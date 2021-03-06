﻿Imports System.Net.Sockets
Imports System.Threading
Imports System.Text
Imports System.Drawing.Printing

Public Class Form1

    Const ScreenTitle = "Arduino Bank Note Dispenser System"

    Public currentOutstanding As Integer

    '
    Public state As Integer = 0
    Public dataReceived As String  ' temp buffer
    Public isDataReceived As Boolean = False
    Public portName As String = "COM1"
    Public baudRate As String = "9600"
    Public isOpenDebugger As Boolean = False
    Public isSendSerialData As Boolean = False
    Public isDisplayStatus As Boolean = False
    Public isValidCommCommand As Boolean = False
    Public isWaitingToSend As Boolean = False
    Public isWinSockCancel As Boolean = False
    Public winSockReturn As Integer = 0
    ' ### WINSOCK CONTROL
    Public Enum WinsockStatuses
        ''' <summary>
        ''' The Winsock is closed.
        ''' </summary>
        Closed = 0
        ''' <summary>
        ''' The Winsock is listening (TCP for connections, UDP for data).
        ''' </summary>
        Listening = 1
        ''' <summary>
        ''' The Winsock is attempting the resolve the remote host.
        ''' </summary>
        ResolvingHost = 2
        ''' <summary>
        ''' The remote host has been resolved to IP address.
        ''' </summary>
        HostResolved = 3
        ''' <summary>
        ''' The Winsock is attempting to connect to the remote host.
        ''' </summary>
        Connecting = 4
        ''' <summary>
        ''' The Winsock is connected to a remote source (client or server).
        ''' </summary>
        Connected = 5
        ''' <summary>
        ''' The Winsock is attempting to close the connection.
        ''' </summary>
        Closing = 6
    End Enum

    Public tcpClient As TcpClient
    Public clientStream As NetworkStream
    Public isEstablished As Boolean = False
    Public receivedCount As Integer = 0

    Public winsockTcp As String = "127.0.0.1"
    Public winsockPort As Long = 9200
    Public winsockStatus As WinsockStatuses = WinsockStatuses.Closed
    Public winsockBuffer As String
    Public winsockBufferReady As Boolean = False
    Public winsockInterval As Integer = 0
    Public winSockReceived As String = String.Empty
    Public isWinSockGateUp As Boolean = False

    ' ### Winsock Client and Server communication protocol ###
    Const wsEndStringPhp As String = "F"
    Const wsPrintReceiptButton As String = "D"
    Const wsCancelButton As String = "E"
    Const wsErrorMachine As String = "B"
    Const wsEmptyMachine As String = "L"
    Const wsOutstandingMachine As String = "B"
    'Winsock1.LocalPort = 420
    'Read DI/DO     = @01

    'Output 1 open  = #01A001"
    '         Close = #01A000

    'Output 2 open  = #01A101"
    '         Close = #01A100"

    'Output 3 open  = #01A201
    '         Close = #01A200

    'Output 4 open  = #01A301
    '         Close = #01A300

    ' Respone D0 = ">000E" -> Cancel
    ' Respone D1 = ">000D" -> Print Receipt
    ' Respone D2 = ">000B" -> Lost ticket
    ' Respone D3 = ">0007" -> Reserve

    Private Sub closeComport()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
    End Sub
    Private Sub Exit_Win()
        closeComport()
        If winsockStatus = WinsockStatuses.Connected Then
            tcpClient.Close()
        Else
            winsockStatus = WinsockStatuses.Closing
        End If
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Exit_Win()
    End Sub

    Private Sub OfflineSet()


        Me.Text = ScreenTitle & " (Offline)"
        ConnectToolStripMenuItem.Enabled = True
        DisconnectToolStripMenuItem.Enabled = False
        RS232.Text = ""

    End Sub

    Private Sub OnlineSet()

        Me.Text = ScreenTitle
        ConnectToolStripMenuItem.Enabled = False
        DisconnectToolStripMenuItem.Enabled = True
    End Sub

    Private Function ctext(ByVal input_text As String) As Integer
        '
        ' delivery message to status bar
        '
        Status.Text = input_text
        isDisplayStatus = True
        tmr_status.Enabled = True

    End Function

    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        Try
            SerialPort1.Close()
        Catch ex As Exception
            MsgBox("Error: " & e.ToString, MsgBoxStyle.Critical, "SerialPort Connection")
        End Try
        OfflineSet()
        ctext(SerialPort1.PortName & " closed")
    End Sub

    Private Sub sendSerial(ByRef serialData As String)
        If (SerialPort1.IsOpen) Then
            SerialPort1.Write(serialData)
        Else
            ctext("Serial communication not established")
        End If
    End Sub

    Private Sub Connect(ByVal portName As String)

        Try
            SerialPort1.Close()
        Catch ex As Exception
        End Try
        Try
            With SerialPort1
                .PortName = portName
                .BaudRate = 9600 ' 9600 baud rate
                .DataBits = 8
                .Parity = IO.Ports.Parity.None
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                '.ReadBufferSize = 1
                .ReceivedBytesThreshold = 1    ' receive 1024 byte per strings 
                .Open()
                RS232.Text = portName & "," & .BaudRate & "," & .DataBits & "," & .Parity & "," & .StopBits
            End With
            OnlineSet()   ' set to online mode
            sendSerial("#")
            state = 1     ' connected
            tmr_state.Interval = 3000 '2 second waiting time
            OpenComReady()
        Catch ex As Exception
            If SerialPort1.IsOpen = True Then
                ctext(SerialPort1.PortName & " : " & SerialPort1.BaudRate & "," & SerialPort1.DataBits & "," & SerialPort1.Parity & "," & SerialPort1.StopBits)
                OnlineSet()   ' set to online mode                
            Else
                MsgBox("Error: " & ErrorToString(), MsgBoxStyle.Critical, "Unable to open port ! ")
                OfflineSet()
            End If
        End Try


    End Sub

    Private Sub COM1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM1ToolStripMenuItem.Click
        Connect("COM1")
    End Sub

    Private Sub COM2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM2ToolStripMenuItem.Click
        Connect("COM2")
    End Sub

    Private Sub COM3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM3ToolStripMenuItem.Click
        Connect("COM3")
    End Sub

    Private Sub COM4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM4ToolStripMenuItem.Click
        Connect("COM4")
    End Sub

    Private Sub COM5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM5ToolStripMenuItem.Click
        Connect("COM5")
    End Sub

    Private Sub COM6ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM6ToolStripMenuItem.Click
        Connect("COM6")
    End Sub

    Private Sub COM7ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM7ToolStripMenuItem.Click
        Connect("COM7")
    End Sub

    Private Sub COM8ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM8ToolStripMenuItem.Click
        Connect("COM8")
    End Sub

    Private Sub COM9ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM9ToolStripMenuItem.Click
        Connect("COM9")
    End Sub

    Private Sub COM10ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM10ToolStripMenuItem.Click
        Connect("COM10")
    End Sub

    Private Sub COM11ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM11ToolStripMenuItem.Click
        Connect("COM11")
    End Sub

    Private Sub COM12ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM12ToolStripMenuItem.Click
        Connect("COM12")
    End Sub

    Private Sub COM13ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM13ToolStripMenuItem.Click
        Connect("COM13")
    End Sub

    Private Sub COM14ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM14ToolStripMenuItem.Click
        Connect("COM14")
    End Sub

    Private Sub COM15ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COM15ToolStripMenuItem.Click
        Connect("COM15")
    End Sub

    Private Sub CUSTOM1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOM1ToolStripMenuItem.Click
        Connect(CUSTOM1ToolStripMenuItem.Text)
    End Sub

    Private Sub CUSTOM2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOM2ToolStripMenuItem.Click
        Connect(CUSTOM2ToolStripMenuItem.Text)
    End Sub

    Private Sub CUSTOM3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOM3ToolStripMenuItem.Click
        Connect(CUSTOM3ToolStripMenuItem.Text)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        closeComport()
        Try
            tcpClient.Close()
            winsockStatus = WinsockStatuses.Closed
        Catch ex As Exception

        End Try
        Environment.Exit(1)
    End Sub

    Private Sub GetComport()
        '*********** reset comport menu
        COM1ToolStripMenuItem.Enabled = False
        COM1ToolStripMenuItem.Visible = False
        COM2ToolStripMenuItem.Enabled = False
        COM2ToolStripMenuItem.Visible = False
        COM3ToolStripMenuItem.Enabled = False
        COM3ToolStripMenuItem.Visible = False
        COM4ToolStripMenuItem.Enabled = False
        COM4ToolStripMenuItem.Visible = False
        COM5ToolStripMenuItem.Enabled = False
        COM5ToolStripMenuItem.Visible = False
        COM6ToolStripMenuItem.Enabled = False
        COM6ToolStripMenuItem.Visible = False
        COM7ToolStripMenuItem.Enabled = False
        COM7ToolStripMenuItem.Visible = False
        COM8ToolStripMenuItem.Enabled = False
        COM8ToolStripMenuItem.Visible = False
        COM9ToolStripMenuItem.Enabled = False
        COM9ToolStripMenuItem.Visible = False
        COM10ToolStripMenuItem.Enabled = False
        COM10ToolStripMenuItem.Visible = False
        COM11ToolStripMenuItem.Enabled = False
        COM11ToolStripMenuItem.Visible = False
        COM12ToolStripMenuItem.Enabled = False
        COM12ToolStripMenuItem.Visible = False
        COM13ToolStripMenuItem.Enabled = False
        COM13ToolStripMenuItem.Visible = False
        COM14ToolStripMenuItem.Enabled = False
        COM14ToolStripMenuItem.Visible = False
        COM15ToolStripMenuItem.Enabled = False
        COM15ToolStripMenuItem.Visible = False
        CUSTOM1ToolStripMenuItem.Enabled = True
        CUSTOM1ToolStripMenuItem.Visible = False
        CUSTOM2ToolStripMenuItem.Enabled = False
        CUSTOM2ToolStripMenuItem.Visible = False
        CUSTOM3ToolStripMenuItem.Enabled = False
        CUSTOM3ToolStripMenuItem.Visible = False
        '*********** lookup comport
        Dim available = System.IO.Ports.SerialPort.GetPortNames()
        For Each Name As String In available
            If Name = COM1ToolStripMenuItem.Text Then
                COM1ToolStripMenuItem.Enabled = True
                COM1ToolStripMenuItem.Visible = True
            ElseIf Name = COM2ToolStripMenuItem.Text Then
                COM2ToolStripMenuItem.Enabled = True
                COM2ToolStripMenuItem.Visible = True
            ElseIf Name = COM3ToolStripMenuItem.Text Then
                COM3ToolStripMenuItem.Enabled = True
                COM3ToolStripMenuItem.Visible = True
            ElseIf Name = COM4ToolStripMenuItem.Text Then
                COM4ToolStripMenuItem.Enabled = True
                COM4ToolStripMenuItem.Visible = True
            ElseIf Name = COM5ToolStripMenuItem.Text Then
                COM5ToolStripMenuItem.Enabled = True
                COM5ToolStripMenuItem.Visible = True
            ElseIf Name = COM6ToolStripMenuItem.Text Then
                COM6ToolStripMenuItem.Enabled = True
                COM6ToolStripMenuItem.Visible = True
            ElseIf Name = COM7ToolStripMenuItem.Text Then
                COM7ToolStripMenuItem.Enabled = True
                COM7ToolStripMenuItem.Visible = True
            ElseIf Name = COM8ToolStripMenuItem.Text Then
                COM8ToolStripMenuItem.Enabled = True
                COM8ToolStripMenuItem.Visible = True
            ElseIf Name = COM9ToolStripMenuItem.Text Then
                COM9ToolStripMenuItem.Enabled = True
                COM9ToolStripMenuItem.Visible = True
            ElseIf Name = COM10ToolStripMenuItem.Text Then
                COM10ToolStripMenuItem.Enabled = True
                COM10ToolStripMenuItem.Visible = True
            ElseIf Name = COM11ToolStripMenuItem.Text Then
                COM11ToolStripMenuItem.Enabled = True
                COM11ToolStripMenuItem.Visible = True
            ElseIf Name = COM12ToolStripMenuItem.Text Then
                COM12ToolStripMenuItem.Enabled = True
                COM12ToolStripMenuItem.Visible = True
            ElseIf Name = COM13ToolStripMenuItem.Text Then
                COM13ToolStripMenuItem.Enabled = True
                COM13ToolStripMenuItem.Visible = True
            ElseIf Name = COM14ToolStripMenuItem.Text Then
                COM14ToolStripMenuItem.Enabled = True
                COM14ToolStripMenuItem.Visible = True
            ElseIf Name = COM15ToolStripMenuItem.Text Then
                COM15ToolStripMenuItem.Enabled = True
                COM15ToolStripMenuItem.Visible = True
                '**** custom comport
            ElseIf CUSTOM1ToolStripMenuItem.Text = "CUSTOM1" Then
                CUSTOM1ToolStripMenuItem.Text = Name
                CUSTOM1ToolStripMenuItem.Enabled = True
                CUSTOM1ToolStripMenuItem.Visible = True
            ElseIf CUSTOM2ToolStripMenuItem.Text = "CUSTOM1" Then
                CUSTOM2ToolStripMenuItem.Text = Name
                CUSTOM2ToolStripMenuItem.Enabled = True
                CUSTOM2ToolStripMenuItem.Visible = True
            ElseIf CUSTOM3ToolStripMenuItem.Text = "CUSTOM1" Then
                CUSTOM3ToolStripMenuItem.Text = Name
                CUSTOM3ToolStripMenuItem.Enabled = True
                CUSTOM3ToolStripMenuItem.Visible = True
            End If
            portName = Name
        Next
        TxtComport.Text = portName + "," + baudRate + ",N,8,1"
    End Sub

    Private Sub setComportMenu()

        OfflineSet()  ' set to offline mode
        GetComport()  ' search available comport
        If COM1ToolStripMenuItem.Enabled = False And _
           COM2ToolStripMenuItem.Enabled = False And _
           COM3ToolStripMenuItem.Enabled = False And _
           COM4ToolStripMenuItem.Enabled = False And _
           COM5ToolStripMenuItem.Enabled = False And _
           COM6ToolStripMenuItem.Enabled = False And _
           COM7ToolStripMenuItem.Enabled = False And _
           COM8ToolStripMenuItem.Enabled = False And _
           COM9ToolStripMenuItem.Enabled = False And _
           COM10ToolStripMenuItem.Enabled = False And _
           COM11ToolStripMenuItem.Enabled = False And _
           COM12ToolStripMenuItem.Enabled = False And _
           COM13ToolStripMenuItem.Enabled = False And _
           COM14ToolStripMenuItem.Enabled = False And _
           COM15ToolStripMenuItem.Enabled = False And _
           CUSTOM1ToolStripMenuItem.Enabled = False And _
           CUSTOM2ToolStripMenuItem.Enabled = False And _
           CUSTOM3ToolStripMenuItem.Enabled = False Then
            MsgBox("No available comport !" & vbNewLine & "Plug-in USB Serial Converter (if any)", vbCritical, "Comport Search Result")
            ConnectToolStripMenuItem.Enabled = False
        Else
            ConnectToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub OpenComReady()
        TxtComport.Text = portName + "," + baudRate + ",N,8,1"
        TxtComport.Enabled = True
        BtnCloseCom.Enabled = False
        BtnOpenCom.Enabled = True
        ButtonSendSerial.Enabled = False
    End Sub

    Private Sub CloseComReady()
        TxtComport.Enabled = False
        BtnCloseCom.Enabled = True
        BtnOpenCom.Enabled = False
        ButtonSendSerial.Enabled = True
    End Sub

    Private Sub MenuItemClicked(ByVal sender As System.Windows.Forms.ToolStripMenuItem, ByVal e As EventArgs)
        Dim dataArray As String() = sender.Text.Split(" ")
        For Each company As printHeader In listOfCompany
            If company.MachineId = dataArray(0) And company.SiteName = dataArray(1) Then
                textSiteName.Text = company.SiteName
                textMachineName.Text = company.MachineId
                textCompanyName.Text = company.CompanyName
                textContact.Text = company.ContactNumber
                textAddress01.Text = company.Address01
                textAddress02.Text = company.Address02
                textAddress03.Text = company.Address03
            End If
        Next
    End Sub

    Private Sub AddSubMenu()

        Dim subItem As ToolStripMenuItem
        Dim starter As Integer = 0
        For Each company As printHeader In listOfCompany
            subItem = New ToolStripMenuItem(company.MachineId & " " & company.SiteName)
            CompanyToolStripMenuItem.DropDownItems.Add(subItem)
            AddHandler subItem.Click, AddressOf MenuItemClicked
            If starter = 0 Then
                textSiteName.Text = company.SiteName
                textMachineName.Text = company.MachineId
                textCompanyName.Text = company.CompanyName
                textContact.Text = company.ContactNumber
                textAddress01.Text = company.Address01
                textAddress02.Text = company.Address02
                textAddress03.Text = company.Address03
                ' do it for first record only
                starter = starter + 1
            End If
        Next

    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GetCompany()
        ' add menu items
        AddSubMenu()
        setComportMenu()
        tmr_status.Enabled = True
        isOpenDebugger = False
        Me.Width = 600
        ' default printer
        Dim settings As New PrinterSettings
        If String.IsNullOrEmpty(settings.PrinterName) = False Then
            DefaultToolStripMenuItem.Text = settings.PrinterName
            DefaultToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub BtnOpenCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpenCom.Click
        Dim dataArray As String() = TxtComport.Text.Split(",")
        Dim _portName = dataArray(0)
        Dim _baudRate = dataArray(1)
        Dim _parityStr = dataArray(2)
        Dim _dataBits = dataArray(3)
        Dim _stopBits = dataArray(4)

        Try
            SerialPort1.Close()
        Catch ex As Exception
        End Try
        Try
            With SerialPort1
                .PortName = _portName
                .BaudRate = _baudRate
                .DataBits = _dataBits
                .Parity = IO.Ports.Parity.None ' assume is N by default
                .StopBits = _stopBits
                .Handshake = IO.Ports.Handshake.None
                '.ReadBufferSize = 1
                .ReceivedBytesThreshold = 1    ' receive 1024 byte per strings 
                .Open()
                RS232.Text = portName & "," & .BaudRate & "," & .DataBits & "," & .Parity & "," & .StopBits
            End With
            CloseComReady()
            OnlineSet()   ' set to online mode
            sendSerial("#")
            state = 1     ' connected
            tmr_state.Interval = 3000 '2 second waiting time
        Catch ex As Exception
            If SerialPort1.IsOpen = True Then
                ctext(SerialPort1.PortName & " : " & SerialPort1.BaudRate & "," & SerialPort1.DataBits & "," & SerialPort1.Parity & "," & SerialPort1.StopBits)
                OnlineSet()   ' set to online mode                
            Else
                MsgBox("Error: " & ErrorToString(), MsgBoxStyle.Critical, "Unable to open port ! ")
                OfflineSet()
            End If
        End Try

    End Sub

    Private Sub BtnCloseCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseCom.Click
        Try
            SerialPort1.Close()
        Catch ex As Exception
            MsgBox("Error: " & e.ToString, MsgBoxStyle.Critical, "SerialPort Connection")
        End Try
        OpenComReady()
        OfflineSet()
        ctext(SerialPort1.PortName & " closed")
    End Sub

    Private Sub tmr_status_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_status.Tick
        ' ### STATUS
        If isDisplayStatus Then
            Status.Text = Nothing
            tmr_status.Enabled = False
        End If
        ' ### COMPORT
        If SerialPort1.IsOpen Then ' connected to state 1
            If state = 1 Then
                Status.Text = "Please wait for WinSock initialization"
                CloseComReady()
                tmr_status.Enabled = False
            Else
                Status.Text = Nothing
            End If
        Else
            Status.Text = "Please select comport to establish connection with device"
        End If
        ' ### DEBUGGER Screen width adjustment
        If isOpenDebugger And Me.Width <= 600 Then
            Me.Width = 1000
        ElseIf Not isOpenDebugger And Me.Width > 600 Then
            Me.Width = 600
        End If

    End Sub

    Private Function getMachineStatus(ByRef stat As String) As String
        If stat = "X" Then
            Return "Error"
        ElseIf stat = "E" Then
            Return "Empty"
        ElseIf stat = "P" Then
            Return "Paid"
        ElseIf stat = "I" Then
            Return "Idle"
        ElseIf stat = "V" Then
            Return "Outstanding"
        ElseIf stat = "O" Then
            Return "Overpaid"
        End If
        Return "Error"
    End Function

    Private Sub LogMessage(ByVal val1 As String, ByVal val2 As String)
        TextLogScreen.AppendText(Now.ToString())
        TextLogScreen.AppendText("> ")
        TextLogScreen.AppendText(" Slot01 Status:")
        TextLogScreen.AppendText(textStatSlot01.Text)
        TextLogScreen.AppendText(" RM:")
        TextLogScreen.AppendText(val1)
        TextLogScreen.AppendText(" | Slot02 Status:")
        TextLogScreen.AppendText(textStatSlot02.Text)
        TextLogScreen.AppendText(" RM:")
        TextLogScreen.AppendText(val2)
        TextLogScreen.AppendText(vbCrLf)
    End Sub

    Private Sub LogLineMessage(ByVal msg As String)
        TextLogScreen.AppendText(Now.ToString())
        TextLogScreen.AppendText("> ")
        TextLogScreen.AppendText(msg)
        TextLogScreen.AppendText(vbCrLf)
    End Sub

    Private Sub LogDataMessage(ByVal msg As String)
        TextLogScreen.AppendText(Now.ToString())
        TextLogScreen.AppendText("> ")
        TextLogScreen.AppendText(msg)
    End Sub

    Private Sub tmr_state_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_state.Tick
        Select Case state
            Case 0
                ' ### Wait for step 1
                tmr_state.Interval = 350 ' repeat in short seconds
            Case 1
                ' ### Wait for step 2
                tmr_status.Enabled = True
                LogLineMessage("Comport configure as " & RS232.Text)
                ' ## Open winsock
                tmr_winsock.Enabled = True ' enable winsock
                state = 2
            Case 2
                tmr_state.Interval = 350 ' repeat in short seconds
                state = 3
            Case 3
                LogLineMessage("Winsock server start at " & winsockTcp & ":" & winsockPort)
                state = 4
                If isDataReceived Then
                    If dataReceived.StartsWith("LABEL") Then
                        ctext(dataReceived)
                        state = 4
                    End If
                End If
            Case 4
                ctext("Hardware Linked")
                tmr_state.Interval = 100 ' repeat in short seconds
                state = 5
            Case 5
                If isSendSerialData Then
                    sendSerial(TextSendSerial.Text)
                    TextSendSerial.Enabled = True ' animate textbox
                    isSendSerialData = False
                End If
                If isDataReceived Then
                    If dataReceived.StartsWith("BUTTON") Then
                        Dim dataArray As String() = dataReceived.Split(",")
                        textSerialReceived.Text = dataArray(1)
                        If dataArray(1) = "RECEIPT" Then
                            ctext("print receipt")
                            AppendWinSockStatus(wsPrintReceiptButton)
                        ElseIf dataArray(1) = "CANCEL" Then
                            ctext("cancelled process")
                            AppendWinSockStatus(wsCancelButton)
                        ElseIf dataArray(1) = "EXTRA" Then
                            ctext("button - extra")
                        End If
                        isValidCommCommand = True
                        LogLineMessage(dataReceived)
                    End If
                    If dataReceived.StartsWith("DATA") Then
                        Dim dataArray As String() = dataReceived.Split(",")
                        ' ### SLOT 01
                        If dataArray(1) = "P" Then
                            textStatSlot01.Text = getMachineStatus(dataArray(1))
                            textAmtSlot01.Text = Val(textAmtSlot01.Text) + Val(dataArray(2))
                            'textOSlot01.Text = "0"
                            'textVSlot01.Text = "0"
                            LogMessage(dataArray(2), dataArray(4))
                        ElseIf dataArray(1) = "V" Then
                            textStatSlot01.Text = getMachineStatus(dataArray(1))
                            'textAmtSlot01.Text = "0"
                            'textOSlot01.Text = "0"
                            textVSlot01.Text = Val(textVSlot01.Text) + Val(dataArray(2))
                            currentOutstanding = Val(dataArray(2))
                            LogMessage(dataArray(2), dataArray(4))
                            AppendWinSockStatus(wsOutstandingMachine)
                            ' print outstanding
                            printOutstanding()

                        ElseIf dataArray(1) = "O" Then
                            textStatSlot01.Text = getMachineStatus(dataArray(1))
                            'textAmtSlot01.Text = "0"
                            textOSlot01.Text = Val(textOSlot01.Text) + Val(dataArray(2))
                            'textVSlot01.Text = "0"
                            LogMessage(dataArray(2), dataArray(4))
                        ElseIf dataArray(1) = "E" Then
                            AppendWinSockStatus(wsEmptyMachine)
                        ElseIf dataArray(1) = "X" Then
                            AppendWinSockStatus(wsErrorMachine)
                        End If
                        ' ### SLOT 02
                        If dataArray(3) = "P" Then
                            textStatSlot02.Text = getMachineStatus(dataArray(3))
                            textAmtSlot02.Text = Val(textAmtSlot02.Text) + Val(dataArray(4))
                            'textOSlot02.Text = "0"
                            'textVSlot02.Text = "0"
                        ElseIf dataArray(3) = "V" Then
                            textStatSlot02.Text = getMachineStatus(dataArray(3))
                            'textAmtSlot02.Text = "0"
                            'textOSlot02.Text = "0"
                            textVSlot02.Text = Val(textVSlot02.Text) + Val(dataArray(4))
                        ElseIf dataArray(3) = "O" Then
                            textStatSlot02.Text = getMachineStatus(dataArray(3))
                            'textAmtSlot02.Text = "0"
                            textOSlot02.Text = Val(textOSlot02.Text) + Val(dataArray(4))
                            'textVSlot02.Text = "0"
                        End If
                        isValidCommCommand = True
                    End If
                    ' ### Add to debugger screen
                    If isOpenDebugger Then
                        Dim selStart As Integer = RichTextLogger.TextLength
                        Dim selLength As Integer = dataReceived.Length
                        RichTextLogger.AppendText(dataReceived)
                        RichTextLogger.Select(selStart, selLength)
                        If isValidCommCommand Then
                            RichTextLogger.SelectionColor = Color.DarkBlue ' this is command string
                        Else
                            RichTextLogger.SelectionColor = Color.Green    ' this is comments or debug output
                        End If
                    End If
                    isDataReceived = False ' process data onetime only
                    isValidCommCommand = False
                End If

        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        isOpenDebugger = Not isOpenDebugger
        ctext("Toggle debugger screen")
        If SerialPort1.IsOpen Then
            Button1.Text = "Close Debugger"
            TextSendSerial.Enabled = True
            ButtonSendSerial.Enabled = True
        Else
            Button1.Text = "Open Debugger"
            TextSendSerial.Enabled = True
            ButtonSendSerial.Enabled = False
        End If
    End Sub

    Private Sub ButtonSendSerial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSendSerial.Click
        TextSendSerial.Enabled = False
        isSendSerialData = True
    End Sub

    Private Sub BUTTON_RECEIPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTTON_RECEIPT.Click
        ctext("print receipt")
        AppendWinSockStatus(wsPrintReceiptButton)
    End Sub

    Private Sub BUTTON_CANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUTTON_CANCEL.Click
        ctext("cancelled process")
        AppendWinSockStatus(wsCancelButton)
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        '
        ' Integrated system with embedded system
        '
        dataReceived = SerialPort1.ReadLine
        dataReceived = dataReceived.Replace(vbNewLine, "")   ' remove newline

        isDataReceived = True
    End Sub

#Region " UI Handlers "

    Private Sub AppendWinSockStatus(ByVal input As String)
        TextWinsockPending.Text = input
        ' ### enabled auto-send ?
        'isWaitingToSend = True
    End Sub

    Private Sub Winsock_ConnectionRequest()
        Dim listenThread As New Thread(New ThreadStart(AddressOf ListenForClients))
        winsockStatus = WinsockStatuses.Listening
        listenThread.Start()

        'LogLineMessage("Winsock_ConnectionRequest::winsockStatus: " & winsockStatus)
        'LogLineMessage("Winsock_ConnectionRequest::winsockStatus...")

    End Sub

    Private Sub ListenForClients()
        ' This method calls the IPAddress.Parse method to check the ipAddress 
        ' input string. If the ipAddress argument represents a syntatical correct IPv4 or
        ' IPv6 address, the method displays the Parse output into quad-notation or
        ' colon-hexadecimal notation, respectively. Otherwise, it displays an 
        ' error message.

        'LogLineMessage("ListenForClients::winsockStatus: " & winsockStatus)
        'LogLineMessage("ListenForClients::winsockStatus 1... ")

        Try
            ' Create an instance of IPAddress for the specified address string (in 
            ' dotted-quad, or colon-hexadecimal notation).
            Dim ipAddress As System.Net.IPAddress = System.Net.IPAddress.Parse(winsockTcp)
            Dim ipLocalEndPoint As New System.Net.IPEndPoint(ipAddress, winsockPort)

            winsockStatus = WinsockStatuses.ResolvingHost
            Dim serverSocket As System.Net.Sockets.TcpListener = New TcpListener(ipLocalEndPoint)

            winsockStatus = WinsockStatuses.HostResolved
            serverSocket.Start()

            'LogLineMessage("ListenForClients::winsockStatus start: " & winsockStatus)
            'LogLineMessage("ListenForClients::winsockStatus 2... ")

            While True  'blocks until a client has connected to the server
                Dim client As TcpClient = serverSocket.AcceptTcpClient()
                Dim clientThread As New Thread(New ParameterizedThreadStart(AddressOf HandleClientComm))

                winsockStatus = WinsockStatuses.Connecting
                clientThread.Start(client)
            End While

        Catch ex As Exception

            'LogLineMessage("ListenForClients::winsockStatus Exception: " & winsockStatus)

        End Try
    End Sub

    Private Sub HandleClientComm(ByVal client As Object)
        tcpClient = DirectCast(client, TcpClient)
        clientStream = tcpClient.GetStream()
        winsockStatus = WinsockStatuses.Connected

        Dim message As Byte() = New Byte(4095) {}
        Dim bytesRead As Integer

        'LogLineMessage("HandleClientComm::winsockStatus start: " & winsockStatus)

        Try
            While True
                isEstablished = True
                bytesRead = 0
                bytesRead = clientStream.Read(message, 0, 4096) 'blocks until a client sends a message
                receivedCount = receivedCount + 1
                If receivedCount >= 1000 Then
                    receivedCount = 0
                End If
                If bytesRead = 0 Then
                    Exit While 'the client has disconnected from the server
                End If
                ' Encode using ASCII 
                ' Truncate string as of size of byte read
                ' Remove line feed
                winsockBuffer = System.Text.Encoding.ASCII.GetString(message).Substring(0, bytesRead).Replace(Chr(10), "").Replace(Chr(13), "").TrimEnd
                winsockBufferReady = True

                ' CAPTURE PRECISE DATA
                If winsockBuffer = "GATEUP" Then
                    ' do something
                    isWinSockGateUp = True
                ElseIf winsockBuffer.StartsWith("RM1:") Then
                    winSockReceived = winsockBuffer.Substring(4)
                ElseIf winsockBuffer = "RL3_1" Then
                    'WinSockSendSerial("0")
                    isWinSockCancel = True
                ElseIf winsockBuffer = "RL3_0" Then
                    'WinSockSendSerial("1")
                    winSockReturn = winSockReturn + 1
                    isWinSockCancel = True
                End If

                If winsockStatus <> WinsockStatuses.Connected Or winsockStatus <> WinsockStatuses.Connecting Then
                    ' break loop if no longer in connect mode
                    ' allow listening (connecting without client/server, broadcasting)
                    Exit While
                End If
            End While

        Catch ex As Exception

        End Try
        
        winsockStatus = WinsockStatuses.Closing


    End Sub

    Private Function Winsock_Get() As String
        If winsockBufferReady Then
            winsockBufferReady = False ' read Winsock once per time
            Return winsockBuffer
        End If
        Return ""
    End Function

    Private Sub Winsock_Send(ByVal serverResponse As String)
        Dim encoder As New ASCIIEncoding()
        Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(serverResponse)
        If winsockStatus = WinsockStatuses.Connected Then
            clientStream.Write(sendBytes, 0, sendBytes.Length)
        Else
            LogLineMessage("Unable to send: Winsock server is not connected to any client")
        End If
    End Sub

    Private Sub SendWinSockData()
        If TextWinsockPending.Text <> "" Then
            Winsock_Send(TextWinsockPending.Text)
            TextWinsockReady.Text = TextWinsockPending.Text
            TextWinsockPending.Text = ""
        Else
            If winsockInterval >= 10 Then    ' send response every tmr_winsock.interval x 10 = 2000 milliseconds/ 2 seconds
                Winsock_Send(wsEndStringPhp) 'each message is end with "F", user-defined protocol
                TextWinsockReady.Text = wsEndStringPhp
                winsockInterval = 0
            Else
                winsockInterval = winsockInterval + 1
            End If

        End If
    End Sub

    Private Sub WinSockSendSerial(ByVal input As String)
        TextSendSerial.Text = input
        TextSendSerial.Enabled = False
        isSendSerialData = True

    End Sub

    Private Sub ProcessWinSockData(ByVal sData As String)
        'Dim retVal As String = String.Empty

        'isWaitingToSend 
        TextWinSockResp.Text = sData
        If sData = "btn_status" Then
            isWaitingToSend = True ' every request must response, if no data to send , send end string F instead
            ButtonWinSock.Enabled = True
        Else
            If sData <> "" Then
                LogLineMessage("AUTOPAY REQUEST : " & sData)
            End If
        End If
        ' CAPTURE PRECISE DATA - HandleClientComm()
        ' Payment as string
        If isWinSockCancel = True Then
            isWinSockCancel = False
        ElseIf isWinSockCancel = False And winSockReturn > 0 Then
            Dim paymentZeroChar As Integer = 48 ' character zero
            Dim paymentReturn As Integer = 0
            Dim paymentChar As Char
            Try
                paymentReturn = winSockReturn
                winSockReturn = 0 ' reset to zero
                isWinSockCancel = False ' reset send
                If paymentReturn > 0 Then
                    paymentChar = Chr(paymentZeroChar + paymentReturn)
                    WinSockSendSerial(CStr(paymentChar))
                    LogLineMessage("Cancel and return at dispenser: " & paymentReturn)
                End If

            Catch ex As Exception
                paymentReturn = 0
            End Try
        End If

        If isWinSockGateUp = True Then
            ' Gate up , do something
            LogLineMessage("GATE UP: Done")
            isWinSockGateUp = False
        End If

        If winSockReceived = String.Empty Then
            Exit Sub
        Else
            Dim paymentZeroChar As Integer = 48 ' character zero
            Dim paymentReturn As Integer = 0
            Dim paymentChar As Char
            Try
                paymentReturn = Val(winSockReceived)
                If paymentReturn > 0 Then
                    paymentChar = Chr(paymentZeroChar + paymentReturn)
                    WinSockSendSerial(CStr(paymentChar))
                    LogLineMessage("Proceed dispenser: " & paymentReturn)
                End If
            Catch ex As Exception
                paymentReturn = 0
            End Try

            winSockReceived = String.Empty

        End If
        
    End Sub

    Private Sub tmr_wsListen_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_wsListen.Tick
        ' this is a permanent loop
        ' code execution will trap within
        tmr_wsListen.Enabled = False
        Winsock_ConnectionRequest()
    End Sub

    Private Sub tmr_winsock_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_winsock.Tick

        ' attempt to get data
        If winsockBufferReady Then
            winsockStatus = WinsockStatuses.Connected
            Dim sData As String = Winsock_Get()
            If TextWinsockPending.Text = "wait for client connection" Then
                TextWinsockPending.Text = ""
            End If
            ProcessWinSockData(sData)
            TextCount.Text = receivedCount

        End If

        If winsockStatus = WinsockStatuses.Closed Then
            pngWinSock.Hide()
            ButtonWinSock.Enabled = False
            ' enable winsock listen()
            tmr_wsListen.Enabled = True
            If Not isEstablished Then TextWinsockPending.Text = "not ready"
            Button4.Enabled = False

        ElseIf winsockStatus = WinsockStatuses.HostResolved Then
            ' attempt to get client
            pngWinSock.Visible = Not pngWinSock.Visible
            If Not isEstablished Then TextWinsockPending.Text = "wait for client connection"

        ElseIf winsockStatus = WinsockStatuses.Connected Then
            pngWinSock.Show()
            ButtonWinSock.Enabled = True
            Button4.Enabled = True

        ElseIf winsockStatus = WinsockStatuses.Closing Then
            tcpClient.Close()
            winsockStatus = WinsockStatuses.Closed

        End If
        ' nothing to send then close winsock
        If winsockStatus = WinsockStatuses.Connected Then
            If isWaitingToSend Then
                SendWinSockData()
                isWaitingToSend = False
            Else
                winsockStatus = WinsockStatuses.Closing
            End If
        End If

    End Sub

    Private Sub ButtonWinSock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWinSock.Click
        SendWinSockData()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If winsockStatus = WinsockStatuses.Connected Then
            winsockStatus = WinsockStatuses.Closing
        End If
    End Sub

#End Region

    Private Sub LabelExpand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelExpand.Click
        If LabelExpand.Text = "+" Then
            LabelExpand.Text = "-"
            RichTextLogger.Height = 600
            GroupBox6.Height = 652
            Me.Height = 750
            GroupBox7.Show()
        Else
            LabelExpand.Text = "+"
            RichTextLogger.Height = 380
            GroupBox6.Height = 433
            Me.Height = 550
            GroupBox7.Hide()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextLogger.Clear()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextLogScreen.Clear()

    End Sub


    Private Sub bAmtSlot01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAmtSlot01.Click
        textAmtSlot01.Text = "0"
    End Sub

    Private Sub bVSlot01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bVSlot01.Click
        textVSlot01.Text = "0"
    End Sub

    Private Sub bOSlot01_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOSlot01.Click
        textOSlot01.Text = "0"
    End Sub

    Private Sub bAmtSlot02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAmtSlot02.Click
        textAmtSlot02.Text = "0"
    End Sub

    Private Sub bVSlot02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bVSlot02.Click
        textVSlot02.Text = "0"
    End Sub

    Private Sub bOSlot02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bOSlot02.Click
        textOSlot02.Text = "0"
    End Sub

    Private Sub printOutstanding()
        'Prints the desired text to the default printer using the default font
        Dim printString As String
        Dim invoiceNo As String
        Dim currentDate As String = Now.ToString("yyyy-MM-dd HH:mm:ss")
        invoiceNo = Invoice.GetInvoice() ' auto-increment

        printString = ""
        printString = printString & textMachineName.Text
        printString = printString & vbNewLine
        printString = printString & textCompanyName.Text
        printString = printString & vbNewLine
        printString = printString & textAddress01.Text
        printString = printString & vbNewLine
        printString = printString & textAddress02.Text
        printString = printString & vbNewLine
        printString = printString & textAddress03.Text
        printString = printString & vbNewLine
        printString = printString & textContact.Text
        printString = printString & vbNewLine
        printString = printString & textSiteName.Text
        printString = printString & vbNewLine
        printString = printString & vbNewLine
        printString = printString & vbNewLine
        printString = printString & "_________________________________________"
        printString = printString & vbNewLine
        printString = printString & vbNewLine
        printString = printString & "VOUCHER NO  : " & invoiceNo
        printString = printString & vbNewLine
        printString = printString & "DATE IN             : " & currentDate
        printString = printString & vbNewLine
        printString = printString & "AMOUNT           : " & "RM " & currentOutstanding.ToString() & ".00"
        printString = printString & vbNewLine
        printString = printString & vbNewLine
        printString = printString & vbNewLine
        printString = printString & "Please proceed to counter to redempt your"
        printString = printString & vbNewLine
        printString = printString & "balance amount"
        printString = printString & vbNewLine
        printString = printString & vbNewLine
        printString = printString & vbNewLine

        defaultPrinter.Print(printString)
        ' log
        Dim logMessage As String
        logMessage = "VOUCHER NO:" & invoiceNo & " with amount RM" & currentOutstanding.ToString() & ".00" & " at " & currentDate

        Invoice.Log(textMachineName.Text & "," & textSiteName.Text & " > " & logMessage)
        LogLineMessage(logMessage)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        printOutstanding()
    End Sub

    Private Sub WindowsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WindowsToolStripMenuItem.Click

    End Sub


End Class

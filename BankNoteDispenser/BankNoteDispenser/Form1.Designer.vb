<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.RS232 = New System.Windows.Forms.ToolStripStatusLabel
        Me.Status = New System.Windows.Forms.ToolStripStatusLabel
        Me.SerialText = New System.Windows.Forms.ToolStripStatusLabel
        Me.tmr_state = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.tmr_status = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InterfaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM6ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM7ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM8ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM9ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM10ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM11ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM12ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM13ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM14ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.COM15ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CUSTOM1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CUSTOM2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CUSTOM3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisconnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrinterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnCloseCom = New System.Windows.Forms.Button
        Me.BtnOpenCom = New System.Windows.Forms.Button
        Me.TxtComport = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextCount = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextWinsockReady = New System.Windows.Forms.TextBox
        Me.ButtonWinSock = New System.Windows.Forms.Button
        Me.pngWinSock = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextWinSockResp = New System.Windows.Forms.TextBox
        Me.TextWinsockPending = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.bOSlot02 = New System.Windows.Forms.Button
        Me.bVSlot02 = New System.Windows.Forms.Button
        Me.bAmtSlot02 = New System.Windows.Forms.Button
        Me.textOSlot02 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.textVSlot02 = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.textAmtSlot02 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.textStatSlot02 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.bOSlot01 = New System.Windows.Forms.Button
        Me.bVSlot01 = New System.Windows.Forms.Button
        Me.bAmtSlot01 = New System.Windows.Forms.Button
        Me.textOSlot01 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.textVSlot01 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.textAmtSlot01 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.textStatSlot01 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BUTTON_CANCEL = New System.Windows.Forms.Button
        Me.BUTTON_RECEIPT = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.textAddress03 = New System.Windows.Forms.TextBox
        Me.textAddress02 = New System.Windows.Forms.TextBox
        Me.textContact = New System.Windows.Forms.TextBox
        Me.textAddress01 = New System.Windows.Forms.TextBox
        Me.textCompanyName = New System.Windows.Forms.TextBox
        Me.textSiteName = New System.Windows.Forms.TextBox
        Me.textMachineName = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.textSerialReceived = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.ButtonSendSerial = New System.Windows.Forms.Button
        Me.TextSendSerial = New System.Windows.Forms.TextBox
        Me.RichTextLogger = New System.Windows.Forms.RichTextBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.TextLogScreen = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelExpand = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.tmr_winsock = New System.Windows.Forms.Timer(Me.components)
        Me.tmr_wsListen = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pngWinSock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RS232, Me.Status, Me.SerialText})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 690)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(992, 22)
        Me.StatusStrip1.TabIndex = 84
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'RS232
        '
        Me.RS232.Name = "RS232"
        Me.RS232.Size = New System.Drawing.Size(19, 17)
        Me.RS232.Text = "Rx"
        '
        'Status
        '
        Me.Status.ForeColor = System.Drawing.Color.Red
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(39, 17)
        Me.Status.Text = "Status"
        '
        'SerialText
        '
        Me.SerialText.Name = "SerialText"
        Me.SerialText.Size = New System.Drawing.Size(0, 17)
        '
        'tmr_state
        '
        Me.tmr_state.Enabled = True
        Me.tmr_state.Interval = 15000
        '
        'SerialPort1
        '
        '
        'tmr_status
        '
        Me.tmr_status.Interval = 500
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.InterfaceToolStripMenuItem, Me.WindowsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 24)
        Me.MenuStrip1.TabIndex = 83
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'InterfaceToolStripMenuItem
        '
        Me.InterfaceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToolStripMenuItem, Me.DisconnectToolStripMenuItem})
        Me.InterfaceToolStripMenuItem.Name = "InterfaceToolStripMenuItem"
        Me.InterfaceToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.InterfaceToolStripMenuItem.Text = "Interface"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COM1ToolStripMenuItem, Me.COM2ToolStripMenuItem, Me.COM3ToolStripMenuItem, Me.COM4ToolStripMenuItem, Me.COM5ToolStripMenuItem, Me.COM6ToolStripMenuItem, Me.COM7ToolStripMenuItem, Me.COM8ToolStripMenuItem, Me.COM9ToolStripMenuItem, Me.COM10ToolStripMenuItem, Me.COM11ToolStripMenuItem, Me.COM12ToolStripMenuItem, Me.COM13ToolStripMenuItem, Me.COM14ToolStripMenuItem, Me.COM15ToolStripMenuItem, Me.CUSTOM1ToolStripMenuItem, Me.CUSTOM2ToolStripMenuItem, Me.CUSTOM3ToolStripMenuItem})
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ConnectToolStripMenuItem.Text = "Connect"
        '
        'COM1ToolStripMenuItem
        '
        Me.COM1ToolStripMenuItem.Name = "COM1ToolStripMenuItem"
        Me.COM1ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM1ToolStripMenuItem.Text = "COM1"
        '
        'COM2ToolStripMenuItem
        '
        Me.COM2ToolStripMenuItem.Name = "COM2ToolStripMenuItem"
        Me.COM2ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM2ToolStripMenuItem.Text = "COM2"
        '
        'COM3ToolStripMenuItem
        '
        Me.COM3ToolStripMenuItem.Name = "COM3ToolStripMenuItem"
        Me.COM3ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM3ToolStripMenuItem.Text = "COM3"
        '
        'COM4ToolStripMenuItem
        '
        Me.COM4ToolStripMenuItem.Name = "COM4ToolStripMenuItem"
        Me.COM4ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM4ToolStripMenuItem.Text = "COM4"
        '
        'COM5ToolStripMenuItem
        '
        Me.COM5ToolStripMenuItem.Name = "COM5ToolStripMenuItem"
        Me.COM5ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM5ToolStripMenuItem.Text = "COM5"
        '
        'COM6ToolStripMenuItem
        '
        Me.COM6ToolStripMenuItem.Name = "COM6ToolStripMenuItem"
        Me.COM6ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM6ToolStripMenuItem.Text = "COM6"
        '
        'COM7ToolStripMenuItem
        '
        Me.COM7ToolStripMenuItem.Name = "COM7ToolStripMenuItem"
        Me.COM7ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM7ToolStripMenuItem.Text = "COM7"
        '
        'COM8ToolStripMenuItem
        '
        Me.COM8ToolStripMenuItem.Name = "COM8ToolStripMenuItem"
        Me.COM8ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM8ToolStripMenuItem.Text = "COM8"
        '
        'COM9ToolStripMenuItem
        '
        Me.COM9ToolStripMenuItem.Name = "COM9ToolStripMenuItem"
        Me.COM9ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM9ToolStripMenuItem.Text = "COM9"
        '
        'COM10ToolStripMenuItem
        '
        Me.COM10ToolStripMenuItem.Name = "COM10ToolStripMenuItem"
        Me.COM10ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM10ToolStripMenuItem.Text = "COM10"
        '
        'COM11ToolStripMenuItem
        '
        Me.COM11ToolStripMenuItem.Name = "COM11ToolStripMenuItem"
        Me.COM11ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM11ToolStripMenuItem.Text = "COM11"
        '
        'COM12ToolStripMenuItem
        '
        Me.COM12ToolStripMenuItem.Name = "COM12ToolStripMenuItem"
        Me.COM12ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM12ToolStripMenuItem.Text = "COM12"
        '
        'COM13ToolStripMenuItem
        '
        Me.COM13ToolStripMenuItem.Name = "COM13ToolStripMenuItem"
        Me.COM13ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM13ToolStripMenuItem.Text = "COM13"
        '
        'COM14ToolStripMenuItem
        '
        Me.COM14ToolStripMenuItem.Name = "COM14ToolStripMenuItem"
        Me.COM14ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM14ToolStripMenuItem.Text = "COM14"
        '
        'COM15ToolStripMenuItem
        '
        Me.COM15ToolStripMenuItem.Name = "COM15ToolStripMenuItem"
        Me.COM15ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.COM15ToolStripMenuItem.Text = "COM15"
        '
        'CUSTOM1ToolStripMenuItem
        '
        Me.CUSTOM1ToolStripMenuItem.Name = "CUSTOM1ToolStripMenuItem"
        Me.CUSTOM1ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CUSTOM1ToolStripMenuItem.Text = "CUSTOM1"
        '
        'CUSTOM2ToolStripMenuItem
        '
        Me.CUSTOM2ToolStripMenuItem.Name = "CUSTOM2ToolStripMenuItem"
        Me.CUSTOM2ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CUSTOM2ToolStripMenuItem.Text = "CUSTOM2"
        '
        'CUSTOM3ToolStripMenuItem
        '
        Me.CUSTOM3ToolStripMenuItem.Name = "CUSTOM3ToolStripMenuItem"
        Me.CUSTOM3ToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CUSTOM3ToolStripMenuItem.Text = "CUSTOM3"
        '
        'DisconnectToolStripMenuItem
        '
        Me.DisconnectToolStripMenuItem.Name = "DisconnectToolStripMenuItem"
        Me.DisconnectToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.DisconnectToolStripMenuItem.Text = "Disconnect"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrinterToolStripMenuItem, Me.CompanyToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.WindowsToolStripMenuItem.Text = "Setting"
        '
        'PrinterToolStripMenuItem
        '
        Me.PrinterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem})
        Me.PrinterToolStripMenuItem.Name = "PrinterToolStripMenuItem"
        Me.PrinterToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PrinterToolStripMenuItem.Text = "Printer"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Checked = True
        Me.DefaultToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.DefaultToolStripMenuItem.Text = "Default"
        Me.DefaultToolStripMenuItem.Visible = False
        '
        'CompanyToolStripMenuItem
        '
        Me.CompanyToolStripMenuItem.Name = "CompanyToolStripMenuItem"
        Me.CompanyToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.CompanyToolStripMenuItem.Text = "Company"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnCloseCom)
        Me.GroupBox1.Controls.Add(Me.BtnOpenCom)
        Me.GroupBox1.Controls.Add(Me.TxtComport)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 100)
        Me.GroupBox1.TabIndex = 85
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 1"
        '
        'BtnCloseCom
        '
        Me.BtnCloseCom.Location = New System.Drawing.Point(135, 56)
        Me.BtnCloseCom.Name = "BtnCloseCom"
        Me.BtnCloseCom.Size = New System.Drawing.Size(75, 23)
        Me.BtnCloseCom.TabIndex = 3
        Me.BtnCloseCom.Text = "Close Com"
        Me.BtnCloseCom.UseVisualStyleBackColor = True
        '
        'BtnOpenCom
        '
        Me.BtnOpenCom.Location = New System.Drawing.Point(59, 56)
        Me.BtnOpenCom.Name = "BtnOpenCom"
        Me.BtnOpenCom.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpenCom.TabIndex = 2
        Me.BtnOpenCom.Text = "Open Com"
        Me.BtnOpenCom.UseVisualStyleBackColor = True
        '
        'TxtComport
        '
        Me.TxtComport.Location = New System.Drawing.Point(59, 16)
        Me.TxtComport.Name = "TxtComport"
        Me.TxtComport.Size = New System.Drawing.Size(151, 20)
        Me.TxtComport.TabIndex = 1
        Me.TxtComport.Text = "COM1,9600,N,8,1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comport"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextCount)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.TextWinsockReady)
        Me.GroupBox2.Controls.Add(Me.ButtonWinSock)
        Me.GroupBox2.Controls.Add(Me.pngWinSock)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextWinSockResp)
        Me.GroupBox2.Controls.Add(Me.TextWinsockPending)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 100)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Step 2"
        '
        'TextCount
        '
        Me.TextCount.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextCount.Location = New System.Drawing.Point(196, 42)
        Me.TextCount.Name = "TextCount"
        Me.TextCount.ReadOnly = True
        Me.TextCount.Size = New System.Drawing.Size(95, 20)
        Me.TextCount.TabIndex = 10
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(265, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(26, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "X"
        Me.ToolTip1.SetToolTip(Me.Button4, "Disconnect")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextWinsockReady
        '
        Me.TextWinsockReady.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextWinsockReady.Location = New System.Drawing.Point(61, 42)
        Me.TextWinsockReady.Name = "TextWinsockReady"
        Me.TextWinsockReady.ReadOnly = True
        Me.TextWinsockReady.Size = New System.Drawing.Size(128, 20)
        Me.TextWinsockReady.TabIndex = 8
        '
        'ButtonWinSock
        '
        Me.ButtonWinSock.Location = New System.Drawing.Point(196, 13)
        Me.ButtonWinSock.Name = "ButtonWinSock"
        Me.ButtonWinSock.Size = New System.Drawing.Size(68, 23)
        Me.ButtonWinSock.TabIndex = 7
        Me.ButtonWinSock.Text = "Send"
        Me.ButtonWinSock.UseVisualStyleBackColor = True
        '
        'pngWinSock
        '
        Me.pngWinSock.Image = CType(resources.GetObject("pngWinSock.Image"), System.Drawing.Image)
        Me.pngWinSock.Location = New System.Drawing.Point(297, 15)
        Me.pngWinSock.Name = "pngWinSock"
        Me.pngWinSock.Size = New System.Drawing.Size(17, 20)
        Me.pngWinSock.TabIndex = 6
        Me.pngWinSock.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pngWinSock, "Winsock Ready")
        Me.pngWinSock.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Resp$"
        '
        'TextWinSockResp
        '
        Me.TextWinSockResp.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextWinSockResp.Location = New System.Drawing.Point(61, 68)
        Me.TextWinSockResp.Multiline = True
        Me.TextWinSockResp.Name = "TextWinSockResp"
        Me.TextWinSockResp.ReadOnly = True
        Me.TextWinSockResp.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextWinSockResp.Size = New System.Drawing.Size(230, 26)
        Me.TextWinSockResp.TabIndex = 4
        '
        'TextWinsockPending
        '
        Me.TextWinsockPending.BackColor = System.Drawing.Color.White
        Me.TextWinsockPending.Location = New System.Drawing.Point(61, 16)
        Me.TextWinsockPending.Name = "TextWinsockPending"
        Me.TextWinsockPending.Size = New System.Drawing.Size(129, 20)
        Me.TextWinsockPending.TabIndex = 2
        Me.TextWinsockPending.Text = "not ready"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Winsock"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(561, 166)
        Me.GroupBox3.TabIndex = 87
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Step 3"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(403, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(151, 144)
        Me.Panel3.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "O - overpaid"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "V - outstanding payment"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "I - Idle Mode"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "P - Payment in progress"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Open Debugger"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "E - Empty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "X - Error"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Status :-"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bOSlot02)
        Me.Panel2.Controls.Add(Me.bVSlot02)
        Me.Panel2.Controls.Add(Me.bAmtSlot02)
        Me.Panel2.Controls.Add(Me.textOSlot02)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.textVSlot02)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.textAmtSlot02)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.textStatSlot02)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(222, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 144)
        Me.Panel2.TabIndex = 3
        '
        'bOSlot02
        '
        Me.bOSlot02.Location = New System.Drawing.Point(153, 112)
        Me.bOSlot02.Name = "bOSlot02"
        Me.bOSlot02.Size = New System.Drawing.Size(27, 23)
        Me.bOSlot02.TabIndex = 101
        Me.bOSlot02.Text = "X"
        Me.bOSlot02.UseVisualStyleBackColor = True
        '
        'bVSlot02
        '
        Me.bVSlot02.Location = New System.Drawing.Point(153, 86)
        Me.bVSlot02.Name = "bVSlot02"
        Me.bVSlot02.Size = New System.Drawing.Size(27, 23)
        Me.bVSlot02.TabIndex = 100
        Me.bVSlot02.Text = "X"
        Me.bVSlot02.UseVisualStyleBackColor = True
        '
        'bAmtSlot02
        '
        Me.bAmtSlot02.Location = New System.Drawing.Point(153, 60)
        Me.bAmtSlot02.Name = "bAmtSlot02"
        Me.bAmtSlot02.Size = New System.Drawing.Size(27, 23)
        Me.bAmtSlot02.TabIndex = 99
        Me.bAmtSlot02.Text = "X"
        Me.bAmtSlot02.UseVisualStyleBackColor = True
        '
        'textOSlot02
        '
        Me.textOSlot02.Enabled = False
        Me.textOSlot02.Location = New System.Drawing.Point(73, 115)
        Me.textOSlot02.Name = "textOSlot02"
        Me.textOSlot02.Size = New System.Drawing.Size(75, 20)
        Me.textOSlot02.TabIndex = 12
        Me.textOSlot02.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 118)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Overpaid"
        '
        'textVSlot02
        '
        Me.textVSlot02.Enabled = False
        Me.textVSlot02.Location = New System.Drawing.Point(73, 88)
        Me.textVSlot02.Name = "textVSlot02"
        Me.textVSlot02.Size = New System.Drawing.Size(75, 20)
        Me.textVSlot02.TabIndex = 10
        Me.textVSlot02.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 91)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 13)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Outstanding"
        '
        'textAmtSlot02
        '
        Me.textAmtSlot02.Enabled = False
        Me.textAmtSlot02.Location = New System.Drawing.Point(73, 62)
        Me.textAmtSlot02.Name = "textAmtSlot02"
        Me.textAmtSlot02.Size = New System.Drawing.Size(75, 20)
        Me.textAmtSlot02.TabIndex = 8
        Me.textAmtSlot02.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Amount (RM)"
        '
        'textStatSlot02
        '
        Me.textStatSlot02.Enabled = False
        Me.textStatSlot02.Location = New System.Drawing.Point(73, 26)
        Me.textStatSlot02.Name = "textStatSlot02"
        Me.textStatSlot02.Size = New System.Drawing.Size(75, 20)
        Me.textStatSlot02.TabIndex = 6
        Me.textStatSlot02.Text = "Idle"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Status"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "NDE1000 (Slot 2)"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bOSlot01)
        Me.Panel1.Controls.Add(Me.bVSlot01)
        Me.Panel1.Controls.Add(Me.bAmtSlot01)
        Me.Panel1.Controls.Add(Me.textOSlot01)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.textVSlot01)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.textAmtSlot01)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.textStatSlot01)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(39, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 144)
        Me.Panel1.TabIndex = 2
        '
        'bOSlot01
        '
        Me.bOSlot01.Location = New System.Drawing.Point(150, 113)
        Me.bOSlot01.Name = "bOSlot01"
        Me.bOSlot01.Size = New System.Drawing.Size(27, 23)
        Me.bOSlot01.TabIndex = 98
        Me.bOSlot01.Text = "X"
        Me.bOSlot01.UseVisualStyleBackColor = True
        '
        'bVSlot01
        '
        Me.bVSlot01.Location = New System.Drawing.Point(150, 86)
        Me.bVSlot01.Name = "bVSlot01"
        Me.bVSlot01.Size = New System.Drawing.Size(27, 23)
        Me.bVSlot01.TabIndex = 97
        Me.bVSlot01.Text = "X"
        Me.bVSlot01.UseVisualStyleBackColor = True
        '
        'bAmtSlot01
        '
        Me.bAmtSlot01.Location = New System.Drawing.Point(150, 60)
        Me.bAmtSlot01.Name = "bAmtSlot01"
        Me.bAmtSlot01.Size = New System.Drawing.Size(27, 23)
        Me.bAmtSlot01.TabIndex = 96
        Me.bAmtSlot01.Text = "X"
        Me.bAmtSlot01.UseVisualStyleBackColor = True
        '
        'textOSlot01
        '
        Me.textOSlot01.Enabled = False
        Me.textOSlot01.Location = New System.Drawing.Point(73, 115)
        Me.textOSlot01.Name = "textOSlot01"
        Me.textOSlot01.Size = New System.Drawing.Size(75, 20)
        Me.textOSlot01.TabIndex = 10
        Me.textOSlot01.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 118)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 13)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Overpaid"
        '
        'textVSlot01
        '
        Me.textVSlot01.Enabled = False
        Me.textVSlot01.Location = New System.Drawing.Point(73, 88)
        Me.textVSlot01.Name = "textVSlot01"
        Me.textVSlot01.Size = New System.Drawing.Size(75, 20)
        Me.textVSlot01.TabIndex = 8
        Me.textVSlot01.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 91)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "Outstanding"
        '
        'textAmtSlot01
        '
        Me.textAmtSlot01.Enabled = False
        Me.textAmtSlot01.Location = New System.Drawing.Point(73, 62)
        Me.textAmtSlot01.Name = "textAmtSlot01"
        Me.textAmtSlot01.Size = New System.Drawing.Size(75, 20)
        Me.textAmtSlot01.TabIndex = 6
        Me.textAmtSlot01.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Amount (RM)"
        '
        'textStatSlot01
        '
        Me.textStatSlot01.Enabled = False
        Me.textStatSlot01.Location = New System.Drawing.Point(73, 26)
        Me.textStatSlot01.Name = "textStatSlot01"
        Me.textStatSlot01.Size = New System.Drawing.Size(75, 20)
        Me.textStatSlot01.TabIndex = 4
        Me.textStatSlot01.Text = "Idle"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Status"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "NDE1000 (Slot 1)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Label"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BUTTON_CANCEL)
        Me.GroupBox4.Controls.Add(Me.BUTTON_RECEIPT)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 309)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(235, 154)
        Me.GroupBox4.TabIndex = 88
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Step 4"
        '
        'BUTTON_CANCEL
        '
        Me.BUTTON_CANCEL.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BUTTON_CANCEL.Location = New System.Drawing.Point(52, 57)
        Me.BUTTON_CANCEL.Name = "BUTTON_CANCEL"
        Me.BUTTON_CANCEL.Size = New System.Drawing.Size(121, 40)
        Me.BUTTON_CANCEL.TabIndex = 3
        Me.BUTTON_CANCEL.Text = "CANCEL"
        Me.BUTTON_CANCEL.UseVisualStyleBackColor = False
        '
        'BUTTON_RECEIPT
        '
        Me.BUTTON_RECEIPT.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BUTTON_RECEIPT.Location = New System.Drawing.Point(52, 11)
        Me.BUTTON_RECEIPT.Name = "BUTTON_RECEIPT"
        Me.BUTTON_RECEIPT.Size = New System.Drawing.Size(121, 40)
        Me.BUTTON_RECEIPT.TabIndex = 2
        Me.BUTTON_RECEIPT.Text = "RECEIPT"
        Me.BUTTON_RECEIPT.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Control"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button5.Location = New System.Drawing.Point(52, 103)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 40)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "PRINT"
        Me.ToolTip1.SetToolTip(Me.Button5, "Print Outstanding")
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.textAddress03)
        Me.GroupBox5.Controls.Add(Me.textAddress02)
        Me.GroupBox5.Controls.Add(Me.textContact)
        Me.GroupBox5.Controls.Add(Me.textAddress01)
        Me.GroupBox5.Controls.Add(Me.textCompanyName)
        Me.GroupBox5.Controls.Add(Me.textSiteName)
        Me.GroupBox5.Controls.Add(Me.textMachineName)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.textSerialReceived)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Location = New System.Drawing.Point(257, 309)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(319, 154)
        Me.GroupBox5.TabIndex = 89
        Me.GroupBox5.TabStop = False
        '
        'textAddress03
        '
        Me.textAddress03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textAddress03.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.textAddress03.Location = New System.Drawing.Point(226, 119)
        Me.textAddress03.Name = "textAddress03"
        Me.textAddress03.ReadOnly = True
        Me.textAddress03.Size = New System.Drawing.Size(93, 20)
        Me.textAddress03.TabIndex = 13
        Me.textAddress03.Visible = False
        '
        'textAddress02
        '
        Me.textAddress02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textAddress02.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.textAddress02.Location = New System.Drawing.Point(226, 98)
        Me.textAddress02.Name = "textAddress02"
        Me.textAddress02.ReadOnly = True
        Me.textAddress02.Size = New System.Drawing.Size(93, 20)
        Me.textAddress02.TabIndex = 12
        Me.textAddress02.Visible = False
        '
        'textContact
        '
        Me.textContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textContact.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.textContact.Location = New System.Drawing.Point(62, 119)
        Me.textContact.Name = "textContact"
        Me.textContact.ReadOnly = True
        Me.textContact.Size = New System.Drawing.Size(156, 20)
        Me.textContact.TabIndex = 11
        '
        'textAddress01
        '
        Me.textAddress01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textAddress01.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.textAddress01.Location = New System.Drawing.Point(62, 98)
        Me.textAddress01.Name = "textAddress01"
        Me.textAddress01.ReadOnly = True
        Me.textAddress01.Size = New System.Drawing.Size(156, 20)
        Me.textAddress01.TabIndex = 10
        '
        'textCompanyName
        '
        Me.textCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textCompanyName.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.textCompanyName.Location = New System.Drawing.Point(62, 77)
        Me.textCompanyName.Name = "textCompanyName"
        Me.textCompanyName.ReadOnly = True
        Me.textCompanyName.Size = New System.Drawing.Size(156, 20)
        Me.textCompanyName.TabIndex = 9
        '
        'textSiteName
        '
        Me.textSiteName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSiteName.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.textSiteName.Location = New System.Drawing.Point(62, 56)
        Me.textSiteName.Name = "textSiteName"
        Me.textSiteName.ReadOnly = True
        Me.textSiteName.Size = New System.Drawing.Size(156, 20)
        Me.textSiteName.TabIndex = 8
        '
        'textMachineName
        '
        Me.textMachineName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textMachineName.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.textMachineName.Location = New System.Drawing.Point(62, 35)
        Me.textMachineName.Name = "textMachineName"
        Me.textMachineName.ReadOnly = True
        Me.textMachineName.Size = New System.Drawing.Size(156, 20)
        Me.textMachineName.TabIndex = 7
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 38)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 13)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Site"
        '
        'textSerialReceived
        '
        Me.textSerialReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSerialReceived.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.textSerialReceived.Location = New System.Drawing.Point(62, 11)
        Me.textSerialReceived.Name = "textSerialReceived"
        Me.textSerialReceived.ReadOnly = True
        Me.textSerialReceived.Size = New System.Drawing.Size(156, 20)
        Me.textSerialReceived.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 11)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Received"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(556, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(36, 13)
        Me.Label23.TabIndex = 90
        Me.Label23.Text = "600px"
        Me.Label23.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.ButtonSendSerial)
        Me.GroupBox6.Controls.Add(Me.TextSendSerial)
        Me.GroupBox6.Controls.Add(Me.RichTextLogger)
        Me.GroupBox6.Location = New System.Drawing.Point(598, 30)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(382, 652)
        Me.GroupBox6.TabIndex = 91
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Debugger Screen"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(345, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ButtonSendSerial
        '
        Me.ButtonSendSerial.Location = New System.Drawing.Point(197, 16)
        Me.ButtonSendSerial.Name = "ButtonSendSerial"
        Me.ButtonSendSerial.Size = New System.Drawing.Size(142, 23)
        Me.ButtonSendSerial.TabIndex = 3
        Me.ButtonSendSerial.Text = "Send Serial Commnand"
        Me.ButtonSendSerial.UseVisualStyleBackColor = True
        '
        'TextSendSerial
        '
        Me.TextSendSerial.Enabled = False
        Me.TextSendSerial.Location = New System.Drawing.Point(6, 16)
        Me.TextSendSerial.Name = "TextSendSerial"
        Me.TextSendSerial.Size = New System.Drawing.Size(185, 20)
        Me.TextSendSerial.TabIndex = 2
        Me.TextSendSerial.Text = "8"
        '
        'RichTextLogger
        '
        Me.RichTextLogger.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextLogger.Location = New System.Drawing.Point(6, 42)
        Me.RichTextLogger.Name = "RichTextLogger"
        Me.RichTextLogger.ReadOnly = True
        Me.RichTextLogger.Size = New System.Drawing.Size(370, 600)
        Me.RichTextLogger.TabIndex = 0
        Me.RichTextLogger.Text = ""
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TextLogScreen)
        Me.GroupBox7.Location = New System.Drawing.Point(16, 488)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(560, 194)
        Me.GroupBox7.TabIndex = 92
        Me.GroupBox7.TabStop = False
        '
        'TextLogScreen
        '
        Me.TextLogScreen.BackColor = System.Drawing.Color.LemonChiffon
        Me.TextLogScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextLogScreen.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.TextLogScreen.Location = New System.Drawing.Point(6, 13)
        Me.TextLogScreen.Multiline = True
        Me.TextLogScreen.Name = "TextLogScreen"
        Me.TextLogScreen.ReadOnly = True
        Me.TextLogScreen.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextLogScreen.Size = New System.Drawing.Size(548, 175)
        Me.TextLogScreen.TabIndex = 3
        '
        'LabelExpand
        '
        Me.LabelExpand.AutoSize = True
        Me.LabelExpand.BackColor = System.Drawing.Color.LemonChiffon
        Me.LabelExpand.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExpand.Location = New System.Drawing.Point(18, 467)
        Me.LabelExpand.Name = "LabelExpand"
        Me.LabelExpand.Size = New System.Drawing.Size(17, 24)
        Me.LabelExpand.TabIndex = 94
        Me.LabelExpand.Text = "-"
        Me.ToolTip1.SetToolTip(Me.LabelExpand, "Click to show or hide log screen")
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(42, 472)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 13)
        Me.Label25.TabIndex = 93
        Me.Label25.Text = "Log Screen"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(114, 467)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(27, 23)
        Me.Button3.TabIndex = 95
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'tmr_winsock
        '
        Me.tmr_winsock.Interval = 50
        '
        'tmr_wsListen
        '
        Me.tmr_wsListen.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 712)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LabelExpand)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Location = New System.Drawing.Point(100, 0)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pngWinSock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents RS232 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SerialText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmr_state As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents tmr_status As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InterfaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM6ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM7ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM8ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM9ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM10ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM11ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM12ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM13ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM14ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COM15ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUSTOM1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUSTOM2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CUSTOM3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisconnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtComport As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCloseCom As System.Windows.Forms.Button
    Friend WithEvents BtnOpenCom As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextWinSockResp As System.Windows.Forms.TextBox
    Friend WithEvents TextWinsockPending As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pngWinSock As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BUTTON_CANCEL As System.Windows.Forms.Button
    Friend WithEvents BUTTON_RECEIPT As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents textStatSlot02 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents textStatSlot01 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents textAmtSlot02 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents textAmtSlot01 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents textOSlot02 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents textVSlot02 As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents textOSlot01 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents textVSlot01 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RichTextLogger As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonSendSerial As System.Windows.Forms.Button
    Friend WithEvents TextSendSerial As System.Windows.Forms.TextBox
    Friend WithEvents textSerialReceived As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TextLogScreen As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents LabelExpand As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents bOSlot02 As System.Windows.Forms.Button
    Friend WithEvents bVSlot02 As System.Windows.Forms.Button
    Friend WithEvents bAmtSlot02 As System.Windows.Forms.Button
    Friend WithEvents bOSlot01 As System.Windows.Forms.Button
    Friend WithEvents bVSlot01 As System.Windows.Forms.Button
    Friend WithEvents bAmtSlot01 As System.Windows.Forms.Button
    Friend WithEvents ButtonWinSock As System.Windows.Forms.Button
    Friend WithEvents TextWinsockReady As System.Windows.Forms.TextBox
    Friend WithEvents tmr_winsock As System.Windows.Forms.Timer
    Friend WithEvents tmr_wsListen As System.Windows.Forms.Timer
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TextCount As System.Windows.Forms.TextBox
    Friend WithEvents WindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrinterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CompanyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents textMachineName As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents textCompanyName As System.Windows.Forms.TextBox
    Friend WithEvents textSiteName As System.Windows.Forms.TextBox
    Friend WithEvents textContact As System.Windows.Forms.TextBox
    Friend WithEvents textAddress01 As System.Windows.Forms.TextBox
    Friend WithEvents textAddress03 As System.Windows.Forms.TextBox
    Friend WithEvents textAddress02 As System.Windows.Forms.TextBox
End Class

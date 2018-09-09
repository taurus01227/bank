Module Invoice

    Public Structure printHeader
        Public CompanyName As String
        Public SiteName As String
        Public MachineId As String
        Public Address01 As String
        Public Address02 As String
        Public Address03 As String
        Public ContactNumber As String
    End Structure

    Public Const companyfile As String = "C:\Users\Public\company.txt"
    Public Const invoicefile As String = "C:\Users\Public\invoice.txt"
    Public Const invoiceLog As String = "C:\Users\Public\invoiceLog.txt"

    Public listOfCompany As List(Of printHeader)

    Public Sub UpdateInvoice(ByVal invoiceNo As Integer)
        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(invoicefile, False)
            Dim nextNumber As Integer = invoiceNo + 1
            file.Write(nextNumber.ToString("00000"))
            file.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Function GetInvoice() As String
        Try
            Dim fileReader As String
            If My.Computer.FileSystem.FileExists(invoicefile) Then
                fileReader = My.Computer.FileSystem.ReadAllText(invoicefile)
                UpdateInvoice(Val(fileReader))
                Return fileReader
            Else
                UpdateInvoice(1)
                Return "00001"
            End If
        Catch ex As Exception

        End Try
        UpdateInvoice(1)
        Return "00001"
    End Function

    Public Sub Log(ByVal lineMessage As String)
        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(invoiceLog, True)
            file.WriteLine(lineMessage)
            file.Close()
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub AddDefaultCompany()
        Dim company As printHeader
        listOfCompany = New List(Of printHeader)
        ' # machine 01
        company = New printHeader
        company.CompanyName = "LOYAL APEX SDN BHD"
        company.SiteName = "PV128"
        company.MachineId = "AP1"
        company.Address01 = "Co. Reg. No. 1067302-D"
        company.Address02 = ""
        company.Address03 = ""
        company.ContactNumber = "012-3082725"
        listOfCompany.Add(company)

        ' # machine 02
        company = New printHeader
        company.CompanyName = "LOYAL APEX SDN BHD"
        company.SiteName = "PV128"
        company.MachineId = "AP2"
        company.Address01 = "Co. Reg. No. 1067302-D"
        company.Address02 = ""
        company.Address03 = ""
        company.ContactNumber = "012-3082725"
        listOfCompany.Add(company)

        ' # machine 03
        company = New printHeader
        company.CompanyName = "LOYAL APEX SDN BHD"
        company.SiteName = "PV128"
        company.MachineId = "AP3"
        company.Address01 = "Co. Reg. No. 1067302-D"
        company.Address02 = ""
        company.Address03 = ""
        company.ContactNumber = "012-3082725"
        listOfCompany.Add(company)

        ' write to file
        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(companyfile, True)
            For Each cp As printHeader In listOfCompany
                Dim lineMessage As String = cp.CompanyName & "|" & cp.SiteName & "|" & cp.MachineId & "|" & cp.Address01 & "|" & cp.Address02 & "|" & cp.Address03 & "|" & cp.ContactNumber
                file.WriteLine(lineMessage)
            Next

            file.Close()
        Catch ex As Exception

        End Try

    End Sub

    Public Function GetCompany() As List(Of printHeader)

        If My.Computer.FileSystem.FileExists(companyfile) = False Then
            AddDefaultCompany()
        End If

        Try
            Dim company As printHeader
            listOfCompany = New List(Of printHeader)

            Dim file As System.IO.StreamReader
            Dim line As String = String.Empty
            file = My.Computer.FileSystem.OpenTextFileReader(companyfile)
            line = file.ReadLine()
            While String.IsNullOrEmpty(line) = False
                Dim dataArray As String() = line.Split("|")
                ' # machine 01
                company = New printHeader
                company.CompanyName = dataArray(0)
                company.SiteName = dataArray(1)
                company.MachineId = dataArray(2)
                company.Address01 = dataArray(3)
                company.Address02 = dataArray(4)
                company.Address03 = dataArray(5)
                company.ContactNumber = dataArray(6)
                listOfCompany.Add(company)
                line = file.ReadLine()
            End While
            file.Close()
        Catch ex As Exception

        End Try

        Return listOfCompany
    End Function
End Module

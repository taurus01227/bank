Imports System.Drawing
Imports System.Drawing.Printing

Module defaultPrinter
    Private defaultFont As Font = SystemFonts.DefaultFont
    Private pDocument As PrintDocument
    Private pData As String

    ''' <summary>
    ''' Prints the desired text using the System's default Font.
    ''' </summary>
    ''' <param name="text">The text to print.</param>
    ''' <remarks>The text will automatically word wrap and it prints to the default printer.</remarks>
    Public Sub Print(ByVal text As String)
        'Create a new instance of the PrintDocument object
        pDocument = New PrintDocument

        'Create the event handler to print text using the default font
        AddHandler pDocument.PrintPage, AddressOf pDocument_PrintPage

        'Set the print data to the text
        pData = text

        ' Set some preferences, our method should print a box with any 
        ' combination of these properties being true/false.
        pDocument.OriginAtMargins = True 'true = soft margins, false = hard margins
        pDocument.DefaultPageSettings.Margins.Top = 15
        pDocument.DefaultPageSettings.Margins.Left = 15
        pDocument.DefaultPageSettings.Margins.Right = 15
        pDocument.DefaultPageSettings.Margins.Bottom = 10
        'Print!
        pDocument.Print()
    End Sub

    ''' <summary>
    ''' Prints the desired text using specified Font.
    ''' </summary>
    ''' <param name="text">The text to print.</param>
    ''' <param name="font">The font to use while printing.</param>
    ''' <remarks>The text will automatically word wrap and it prints to the default printer.</remarks>
    Public Sub Print(ByVal text As String, ByVal font As Font)
        'Create a new instance of the PrintDocument object
        pDocument = New PrintDocument

        'Create the event handler to print text using the default font
        AddHandler pDocument.PrintPage, AddressOf pDocument_PrintPage

        'Set the print data to the text
        pData = text

        'Set the font
        defaultFont = font

        'Print!
        pDocument.Print()
    End Sub

    ''' <summary>
    ''' Prints the desired text using the System's default Font to the specified printer.
    ''' </summary>
    ''' <param name="text">The text to print.</param>
    ''' <param name="printerName">The name of the printer to print to.</param>
    ''' <remarks>The text will automatically word wrap. The printer name should be verfied that it is contained in PrinterSettings.InstalledPrinters</remarks>
    Public Sub Print(ByVal text As String, ByVal printerName As String)
        'Create a new instance of the PrintDocument object
        pDocument = New PrintDocument

        'Set the printer's name
        pDocument.PrinterSettings.PrinterName = printerName

        'Create the event handler to print text using the default font
        AddHandler pDocument.PrintPage, AddressOf pDocument_PrintPage

        'Set the print data to the text
        pData = text

        'Print!
        pDocument.Print()
    End Sub

    ''' <summary>
    ''' Prints the desired text using the specified Font to the specified printer.
    ''' </summary>
    ''' <param name="text">The text to print.</param>
    ''' <param name="font">The font to use while printing.</param>
    ''' <param name="printerName">The name of the printer to print to.</param>
    ''' <remarks>The text will automatically word wrap. The printer name should be verfied that it is contained in PrinterSettings.InstalledPrinters</remarks>
    Public Sub Print(ByVal text As String, ByVal font As Font, ByVal printerName As String)
        'Create a new instance of the PrintDocument object
        pDocument = New PrintDocument

        'Set the printer's name
        pDocument.PrinterSettings.PrinterName = printerName

        'Create the event handler to print text using the default font
        AddHandler pDocument.PrintPage, AddressOf pDocument_PrintPage

        'Set the print data to the text
        pData = text

        'Set the font
        defaultFont = font

        'Print!
        pDocument.Print()
    End Sub

    Private Sub pDocument_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        'Get the text, the amount of characters on the page, and the amount of lines per page
        Dim charactersOnPage As Integer = 0
        Dim linesPerPage As Integer = 0

        'Sets the value of charactersOnPage to the number of characters of s that will fit within the bounds of the page.
        e.Graphics.MeasureString(pData, defaultFont, e.MarginBounds.Size, StringFormat.GenericTypographic, charactersOnPage, linesPerPage)

        'Draws the string within the bounds of the page
        e.Graphics.DrawString(pData, defaultFont, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic)

        'Remove the portion of the string that has been printed.
        pData = pData.Substring(charactersOnPage)

        'Check to see if more pages are to be printed.
        e.HasMorePages = (pData.Length > 0)
    End Sub
End Module

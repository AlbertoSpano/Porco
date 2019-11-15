Public Class EvidenizaParole

    Public Property ps As List(Of pCpunt)
    Public Property testo As String

    Private Sub EvidenizaParole_Load(sender As Object, e As EventArgs) Handles Me.Load

        testo = testo.Replace(vbLf, "")

        grdParole.DataSource = ps

        grdParole.Rows(0).Selected = False

        AddHandler grdParole.SelectionChanged, AddressOf grdParole_SelectionChanged

    End Sub

    Private Sub grdParole_SelectionChanged(sender As Object, e As EventArgs)

        If grdParole.CurrentRow.Index = -1 Then Return

        ' .. file html
        Dim h As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), String.Format("{0:yyyyMMddHHmmss}.html", Now))

        Dim parola As String = grdParole.CurrentRow.Cells(0).Value.ToString

        Dim riga As Integer = 0
        Dim index As Integer = 0
        Dim pos As Integer = 0
        Dim p As String = String.Empty
        Dim pNew As String

        Dim html As String = "<html>"

        html += "<head>"
        html += "<style type=""text/css"">"
        html += ".riga {text-align:right; width: 40px; color: blue; padding-right: 6px;}"
        html += ".parola {background-color: yellow;}"
        html += "body {font-size: 0.8em; font-family: Calibri;}"
        html += "</style>"
        html += "</head>"
        html += "<body>"
        html += "<button type=""button"" onclick=""scrollFirst();"">Prima occorrenza</button><p />"

        For Each s As String In testo.Split(CType(vbCr, Char()))
            index = 0
            riga += 1
            html += String.Format("<span class=""riga"">{0}.</span>", riga)
            pos = s.IndexOf(parola, StringComparison.CurrentCultureIgnoreCase)
            While pos > -1
                index += 1
                p = s.Substring(pos, parola.Length)
                pNew = String.Format("<span class=""parola"" id=""parola"">{0}</span>", p)
                s = s.Substring(0, pos) + pNew + s.Substring(pos + parola.Length)
                pos = s.IndexOf(parola, pos + pNew.Length, StringComparison.CurrentCultureIgnoreCase)
            End While
            html += s + "<br />"
        Next

        html += "<script type=""text/javascript"">"
        html += "var el = document.getElementById('parola');scrollFirst();"
        html += "function scrollFirst() {"
        html += "if (!el) return;"
        html += "el.scrollIntoView();"
        html += "}"
        html += "</script>"
        html += "</body>"
        html += "</html>"

        Me.webTesto.DocumentText = html

        'IO.File.WriteAllText(h, html)

        'System.Diagnostics.Process.Start(h)

    End Sub

End Class
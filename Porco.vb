Imports OfficeOpenXml

Public Class Porco

    Private Property contato As Boolean
        Get
            Return _contato
        End Get
        Set
            _contato = Value
            btnConta.Enabled = Not _contato
            btnEvidenzia.Enabled = contato
            lnkExcel.Enabled = contato
            If Not contato Then grdParole.DataSource = Nothing
        End Set
    End Property

    Private minChars As Integer = 4
    Private testo As String
    Private preposizioni As String() = {"di", "a", "da", "in", "con", "su", "per", "tra", "fra"}
    Private articoli As String() = {"il", "lo", "la", "i", "gli", "le", "un", "uno", "una", "l"}
    Private preposizioniarticolate As String() = {"del", "dell", "della", "dello", "delle", "degli", "al", "all", "allo", "alla", "alle", "agli", "ai", "dal", "dall", "dalla", "dallo", "dalle", "dagli", "nel", "nello", "nella", "nelle", "nei", "negli", "su", "sul", "sullo", "sulla", "sulle", "sui", "sugli"}
    Private congiunzioni As String() = {"e", "né", "nè", "se", "o", "ma", "anche", "neanche", "affinché", "affinchè"}
    Private _contato As Boolean
    Dim xls As String

    Private Sub Porco_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnImporta_Click(sender As Object, e As EventArgs) Handles btnImporta.Click
        If OpenFileTxt.ShowDialog = DialogResult.OK Then
            testo = IO.File.ReadAllText(OpenFileTxt.FileName, System.Text.Encoding.UTF7)
            Me.txtTesto.Text = testo
            conta()
        End If
    End Sub

    Private Sub btnConta_Click(sender As Object, e As EventArgs) Handles btnConta.Click
        conta()
    End Sub

    Private Sub txtMinLung_ValueChanged(sender As Object, e As EventArgs) Handles txtMinLung.ValueChanged
        Me.lblDid.Text = String.Format("con lunghezza minina {0} caratteri", txtMinLung.Value)
    End Sub

    Private Sub Elenco()

        If grdParole.Rows.Count > 0 Then

            ' .. file excel
            xls = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), String.Format("{0:yyyyMMddHHmmss}.xlsx", Now))

            If IO.File.Exists(xls) Then IO.File.Delete(xls)

            ' ... elenco
            Dim ps As List(Of pCpunt) = CType(grdParole.DataSource, List(Of pCpunt))

            ' ... crea file di excel
            Using ex As New OfficeOpenXml.ExcelPackage(New IO.FileInfo(xls))

                Dim worksheet As ExcelWorksheet = ex.Workbook.Worksheets.Add("Parole")

                worksheet.Cells("A1").Value = "Parola"
                worksheet.Cells("b1").Value = "Conteggio"

                Dim r As Integer = 1

                For Each p In ps
                    r += 1
                    worksheet.Cells(r, 1).Value = p.parola
                    worksheet.Cells(r, 2).Value = p.count
                Next

                worksheet.Cells(worksheet.Dimension.Address).AutoFitColumns()
                worksheet.Column(2).Style.Numberformat.Format = "#,##0"

                ex.Save()

            End Using

        End If

    End Sub

    Private Sub conta()

        If Me.txtTesto.Text.Length > 0 Then

            Dim txt As String = Me.txtTesto.Text
            txt = txt.Replace("'", " ")
            txt = txt.Replace("`", " ")
            txt = txt.Replace("´", " ")
            txt = txt.Replace("«", " ")
            txt = txt.Replace("»", " ")
            txt = txt.Replace(",", " ")
            txt = txt.Replace(";", " ")
            txt = txt.Replace(".", " ")
            txt = txt.Replace(":", " ")
            txt = txt.Replace("?", " ")
            txt = txt.Replace("!", " ")
            txt = txt.Replace("=", " ")
            txt = txt.Replace(Chr(34), " ")
            txt = txt.Replace("(", " ")
            txt = txt.Replace(")", " ")
            txt = txt.Replace("[", " ")
            txt = txt.Replace("]", " ")
            txt = txt.Replace("{", " ")
            txt = txt.Replace("}", " ")
            txt = txt.Replace(vbCrLf, " ")

            If chkArticoli.Checked Then
                For Each p As String In preposizioni
                    txt = txt.Replace(" " + p + " ", " ")
                Next
            End If

            If chkPreposizioni.Checked Then
                For Each p As String In articoli
                    txt = txt.Replace(" " + p + " ", " ")
                Next
            End If

            If chkPreposizioniArticolate.Checked Then
                For Each p As String In preposizioniarticolate
                    txt = txt.Replace(" " + p + " ", " ")
                Next
            End If

            If chkCongiunzioni.Checked Then
                For Each p As String In congiunzioni
                    txt = txt.Replace(" " + p + " ", " ")
                Next
            End If

            Dim parole As List(Of String) = txt.Split(" "c).ToList().Where(Function(x) x.Trim.Length >= txtMinLung.Value).ToList
            txtParoleTotali.Text = parole.Count.ToString

            Dim ps As List(Of pCpunt) = parole.GroupBy(Function(x) x.ToUpper).Select(Function(g) New pCpunt With {.parola = g.Key, .count = g.Count}).OrderByDescending(Function(x) x.count).ThenBy(Function(x) x.parola).ToList
            grdParole.DataSource = ps

            Elenco()

            contato = True

        End If

    End Sub

    Private Sub btnEvidenzia_Click(sender As Object, e As EventArgs) Handles btnEvidenzia.Click

        If Not contato Then conta()

        Dim frm As New EvidenizaParole
        frm.testo = Me.txtTesto.Text
        frm.ps = CType(grdParole.DataSource, List(Of pCpunt))
        frm.ShowDialog()

    End Sub

    Private Sub txtTesto_TextChanged(sender As Object, e As EventArgs) Handles txtTesto.TextChanged
        contato = False
    End Sub

    Private Sub chkArticoli_CheckedChanged(sender As Object, e As EventArgs) Handles chkArticoli.CheckedChanged
        conta()
    End Sub

    Private Sub chkPreposizioni_CheckedChanged(sender As Object, e As EventArgs) Handles chkPreposizioni.CheckedChanged
        conta()
    End Sub

    Private Sub chkPreposizioniArticolate_CheckedChanged(sender As Object, e As EventArgs) Handles chkPreposizioniArticolate.CheckedChanged
        conta()
    End Sub

    Private Sub chkCongiunzioni_CheckedChanged(sender As Object, e As EventArgs) Handles chkCongiunzioni.CheckedChanged
        conta()
    End Sub

    Private Sub lnkExcel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkExcel.LinkClicked
        System.Diagnostics.Process.Start(xls)
    End Sub

End Class

Public Class pCpunt
    Public Property parola As String
    Public Property count As Integer
End Class

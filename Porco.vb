Public Class Porco

    Private minChars As Integer = 4
    Private testo As String
    Private preposizioni As String() = {"di", "a", "da", "in", "con", "su", "per", "tra", "fra"}
    Private articoli As String() = {"il", "lo", "la", "i", "gli", "le", "un", "uno", "una", "l"}
    Private preposizioniarticolate As String() = {"del", "dell", "della", "dello", "delle", "degli", "al", "all", "allo", "alla", "alle", "agli", "ai", "dal", "dall", "dalla", "dallo", "dalle", "dagli", "nel", "nello", "nella", "nelle", "nei", "negli", "su", "sul", "sullo", "sulla", "sulle", "sui", "sugli"}
    Private congiunzioni As String() = {"e", "né", "nè", "se", "o", "ma", "anche", "neanche", "affinché", "affinchè"}

    Private Sub Porco_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnImporta_Click(sender As Object, e As EventArgs) Handles btnImporta.Click
        If OpenFileTxt.ShowDialog = DialogResult.OK Then
            testo = IO.File.ReadAllText(OpenFileTxt.FileName)
            Me.txtTesto.Text = testo
        End If
    End Sub

    Private Sub btnConta_Click(sender As Object, e As EventArgs) Handles btnConta.Click
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

        End If
    End Sub

    Private Sub txtMinLung_ValueChanged(sender As Object, e As EventArgs) Handles txtMinLung.ValueChanged
        Me.lblDid.Text = String.Format("con lunghezza minina {0} caratteri", txtMinLung.Value)
    End Sub
End Class

Public Class pCpunt
    Public Property parola As String
    Public Property count As Integer
End Class

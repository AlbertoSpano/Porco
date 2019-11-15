<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Porco
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtTesto = New System.Windows.Forms.TextBox()
        Me.btnImporta = New System.Windows.Forms.Button()
        Me.OpenFileTxt = New System.Windows.Forms.OpenFileDialog()
        Me.btnConta = New System.Windows.Forms.Button()
        Me.grdParole = New System.Windows.Forms.DataGridView()
        Me.txtMinLung = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtParoleTotali = New System.Windows.Forms.TextBox()
        Me.lblDid = New System.Windows.Forms.Label()
        Me.chkArticoli = New System.Windows.Forms.CheckBox()
        Me.chkPreposizioni = New System.Windows.Forms.CheckBox()
        Me.chkPreposizioniArticolate = New System.Windows.Forms.CheckBox()
        Me.chkCongiunzioni = New System.Windows.Forms.CheckBox()
        Me.btnEsporta = New System.Windows.Forms.Button()
        Me.btnEvidenzia = New System.Windows.Forms.Button()
        CType(Me.grdParole, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinLung, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTesto
        '
        Me.txtTesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTesto.Location = New System.Drawing.Point(12, 68)
        Me.txtTesto.MaxLength = 0
        Me.txtTesto.Multiline = True
        Me.txtTesto.Name = "txtTesto"
        Me.txtTesto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTesto.Size = New System.Drawing.Size(682, 382)
        Me.txtTesto.TabIndex = 0
        '
        'btnImporta
        '
        Me.btnImporta.Location = New System.Drawing.Point(12, 12)
        Me.btnImporta.Name = "btnImporta"
        Me.btnImporta.Size = New System.Drawing.Size(119, 23)
        Me.btnImporta.TabIndex = 1
        Me.btnImporta.Text = "Importa file"
        Me.btnImporta.UseVisualStyleBackColor = True
        '
        'OpenFileTxt
        '
        Me.OpenFileTxt.DefaultExt = "txt"
        Me.OpenFileTxt.FileName = "*.txt"
        '
        'btnConta
        '
        Me.btnConta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConta.Enabled = False
        Me.btnConta.Location = New System.Drawing.Point(961, 12)
        Me.btnConta.Name = "btnConta"
        Me.btnConta.Size = New System.Drawing.Size(75, 23)
        Me.btnConta.TabIndex = 2
        Me.btnConta.Text = "Conta"
        Me.btnConta.UseVisualStyleBackColor = True
        '
        'grdParole
        '
        Me.grdParole.AllowUserToAddRows = False
        Me.grdParole.AllowUserToDeleteRows = False
        Me.grdParole.AllowUserToResizeRows = False
        Me.grdParole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdParole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdParole.Location = New System.Drawing.Point(700, 68)
        Me.grdParole.Name = "grdParole"
        Me.grdParole.ReadOnly = True
        Me.grdParole.RowHeadersVisible = False
        Me.grdParole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdParole.Size = New System.Drawing.Size(336, 380)
        Me.grdParole.TabIndex = 3
        '
        'txtMinLung
        '
        Me.txtMinLung.Location = New System.Drawing.Point(137, 42)
        Me.txtMinLung.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.txtMinLung.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtMinLung.Name = "txtMinLung"
        Me.txtMinLung.Size = New System.Drawing.Size(38, 20)
        Me.txtMinLung.TabIndex = 4
        Me.txtMinLung.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "lunghezza minima parole"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(697, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Parole totali:"
        '
        'txtParoleTotali
        '
        Me.txtParoleTotali.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParoleTotali.Location = New System.Drawing.Point(768, 43)
        Me.txtParoleTotali.Name = "txtParoleTotali"
        Me.txtParoleTotali.ReadOnly = True
        Me.txtParoleTotali.Size = New System.Drawing.Size(85, 20)
        Me.txtParoleTotali.TabIndex = 7
        '
        'lblDid
        '
        Me.lblDid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDid.AutoSize = True
        Me.lblDid.Location = New System.Drawing.Point(875, 46)
        Me.lblDid.Name = "lblDid"
        Me.lblDid.Size = New System.Drawing.Size(159, 13)
        Me.lblDid.TabIndex = 8
        Me.lblDid.Text = "con lunghezza minina 4 caratteri"
        '
        'chkArticoli
        '
        Me.chkArticoli.AutoSize = True
        Me.chkArticoli.Location = New System.Drawing.Point(179, 43)
        Me.chkArticoli.Name = "chkArticoli"
        Me.chkArticoli.Size = New System.Drawing.Size(92, 17)
        Me.chkArticoli.TabIndex = 9
        Me.chkArticoli.Text = "escludi articoli"
        Me.chkArticoli.UseVisualStyleBackColor = True
        '
        'chkPreposizioni
        '
        Me.chkPreposizioni.AutoSize = True
        Me.chkPreposizioni.Location = New System.Drawing.Point(277, 43)
        Me.chkPreposizioni.Name = "chkPreposizioni"
        Me.chkPreposizioni.Size = New System.Drawing.Size(117, 17)
        Me.chkPreposizioni.TabIndex = 10
        Me.chkPreposizioni.Text = "escludi preposizioni"
        Me.chkPreposizioni.UseVisualStyleBackColor = True
        '
        'chkPreposizioniArticolate
        '
        Me.chkPreposizioniArticolate.AutoSize = True
        Me.chkPreposizioniArticolate.Location = New System.Drawing.Point(400, 43)
        Me.chkPreposizioniArticolate.Name = "chkPreposizioniArticolate"
        Me.chkPreposizioniArticolate.Size = New System.Drawing.Size(163, 17)
        Me.chkPreposizioniArticolate.TabIndex = 11
        Me.chkPreposizioniArticolate.Text = "escludi preposizioni articolate"
        Me.chkPreposizioniArticolate.UseVisualStyleBackColor = True
        '
        'chkCongiunzioni
        '
        Me.chkCongiunzioni.AutoSize = True
        Me.chkCongiunzioni.Location = New System.Drawing.Point(569, 43)
        Me.chkCongiunzioni.Name = "chkCongiunzioni"
        Me.chkCongiunzioni.Size = New System.Drawing.Size(121, 17)
        Me.chkCongiunzioni.TabIndex = 12
        Me.chkCongiunzioni.Text = "escludi congiunzioni"
        Me.chkCongiunzioni.UseVisualStyleBackColor = True
        '
        'btnEsporta
        '
        Me.btnEsporta.Enabled = False
        Me.btnEsporta.Location = New System.Drawing.Point(137, 12)
        Me.btnEsporta.Name = "btnEsporta"
        Me.btnEsporta.Size = New System.Drawing.Size(120, 23)
        Me.btnEsporta.TabIndex = 13
        Me.btnEsporta.Text = "Esporta elenco"
        Me.btnEsporta.UseVisualStyleBackColor = True
        '
        'btnEvidenzia
        '
        Me.btnEvidenzia.Enabled = False
        Me.btnEvidenzia.Location = New System.Drawing.Point(263, 12)
        Me.btnEvidenzia.Name = "btnEvidenzia"
        Me.btnEvidenzia.Size = New System.Drawing.Size(120, 23)
        Me.btnEvidenzia.TabIndex = 14
        Me.btnEvidenzia.Text = "Evidenzia parole"
        Me.btnEvidenzia.UseVisualStyleBackColor = True
        '
        'Porco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 462)
        Me.Controls.Add(Me.btnEvidenzia)
        Me.Controls.Add(Me.btnEsporta)
        Me.Controls.Add(Me.chkCongiunzioni)
        Me.Controls.Add(Me.chkPreposizioniArticolate)
        Me.Controls.Add(Me.chkPreposizioni)
        Me.Controls.Add(Me.chkArticoli)
        Me.Controls.Add(Me.lblDid)
        Me.Controls.Add(Me.txtParoleTotali)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMinLung)
        Me.Controls.Add(Me.grdParole)
        Me.Controls.Add(Me.btnConta)
        Me.Controls.Add(Me.btnImporta)
        Me.Controls.Add(Me.txtTesto)
        Me.MinimumSize = New System.Drawing.Size(1060, 400)
        Me.Name = "Porco"
        Me.Text = "Porco"
        CType(Me.grdParole, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinLung, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTesto As TextBox
    Friend WithEvents btnImporta As Button
    Friend WithEvents OpenFileTxt As OpenFileDialog
    Friend WithEvents btnConta As Button
    Friend WithEvents grdParole As DataGridView
    Friend WithEvents txtMinLung As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtParoleTotali As TextBox
    Friend WithEvents lblDid As Label
    Friend WithEvents chkArticoli As CheckBox
    Friend WithEvents chkPreposizioni As CheckBox
    Friend WithEvents chkPreposizioniArticolate As CheckBox
    Friend WithEvents chkCongiunzioni As CheckBox
    Friend WithEvents btnEsporta As Button
    Friend WithEvents btnEvidenzia As Button
End Class

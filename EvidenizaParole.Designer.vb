<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EvidenizaParole
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdParole = New System.Windows.Forms.DataGridView()
        Me.webTesto = New System.Windows.Forms.WebBrowser()
        CType(Me.grdParole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdParole
        '
        Me.grdParole.AllowUserToAddRows = False
        Me.grdParole.AllowUserToDeleteRows = False
        Me.grdParole.AllowUserToResizeRows = False
        Me.grdParole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdParole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdParole.Location = New System.Drawing.Point(529, 13)
        Me.grdParole.Name = "grdParole"
        Me.grdParole.ReadOnly = True
        Me.grdParole.RowHeadersVisible = False
        Me.grdParole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdParole.Size = New System.Drawing.Size(259, 425)
        Me.grdParole.TabIndex = 4
        '
        'webTesto
        '
        Me.webTesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webTesto.Location = New System.Drawing.Point(13, 13)
        Me.webTesto.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webTesto.Name = "webTesto"
        Me.webTesto.Size = New System.Drawing.Size(510, 425)
        Me.webTesto.TabIndex = 5
        '
        'EvidenizaParole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.webTesto)
        Me.Controls.Add(Me.grdParole)
        Me.Name = "EvidenizaParole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EvidenizaParole"
        CType(Me.grdParole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdParole As DataGridView
    Friend WithEvents webTesto As WebBrowser
End Class

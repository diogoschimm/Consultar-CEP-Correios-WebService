<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultarCEP
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
        Me.txt_CEP = New System.Windows.Forms.TextBox()
        Me.btn_CEP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_CEP
        '
        Me.txt_CEP.Location = New System.Drawing.Point(13, 34)
        Me.txt_CEP.Name = "txt_CEP"
        Me.txt_CEP.Size = New System.Drawing.Size(100, 20)
        Me.txt_CEP.TabIndex = 0
        '
        'btn_CEP
        '
        Me.btn_CEP.Location = New System.Drawing.Point(120, 34)
        Me.btn_CEP.Name = "btn_CEP"
        Me.btn_CEP.Size = New System.Drawing.Size(75, 23)
        Me.btn_CEP.TabIndex = 1
        Me.btn_CEP.Text = "Buscar"
        Me.btn_CEP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 261)
        Me.Controls.Add(Me.btn_CEP)
        Me.Controls.Add(Me.txt_CEP)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulário de Consulta de CEP (Correios)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_CEP As TextBox
    Friend WithEvents btn_CEP As Button
End Class

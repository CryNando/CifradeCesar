<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CifraCesar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CifraCesar))
        Me.tbTexto = New System.Windows.Forms.TextBox()
        Me.tbResultado = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.btn_Decrypt = New System.Windows.Forms.Button()
        Me.tbKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbTexto
        '
        Me.tbTexto.Location = New System.Drawing.Point(31, 40)
        Me.tbTexto.Multiline = True
        Me.tbTexto.Name = "tbTexto"
        Me.tbTexto.Size = New System.Drawing.Size(646, 162)
        Me.tbTexto.TabIndex = 0
        '
        'tbResultado
        '
        Me.tbResultado.Location = New System.Drawing.Point(31, 253)
        Me.tbResultado.Multiline = True
        Me.tbResultado.Name = "tbResultado"
        Me.tbResultado.Size = New System.Drawing.Size(646, 162)
        Me.tbResultado.TabIndex = 1
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrypt.ForeColor = System.Drawing.Color.Black
        Me.btnEncrypt.Location = New System.Drawing.Point(217, 217)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(106, 23)
        Me.btnEncrypt.TabIndex = 2
        Me.btnEncrypt.Text = "Criptografar"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'btn_Decrypt
        '
        Me.btn_Decrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Decrypt.ForeColor = System.Drawing.Color.Black
        Me.btn_Decrypt.Location = New System.Drawing.Point(329, 217)
        Me.btn_Decrypt.Name = "btn_Decrypt"
        Me.btn_Decrypt.Size = New System.Drawing.Size(106, 23)
        Me.btn_Decrypt.TabIndex = 3
        Me.btn_Decrypt.Text = "Descriptografar"
        Me.btn_Decrypt.UseVisualStyleBackColor = True
        '
        'tbKey
        '
        Me.tbKey.Location = New System.Drawing.Point(577, 217)
        Me.tbKey.Name = "tbKey"
        Me.tbKey.Size = New System.Drawing.Size(100, 20)
        Me.tbKey.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(28, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Digite seu Texto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(533, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Chave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(28, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Texto Gerado"
        '
        'btnLimpar
        '
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar.Location = New System.Drawing.Point(577, 424)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(100, 23)
        Me.btnLimpar.TabIndex = 8
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'CifraCesar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(718, 457)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbKey)
        Me.Controls.Add(Me.btn_Decrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.tbResultado)
        Me.Controls.Add(Me.tbTexto)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(734, 496)
        Me.MinimumSize = New System.Drawing.Size(734, 496)
        Me.Name = "CifraCesar"
        Me.Text = "Cifra de César"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbTexto As System.Windows.Forms.TextBox
    Friend WithEvents tbResultado As System.Windows.Forms.TextBox
    Friend WithEvents btnEncrypt As System.Windows.Forms.Button
    Friend WithEvents btn_Decrypt As System.Windows.Forms.Button
    Friend WithEvents tbKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button

End Class

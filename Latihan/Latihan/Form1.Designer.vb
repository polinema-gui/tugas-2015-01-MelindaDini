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
        Me.Nama = New System.Windows.Forms.Label()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.Keterangan = New System.Windows.Forms.Label()
        Me.infoText = New System.Windows.Forms.TextBox()
        Me.okButton1 = New System.Windows.Forms.Button()
        Me.lengthLabel = New System.Windows.Forms.Label()
        Me.Length = New System.Windows.Forms.Label()
        Me.showButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Location = New System.Drawing.Point(17, 24)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(35, 13)
        Me.Nama.TabIndex = 0
        Me.Nama.Text = "Nama"
        '
        'nameText
        '
        Me.nameText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameText.Location = New System.Drawing.Point(77, 21)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(202, 20)
        Me.nameText.TabIndex = 1
        '
        'Keterangan
        '
        Me.Keterangan.AutoSize = True
        Me.Keterangan.Location = New System.Drawing.Point(17, 59)
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Size = New System.Drawing.Size(62, 13)
        Me.Keterangan.TabIndex = 2
        Me.Keterangan.Text = "Keterangan"
        '
        'infoText
        '
        Me.infoText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoText.Location = New System.Drawing.Point(77, 56)
        Me.infoText.Multiline = True
        Me.infoText.Name = "infoText"
        Me.infoText.Size = New System.Drawing.Size(202, 112)
        Me.infoText.TabIndex = 3
        '
        'okButton1
        '
        Me.okButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okButton1.Location = New System.Drawing.Point(204, 271)
        Me.okButton1.Name = "okButton1"
        Me.okButton1.Size = New System.Drawing.Size(75, 28)
        Me.okButton1.TabIndex = 4
        Me.okButton1.Text = "OK"
        Me.okButton1.UseVisualStyleBackColor = True
        '
        'lengthLabel
        '
        Me.lengthLabel.AutoSize = True
        Me.lengthLabel.Location = New System.Drawing.Point(17, 187)
        Me.lengthLabel.Name = "lengthLabel"
        Me.lengthLabel.Size = New System.Drawing.Size(45, 13)
        Me.lengthLabel.TabIndex = 5
        Me.lengthLabel.Text = "panjang"
        '
        'Length
        '
        Me.Length.AutoSize = True
        Me.Length.Location = New System.Drawing.Point(108, 187)
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(39, 13)
        Me.Length.TabIndex = 6
        Me.Length.Text = "Label4"
        '
        'showButton
        '
        Me.showButton.Location = New System.Drawing.Point(125, 274)
        Me.showButton.Name = "showButton"
        Me.showButton.Size = New System.Drawing.Size(73, 25)
        Me.showButton.TabIndex = 7
        Me.showButton.Text = "Show"
        Me.showButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 370)
        Me.Controls.Add(Me.showButton)
        Me.Controls.Add(Me.Length)
        Me.Controls.Add(Me.lengthLabel)
        Me.Controls.Add(Me.okButton1)
        Me.Controls.Add(Me.infoText)
        Me.Controls.Add(Me.Keterangan)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.Nama)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Latihan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nama As System.Windows.Forms.Label
    Friend WithEvents nameText As System.Windows.Forms.TextBox
    Friend WithEvents Keterangan As System.Windows.Forms.Label
    Friend WithEvents infoText As System.Windows.Forms.TextBox
    Friend WithEvents okButton1 As System.Windows.Forms.Button
    Friend WithEvents lengthLabel As System.Windows.Forms.Label
    Friend WithEvents Length As System.Windows.Forms.Label
    Friend WithEvents showButton As System.Windows.Forms.Button

End Class

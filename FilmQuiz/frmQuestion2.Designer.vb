<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnAnswer2 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer3 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer4 = New System.Windows.Forms.RadioButton()
        Me.btnAnswer1 = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(678, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Which superhero did batman fight in  The Dark knight Returns?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 154)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(212, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(488, 103)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 190)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'btnAnswer2
        '
        Me.btnAnswer2.AutoSize = True
        Me.btnAnswer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer2.Location = New System.Drawing.Point(260, 170)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(136, 28)
        Me.btnAnswer2.TabIndex = 3
        Me.btnAnswer2.TabStop = True
        Me.btnAnswer2.Text = "Green Arrow"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.AutoSize = True
        Me.btnAnswer3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer3.Location = New System.Drawing.Point(260, 219)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(113, 28)
        Me.btnAnswer3.TabIndex = 4
        Me.btnAnswer3.TabStop = True
        Me.btnAnswer3.Text = "The Flash"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.AutoSize = True
        Me.btnAnswer4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer4.Location = New System.Drawing.Point(260, 265)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(141, 28)
        Me.btnAnswer4.TabIndex = 5
        Me.btnAnswer4.TabStop = True
        Me.btnAnswer4.Text = "Superwoman"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'btnAnswer1
        '
        Me.btnAnswer1.AutoSize = True
        Me.btnAnswer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnswer1.Location = New System.Drawing.Point(260, 127)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(116, 28)
        Me.btnAnswer1.TabIndex = 6
        Me.btnAnswer1.TabStop = True
        Me.btnAnswer1.Text = "Superman"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(573, 361)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(155, 54)
        Me.btnNext.TabIndex = 7
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'frmQuestion2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnAnswer1)
        Me.Controls.Add(Me.btnAnswer4)
        Me.Controls.Add(Me.btnAnswer3)
        Me.Controls.Add(Me.btnAnswer2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuestion2"
        Me.Text = "Which superhero did batman fight in Dark Knight Returns?"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnAnswer2 As RadioButton
    Friend WithEvents btnAnswer3 As RadioButton
    Friend WithEvents btnAnswer4 As RadioButton
    Friend WithEvents btnAnswer1 As RadioButton
    Friend WithEvents btnNext As Button
End Class

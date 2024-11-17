<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lsttaille = New ComboBox()
        rb1 = New RadioButton()
        rb3 = New RadioButton()
        rb2 = New RadioButton()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        Btn = New Button()
        SuspendLayout()
        ' 
        ' lsttaille
        ' 
        lsttaille.FormattingEnabled = True
        lsttaille.Items.AddRange(New Object() {"petite", "moyenne", "grande"})
        lsttaille.Location = New Point(47, 42)
        lsttaille.Name = "lsttaille"
        lsttaille.Size = New Size(121, 23)
        lsttaille.TabIndex = 0
        ' 
        ' rb1
        ' 
        rb1.AutoSize = True
        rb1.Location = New Point(47, 138)
        rb1.Name = "rb1"
        rb1.Size = New Size(82, 19)
        rb1.TabIndex = 1
        rb1.TabStop = True
        rb1.Text = "croute fine"
        rb1.UseVisualStyleBackColor = True
        ' 
        ' rb3
        ' 
        rb3.AutoSize = True
        rb3.Location = New Point(354, 138)
        rb3.Name = "rb3"
        rb3.Size = New Size(100, 19)
        rb3.TabIndex = 4
        rb3.TabStop = True
        rb3.Text = "croute epaisse"
        rb3.UseVisualStyleBackColor = True
        ' 
        ' rb2
        ' 
        rb2.AutoSize = True
        rb2.Location = New Point(186, 138)
        rb2.Name = "rb2"
        rb2.Size = New Size(110, 19)
        rb2.TabIndex = 5
        rb2.TabStop = True
        rb2.Text = "croute classique"
        rb2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(47, 206)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(101, 19)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Champignons"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(47, 255)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(58, 19)
        CheckBox2.TabIndex = 7
        CheckBox2.Text = "Olives"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(47, 310)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(72, 19)
        CheckBox3.TabIndex = 8
        CheckBox3.Text = "Poivrons"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(47, 363)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(158, 19)
        CheckBox4.TabIndex = 9
        CheckBox4.Text = "Fromage supplémentaire"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Btn
        ' 
        Btn.Location = New Point(318, 342)
        Btn.Name = "Btn"
        Btn.Size = New Size(188, 59)
        Btn.TabIndex = 10
        Btn.Text = "Afficher le récapitulatif"
        Btn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Btn)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(rb2)
        Controls.Add(rb3)
        Controls.Add(rb1)
        Controls.Add(lsttaille)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsttaille As ComboBox
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Btn As Button

End Class

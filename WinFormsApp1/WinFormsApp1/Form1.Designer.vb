<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox2 = New ComboBox()
        Label3 = New Label()
        ComboBox3 = New ComboBox()
        Label4 = New Label()
        ComboBox4 = New ComboBox()
        Label5 = New Label()
        ComboBox5 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(76, 12)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(196, 33)
        ComboBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Location = New Point(8, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 1
        Label1.Text = "Family"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 25)
        Label2.TabIndex = 2
        Label2.Text = "Size"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(76, 72)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(196, 33)
        ComboBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 25)
        Label3.TabIndex = 4
        Label3.Text = "Pitch"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(76, 140)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(196, 33)
        ComboBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 25)
        Label4.TabIndex = 6
        Label4.Text = "Color"
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(76, 206)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(196, 33)
        ComboBox4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(5, 284)
        Label5.Name = "Label5"
        Label5.Size = New Size(65, 25)
        Label5.TabIndex = 8
        Label5.Text = "Border"
        ' 
        ' ComboBox5
        ' 
        ComboBox5.FormattingEnabled = True
        ComboBox5.Location = New Point(76, 281)
        ComboBox5.Name = "ComboBox5"
        ComboBox5.Size = New Size(196, 33)
        ComboBox5.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(27, 372)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 10
        Button1.Text = "Ok"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(301, 372)
        Button2.Name = "Button2"
        Button2.RightToLeft = RightToLeft.No
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 11
        Button2.Text = "Apply"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(562, 372)
        Button3.Name = "Button3"
        Button3.RightToLeft = RightToLeft.No
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 12
        Button3.Text = "Cancel"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(562, 10)
        Button4.Name = "Button4"
        Button4.RightToLeft = RightToLeft.No
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 13
        Button4.Text = "Help"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(686, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox5)
        Controls.Add(Label5)
        Controls.Add(ComboBox4)
        Controls.Add(Label4)
        Controls.Add(ComboBox3)
        Controls.Add(Label3)
        Controls.Add(ComboBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Text Properties"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class

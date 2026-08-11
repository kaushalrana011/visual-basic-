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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.Location = New Point(450, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 54)
        Label1.TabIndex = 0
        Label1.Text = "Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.Location = New Point(95, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(171, 38)
        Label2.TabIndex = 1
        Label2.Text = "Enter Digit 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F)
        Label3.Location = New Point(95, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(171, 38)
        Label3.TabIndex = 2
        Label3.Text = "Enter Digit 2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(354, 159)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 3
        TextBox1.Text = " "
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(354, 229)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.Location = New Point(653, 157)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 43)
        Button1.TabIndex = 5
        Button1.Text = "Add (+)"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.Location = New Point(653, 221)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 43)
        Button2.TabIndex = 6
        Button2.Text = "Sub (-)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button3.Location = New Point(653, 296)
        Button3.Name = "Button3"
        Button3.Size = New Size(164, 43)
        Button3.TabIndex = 7
        Button3.Text = "Multiply (*)"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button4.Location = New Point(959, 151)
        Button4.Name = "Button4"
        Button4.Size = New Size(160, 43)
        Button4.TabIndex = 8
        Button4.Text = "Division (/)"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button5.Location = New Point(959, 217)
        Button5.Name = "Button5"
        Button5.Size = New Size(181, 43)
        Button5.TabIndex = 9
        Button5.Text = "Modulus (%)"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button6.Location = New Point(959, 296)
        Button6.Name = "Button6"
        Button6.Size = New Size(112, 43)
        Button6.TabIndex = 10
        Button6.Text = "Power"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1362, 929)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button

End Class

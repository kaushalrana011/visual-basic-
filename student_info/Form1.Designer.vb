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
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold Or FontStyle.Underline)
        Label1.Location = New Point(298, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(280, 54)
        Label1.TabIndex = 1
        Label1.Text = "Student Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F)
        Label2.LiveSetting = Automation.AutomationLiveSetting.Assertive
        Label2.Location = New Point(99, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 38)
        Label2.TabIndex = 2
        Label2.Text = "Roll Number"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(429, 129)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(137, 31)
        TextBox1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F)
        Label3.LiveSetting = Automation.AutomationLiveSetting.Assertive
        Label3.Location = New Point(99, 183)
        Label3.Name = "Label3"
        Label3.Size = New Size(91, 38)
        Label3.TabIndex = 8
        Label3.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F)
        Label4.LiveSetting = Automation.AutomationLiveSetting.Assertive
        Label4.Location = New Point(99, 247)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 38)
        Label4.TabIndex = 9
        Label4.Text = "Branch"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F)
        Label5.LiveSetting = Automation.AutomationLiveSetting.Assertive
        Label5.Location = New Point(99, 307)
        Label5.Name = "Label5"
        Label5.Size = New Size(132, 38)
        Label5.TabIndex = 10
        Label5.Text = "Semester"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F)
        Label6.LiveSetting = Automation.AutomationLiveSetting.Assertive
        Label6.Location = New Point(99, 376)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 38)
        Label6.TabIndex = 11
        Label6.Text = "Email"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(429, 191)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(137, 31)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(429, 255)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(137, 31)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(429, 315)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(137, 31)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(429, 384)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(137, 31)
        TextBox5.TabIndex = 15
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Button1.Location = New Point(276, 513)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 53)
        Button1.TabIndex = 16
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1183, 682)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button

End Class

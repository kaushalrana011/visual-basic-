Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim studentName As String = TextBox1.Text
        Dim fatherName As String = TextBox2.Text
        Dim motherName As String = TextBox3.Text
        Dim phoneNumber As String = TextBox4.Text
        Dim dob As String = DateTimePicker1.Value.ToShortDateString()
        Dim course As String = ComboBox1.Text

        Dim gender As String = ""
        If RadioButton1.Checked Then
            gender = "Male"
        ElseIf RadioButton2.Checked Then
            gender = "Female"
        End If

        Dim edu As String = ""
        If CheckBox1.Checked Then edu += "10th "
        If CheckBox2.Checked Then edu += "12th "
        If CheckBox3.Checked Then edu += "UG "
        If CheckBox4.Checked Then edu += "PG"

        Dim bus As String = ""
        If RadioButton3.Checked Then bus = "Yes" Else bus = "No"

        Dim hostel As String = ""
        If RadioButton5.Checked Then hostel = "Yes" Else hostel = "No"

        Dim info As String = "Student Name: " & studentName & vbCrLf &
                             "Father's Name: " & fatherName & vbCrLf &
                             "Mother's Name: " & motherName & vbCrLf &
                             "Phone Number: " & phoneNumber & vbCrLf &
                             "Date of Birth: " & dob & vbCrLf &
                             "Course: " & course & vbCrLf &
                             "Gender: " & gender & vbCrLf &
                             "Education: " & edu & vbCrLf &
                             "Bus Facility: " & bus & vbCrLf &
                             "Hostel Facility: " & hostel

        MessageBox.Show(info, "Submitted Information")
    End Sub

End Class

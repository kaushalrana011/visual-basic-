Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Server=localhost\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("Insert Into Students(Name,Age,Course,Mobile) Values(@Name,@Age,@Course,@Mobile)", con)
            cmd.Parameters.AddWithValue("@Roll", txtID.Text)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Age", txtAge.Text)
            cmd.Parameters.AddWithValue("@Course", txtCourse.Text)
            cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Inserted Successfully")
            LoadData()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand("UPDATE Students SET Name=@Name, Age=@Age, Course=@Course, Mobile=@Mobile WHERE StudentID=@StudentID", con)
            cmd.Parameters.AddWithValue("@Roll No", txtID.Text)
            cmd.Parameters.AddWithValue("@Name", txtName.Text)
            cmd.Parameters.AddWithValue("@Age", txtAge.Text)
            cmd.Parameters.AddWithValue("@Course", txtCourse.Text)
            cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record Updated Successfully")
            LoadData()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con.Open()
        Dim cmd As New SqlCommand("DELETE FROM Students WHERE StudentID=@id", con)
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Record Deleted Successfully")
        LoadData()
        con.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        con.Open()
        Dim cmd As New SqlCommand("SELECT * FROM Students WHERE StudentID=@id", con)
        cmd.Parameters.AddWithValue("@id", txtID.Text)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            txtName.Text = dr("Name").ToString()
            txtAge.Text = dr("Age").ToString()
            txtCourse.Text = dr("Course").ToString()
            txtMobile.Text = dr("Mobile").ToString()
        Else
            MessageBox.Show("Record Not Found")
        End If
        con.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Focus()
        LoadData()
    End Sub
    Sub LoadData()
        Dim da As New SqlDataAdapter("SELECT * FROM Students", con)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class

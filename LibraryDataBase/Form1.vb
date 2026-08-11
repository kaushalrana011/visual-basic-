Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class Form1
    Dim con As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "Insert Into Books Values(" &
                              txtBookID.Text &
                              ",'" &
                              txtBookName.Text &
                              "','" &
                              txtAuthor.Text &
                              "','Available')"

            cmd.ExecuteNonQuery()
            MsgBox("Book Added Successfully")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "Update Books Set Status='Issued' Where BookID=" &
                          txtBookID.Text

            cmd.ExecuteNonQuery()
            MsgBox("Book Issued")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "Update Books Set Status='Available' Where BookID=" &
                              txtBookID.Text
            cmd.ExecuteNonQuery()
            MsgBox("Book Returned")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            con.Open()
            Dim cmd As New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "Select * From Books Where BookID=" &
                              txtBookID.Text
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                txtBookName.Text = dr("BookName")
                txtAuthor.Text = dr("Author")
                MsgBox("Status : " & dr("Status"))
            Else
                MsgBox("Book Not Found")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim da As New SqlDataAdapter
            Dim ds As New DataSet
            da = New SqlDataAdapter("Select * From Books", con)
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class


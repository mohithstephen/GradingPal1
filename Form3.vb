Public Class Form3


    Private Sqlconstring As String = "Data Source=TXDDY;Initial Catalog=GradingPal1;Integrated Security=True;Encrypt=False;Trust Server Certificate=True"

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        Dim query As String = "SELECT * FROM Student"
        Dim connection As New SqlConnection("Data Source=TXDDY;Initial Catalog=GradingPal1;Integrated Security=True;Encrypt=False;Trust Server Certificate=True")
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim dataTable As New DataTable()
        Try
            connection.Open()
            adapter.Fill(dataTable)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        TextBox4.Text = String.Empty
        TextBox5.Text = String.Empty
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String = "INSERT INTO Student (SName, RollNo, Class, Section, Email) VALUES (@SName, @RollNo, @Class, @Section, @Email)"
        Dim connection As New SqlConnection("Data Source=TXDDY;Initial Catalog=GradingPal1;Integrated Security=True;Encrypt=False")
        Dim command As New SqlCommand(query, connection)


        command.Parameters.AddWithValue("@SName", TextBox1.Text)
        command.Parameters.AddWithValue("@RollNo", TextBox2.Text)
        command.Parameters.AddWithValue("@Class", TextBox3.Text)
        command.Parameters.AddWithValue("@Section", TextBox4.Text)
        command.Parameters.AddWithValue("@Email", TextBox5.Text)

        Try
            connection.Open()
            command.ExecuteNonQuery()
            MessageBox.Show("Data inserted successfully.")
            LoadData() ' Reload data after insertion
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub





End Class
Imports System.IO

Public Class Form1
    Dim filePath As String = "sample.txt"
    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click

        Using writer As New StreamWriter(filePath, True)
            writer.WriteLine("hello, this is a file test")
            writer.WriteLine("second line of the text")
        End Using
        MessageBox.Show("Data written succesfully", "error")
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click

        Using reader As New StreamReader(filePath)
            Dim content As String = reader.ReadToEnd()
            MessageBox.Show("File content: " + content)
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Using reader As New StreamReader(filePath)
            Dim line As String
            line = reader.ReadLine()
            While (line IsNot Nothing)
                ListBox1.Items.Add(line)
                line = reader.ReadLine()
            End While



        End Using
    End Sub
End Class

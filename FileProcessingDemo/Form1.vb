Imports System.IO

Public Class Form1
    Private Sub ButtonWrite_Click(sender As Object, e As EventArgs) Handles ButtonWrite.Click
        Dim filePath As String = "sample.txt"
        Using writer As New StreamWriter(filePath, True)
            writer.WriteLine("hello, this is a file test")
            writer.WriteLine("second line of the text")
        End Using
        MessageBox.Show("Data written succesfully", "error")
    End Sub

    Private Sub ButtonRead_Click(sender As Object, e As EventArgs) Handles ButtonRead.Click
        Dim filePath As String = "sample.txt"
        Using reader As New StreamReader(filePath)
            Dim content As String = reader.ReadToEnd()
            MessageBox.Show("File content: " + content)
        End Using
    End Sub
End Class

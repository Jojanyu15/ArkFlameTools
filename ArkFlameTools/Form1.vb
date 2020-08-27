Option Strict Off
Option Explicit On

Public Class presentacion

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        inicio.Show()
        Me.Hide()
    End Sub
End Class
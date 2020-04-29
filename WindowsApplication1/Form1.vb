Imports System.Drawing.Graphics
Public Class Form1
    Const A_Width = 40
    Const A_Height = 160
    Const T_Width = 40
    Const T_Height = 40
    Dim BM As Bitmap
    Dim g As Graphics
    Dim Lx, Ly As Integer
    Dim X1, X2, V1, V2, t, DS, DT As Single

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DS = X2 - X1 - A_Width
        t = DS / V1
        If DT > t And CheckBox1.Checked Then DT = t / 100
        X1 = X1 + V1 * DT
        X2 = X2 + V2 * DT
        g.Clear(Color.Yellow)
        g.FillRectangle(Brushes.Chocolate, X1, Ly - A_Height, A_Width, A_Height)
        g.FillEllipse(Brushes.DarkGreen, X2, Ly - T_Height \ 2, T_Width, T_Height)
        PictureBox1.Image = BM
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lx = PictureBox1.DisplayRectangle.Width
        Ly = PictureBox1.DisplayRectangle.Height
        BM = New Bitmap(Lx, Ly)
        g = FromImage(BM)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        V1 = Val(TextBox1.Text)
        V2 = Val(TextBox2.Text)
        X1 = 0
        X2 = Lx / 4
        DT = (X2 - X1) / V1 / 100
        g.Clear(Color.Yellow)
        g.FillRectangle(Brushes.Chocolate, X1, Ly - A_Height, A_Width, A_Height)
        g.FillEllipse(Brushes.DarkGreen, X2, Ly - T_Height \ 2, T_Width, T_Height)
        PictureBox1.Image = BM

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = False
    End Sub
End Class

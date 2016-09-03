Public Class Form_Archimedes
    Dim ArchimedesCurve As Bitmap = New Bitmap(540, 480)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static 时间 As Single = 0.0
        Static I As Integer = 1
        时间 += 0.05 * I
        Dim 偏移量 As Integer = 15
        Dim 位置 As Integer = 偏移量 * (时间 + 1)
        Dim X As Integer = 270 + 位置 * Math.Cos(时间 + Math.PI / 4)
        Dim Y As Integer = 240 + 位置 * Math.Sin(时间 + Math.PI / 4)
        Try
            ArchimedesCurve.SetPixel(X, Y, IIf(I = 1, Color.Blue, Color.Yellow))
            PictureBox1.Image = ArchimedesCurve
        Catch ex As Exception
            I = -I
        End Try
    End Sub

End Class

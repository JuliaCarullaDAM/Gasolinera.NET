Public Class Form1
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles pbSortidor1.MouseHover, pbSortidor2.MouseHover, pbSortidor3.MouseHover, pbSortidor4.MouseHover, pbSortidor5.MouseHover, pbSortidor6.MouseHover
        Dim pbSeleccionada As PictureBox = DirectCast(sender, PictureBox)
        pbSeleccionada.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles pbSortidor1.MouseLeave, pbSortidor2.MouseLeave, pbSortidor3.MouseLeave, pbSortidor4.MouseLeave, pbSortidor5.MouseLeave, pbSortidor6.MouseLeave
        Dim pbSeleccionada As PictureBox = DirectCast(sender, PictureBox)
        pbSeleccionada.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub pbSortidor1_Click(sender As Object, e As EventArgs) Handles pbSortidor1.Click
        Dim formNou As New FormEstatSortidor("1")
        formNou.Show()
    End Sub

    Private Sub pbSortidor2_Click(sender As Object, e As EventArgs) Handles pbSortidor2.Click
        Dim formNou As New FormEstatSortidor("2")
        formNou.Show()
    End Sub

    Private Sub pbSortidor3_Click(sender As Object, e As EventArgs) Handles pbSortidor3.Click
        Dim formNou As New FormEstatSortidor("3")
        formNou.Show()
    End Sub

    Private Sub pbSortidor4_Click(sender As Object, e As EventArgs) Handles pbSortidor4.Click
        Dim formNou As New FormEstatSortidor("4")
        formNou.Show()
    End Sub

    Private Sub pbSortidor5_Click(sender As Object, e As EventArgs) Handles pbSortidor5.Click
        Dim formNou As New FormEstatSortidor("5")
        formNou.Show()
    End Sub

    Private Sub pbSortidor6_Click(sender As Object, e As EventArgs) Handles pbSortidor6.Click
        Dim formNou As New FormEstatSortidor("6")
        formNou.Show()
    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs) Handles Label66.Click

    End Sub
End Class

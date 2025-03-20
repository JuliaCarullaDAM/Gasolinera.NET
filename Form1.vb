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

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            ActualitzarInfoDiposits()
        ElseIf TabControl1.SelectedIndex = 2
            ActualitzarInfoEnergia()
        End If
    End Sub

    Private Sub ActualitzarInfoEnergia()
        'gestionar resultats nulls!!!
        lbVehiclesSubministratsEnergia5.Text = "Vehicles carregats: " + SubministramentTableAdapter.SelectCountVehiclesElectrics(gbSortidor5Energia.Tag.ToString, dataIniciS5.Value, dataFiS5.Value).ToString
        lbEnergiaS5.Text = "Energia subministrada: " + SubministramentTableAdapter.SelectQuantitatSortidor(gbSortidor5Energia.Tag.ToString, dataIniciS5.Value, dataFiS5.Value).ToString + "kW/h"
        lbPreuMigS5.Text = "Preu mitjà: " + SubministramentTableAdapter.PreuMitjaData("5", dataIniciS5.Value, dataFiS5.Value).ToString + " €"

        'DataGrids
        dgvSortidor5.DataSource = SubministramentTableAdapter.GetDataByEnergiaSortidorData(gbSortidor5Energia.Tag.ToString, dataIniciS5.Value, dataFiS5.Value)
        dgvSortidor6.DataSource = SubministramentTableAdapter.GetDataByEnergiaSortidorData(gbSortidor6Energia.Tag.ToString, dataIniciS6.Value, dataFiS6.Value)
        dgvSortidorsElectrics.DataSource = SubministramentTableAdapter.GetDataEnergiaData(dataIniciTotal.Value, dataFiTotal.Value)

    End Sub

    Private Sub ActualitzarInfoDiposits()
        'Gasolina 95
        lbTotal95.Text = "Total combinat: " + DipositTableAdapter.SelectTotalTipusCombustible(gbGasolina95.Tag.ToString).ToString
        lbDisponible95.Text = "Disponible combinat: " + DipositTableAdapter.SelectActualTipusCombustible(gbGasolina95.Tag.ToString).ToString

        tg95s1.Text = DipositsLabelInfo(gbGasolina95.Tag.ToString, tg95s1.Tag.ToString)
        tg95s2.Text = DipositsLabelInfo(gbGasolina95.Tag.ToString, tg95s2.Tag.ToString)
        tg95s3.Text = DipositsLabelInfo(gbGasolina95.Tag.ToString, tg95s3.Tag.ToString)
        tg95s4.Text = DipositsLabelInfo(gbGasolina95.Tag.ToString, tg95s4.Tag.ToString)

        'Gasolina 98
        lbTotal98.Text = "Total combinat: " + DipositTableAdapter.SelectTotalTipusCombustible(gbGasolina98.Tag.ToString).ToString
        lbDisponible98.Text = "Disponible combinat: " + DipositTableAdapter.SelectActualTipusCombustible(gbGasolina98.Tag.ToString).ToString

        tg98s1.Text = DipositsLabelInfo(gbGasolina98.Tag.ToString, tg98s1.Tag.ToString)
        tg98s2.Text = DipositsLabelInfo(gbGasolina98.Tag.ToString, tg98s2.Tag.ToString)
        tg98s3.Text = DipositsLabelInfo(gbGasolina98.Tag.ToString, tg98s3.Tag.ToString)
        tg98s4.Text = DipositsLabelInfo(gbGasolina98.Tag.ToString, tg98s4.Tag.ToString)

        'Diesel
        lbTotalDiesel.Text = "Total combinat: " + DipositTableAdapter.SelectTotalTipusCombustible(gbDiesel.Tag.ToString).ToString
        lbDisponibleDiesel.Text = "Disponible combinat: " + DipositTableAdapter.SelectActualTipusCombustible(gbDiesel.Tag.ToString).ToString

        tDs1.Text = DipositsLabelInfo(gbDiesel.Tag.ToString, tDs1.Tag.ToString)
        tDs2.Text = DipositsLabelInfo(gbDiesel.Tag.ToString, tDs2.Tag.ToString)
        tDs3.Text = DipositsLabelInfo(gbDiesel.Tag.ToString, tDs3.Tag.ToString)
        tDs4.Text = DipositsLabelInfo(gbDiesel.Tag.ToString, tDs4.Tag.ToString)

        'AdBlue
        lbTotalAdblue.Text = "Total combinat: " + DipositTableAdapter.SelectTotalTipusCombustible(gbAdBlue.Tag.ToString).ToString
        lbDisponibleAdBlue.Text = "Disponible combinat: " + DipositTableAdapter.SelectActualTipusCombustible(gbAdBlue.Tag.ToString).ToString

        tAs1.Text = DipositsLabelInfo(gbAdBlue.Tag.ToString, tAs1.Tag.ToString)
        tAs2.Text = DipositsLabelInfo(gbAdBlue.Tag.ToString, tAs2.Tag.ToString)
        tAs3.Text = DipositsLabelInfo(gbAdBlue.Tag.ToString, tAs3.Tag.ToString)
        tAs4.Text = DipositsLabelInfo(gbAdBlue.Tag.ToString, tAs4.Tag.ToString)
    End Sub

    Private Function DipositsLabelInfo(combustibleTag As String, sortidorTag As String) As String
        Dim tmpTotal, tmpActual As Double
        Dim percentatge As Integer
        Dim text As String

        tmpTotal = DipositTableAdapter.SelectTotalSortidor(combustibleTag, sortidorTag).ToString
        tmpActual = DipositTableAdapter.SelectActualSortidor(combustibleTag, sortidorTag).ToString

        text = "Total: " + tmpTotal.ToString + Space(5) +
                    "Disponible: " + tmpActual.ToString + Space(5) +
                    "Percentatge: " + CInt(tmpActual / tmpTotal * 100).ToString + "%"

        Return text
    End Function

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOKS5.Click, btOKS6.Click, btOKTotal.Click
        ActualitzarInfoEnergia()
    End Sub

    Private Sub btReset_Click(sender As Object, e As EventArgs) Handles btResetS5.Click, btResetS6.Click, btResetTotal.Click
        Dim bt As Button = CType(sender, Button)

        If bt.Tag.ToString = "5" Then
            dataIniciS5.Value = "01/01/2025"
            dataFiS5.Value = "31/12/2025"
            ActualitzarInfoEnergia()

        ElseIf bt.Tag.ToString = "6"
            dataIniciS6.Value = "01/01/2025"
            dataFiS6.Value = "31/12/2025"
            ActualitzarInfoEnergia()

        ElseIf bt.Tag.ToString = "0"
            dataIniciTotal.Value = "01/01/2025"
            dataFiTotal.Value = "31/12/2025"
            ActualitzarInfoEnergia()
        End If
    End Sub
End Class

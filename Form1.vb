Public Class Form1
    Private Const ID_ENERGIA = "5"
    Private _idPreuCombustible As String = ""
    Private ticksForaDeServei As Integer = 0
    Private idSortidor As Integer = 0
    Private informeCombustible As Integer = 0
    Private informeFiltrarCombustible As Boolean = False

    Private Sub PictureBox_MouseHover(sender As Object, e As EventArgs) Handles pbSortidor1.MouseHover, pbSortidor2.MouseHover, pbSortidor3.MouseHover, pbSortidor4.MouseHover, pbSortidor5.MouseHover, pbSortidor6.MouseHover
        Dim pbSeleccionada As PictureBox = DirectCast(sender, PictureBox)
        pbSeleccionada.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub PictureBox_MouseLeave(sender As Object, e As EventArgs) Handles pbSortidor1.MouseLeave, pbSortidor2.MouseLeave, pbSortidor3.MouseLeave, pbSortidor4.MouseLeave, pbSortidor5.MouseLeave, pbSortidor6.MouseLeave
        Dim pbSeleccionada As PictureBox = DirectCast(sender, PictureBox)
        pbSeleccionada.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub pbSortidor_Click(sender As Object, e As EventArgs) Handles pbSortidor1.Click, pbSortidor2.Click, pbSortidor3.Click, pbSortidor4.Click, pbSortidor5.Click, pbSortidor6.Click
        Dim pbSeleccionada As PictureBox = DirectCast(sender, PictureBox)
        Dim idSortidor = pbSeleccionada.Tag.ToString

        Dim formNou As New FormEstatSortidor(idSortidor)
        formNou.Show()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            ActualitzarInfoDiposits()
        ElseIf TabControl1.SelectedIndex = 2
            ActualitzarInfoEnergia()
        ElseIf TabControl1.SelectedIndex = 3
            CarregarComandes()
        ElseIf TabControl1.SelectedIndex = 4
            CarregarDGV()
        ElseIf TabControl1.SelectedIndex = 5
            comboInformeTrimestre.SelectedIndex = 0
        End If
    End Sub

    Private Sub CarregarComandes()
        Try
            dgvComandesRebudes.DataSource = COMANDATableAdapter.GetComandesByEstat("Rebut")
            dgvComandesProces.DataSource = COMANDATableAdapter.GetComandesByEstat("En procés")
            dgvComandesCancelades.DataSource = COMANDATableAdapter.GetComandesByEstat("Cancel·lat")
        Catch ex As Exception
            Console.Write("Error al carregar les dades.")
        End Try
    End Sub

    Private Sub CarregarDGV()
        Try
            dgvPreuGas95.DataSource = HISTORIAL_PREUSTableAdapter.GetDataByIdCarburant(dgvPreuGas95.Tag.ToString)
            dgvPreuGas98.DataSource = HISTORIAL_PREUSTableAdapter.GetDataByIdCarburant(dgvPreuGas98.Tag.ToString)
            dgvPreuDiesel.DataSource = HISTORIAL_PREUSTableAdapter.GetDataByIdCarburant(dgvPreuDiesel.Tag.ToString)
            dgvPreuAdblue.DataSource = HISTORIAL_PREUSTableAdapter.GetDataByIdCarburant(dgvPreuAdblue.Tag.ToString)
            dgvPreuElectricitat.DataSource = HISTORIAL_PREUSTableAdapter.GetDataByIdCarburant(dgvPreuElectricitat.Tag.ToString)
        Catch ex As Exception
            Console.Write("No s'han trobat dades")
        End Try
    End Sub

    Private Sub ActualitzarInfoEnergia()
        'Labels de cada groupbox
        LabelsEnergia(lbVehiclesSubministratsEnergia5, lbEnergiaS5, lbPreuMigS5, lbIngressosS5, gbSortidor5Energia.Tag.ToString, dataIniciS5.Value, dataFiS5.Value)
        LabelsEnergia(lbVehiclesSubministratsEnergia6, lbEnergiaS6, lbPreuMigS6, lbIngressosS6, gbSortidor6Energia.Tag.ToString, dataIniciS6.Value, dataFiS6.Value)
        LabelsEnergia(lbVehiclesSubministratsEnergiaTotal, lbEnergiaTotal, lbPreuMitjaTotal, lbIngressosTotal, dataIniciTotal.Value, dataFiTotal.Value)

        'DataGrids
        Try
            dgvSortidor5.DataSource = SubministramentTableAdapter.GetDataByEnergiaSortidorData(gbSortidor5Energia.Tag.ToString, dataIniciS5.Value, dataFiS5.Value)
            dgvSortidor6.DataSource = SubministramentTableAdapter.GetDataByEnergiaSortidorData(gbSortidor6Energia.Tag.ToString, dataIniciS6.Value, dataFiS6.Value)
            dgvSortidorsElectrics.DataSource = SubministramentTableAdapter.GetDataEnergiaData(dataIniciTotal.Value, dataFiTotal.Value)
        Catch ex As Exception
            MessageBox.Show("Error al carregar les dades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LabelsEnergia(lbVehicles As Label, lbEnergia As Label, lbPreuMig As Label, lbIngressos As Label, idSortidor As String, dataInici As Date, dataFi As Date)
        Dim incorrecte As Boolean = False

        If dataInici <= dataFi Then
            Try
                lbVehicles.Text = "Vehicles carregats: " + SubministramentTableAdapter.SelectCountVehiclesElectrics(idSortidor, dataInici, dataFi).ToString
                lbEnergia.Text = "Energia subministrada: " + SubministramentTableAdapter.SelectQuantitatSortidor(idSortidor, dataInici, dataFi).ToString + "kW"
                lbPreuMig.Text = "Preu mitjà: " + CDbl(SubministramentTableAdapter.PreuMitjaData(ID_ENERGIA, dataInici, dataFi)).ToString("F3") + " €/kW"
                lbIngressos.Text = "Ingressos: " + SubministramentTableAdapter.SelectImportFromSortidorData(ID_ENERGIA, idSortidor, dataInici, dataFi).ToString + " €"
            Catch ex As Exception
                MessageBox.Show("No s'han trobat resultats ", "Sense resultats", MessageBoxButtons.OK, MessageBoxIcon.Information)
                incorrecte = True
            End Try

        Else
            MessageBox.Show("La data final és menor que la data inicial", "Data incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            incorrecte = True
        End If

        If incorrecte Then
            lbVehicles.Text = "Vehicles carregats: "
            lbEnergia.Text = "Energia subministrada: "
            lbPreuMig.Text = "Preu mitjà: "
            lbIngressos.Text = "Ingressos: "
        End If
    End Sub

    Private Sub LabelsEnergia(lbVehicles As Label, lbEnergia As Label, lbPreuMig As Label, lbIngressos As Label, dataInici As Date, dataFi As Date)
        Dim incorrecte As Boolean = False

        If dataInici <= dataFi Then
            Try
                lbVehicles.Text = "Vehicles carregats: " + SubministramentTableAdapter.SelectAllCountElectrics(dataInici, dataFi).ToString
                lbEnergia.Text = "Energia subministrada: " + SubministramentTableAdapter.SelectQuantitatTotal(dataInici, dataFi).ToString + "kW"
                lbPreuMig.Text = "Preu mitjà: " + CDbl(SubministramentTableAdapter.PreuMitjaData(ID_ENERGIA, dataInici, dataFi)).ToString("F3") + " €/kW"
                lbIngressos.Text = "Ingressos: " + SubministramentTableAdapter.SelectImportTotalData(ID_ENERGIA, dataInici, dataFi).ToString + " €"
            Catch ex As Exception
                MessageBox.Show("No s'han trobat resultats ", "Sense resultats", MessageBoxButtons.OK, MessageBoxIcon.Information)
                incorrecte = True
            End Try

        Else
            MessageBox.Show("No s'han trobat resultats ", "Data incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            incorrecte = True
        End If

        If incorrecte Then
            lbVehicles.Text = "Vehicles carregats: "
            lbEnergia.Text = "Energia subministrada: "
            lbPreuMig.Text = "Preu mitjà: "
            lbIngressos.Text = "Ingressos: "
        End If
    End Sub

    Private Sub ActualitzarInfoDiposits()
        Try
            'Gasolina 95
            lbTotal95.Text = "Total combinat: " + DipositTableAdapter.SelectTotalTipusCombustible(gbGasolina95.Tag.ToString).ToString
            lbDisponible95.Text = "Disponible combinat: " + DipositTableAdapter.SelectActualTipusCombustible(gbGasolina95.Tag.ToString).ToString

            'Gasolina 98
            lbTotal98.Text = "Total combinat: " + DipositTableAdapter.SelectTotalTipusCombustible(gbGasolina98.Tag.ToString).ToString
            lbDisponible98.Text = "Disponible combinat: " + DipositTableAdapter.SelectActualTipusCombustible(gbGasolina98.Tag.ToString).ToString

            'Diesel
            lbTotalDiesel.Text = "Total combinat: " + DipositTableAdapter.SelectTotalTipusCombustible(gbDiesel.Tag.ToString).ToString
            lbDisponibleDiesel.Text = "Disponible combinat: " + DipositTableAdapter.SelectActualTipusCombustible(gbDiesel.Tag.ToString).ToString

            'AdBlue
            lbTotalAdblue.Text = "Total combinat: " + DipositTableAdapter.SelectTotalTipusCombustible(gbAdBlue.Tag.ToString).ToString
            lbDisponibleAdBlue.Text = "Disponible combinat: " + DipositTableAdapter.SelectActualTipusCombustible(gbAdBlue.Tag.ToString).ToString
        Catch ex As Exception
            MessageBox.Show("Error al carregar les dades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Gasolina 95
        tg95s1.Text = DipositsLabelInfo(gbGasolina95.Tag.ToString, tg95s1.Tag.ToString)
        tg95s2.Text = DipositsLabelInfo(gbGasolina95.Tag.ToString, tg95s2.Tag.ToString)
        tg95s3.Text = DipositsLabelInfo(gbGasolina95.Tag.ToString, tg95s3.Tag.ToString)
        tg95s4.Text = DipositsLabelInfo(gbGasolina95.Tag.ToString, tg95s4.Tag.ToString)

        'Gasolina 98
        tg98s1.Text = DipositsLabelInfo(gbGasolina98.Tag.ToString, tg98s1.Tag.ToString)
        tg98s2.Text = DipositsLabelInfo(gbGasolina98.Tag.ToString, tg98s2.Tag.ToString)
        tg98s3.Text = DipositsLabelInfo(gbGasolina98.Tag.ToString, tg98s3.Tag.ToString)
        tg98s4.Text = DipositsLabelInfo(gbGasolina98.Tag.ToString, tg98s4.Tag.ToString)

        'Diesel
        tDs1.Text = DipositsLabelInfo(gbDiesel.Tag.ToString, tDs1.Tag.ToString)
        tDs2.Text = DipositsLabelInfo(gbDiesel.Tag.ToString, tDs2.Tag.ToString)
        tDs3.Text = DipositsLabelInfo(gbDiesel.Tag.ToString, tDs3.Tag.ToString)
        tDs4.Text = DipositsLabelInfo(gbDiesel.Tag.ToString, tDs4.Tag.ToString)

        'AdBlue
        tAs1.Text = DipositsLabelInfo(gbAdBlue.Tag.ToString, tAs1.Tag.ToString)
        tAs2.Text = DipositsLabelInfo(gbAdBlue.Tag.ToString, tAs2.Tag.ToString)
        tAs3.Text = DipositsLabelInfo(gbAdBlue.Tag.ToString, tAs3.Tag.ToString)
        tAs4.Text = DipositsLabelInfo(gbAdBlue.Tag.ToString, tAs4.Tag.ToString)
    End Sub

    Private Function DipositsLabelInfo(combustibleTag As String, sortidorTag As String) As String
        Dim tmpTotal As Double = 0.0
        Dim tmpActual As Double = 0.0
        Dim text As String

        Try
            tmpTotal = DipositTableAdapter.SelectTotalSortidor(combustibleTag, sortidorTag).ToString
            tmpActual = DipositTableAdapter.SelectActualSortidor(combustibleTag, sortidorTag).ToString
        Catch ex As Exception
            MessageBox.Show("No s'han trobat resultats", "Sense resultats", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

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

    Private Sub btActualitzar_Click(sender As Object, e As EventArgs) Handles btActualitzar.Click
        If DataIniciHistorial.Value <= DataFiHistorial.Value Then
            Try
                dgvPreuGas95.DataSource = HISTORIAL_PREUSTableAdapter.GetByIdCarburantAndData(dgvPreuGas95.Tag.ToString, DataIniciHistorial.Value, DataFiHistorial.Value)
                dgvPreuGas98.DataSource = HISTORIAL_PREUSTableAdapter.GetByIdCarburantAndData(dgvPreuGas98.Tag.ToString, DataIniciHistorial.Value, DataFiHistorial.Value)
                dgvPreuDiesel.DataSource = HISTORIAL_PREUSTableAdapter.GetByIdCarburantAndData(dgvPreuDiesel.Tag.ToString, DataIniciHistorial.Value, DataFiHistorial.Value)
                dgvPreuAdblue.DataSource = HISTORIAL_PREUSTableAdapter.GetByIdCarburantAndData(dgvPreuAdblue.Tag.ToString, DataIniciHistorial.Value, DataFiHistorial.Value)
                dgvPreuElectricitat.DataSource = HISTORIAL_PREUSTableAdapter.GetByIdCarburantAndData(dgvPreuElectricitat.Tag.ToString, DataIniciHistorial.Value, DataFiHistorial.Value)
            Catch ex As Exception
                Console.Write("No s'han trobat dades")
            End Try
        Else
            MessageBox.Show("La data d'inici no pot ser major que la data final", "Data no vàlida", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub pbCombustible_click(sender As Object, e As EventArgs) Handles pbGasolina95.Click, pbGasolina98.Click, pbDiesel.Click, pbAdblue.Click, PbEnergia.Click
        pbGasolina95.BorderStyle = BorderStyle.None
        pbGasolina98.BorderStyle = BorderStyle.None
        pbDiesel.BorderStyle = BorderStyle.None
        pbAdblue.BorderStyle = BorderStyle.None
        PbEnergia.BorderStyle = BorderStyle.None

        Dim combustibleSeleccionat As PictureBox = DirectCast(sender, PictureBox)
        combustibleSeleccionat.BorderStyle = BorderStyle.Fixed3D

        _idPreuCombustible = combustibleSeleccionat.Tag.ToString
    End Sub

    Private Sub tbImport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbImport.KeyPress
        Dim txt As TextBox = CType(sender, TextBox)

        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Char.IsDigit(e.KeyChar) Then
            If txt.SelectionStart = 0 AndAlso txt.Text.Length >= 1 AndAlso Not txt.SelectedText.Contains(txt.Text(0)) Then
                e.Handled = True
            End If
            Return
        End If

        If e.KeyChar = "," Then
            If txt.Text.Contains(",") Then
                e.Handled = True
            End If
            Return
        End If
        e.Handled = True
    End Sub

    Private Sub btModificarPreu_Click(sender As Object, e As EventArgs) Handles btModificarPreu.Click
        If _idPreuCombustible.Length > 0 AndAlso tbImport.TextLength > 0 Then

            Try
                HISTORIAL_PREUSTableAdapter.SP_ActualitzarPreuCarburant(_idPreuCombustible, tbImport.Text.ToString)
                tbImport.Clear()
                CarregarDGV()
                DataIniciHistorial.Value = "01/01/2025"
                DataFiHistorial.Value = "31/12/2025"
            Catch ex As Exception
                Console.Write("Error al actualitzar preus")
            End Try

        ElseIf _idPreuCombustible.Length <= 0
            MessageBox.Show("Si us plau, selecciona un combustible", "Combustible no seleccionat", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf tbImport.TextLength <= 0
            MessageBox.Show("Si us plau, introdueix un import", "Import no vàlid", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btCancelarComanda_Click(sender As Object, e As EventArgs) Handles btCancelarComanda.Click
        Dim fila As DataGridViewRow
        Dim idComanda As Integer

        If dgvComandesProces.RowCount > 0 Then
            fila = dgvComandesProces.SelectedRows(0)
            idComanda = fila.Cells(0).Value

            Try
                COMANDATableAdapter.UpdateToCancelat(idComanda)
                CarregarComandes()
            Catch ex As Exception
                Console.Write("No s'ha pogut actualitzar l'estat de la comanda")
            End Try
        End If
    End Sub

    Private Sub btPlenarDiposit_Click(sender As Object, e As EventArgs) Handles btPlenarDiposit.Click
        Dim fila As DataGridViewRow
        Dim idComanda As Integer
        Dim idDiposit As Integer
        Dim quantitat As Double

        If dgvComandesProces.RowCount > 0 Then
            fila = dgvComandesProces.SelectedRows(0)
            idComanda = fila.Cells(0).Value
            idDiposit = fila.Cells(1).Value
            quantitat = fila.Cells(2).Value

            Try
                COMANDATableAdapter.UpdateToRebut(idComanda)
                DipositTableAdapter.UpdateEmplenarDiposit(quantitat, idDiposit)
                idSortidor = DipositS_SORTIDORTableAdapter.SelectSortidorFromDiposit(idDiposit)
                CarregarComandes()

                TimerForaDeServei.Start()
                SortidorTableAdapter.UpdateEstatForaServei(idSortidor)

            Catch ex As Exception
                Console.Write("No s'ha pogut actualitzar l'estat de la comanda")
            End Try
        End If
    End Sub

    Private Sub TimerForaDeServei_Tick(sender As Object, e As EventArgs) Handles TimerForaDeServei.Tick
        ticksForaDeServei += 1

        If ticksForaDeServei >= 60 Then
            ticksForaDeServei = 0
            TimerForaDeServei.Stop()

            Try
                SortidorTableAdapter.UpdateEstatDisponible(idSortidor)
                idSortidor = 0
            Catch ex As Exception
                Console.Write("Error al actualitzar informació del sortidor!")
            End Try
        End If
    End Sub

    Private Sub btInformeReset_Click(sender As Object, e As EventArgs) Handles btInformeReset.Click
        dataIniciInforme.Value = "01/01/2025"
        dataFiInforme.Value = "31/12/2025"
    End Sub

    Private Sub btInformeData_Click(sender As Object, e As EventArgs) Handles btInformeData.Click
        Try
            If informeFiltrarCombustible Then
                dgvInformesIngressos.DataSource = SubministramentTableAdapter.GetSelectAllByDataCombustible(dataIniciInforme.Value, dataFiInforme.Value, informeCombustible)
                dgvInformesDespeses.DataSource = COMANDATableAdapter.GetSelectComandesDataCombustible(dataIniciInforme.Value, dataFiInforme.Value, informeCombustible)
            Else
                dgvInformesIngressos.DataSource = SubministramentTableAdapter.GetAllByData(dataIniciInforme.Value, dataFiInforme.Value)
                dgvInformesDespeses.DataSource = COMANDATableAdapter.GetComandesByData(dataIniciInforme.Value, dataFiInforme.Value)
            End If
            calcularBeneficis(dgvInformesIngressos, dgvInformesDespeses)
        Catch ex As Exception
            Console.Write("Error al obtenir informació de les vendes!")
        End Try
    End Sub

    Private Sub btInformeAny_Click(sender As Object, e As EventArgs) Handles btInformeAny.Click
        Try
            If informeFiltrarCombustible Then
                dgvInformesIngressos.DataSource = SubministramentTableAdapter.GetSelectSubministramentYearCombustible(AnyInforme.Value.Year, informeCombustible)
                dgvInformesDespeses.DataSource = COMANDATableAdapter.GetSelectComandesYearCombustible(AnyInforme.Value.Year, informeCombustible)
            Else
                dgvInformesIngressos.DataSource = SubministramentTableAdapter.GetSelectSubministramentYear(AnyInforme.Value.Year)
                dgvInformesDespeses.DataSource = COMANDATableAdapter.GetSelectComandesYear(AnyInforme.Value.Year)
            End If
            calcularBeneficis(dgvInformesIngressos, dgvInformesDespeses)
        Catch ex As Exception
            Console.Write("Error al obtenir informació de les vendes!")
        End Try
    End Sub

    Private Sub btInformeTrimestre_Click(sender As Object, e As EventArgs) Handles btInformeTrimestre.Click
        Try
            If informeFiltrarCombustible Then
                dgvInformesIngressos.DataSource = SubministramentTableAdapter.GetSelectSubministramentYearQuarterCombustible(AnyInforme.Value.Year, (comboInformeTrimestre.SelectedIndex + 1), informeCombustible)
                dgvInformesDespeses.DataSource = COMANDATableAdapter.GetSelectComandesYearTrimestreCombustible(AnyInforme.Value.Year, (comboInformeTrimestre.SelectedIndex + 1), informeCombustible)
            Else
                dgvInformesIngressos.DataSource = SubministramentTableAdapter.GetSelectSubministramentYearQuarter(AnyInforme.Value.Year, (comboInformeTrimestre.SelectedIndex + 1))
                dgvInformesDespeses.DataSource = COMANDATableAdapter.GetSelectComandesYearTrimestre(AnyInforme.Value.Year, (comboInformeTrimestre.SelectedIndex + 1))
            End If
            calcularBeneficis(dgvInformesIngressos, dgvInformesDespeses)
        Catch ex As Exception
            Console.Write("Error al obtenir informació de les vendes!")
        End Try
    End Sub

    Private Sub calcularBeneficis(dgvIngressos As DataGridView, dgvDespeses As DataGridView)
        Dim ingressos As Double = 0
        For Each row As DataGridViewRow In dgvIngressos.Rows
            ingressos += row.Cells(4).Value
        Next

        Dim despeses As Double = 0
        For Each row As DataGridViewRow In dgvDespeses.Rows
            despeses += row.Cells(3).Value
        Next

        If dgvInformesBeneficis.RowCount > 0 Then dgvInformesBeneficis.Rows.RemoveAt(0)
        dgvInformesBeneficis.Rows.Insert(0, ingressos.ToString, despeses.ToString, (ingressos - despeses).ToString)
    End Sub

    Private Sub btEsborrarInforme_Click(sender As Object, e As EventArgs) Handles btEsborrarInforme.Click
        TreureSeleccioInformes()
        informeFiltrarCombustible = False
    End Sub

    Private Sub pbInformeCombustible_click(sender As Object, e As EventArgs) Handles pbInformeGas95.Click, pbInformeGas98.Click, pbInformeDiesel.Click, pbInformeAdblue.Click, pbInformeEnergia.Click
        TreureSeleccioInformes()

        Dim combustibleSeleccionat As PictureBox = DirectCast(sender, PictureBox)
        combustibleSeleccionat.BorderStyle = BorderStyle.Fixed3D

        informeCombustible = combustibleSeleccionat.Tag.ToString
        informeFiltrarCombustible = True
    End Sub
    Private Sub TreureSeleccioInformes()
        pbInformeGas95.BorderStyle = BorderStyle.None
        pbInformeGas98.BorderStyle = BorderStyle.None
        pbInformeDiesel.BorderStyle = BorderStyle.None
        pbInformeAdblue.BorderStyle = BorderStyle.None
        pbInformeEnergia.BorderStyle = BorderStyle.None
    End Sub
End Class

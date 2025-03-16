Public Class FormCombustioSeleccio

    Private _idSortidor As String
    Dim idCombustible As String
    Dim nomCombustible As String
    Dim import As Double

    Public Sub New(sortidor As String)
        InitializeComponent()
        _idSortidor = sortidor
    End Sub

    Private Sub FormCombustioSeleccio_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbPreuGas95.Text = CarburantTableAdapter.PreuCarburant(lbPreuGas95.Tag.ToString).ToString + "€/L"
        lbPreuGas98.Text = CarburantTableAdapter.PreuCarburant(lbPreuGas98.Tag.ToString).ToString + "€/L"
        lbPreuDiesel.Text = CarburantTableAdapter.PreuCarburant(lbPreuDiesel.Tag.ToString).ToString + "€/L"
        lbPreuAdblue.Text = CarburantTableAdapter.PreuCarburant(lbPreuAdblue.Tag.ToString).ToString + "€/L"
    End Sub

    Private Sub pbCombustible_click(sender As Object, e As EventArgs) Handles pbGasoilina95.Click, pbGasolina98.Click, pbDiesel.Click, pbAdBlue.Click
        pbGasoilina95.BorderStyle = BorderStyle.None
        pbGasolina98.BorderStyle = BorderStyle.None
        pbDiesel.BorderStyle = BorderStyle.None
        pbAdBlue.BorderStyle = BorderStyle.None

        Dim combustibleSeleccionat As PictureBox = DirectCast(sender, PictureBox)
        combustibleSeleccionat.BorderStyle = BorderStyle.Fixed3D

        idCombustible = combustibleSeleccionat.Tag.ToString
    End Sub

    Private Sub bt_click(sender As Object, e As EventArgs) Handles bt1.Click, bt2.Click, bt3.Click, bt4.Click, bt5.Click, bt6.Click, bt7.Click, bt8.Click, bt9.Click, bt0.Click
        Dim numSeleccionat As Button = DirectCast(sender, Button)

        If tbImport.Text.Length < 2 Then
            tbImport.Text = tbImport.Text + numSeleccionat.Text
        End If
    End Sub

    Private Sub btEsborrar_Click(sender As Object, e As EventArgs) Handles btEsborrar.Click
        If tbImport.Text.Length > 0 Then
            tbImport.Text = tbImport.Text.Remove(tbImport.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click

        If idCombustible > 0 AndAlso tbImport.Text.Length > 0 Then
            import = CDbl(tbImport.Text)
            nomCombustible = CarburantTableAdapter.NomCarburant(idCombustible)

            Dim resposta As DialogResult
            resposta = MessageBox.Show("Sortidor: " + _idSortidor + vbNewLine + "Combustible: " + nomCombustible + vbNewLine + "Import: " + import.ToString + "€", "Confirmació", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resposta = DialogResult.Yes Then
                Dim formPin As New FormPIN(_idSortidor, Me)
                formPin.Show()
                btCancelar.Enabled = False
            End If
        ElseIf idCombustible <= 0 Then
            MessageBox.Show("No ha seleccionat cap combustible!", "Seleccioni el combustible", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf tbImport.Text.Length <= 0 Then
            MessageBox.Show("No ha introduit l'import!", "Seleccioni l'import", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Dim resposta As DialogResult
        resposta = MessageBox.Show("Vols cancel·lar l'operació?", "Confirmació", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            SortidorTableAdapter.UpdateEstatDisponible(_idSortidor)
            Me.Close()
        End If
    End Sub

    Public Sub FormRepostatge_show()
        Dim FormRepostar As New FormRepostarCombustio(_idSortidor, idCombustible, import)
        FormRepostar.Show()
    End Sub
End Class
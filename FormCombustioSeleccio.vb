Public Class FormCombustioSeleccio
    Private Const IMPORT_MAXIM = "99"

    Private _idSortidor As String
    Dim idCombustible As String
    Dim nomCombustible As String
    Dim import As Double

    Public Sub New(sortidor As String)
        InitializeComponent()
        _idSortidor = sortidor
    End Sub

    'Mostro el preu actual de cada combustible
    Private Sub FormCombustioSeleccio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            lbPreuGas95.Text = CarburantTableAdapter.PreuCarburant(lbPreuGas95.Tag.ToString).ToString + "€/L"
            lbPreuGas98.Text = CarburantTableAdapter.PreuCarburant(lbPreuGas98.Tag.ToString).ToString + "€/L"
            lbPreuDiesel.Text = CarburantTableAdapter.PreuCarburant(lbPreuDiesel.Tag.ToString).ToString + "€/L"
            lbPreuAdblue.Text = CarburantTableAdapter.PreuCarburant(lbPreuAdblue.Tag.ToString).ToString + "€/L"
        Catch ex As Exception
            Console.WriteLine("Error. No s'han pogut obtenir els preus del carburant")
        End Try
    End Sub

    'Agafo les dades del pb seleccionat per a guardar en una variable l'id del combustible i gestionar-ho posteriorment
    Private Sub pbCombustible_click(sender As Object, e As EventArgs) Handles pbGasoilina95.Click, pbGasolina98.Click, pbDiesel.Click, pbAdBlue.Click
        pbGasoilina95.BorderStyle = BorderStyle.None
        pbGasolina98.BorderStyle = BorderStyle.None
        pbDiesel.BorderStyle = BorderStyle.None
        pbAdBlue.BorderStyle = BorderStyle.None

        Dim combustibleSeleccionat As PictureBox = DirectCast(sender, PictureBox)
        combustibleSeleccionat.BorderStyle = BorderStyle.Fixed3D

        idCombustible = combustibleSeleccionat.Tag.ToString
    End Sub

    'Gestiono un teclat numèric en pantalla que permet un nombre màxim de 99
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

    Private Sub btPle_Click(sender As Object, e As EventArgs) Handles btPle.Click
        tbImport.Text = IMPORT_MAXIM
    End Sub

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click

        'M'asseguro que s'ha introduit un import i s'ha seleccionat el combustible
        If idCombustible > 0 AndAlso tbImport.Text.Length > 0 Then
            import = CDbl(tbImport.Text)
            Try
                nomCombustible = CarburantTableAdapter.NomCarburant(idCombustible)
            Catch ex As Exception
                Console.WriteLine("idCombustible incorrecte. No existeix cap registre que coincideixi.")
            End Try

            'Es confirmen les dades a l'usuari
            Dim resposta As DialogResult
            resposta = MessageBox.Show("Sortidor: " + _idSortidor + vbNewLine + "Combustible: " + nomCombustible + vbNewLine + "Import: " + import.ToString + "€", "Confirmació", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            'Si les dades són correctes, es procedeix al pagament, si no, es permet modificar-les
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

    'Si l'usuari al final no vol repostar, pot cancel·lar i el sortidor tornarà a estar disponible
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Dim resposta As DialogResult
        resposta = MessageBox.Show("Vols cancel·lar l'operació?", "Confirmació", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resposta = DialogResult.Yes Then
            Try
                SortidorTableAdapter.UpdateEstatDisponible(_idSortidor)
                Me.Close()
            Catch ex As Exception
                Console.WriteLine("Estat no actualitzat. Error al fer la consulta")
            End Try
        End If
    End Sub

    'A partir de les dades obtingudes amb la selecció d'aquest formulari, puc instanciar el formulari del repostatge des del formulari on introdueixo el PIN
    Public Sub FormRepostatge_show()
        Dim FormRepostar As New FormRepostarCombustio(_idSortidor, idCombustible, import)
        FormRepostar.Show()
    End Sub
End Class
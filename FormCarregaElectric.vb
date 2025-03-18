Public Class FormCarregaElectric
    Private _idSortidor As String

    Dim capacitatVehicle As Double
    Dim percentatgeActual As Integer
    Dim tempsTranscorregut As String

    Dim energiaSubministrada As Double
    Dim preuKW As Double
    Dim importTotalCarrega As Double

    Public Sub New(sortidor As String)
        InitializeComponent()
        _idSortidor = sortidor
    End Sub
    Private Sub FormCarregaElectric_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rnd As Random = New Random
        'els vehicles tindran una capacitat aleatòria d'entre 50 i 110kW/h
        capacitatVehicle = rnd.Next(50, 111)
        'els vehicles podran arribar amb un màxim de 80% de la càrrega
        percentatgeActual = rnd.NextDouble * 80
        preuKW = CarburantTableAdapter.PreuCarburant("5")

        lbEstat.Text = "Estat: en espera"
        lbPreuKW.Text = "Preu kW/h: " + preuKW.ToString + " €"

        lbCapacitat.Text = "Capacitat: " + capacitatVehicle.ToString("F0") + " kW/h"
        lbBateria.Text = "Percentatge actual: " + percentatgeActual.ToString + "%"

        btFinalitzar.Enabled = False
        ProgressBar1.Value = percentatgeActual
    End Sub
    Private Sub btCarregar_Click(sender As Object, e As EventArgs) Handles btCarregar.Click
        Dim formPin As New FormPIN(_idSortidor)
        formPin.Show()

        btCarregar.Enabled = False
        'vigilar perque salta un cop li dona ok, no quan es passa el pin i si fa un timeout, que l'estat torni a en espera
        TimerCarrega.Start()
        lbEstat.Text = "Estat: carregant"
    End Sub
    Private Sub btParar_Click(sender As Object, e As EventArgs) Handles btParar.Click
        lbEstat.Text = "Estat: finalitzat"
        CarregaFeta()
    End Sub
    Private Sub btFinalitzar_Click(sender As Object, e As EventArgs) Handles btFinalitzar.Click
        btCarregar.Enabled = False
        SortidorTableAdapter.UpdateEstatDisponible(_idSortidor)
        Me.Close()
    End Sub
    Private Sub CarregaFeta()
        btFinalitzar.Enabled = True
        btCarregar.Enabled = False
        btParar.Enabled = False

        TimerCarrega.Stop()
    End Sub

    Dim minuts As Integer = 0
    Dim segons As Integer = 0
    Dim ticks As Integer = 0
    Private Sub TimerCarrega_Tick(sender As Object, e As EventArgs) Handles TimerCarrega.Tick
        energiaSubministrada += 0.025
        importTotalCarrega = preuKW * energiaSubministrada

        FormatarTemps(ticks, segons, minuts)

        lbEnergiaSubministrada.Text = "Subministre: " + energiaSubministrada.ToString("F2") + " kW/h"
        lbCostCarrega.Text = "Cost: " + importTotalCarrega.ToString("F2") + " €"
    End Sub

    Private Sub FormatarTemps(ByRef ticks As Integer, ByRef minuts As Integer, ByRef segons As Integer)
        ticks += 1

        If ticks >= 9 Then
            ticks = 0
            segons += 1
            If segons >= 59 Then
                segons = 0
                minuts += 1
            End If
        End If

        lbTemps.Text = "Temps transcorregut: " + String.Format("{0:D2}:{1:D2}", minuts, segons)
    End Sub
End Class
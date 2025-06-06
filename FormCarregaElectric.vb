﻿Public Class FormCarregaElectric
    Private _idSortidor As String
    Private Const ID_ENERGIA As String = "5"

    Dim capacitatVehicle As Double
    Dim percentatgeInicial As Integer
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
        percentatgeInicial = rnd.NextDouble * 80
        preuKW = CarburantTableAdapter.PreuCarburant(ID_ENERGIA)

        lbEstat.Text = "Estat: en espera"
        lbPreuKW.Text = "Preu kW/h: " + preuKW.ToString + " €"

        lbCapacitat.Text = "Capacitat: " + capacitatVehicle.ToString("F0") + " kW/h"
        lbBateria.Text = "Percentatge actual: " + percentatgeInicial.ToString + "%"

        btFinalitzar.Enabled = False
        ProgressBar1.Value = percentatgeInicial
    End Sub

    'Si l'usuari vol carregar el vehicle, haurà de passar primer la targeta
    Private Sub btCarregar_Click(sender As Object, e As EventArgs) Handles btCarregar.Click
        Dim formPin As New FormPIN(_idSortidor, Me)
        formPin.Show()

        btCarregar.Enabled = False
        lbEstat.Text = "Estat: carregant"
    End Sub

    'Al parar la càrrega, es gestionen les consultes 
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

        'Si s'ha carregat energia, es fan les consultes
        If energiaSubministrada > 0.00 Then
            Try
                SubministramentTableAdapter.InsertSubministrament(_idSortidor, ID_ENERGIA, importTotalCarrega, energiaSubministrada, preuKW)
                DipositTableAdapter.UpdateQuantitatElectricitat(energiaSubministrada, ID_ENERGIA, _idSortidor)
            Catch ex As Exception
                MessageBox.Show("Error al inserir les dades del repostatge", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Dim minuts As Integer = 0
    Dim segons As Integer = 0
    Dim ticks As Integer = 0

    'Aquest timer s'inicia un cop s'ha autoritzat el pagament. Mostra les dades en temps real sobre la càrrega
    Private Sub TimerCarrega_Tick(sender As Object, e As EventArgs) Handles TimerCarrega.Tick
        energiaSubministrada += 0.025
        importTotalCarrega = preuKW * energiaSubministrada

        CarregarBateria()
        FormatarTemps(ticks, segons, minuts)

        lbEnergiaSubministrada.Text = "Subministre: " + energiaSubministrada.ToString("F2") + " kW/h"
        lbCostCarrega.Text = "Cost: " + importTotalCarrega.ToString("F2") + " €"
    End Sub

    'Amb les variables, calculo el temps i el formato per a que sigui llegible
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

    'Simulo la càrrega del cotxe i calculo els percentatges. Un cop carregat, es para automàticament
    Private Sub CarregarBateria()
        Dim percentatgeCarregat As Double = (energiaSubministrada / capacitatVehicle) * 100
        percentatgeActual = CInt(percentatgeInicial + percentatgeCarregat)

        If percentatgeActual >= 100 Then
            percentatgeActual = 100
            btParar.PerformClick()
        End If

        ProgressBar1.Value = percentatgeActual
        lbBateria.Text = "Percentatge actual: " + percentatgeActual.ToString + "%"
    End Sub
End Class
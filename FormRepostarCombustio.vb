﻿Public Class FormRepostarCombustio
    Private _idSortidor As String
    Private _idCombustible As String
    Private _import As Double

    Dim capacitat As Double
    Dim combustible_actual As Double

    Dim quantitatRepostada As Double
    Dim importCombustible As Double
    Dim preuLitre As Double

    Public Sub New(sortidor As String, combustible As String, import As Double)
        InitializeComponent()
        _idSortidor = sortidor
        _idCombustible = combustible
        _import = import
    End Sub

    Private Sub FormRepostarCombustio_Load(sender As Object, e As EventArgs) Handles Me.Load
        preuLitre = CDbl(CarburantTableAdapter.PreuCarburant(_idCombustible))
        Dim rnd As Random = New Random()
        'Els diposits poden anar de 40 fins a 80 litres
        capacitat = rnd.Next(4, 9) * 10
        'El combustible actual també es calcularà de forma aleatoria
        combustible_actual = capacitat * rnd.NextDouble()

        lbCapacitat.Text = "Capacitat: " + capacitat.ToString
        lbCombustibleActual.Text = "Combustible actual: " + combustible_actual.ToString("F2")

        ProgressBar1.Value = CInt(combustible_actual * 100 / capacitat)

        lbImportIntroduit.Text = "Import introduït: " + _import.ToString + "€"
        lbPreuLitre.Text = "Preu/L: " + preuLitre.ToString + "€/L"

        btFinalitzar.Enabled = False

        lbIdSortidor.Text = "Sortidor: " + _idSortidor
    End Sub

    Private Sub TimerRepostar_Tick(sender As Object, e As EventArgs) Handles TimerRepostar.Tick

        If importCombustible.CompareTo(_import) >= 0 Then
            DipositPle()
        ElseIf combustible_actual.CompareTo(capacitat) >= 0
            DipositPle()
        Else
            quantitatRepostada += 0.01
            importCombustible = quantitatRepostada * preuLitre

            lbQuantitat.Text = "Quantitat: " + quantitatRepostada.ToString("F2") + " L"
            lbImport.Text = "Import: " + importCombustible.ToString("F2") + "€"

            combustible_actual += 0.01
            lbCombustibleActual.Text = "Combustible actual: " + combustible_actual.ToString("F2") + " L"

            ProgressBar1.Value = CInt(combustible_actual * 100 / capacitat)
        End If
    End Sub

    Private Sub btCarregar_Click(sender As Object, e As EventArgs) Handles btCarregar.Click
        TimerRepostar.Start()
    End Sub

    Private Sub btParar_Click(sender As Object, e As EventArgs) Handles btParar.Click
        DipositPle()
    End Sub

    Private Sub btFinalitzar_Click(sender As Object, e As EventArgs) Handles btFinalitzar.Click
        Try
            SortidorTableAdapter.UpdateEstatDisponible(_idSortidor)
        Catch ex As Exception
            Console.WriteLine("No 'sha pogut actualitzar l'estat del sortidor")
        End Try
        Me.Close()
    End Sub

    Private Sub DipositPle()
        TimerRepostar.Stop()
        btCarregar.Enabled = False
        btParar.Enabled = False
        btFinalitzar.Enabled = True

        'En cas d'haver clicat a cancel·lar, si no s'ha repostat, no es farà cap consulta ja que no té sentit comptabilitzar 0 litres i un import de 0
        If quantitatRepostada > 0.00 Then
            Try
                SubministramentTableAdapter.InsertSubministrament(_idSortidor, _idCombustible, importCombustible, quantitatRepostada, preuLitre)
                DipositTableAdapter.UpdateCapacitatDiposit(quantitatRepostada, _idCombustible, _idSortidor)
            Catch ex As Exception
                Console.WriteLine("No s'ha pogut realitzar la consulta a la base de dades per guardar les dades del subministrament")
            End Try
        End If
    End Sub
End Class
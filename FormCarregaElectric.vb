Public Class FormCarregaElectric
    Private _idSortidor As String

    Public Sub New(sortidor As String)
        InitializeComponent()
        _idSortidor = sortidor
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btFinalitzar.Click
        SortidorTableAdapter.UpdateEstatDisponible(_idSortidor)
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub btCarregar_click(sender As Object, e As EventArgs) Handles btCarregar.Click
        Dim formPin As New FormPIN(_idSortidor)
        formPin.Show()
    End Sub

    Private Sub FormCarregaElectric_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
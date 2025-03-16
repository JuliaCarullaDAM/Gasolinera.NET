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

End Class
Public Class FormRepostarCombustio
    Private _idSortidor As String
    Private _idCombustible As String
    Private _import As Double

    Public Sub New(sortidor As String, combustible As String, import As Double)
        InitializeComponent()
        _idSortidor = sortidor
        _idCombustible = combustible
        _import = import
    End Sub
End Class
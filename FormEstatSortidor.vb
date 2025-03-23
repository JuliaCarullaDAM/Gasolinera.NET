Public Class FormEstatSortidor

    Private _sortidor As String
    Dim estat As String

    'Creo un constructor per poder instanciar varies vegades el formulari
    'D'aquesta manera també puc fer que cada instància agafi les dades del sortidor que l'ha cridat
    Public Sub New(sortidor As String)
        InitializeComponent()
        _sortidor = sortidor
    End Sub

    Private Sub FormEstatSortidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            estat = SortidorTableAdapter.EstatSortidor(_sortidor)
        Catch ex As Exception
            Console.WriteLine("No 'sha pogut actualitzar l'estat del sortidor")
        End Try

        Label1.Text = "Sortidor: " + _sortidor
        Label2.Text = "Estat: " + estat

        If estat = "Fora de servei" Then
            pbEstat.Image = ImageList1.Images(2)
        ElseIf estat = "Ocupat"
            pbEstat.Image = ImageList1.Images(1)
        Else
            pbEstat.Image = ImageList1.Images(0)
        End If

        If _sortidor = "5" Or _sortidor = "6" Then
            btRepostar.Text = "Carregar vehicle"
        End If

        If estat = "Ocupat" Or estat = "Fora de servei" Then
            btRepostar.Enabled = False
        Else
            btRepostar.Enabled = True
        End If
    End Sub

    Private Sub btRepostar_Click(sender As Object, e As EventArgs) Handles btRepostar.Click
        Try
            SortidorTableAdapter.UpdateEstatOcupat(_sortidor)
        Catch ex As Exception
            Console.WriteLine("No 'sha pogut actualitzar l'estat del sortidor")
        End Try

        If _sortidor = "5" Or _sortidor = "6" Then
            Dim formSeleccio As New FormCarregaElectric(_sortidor)
            formSeleccio.Show()
        Else
            Dim formSeleccio As New FormCombustioSeleccio(_sortidor)
            formSeleccio.Show()
        End If
        Me.Close()
    End Sub
End Class
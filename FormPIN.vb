Public Class FormPIN
    Dim segonsTimeout As Integer = 60
    Private _idSortidor As String

    Public Sub New(sortidor As String)
        InitializeComponent()
        _idSortidor = sortidor
    End Sub
    Private Sub bt_click(sender As Object, e As EventArgs) Handles bt1.Click, bt2.Click, bt3.Click, bt4.Click, bt5.Click, bt6.Click, bt7.Click, bt8.Click, bt9.Click, bt0.Click
        If tbTargeta.Text.Length < 4 Then
            tbTargeta.Text = tbTargeta.Text + "*"
        End If
    End Sub
    Private Sub btEsborrar_Click(sender As Object, e As EventArgs) Handles btEsborrar.Click
        If tbTargeta.Text.Length > 0 Then
            tbTargeta.Text = tbTargeta.Text.Remove(tbTargeta.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click
        'llançar formulari nou amb l'animació de repostar i les dades que s'hagin de passar
        'fer l'animació amb un progress bar <- pot quedar molt top en cotxes elecrics i si es pot canviar el color amb els de gasolina tb
        Me.Close()
    End Sub

    Private Sub FormPIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimerTimeout.Start()
    End Sub

    Private Sub TimerTimeout_Tick(sender As Object, e As EventArgs) Handles TimerTimeout.Tick
        segonsTimeout -= 1

        If segonsTimeout <= 0 Then
            SortidorTableAdapter.UpdateEstatDisponible(_idSortidor)
            Me.Close()
        End If
    End Sub
End Class
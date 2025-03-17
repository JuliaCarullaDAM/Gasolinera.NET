Public Class FormPIN
    Dim segonsTimeout As Integer = 60
    Private _idSortidor As String
    Private _formCombustio As FormCombustioSeleccio

    Public Sub New(sortidor As String)
        InitializeComponent()
        _idSortidor = sortidor
    End Sub

    Public Sub New(sortidor As String, formCombustio As FormCombustioSeleccio)
        Me.New(sortidor)
        _formCombustio = formCombustio
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
        'FALTA POSAR LA PART ELÈCTRICA I FER IF SEGONS ID DE SORTIDOR

        If tbTargeta.Text.Length = 4 Then
            _formCombustio.FormRepostatge_show()
            _formCombustio.Close()
            Me.Close()
        Else
            MessageBox.Show("S'ha introduït un PIN no vàlid", "PIN Incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub FormPIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimerTimeout.Start()
    End Sub

    Private Sub TimerTimeout_Tick(sender As Object, e As EventArgs) Handles TimerTimeout.Tick
        segonsTimeout -= 1

        If segonsTimeout <= 0 Then
            SortidorTableAdapter.UpdateEstatDisponible(_idSortidor)
            _formCombustio.Close()
            Me.Close()
        End If

    End Sub
End Class
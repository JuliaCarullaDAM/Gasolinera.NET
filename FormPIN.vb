﻿Public Class FormPIN
    Dim segonsTimeout As Integer = 60
    Private _idSortidor As String
    Private _formCombustio As FormCombustioSeleccio
    Private _formElectric As FormCarregaElectric

    'Hi ha el constructor base, que agafa l'id corresponent
    Public Sub New(sortidor As String)
        InitializeComponent()
        _idSortidor = sortidor
    End Sub

    'I el constructor que s'utilitza segons si el repostatge és de combustió o elèctric, que també utilitza el base
    Public Sub New(sortidor As String, formCombustio As FormCombustioSeleccio)
        Me.New(sortidor)
        _formCombustio = formCombustio
    End Sub

    Public Sub New(sortidor As String, formElectric As FormCarregaElectric)
        Me.New(sortidor)
        _formElectric = formElectric
    End Sub

    'Quan carrega aquest formulari, s'incia un timer
    Private Sub FormPIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        TimerTimeout.Start()
    End Sub

    'Gestiono l'entrada del PIN amb un pad numèric simulat i segueixo el format de 4 dígits
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

    'Comprovo que el PIN tingui un format vàlid i gestiono l'obertura del formulari que correspongui segons el sortidor
    'També puc gestionar objectes d'altres formularis, ja que els he passat per paràmetre al instanciar aquest
    Private Sub btOK_Click(sender As Object, e As EventArgs) Handles btOK.Click

        If (_idSortidor = "5" Or _idSortidor = "6") AndAlso tbTargeta.Text.Length = 4 Then
            MessageBox.Show("S'ha realitzat una preautorització de 100€", "Preautorització", MessageBoxButtons.OK, MessageBoxIcon.Information)
            _formElectric.TimerCarrega.Start()
            Me.Close()

        ElseIf tbTargeta.Text.Length = 4
            _formCombustio.FormRepostatge_show()
            _formCombustio.Close()
            Me.Close()
        Else
            MessageBox.Show("S'ha introduït un PIN no vàlid", "PIN Incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    'Aquest timer permet cancel·lar operacions en cas de que l'usuari tardi massa temps en respondre. Evita que un sortidor estigui fora de servei
    ' i a que no es produeixin operacions no autoritzades/errònies
    Private Sub TimerTimeout_Tick(sender As Object, e As EventArgs) Handles TimerTimeout.Tick
        segonsTimeout -= 1

        If segonsTimeout <= 0 Then
            Try
                SortidorTableAdapter.UpdateEstatDisponible(_idSortidor)
            Catch ex As Exception
                Console.WriteLine("No 'sha pogut actualitzar l'estat del sortidor")
            End Try
            If _idSortidor = "5" Or _idSortidor = "6" Then
                _formElectric.Close()
                Me.Close()
            Else
                _formCombustio.Close()
                Me.Close()
            End If
        End If
    End Sub

End Class
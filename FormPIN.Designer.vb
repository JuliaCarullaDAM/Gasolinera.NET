<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPIN
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btEsborrar = New System.Windows.Forms.Button()
        Me.bt0 = New System.Windows.Forms.Button()
        Me.bt7 = New System.Windows.Forms.Button()
        Me.bt8 = New System.Windows.Forms.Button()
        Me.bt9 = New System.Windows.Forms.Button()
        Me.bt4 = New System.Windows.Forms.Button()
        Me.bt5 = New System.Windows.Forms.Button()
        Me.bt6 = New System.Windows.Forms.Button()
        Me.bt3 = New System.Windows.Forms.Button()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.tbTargeta = New System.Windows.Forms.TextBox()
        Me.btOK = New System.Windows.Forms.Button()
        Me.TimerTimeout = New System.Windows.Forms.Timer(Me.components)
        Me.SortidorTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.SORTIDORTableAdapter()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Introdueixi el PIN de la targeta"
        '
        'btEsborrar
        '
        Me.btEsborrar.BackColor = System.Drawing.Color.Tomato
        Me.btEsborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEsborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEsborrar.Location = New System.Drawing.Point(45, 276)
        Me.btEsborrar.Name = "btEsborrar"
        Me.btEsborrar.Size = New System.Drawing.Size(75, 23)
        Me.btEsborrar.TabIndex = 30
        Me.btEsborrar.Text = "Esborrar"
        Me.btEsborrar.UseVisualStyleBackColor = False
        '
        'bt0
        '
        Me.bt0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt0.Location = New System.Drawing.Point(143, 276)
        Me.bt0.Name = "bt0"
        Me.bt0.Size = New System.Drawing.Size(75, 23)
        Me.bt0.TabIndex = 29
        Me.bt0.Text = "0"
        Me.bt0.UseVisualStyleBackColor = True
        '
        'bt7
        '
        Me.bt7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt7.Location = New System.Drawing.Point(44, 237)
        Me.bt7.Name = "bt7"
        Me.bt7.Size = New System.Drawing.Size(75, 23)
        Me.bt7.TabIndex = 28
        Me.bt7.Text = "7"
        Me.bt7.UseVisualStyleBackColor = True
        '
        'bt8
        '
        Me.bt8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt8.Location = New System.Drawing.Point(143, 237)
        Me.bt8.Name = "bt8"
        Me.bt8.Size = New System.Drawing.Size(75, 23)
        Me.bt8.TabIndex = 27
        Me.bt8.Text = "8"
        Me.bt8.UseVisualStyleBackColor = True
        '
        'bt9
        '
        Me.bt9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt9.Location = New System.Drawing.Point(237, 237)
        Me.bt9.Name = "bt9"
        Me.bt9.Size = New System.Drawing.Size(75, 23)
        Me.bt9.TabIndex = 26
        Me.bt9.Text = "9"
        Me.bt9.UseVisualStyleBackColor = True
        '
        'bt4
        '
        Me.bt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt4.Location = New System.Drawing.Point(45, 198)
        Me.bt4.Name = "bt4"
        Me.bt4.Size = New System.Drawing.Size(75, 23)
        Me.bt4.TabIndex = 25
        Me.bt4.Text = "4"
        Me.bt4.UseVisualStyleBackColor = True
        '
        'bt5
        '
        Me.bt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt5.Location = New System.Drawing.Point(143, 198)
        Me.bt5.Name = "bt5"
        Me.bt5.Size = New System.Drawing.Size(75, 23)
        Me.bt5.TabIndex = 24
        Me.bt5.Text = "5"
        Me.bt5.UseVisualStyleBackColor = True
        '
        'bt6
        '
        Me.bt6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt6.Location = New System.Drawing.Point(237, 198)
        Me.bt6.Name = "bt6"
        Me.bt6.Size = New System.Drawing.Size(75, 23)
        Me.bt6.TabIndex = 23
        Me.bt6.Text = "6"
        Me.bt6.UseVisualStyleBackColor = True
        '
        'bt3
        '
        Me.bt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt3.Location = New System.Drawing.Point(237, 157)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(75, 23)
        Me.bt3.TabIndex = 22
        Me.bt3.Text = "3"
        Me.bt3.UseVisualStyleBackColor = True
        '
        'bt2
        '
        Me.bt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt2.Location = New System.Drawing.Point(143, 157)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(75, 23)
        Me.bt2.TabIndex = 21
        Me.bt2.Text = "2"
        Me.bt2.UseVisualStyleBackColor = True
        '
        'bt1
        '
        Me.bt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.Location = New System.Drawing.Point(44, 157)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(75, 23)
        Me.bt1.TabIndex = 20
        Me.bt1.Text = "1"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'tbTargeta
        '
        Me.tbTargeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTargeta.Location = New System.Drawing.Point(44, 89)
        Me.tbTargeta.Name = "tbTargeta"
        Me.tbTargeta.ReadOnly = True
        Me.tbTargeta.Size = New System.Drawing.Size(268, 35)
        Me.tbTargeta.TabIndex = 31
        '
        'btOK
        '
        Me.btOK.BackColor = System.Drawing.Color.LimeGreen
        Me.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOK.Location = New System.Drawing.Point(237, 276)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(75, 23)
        Me.btOK.TabIndex = 32
        Me.btOK.Text = "OK"
        Me.btOK.UseVisualStyleBackColor = False
        '
        'TimerTimeout
        '
        Me.TimerTimeout.Interval = 1000
        '
        'SortidorTableAdapter
        '
        Me.SortidorTableAdapter.ClearBeforeFill = True
        '
        'FormPIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 337)
        Me.ControlBox = False
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.tbTargeta)
        Me.Controls.Add(Me.btEsborrar)
        Me.Controls.Add(Me.bt0)
        Me.Controls.Add(Me.bt7)
        Me.Controls.Add(Me.bt8)
        Me.Controls.Add(Me.bt9)
        Me.Controls.Add(Me.bt4)
        Me.Controls.Add(Me.bt5)
        Me.Controls.Add(Me.bt6)
        Me.Controls.Add(Me.bt3)
        Me.Controls.Add(Me.bt2)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPIN"
        Me.Text = "FormPIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btEsborrar As Button
    Friend WithEvents bt0 As Button
    Friend WithEvents bt7 As Button
    Friend WithEvents bt8 As Button
    Friend WithEvents bt9 As Button
    Friend WithEvents bt4 As Button
    Friend WithEvents bt5 As Button
    Friend WithEvents bt6 As Button
    Friend WithEvents bt3 As Button
    Friend WithEvents bt2 As Button
    Friend WithEvents bt1 As Button
    Friend WithEvents tbTargeta As TextBox
    Friend WithEvents btOK As Button
    Friend WithEvents TimerTimeout As Timer
    Friend WithEvents SortidorTableAdapter As GasolineraDataSetTableAdapters.SORTIDORTableAdapter
End Class

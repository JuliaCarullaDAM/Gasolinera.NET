<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCombustioSeleccio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.bt3 = New System.Windows.Forms.Button()
        Me.bt4 = New System.Windows.Forms.Button()
        Me.bt5 = New System.Windows.Forms.Button()
        Me.bt6 = New System.Windows.Forms.Button()
        Me.bt7 = New System.Windows.Forms.Button()
        Me.bt8 = New System.Windows.Forms.Button()
        Me.bt9 = New System.Windows.Forms.Button()
        Me.bt0 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbImport = New System.Windows.Forms.TextBox()
        Me.btOK = New System.Windows.Forms.Button()
        Me.btEsborrar = New System.Windows.Forms.Button()
        Me.btCancelar = New System.Windows.Forms.Button()
        Me.lbPreuGas95 = New System.Windows.Forms.Label()
        Me.lbPreuGas98 = New System.Windows.Forms.Label()
        Me.lbPreuDiesel = New System.Windows.Forms.Label()
        Me.lbPreuAdblue = New System.Windows.Forms.Label()
        Me.CarburantTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.CARBURANTTableAdapter()
        Me.SortidorTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.SORTIDORTableAdapter()
        Me.pbAdBlue = New System.Windows.Forms.PictureBox()
        Me.pbDiesel = New System.Windows.Forms.PictureBox()
        Me.pbGasolina98 = New System.Windows.Forms.PictureBox()
        Me.pbGasoilina95 = New System.Windows.Forms.PictureBox()
        CType(Me.pbAdBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDiesel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGasolina98, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGasoilina95, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(175, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 29)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Seleccioni el combustible"
        '
        'bt1
        '
        Me.bt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.Location = New System.Drawing.Point(371, 212)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(75, 23)
        Me.bt1.TabIndex = 6
        Me.bt1.Text = "1"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'bt2
        '
        Me.bt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt2.Location = New System.Drawing.Point(470, 212)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(75, 23)
        Me.bt2.TabIndex = 7
        Me.bt2.Text = "2"
        Me.bt2.UseVisualStyleBackColor = True
        '
        'bt3
        '
        Me.bt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt3.Location = New System.Drawing.Point(564, 212)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(75, 23)
        Me.bt3.TabIndex = 8
        Me.bt3.Text = "3"
        Me.bt3.UseVisualStyleBackColor = True
        '
        'bt4
        '
        Me.bt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt4.Location = New System.Drawing.Point(372, 253)
        Me.bt4.Name = "bt4"
        Me.bt4.Size = New System.Drawing.Size(75, 23)
        Me.bt4.TabIndex = 11
        Me.bt4.Text = "4"
        Me.bt4.UseVisualStyleBackColor = True
        '
        'bt5
        '
        Me.bt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt5.Location = New System.Drawing.Point(470, 253)
        Me.bt5.Name = "bt5"
        Me.bt5.Size = New System.Drawing.Size(75, 23)
        Me.bt5.TabIndex = 10
        Me.bt5.Text = "5"
        Me.bt5.UseVisualStyleBackColor = True
        '
        'bt6
        '
        Me.bt6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt6.Location = New System.Drawing.Point(564, 253)
        Me.bt6.Name = "bt6"
        Me.bt6.Size = New System.Drawing.Size(75, 23)
        Me.bt6.TabIndex = 9
        Me.bt6.Text = "6"
        Me.bt6.UseVisualStyleBackColor = True
        '
        'bt7
        '
        Me.bt7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt7.Location = New System.Drawing.Point(371, 292)
        Me.bt7.Name = "bt7"
        Me.bt7.Size = New System.Drawing.Size(75, 23)
        Me.bt7.TabIndex = 14
        Me.bt7.Text = "7"
        Me.bt7.UseVisualStyleBackColor = True
        '
        'bt8
        '
        Me.bt8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt8.Location = New System.Drawing.Point(470, 292)
        Me.bt8.Name = "bt8"
        Me.bt8.Size = New System.Drawing.Size(75, 23)
        Me.bt8.TabIndex = 13
        Me.bt8.Text = "8"
        Me.bt8.UseVisualStyleBackColor = True
        '
        'bt9
        '
        Me.bt9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt9.Location = New System.Drawing.Point(564, 292)
        Me.bt9.Name = "bt9"
        Me.bt9.Size = New System.Drawing.Size(75, 23)
        Me.bt9.TabIndex = 12
        Me.bt9.Text = "9"
        Me.bt9.UseVisualStyleBackColor = True
        '
        'bt0
        '
        Me.bt0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt0.Location = New System.Drawing.Point(470, 331)
        Me.bt0.Name = "bt0"
        Me.bt0.Size = New System.Drawing.Size(75, 23)
        Me.bt0.TabIndex = 15
        Me.bt0.Text = "0"
        Me.bt0.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Import:"
        '
        'tbImport
        '
        Me.tbImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbImport.Location = New System.Drawing.Point(165, 212)
        Me.tbImport.Name = "tbImport"
        Me.tbImport.ReadOnly = True
        Me.tbImport.Size = New System.Drawing.Size(100, 35)
        Me.tbImport.TabIndex = 17
        '
        'btOK
        '
        Me.btOK.BackColor = System.Drawing.Color.PaleGreen
        Me.btOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOK.Location = New System.Drawing.Point(165, 253)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(100, 27)
        Me.btOK.TabIndex = 18
        Me.btOK.Text = "OK"
        Me.btOK.UseVisualStyleBackColor = False
        '
        'btEsborrar
        '
        Me.btEsborrar.BackColor = System.Drawing.Color.Tomato
        Me.btEsborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEsborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEsborrar.Location = New System.Drawing.Point(372, 331)
        Me.btEsborrar.Name = "btEsborrar"
        Me.btEsborrar.Size = New System.Drawing.Size(75, 23)
        Me.btEsborrar.TabIndex = 19
        Me.btEsborrar.Text = "Esborrar"
        Me.btEsborrar.UseVisualStyleBackColor = False
        '
        'btCancelar
        '
        Me.btCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.Location = New System.Drawing.Point(151, 325)
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(125, 33)
        Me.btCancelar.TabIndex = 20
        Me.btCancelar.Text = "Cancel·lar"
        Me.btCancelar.UseVisualStyleBackColor = True
        '
        'lbPreuGas95
        '
        Me.lbPreuGas95.AutoSize = True
        Me.lbPreuGas95.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPreuGas95.Location = New System.Drawing.Point(103, 171)
        Me.lbPreuGas95.Name = "lbPreuGas95"
        Me.lbPreuGas95.Size = New System.Drawing.Size(46, 13)
        Me.lbPreuGas95.TabIndex = 21
        Me.lbPreuGas95.Tag = "1"
        Me.lbPreuGas95.Text = "Import:"
        '
        'lbPreuGas98
        '
        Me.lbPreuGas98.AutoSize = True
        Me.lbPreuGas98.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPreuGas98.Location = New System.Drawing.Point(254, 171)
        Me.lbPreuGas98.Name = "lbPreuGas98"
        Me.lbPreuGas98.Size = New System.Drawing.Size(46, 13)
        Me.lbPreuGas98.TabIndex = 22
        Me.lbPreuGas98.Tag = "2"
        Me.lbPreuGas98.Text = "Import:"
        '
        'lbPreuDiesel
        '
        Me.lbPreuDiesel.AutoSize = True
        Me.lbPreuDiesel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPreuDiesel.Location = New System.Drawing.Point(401, 171)
        Me.lbPreuDiesel.Name = "lbPreuDiesel"
        Me.lbPreuDiesel.Size = New System.Drawing.Size(46, 13)
        Me.lbPreuDiesel.TabIndex = 23
        Me.lbPreuDiesel.Tag = "3"
        Me.lbPreuDiesel.Text = "Import:"
        '
        'lbPreuAdblue
        '
        Me.lbPreuAdblue.AutoSize = True
        Me.lbPreuAdblue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPreuAdblue.Location = New System.Drawing.Point(561, 171)
        Me.lbPreuAdblue.Name = "lbPreuAdblue"
        Me.lbPreuAdblue.Size = New System.Drawing.Size(46, 13)
        Me.lbPreuAdblue.TabIndex = 24
        Me.lbPreuAdblue.Tag = "4"
        Me.lbPreuAdblue.Text = "Import:"
        '
        'CarburantTableAdapter
        '
        Me.CarburantTableAdapter.ClearBeforeFill = True
        '
        'SortidorTableAdapter
        '
        Me.SortidorTableAdapter.ClearBeforeFill = True
        '
        'pbAdBlue
        '
        Me.pbAdBlue.Image = Global.ProjecteGasolinera.My.Resources.Resources.adblue
        Me.pbAdBlue.Location = New System.Drawing.Point(539, 68)
        Me.pbAdBlue.Name = "pbAdBlue"
        Me.pbAdBlue.Size = New System.Drawing.Size(100, 100)
        Me.pbAdBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAdBlue.TabIndex = 3
        Me.pbAdBlue.TabStop = False
        Me.pbAdBlue.Tag = "4"
        '
        'pbDiesel
        '
        Me.pbDiesel.Image = Global.ProjecteGasolinera.My.Resources.Resources.diesel_e
        Me.pbDiesel.Location = New System.Drawing.Point(377, 68)
        Me.pbDiesel.Name = "pbDiesel"
        Me.pbDiesel.Size = New System.Drawing.Size(100, 100)
        Me.pbDiesel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDiesel.TabIndex = 2
        Me.pbDiesel.TabStop = False
        Me.pbDiesel.Tag = "3"
        '
        'pbGasolina98
        '
        Me.pbGasolina98.Image = Global.ProjecteGasolinera.My.Resources.Resources.efitec_98
        Me.pbGasolina98.Location = New System.Drawing.Point(226, 68)
        Me.pbGasolina98.Name = "pbGasolina98"
        Me.pbGasolina98.Size = New System.Drawing.Size(100, 100)
        Me.pbGasolina98.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGasolina98.TabIndex = 1
        Me.pbGasolina98.TabStop = False
        Me.pbGasolina98.Tag = "2"
        '
        'pbGasoilina95
        '
        Me.pbGasoilina95.Image = Global.ProjecteGasolinera.My.Resources.Resources.efitec_95
        Me.pbGasoilina95.Location = New System.Drawing.Point(77, 68)
        Me.pbGasoilina95.Name = "pbGasoilina95"
        Me.pbGasoilina95.Size = New System.Drawing.Size(100, 100)
        Me.pbGasoilina95.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGasoilina95.TabIndex = 0
        Me.pbGasoilina95.TabStop = False
        Me.pbGasoilina95.Tag = "1"
        '
        'FormCombustioSeleccio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 384)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbPreuAdblue)
        Me.Controls.Add(Me.lbPreuDiesel)
        Me.Controls.Add(Me.lbPreuGas98)
        Me.Controls.Add(Me.lbPreuGas95)
        Me.Controls.Add(Me.btCancelar)
        Me.Controls.Add(Me.btEsborrar)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.tbImport)
        Me.Controls.Add(Me.Label1)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbAdBlue)
        Me.Controls.Add(Me.pbDiesel)
        Me.Controls.Add(Me.pbGasolina98)
        Me.Controls.Add(Me.pbGasoilina95)
        Me.Name = "FormCombustioSeleccio"
        Me.Text = "FormCombustioSeleccio"
        CType(Me.pbAdBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDiesel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGasolina98, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGasoilina95, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbGasoilina95 As PictureBox
    Friend WithEvents pbGasolina98 As PictureBox
    Friend WithEvents pbDiesel As PictureBox
    Friend WithEvents pbAdBlue As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bt1 As Button
    Friend WithEvents bt2 As Button
    Friend WithEvents bt3 As Button
    Friend WithEvents bt4 As Button
    Friend WithEvents bt5 As Button
    Friend WithEvents bt6 As Button
    Friend WithEvents bt7 As Button
    Friend WithEvents bt8 As Button
    Friend WithEvents bt9 As Button
    Friend WithEvents bt0 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbImport As TextBox
    Friend WithEvents btOK As Button
    Friend WithEvents btEsborrar As Button
    Friend WithEvents CarburantTableAdapter As GasolineraDataSetTableAdapters.CARBURANTTableAdapter
    Friend WithEvents btCancelar As Button
    Friend WithEvents SortidorTableAdapter As GasolineraDataSetTableAdapters.SORTIDORTableAdapter
    Friend WithEvents lbPreuGas95 As Label
    Friend WithEvents lbPreuGas98 As Label
    Friend WithEvents lbPreuDiesel As Label
    Friend WithEvents lbPreuAdblue As Label
End Class

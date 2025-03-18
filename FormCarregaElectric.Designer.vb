<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCarregaElectric
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
        Me.components = New System.ComponentModel.Container()
        Me.btCarregar = New System.Windows.Forms.Button()
        Me.btParar = New System.Windows.Forms.Button()
        Me.lbEstat = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbBateria = New System.Windows.Forms.Label()
        Me.btFinalitzar = New System.Windows.Forms.Button()
        Me.lbPreuKW = New System.Windows.Forms.Label()
        Me.lbEnergiaSubministrada = New System.Windows.Forms.Label()
        Me.lbCapacitat = New System.Windows.Forms.Label()
        Me.lbCostCarrega = New System.Windows.Forms.Label()
        Me.lbTemps = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TimerCarrega = New System.Windows.Forms.Timer(Me.components)
        Me.SortidorTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.SORTIDORTableAdapter()
        Me.CarburantTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.CARBURANTTableAdapter()
        Me.SubministramentTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.SUBMINISTRAMENTTableAdapter()
        Me.DipositTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.DIPOSITTableAdapter()
        Me.SuspendLayout()
        '
        'btCarregar
        '
        Me.btCarregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCarregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCarregar.Location = New System.Drawing.Point(307, 54)
        Me.btCarregar.Name = "btCarregar"
        Me.btCarregar.Size = New System.Drawing.Size(188, 36)
        Me.btCarregar.TabIndex = 0
        Me.btCarregar.Text = "Començar càrrega"
        Me.btCarregar.UseVisualStyleBackColor = False
        '
        'btParar
        '
        Me.btParar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btParar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btParar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btParar.Location = New System.Drawing.Point(307, 108)
        Me.btParar.Name = "btParar"
        Me.btParar.Size = New System.Drawing.Size(188, 36)
        Me.btParar.TabIndex = 1
        Me.btParar.Text = "Cancel·lar/Parar"
        Me.btParar.UseVisualStyleBackColor = False
        '
        'lbEstat
        '
        Me.lbEstat.AutoSize = True
        Me.lbEstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEstat.Location = New System.Drawing.Point(303, 21)
        Me.lbEstat.Name = "lbEstat"
        Me.lbEstat.Size = New System.Drawing.Size(179, 20)
        Me.lbEstat.TabIndex = 2
        Me.lbEstat.Text = "Estat: carregant o no"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Informació del vehicle"
        '
        'lbBateria
        '
        Me.lbBateria.AutoSize = True
        Me.lbBateria.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBateria.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbBateria.Location = New System.Drawing.Point(15, 81)
        Me.lbBateria.Name = "lbBateria"
        Me.lbBateria.Size = New System.Drawing.Size(143, 18)
        Me.lbBateria.TabIndex = 4
        Me.lbBateria.Text = "Percentatge bateria: "
        '
        'btFinalitzar
        '
        Me.btFinalitzar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btFinalitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btFinalitzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFinalitzar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btFinalitzar.Location = New System.Drawing.Point(305, 195)
        Me.btFinalitzar.Name = "btFinalitzar"
        Me.btFinalitzar.Size = New System.Drawing.Size(188, 36)
        Me.btFinalitzar.TabIndex = 8
        Me.btFinalitzar.Text = "Finalitzar"
        Me.btFinalitzar.UseVisualStyleBackColor = False
        '
        'lbPreuKW
        '
        Me.lbPreuKW.AutoSize = True
        Me.lbPreuKW.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPreuKW.Location = New System.Drawing.Point(14, 155)
        Me.lbPreuKW.Name = "lbPreuKW"
        Me.lbPreuKW.Size = New System.Drawing.Size(101, 20)
        Me.lbPreuKW.TabIndex = 9
        Me.lbPreuKW.Text = "Preu kW/h: "
        '
        'lbEnergiaSubministrada
        '
        Me.lbEnergiaSubministrada.AutoSize = True
        Me.lbEnergiaSubministrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEnergiaSubministrada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbEnergiaSubministrada.Location = New System.Drawing.Point(15, 186)
        Me.lbEnergiaSubministrada.Name = "lbEnergiaSubministrada"
        Me.lbEnergiaSubministrada.Size = New System.Drawing.Size(162, 18)
        Me.lbEnergiaSubministrada.TabIndex = 10
        Me.lbEnergiaSubministrada.Text = "Energia subministrada: "
        '
        'lbCapacitat
        '
        Me.lbCapacitat.AutoSize = True
        Me.lbCapacitat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCapacitat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCapacitat.Location = New System.Drawing.Point(13, 52)
        Me.lbCapacitat.Name = "lbCapacitat"
        Me.lbCapacitat.Size = New System.Drawing.Size(127, 18)
        Me.lbCapacitat.TabIndex = 11
        Me.lbCapacitat.Text = "Capacitat vehicle: "
        '
        'lbCostCarrega
        '
        Me.lbCostCarrega.AutoSize = True
        Me.lbCostCarrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCostCarrega.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbCostCarrega.Location = New System.Drawing.Point(15, 213)
        Me.lbCostCarrega.Name = "lbCostCarrega"
        Me.lbCostCarrega.Size = New System.Drawing.Size(129, 18)
        Me.lbCostCarrega.TabIndex = 12
        Me.lbCostCarrega.Text = "Cost de la càrrega"
        '
        'lbTemps
        '
        Me.lbTemps.AutoSize = True
        Me.lbTemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTemps.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbTemps.Location = New System.Drawing.Point(15, 108)
        Me.lbTemps.Name = "lbTemps"
        Me.lbTemps.Size = New System.Drawing.Size(198, 18)
        Me.lbTemps.TabIndex = 6
        Me.lbTemps.Text = "Temps transcorregut:  00:00 "
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(16, 250)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(477, 36)
        Me.ProgressBar1.TabIndex = 13
        '
        'TimerCarrega
        '
        '
        'SortidorTableAdapter
        '
        Me.SortidorTableAdapter.ClearBeforeFill = True
        '
        'CarburantTableAdapter
        '
        Me.CarburantTableAdapter.ClearBeforeFill = True
        '
        'SubministramentTableAdapter
        '
        Me.SubministramentTableAdapter.ClearBeforeFill = True
        '
        'DipositTableAdapter
        '
        Me.DipositTableAdapter.ClearBeforeFill = True
        '
        'FormCarregaElectric
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 305)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbCostCarrega)
        Me.Controls.Add(Me.lbCapacitat)
        Me.Controls.Add(Me.lbEnergiaSubministrada)
        Me.Controls.Add(Me.lbPreuKW)
        Me.Controls.Add(Me.btFinalitzar)
        Me.Controls.Add(Me.lbTemps)
        Me.Controls.Add(Me.lbBateria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbEstat)
        Me.Controls.Add(Me.btParar)
        Me.Controls.Add(Me.btCarregar)
        Me.Name = "FormCarregaElectric"
        Me.Text = "Càrrega vehicles elèctrics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btCarregar As Button
    Friend WithEvents btParar As Button
    Friend WithEvents lbEstat As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbBateria As Label
    Friend WithEvents btFinalitzar As Button
    Friend WithEvents lbPreuKW As Label
    Friend WithEvents lbEnergiaSubministrada As Label
    Friend WithEvents lbCapacitat As Label
    Friend WithEvents lbCostCarrega As Label
    Friend WithEvents lbTemps As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TimerCarrega As Timer
    Friend WithEvents SortidorTableAdapter As GasolineraDataSetTableAdapters.SORTIDORTableAdapter
    Friend WithEvents CarburantTableAdapter As GasolineraDataSetTableAdapters.CARBURANTTableAdapter
    Friend WithEvents SubministramentTableAdapter As GasolineraDataSetTableAdapters.SUBMINISTRAMENTTableAdapter
    Friend WithEvents DipositTableAdapter As GasolineraDataSetTableAdapters.DIPOSITTableAdapter
End Class

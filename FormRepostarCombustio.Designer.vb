<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRepostarCombustio
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
        Me.lbQuantitat = New System.Windows.Forms.Label()
        Me.lbImport = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbCapacitat = New System.Windows.Forms.Label()
        Me.lbCombustibleActual = New System.Windows.Forms.Label()
        Me.lbPreuLitre = New System.Windows.Forms.Label()
        Me.lbImportIntroduit = New System.Windows.Forms.Label()
        Me.btParar = New System.Windows.Forms.Button()
        Me.btCarregar = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btFinalitzar = New System.Windows.Forms.Button()
        Me.TimerRepostar = New System.Windows.Forms.Timer(Me.components)
        Me.lbIdSortidor = New System.Windows.Forms.Label()
        Me.CarburantTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.CARBURANTTableAdapter()
        Me.SortidorTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.SORTIDORTableAdapter()
        Me.SubministramentTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.SUBMINISTRAMENTTableAdapter()
        Me.DipositTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.DIPOSITTableAdapter()
        Me.SuspendLayout()
        '
        'lbQuantitat
        '
        Me.lbQuantitat.AutoSize = True
        Me.lbQuantitat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuantitat.Location = New System.Drawing.Point(34, 45)
        Me.lbQuantitat.Name = "lbQuantitat"
        Me.lbQuantitat.Size = New System.Drawing.Size(75, 20)
        Me.lbQuantitat.TabIndex = 0
        Me.lbQuantitat.Text = "Quantitat"
        '
        'lbImport
        '
        Me.lbImport.AutoSize = True
        Me.lbImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbImport.Location = New System.Drawing.Point(34, 76)
        Me.lbImport.Name = "lbImport"
        Me.lbImport.Size = New System.Drawing.Size(55, 20)
        Me.lbImport.TabIndex = 1
        Me.lbImport.Text = "Import"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dades del cotxe"
        '
        'lbCapacitat
        '
        Me.lbCapacitat.AutoSize = True
        Me.lbCapacitat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCapacitat.Location = New System.Drawing.Point(34, 223)
        Me.lbCapacitat.Name = "lbCapacitat"
        Me.lbCapacitat.Size = New System.Drawing.Size(77, 20)
        Me.lbCapacitat.TabIndex = 3
        Me.lbCapacitat.Text = "Capacitat"
        '
        'lbCombustibleActual
        '
        Me.lbCombustibleActual.AutoSize = True
        Me.lbCombustibleActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCombustibleActual.Location = New System.Drawing.Point(34, 253)
        Me.lbCombustibleActual.Name = "lbCombustibleActual"
        Me.lbCombustibleActual.Size = New System.Drawing.Size(144, 20)
        Me.lbCombustibleActual.TabIndex = 4
        Me.lbCombustibleActual.Text = "Combustible actual"
        '
        'lbPreuLitre
        '
        Me.lbPreuLitre.AutoSize = True
        Me.lbPreuLitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPreuLitre.Location = New System.Drawing.Point(34, 109)
        Me.lbPreuLitre.Name = "lbPreuLitre"
        Me.lbPreuLitre.Size = New System.Drawing.Size(55, 20)
        Me.lbPreuLitre.TabIndex = 5
        Me.lbPreuLitre.Text = "Preu/L"
        '
        'lbImportIntroduit
        '
        Me.lbImportIntroduit.AutoSize = True
        Me.lbImportIntroduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbImportIntroduit.Location = New System.Drawing.Point(287, 45)
        Me.lbImportIntroduit.Name = "lbImportIntroduit"
        Me.lbImportIntroduit.Size = New System.Drawing.Size(116, 20)
        Me.lbImportIntroduit.TabIndex = 6
        Me.lbImportIntroduit.Text = "Import introduït"
        '
        'btParar
        '
        Me.btParar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btParar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btParar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btParar.Location = New System.Drawing.Point(291, 185)
        Me.btParar.Name = "btParar"
        Me.btParar.Size = New System.Drawing.Size(188, 36)
        Me.btParar.TabIndex = 8
        Me.btParar.Text = "Parar/Cancel·lar"
        Me.btParar.UseVisualStyleBackColor = False
        '
        'btCarregar
        '
        Me.btCarregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btCarregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCarregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCarregar.Location = New System.Drawing.Point(291, 135)
        Me.btCarregar.Name = "btCarregar"
        Me.btCarregar.Size = New System.Drawing.Size(188, 36)
        Me.btCarregar.TabIndex = 7
        Me.btCarregar.Text = "Començar càrrega"
        Me.btCarregar.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(37, 308)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(442, 36)
        Me.ProgressBar1.TabIndex = 9
        '
        'btFinalitzar
        '
        Me.btFinalitzar.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btFinalitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btFinalitzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFinalitzar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btFinalitzar.Location = New System.Drawing.Point(291, 237)
        Me.btFinalitzar.Name = "btFinalitzar"
        Me.btFinalitzar.Size = New System.Drawing.Size(188, 36)
        Me.btFinalitzar.TabIndex = 10
        Me.btFinalitzar.Text = "Finalitzar"
        Me.btFinalitzar.UseVisualStyleBackColor = False
        '
        'TimerRepostar
        '
        Me.TimerRepostar.Interval = 10
        '
        'lbIdSortidor
        '
        Me.lbIdSortidor.AutoSize = True
        Me.lbIdSortidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdSortidor.Location = New System.Drawing.Point(33, 18)
        Me.lbIdSortidor.Name = "lbIdSortidor"
        Me.lbIdSortidor.Size = New System.Drawing.Size(83, 20)
        Me.lbIdSortidor.TabIndex = 11
        Me.lbIdSortidor.Text = "Sortidor: "
        '
        'CarburantTableAdapter
        '
        Me.CarburantTableAdapter.ClearBeforeFill = True
        '
        'SortidorTableAdapter
        '
        Me.SortidorTableAdapter.ClearBeforeFill = True
        '
        'SubministramentTableAdapter
        '
        Me.SubministramentTableAdapter.ClearBeforeFill = True
        '
        'DipositTableAdapter
        '
        Me.DipositTableAdapter.ClearBeforeFill = True
        '
        'FormRepostarCombustio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 365)
        Me.Controls.Add(Me.lbIdSortidor)
        Me.Controls.Add(Me.btFinalitzar)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btParar)
        Me.Controls.Add(Me.btCarregar)
        Me.Controls.Add(Me.lbImportIntroduit)
        Me.Controls.Add(Me.lbPreuLitre)
        Me.Controls.Add(Me.lbCombustibleActual)
        Me.Controls.Add(Me.lbCapacitat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbImport)
        Me.Controls.Add(Me.lbQuantitat)
        Me.Name = "FormRepostarCombustio"
        Me.Text = "FormRepostarCombustio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbQuantitat As Label
    Friend WithEvents lbImport As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbCapacitat As Label
    Friend WithEvents lbCombustibleActual As Label
    Friend WithEvents lbPreuLitre As Label
    Friend WithEvents lbImportIntroduit As Label
    Friend WithEvents btParar As Button
    Friend WithEvents btCarregar As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btFinalitzar As Button
    Friend WithEvents TimerRepostar As Timer
    Friend WithEvents CarburantTableAdapter As GasolineraDataSetTableAdapters.CARBURANTTableAdapter
    Friend WithEvents SortidorTableAdapter As GasolineraDataSetTableAdapters.SORTIDORTableAdapter
    Friend WithEvents SubministramentTableAdapter As GasolineraDataSetTableAdapters.SUBMINISTRAMENTTableAdapter
    Friend WithEvents DipositTableAdapter As GasolineraDataSetTableAdapters.DIPOSITTableAdapter
    Friend WithEvents lbIdSortidor As Label
End Class

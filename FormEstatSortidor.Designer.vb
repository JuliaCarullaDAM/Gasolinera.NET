<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstatSortidor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstatSortidor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btRepostar = New System.Windows.Forms.Button()
        Me.SortidorTableAdapter = New ProjecteGasolinera.GasolineraDataSetTableAdapters.SORTIDORTableAdapter()
        Me.pbEstat = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.pbEstat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sortidor: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estat: "
        '
        'btRepostar
        '
        Me.btRepostar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRepostar.Location = New System.Drawing.Point(89, 348)
        Me.btRepostar.Name = "btRepostar"
        Me.btRepostar.Size = New System.Drawing.Size(283, 45)
        Me.btRepostar.TabIndex = 2
        Me.btRepostar.Text = "Repostar vehicle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btRepostar.UseVisualStyleBackColor = True
        '
        'SortidorTableAdapter
        '
        Me.SortidorTableAdapter.ClearBeforeFill = True
        '
        'pbEstat
        '
        Me.pbEstat.Image = CType(resources.GetObject("pbEstat.Image"), System.Drawing.Image)
        Me.pbEstat.Location = New System.Drawing.Point(137, 128)
        Me.pbEstat.Name = "pbEstat"
        Me.pbEstat.Size = New System.Drawing.Size(180, 180)
        Me.pbEstat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEstat.TabIndex = 3
        Me.pbEstat.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "iconaDisponible.png")
        Me.ImageList1.Images.SetKeyName(1, "iconaOcupat.png")
        Me.ImageList1.Images.SetKeyName(2, "warning-triangle2.png")
        '
        'FormEstatSortidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 429)
        Me.Controls.Add(Me.pbEstat)
        Me.Controls.Add(Me.btRepostar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormEstatSortidor"
        Me.Text = "Estat del sortidor"
        CType(Me.pbEstat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btRepostar As Button
    Friend WithEvents SortidorTableAdapter As GasolineraDataSetTableAdapters.SORTIDORTableAdapter
    Friend WithEvents pbEstat As PictureBox
    Friend WithEvents ImageList1 As ImageList
End Class

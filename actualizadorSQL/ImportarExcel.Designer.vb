<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImportarExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportarExcel))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLink = New System.Windows.Forms.TextBox
        Me.picBuscarArticulo = New System.Windows.Forms.PictureBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        CType(Me.picBuscarArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Acceso"
        '
        'txtLink
        '
        Me.txtLink.Location = New System.Drawing.Point(70, 13)
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(100, 20)
        Me.txtLink.TabIndex = 163
        '
        'picBuscarArticulo
        '
        Me.picBuscarArticulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBuscarArticulo.Image = CType(resources.GetObject("picBuscarArticulo.Image"), System.Drawing.Image)
        Me.picBuscarArticulo.Location = New System.Drawing.Point(176, 13)
        Me.picBuscarArticulo.Name = "picBuscarArticulo"
        Me.picBuscarArticulo.Size = New System.Drawing.Size(23, 20)
        Me.picBuscarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBuscarArticulo.TabIndex = 162
        Me.picBuscarArticulo.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(476, 210)
        Me.DataGridView1.TabIndex = 165
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ImportarExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 302)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLink)
        Me.Controls.Add(Me.picBuscarArticulo)
        Me.Name = "ImportarExcel"
        Me.Text = "ImportarExcel"
        CType(Me.picBuscarArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLink As System.Windows.Forms.TextBox
    Friend WithEvents picBuscarArticulo As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class

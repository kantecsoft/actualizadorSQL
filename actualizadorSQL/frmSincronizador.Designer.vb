<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSincronizador
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog
        Me.btnAplicarCambios = New System.Windows.Forms.Button
        Me.txtProyecto1 = New System.Windows.Forms.TextBox
        Me.txtProyecto2 = New System.Windows.Forms.TextBox
        Me.btnProyecto1 = New System.Windows.Forms.Button
        Me.btnProyecto2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCodigo1 = New System.Windows.Forms.Button
        Me.txtCodigo1 = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCodigo2 = New System.Windows.Forms.TextBox
        Me.btnCodigo2 = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtIdSync = New System.Windows.Forms.TextBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'btnAplicarCambios
        '
        Me.btnAplicarCambios.Location = New System.Drawing.Point(13, 362)
        Me.btnAplicarCambios.Name = "btnAplicarCambios"
        Me.btnAplicarCambios.Size = New System.Drawing.Size(282, 23)
        Me.btnAplicarCambios.TabIndex = 0
        Me.btnAplicarCambios.Text = "Aplicar Cambios"
        Me.btnAplicarCambios.UseVisualStyleBackColor = True
        '
        'txtProyecto1
        '
        Me.txtProyecto1.Location = New System.Drawing.Point(85, 18)
        Me.txtProyecto1.Name = "txtProyecto1"
        Me.txtProyecto1.Size = New System.Drawing.Size(128, 20)
        Me.txtProyecto1.TabIndex = 1
        '
        'txtProyecto2
        '
        Me.txtProyecto2.Location = New System.Drawing.Point(85, 15)
        Me.txtProyecto2.Name = "txtProyecto2"
        Me.txtProyecto2.Size = New System.Drawing.Size(128, 20)
        Me.txtProyecto2.TabIndex = 2
        '
        'btnProyecto1
        '
        Me.btnProyecto1.Location = New System.Drawing.Point(219, 16)
        Me.btnProyecto1.Name = "btnProyecto1"
        Me.btnProyecto1.Size = New System.Drawing.Size(35, 23)
        Me.btnProyecto1.TabIndex = 3
        Me.btnProyecto1.Text = "..."
        Me.btnProyecto1.UseVisualStyleBackColor = True
        '
        'btnProyecto2
        '
        Me.btnProyecto2.Location = New System.Drawing.Point(219, 13)
        Me.btnProyecto2.Name = "btnProyecto2"
        Me.btnProyecto2.Size = New System.Drawing.Size(35, 23)
        Me.btnProyecto2.TabIndex = 4
        Me.btnProyecto2.Text = "..."
        Me.btnProyecto2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCodigo1)
        Me.GroupBox1.Controls.Add(Me.txtCodigo1)
        Me.GroupBox1.Controls.Add(Me.btnProyecto1)
        Me.GroupBox1.Controls.Add(Me.txtProyecto1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 57)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proyecto 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Codigo 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Designer 1"
        '
        'btnCodigo1
        '
        Me.btnCodigo1.Location = New System.Drawing.Point(470, 17)
        Me.btnCodigo1.Name = "btnCodigo1"
        Me.btnCodigo1.Size = New System.Drawing.Size(31, 23)
        Me.btnCodigo1.TabIndex = 5
        Me.btnCodigo1.Text = "..."
        Me.btnCodigo1.UseVisualStyleBackColor = True
        '
        'txtCodigo1
        '
        Me.txtCodigo1.Location = New System.Drawing.Point(336, 19)
        Me.txtCodigo1.Name = "txtCodigo1"
        Me.txtCodigo1.Size = New System.Drawing.Size(128, 20)
        Me.txtCodigo1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtCodigo2)
        Me.GroupBox2.Controls.Add(Me.btnCodigo2)
        Me.GroupBox2.Controls.Add(Me.txtProyecto2)
        Me.GroupBox2.Controls.Add(Me.btnProyecto2)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(507, 50)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proyecto 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(281, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Codigo 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Designer 2"
        '
        'txtCodigo2
        '
        Me.txtCodigo2.Location = New System.Drawing.Point(336, 15)
        Me.txtCodigo2.Name = "txtCodigo2"
        Me.txtCodigo2.Size = New System.Drawing.Size(128, 20)
        Me.txtCodigo2.TabIndex = 5
        '
        'btnCodigo2
        '
        Me.btnCodigo2.Location = New System.Drawing.Point(470, 13)
        Me.btnCodigo2.Name = "btnCodigo2"
        Me.btnCodigo2.Size = New System.Drawing.Size(31, 23)
        Me.btnCodigo2.TabIndex = 6
        Me.btnCodigo2.Text = "..."
        Me.btnCodigo2.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(348, 362)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 391)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Revertir Diseño"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtIdSync
        '
        Me.txtIdSync.Location = New System.Drawing.Point(301, 365)
        Me.txtIdSync.Name = "txtIdSync"
        Me.txtIdSync.Size = New System.Drawing.Size(30, 20)
        Me.txtIdSync.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(157, 391)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Revertir Codigo"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.descripcion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(7, 4)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(512, 195)
        Me.DataGridView1.TabIndex = 13
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripción"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 400
        '
        'frmSincronizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 431)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtIdSync)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAplicarCambios)
        Me.Name = "frmSincronizador"
        Me.Text = "frmSincronizador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAplicarCambios As System.Windows.Forms.Button
    Friend WithEvents txtProyecto1 As System.Windows.Forms.TextBox
    Friend WithEvents txtProyecto2 As System.Windows.Forms.TextBox
    Friend WithEvents btnProyecto1 As System.Windows.Forms.Button
    Friend WithEvents btnProyecto2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCodigo1 As System.Windows.Forms.Button
    Friend WithEvents txtCodigo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCodigo2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtIdSync As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracionBases
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.txtConfiguracionAvanzadaBalanza = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtServerBalanza = New System.Windows.Forms.TextBox
        Me.lblNombreServidor = New System.Windows.Forms.Label
        Me.chkServerSQLBalanza = New System.Windows.Forms.CheckBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.txtConfiguracionAvanzadaColonos = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtServidorColonos = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.chkSqlServerColonos = New System.Windows.Forms.CheckBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel
        Me.txtConfiguracionAvanzadaAux = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtServerAux = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkSqlServerAux = New System.Windows.Forms.CheckBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel
        Me.txtConfiguracionAvanzadaExportacion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtServidorExportacion = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkServerSqlExportacion = New System.Windows.Forms.CheckBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel
        Me.txtConfiguracionAvanzadaCompras = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtServidorCompras = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkServerSqlCompras = New System.Windows.Forms.CheckBox
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.LinkLabel6 = New System.Windows.Forms.LinkLabel
        Me.txtConfiguracionAvanzadaStock = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtServidorStock = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.chkServerSqlStock = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(2, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(412, 247)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(404, 221)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Balanza"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.txtConfiguracionAvanzadaBalanza)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtServerBalanza)
        Me.GroupBox1.Controls.Add(Me.lblNombreServidor)
        Me.GroupBox1.Controls.Add(Me.chkServerSQLBalanza)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 179)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acceso a la base de datos módulo Balanza"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(21, 138)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Testear conexion"
        '
        'txtConfiguracionAvanzadaBalanza
        '
        Me.txtConfiguracionAvanzadaBalanza.Location = New System.Drawing.Point(21, 102)
        Me.txtConfiguracionAvanzadaBalanza.Name = "txtConfiguracionAvanzadaBalanza"
        Me.txtConfiguracionAvanzadaBalanza.Size = New System.Drawing.Size(366, 20)
        Me.txtConfiguracionAvanzadaBalanza.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Configuración avanzada"
        '
        'txtServerBalanza
        '
        Me.txtServerBalanza.Location = New System.Drawing.Point(64, 45)
        Me.txtServerBalanza.Name = "txtServerBalanza"
        Me.txtServerBalanza.Size = New System.Drawing.Size(323, 20)
        Me.txtServerBalanza.TabIndex = 2
        '
        'lblNombreServidor
        '
        Me.lblNombreServidor.AutoSize = True
        Me.lblNombreServidor.Location = New System.Drawing.Point(18, 48)
        Me.lblNombreServidor.Name = "lblNombreServidor"
        Me.lblNombreServidor.Size = New System.Drawing.Size(49, 13)
        Me.lblNombreServidor.TabIndex = 1
        Me.lblNombreServidor.Text = "Servidor:"
        '
        'chkServerSQLBalanza
        '
        Me.chkServerSQLBalanza.AutoSize = True
        Me.chkServerSQLBalanza.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkServerSQLBalanza.Location = New System.Drawing.Point(21, 28)
        Me.chkServerSQLBalanza.Name = "chkServerSQLBalanza"
        Me.chkServerSQLBalanza.Size = New System.Drawing.Size(119, 17)
        Me.chkServerSQLBalanza.TabIndex = 0
        Me.chkServerSQLBalanza.Text = "Microsoft Server"
        Me.chkServerSQLBalanza.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(404, 221)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Colonos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LinkLabel2)
        Me.GroupBox3.Controls.Add(Me.txtConfiguracionAvanzadaColonos)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtServidorColonos)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.chkSqlServerColonos)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(393, 179)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acceso a la base de datos módulo Colonos"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(21, 138)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(89, 13)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Testear conexion"
        '
        'txtConfiguracionAvanzadaColonos
        '
        Me.txtConfiguracionAvanzadaColonos.Location = New System.Drawing.Point(21, 102)
        Me.txtConfiguracionAvanzadaColonos.Name = "txtConfiguracionAvanzadaColonos"
        Me.txtConfiguracionAvanzadaColonos.Size = New System.Drawing.Size(366, 20)
        Me.txtConfiguracionAvanzadaColonos.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Configuración avanzada"
        '
        'txtServidorColonos
        '
        Me.txtServidorColonos.Location = New System.Drawing.Point(64, 45)
        Me.txtServidorColonos.Name = "txtServidorColonos"
        Me.txtServidorColonos.Size = New System.Drawing.Size(323, 20)
        Me.txtServidorColonos.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Servidor:"
        '
        'chkSqlServerColonos
        '
        Me.chkSqlServerColonos.AutoSize = True
        Me.chkSqlServerColonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSqlServerColonos.Location = New System.Drawing.Point(21, 28)
        Me.chkSqlServerColonos.Name = "chkSqlServerColonos"
        Me.chkSqlServerColonos.Size = New System.Drawing.Size(119, 17)
        Me.chkSqlServerColonos.TabIndex = 0
        Me.chkSqlServerColonos.Text = "Microsoft Server"
        Me.chkSqlServerColonos.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(404, 221)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Auxiliares_Contables"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LinkLabel3)
        Me.GroupBox4.Controls.Add(Me.txtConfiguracionAvanzadaAux)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtServerAux)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.chkSqlServerAux)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(393, 179)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acceso a la base de datos módulo Auxiliares Contables"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Location = New System.Drawing.Point(21, 138)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(89, 13)
        Me.LinkLabel3.TabIndex = 5
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Testear conexion"
        '
        'txtConfiguracionAvanzadaAux
        '
        Me.txtConfiguracionAvanzadaAux.Location = New System.Drawing.Point(21, 102)
        Me.txtConfiguracionAvanzadaAux.Name = "txtConfiguracionAvanzadaAux"
        Me.txtConfiguracionAvanzadaAux.Size = New System.Drawing.Size(366, 20)
        Me.txtConfiguracionAvanzadaAux.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Configuración avanzada"
        '
        'txtServerAux
        '
        Me.txtServerAux.Location = New System.Drawing.Point(64, 45)
        Me.txtServerAux.Name = "txtServerAux"
        Me.txtServerAux.Size = New System.Drawing.Size(323, 20)
        Me.txtServerAux.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Servidor:"
        '
        'chkSqlServerAux
        '
        Me.chkSqlServerAux.AutoSize = True
        Me.chkSqlServerAux.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSqlServerAux.Location = New System.Drawing.Point(21, 28)
        Me.chkSqlServerAux.Name = "chkSqlServerAux"
        Me.chkSqlServerAux.Size = New System.Drawing.Size(119, 17)
        Me.chkSqlServerAux.TabIndex = 0
        Me.chkSqlServerAux.Text = "Microsoft Server"
        Me.chkSqlServerAux.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(404, 221)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Exportacion"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.LinkLabel4)
        Me.GroupBox5.Controls.Add(Me.txtConfiguracionAvanzadaExportacion)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtServidorExportacion)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.chkServerSqlExportacion)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(393, 179)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Acceso a la base de datos módulo Expotación"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Location = New System.Drawing.Point(21, 138)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(89, 13)
        Me.LinkLabel4.TabIndex = 5
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Testear conexion"
        '
        'txtConfiguracionAvanzadaExportacion
        '
        Me.txtConfiguracionAvanzadaExportacion.Location = New System.Drawing.Point(21, 102)
        Me.txtConfiguracionAvanzadaExportacion.Name = "txtConfiguracionAvanzadaExportacion"
        Me.txtConfiguracionAvanzadaExportacion.Size = New System.Drawing.Size(366, 20)
        Me.txtConfiguracionAvanzadaExportacion.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Configuración avanzada"
        '
        'txtServidorExportacion
        '
        Me.txtServidorExportacion.Location = New System.Drawing.Point(64, 45)
        Me.txtServidorExportacion.Name = "txtServidorExportacion"
        Me.txtServidorExportacion.Size = New System.Drawing.Size(323, 20)
        Me.txtServidorExportacion.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Servidor:"
        '
        'chkServerSqlExportacion
        '
        Me.chkServerSqlExportacion.AutoSize = True
        Me.chkServerSqlExportacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkServerSqlExportacion.Location = New System.Drawing.Point(21, 28)
        Me.chkServerSqlExportacion.Name = "chkServerSqlExportacion"
        Me.chkServerSqlExportacion.Size = New System.Drawing.Size(119, 17)
        Me.chkServerSqlExportacion.TabIndex = 0
        Me.chkServerSqlExportacion.Text = "Microsoft Server"
        Me.chkServerSqlExportacion.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GroupBox6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(404, 221)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Compras"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.LinkLabel5)
        Me.GroupBox6.Controls.Add(Me.txtConfiguracionAvanzadaCompras)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.txtServidorCompras)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.chkServerSqlCompras)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(393, 179)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Acceso a la base de datos módulo Compras"
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.Location = New System.Drawing.Point(21, 138)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(89, 13)
        Me.LinkLabel5.TabIndex = 5
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Testear conexion"
        '
        'txtConfiguracionAvanzadaCompras
        '
        Me.txtConfiguracionAvanzadaCompras.Location = New System.Drawing.Point(21, 102)
        Me.txtConfiguracionAvanzadaCompras.Name = "txtConfiguracionAvanzadaCompras"
        Me.txtConfiguracionAvanzadaCompras.Size = New System.Drawing.Size(366, 20)
        Me.txtConfiguracionAvanzadaCompras.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Configuración avanzada"
        '
        'txtServidorCompras
        '
        Me.txtServidorCompras.Location = New System.Drawing.Point(64, 45)
        Me.txtServidorCompras.Name = "txtServidorCompras"
        Me.txtServidorCompras.Size = New System.Drawing.Size(323, 20)
        Me.txtServidorCompras.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Servidor:"
        '
        'chkServerSqlCompras
        '
        Me.chkServerSqlCompras.AutoSize = True
        Me.chkServerSqlCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkServerSqlCompras.Location = New System.Drawing.Point(21, 28)
        Me.chkServerSqlCompras.Name = "chkServerSqlCompras"
        Me.chkServerSqlCompras.Size = New System.Drawing.Size(119, 17)
        Me.chkServerSqlCompras.TabIndex = 0
        Me.chkServerSqlCompras.Text = "Microsoft Server"
        Me.chkServerSqlCompras.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox7)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(404, 221)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Stock"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LinkLabel6)
        Me.GroupBox7.Controls.Add(Me.txtConfiguracionAvanzadaStock)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.txtServidorStock)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.chkServerSqlStock)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 21)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(393, 179)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Acceso a la base de datos módulo Balanza"
        '
        'LinkLabel6
        '
        Me.LinkLabel6.AutoSize = True
        Me.LinkLabel6.Location = New System.Drawing.Point(21, 138)
        Me.LinkLabel6.Name = "LinkLabel6"
        Me.LinkLabel6.Size = New System.Drawing.Size(89, 13)
        Me.LinkLabel6.TabIndex = 5
        Me.LinkLabel6.TabStop = True
        Me.LinkLabel6.Text = "Testear conexion"
        '
        'txtConfiguracionAvanzadaStock
        '
        Me.txtConfiguracionAvanzadaStock.Location = New System.Drawing.Point(21, 102)
        Me.txtConfiguracionAvanzadaStock.Name = "txtConfiguracionAvanzadaStock"
        Me.txtConfiguracionAvanzadaStock.Size = New System.Drawing.Size(366, 20)
        Me.txtConfiguracionAvanzadaStock.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Configuración avanzada"
        '
        'txtServidorStock
        '
        Me.txtServidorStock.Location = New System.Drawing.Point(64, 45)
        Me.txtServidorStock.Name = "txtServidorStock"
        Me.txtServidorStock.Size = New System.Drawing.Size(323, 20)
        Me.txtServidorStock.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Servidor:"
        '
        'chkServerSqlStock
        '
        Me.chkServerSqlStock.AutoSize = True
        Me.chkServerSqlStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkServerSqlStock.Location = New System.Drawing.Point(21, 28)
        Me.chkServerSqlStock.Name = "chkServerSqlStock"
        Me.chkServerSqlStock.Size = New System.Drawing.Size(119, 17)
        Me.chkServerSqlStock.TabIndex = 0
        Me.chkServerSqlStock.Text = "Microsoft Server"
        Me.chkServerSqlStock.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 47)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(329, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(248, 19)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmConfiguracionBases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 315)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmConfiguracionBases"
        Me.Text = "Configuracion"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents chkServerSQLBalanza As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNombreServidor As System.Windows.Forms.Label
    Friend WithEvents txtServerBalanza As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConfiguracionAvanzadaBalanza As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtConfiguracionAvanzadaColonos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtServidorColonos As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkSqlServerColonos As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtConfiguracionAvanzadaAux As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtServerAux As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkSqlServerAux As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel4 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtConfiguracionAvanzadaExportacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtServidorExportacion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkServerSqlExportacion As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel5 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtConfiguracionAvanzadaCompras As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtServidorCompras As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkServerSqlCompras As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel6 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtConfiguracionAvanzadaStock As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtServidorStock As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chkServerSqlStock As System.Windows.Forms.CheckBox
End Class

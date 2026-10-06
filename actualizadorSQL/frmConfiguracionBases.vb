Public Class frmConfiguracionBases

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        ' Oculta todos los GroupBox
        ' GroupBox1.Visible = False
        'GroupBox2.Visible = False
        'GroupBox3.Visible = False

        ' Muestra el GroupBox correspondiente al nodo seleccionado
        Select Case e.Node.Name
            Case "Nodo1"
                'GroupBox1.Visible = True
                TabControl1.SelectedTab = TabPage1
            Case "Nodo2"
                'GroupBox2.Visible = True
                TabControl1.SelectedTab = TabPage2
            Case "Nodo3"
                'GroupBox3.Visible = True
                'TabControl1.SelectedTab = tabPage3
        End Select
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        guardarConfiguracion()

    End Sub
    'FUNCIONES Y PROCEDIMIENTOS
    Private Sub guardarConfiguracion()
        Try

            My.Settings.BALANZAGLOBAL = txtConfiguracionAvanzadaBalanza.Text
            My.Settings.COLONGLOBAL = txtConfiguracionAvanzadaColonos.Text
            My.Settings.EXPORTACIONGLOBAL = txtConfiguracionAvanzadaExportacion.Text
            My.Settings.COMPRASGLOBAL = txtConfiguracionAvanzadaCompras.Text
            My.Settings.AUXILIARES_CONTABLESGLOBAL = txtConfiguracionAvanzadaAux.Text
            My.Settings.STOCKGLOBAL = txtConfiguracionAvanzadaStock.Text
            My.Settings.Save()
            MsgBox("Los Datos se guardaron correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmConfiguracionBases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtConfiguracionAvanzadaBalanza.Text = My.Settings.BALANZAGLOBAL
        txtConfiguracionAvanzadaCompras.Text = My.Settings.COMPRASGLOBAL
        txtConfiguracionAvanzadaExportacion.Text = My.Settings.EXPORTACIONGLOBAL
        txtConfiguracionAvanzadaColonos.Text = My.Settings.COLONGLOBAL
        txtConfiguracionAvanzadaStock.Text = My.Settings.STOCKGLOBAL
        txtConfiguracionAvanzadaAux.Text = My.Settings.AUXILIARES_CONTABLESGLOBAL
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class
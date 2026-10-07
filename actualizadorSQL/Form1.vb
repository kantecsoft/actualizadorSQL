Public Class Form1

    Private Sub ConfiguracionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        frmConfiguracionBases.Show()
    End Sub

    Private Sub TareasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TareasToolStripMenuItem.Click
        frmTareas.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistorialToolStripMenuItem.Click
        frmTareasHistorial.Show()
    End Sub

    Private Sub SincronizarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SincronizarToolStripMenuItem.Click
        frmSincronizador.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'esto es una prueba 06-10-2026
        'Este cambio es par el comit 2
        'CAMBIO DE 13:20
    End Sub
End Class

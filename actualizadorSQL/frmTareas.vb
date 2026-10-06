Imports System.Data.SqlClient

Public Class frmTareas
    Public esNuevo As Integer = 0
    Dim connectionString As String = _
           "Integrated Security=SSPI;" & _
           "Persist Security Info=False;" & _
           "Initial Catalog=EXPOTEC_BALANZA;" & _
           "Data Source=SVCF-DESARROLLO"

    Private Sub frmTareas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dgvEjemplo.Columns.Clear()
        '' Crear columnas
        'dgvEjemplo.Columns.Add("Columna1", "ID")
        'dgvEjemplo.Columns.Add("Columna2", "Nombre")
        'dgvEjemplo.Columns.Add("Columna3", "Edad")

        ' Agregar filas manualmente
        'DataGridView1.Rows.Add("1", "DEV001-", "EXPOTEC_BALANZA")
        'DataGridView1.Rows.Add("2", "DEV002-", "EXPOTEC_BALANZA")
        'DataGridView1.Rows.Add("3", "DEV003-", "EXPOTEC_BALANZA")
        cargarTareas()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            Dim nombre As String = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            txtDescripcion.Text = nombre
            lblID.Text = id
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            Dim nombre As String = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            txtDescripcion.Text = nombre
            lblID.Text = id
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        enviarDetalle()
    End Sub
    'FUNCIONES Y PROCEDIMIENTOS
    Private Sub cargarTareas()
        DataGridView1.Rows.Clear()
        Using conn As New SqlConnection(connectionString)
            Try
                ' Abrir conexión
                conn.Open()
                Console.WriteLine("Conexión exitosa a SQL Server.")

                ' Ejemplo: ejecutar un comando simple
                'Dim query As String = "SELECT [ID],[_IDBalanza]  FROM [EXPOTEC_BALANZA].[dbo].[LOTES] WHERE _IDBalanza=88"
                Dim query As String = "SELECT [ID],[Descripcion] FROM [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS]"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            'MsgBox(reader("ID").ToString)
                            'Console.WriteLine(reader(0).ToString())
                            DataGridView1.Rows.Add(reader("ID"), reader("Descripcion"))
                        End While
                    End Using
                End Using

            Catch ex As Exception
                'Console.WriteLine("Error al conectar: " & ex.Message)
                MsgBox(ex.Message)
            Finally
                ' La conexión se cierra automáticamente por el Using
            End Try
        End Using

    End Sub
    Private Sub enviarDetalle()
        frmDetalleTarea.cod = lblID.Text
        frmDetalleTarea.des = txtDescripcion.Text
        frmDetalleTarea.Show()
    End Sub
    Private Sub limpiarDatos()
        lblID.Text = "0"
        txtDescripcion.Text = ""

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        esNuevo = 1
        limpiarDatos()
    End Sub

    Private Sub cmbBase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If (lblID.Text.Equals("0")) Then
            guardarTarea()
            cargarTareas()
        Else
            actualizarTarea()
            cargarTareas()
            'MsgBox("")
        End If
    End Sub
    'FUNCIONES Y PROCEDIMIENTOS
    Private Sub actualizarTarea()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                ' Sentencia SQL parametrizada para evitar inyección
                Dim query As String = "UPDATE [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS] SET [Descripcion] = '" & txtDescripcion.Text & "'  WHERE ID=" & lblID.Text

                Using cmd As New SqlCommand(query, conn)

                    ' Ejecutamos el INSERT
                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MsgBox("Registro actualizado correctamente.")

                        ' Opcional: actualizar el DataGridView para mostrar el nuevo registro
                        DataGridView1.Rows.Add(id.ToString(), descripcion)
                    Else
                        MsgBox("No se actualizo ningún registro.")
                    End If
                End Using
                limpiarDatos()
            Catch ex As Exception
                MsgBox("Error al guardar: " & ex.Message)
            End Try
        End Using

    End Sub
    Private Sub guardarTarea()

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                ' Sentencia SQL parametrizada para evitar inyección
                Dim query As String = "INSERT INTO [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS] (Descripcion) VALUES ('" & txtDescripcion.Text & "')"

                Using cmd As New SqlCommand(query, conn)

                    ' Ejecutamos el INSERT
                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MsgBox("Registro guardado correctamente.")

                        ' Opcional: actualizar el DataGridView para mostrar el nuevo registro
                        DataGridView1.Rows.Add(id.ToString(), descripcion)
                    Else
                        MsgBox("No se insertó ningún registro.")
                    End If
                End Using
                limpiarDatos()
            Catch ex As Exception
                MsgBox("Error al guardar: " & ex.Message)
            End Try
        End Using

    End Sub
End Class
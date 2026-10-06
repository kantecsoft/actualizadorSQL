Imports System.Data.SqlClient

Public Class frmDetalleTarea
    Public cod As String
    Public des As String
    Public bas As String
    Dim connectionString As String = _
           "Integrated Security=SSPI;" & _
           "Persist Security Info=False;" & _
           "Initial Catalog=EXPOTEC_BALANZA;" & _
           "Data Source=SVCF-DESARROLLO"
    Private Sub frmDetalleTarea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        cargarDetalleTarea()

    End Sub
    'FUNCIONES Y PROCEDIMIENTOS
    Private Sub eliminarDetalleTarea()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                ' Sentencia SQL parametrizada para evitar inyección
                Dim query As String = "DELETE FROM [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS_DETALLE] WHERE ID=" & lblCodigo.Text

                Using cmd As New SqlCommand(query, conn)

                    ' Ejecutamos el INSERT
                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MsgBox("Registro eliminado correctamente.")

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
    Private Sub ejecutarTarea(ByVal sql As String, ByVal codigoDetalle As String, ByVal desDetalle As String)
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                ' Sentencia SQL parametrizada para evitar inyección
                Dim query As String = sql
                Using cmd As New SqlCommand(query, conn)
                    ' Ejecutamos el INSERT
                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                End Using
                guardarTareaHistorial(sql, codigoDetalle, desDetalle)
                limpiarDatos()
            Catch ex As Exception
                MsgBox("Error al guardar: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub guardarTareaHistorial(ByVal sql As String, ByVal codigoDetalle As String, ByVal desDetalle As String)
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                ' Sentencia SQL parametrizada para evitar inyección
                Dim query As String = "INSERT INTO [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS_HISTORIAL]" & _
           "([_IDTarea]" & _
           ",[Descripcion_Tarea]" & _
           ",[_IDDetalleTarea]" & _
           ",[Descripcion_Detalle_Tarea]" & _
           ",[Fecha])" & _
                "VALUES" & _
           "(" & lblCodPrinicpal.Text & "" & _
           ",'" & lblDescripcionPrincipal.Text & "'" & _
           "," & codigoDetalle & "" & _
           ",'" & desDetalle & "'" & _
           ",'" & Date.Now & "')"

                Using cmd As New SqlCommand(query, conn)

                    ' Ejecutamos el INSERT
                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()


                End Using
                'limpiarDatos()
            Catch ex As Exception
                MsgBox("Error al guardar: " & ex.Message)
            End Try
        End Using

    End Sub
    Private Sub procesandoTareas()
        ' Recorremos el DataGridView y actualizamos el ProgressBar
        ProgressBar1.Value = 0
        ' Contar filas válidas (sin la fila nueva vacía)
        Dim totalFilas As Integer = DataGridView1.Rows.Cast(Of DataGridViewRow)().Count(Function(r) Not r.IsNewRow)

        ' Calcular cuánto vale cada fila en porcentaje
        Dim incremento As Integer = CInt(100 / totalFilas)

        For Each fila As DataGridViewRow In DataGridView1.Rows
            ' Evitar la fila nueva vacía
            If Not fila.IsNewRow Then
                ' Aquí puedes hacer lo que necesites con cada fila
                Dim codigoDetalle As String = fila.Cells(0).Value.ToString()
                Dim desDetalle As String = fila.Cells(1).Value.ToString()
                Dim sql As String = fila.Cells(2).Value.ToString()
                'Dim edad As Integer = Convert.ToInt32(fila.Cells(1).Value)

                ' Simulación de proceso (ejemplo: mostrar en consola)
                'Console.WriteLine("Procesando: " & nombre & " - " & edad)
                ejecutarTarea(sql, codigoDetalle, desDetalle)
                ' Actualizar el ProgressBar
                ProgressBar1.Value += incremento

                ' Refrescar la interfaz para que se vea el avance
                Application.DoEvents()
            End If
        Next
        MsgBox("Proceso finalizado con exito")
        ProgressBar1.Value = 0
    End Sub
    Private Sub actualizarTarea()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                ' Sentencia SQL parametrizada para evitar inyección
                'Dim query As String = "UPDATE [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS] SET [Descripcion] = '" & txtDescripcion.Text & "'  WHERE ID=" & lblCodigo.Text
                Dim query As String = "UPDATE [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS_DETALLE] SET [Descripcion] = '" & txtDescripcion.Text & "',[Sql] = '" & txtSql.Text & "'  WHERE ID=" & lblCodigo.Text
                Using cmd As New SqlCommand(query, conn)

                    ' Ejecutamos el INSERT
                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                End Using
                limpiarDatos()
            Catch ex As Exception
                MsgBox("Error al guardar: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub cargarDetalleTarea()
        lblCodPrinicpal.Text = cod
        lblDescripcionPrincipal.Text = des

        DataGridView1.Rows.Clear()
        Using conn As New SqlConnection(connectionString)
            Try
                ' Abrir conexión
                conn.Open()
                Console.WriteLine("Conexión exitosa a SQL Server.")

                ' Ejemplo: ejecutar un comando simple
                'Dim query As String = "SELECT [ID],[_IDBalanza]  FROM [EXPOTEC_BALANZA].[dbo].[LOTES] WHERE _IDBalanza=88"
                Dim query As String = "SELECT td.[ID],td.[Descripcion],td.[Sql] FROM [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS_DETALLE] as td " & _
                " INNER JOIN [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREA_TAREA_DETALLE] as ttd on td.[ID] = ttd._IDTarea_Detalle" & _
                " WHERE  ttd._IDTarea =" & lblCodPrinicpal.Text
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            'MsgBox(reader("ID").ToString)
                            'Console.WriteLine(reader(0).ToString())
                            DataGridView1.Rows.Add(reader("ID"), reader("Descripcion"), reader("Sql"))
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

    Private Sub limpiarDatos()
        lblCodigo.Text = "0"
        txtDescripcion.Text = ""
        txtSql.Text = ""
    End Sub
    Private Sub cargarDetalle()
        lblCodPrinicpal.Text = cod
        lblDescripcionPrincipal.Text = des
        'cmbBase.Text = bas
        '''''''''''''''''''''''''''''''
        ' Crear conexión
        Using conn As New SqlConnection(connectionString)
            Try
                ' Abrir conexión
                conn.Open()
                Console.WriteLine("Conexión exitosa a SQL Server.")

                ' Ejemplo: ejecutar un comando simple
                'Dim query As String = "SELECT [ID],[_IDBalanza]  FROM [EXPOTEC_BALANZA].[dbo].[LOTES] WHERE _IDBalanza=88"
                Dim query As String = "SELECT TAREAS_DETALLE.ID,  TAREAS_DETALLE.Descripcion, TAREAS_DETALLE.Sql  FROM [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREA_TAREA_DETALLE] " & _
                " INNER JOIN [EXPOTEC_ACTUALIZADOR_BD].[dbo].TAREAS ON TAREA_TAREA_DETALLE._IDTarea = TAREAS.ID " & _
                " INNER JOIN [EXPOTEC_ACTUALIZADOR_BD].[dbo].TAREAS_DETALLE ON TAREAS_DETALLE.ID = TAREA_TAREA_DETALLE._IDTarea_Detalle" & _
                " WHERE TAREAS.ID=" & lblCodPrinicpal.Text
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DataGridView1.Rows.Add(reader("ID"), reader("Descripcion"), reader("Sql"))
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
        ''''''''''''''''''''''''''''''
    End Sub
    Private Sub guardarDetalleTarea()
        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()

                ' 1. Insertar en TAREAS_DETALLE y recuperar el ID generado
                Dim queryDetalle As String = _
                    "INSERT INTO [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS_DETALLE] (Descripcion, Sql) " & _
                    "VALUES (@Descripcion, @Sql); " & _
                    "SELECT SCOPE_IDENTITY();"

                Dim idTareaDetalle As Integer
                Using cmdDetalle As New SqlCommand(queryDetalle, conn)
                    cmdDetalle.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text)
                    cmdDetalle.Parameters.AddWithValue("@Sql", txtSql.Text) ' suponiendo que tienes un TextBox para el SQL

                    idTareaDetalle = Convert.ToInt32(cmdDetalle.ExecuteScalar())
                End Using

                ' 2. Insertar en TAREA_TAREA_DETALLE usando el ID recuperado
                Dim queryRelacion As String = _
                    "INSERT INTO [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREA_TAREA_DETALLE] (_IDTarea, _IDTarea_Detalle) " & _
                    "VALUES (@IDTarea, @IDTareaDetalle)"

                Using cmdRelacion As New SqlCommand(queryRelacion, conn)
                    cmdRelacion.Parameters.AddWithValue("@IDTarea", lblCodPrinicpal.Text) ' aquí deberías tener el ID de la tarea principal
                    cmdRelacion.Parameters.AddWithValue("@IDTareaDetalle", idTareaDetalle)

                    cmdRelacion.ExecuteNonQuery()
                End Using

                limpiarDatos()

            Catch ex As Exception
                MsgBox("Error al guardar: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If (lblCodigo.Text.Equals("0")) Then
            guardarDetalleTarea()
            cargarDetalleTarea()
        Else
            actualizarTarea()
            cargarDetalleTarea()

        End If
    End Sub

    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        procesandoTareas()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'If DataGridView1.CurrentRow IsNot Nothing Then
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Dim descripcion As String = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Dim sql As String = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtDescripcion.Text = descripcion
        lblCodigo.Text = id
        txtSql.Text = sql
        'End If
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Dim descripcion As String = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Dim sql As String = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        txtDescripcion.Text = descripcion
        lblCodigo.Text = id
        txtSql.Text = sql
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        limpiarDatos()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If (lblCodigo.Text <> "0") Then
            eliminarDetalleTarea()
            limpiarDatos()
            cargarDetalleTarea()
        Else
            MsgBox("Debe seleccionar una tarea")
        End If
    End Sub

    Private Sub btnProcesarUnico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesarUnico.Click
        Try

            If (lblCodigo.Text <> "0") Then
                If (txtSql.Text <> "") Then
                    ProgressBar1.Value = 0
                    ejecutarTarea(txtSql.Text, lblCodigo.Text, txtDescripcion.Text)
                    ProgressBar1.Value += 100
                    MsgBox("Proceso finalizado con exito")
                    ProgressBar1.Value = 0
                    limpiarDatos()
                Else
                    MsgBox("La consulta no es valida")
                End If
            Else
                MsgBox("Debe seleccionar una tarea")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub txtBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar.TextChanged

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
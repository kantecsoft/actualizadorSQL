Imports System.Data.SqlClient

Public Class frmTareasHistorial
    Dim connectionString As String = _
          "Integrated Security=SSPI;" & _
          "Persist Security Info=False;" & _
          "Initial Catalog=EXPOTEC_BALANZA;" & _
          "Data Source=SVCF-DESARROLLO"
    Private Sub frmTareasHistorial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        cargarTareas()
    End Sub
    'FUNCIONES Y PROCEDIMIENTOS
    Private Sub buscarTarea()
        Try
            DataGridView1.Rows.Clear()
            Using conn As New SqlConnection(connectionString)
                Try
                    ' Abrir conexión
                    conn.Open()
                    Console.WriteLine("Conexión exitosa a SQL Server.")

                    ' Ejemplo: ejecutar un comando simple
                    'Dim query As String = "SELECT [ID],[_IDBalanza]  FROM [EXPOTEC_BALANZA].[dbo].[LOTES] WHERE _IDBalanza=88"
                    Dim query As String = "SELECT [ID],[_IDTarea],[Descripcion_Tarea],[_IDDetalleTarea],[Descripcion_Detalle_Tarea],[Fecha]  FROM [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS_HISTORIAL] WHERE Descripcion_Tarea LIKE '%" & txtBuscar.Text & "%' ORDER BY ID DESC"
                    Using cmd As New SqlCommand(query, conn)
                        Using reader As SqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                'MsgBox(reader("ID").ToString)
                                'Console.WriteLine(reader(0).ToString())
                                DataGridView1.Rows.Add(reader("ID"), reader("_IDTarea"), reader("Descripcion_Tarea"), reader("_IDDetalleTarea"), reader("Descripcion_Detalle_Tarea"), reader("Fecha"))
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

        Catch ex As Exception

        End Try

    End Sub
    Private Sub cargarTareas()
        DataGridView1.Rows.Clear()
        Using conn As New SqlConnection(connectionString)
            Try
                ' Abrir conexión
                conn.Open()
                Console.WriteLine("Conexión exitosa a SQL Server.")

                ' Ejemplo: ejecutar un comando simple
                'Dim query As String = "SELECT [ID],[_IDBalanza]  FROM [EXPOTEC_BALANZA].[dbo].[LOTES] WHERE _IDBalanza=88"
                Dim query As String = "SELECT [ID],[_IDTarea],[Descripcion_Tarea],[_IDDetalleTarea],[Descripcion_Detalle_Tarea],[Fecha]  FROM [EXPOTEC_ACTUALIZADOR_BD].[dbo].[TAREAS_HISTORIAL] ORDER BY ID DESC"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            'MsgBox(reader("ID").ToString)
                            'Console.WriteLine(reader(0).ToString())
                            DataGridView1.Rows.Add(reader("ID"), reader("_IDTarea"), reader("Descripcion_Tarea"), reader("_IDDetalleTarea"), reader("Descripcion_Detalle_Tarea"), reader("Fecha"))
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

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        buscarTarea()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
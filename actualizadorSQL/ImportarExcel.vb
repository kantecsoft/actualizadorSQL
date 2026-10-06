Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Threading

Imports System.Data.SqlClient
Imports System.Windows.Forms
'Imports OfficeOpenXml
Imports ClosedXML.Excel
Imports System.Globalization
Public Class ImportarExcel

    Private Sub picBuscarArticulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picBuscarArticulo.Click

    End Sub
    'FUNCIONES Y PROCEDIMIENTOS
    Public Sub ImportarExcel()
        Try
            ''Declaracion de variables
            'Dim strSQLCon, strSQLExe
            'Dim enTran As Boolean
            'Dim rst As SqlClient.SqlDataReader
            'Dim conn As New SqlClient.SqlConnection
            'Dim openFileDialog As New OpenFileDialog()
            'openFileDialog.Filter = "Archivos de Excel|*.xls;*.xlsx"
            'openFileDialog.Title = "Seleccionar archivo Excel"

            'If openFileDialog.ShowDialog() = DialogResult.OK Then
            '    Dim filePath As String = openFileDialog.FileName

            '    ' Leer datos del archivo Excel
            '    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filePath & ";Extended Properties='Excel 12.0 Xml;HDR=YES';"
            '    Using connection As New OleDbConnection(connectionString)
            '        connection.Open()

            '        ' Obtener el nombre de la primera hoja
            '        Dim dtSheets As DataTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)
            '        Dim sheetName As String = dtSheets.Rows(0)("TABLE_NAME").ToString()

            '        Dim command As New OleDbCommand("SELECT * FROM [" & sheetName & "]", connection)
            '        Dim adapter As New OleDbDataAdapter(command)
            '        Dim dtExcel As New DataTable()
            '        adapter.Fill(dtExcel)

            '        ' Conexión a la base de datos
            '        conn.ConnectionString = GLOBAL_CONN
            '        conn.Open()
            '        Dim ban As Boolean = False
            '        Dim banElem As Boolean = False

            '        Dim conta As Integer = 1
            '        Dim conta2 As Integer = 0

            '        Dim horaCorrecta As Boolean = False
            '        Dim totalExtra As Boolean = False

            '        'Se detecta que oreja del TabControl esta activo
            '        Dim activeTab As String
            '        Select Case TabControl1.SelectedIndex
            '            Case 0
            '                '1er quincena
            '                activeTab = "1RA"
            '            Case 1
            '                '2da quincena
            '                activeTab = "2DA"
            '            Case 2
            '                'mensual
            '                activeTab = ""
            '            Case Else
            '                activeTab = ""
            '        End Select

            '        'Recorre todas las filas del excel
            '        For Each excelRow As DataRow In dtExcel.Rows
            '            conta = conta + 1
            '            Dim horaEntrada As String = excelRow("ENTRO").ToString
            '            If horaEntrada.Length > 5 Then
            '                'MsgBox(horaEntrada.Length)
            '                'MsgBox(DateTime.Parse(horaEntrada).ToString("HH:mm"))
            '                horaEntrada = DateTime.Parse(horaEntrada).ToString("HH:mm")
            '                'horaEntrada = horaEntrada.Substring(0, 5)
            '            End If

            '            Dim horaSalida As String = excelRow("SALIO").ToString
            '            If horaSalida.Length > 5 Then
            '                horaSalida = DateTime.Parse(horaSalida).ToString("HH:mm")
            '                'horaSalida = horaSalida.Substring(0, 5)
            '            End If
            '            'MsgBox(horaEntrada)
            '            ' MsgBox(horaSalida)

            '            Dim totDiaria As Double = Double.Parse(excelRow("TOTAL DIARIA").ToString)
            '            Dim totExtra As String = Double.Parse(excelRow("TOTAL EXTRA").ToString)

            '            Dim formatoHora As String = "HH:mm"
            '            'Dim formatoHora As String = "HH:mm:ss"
            '            'MsgBox("antes de cambiar")

            '            ' Verificar si la hora de entrada es menor a las 6:00
            '            'MsgBox(horaEntrada)
            '            'MsgBox(horaSalida)
            '            Dim horaEntradaMenor6 As DateTime = DateTime.ParseExact(horaEntrada, formatoHora, CultureInfo.InvariantCulture)
            '            Dim entrada As DateTime = DateTime.ParseExact(horaEntrada, formatoHora, CultureInfo.InvariantCulture)
            '            Dim salida As DateTime = DateTime.ParseExact(horaSalida, formatoHora, CultureInfo.InvariantCulture)



            '            'Dim horaEntradaMenor6 As DateTime = DateTime.ParseExact(TimeString, "HH:mm:ss", Nothing).ToString("HH:mm")
            '            'Dim entrada As DateTime = DateTime.ParseExact(TimeString, "HH:mm:ss", Nothing).ToString("HH:mm")
            '            'Dim salida As DateTime = DateTime.ParseExact(TimeString, "HH:mm:ss", Nothing).ToString("HH:mm")


            '            'Declara una variable con el formato 00:00
            '            Dim formato As String = "^(?:[0-2][0-9]):[0-5][0-9]$"
            '            'Dim formato As String = "^(?:[0-2][0-9]):[0-5][0-9]:[0-5][0-9]$"
            '            Dim regex As New System.Text.RegularExpressions.Regex(formato)

            '            'Controla si el formato de las variables horaEntrada y horaSalida son correctas ademas que la hora de entrada sea mayor a las 06:00
            '            If regex.IsMatch(horaEntrada).Equals(True) And regex.IsMatch(horaSalida).Equals(True) And esMadrugada(horaEntradaMenor6, salida) Then
            '                horaCorrecta = True
            '            Else
            '                horaCorrecta = False
            '                conta2 = conta
            '                Exit For
            '            End If
            '            'Controla si el total de horas extras es menor o igual a las horas trabajadas
            '            If totExtra <= totDiaria Then
            '                totalExtra = True
            '            Else
            '                totalExtra = False
            '                conta2 = conta
            '                Exit For
            '            End If
            '        Next

            '        'Controlamos que las banderas esten en true y recorremos nuevamente el excel para actualizacion
            '        If horaCorrecta.Equals(True) And totalExtra.Equals(True) Then

            '            For Each excelRow As DataRow In dtExcel.Rows

            '                Dim fechaSeleccionada As Date
            '                fechaSeleccionada = Calendario.SelectionStart
            '                Dim mesFormulario As Integer = Month(fechaSeleccionada)
            '                Dim anoFormulario As Integer = Year(fechaSeleccionada)

            '                Dim dia1 As DateTime
            '                Dim dia15 As DateTime
            '                dia1 = New DateTime(Calendario.SelectionStart.Year, Calendario.SelectionStart.Month, 1)
            '                dia15 = New DateTime(Calendario.SelectionStart.Year, Calendario.SelectionStart.Month, 15)
            '                Dim ano As Integer = Calendario.SelectionStart.Year
            '                Dim mes As Integer = Calendario.SelectionStart.Month
            '                Dim ultimoDia As DateTime = New DateTime(Calendario.SelectionStart.Year, Calendario.SelectionStart.Month, DateTime.DaysInMonth(Calendario.SelectionStart.Year, Calendario.SelectionStart.Month))
            '                'Si la oreja del tabControl esta activa en 1ra, pregunta si la fecha esta dentro la primer quincena luego
            '                'procede a actualizar
            '                Dim horaEntradaUpdate As String
            '                Dim horaSalidaUpdate As String
            '                If activeTab.Equals("1RA") Then
            '                    If (excelRow("FECHA") >= dia1 And excelRow("FECHA") <= dia15) Then
            '                        horaEntradaUpdate = excelRow("ENTRO").ToString
            '                        If horaEntradaUpdate.Length > 5 Then
            '                            horaEntradaUpdate = DateTime.Parse(horaEntradaUpdate).ToString("HH:mm") 'horaEntradaUpdate.Substring(0, 5)
            '                        End If
            '                        horaSalidaUpdate = excelRow("SALIO").ToString
            '                        If horaSalidaUpdate.Length > 5 Then
            '                            horaSalidaUpdate = DateTime.Parse(horaSalidaUpdate).ToString("HH:mm") 'horaSalidaUpdate.Substring(0, 5)
            '                        End If

            '                        Dim cmd As New SqlCommand("UPDATE [EXPOTEC_BALANZA].[dbo].[RRHH_DIAS] SET " & _
            '                                                "[Nro_Legajo] = @NroLegajo, " & _
            '                                                "[Apellido_Nombre] = @ApellidoNombre, " & _
            '                                                "[Sector] = @Sector, " & _
            '                                                "[Fecha] = @Fecha, " & _
            '                                               "[Quincena] = @Quincena, " & _
            '                                              "[Condicion] = @Condicion, " & _
            '                                              "[Hora_desde] = @HoraDesde, " & _
            '                                              "[Hora_hasta] = @HoraHasta, " & _
            '                                              "[Hora_corte] = @Hora_corte, " & _
            '                                              "[Horas_50] = @Horas_50, " & _
            '                                              "[Horas_100] = @Horas_100, " & _
            '                                              "[Total_Horas_Dia] =@Total_Horas_Dia " & _
            '                                               " WHERE " & _
            '                                                "[ID] = @ID", conn)
            '                        cmd.Parameters.AddWithValue("@NroLegajo", excelRow("LEGAJO"))
            '                        cmd.Parameters.AddWithValue("@ApellidoNombre", excelRow("APELLIDO_Y_NOMBRE"))
            '                        cmd.Parameters.AddWithValue("@Sector", excelRow("PLANTA"))
            '                        cmd.Parameters.AddWithValue("@Fecha", excelRow("FECHA"))
            '                        cmd.Parameters.AddWithValue("@Quincena", excelRow("PERIODO"))
            '                        cmd.Parameters.AddWithValue("@Condicion", excelRow("CONDICION"))
            '                        cmd.Parameters.AddWithValue("@HoraDesde", horaEntradaUpdate)
            '                        cmd.Parameters.AddWithValue("@HoraHasta", horaSalidaUpdate)
            '                        cmd.Parameters.AddWithValue("@Hora_corte", excelRow("HORA_CORTE").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@Horas_50", excelRow("EXTRAS 50%").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@Horas_100", excelRow("EXTRAS 100%").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@Total_Horas_Dia", excelRow("TOTAL DIARIA").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@ID", excelRow("ID"))
            '                        cmd.ExecuteNonQuery()

            '                    Else
            '                        banElem = True
            '                    End If
            '                End If
            '                'Si la oreja del tabControl esta activa en 2DA, pregunta si la fecha esta dentro la segunda quincena luego
            '                'procede a actualizar
            '                If activeTab.Equals("2DA") Then

            '                    If (excelRow("FECHA") > dia15 And excelRow("FECHA") <= ultimoDia) Then
            '                        horaEntradaUpdate = excelRow("ENTRO").ToString
            '                        If horaEntradaUpdate.Length > 5 Then
            '                            horaEntradaUpdate = DateTime.Parse(horaEntradaUpdate).ToString("HH:mm") 'horaEntradaUpdate.Substring(0, 5)
            '                        End If
            '                        horaSalidaUpdate = excelRow("SALIO").ToString
            '                        If horaSalidaUpdate.Length > 5 Then
            '                            horaSalidaUpdate = DateTime.Parse(horaSalidaUpdate).ToString("HH:mm") 'horaSalidaUpdate.Substring(0, 5)
            '                        End If

            '                        Dim cmd As New SqlCommand("UPDATE [EXPOTEC_BALANZA].[dbo].[RRHH_DIAS] SET " & _
            '                                                "[Nro_Legajo] = @NroLegajo, " & _
            '                                                "[Apellido_Nombre] = @ApellidoNombre, " & _
            '                                                "[Sector] = @Sector, " & _
            '                                                "[Fecha] = @Fecha, " & _
            '                                               "[Quincena] = @Quincena, " & _
            '                                              "[Condicion] = @Condicion, " & _
            '                                              "[Hora_desde] = @HoraDesde, " & _
            '                                              "[Hora_hasta] = @HoraHasta, " & _
            '                                              "[Hora_corte] = @Hora_corte, " & _
            '                                              "[Horas_50] = @Horas_50, " & _
            '                                              "[Horas_100] = @Horas_100, " & _
            '                                              "[Total_Horas_Dia] =@Total_Horas_Dia " & _
            '                                              " WHERE " & _
            '                                                "[ID] = @ID", conn)
            '                        cmd.Parameters.AddWithValue("@NroLegajo", excelRow("LEGAJO"))
            '                        cmd.Parameters.AddWithValue("@ApellidoNombre", excelRow("APELLIDO_Y_NOMBRE"))
            '                        cmd.Parameters.AddWithValue("@Sector", excelRow("PLANTA"))
            '                        cmd.Parameters.AddWithValue("@Fecha", excelRow("FECHA"))
            '                        cmd.Parameters.AddWithValue("@Quincena", excelRow("PERIODO"))
            '                        cmd.Parameters.AddWithValue("@Condicion", excelRow("CONDICION"))
            '                        cmd.Parameters.AddWithValue("@HoraDesde", horaEntradaUpdate)
            '                        cmd.Parameters.AddWithValue("@HoraHasta", horaSalidaUpdate)
            '                        cmd.Parameters.AddWithValue("@Hora_corte", excelRow("HORA_CORTE").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@Horas_50", excelRow("EXTRAS 50%").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@Horas_100", excelRow("EXTRAS 100%").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@Total_Horas_Dia", excelRow("TOTAL DIARIA").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@ID", excelRow("ID"))
            '                        cmd.ExecuteNonQuery()

            '                    Else
            '                        banElem = True
            '                    End If

            '                End If
            '                'Si la oreja del tabControl esta activa en Mes, pregunta si la fecha esta dentro del mes luego
            '                'procede a actualizar

            '                If activeTab.Equals("") Then
            '                    If (excelRow("FECHA") >= dia1 And excelRow("FECHA") <= ultimoDia) Then
            '                        horaEntradaUpdate = excelRow("ENTRO").ToString
            '                        If horaEntradaUpdate.Length > 5 Then
            '                            horaEntradaUpdate = DateTime.Parse(horaEntradaUpdate).ToString("HH:mm") 'horaEntradaUpdate.Substring(0, 5)
            '                        End If
            '                        horaSalidaUpdate = excelRow("SALIO").ToString
            '                        If horaSalidaUpdate.Length > 5 Then
            '                            horaSalidaUpdate = DateTime.Parse(horaSalidaUpdate).ToString("HH:mm") 'horaSalidaUpdate.Substring(0, 5)
            '                        End If

            '                        Dim cmd As New SqlCommand("UPDATE [EXPOTEC_BALANZA].[dbo].[RRHH_DIAS] SET " & _
            '                                                "[Nro_Legajo] = @NroLegajo, " & _
            '                                                "[Apellido_Nombre] = @ApellidoNombre, " & _
            '                                                "[Sector] = @Sector, " & _
            '                                                "[Fecha] = @Fecha, " & _
            '                                               "[Quincena] = @Quincena, " & _
            '                                              "[Condicion] = @Condicion, " & _
            '                                              "[Hora_desde] = @HoraDesde, " & _
            '                                              "[Hora_hasta] = @HoraHasta, " & _
            '                                              "[Hora_corte] = @Hora_corte, " & _
            '                                              "[Horas_50] = @Horas_50, " & _
            '                                              "[Horas_100] = @Horas_100, " & _
            '                                              "[Total_Horas_Dia] =@Total_Horas_Dia " & _
            '                                               " WHERE " & _
            '                                                "[ID] = @ID", conn)
            '                        cmd.Parameters.AddWithValue("@NroLegajo", excelRow("LEGAJO"))
            '                        cmd.Parameters.AddWithValue("@ApellidoNombre", excelRow("APELLIDO_Y_NOMBRE"))
            '                        cmd.Parameters.AddWithValue("@Sector", excelRow("PLANTA"))
            '                        cmd.Parameters.AddWithValue("@Fecha", excelRow("FECHA"))
            '                        cmd.Parameters.AddWithValue("@Quincena", excelRow("PERIODO"))
            '                        cmd.Parameters.AddWithValue("@Condicion", excelRow("CONDICION"))
            '                        cmd.Parameters.AddWithValue("@HoraDesde", horaEntradaUpdate)
            '                        cmd.Parameters.AddWithValue("@HoraHasta", horaSalidaUpdate)
            '                        cmd.Parameters.AddWithValue("@Hora_corte", excelRow("HORA_CORTE").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@Horas_50", excelRow("EXTRAS 50%").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@Horas_100", excelRow("EXTRAS 100%").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@Total_Horas_Dia", excelRow("TOTAL DIARIA").ToString.Replace(",", "."))
            '                        cmd.Parameters.AddWithValue("@ID", excelRow("ID"))
            '                        cmd.ExecuteNonQuery()

            '                    Else
            '                        banElem = True
            '                    End If

            '                End If

            '            Next
            '            If banElem.Equals(True) Then
            '                MsgBox("Existen registros que no pertenecen a este periodo", MsgBoxStyle.Information, "Information:")

            '            Else
            '                MsgBox("Datos actualizados correctamente", MsgBoxStyle.Information, "Informacion:")
            '            End If

            '            recargarDataGrid()
            '        Else
            '            MsgBox("Error en la fila " & conta2 & ": Verifique que: El horario de salida no sea anterior al horario de ingreso. El total de horas extras no supere el total de horas trabajadas. Que no existen horas de ingreso menores a 06:00 ", MsgBoxStyle.Critical, "Error:")

            '        End If
            '        If totalExtra.Equals(False) Then

            '        End If

            '    End Using
            'End If
        Catch ex As Exception
            MsgBox(ex.Message & " ")

        End Try

    End Sub

End Class
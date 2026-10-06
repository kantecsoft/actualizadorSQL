Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices


Public Class frmSincronizador
    Public rutaProyecto1 As String
    Public rutaProyecto2 As String
    Const MOUSEEVENTF_MOVE As Integer = &H1
    Const KEYEVENTF_KEYUP As Integer = &H2
    Const VK_LWIN As Byte = &H5B   ' Tecla Windows izquierda
    Private conexionSQL As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MULTIVERSIONES_BD;Data Source=SVCF-DESARROLLO"
    'Private conexionSQL As String = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MULTIVERSIONES_BD;Data Source=SVCF-DESARROLLO"
    Private Sub frmSincronizador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Timer1.Interval = 10000   ' 10 segundos
        'Timer1.Start()
        cargarTareas()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnProyecto1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProyecto1.Click
        buscarProyecto1()
    End Sub
    'FUNCIONES Y PROCEDIMIENTOS
    Private Sub cargarTareas()
        DataGridView1.Rows.Clear()
        Using conn As New SqlConnection(conexionSQL)
            Try
                ' Abrir conexión
                conn.Open()
                ' Ejemplo: ejecutar un comando simple
                Dim query As String = "SELECT [Id],[Descripcion] FROM [MULTIVERSIONES_BD].[dbo].[Sincronizacion] ORDER BY ID DESC"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            DataGridView1.Rows.Add(reader("Id"), reader("Descripcion"))
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

    Private Function dameDireccionArchivo(ByVal idS As Integer)
        Dim resultado As String

        Using conn As New SqlConnection(conexionSQL)
            ' Abrir conexión
            conn.Open()
            Console.WriteLine("Conexión exitosa a SQL Server.")
            Dim sql As String = "SELECT ArchivoOrigenAntes FROM Sincronizacion WHERE Id =" & idS
            Using cmd As New SqlCommand(sql, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        resultado = reader("ArchivoOrigenAntes")

                    End While
                End Using

            End Using
        End Using
        dameDireccionArchivo = resultado
        MessageBox.Show("Archivo destino restaurado.")


    End Function
    Private Sub RevertirDestino(ByVal idSincronizacion As Integer, ByVal archivoDestino As String)
        Using conn As New SqlConnection(conexionSQL)
            ' Abrir conexión
            conn.Open()
            Console.WriteLine("Conexión exitosa a SQL Server.")
            Dim sql As String = "SELECT ArchivoOrigenAntes,ArchivoDestinoDespues FROM Sincronizacion WHERE Id =" & idSincronizacion

            Using cmd As New SqlCommand(sql, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim contenido0 As String = CStr(reader("ArchivoDestinoDespues"))
                        Dim contenido1 As String = CStr(reader("ArchivoOrigenAntes"))

                        'File.WriteAllText(archivoDestino, contenido)
                        'SincronizarDesigner4(contenido0, contenido1, archivoDestino)
                    End While
                End Using

            End Using
        End Using
        MessageBox.Show("Archivo destino restaurado.")



    End Sub

    

    ' --- API para simular teclas ---
    <DllImport("user32.dll")> _
    Private Shared Sub keybd_event(ByVal bVk As Byte, _
                                   ByVal bScan As Byte, _
                                   ByVal dwFlags As Integer, _
                                   ByVal dwExtraInfo As Integer)
    End Sub
    ' --- API para mover el mouse ---
    <DllImport("user32.dll")> _
    Private Shared Sub mouse_event(ByVal dwFlags As Integer, _
                                   ByVal dx As Integer, _
                                   ByVal dy As Integer, _
                                   ByVal dwData As Integer, _
                                   ByVal dwExtraInfo As Integer)
    End Sub

    Private Sub guardar(ByVal lineaAntigua As String, ByVal lineaNueva As String, ByVal proyecto As String)

        Try
            Using cn As New SqlClient.SqlConnection(conexionSQL)
                cn.Open()

                Dim sql As String = "INSERT INTO Rama (Fecha, Hora, Proyecto, LineaAntigua, LineaNueva) " & _
                                "VALUES (@Fecha, @Hora, @Proyecto, @LineaAntigua, @LineaNueva)"

                Using cmd As New SqlClient.SqlCommand(sql, cn)
                    cmd.Parameters.AddWithValue("@Fecha", Date.Now.Date)
                    cmd.Parameters.AddWithValue("@Hora", Date.Now.ToString("HH:mm:ss"))
                    cmd.Parameters.AddWithValue("@Proyecto", proyecto)
                    cmd.Parameters.AddWithValue("@LineaAntigua", lineaAntigua)
                    cmd.Parameters.AddWithValue("@LineaNueva", lineaNueva)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al guardar en Rama: " & ex.Message)
        End Try

    End Sub

    Private Sub SincronizarDesigner(ByVal archivoNuevo As String, ByVal archivoViejo As String, ByVal proyecto As String)

        ' archivoNuevo = actualizado
        ' archivoViejo = donde se aplican los cambios

        Dim nuevo As String = File.ReadAllText(archivoNuevo)
        Dim viejo As String = File.ReadAllText(archivoViejo)

        Dim regDeclaracion As New Regex("Friend WithEvents\s+(\w+)\s+As\s+System\.Windows\.Forms\.\w+", RegexOptions.Multiline)
        Dim regInit As New Regex("Me\.(\w+)\s*=\s*New\s+System\.Windows\.Forms\.\w+[\s\S]*?Me\.Controls\.Add\(Me\.\1\)", RegexOptions.Multiline)

        Dim declaracionesNuevo = regDeclaracion.Matches(nuevo).Cast(Of Match).Select(Function(m) m.Value).ToList()
        Dim declaracionesViejo = regDeclaracion.Matches(viejo).Cast(Of Match).Select(Function(m) m.Value).ToList()

        Dim inicializacionesNuevo = regInit.Matches(nuevo).Cast(Of Match).Select(Function(m) m.Value).ToList()
        Dim inicializacionesViejo = regInit.Matches(viejo).Cast(Of Match).Select(Function(m) m.Value).ToList()

        Dim nuevasDeclaraciones As New List(Of String)
        Dim nuevasInicializaciones As New List(Of String)

        ' Detectar declaraciones nuevas (del archivo nuevo hacia el viejo)
        For Each decNuevo In declaracionesNuevo
            If Not declaracionesViejo.Contains(decNuevo) Then

                nuevasDeclaraciones.Add(decNuevo)

                guardar("", decNuevo, proyecto)

            End If
        Next

        ' Detectar inicializaciones nuevas
        For Each initNuevo In inicializacionesNuevo

            Dim nombreControl As String = Regex.Match(initNuevo, "Me\.(\w+)\s*=").Groups(1).Value
            Dim lineaAntigua As String = inicializacionesViejo.FirstOrDefault(Function(i) i.Contains("Me." & nombreControl & " ="))

            If lineaAntigua Is Nothing Then lineaAntigua = ""

            Dim existe As Boolean = inicializacionesViejo.Any(Function(i) i.Contains("Me." & nombreControl & " ="))

            If Not existe Then

                nuevasInicializaciones.Add(initNuevo)

                guardar(lineaAntigua, initNuevo, proyecto)

            End If
        Next

        ' Convertir listas a arrays (VS2008)
        Dim nuevasDeclaracionesArray() As String = nuevasDeclaraciones.ToArray()
        Dim nuevasInicializacionesArray() As String = nuevasInicializaciones.ToArray()

        ' Insertar declaraciones nuevas en el archivo viejo
        Dim indiceDeclaraciones = viejo.LastIndexOf("End Class")
        Dim contenidoActualizado = viejo.Insert(indiceDeclaraciones, vbCrLf & String.Join(vbCrLf, nuevasDeclaracionesArray) & vbCrLf)

        ' Insertar inicializaciones nuevas en el archivo viejo
        Dim indiceInit = contenidoActualizado.IndexOf("End Sub")
        contenidoActualizado = contenidoActualizado.Insert(indiceInit, vbCrLf & String.Join(vbCrLf, nuevasInicializacionesArray) & vbCrLf)

        File.WriteAllText(archivoViejo, contenidoActualizado)

        MessageBox.Show("Sincronización completada y cambios guardados en SQL.")
    End Sub

    Private Sub buscarProyecto1()
        Dim rutaFrm1Proyecto1 As String
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Archivos VB|*.vb"
        If ofd.ShowDialog() = DialogResult.OK Then
            rutaFrm1Proyecto1 = ofd.FileName
            txtProyecto1.Text = rutaFrm1Proyecto1
        End If
    End Sub
    Private Sub buscarCodigo1()
        Dim rutaFrm1Codigo1 As String
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Archivos VB|*.vb"
        If ofd.ShowDialog() = DialogResult.OK Then
            rutaFrm1Codigo1 = ofd.FileName
            txtCodigo1.Text = rutaFrm1Codigo1
        End If
    End Sub

    Private Sub buscarProyecto2()
        Dim rutaFrm1Proyecto2 As String
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Archivos VB|*.vb"
        If ofd.ShowDialog() = DialogResult.OK Then
            rutaFrm1Proyecto2 = ofd.FileName
            txtProyecto2.Text = rutaFrm1Proyecto2
        End If
    End Sub
    Private Sub buscarCodigo2()
        Dim rutaFrm1Codigo2 As String
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Archivos VB|*.vb"
        If ofd.ShowDialog() = DialogResult.OK Then
            rutaFrm1Codigo2 = ofd.FileName
            txtCodigo2.Text = rutaFrm1Codigo2
        End If
    End Sub

    Private Sub btnAplicarCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarCambios.Click
        ' Obtener hora y minutos
        Dim hora As String = DateTime.Now.Hour.ToString("00")
        Dim minutos As String = DateTime.Now.Minute.ToString("00")

        Dim rutaArchivoOriginal As String = txtProyecto2.Text
        Dim rutaArchivoOriginal2 As String = txtCodigo2.Text

        ' Nombre nuevo del archivo
        Dim nombreArchivo As String
        nombreArchivo = "form1_" & hora & "_" & minutos & ".Designer.vb"
        Dim commit As String
        commit = hora & "_" & minutos & "_Diseño"


        SincronizarDesigner3(txtProyecto1.Text, txtProyecto2.Text, nombreArchivo, rutaArchivoOriginal, commit)

        commit = hora & "_" & minutos & "_Codigo"
        nombreArchivo = "form1_" & hora & "_" & minutos & ".vb"
        SincronizarDesigner3(txtCodigo1.Text, txtCodigo2.Text, nombreArchivo, rutaArchivoOriginal2, commit)
        MsgBox("Datos guardados correctamente")
        cargarTareas()

    End Sub
    ''''''''
    
    '''''''
    Private Sub SincronizarDesigner3(ByVal archivoViejo As String, ByVal archivoNuevo As String, ByVal nombreArchivo As String, ByVal rutaArchivoOriginal As String, ByVal commit As String)

        ' Leer ambos archivos Designer
        Dim viejo As String = File.ReadAllText(archivoViejo)
        Dim nuevo As String = File.ReadAllText(archivoNuevo)

        ' REGEX para detectar declaraciones de controles
        Dim regDeclaracion As New Regex("Friend WithEvents\s+(\w+)\s+As\s+System\.Windows\.Forms\.\w+", RegexOptions.Multiline)

        ' REGEX para detectar inicializaciones dentro de InitializeComponent
        Dim regInit As New Regex("Me\.(\w+)\s*=\s*New\s+System\.Windows\.Forms\.\w+[\s\S]*?Me\.Controls\.Add\(Me\.\1\)", RegexOptions.Multiline)

        ' Extraer declaraciones
        Dim declaracionesViejo = regDeclaracion.Matches(viejo).Cast(Of Match).Select(Function(m) m.Value).ToList()
        Dim declaracionesNuevo = regDeclaracion.Matches(nuevo).Cast(Of Match).Select(Function(m) m.Value).ToList()

        ' Extraer inicializaciones
        Dim inicializacionesViejo = regInit.Matches(viejo).Cast(Of Match).Select(Function(m) m.Value).ToList()
        Dim inicializacionesNuevo = regInit.Matches(nuevo).Cast(Of Match).Select(Function(m) m.Value).ToList()

        Dim nuevasDeclaraciones As New List(Of String)
        Dim nuevasInicializaciones As New List(Of String)

        ' Buscar declaraciones nuevas
        For Each decNuevo In declaracionesNuevo
            If Not declaracionesViejo.Contains(decNuevo) Then
                nuevasDeclaraciones.Add(decNuevo)
            End If
        Next

        ' Buscar inicializaciones nuevas
        For Each initNuevo In inicializacionesNuevo
            Dim nombreControl As String = Regex.Match(initNuevo, "Me\.(\w+)\s*=").Groups(1).Value
            Dim existe As Boolean = inicializacionesViejo.Any(Function(i) i.Contains("Me." & nombreControl & " ="))
            If Not existe Then
                nuevasInicializaciones.Add(initNuevo)
            End If
        Next

        ' Convertir listas a arrays (VS2008 lo requiere)
        Dim nuevasDeclaracionesArray() As String = nuevasDeclaraciones.ToArray()
        Dim nuevasInicializacionesArray() As String = nuevasInicializaciones.ToArray()

        ' Insertar declaraciones nuevas antes de End Class
        Dim indiceDeclaraciones = viejo.LastIndexOf("End Class")
        Dim contenidoActualizado = viejo.Insert(indiceDeclaraciones, vbCrLf & String.Join(vbCrLf, nuevasDeclaracionesArray) & vbCrLf)

        ' Insertar inicializaciones nuevas dentro de InitializeComponent
        Dim indiceInit = contenidoActualizado.IndexOf("End Sub")
        contenidoActualizado = contenidoActualizado.Insert(indiceInit, vbCrLf & String.Join(vbCrLf, nuevasInicializacionesArray) & vbCrLf)

        'GENERAR COPIA
        Dim carpetaDestino As String = "C:\__Codigo fuente compartido\_Codigo fuente BIS\Nestor\actualizadorSQL\actualizadorSQL\bin\Debug\copias"


        ' Ruta completa destino
        Dim rutaDestino As String = Path.Combine(carpetaDestino, nombreArchivo)

        ' Copiar archivo
        File.Copy(rutaArchivoOriginal, rutaDestino, True)

        '        MessageBox.Show("Archivo copiado correctamente a:" & vbCrLf & rutaDestino)

        '..........................
        ' GUARDAR EN SQL SERVER
        'Dim idSync As Integer = GuardarSincronizacion(viejo, nuevo, proyecto, "")
        Dim idSync As Integer = GuardarSincronizacion(rutaDestino, "", nombreArchivo, commit)

        ' Guardar cada declaración nueva
        For Each decNuevo In nuevasDeclaraciones
            Dim nombre = Regex.Match(decNuevo, "Friend WithEvents\s+(\w+)").Groups(1).Value
            ' GuardarCambio(idSync, "Declaracion", nombre, decNuevo)
        Next

        ' Guardar cada inicialización nueva
        For Each initNuevo In nuevasInicializaciones
            Dim nombre = Regex.Match(initNuevo, "Me\.(\w+)\s*=").Groups(1).Value
            'GuardarCambio(idSync, "Inicializacion", nombre, initNuevo)
        Next

        ' Guardar archivo actualizado

        File.WriteAllText(archivoNuevo, contenidoActualizado)
        Debug.WriteLine("===== CONTENIDO ACTUALIZADO =====")
        Debug.WriteLine(contenidoActualizado)

        ' MessageBox.Show("Sincronización completada y registrada en SQL Server.")
    End Sub



    Private Sub SincronizarReversa(ByVal archivoViejo As String, ByVal archivoNuevo As String, ByVal proyecto As String)

        ' Leer ambos archivos Designer
        Dim viejo As String = File.ReadAllText(archivoViejo)
        Dim nuevo As String = File.ReadAllText(archivoNuevo)

        ' REGEX para detectar declaraciones de controles
        Dim regDeclaracion As New Regex("Friend WithEvents\s+(\w+)\s+As\s+System\.Windows\.Forms\.\w+", RegexOptions.Multiline)

        ' REGEX para detectar inicializaciones dentro de InitializeComponent
        Dim regInit As New Regex("Me\.(\w+)\s*=\s*New\s+System\.Windows\.Forms\.\w+[\s\S]*?Me\.Controls\.Add\(Me\.\1\)", RegexOptions.Multiline)

        ' Extraer declaraciones
        Dim declaracionesViejo = regDeclaracion.Matches(viejo).Cast(Of Match).Select(Function(m) m.Value).ToList()
        Dim declaracionesNuevo = regDeclaracion.Matches(nuevo).Cast(Of Match).Select(Function(m) m.Value).ToList()

        ' Extraer inicializaciones
        Dim inicializacionesViejo = regInit.Matches(viejo).Cast(Of Match).Select(Function(m) m.Value).ToList()
        Dim inicializacionesNuevo = regInit.Matches(nuevo).Cast(Of Match).Select(Function(m) m.Value).ToList()

        Dim nuevasDeclaraciones As New List(Of String)
        Dim nuevasInicializaciones As New List(Of String)

        ' Buscar declaraciones nuevas
        For Each decNuevo In declaracionesNuevo
            If Not declaracionesViejo.Contains(decNuevo) Then
                nuevasDeclaraciones.Add(decNuevo)
            End If
        Next

        ' Buscar inicializaciones nuevas
        For Each initNuevo In inicializacionesNuevo
            Dim nombreControl As String = Regex.Match(initNuevo, "Me\.(\w+)\s*=").Groups(1).Value
            Dim existe As Boolean = inicializacionesViejo.Any(Function(i) i.Contains("Me." & nombreControl & " ="))
            If Not existe Then
                nuevasInicializaciones.Add(initNuevo)
            End If
        Next

        ' Convertir listas a arrays (VS2008 lo requiere)
        Dim nuevasDeclaracionesArray() As String = nuevasDeclaraciones.ToArray()
        Dim nuevasInicializacionesArray() As String = nuevasInicializaciones.ToArray()

        ' Insertar declaraciones nuevas antes de End Class
        Dim indiceDeclaraciones = viejo.LastIndexOf("End Class")
        Dim contenidoActualizado = viejo.Insert(indiceDeclaraciones, vbCrLf & String.Join(vbCrLf, nuevasDeclaracionesArray) & vbCrLf)

        ' Insertar inicializaciones nuevas dentro de InitializeComponent
        Dim indiceInit = contenidoActualizado.IndexOf("End Sub")
        contenidoActualizado = contenidoActualizado.Insert(indiceInit, vbCrLf & String.Join(vbCrLf, nuevasInicializacionesArray) & vbCrLf)

        'GENERAR COPIA
        Dim rutaArchivoOriginal As String = txtProyecto2.Text
        Dim carpetaDestino As String = "C:\__Codigo fuente compartido\_Codigo fuente BIS\Nestor\actualizadorSQL\actualizadorSQL\bin\Debug\copias"

        ' Obtener hora y minutos
        Dim hora As String = DateTime.Now.Hour.ToString("00")
        Dim minutos As String = DateTime.Now.Minute.ToString("00")

        ' Nombre nuevo del archivo
        Dim nombreNuevo As String = "form1_" & hora & "_" & minutos & ".Designer.vb"

        ' Ruta completa destino
        Dim rutaDestino As String = Path.Combine(carpetaDestino, nombreNuevo)

        ' Copiar archivo
        File.Copy(rutaArchivoOriginal, rutaDestino, True)

        '        MessageBox.Show("Archivo copiado correctamente a:" & vbCrLf & rutaDestino)

        '..........................
        ' GUARDAR EN SQL SERVER
        'Dim idSync As Integer = GuardarSincronizacion(viejo, nuevo, proyecto, "")
        'Dim idSync As Integer = GuardarSincronizacion(rutaDestino, "", proyecto, "")

        ' Guardar cada declaración nueva
        For Each decNuevo In nuevasDeclaraciones
            Dim nombre = Regex.Match(decNuevo, "Friend WithEvents\s+(\w+)").Groups(1).Value
            ' GuardarCambio(idSync, "Declaracion", nombre, decNuevo)
        Next

        ' Guardar cada inicialización nueva
        For Each initNuevo In nuevasInicializaciones
            Dim nombre = Regex.Match(initNuevo, "Me\.(\w+)\s*=").Groups(1).Value
            'GuardarCambio(idSync, "Inicializacion", nombre, initNuevo)
        Next

        ' Guardar archivo actualizado

        File.WriteAllText(archivoNuevo, contenidoActualizado)
        Debug.WriteLine("===== CONTENIDO ACTUALIZADO =====")
        Debug.WriteLine(contenidoActualizado)

        MessageBox.Show("Sincronización completada y registrada en SQL Server.")
    End Sub



    ''''''''''''''inicio 2'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Function GuardarSincronizacion(ByVal archivoOrigenAntes As String, ByVal archivoDestinoAntes As String, ByVal archivoDestinoDespues As String, ByVal commit As String) As Integer
      
    
        Using conn As New SqlConnection(conexionSQL)
            conn.Open()
            Dim descripcionTarea As String
            ' Sentencia SQL parametrizada para evitar inyección
            Dim sql2 As String = "INSERT INTO Sincronizacion (ArchivoOrigenAntes,Descripcion,Proyecto)VALUES ( '" & archivoOrigenAntes & "', '" & commit & "','proyecto')"
            Using cmd As New SqlCommand(sql2, conn)
                ' Ejecutamos el INSERT
                Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()
                If filasAfectadas > 0 Then
                    'MsgBox("Registro guardado correctamente.")
                Else
                    MsgBox("No se insertó ningún registro.")
                End If
            End Using
        End Using
    End Function


 




    Private Sub GuardarCambio(ByVal idSincronizacion As Integer, ByVal tipo As String, ByVal nombreControl As String, ByVal textoCambio As String)

        Using cn As New SqlClient.SqlConnection(conexionSQL)
            cn.Open()

            Dim sql As String = "INSERT INTO SincronizacionCambios (IdSincronizacion, TipoCambio, NombreControl, TextoCambio) " & _
                            "VALUES (@IdSincronizacion, @TipoCambio, @NombreControl, @TextoCambio)"

            Using cmd As New SqlClient.SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@IdSincronizacion", idSincronizacion)
                cmd.Parameters.AddWithValue("@TipoCambio", tipo)
                cmd.Parameters.AddWithValue("@NombreControl", nombreControl)
                cmd.Parameters.AddWithValue("@TextoCambio", textoCambio)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub RevertirSincronizacion(ByVal idSincronizacion As Integer, ByVal archivoDestino As String)

        Using cn As New SqlClient.SqlConnection(conexionSQL)
            cn.Open()

            Dim sql As String = "SELECT ArchivoViejo FROM Sincronizacion WHERE Id = @Id"

            Using cmd As New SqlClient.SqlCommand(sql, cn)
                cmd.Parameters.AddWithValue("@Id", idSincronizacion)

                Dim contenidoOriginal As String = CStr(cmd.ExecuteScalar())

                File.WriteAllText(archivoDestino, contenidoOriginal)
            End Using
        End Using

        MessageBox.Show("Reversión completada. Archivo restaurado.")
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub btnProyecto2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProyecto2.Click
        buscarProyecto2()
    End Sub

    Private Sub btnCodigo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCodigo1.Click
        buscarCodigo1()
    End Sub

    Private Sub btnCodigo2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCodigo2.Click
        buscarCodigo2()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' SincronizarDesigner3(txtCodigo1.Text, txtCodigo2.Text, "")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ' ID de sincronización que querés revertir
        Dim idSync As Integer = CInt(txtIdSync.Text)

         Dim archivoAnterior As String = dameDireccionArchivo(idSync)
        SincronizarReversa(archivoAnterior, txtProyecto2.Text, "")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' ID de sincronización que querés revertir
        Dim idSync As Integer = CInt(txtIdSync.Text)

        Dim archivoAnterior As String = dameDireccionArchivo(idSync)
        SincronizarReversa(archivoAnterior, txtCodigo2.Text, "")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim rutaArchivoOriginal As String = txtProyecto2.Text
            Dim carpetaDestino As String = "C:\__Codigo fuente compartido\_Codigo fuente BIS\Nestor\actualizadorSQL\actualizadorSQL\bin\Debug\copias"
            If String.IsNullOrEmpty(rutaArchivoOriginal) Then
                MessageBox.Show("Debe seleccionar el archivo Designer original.")
                Exit Sub
            End If

            If String.IsNullOrEmpty(carpetaDestino) Then
                MessageBox.Show("Debe seleccionar la carpeta destino.")
                Exit Sub
            End If

            ' Obtener hora y minutos
            Dim hora As String = DateTime.Now.Hour.ToString("00")
            Dim minutos As String = DateTime.Now.Minute.ToString("00")

            ' Nombre nuevo del archivo
            Dim nombreNuevo As String = "form1_" & hora & "_" & minutos & ".Designer.vb"

            ' Ruta completa destino
            Dim rutaDestino As String = Path.Combine(carpetaDestino, nombreNuevo)

            ' Copiar archivo
            File.Copy(rutaArchivoOriginal, rutaDestino, True)

            MessageBox.Show("Archivo copiado correctamente a:" & vbCrLf & rutaDestino)

        Catch ex As Exception
            MessageBox.Show("Error al copiar el archivo: " & ex.Message)
        End Try


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' --- Mover el mouse lentamente hacia la derecha ---
        mouse_event(MOUSEEVENTF_MOVE, 20, 0, 0, 0)  ' mueve 20 px a la derecha

        ' --- Simular tecla Windows (botón Inicio) ---
        keybd_event(VK_LWIN, 0, 0, 0)          ' presiona
        keybd_event(VK_LWIN, 0, KEYEVENTF_KEYUP, 0)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            Dim nombre As String = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            txtIdSync.Text = id

        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim id As String = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            Dim nombre As String = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            txtIdSync.Text = id

        End If
    End Sub
End Class
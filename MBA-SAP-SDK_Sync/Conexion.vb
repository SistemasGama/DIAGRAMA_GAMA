Imports System.Data.SqlClient
Module Conexion
    Public cnDB As SqlClient.SqlConnection
    Public UsuarioSAP As String
    Public PasswordSAP As String
    Dim cmDB As SqlClient.SqlCommand
    Dim dsDAB As DataSet
    Dim oCompany As SAPbobsCOM.Company

    Public Sub ConectarSQLServer()
        cnDB = New SqlClient.SqlConnection
        cnDB.ConnectionString = "User ID=" & My.Settings.Usuario & ";Initial Catalog=" & My.Settings.DB & ";Data Source=" & My.Settings.Servidor & ";Password=" & My.Settings.Password & ""
        Try
            cnDB.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Desconectar()
        cnDB.Close()
    End Sub

    Public Function conectarSAP(ByVal Usuario As String, ByVal Password As String) As SAPbobsCOM.Company

        'Definir variables
        Dim lRetCode, ErrorCode As Long
        Dim ErrorMessage As String = ""

        'Iniciar objeto de la compañia
        oCompany = New SAPbobsCOM.Company

        'Definir datos de la coneccion
        oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2019 '//Tipo de BD
        oCompany.DbUserName = My.Settings.Usuario
        oCompany.DbPassword = My.Settings.Password  '//Contraseña usuario sa
        oCompany.Server = My.Settings.Servidor '//IP o servidor de SQL
        oCompany.CompanyDB = My.Settings.DB   '//BASE DE DATOS
        oCompany.UserName = Usuario
        oCompany.Password = Password  '//contraseña usuario manager
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English '//lenguaje de SQL, si esta en español usa SAPbobsCOM.BoSuppLangs.ln_Spanish
        oCompany.UseTrusted = False

        'Conectar a la base de SAP B1
        lRetCode = oCompany.Connect()

        'esta llamada verifica si no hubo error al conectar y guarda los valores de error en las variables pasadas.
        'al momento de realizar transacciones tambien verifica si no hubo algun error en el transactionNotification.
        Call oCompany.GetLastError(ErrorCode, ErrorMessage)
        If (lRetCode <> 0) Then
            MsgBox("Falló la conexión a SAP: " + Str(ErrorCode) + "," + ErrorMessage)
        End If

        Return oCompany

    End Function

    Public Function SelectResult(ByVal cadConsul As String) As DataTable
        Dim dtTabla As New DataTable
        Try
            ConectarSQLServer()
            cmDB = New SqlClient.SqlCommand(cadConsul, cnDB)
            Dim da As New SqlDataAdapter(cmDB)
            cmDB.CommandTimeout = 0
            da.Fill(dtTabla)
            desconectar()
        Catch
            desconectar()
            ' //MessageBox.Show(ex.Message)
        End Try
        Return dtTabla
    End Function

    Public Function TransactionResult(ByVal cadInsert As String) As Boolean

        Try
            ConectarSQLServer()
            cmDB = New SqlClient.SqlCommand(cadInsert, cnDB)
            cmDB.CommandTimeout = 0
            cmDB.ExecuteNonQuery()
            Desconectar()
            Return True
        Catch
            Desconectar()
            Return False
        End Try

    End Function

End Module

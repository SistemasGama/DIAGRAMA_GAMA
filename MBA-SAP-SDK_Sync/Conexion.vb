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
        Dim lRetCode, ErrorCode As Long
        Dim ErrorMessage As String = ""


        oCompany = New SAPbobsCOM.Company

        oCompany.DbServerType = SAPbobsCOM.BoDataServerTypes.dst_MSSQL2019
        oCompany.DbUserName = My.Settings.Usuario
        oCompany.DbPassword = My.Settings.Password
        oCompany.Server = My.Settings.Servidor
        oCompany.CompanyDB = My.Settings.DB
        oCompany.UserName = Usuario
        oCompany.Password = Password
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English
        oCompany.UseTrusted = False

        lRetCode = oCompany.Connect()

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
            Desconectar()
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

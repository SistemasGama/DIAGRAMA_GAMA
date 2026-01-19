Public Class OT7
    Private Sub Mensajes()
        ToolTip1.SetToolTip(txtNroPresup1, "Ingrese el número de presupuesto previamente creado en LITOPLAN.") 'jjfff'

    End Sub

    Private Sub OT7_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mensajes()
    End Sub

    Private Sub datos()
        Dim NroPresup As Integer = txtNroPresup.Text
        txtCodCLientee.Text = SelectResult($"select top 1 CardCode from [@LP_COTIZ] a inner join OCRD b ON a.Empresa = b.cardname where id = {NroPresup}").Rows(0).Item(0).ToString
        txtClientee.Text = SelectResult($"select top 1 Empresa from [@LP_COTIZ]  where id = {NroPresup}").Rows(0).Item(0).ToString
        txtTrabajo.Text = SelectResult($"select top 1 producto from [@LP_COTIZ]  where id = {NroPresup}").Rows(0).Item(0).ToString
        txtCodProducto.Text = SelectResult($"select top 1 b.ItemCode from [@LP_COTIZ] a INNER JOIN OITM b ON a.Referencia = b.ItemCode where id = {NroPresup}").Rows(0).Item(0).ToString
        txtProducto.Text = SelectResult($"select top 1 b.ItemName from [@LP_COTIZ] a INNER JOIN OITM b ON a.Referencia = b.ItemCode where id = {NroPresup}").Rows(0).Item(0).ToString

    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        datos()
        Dim codcliente As String = txtCodCLientee.Text
        txtVendedor.Text = SelectResult($"select top 1 SlpName from OSLP a inner join OCRD b on a.SlpCode = b.SlpCode where b.CardCode = '{codcliente}'").Rows(0).Item(0).ToString
    End Sub

    Private Sub DgPresupuestoGral_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgPresupuestoGral.CellEndEdit
        Try

            If e.ColumnIndex = DgPresupuestoGral.Columns("NroPresupuesto").Index Then

                Dim nroPto As String = DgPresupuestoGral.Rows(e.RowIndex).Cells("NroPresupuesto").Value?.ToString()

                If String.IsNullOrWhiteSpace(nroPto) Then Exit Sub

                Dim query As String =
                    " SELECT b.CardCode, b.CardName, c.ItemCode, c.ItemName
                     FROM [@LP_COTIZ] a INNER JOIN 
					 OCRD b ON a.Empresa = b.CardName INNER JOIN
					 OITM c ON c.itemcode = a.referencia
                     WHERE a.id = '" & nroPto & "'"

                Dim dt As DataTable = SelectResult(query)
                ''  Dim PtoGeneral As Integer = SelectResult("select max(isnull(DocEntry,0)) + 1 as Docentry from [@PRESUP_GENERAL_LP]").Rows(0).Item(0).ToString
                If dt.Rows.Count = 0 Then
                    MsgBox("No se encontró el punto ingresado.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                Dim rowDG = DgPresupuestoGral.Rows(e.RowIndex)

                ''    rowDG.Cells("NroGral").Value = PtoGeneral
                '' rowDG.Cells("PtoImpreso").Value = dt.Rows(0).Item("Fecha_presupuesto").ToString()
                rowDG.Cells("codCliente").Value = dt.Rows(0).Item("CardCode").ToString() ''2 
                rowDG.Cells("Cliente").Value = dt.Rows(0).Item("CardName").ToString() ''3
                rowDG.Cells("CodTrabajo").Value = dt.Rows(0).Item("itemcode").ToString() ''4
                rowDG.Cells("trabajo").Value = dt.Rows(0).Item("itemname").ToString()  ''5
            End If

        Catch ex As Exception
            MsgBox("Error al cargar datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub GuardarPtoGral()
        Try
            Dim query As String
            Dim resultado As String
            Dim docentry As Integer = SelectResult("select isnull(max(DocEntry),0)+1 from [@PRESUP_GENERAL_LP]").Rows(0).Item(0).ToString
            Dim query1 As String = "insert into [@PRESUP_GENERAL_LP] (docnum, docentry) values " &
                                              "('" & docentry & "', '" & docentry & "') "
            Dim resultado1 As String = TransactionResult(query1)


            For i As Integer = 0 To DgPresupuestoGral.Rows.Count - 1
                If DgPresupuestoGral.Rows(i).IsNewRow Then Continue For
                If String.IsNullOrEmpty(DgPresupuestoGral.Rows(i).Cells(0).Value?.ToString().Trim()) Then Continue For

                Dim Nropresupuesto As String = DgPresupuestoGral.Rows(i).Cells(1).Value
                Dim codcli As String = DgPresupuestoGral.Rows(i).Cells(2).Value
                Dim nomcli As String = DgPresupuestoGral.Rows(i).Cells(3).Value
                Dim codprod As String = DgPresupuestoGral.Rows(i).Cells(4).Value
                Dim nomprod As String = DgPresupuestoGral.Rows(i).Cells(5).Value

                query = "insert into [@PRESUP_GRAL_LP_DET] (docentry, LineId, u_nropresupuesto, U_Codcli, U_Nomcli, u_itemcode, u_itemname) " &
                        "values (" & docentry & "," & i & ",'" & Nropresupuesto & "','" & codcli & "','" & nomcli & "','" & codprod & "','" & nomprod & "')"

                resultado = TransactionResult(query)
                DgPresupuestoGral.DataSource = ""
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error al generar el presupuesto general. Favor comuniquese con el administrador de sistemas.")
        End Try
    End Sub

    Private Sub ActualizarPtoGral()
        Try
            Dim query As String
            Dim resultado As String

            For i As Integer = 0 To DgPresupuestoGral.Rows.Count - 1
                If DgPresupuestoGral.Rows(i).IsNewRow Then Continue For
                If String.IsNullOrEmpty(DgPresupuestoGral.Rows(i).Cells(0).Value?.ToString().Trim()) Then Continue For
                Dim ptogral As String = DgPresupuestoGral.Rows(i).Cells(0).Value
                Dim Nropresupuesto As String = DgPresupuestoGral.Rows(i).Cells(1).Value
                Dim codcli As String = DgPresupuestoGral.Rows(i).Cells(2).Value
                Dim nomcli As String = DgPresupuestoGral.Rows(i).Cells(3).Value
                Dim codprod As String = DgPresupuestoGral.Rows(i).Cells(4).Value
                Dim nomprod As String = DgPresupuestoGral.Rows(i).Cells(5).Value

                query = "update [@presup_gral_lp_det] set u_nropresupuesto = '" & Nropresupuesto & "', U_Codcli = '" & codcli & "', U_Nomcli = '" & nomcli & "', u_itemcode = '" & codprod & "', u_itemname = '" & nomprod & "' where docentry = '" & ptogral & "' and lineid = '" & i & "'"
                resultado = TransactionResult(query)
            Next
        Catch ex As Exception
            MsgBox("Ocurrio un error al actualizar el presupuesto general. Favor comuniquese con el administrador de sistemas.")
        End Try
    End Sub

    Private Sub getPtoGral()
        Try
            Dim query As String = "SELECT a.docnum as ptogral ,b.u_NroPresupuesto as pto, b.U_Codcli as codcli, b.U_Nomcli as cliente, b.U_itemcode as codprod, b.U_itemname as producto 
                     FROM [@PRESUP_GENERAL_LP] a INNER JOIN 
                     [@PRESUP_GRAL_LP_DET] b ON a.docentry = b.docentry 
                     WHERE a.docnum = " & txtNroPreGral.Text

            ''        Dim query As String = "SELECT a.docnum as General_pto, b.u_fechaLitoplan as LitoplanFecha,b.u_NroPresupuesto as Litoplan_pto,b.u_nro_pres_cal as NroCal , b.U_kilos_ot as ot_kls, b.u_cant_uni_caja as Cantidad,
            ''b.u_Imprimir_si as Impr_si,b.u_cot_caja as cu_gs, b.u_precio_total as Totalgs, b.u_ancho_caja as an, b.u_alto_caja as al, b.u_profundidad_caja as pr,
            ''b.u_codcli as cod_cliente,b.u_nomcli as nombre_cliente,a.u_itemcode as trabajo_nro, b.u_itemname as nombre_trabajo, b.u_fecha_impresion as Imprimio_fecha, 
            ''b.u_confirmar_si as Conf_si
            ''FROM [@PRESUP_GENERAL_LP] a INNER JOIN 
            ''[@PRESUP_GRAL_LP_DET] b ON a.docentry = b.docentry 
            ''WHERE a.docnum = " & txtNroPreGral.Text
            Dim dt As New DataTable
            dt = SelectResult(query)

            DgPresupuestoGral.Rows.Clear()

            For i As Integer = 0 To dt.Rows.Count - 1
                DgPresupuestoGral.Rows.Add()
                DgPresupuestoGral.Rows(i).Cells(0).Value = dt.Rows(i).Item("ptogral").ToString
                DgPresupuestoGral.Rows(i).Cells(1).Value = dt.Rows(i).Item("pto").ToString
                DgPresupuestoGral.Rows(i).Cells(2).Value = dt.Rows(i).Item("codcli").ToString
                DgPresupuestoGral.Rows(i).Cells(3).Value = dt.Rows(i).Item("cliente").ToString
                DgPresupuestoGral.Rows(i).Cells(4).Value = dt.Rows(i).Item("codprod").ToString
                DgPresupuestoGral.Rows(i).Cells(5).Value = dt.Rows(i).Item("producto").ToString
            Next
        Catch ex As Exception
            MsgBox("Error al cargar datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnBuscarPtoGral_Click(sender As Object, e As EventArgs) Handles btnBuscarPtoGral.Click
        getPtoGral()
    End Sub
End Class
Public Class Form1

    Private Sub btnTestOracle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestOracle.Click
        Try
            TestOracle()
                Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub

    Private Sub TestOracle()
        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        rvConn.Open()
        rvConn.Close()
        MessageBox.Show("Connection Works OK")
    End Sub

    Function CreateConnection() As System.Data.OracleClient.OracleConnection
        Dim rvConn As New System.Data.OracleClient.OracleConnection
        rvConn.ConnectionString = GetConnectionString()
        Return rvConn
    End Function

    Function GetConnectionString() As String
        Dim vConnStr As String
        vConnStr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)"
        vConnStr = vConnStr & "(HOST=ictoraclesvm1.ict.swin.edu.au)(PORT=1521))"
        vConnStr = vConnStr & "(CONNECT_DATA=(SERVICE_NAME=dms.ict.swin.edu.au)));"
        vConnStr = vConnStr & "User Id=S1784765;"
        vConnStr = vConnStr & "Password=200385;"
        Return vConnStr
    End Function

    Private Sub btnListAllSKUs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListAllSKUs.Click
        DisplayAllSKUs()
    End Sub

    Private Sub DisplayAllSKUs()
        'This code calls a stored procedure with 0 params and no return value
        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strAllSKUs As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2ListAllSkus"
        rvCmd.CommandType = CommandType.StoredProcedure
        Dim rvp As System.Data.OracleClient.OracleParameter
        '---
        'Note the first param of is CMD must be a ReturnValue parameter as vbupdrow is a FUNCTION
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pReturnValue" 'The name of this parameter can be anything you like
        rvp.DbType = DbType.String 'The data type here
        rvp.Size = 2000
        rvp.Direction = ParameterDirection.ReturnValue
        rvConn.Open()
        Try
            rvCmd.ExecuteNonQuery()
            strAllSKUs = rvCmd.Parameters("pReturnValue").Value.ToString
            outbox.Text = outbox.Text & vbCrLf & strAllSKUs
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnListAllLOCs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListAllLOCs.Click
        DisplayAllLocs()
    End Sub

    Private Sub DisplayAllLocs()
        'This code calls a stored procedure with 0 params and no return value
        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strAllLocs As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2ListALLLocs"
        rvCmd.CommandType = CommandType.StoredProcedure
        Dim rvp As System.Data.OracleClient.OracleParameter
        '---
        'Note the first param of is CMD must be a ReturnValue parameter as vbupdrow is a FUNCTION
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pReturnValue" 'The name of this parameter can be anything you like
        rvp.DbType = DbType.String 'The data type here
        rvp.Size = 2000
        rvp.Direction = ParameterDirection.ReturnValue
        rvConn.Open()
        Try
            rvCmd.ExecuteNonQuery()
            strAllLocs = rvCmd.Parameters("pReturnValue").Value.ToString
            outbox.Text = outbox.Text & vbCrLf & strAllLocs
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnListAllBoxes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListAllBoxes.Click
        DisplayAllBoxes()
    End Sub

    Private Sub DisplayAllBoxes()
        'This code calls a stored procedure with 0 params and no return value
        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strAllBoxes As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2ListALLBOXES"
        rvCmd.CommandType = CommandType.StoredProcedure
        Dim rvp As System.Data.OracleClient.OracleParameter
        '---
        'Note the first param of is CMD must be a ReturnValue parameter as vbupdrow is a FUNCTION
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pReturnValue" 'The name of this parameter can be anything you like
        rvp.DbType = DbType.String 'The data type here
        rvp.Size = 2000
        rvp.Direction = ParameterDirection.ReturnValue
        rvConn.Open()
        Try
            rvCmd.ExecuteNonQuery()
            strAllBoxes = rvCmd.Parameters("pReturnValue").Value.ToString
            outbox.Text = outbox.Text & vbCrLf & strAllBoxes
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnListAllCounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListAllCounts.Click
        CallCounts()
    End Sub

    Private Sub CallCounts()
        DisplayAllCounts("A2SumSkuQty")
        DisplayAllCounts("A2SumLocQty")
        DisplayAllCounts("A2CountBoxes")
    End Sub

    Private Sub DisplayAllCounts(ByVal SP_Name As String)
        'This code calls a stored procedure with 0 params and no return value
        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strQty As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = SP_Name
        rvCmd.CommandType = CommandType.StoredProcedure
        Dim rvp As System.Data.OracleClient.OracleParameter
        '---
        'Note the first param of is CMD must be a ReturnValue parameter as vbupdrow is a FUNCTION
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pReturnValue" 'The name of this parameter can be anything you like
        rvp.DbType = DbType.Int32 'The data type here
        'rvp.Size = 2000
        rvp.Direction = ParameterDirection.ReturnValue
        rvConn.Open()
        Try
            rvCmd.ExecuteNonQuery()
            strQty = rvCmd.Parameters("pReturnValue").Value.ToString
            outbox.Text = outbox.Text & vbCrLf & strQty
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnListOneLOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListOneLOC.Click
        DisplayOneLoc()
    End Sub

    Private Sub DisplayOneLoc()
        'This code calls a stored procedure with 0 params and no return value
        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strQty As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2ListOneLoc"
        rvCmd.CommandType = CommandType.StoredProcedure
        Dim rvp As System.Data.OracleClient.OracleParameter
        '---
        'Note the first param of is CMD must be a ReturnValue parameter as vbupdrow is a FUNCTION
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pReturnValue" 'The name of this parameter can be anything you like
        rvp.DbType = DbType.String 'The data type here
        rvp.Size = 2000
        rvp.Direction = ParameterDirection.ReturnValue
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "plocid"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Direction = ParameterDirection.Input
        rvp.Value = Val(InputBox("Enter Location ID:"))
        rvConn.Open()
        Try
            rvCmd.ExecuteNonQuery()
            strQty = rvCmd.Parameters("pReturnValue").Value.ToString
            outbox.Text = outbox.Text & vbCrLf & strQty
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnClearOutBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearOutBox.Click
        ClearTextbox()
    End Sub

    Private Sub ClearTextbox()
        outbox.Clear()
    End Sub

    Private Sub btnAddSKU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSKU.Click
        AddSKU()
    End Sub

    Private Sub AddSKU()

        Dim vSKUID As Integer
        Dim vSKUName As String

        vSKUID = InputBox("Enter SKU ID")
        vSKUName = InputBox("Enter SKU Name")

        'This code calls a stored procedure with 0 params and no return value

        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strQty As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2AddSku"
        rvCmd.CommandType = CommandType.StoredProcedure

        Dim rvp As System.Data.OracleClient.OracleParameter
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pskuid"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vSKUID
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pskuname"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.String
        rvp.Size = 100
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vSKUName
        Dim transaction As OracleClient.OracleTransaction
        rvConn.Open()
        transaction = rvConn.BeginTransaction()
        rvCmd.Transaction = transaction
        Try

            strQty = rvCmd.ExecuteNonQuery()
            outbox.Text = outbox.Text & vbCrLf & " 1 SKU added "
            transaction.Commit()
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
            transaction.Rollback()
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnAddLOC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddLOC.Click
        AddLoc()
    End Sub

    Private Sub AddLoc()
        Dim vLOCID As Integer
        Dim vLOCName As String

        vLOCID = InputBox("Enter LOC ID")
        vLOCName = InputBox("Enter LOC Name")

        'This code calls a stored procedure with 0 params and no return value
        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strQty As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2AddLoc"
        rvCmd.CommandType = CommandType.StoredProcedure
        Dim rvp As System.Data.OracleClient.OracleParameter
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "plocid"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vLOCID
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "plocname"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.String
        rvp.Size = 100
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vLOCName
        Dim transaction As OracleClient.OracleTransaction
        rvConn.Open()
        ' Start a local transaction
        transaction = rvConn.BeginTransaction()
        rvCmd.Transaction = transaction

        Try
            strQty = rvCmd.ExecuteNonQuery()
            outbox.Text = outbox.Text & vbCrLf & " 1 LOC added "
            transaction.Commit()
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
            transaction.Rollback()
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnAddBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBox.Click
        AddBox()
    End Sub

    Private Sub AddBox()
        Dim vSKUID As Integer
        Dim vLOCID As Integer

        vSKUID = InputBox("Enter SKU ID")
        vLOCID = InputBox("Enter LOC ID")

        'This code calls a stored procedure with 0 params and no return value
        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strQty As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2AddBox"
        rvCmd.CommandType = CommandType.StoredProcedure
        Dim rvp As System.Data.OracleClient.OracleParameter
        '---
        'Note the first param of is CMD must be a ReturnValue parameter as vbupdrow is a FUNCTION
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pReturnValue" 'The name of this parameter can be anything you like
        rvp.DbType = DbType.Int32 'The data type here
        'rvp.Size = 2000
        rvp.Direction = ParameterDirection.ReturnValue
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pskuid"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vSKUID
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "plocid"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Size = 100
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vLOCID
        Dim transaction As OracleClient.OracleTransaction
        rvConn.Open()
        ' Start a local transaction
        transaction = rvConn.BeginTransaction()
        rvCmd.Transaction = transaction

        Try
            strQty = rvCmd.ExecuteNonQuery()
            strQty = rvCmd.Parameters("pReturnValue").Value.ToString
            outbox.Text = outbox.Text & vbCrLf & "BOX ID " & strQty & " added "
            transaction.Commit()
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
            transaction.Rollback()
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnResetTables_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResetTables.Click
        ResetTables()
    End Sub

    Private Sub ResetTables()
        'This code calls a stored procedure with 0 params and no return value
        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strQty As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2Reset"
        rvCmd.CommandType = CommandType.StoredProcedure
        Dim transaction As OracleClient.OracleTransaction
        rvConn.Open()
        transaction = rvConn.BeginTransaction()
        rvCmd.Transaction = transaction

        Try
            strQty = rvCmd.ExecuteNonQuery()
            outbox.Text = outbox.Text & vbCrLf & "All the tables are reset"
            transaction.Commit()
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vErrStr
            transaction.Rollback()
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnSetMaxQuantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetMaxQuantity.Click
        SetMaxQuantity()
    End Sub

    Private Sub SetMaxQuantity()
        Dim vLocID As Integer
        Dim vMaxQty As Integer

        vLocID = InputBox("Enter LOC ID")
        vMaxQty = InputBox("Enter Maximum Quantity")

        'This code calls a stored procedure with 0 params and no return value

        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strQty As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2SetMaxQty"
        rvCmd.CommandType = CommandType.StoredProcedure

        Dim rvp As System.Data.OracleClient.OracleParameter
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "plocid"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vLocID
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pqty"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vMaxQty
        Dim transaction As OracleClient.OracleTransaction
        rvConn.Open()
        transaction = rvConn.BeginTransaction()
        rvCmd.Transaction = transaction
        Try

            strQty = rvCmd.ExecuteNonQuery()
            outbox.Text = outbox.Text & vbCrLf & " Maximum quantity " & vMaxQty & " set for LOC ID " & vLocID
            transaction.Commit()
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
            transaction.Rollback()
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnMoveBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveBox.Click
        MoveBox()
    End Sub

    Private Sub MoveBox()
        Dim vBoxID As Integer
        Dim vToLocID As Integer

        vBoxID = InputBox("Enter BOX ID")
        vToLocID = InputBox("Enter The destination Location ID")

        'This code calls a stored procedure with 0 params and no return value

        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strQty As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2MoveBox"
        rvCmd.CommandType = CommandType.StoredProcedure

        Dim rvp As System.Data.OracleClient.OracleParameter
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pboxid"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vBoxID
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pToLocId"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vToLocID
        Dim transaction As OracleClient.OracleTransaction
        rvConn.Open()
        transaction = rvConn.BeginTransaction()
        rvCmd.Transaction = transaction
        Try

            strQty = rvCmd.ExecuteNonQuery()
            outbox.Text = outbox.Text & vbCrLf & " Box id " & vBoxID & " moved to destination LOC ID " & vToLocID
            transaction.Commit()
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
            transaction.Rollback()
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnDeleteBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteBox.Click
        DeleteBox()
    End Sub

    Private Sub DeleteBox()
        Dim vBoxID As Integer

        vBoxID = InputBox("Enter BOX ID to be deleted")

        'This code calls a stored procedure with 0 params and no return value

        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strQty As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2DeleteBox"
        rvCmd.CommandType = CommandType.StoredProcedure

        Dim rvp As System.Data.OracleClient.OracleParameter
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pboxid"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vBoxID
        Dim transaction As OracleClient.OracleTransaction
        rvConn.Open()
        transaction = rvConn.BeginTransaction()
        rvCmd.Transaction = transaction
        Try

            strQty = rvCmd.ExecuteNonQuery()
            outbox.Text = outbox.Text & vbCrLf & " Box id " & vBoxID & " deleted successfully "
            transaction.Commit()
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
            transaction.Rollback()
        Finally
            rvConn.Close()
        End Try
    End Sub

    Private Sub btnDeleteSKU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteSKU.Click
        DeleteSKU()
    End Sub
    Private Sub DeleteSKU()
        Dim vSKUID As Integer

        vSKUID = InputBox("Enter SKU ID to be deleted")

        'This code calls a stored procedure with 0 params and no return value

        Dim rvConn As System.Data.OracleClient.OracleConnection
        rvConn = CreateConnection()
        Dim rvCmd As New System.Data.OracleClient.OracleCommand
        Dim strQty As String
        rvCmd.Connection = rvConn
        rvCmd.CommandText = "A2DeleteSKU"
        rvCmd.CommandType = CommandType.StoredProcedure

        Dim rvp As System.Data.OracleClient.OracleParameter
        rvp = New System.Data.OracleClient.OracleParameter
        rvCmd.Parameters.Add(rvp)
        rvp.ParameterName = "pskuid"
        'Note the second param of the stored proc named vbupdrow MUST be "pid"
        rvp.DbType = DbType.Int32
        rvp.Direction = ParameterDirection.Input
        rvp.Value = vSKUID
        Dim transaction As OracleClient.OracleTransaction
        rvConn.Open()
        transaction = rvConn.BeginTransaction()
        rvCmd.Transaction = transaction
        Try

            strQty = rvCmd.ExecuteNonQuery()
            outbox.Text = outbox.Text & vbCrLf & " SKU id " & vSKUID & " deleted successfully "
            transaction.Commit()
        Catch ex As Exception
            Dim vErrStr As String
            vErrStr = ex.Message
            outbox.Text = outbox.Text & vbCrLf & vErrStr
            transaction.Rollback()
        Finally
            rvConn.Close()
        End Try
    End Sub
End Class

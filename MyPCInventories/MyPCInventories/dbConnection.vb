Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography


Public Class dbConnection
    Dim connString As String = "Server=127.0.0.1;Database=pcinvent;Uid=root;Pwd=;"
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand

    Public Shared username As String

    Private Sub closes()
        cmd.Dispose()
        cmd = Nothing

        conn.Close()
        conn = Nothing
    End Sub

    Public Function logins(ByVal name As String, ByVal word As String)

        conn = New MySqlConnection
        conn.ConnectionString = connString

        Try

            Dim hashings = SHA256.Create()
            Dim calcs = name + word

            Dim mydata(calcs.Length) As Byte
            'convert string to byte
            For i = 0 To calcs.Length - 1
                mydata(i) = AscW(calcs(i))
            Next

            Dim resStrings As String = ""
            'hash data(in byte) that has been prepared
            Dim ress = hashings.ComputeHash(mydata)

            'return to string again
            For i = 0 To ress.Length - 1
                resStrings = resStrings + Hex(ress(i))
            Next

            Dim q = "SELECT * FROM staffpuspel WHERE staffname LIKE '" + name + "' AND staffpass LIKE '" + resStrings + "'"
            Debug.Print(q)

            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = q
            End With

            conn.Open()

            Dim sqlread As MySqlDataReader = cmd.ExecuteReader()
            Dim count = 0
            If sqlread.HasRows Then
                sqlread.Read()
                username = sqlread("names")
                count = 1
            End If

            If sqlread.IsClosed = False Then
                sqlread.Close()
            End If

            If count = 1 Then
                closes()

                Return True
            Else : Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Function checkStaff(ByVal users As String) As Boolean
        conn = New MySqlConnection
        conn.ConnectionString = connString

        Try

            Dim q = "SELECT staffname FROM `staffpuspel` WHERE staffname LIKE '" + users + "'"
            Debug.Print(q)
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = q
            End With

            conn.Open()
            Dim sqlread As MySqlDataReader = cmd.ExecuteReader

            cmd.Dispose()
            cmd = Nothing
            conn.Close()

            If sqlread.HasRows Then
                sqlread.Close()
                sqlread.Dispose()
                sqlread = Nothing

                Return False
            Else
                sqlread.Close()
                sqlread.Dispose()
                sqlread = Nothing

                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

        Return False
    End Function

    Public Function getStaff(ByVal users As String) As List(Of String)
        Dim res As New List(Of String)

        conn = New MySqlConnection
        conn.ConnectionString = connString

        Dim q = "SELECT * FROM `staffpuspel` WHERE staffname LIKE @name"

        cmd = New MySqlCommand
        With cmd
            .Connection = conn
            .CommandText = q
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@name", users)
        End With
        conn.Open()
        Dim sqlreaders = cmd.ExecuteReader()

        If sqlreaders.HasRows Then
            While sqlreaders.Read
                res.Add(sqlreaders("names"))
                res.Add(sqlreaders("staffname"))
            End While
        End If

        Return res
    End Function

    Public Function addStaff(ByVal name As String, ByVal usernames As String, ByVal pass As String)
        conn = New MySqlConnection
        conn.ConnectionString = connString

        Dim calcs = usernames + pass

        Dim hashings = SHA256.Create()

        Dim mydata(calcs.Length) As Byte
        'convert string to byte
        For i = 0 To calcs.Length - 1
            mydata(i) = AscW(calcs(i))
        Next

        Dim resStrings As String = ""
        'hash data(in byte) that has been prepared
        Dim ress = hashings.ComputeHash(mydata)

        'return to string again
        For i = 0 To ress.Length - 1
            resStrings = resStrings + Hex(ress(i))
        Next
        Dim q = "INSERT INTO `staffpuspel`(`id`, `names`, `staffname`, `staffpass`) VALUES ('','" + name + "','" + usernames + "','" + resStrings + "')"
        Debug.Print(q)

        Try
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = q
            End With

            conn.Open()


            If cmd.ExecuteNonQuery() Then
                closes()
                Return True
            Else : Return False
            End If
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Function editStaff(ByVal name As String, ByVal usernames As String, ByVal pass As String) As Boolean
        conn = New MySqlConnection
        conn.ConnectionString = connString

        Dim calcs = usernames + pass

        Dim hashings = SHA256.Create()

        Dim mydata(calcs.Length) As Byte
        'convert string to byte
        For i = 0 To calcs.Length - 1
            mydata(i) = AscW(calcs(i))
        Next

        Dim resStrings As String = ""
        'hash data(in byte) that has been prepared
        Dim ress = hashings.ComputeHash(mydata)

        'return to string again
        For i = 0 To ress.Length - 1
            resStrings = resStrings + Hex(ress(i))
        Next

        Try
            Dim q = "UPDATE `staffpuspel` SET `names`= '" + name.ToString + "',`staffpass`= '" + resStrings.ToString + "' WHERE `staffname` LIKE '" + usernames + "'"
            Debug.Print(q)
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = q
            End With
            conn.Open()
            Dim row = CInt(cmd.ExecuteNonQuery())

            If row > 0 Then

                cmd.Dispose()
                cmd = Nothing
                conn.Close()

                Return True
            End If

        Catch ex As Exception
            Return False
        End Try

        cmd.Dispose()
        cmd = Nothing
        conn.Close()

        Return False
    End Function

    Public Function hapusStaff(ByVal usernames As String) As Boolean
        conn = New MySqlConnection
        conn.ConnectionString = connString

        Dim q = "DELETE FROM `staffpuspel` WHERE staffname LIKE '" + usernames + "'"

        cmd = New MySqlCommand
        With cmd
            .Connection = conn
            .CommandText = q
        End With

        conn.Open()
        cmd.ExecuteNonQuery()

        cmd.Dispose()
        cmd = Nothing
        conn.Close()

        Return True
    End Function

    Public Function getRooms() As List(Of String)
        Dim returns As New List(Of String)

        conn = New MySqlConnection
        conn.ConnectionString = connString

        Dim q = "SELECT * FROM `chamber` WHERE 1 ORDER BY ID"
        Debug.Print(q)

        Try
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = q
            End With

            conn.Open()

            Dim sqlreaders As MySqlDataReader = cmd.ExecuteReader

            If sqlreaders.HasRows Then
                While sqlreaders.Read
                    'Debug.Print(sqlreaders("namechamber").ToString)
                    returns.Add(sqlreaders("namechamber").ToString)
                End While

            End If
            Return returns
        Catch ex As Exception
            Debug.Print("failed: " + ex.Message)
        End Try
        Return returns

    End Function

    Public Function addRoom(ByVal arrsPC As List(Of String), ByVal name As String) As Boolean
        conn = New MySqlConnection
        conn.ConnectionString = connString

        Dim q = "INSERT INTO `chamber`(`id`, `namechamber`) VALUES ('','" + name + "'); SELECT LAST_INSERT_ID();"
        Debug.Print(q)

        Try
            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = q
            End With

            conn.Open()

            Dim lastID = CInt(cmd.ExecuteScalar())

            If conn.State = 1 Then
                cmd.Dispose()
                conn.Close()
            End If

            If addListPCs(arrsPC, lastID) = True Then
                Return True
            Else : Return False
            End If

        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Function addListPCs(ByVal arrsPC As List(Of String), ByVal rooms As Integer) As Boolean
        conn = New MySqlConnection
        conn.ConnectionString = connString
        Try
            For Each item In arrsPC
                Dim q = "INSERT INTO `pcs`(`id`, `proc`, `hdd`, `ram`, `vga`, `os`, `owner`, `room`) VALUES ('', " + item + ", '" + rooms.ToString + "')"
                Debug.Print(q)

                cmd = New MySqlCommand
                With cmd
                    .Connection = conn
                    .CommandText = q
                End With

                conn.Open()
                cmd.ExecuteNonQuery()

                cmd.Dispose()
                cmd = Nothing
                conn.Close()
            Next

            Return True
        Catch ex As Exception
            Return False
        End Try

        Return False
    End Function

    Public Sub getPCS(ByRef dgv As DataGridView, ByVal idx As Integer)
        conn = New MySqlConnection
        conn.ConnectionString = connString

        Try
            Dim q = "SELECT * FROM pcs WHERE room = '" + idx.ToString + " ORDER BY owner'"

            cmd = New MySqlCommand
            With cmd
                .Connection = conn
                .CommandText = q
            End With

            conn.Open()
            Dim sqlreaders As MySqlDataReader = cmd.ExecuteReader()

            dgv.Rows.Clear()

            If sqlreaders.HasRows Then
                While sqlreaders.Read
                    dgv.Rows.Add()
                    dgv.Item(0, dgv.Rows.Count - 1).Value = dgv.Rows.Count

                    dgv.Item(2, dgv.Rows.Count - 1).Value = sqlreaders("proc")
                    dgv.Item(3, dgv.Rows.Count - 1).Value = sqlreaders("hdd")
                    dgv.Item(4, dgv.Rows.Count - 1).Value = sqlreaders("ram")
                    dgv.Item(5, dgv.Rows.Count - 1).Value = sqlreaders("vga")
                    dgv.Item(6, dgv.Rows.Count - 1).Value = sqlreaders("os")
                    dgv.Item(1, dgv.Rows.Count - 1).Value = sqlreaders("owner")
                End While
            End If
            ' refresh numbering
            dgv.Sort(dgv.Columns.Item("DataGridViewTextBoxColumn2"), System.ComponentModel.ListSortDirection.Ascending)
            For i = 0 To dgv.RowCount - 1
                dgv.Item(0, i).Value = i + 1
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Function delRow(ByRef dgv As DataGridView) As Boolean

        conn = New MySqlConnection
        conn.ConnectionString = connString

        For i = 0 To dgv.SelectedRows.Count - 1
            Dim q = "DELETE FROM pcs WHERE owner LIKE '" + dgv.SelectedRows(i).Cells("DataGridViewTextBoxColumn2").Value + "'"
            cmd = New MySqlCommand

            With cmd
                .Connection = conn
                .CommandText = q
            End With
            conn.Open()
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            cmd = Nothing
            conn.Close()

            dgv.Rows.RemoveAt(dgv.SelectedRows(0).Index)
        Next

        conn.Close()
        conn.Dispose()
        conn = Nothing

        ' refresh numbering
        dgv.Sort(dgv.Columns.Item("DataGridViewTextBoxColumn2"), System.ComponentModel.ListSortDirection.Ascending)
        For i = 0 To dgv.RowCount - 1
            dgv.Item(0, i).Value = i + 1
        Next

        Return True
    End Function

End Class

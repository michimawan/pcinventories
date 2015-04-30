Imports System.Net.Sockets
Imports Microsoft.Office.Interop

Public Class mains
    Dim serverSocket As New TcpListener(8889)
    Dim clientSocket As TcpClient
    Dim listenthread As System.Threading.Thread

    ' ====================================================================================================================================================================
    ' Form Function

    Private Sub mainForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub mains_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnDelPCs.Left = Me.Width - 160
    End Sub

    ' ====================================================================================================================================================================
    ' Staff Management

    Private Sub editBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editBtn.Click
        panelCreate.Hide()
        panelEdit.Show()
        createBtn.Enabled = True
        editBtn.Enabled = False
    End Sub

    Private Sub createBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createBtn.Click
        tbAddNama.Text = ""
        tbAddPassword.Text = ""
        tbAddUsername.Text = ""
        tbAddRePass.Text = ""

        panelEdit.Hide()
        panelCreate.Show()
        editBtn.Enabled = True
        createBtn.Enabled = False
    End Sub

    Private Sub btnAddStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStaff.Click
        Dim db As New dbConnection
        If db.checkStaff(tbAddUsername.Text) = False Then
            MsgBox("username sudah ada, silahkan gunakan yang lain", MsgBoxStyle.OkOnly, "Conflict username")
        Else
            If tbAddPassword.Text.Length >= 6 Then
                If tbAddPassword.Text = tbAddRePass.Text Then

                    If db.addStaff(tbAddNama.Text, tbAddUsername.Text, tbAddPassword.Text) = True Then
                        tbAddNama.Text = ""
                        tbAddPassword.Text = ""
                        tbAddRePass.Text = ""
                        tbAddUsername.Text = ""

                        MsgBox("Success to add new user !", MsgBoxStyle.OkOnly, "Success")
                    Else : MsgBox("Something bad happen, failed to create new user !", MsgBoxStyle.OkOnly, "Failed")
                    End If
                    db = Nothing
                Else : MsgBox("Please input the same password", MsgBoxStyle.OkOnly, "Password mismatch")
                End If
            Else : MsgBox("Please use min. 6 char", MsgBoxStyle.OkOnly, "Password too short")
            End If
        End If
        db = Nothing
    End Sub

    Private Sub btnEditCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCari.Click
        If tbEditCari.Text.Length = 0 Then
            MsgBox("Please input some username", MsgBoxStyle.OkOnly, "Error Search")
        Else
            Dim db As New dbConnection
            Dim res = db.getStaff(tbEditCari.Text)
            If res.Count = 0 Then
                MsgBox("Data Staff not found", MsgBoxStyle.OkOnly, "Not Found")
            Else
                editStaff.fillForm(res)
                editStaff.Show()
            End If
        End If
    End Sub


    ' ====================================================================================================================================================================
    ' Get PCs
    Private Sub btnListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListen.Click
        If btnListen.Text = "Listening" Then
            btnListen.Text = "Stop Listening"
            If Not bw.IsBusy = True Then
                bw.RunWorkerAsync()
            End If
            dgvMain.Enabled = False
            BtnSave.Enabled = False
        Else
            stops()
            btnListen.Text = "Listening"
            dgvMain.Enabled = True
            BtnSave.Enabled = True
        End If
    End Sub

    ' raised by RunWorkerAsync()
    Private Sub bw_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bw.DoWork
        Try
            serverSocket.Start()
            While True
                clientSocket = serverSocket.AcceptTcpClient

                Dim bytes(10024) As Byte
                Dim dataClient As String = ""

                Dim networkStream As NetworkStream = clientSocket.GetStream
                networkStream.Read(bytes, 0, bytes.Length)
                dataClient = System.Text.Encoding.ASCII.GetString(bytes)

                parseMessage(dataClient)
            End While
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    'stop listening
    Private Sub stops()
        Try
            If bw.WorkerSupportsCancellation = True Then
                bw.CancelAsync()
            End If
            If clientSocket.Connected = True Then
                clientSocket.Close()
            End If
            serverSocket.Stop()
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub

    ' ====================================================================================================================================================================
    ' parser Client Message
    Private Sub parseMessage(ByVal datas As String)
        Dim data = datas.Split(vbCr)
        Dim newRow(7) As String
        'Debug.Print("row now: " + dgvMain.Rows.Count.ToString)
        newRow(0) = (dgvMain.Rows.Count + 1).ToString

        Dim cHDD = 0

        For Each line In data
            If line.Contains("PROC") Then
                newRow(2) = line.Substring(6, (line.Length - 12))
                Debug.Print(line.Substring(6, (line.Length - 12)))
                'dgvMain.Item(2, dgvMain.Rows.Count).Value = line.Substring(6, (line.Length - 12))
            ElseIf line.Contains("HDD") Then
                If cHDD = 0 Then
                    newRow(3) = line.Substring(5, (line.Length - 10))
                    cHDD = 1
                Else

                End If

                Debug.Print(line.Substring(5, (line.Length - 10)))
                'dgvMain.Item(3, dgvMain.Rows.Count).Value = line.Substring(5, (line.Length - 10))
            ElseIf line.Contains("RAM") Then
                newRow(4) = line.Substring(5, (line.Length - 10))
                Debug.Print(line.Substring(5, (line.Length - 10)))
                'dgvMain.Item(4, dgvMain.Rows.Count).Value = line.Substring(5, (line.Length - 10))
            ElseIf line.Contains("VGA") Then
                newRow(5) = line.Substring(5, (line.Length - 10))
                Debug.Print(line.Substring(5, (line.Length - 10)))
                'dgvMain.Item(5, dgvMain.Rows.Count).Value = line.Substring(5, (line.Length - 10))
            ElseIf line.Contains("OS") Then
                newRow(6) = line.Substring(4, (line.Length - 8))
                Debug.Print(line.Substring(4, (line.Length - 8)))
                'dgvMain.Item(6, dgvMain.Rows.Count).Value = line.Substring(4, (line.Length - 8))
            ElseIf line.Contains("Owner") Then
                newRow(1) = line.Substring(7, (line.Length - 14))
                Debug.Print(line.Substring(7, (line.Length - 14)))
                'dgvMain.Item(1, dgvMain.Rows.Count).Value = line.Substring(7, (line.Length - 14))
            End If
        Next

        doRowAdd(dgvMain, newRow)
    End Sub

    ' ====================================================================================================================================================================
    ' add row in GUI thread / main thread / caller thread

    Private Delegate Sub addDGVRow(ByVal dgv As DataGridView, ByVal row As String())
    Sub doRowAdd(ByVal dgv As DataGridView, ByVal row As String())
        If dgv.InvokeRequired Then
            dgv.Invoke(New addDGVRow(AddressOf doRowAdd), dgv, row)
        Else
            dgv.Rows.Add(row)
        End If
    End Sub

    ' ====================================================================================================================================================================
    ' save list PC to db
    Public Shared selPCs As New List(Of String)
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        saveForm.reload()

        selPCs = New List(Of String)
        If dgvMain.SelectedRows.Count > 0 Then
            For i = 0 To dgvMain.SelectedRows.Count - 1
                'Debug.Print(dgvMain.SelectedRows(i).Cells("col1").Value) 'no
                'Debug.Print(dgvMain.SelectedRows(i).Cells("col2").Value) 'owner
                'Debug.Print(dgvMain.SelectedRows(i).Cells("col3").Value) 'proc
                'Debug.Print(dgvMain.SelectedRows(i).Cells("col4").Value) 'hdd
                'Debug.Print(dgvMain.SelectedRows(i).Cells("col5").Value) 'ram
                'Debug.Print(dgvMain.SelectedRows(i).Cells("col6").Value) 'vga
                'Debug.Print(dgvMain.SelectedRows(i).Cells("col7").Value) 'os
                Dim newPC = "'" + dgvMain.SelectedRows(i).Cells("col3").Value + "', '" + _
                            dgvMain.SelectedRows(i).Cells("col4").Value + "', '" + _
                            dgvMain.SelectedRows(i).Cells("col5").Value + "', '" + _
                            dgvMain.SelectedRows(i).Cells("col6").Value + "', '" + _
                            dgvMain.SelectedRows(i).Cells("col7").Value + "', '" + _
                            dgvMain.SelectedRows(i).Cells("col2").Value + "'"
                selPCs.Add(newPC)
            Next
            saveForm.Show()
        Else : MsgBox("Please select some row first !", MsgBoxStyle.OkOnly, "Error Save")
        End If
    End Sub

    ' ====================================================================================================================================================================
    ' tab get PCs

    Private Sub btnGetPC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetPC.Click
        If cbListRooms.SelectedIndex < 0 Then
            MsgBox("Please select some room first !", MsgBoxStyle.OkOnly, "Error Get PCs")
        Else
            Dim db As New dbConnection
            db.getPCS(dgvView, cbListRooms.SelectedIndex + 1)
            db = Nothing
        End If
    End Sub

    ' ====================================================================================================================================================================
    ' tab control management

    Private Sub tabControls_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabControls.SelectedIndexChanged
        If tabControls.SelectedIndex = 0 Then
        ElseIf tabControls.SelectedIndex = 1 Then
            Dim db As New dbConnection
            Dim res = db.getRooms()
            cbListRooms.Items.Clear()
            For Each item In res
                cbListRooms.Items.Add(item.ToString)
            Next
            db = Nothing
        ElseIf tabControls.SelectedIndex = 2 Then
            tbAddNama.Text = ""
            tbAddPassword.Text = ""
            tbAddUsername.Text = ""
            tbAddRePass.Text = ""

            panelEdit.Hide()
            createBtn.Enabled = False
            panelCreate.Show()
            editBtn.Enabled = True
        End If
    End Sub

#Region "prints"
    ' ====================================================================================================================================================================
    ' print PCs

    Private prnDialog As System.Windows.Forms.PrintDialog
    Private prnDocument As System.Drawing.Printing.PrintDocument
    Private currX As Integer
    Private currY As Integer
    Private leftMargin As Integer
    Private rightMargin As Integer
    Private topMargin As Integer
    Private bottomMargin As Integer
    Private PaperWidth As Integer
    Private PaperHeight As Integer

    ' Font and Color: 
    Private InvTitleFont As Font = New Font("Arial", 24, FontStyle.Bold)
    Private InvSubTitleFont As Font = New Font("Arial", 16, FontStyle.Bold)
    Private InvDateFont As Font = New Font("Arial", 12, FontStyle.Regular)
    Private dataHeaderFont As Font = New Font("Arial", 12, FontStyle.Bold)
    Private dataContentFont As Font = New Font("Arial", 12, FontStyle.Regular)

    ' Title
    Private title As String
    Private subTitle As String
    Private dates As String
    Private imgPath As String

#Region "generate windows print"
    Public Sub New()
        MyBase.new()
        ' This call is required by the designer.
        InitializeComponent()

        Me.prnDocument = New System.Drawing.Printing.PrintDocument
        AddHandler prnDocument.PrintPage, AddressOf prnDocument_PrintPage

    End Sub
#End Region

    'Private Sub btnPrintPCs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPCs.Click

    '    Try
    '        prnDocument.DefaultPageSettings.Landscape = True

    '        prnDocument.Print()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString())
    '    End Try

    'End Sub

    Private Sub prnDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)


        leftMargin = Convert.ToInt32(e.MarginBounds.Left)
        rightMargin = Convert.ToInt32(e.MarginBounds.Right)
        topMargin = Convert.ToInt32(e.MarginBounds.Top)
        bottomMargin = Convert.ToInt32(e.MarginBounds.Bottom)
        PaperWidth = Convert.ToInt32(e.MarginBounds.Width)
        PaperHeight = Convert.ToInt32(e.MarginBounds.Height)
        'MsgBox(e.MarginBounds.Width.ToString)

        setData(e.Graphics, e)
    End Sub

    Private Sub fillHeader()
        title = "PUSAT PELAYANAN KOMPUTER UKDW"
        subTitle = "Sistem Informasi Inventarisasi PC"
        imgPath = Application.StartupPath & "\img\" + "logo.jpg"
        dates = "Dicetak: " + Now().Date.ToString
    End Sub

    Private Sub setHeader(ByVal g As Graphics)
        fillHeader()

        currX = leftMargin
        currY = topMargin - 50
        Dim imgHeight As Integer = 0

        If (System.IO.File.Exists(imgPath)) Then
            Dim oImage As Bitmap = New Bitmap(imgPath)
            'set Image to left page
            Dim xImage As Integer = currX + (PaperWidth / 2) - (oImage.Width / 4)
            imgHeight = oImage.Height
            g.DrawImage(oImage, xImage, currY)
        End If

        ' get height
        Dim titleHeight = Convert.ToInt32(InvTitleFont.GetHeight(g))
        Dim subTitleHeight = Convert.ToInt32(InvSubTitleFont.GetHeight(g))
        Dim datesHeight = Convert.ToInt32(InvDateFont.GetHeight(g))

        ' get length
        Dim lenTitle As Integer = Convert.ToInt32(g.MeasureString(title, InvTitleFont).Width)
        Dim lenSubTitle As Integer = Convert.ToInt32(g.MeasureString(subTitle, InvSubTitleFont).Width)
        Dim lenDates As Integer = Convert.ToInt32(g.MeasureString(dates, InvDateFont).Width)

        ' set left
        Dim xTitle As Integer = currX + (PaperWidth - lenTitle) / 2
        Dim xSubTitle As Integer = currX + (PaperWidth - lenSubTitle) / 2
        Dim xDates As Integer = currX + (PaperWidth - lenDates) / 2

        'draw header
        currY = currY + imgHeight - 220
        g.DrawString(title, InvTitleFont, Brushes.Black, xTitle, currY)

        currY = currY + titleHeight
        g.DrawString(subTitle, InvSubTitleFont, Brushes.Black, xSubTitle, currY)

        currY = currY + subTitleHeight + 3
        g.DrawLine(New Pen(Brushes.Black, 2), currX, currY, rightMargin, currY)

        currY = currY + 5
        g.DrawString(dates, InvDateFont, Brushes.Black, xDates, currY)
    End Sub
    '30 75 275 225 60 180 200

    ' Dim x As 
    Private Sub setData(ByVal g As Graphics, ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        setHeader(e.Graphics)

        Dim fieldValue As String = ""
        Dim currRecord = 0
        Dim recordPerPage = 20
        Dim stopReading As Boolean = False

        Dim pFontHeight = Convert.ToInt32(dataHeaderFont.GetHeight(g))

        'set Header Table
        Dim xNo As Integer = leftMargin
        currY = currY + pFontHeight
        g.DrawString("No", dataHeaderFont, Brushes.Black, xNo, currY)
        'Convert.ToInt32(g.MeasureString("HIMAWAN-PC", dataContentFont).Width)
        Dim xOwner As Integer = xNo + 30
        g.DrawString("HIMAWAN-PC", dataContentFont, Brushes.Black, xOwner, currY)
        'Convert.ToInt32(g.MeasureString("Intel(R) Core(TM) i5 CPU       M 520  @ 2.40GHz", dataContentFont).Width)
        Dim xProc As Integer = xOwner + 75
        g.DrawString("Intel(R) Core(TM) i5 CPU       M 520  @ 2.40GHz", dataContentFont, Brushes.Black, xProc, currY)
        'Convert.ToInt32(g.MeasureString("WDC WD2500BEKT-75A25T0, 250 GB", dataContentFont).Width)
        Dim xHDD As Integer = xProc + 200
        g.DrawString("WDC WD2500BEKT-75A25T0, 250 GB", dataContentFont, Brushes.Black, xHDD, currY)
        'Convert.ToInt32(g.MeasureString("4 GB", dataContentFont).Width)
        Dim xRAM As Integer = xHDD + 175
        g.DrawString("4 GB", dataContentFont, Brushes.Black, xRAM, currY)
        'Convert.ToInt32(g.MeasureString("NVIDIA NVS 3100M, 537 MB", dataContentFont).Width)
        Dim xVGA As Integer = xRAM + 15
        g.DrawString("NVIDIA NVS 3100M, 537 MB", dataContentFont, Brushes.Black, xRAM, currY)
        'Convert.ToInt32(g.MeasureString("Microsoft Windows 8.1 Pro 6.3.9600", dataContentFont).Width)
        Dim xOS As Integer = xVGA + 150
        g.DrawString("Microsoft Windows 8.1 Pro 6.3.9600", dataContentFont, Brushes.Black, xOS, currY)


    End Sub

#End Region

#Region "Export to Excel"
    Private Sub btnPrintPCs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPCs.Click

        If cbListRooms.SelectedIndex >= 0 Then
            createExcelFile()
            writeToFile()
            saveFile()
        Else : MsgBox("Select one room that you'll export", MsgBoxStyle.OkOnly, "Error Export")
        End If

    End Sub

    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim misValue As Object = System.Reflection.Missing.Value

    Private Sub createExcelFile()
        'xlApp = New Excel.Application
        xlApp = CreateObject("Excel.Application")
        xlWorkBook = xlApp.Workbooks.Add
        'xlApp.Visible = True
        xlWorkSheet = xlWorkBook.Worksheets(1)
        'xlWorkSheet.EnableSelection = True
    End Sub

    Private Sub saveFile()
        Dim dir = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        dir = dir + "\PC Invents\"

        If System.IO.Directory.Exists(dir) Then
            Dim title = cbListRooms.Items(cbListRooms.SelectedIndex).ToString + "-" + Now.ToString + ".xlsx"
            title = title.Replace("/", "")
            title = title.Replace(":", "")
            title = title.Replace(" ", "")
            title = dir + title

            'createExcelFile()
            xlWorkSheet.SaveAs(title)
            xlWorkBook.Close()
            xlApp.Quit()
        Else
            System.IO.Directory.CreateDirectory(dir)
            Dim title = cbListRooms.Items(cbListRooms.SelectedIndex).ToString + "-" + Now.ToString + ".xlsx"
            title = title.Replace("/", "")
            title = title.Replace(":", "")
            title = title.Replace(" ", "")
            title = dir + title

            'createExcelFile()
            xlWorkSheet.SaveAs(title)
            xlWorkBook.Close()
            xlApp.Quit()
        End If

    End Sub

    Private Sub writeToFile()

        'formatting
        With xlWorkSheet.Range(xlWorkSheet.Cells(1, 1), xlWorkSheet.Cells(7, 7))
            .Font.Bold = True
            .Font.Size = 14
            .Font.Name = "Arial"
            .HorizontalAlignment = 3
        End With

        With xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 7))
            .Font.Size = 12
        End With

        With xlWorkSheet.Range(xlWorkSheet.Cells(6, 1), xlWorkSheet.Cells(6, 7))
            .HorizontalAlignment = 1
        End With

        With xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(dgvView.RowCount + 10, 7))
            .Font.Size = 10
            .Font.Name = "Arial"
        End With

        With xlWorkSheet.Range(xlWorkSheet.Cells(7, 1), xlWorkSheet.Cells(dgvView.RowCount + 10, 7))
            .HorizontalAlignment = 3
        End With

        'fill content I
        xlWorkSheet.Cells(2, 1).Value = "PUSAT PELAYANAN KOMPUTER UKDW"
        xlWorkSheet.Cells(3, 1).Value = "Sistem Inventarisasi PC"
        xlWorkSheet.Cells(4, 1).Value = "Dicetak : " + Now.ToString

        ' merge cells
        xlWorkSheet.Range(xlWorkSheet.Cells(2, 1), xlWorkSheet.Cells(2, 7)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(3, 1), xlWorkSheet.Cells(3, 7)).Merge()
        xlWorkSheet.Range(xlWorkSheet.Cells(4, 1), xlWorkSheet.Cells(4, 7)).Merge()

        'fill content II
        xlWorkSheet.Cells(6, 1).Value = "Ruang: " + cbListRooms.Items(cbListRooms.SelectedIndex).ToString + ", Total PC: " + dgvView.RowCount.ToString
        xlWorkSheet.Cells(7, 1).Value = "No"
        xlWorkSheet.Cells(7, 2).Value = "Owner"
        xlWorkSheet.Cells(7, 3).Value = "Processor"
        xlWorkSheet.Cells(7, 4).Value = "HDD"
        xlWorkSheet.Cells(7, 5).Value = "RAM"
        xlWorkSheet.Cells(7, 6).Value = "VGA"
        xlWorkSheet.Cells(7, 7).Value = "OS"
        For i = 0 To dgvView.RowCount - 1
            For j = 0 To 6
                xlWorkSheet.Cells((i + 8), j + 1).Value = dgvView.Item(j, i).Value.ToString
            Next
        Next

        ' set width column
        With xlWorkSheet.Columns("A")
            .ColumnWidth = 4
        End With
        xlWorkSheet.Columns("B").AutoFit()
        xlWorkSheet.Columns("C").AutoFit()
        xlWorkSheet.Columns("D").AutoFit()
        xlWorkSheet.Columns("E").AutoFit()
        xlWorkSheet.Columns("F").AutoFit()
        xlWorkSheet.Columns("G").AutoFit()

    End Sub

#End Region

    Private Sub mains_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
        Me.WindowState = FormWindowState.Maximized
    End Sub


    Private Sub mains_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            Debug.Print("meme")
            btnDelPCs.Left = Me.Width - 140
            Dim f As New System.Drawing.Font("Microsoft Sans Serif", 10, FontStyle.Bold)
            Label1.Font = f
            lblUsername.Font = f
            f = Nothing
        ElseIf WindowState = FormWindowState.Normal Then
            Debug.Print("yeye")
            btnDelPCs.Left = Me.Width - 140

            Dim f As New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
            Label1.Font = f
            lblUsername.Font = f
            f = Nothing
        End If
    End Sub

    Private Sub btnDelPCs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelPCs.Click
        If dgvView.SelectedRows.Count = 0 Then
            MsgBox("Please select at least one row", MsgBoxStyle.OkOnly, "Error Delete")
        Else
            Dim res = MsgBox("Are You sure to delete this?", MsgBoxStyle.OkCancel, "Confirm Delete")
            If res = DialogResult.OK Then
                Dim db As New dbConnection

                If db.delRow(dgvView) Then
                    MsgBox("Success delete row", MsgBoxStyle.OkOnly, "Success Delete")
                Else : MsgBox("Failed delete row", MsgBoxStyle.OkOnly, "Failed Delete")
                End If

                db = Nothing
            End If
        End If
    End Sub
End Class
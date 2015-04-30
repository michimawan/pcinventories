Public Class saveForm
    Dim db As New dbConnection
    Public Sub reload()
        Dim res = db.getRooms()
        cbRoomSave.Items.Clear()
        For Each item In res
            'simpan index juga
            Debug.Print("cb: " + item.ToString)
            cbRoomSave.Items.Add(item.ToString)
        Next
        cbRoomSave.Items.Add("New Room...")

        tbRoomSave.Text = ""
        tbRoomSave.Visible = False
        BtnSaveForm.Text = "Save"
    End Sub

    Private Sub saveForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub BtnSaveForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveForm.Click
        If BtnSaveForm.Text = "Save" Then
            If cbRoomSave.SelectedIndex < 0 Then
                MsgBox("Please fill one of the boxes", MsgBoxStyle.OkOnly, "Error Save")
            ElseIf cbRoomSave.SelectedIndex = cbRoomSave.Items.Count - 1 Then 'if selected was new room
                cbRoomSave.Visible = False
                BtnSaveForm.Text = "Add Room and Save"
                tbRoomSave.Text = "type your room here .."
                tbRoomSave.ForeColor = Color.Gray
                tbRoomSave.Visible = True
            Else 'if selected others than new room and index < 0
                If db.addListPCs(mains.selPCs, (cbRoomSave.SelectedIndex + 1)) = True Then
                    MsgBox("Success save selected PCs", MsgBoxStyle.OkOnly, "Success Save")
                Else : MsgBox("Failed to save selected PCs", MsgBoxStyle.OkOnly, "Fail Save")
                End If
                Me.Hide()
            End If
        ElseIf BtnSaveForm.Text = "Add Room and Save" Then

            If db.addRoom(mains.selPCs, tbRoomSave.Text) = True Then
                MsgBox("Success save selected PCs", MsgBoxStyle.OkOnly, "Success Save")
            Else : MsgBox("Failed to save selected PCs", MsgBoxStyle.OkOnly, "Fail Save")
            End If

            BtnSaveForm.Text = "Save"
            tbRoomSave.Text = ""
            tbRoomSave.Visible = False
            cbRoomSave.Visible = True
            Me.Hide()
        End If

    End Sub

    Private Sub tbRoomSave_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbRoomSave.Enter
        tbRoomSave.Text = ""
        tbRoomSave.ForeColor = Color.Black
    End Sub
End Class
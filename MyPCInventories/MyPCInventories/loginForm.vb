Public Class loginForm
    Dim conns As New dbConnection
    Private Sub loginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginBtn.Click
        logins()
    End Sub

    Private Sub logins()
        If conns.logins(staffTb.Text, staffPTb.Text) = True Then
            Me.Hide()
            mains.WindowState = FormWindowState.Maximized
            mains.lblUsername.Text = dbConnection.username
            staffPTb.Text = ""
            staffTb.Text = ""
            mains.tabControls.SelectedIndex = 0
            mains.Show()
        Else : MsgBox("Failed to Login, invalid ID", MsgBoxStyle.OkOnly, "Failed Login")
        End If
    End Sub

    Private Sub loginForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub staffPTb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles staffPTb.KeyPress
        If Asc(e.KeyChar) = 13 Then
            logins()
        End If
    End Sub

    Private Sub staffTb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles staffTb.KeyPress
        If Asc(e.KeyChar) = 13 Then
            logins()
        End If

    End Sub
End Class
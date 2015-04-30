Public Class editStaff

    Public Sub fillForm(ByVal datas As List(Of String))

        tbEditNama.Text = datas(0).ToString
        tbEditUsername.Text = datas(1).ToString

    End Sub

    Private Sub btnEditStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStaff.Click
        If tbEditPassword.Text.Length >= 6 Then
            If tbEditPassword.Text = tbEditRePass.Text Then

                Dim db As New dbConnection
                If db.editStaff(tbEditNama.Text, tbEditUsername.Text, tbEditPassword.Text) = True Then
                    tbEditNama.Text = ""
                    tbEditPassword.Text = ""
                    tbEditRePass.Text = ""
                    tbEditUsername.Text = ""

                    MsgBox("Success to edit user data !", MsgBoxStyle.OkOnly, "Success")
                    Me.Hide()
                Else : MsgBox("Something bad happen, failed to edit new user !", MsgBoxStyle.OkOnly, "Failed")
                End If
                db = Nothing

            Else : MsgBox("Please input the same password", MsgBoxStyle.OkOnly, "Password mismatch")
            End If
        Else : MsgBox("Please input min. 6 char", MsgBoxStyle.OkOnly, "Password too short")
        End If
        
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim db As New dbConnection
        If db.hapusStaff(tbEditUsername.Text) = True Then
            MsgBox("Data user has been deleted", MsgBoxStyle.OkOnly, "Success Delete")
            Me.Hide()
        Else : MsgBox("Data user can't be deleted", MsgBoxStyle.OkOnly, "Failed Delete")
        End If
    End Sub
End Class
Imports System.Net.Sockets

Public Class Form1
    Dim clientSocket As New TcpClient()
    Dim serverStream As NetworkStream
    Dim grab As New PCSpecGrabber

    Private Sub SendBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendBtn.Click
        If clientSocket.Connected = True Then
            Dim serverStream As NetworkStream = clientSocket.GetStream()
            Dim outStream As Byte() = _
            System.Text.Encoding.ASCII.GetBytes(grab.SendSpec())
            serverStream.Write(outStream, 0, outStream.Length)
            serverStream.Flush()

            'Dim buffSize As Integer
            'Dim inStream(10024) As Byte
            'buffSize = clientSocket.ReceiveBufferSize
            'serverStream.Read(inStream, 0, buffSize)
            'Dim returndata As String = _
            'System.Text.Encoding.ASCII.GetString(inStream)
            'MsgBox("Data from Server : " + returndata)
            MsgBox("Data has been sent.", MsgBoxStyle.OkOnly, "Send Report")

            Me.Close()
        Else : MsgBox("You must connect first !!", MsgBoxStyle.OkOnly, "Problem send data")
            ConnectBtn.Visible = True
        End If

    End Sub

    Private Sub ConnectBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectBtn.Click
        If IPtb.Text.Length = 0 Then
        Else
            Try
                clientSocket.Connect(IPtb.Text, 8889)
            Catch ex As Exception

            End Try

        End If
        If clientSocket.Connected = True Then
            ConnectBtn.Visible = False
            statusLabl.Text = "Connected..."
        Else
            MsgBox("Make sure the server are listening and can be ping", MsgBoxStyle.OkOnly, "Error connecting")
            statusLabl.Text = "Not Connected ..."
        End If
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editStaff))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbEditRePass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbEditPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbEditUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbEditNama = New System.Windows.Forms.TextBox()
        Me.btnEditStaff = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Re-type Password :"
        '
        'tbEditRePass
        '
        Me.tbEditRePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEditRePass.Location = New System.Drawing.Point(24, 210)
        Me.tbEditRePass.Name = "tbEditRePass"
        Me.tbEditRePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbEditRePass.Size = New System.Drawing.Size(214, 23)
        Me.tbEditRePass.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Password :"
        '
        'tbEditPassword
        '
        Me.tbEditPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEditPassword.Location = New System.Drawing.Point(24, 153)
        Me.tbEditPassword.Name = "tbEditPassword"
        Me.tbEditPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbEditPassword.Size = New System.Drawing.Size(214, 23)
        Me.tbEditPassword.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Username : "
        '
        'tbEditUsername
        '
        Me.tbEditUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEditUsername.Location = New System.Drawing.Point(24, 98)
        Me.tbEditUsername.Name = "tbEditUsername"
        Me.tbEditUsername.ReadOnly = True
        Me.tbEditUsername.Size = New System.Drawing.Size(214, 23)
        Me.tbEditUsername.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama : "
        '
        'tbEditNama
        '
        Me.tbEditNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEditNama.Location = New System.Drawing.Point(24, 44)
        Me.tbEditNama.Name = "tbEditNama"
        Me.tbEditNama.Size = New System.Drawing.Size(214, 23)
        Me.tbEditNama.TabIndex = 10
        '
        'btnEditStaff
        '
        Me.btnEditStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStaff.Location = New System.Drawing.Point(163, 256)
        Me.btnEditStaff.Name = "btnEditStaff"
        Me.btnEditStaff.Size = New System.Drawing.Size(75, 30)
        Me.btnEditStaff.TabIndex = 9
        Me.btnEditStaff.Text = "Simpan"
        Me.btnEditStaff.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(77, 256)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 30)
        Me.btnHapus.TabIndex = 18
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'editStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 301)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbEditRePass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbEditPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbEditUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbEditNama)
        Me.Controls.Add(Me.btnEditStaff)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "editStaff"
        Me.Text = "Staff Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbEditRePass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbEditPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbEditUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbEditNama As System.Windows.Forms.TextBox
    Friend WithEvents btnEditStaff As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class saveForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(saveForm))
        Me.BtnSaveForm = New System.Windows.Forms.Button()
        Me.cbRoomSave = New System.Windows.Forms.ComboBox()
        Me.tbRoomSave = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnSaveForm
        '
        Me.BtnSaveForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveForm.Location = New System.Drawing.Point(162, 78)
        Me.BtnSaveForm.Name = "BtnSaveForm"
        Me.BtnSaveForm.Size = New System.Drawing.Size(75, 28)
        Me.BtnSaveForm.TabIndex = 0
        Me.BtnSaveForm.Text = "Save"
        Me.BtnSaveForm.UseVisualStyleBackColor = True
        '
        'cbRoomSave
        '
        Me.cbRoomSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoomSave.FormattingEnabled = True
        Me.cbRoomSave.Location = New System.Drawing.Point(36, 23)
        Me.cbRoomSave.Name = "cbRoomSave"
        Me.cbRoomSave.Size = New System.Drawing.Size(201, 24)
        Me.cbRoomSave.TabIndex = 1
        Me.cbRoomSave.Text = "Select available room"
        '
        'tbRoomSave
        '
        Me.tbRoomSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRoomSave.Location = New System.Drawing.Point(36, 23)
        Me.tbRoomSave.Name = "tbRoomSave"
        Me.tbRoomSave.Size = New System.Drawing.Size(201, 23)
        Me.tbRoomSave.TabIndex = 2
        '
        'saveForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 121)
        Me.Controls.Add(Me.BtnSaveForm)
        Me.Controls.Add(Me.tbRoomSave)
        Me.Controls.Add(Me.cbRoomSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "saveForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Save"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSaveForm As System.Windows.Forms.Button
    Friend WithEvents cbRoomSave As System.Windows.Forms.ComboBox
    Friend WithEvents tbRoomSave As System.Windows.Forms.TextBox
End Class

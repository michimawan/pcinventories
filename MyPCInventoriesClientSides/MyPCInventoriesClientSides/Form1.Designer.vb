<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.IPtb = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ConnectBtn = New System.Windows.Forms.Button()
        Me.SendBtn = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusLabl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IPtb
        '
        Me.IPtb.Location = New System.Drawing.Point(32, 29)
        Me.IPtb.Name = "IPtb"
        Me.IPtb.ShortcutsEnabled = False
        Me.IPtb.Size = New System.Drawing.Size(199, 20)
        Me.IPtb.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ConnectBtn)
        Me.GroupBox1.Controls.Add(Me.SendBtn)
        Me.GroupBox1.Controls.Add(Me.IPtb)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 97)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Put Server IP here"
        '
        'ConnectBtn
        '
        Me.ConnectBtn.Location = New System.Drawing.Point(32, 63)
        Me.ConnectBtn.Name = "ConnectBtn"
        Me.ConnectBtn.Size = New System.Drawing.Size(75, 23)
        Me.ConnectBtn.TabIndex = 1
        Me.ConnectBtn.Text = "Connect"
        Me.ConnectBtn.UseVisualStyleBackColor = True
        '
        'SendBtn
        '
        Me.SendBtn.Location = New System.Drawing.Point(156, 63)
        Me.SendBtn.Name = "SendBtn"
        Me.SendBtn.Size = New System.Drawing.Size(75, 23)
        Me.SendBtn.TabIndex = 2
        Me.SendBtn.Text = "Send !!!"
        Me.SendBtn.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 113)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(292, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusLabl
        '
        Me.statusLabl.Name = "statusLabl"
        Me.statusLabl.Size = New System.Drawing.Size(100, 17)
        Me.statusLabl.Text = "Not Connected ..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 135)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send PC Spec"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IPtb As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SendBtn As System.Windows.Forms.Button
    Friend WithEvents ConnectBtn As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statusLabl As System.Windows.Forms.ToolStripStatusLabel

End Class

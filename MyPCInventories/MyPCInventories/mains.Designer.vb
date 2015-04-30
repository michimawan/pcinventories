<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mains
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mains))
        Me.tabControls = New System.Windows.Forms.TabControl()
        Me.tab1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.btnListen = New System.Windows.Forms.Button()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer()
        Me.btnDelPCs = New System.Windows.Forms.Button()
        Me.btnPrintPCs = New System.Windows.Forms.Button()
        Me.cbListRooms = New System.Windows.Forms.ComboBox()
        Me.btnGetPC = New System.Windows.Forms.Button()
        Me.dgvView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tab3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.createBtn = New System.Windows.Forms.Button()
        Me.panelEdit = New System.Windows.Forms.Panel()
        Me.btnEditCari = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbEditCari = New System.Windows.Forms.TextBox()
        Me.panelCreate = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbAddRePass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbAddPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAddUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAddNama = New System.Windows.Forms.TextBox()
        Me.btnAddStaff = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.bw = New System.ComponentModel.BackgroundWorker()
        Me.tabControls.SuspendLayout()
        Me.tab1.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab2.SuspendLayout()
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.panelEdit.SuspendLayout()
        Me.panelCreate.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControls
        '
        Me.tabControls.Controls.Add(Me.tab1)
        Me.tabControls.Controls.Add(Me.tab2)
        Me.tabControls.Controls.Add(Me.tab3)
        Me.tabControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControls.Location = New System.Drawing.Point(0, 0)
        Me.tabControls.Name = "tabControls"
        Me.tabControls.SelectedIndex = 0
        Me.tabControls.Size = New System.Drawing.Size(820, 489)
        Me.tabControls.TabIndex = 0
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.SplitContainer5)
        Me.tab1.Location = New System.Drawing.Point(4, 22)
        Me.tab1.Name = "tab1"
        Me.tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1.Size = New System.Drawing.Size(812, 463)
        Me.tab1.TabIndex = 0
        Me.tab1.Text = "Get PCs"
        Me.tab1.UseVisualStyleBackColor = True
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.BtnSave)
        Me.SplitContainer5.Panel1.Controls.Add(Me.btnListen)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.dgvMain)
        Me.SplitContainer5.Size = New System.Drawing.Size(806, 457)
        Me.SplitContainer5.SplitterDistance = 29
        Me.SplitContainer5.TabIndex = 2
        '
        'BtnSave
        '
        Me.BtnSave.AutoSize = True
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSave.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.Location = New System.Drawing.Point(0, 0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 29)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'btnListen
        '
        Me.btnListen.AutoSize = True
        Me.btnListen.BackColor = System.Drawing.SystemColors.Control
        Me.btnListen.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnListen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListen.ForeColor = System.Drawing.Color.Black
        Me.btnListen.Location = New System.Drawing.Point(669, 0)
        Me.btnListen.Name = "btnListen"
        Me.btnListen.Size = New System.Drawing.Size(137, 29)
        Me.btnListen.TabIndex = 1
        Me.btnListen.Text = "Listening"
        Me.btnListen.UseVisualStyleBackColor = False
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col1, Me.col2, Me.col3, Me.col4, Me.col5, Me.col6, Me.col7})
        Me.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMain.Location = New System.Drawing.Point(0, 0)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(806, 424)
        Me.dgvMain.TabIndex = 0
        '
        'col1
        '
        Me.col1.HeaderText = "No"
        Me.col1.Name = "col1"
        Me.col1.ReadOnly = True
        Me.col1.Width = 30
        '
        'col2
        '
        Me.col2.HeaderText = "Owner"
        Me.col2.Name = "col2"
        Me.col2.ReadOnly = True
        '
        'col3
        '
        Me.col3.HeaderText = "Processor"
        Me.col3.Name = "col3"
        Me.col3.ReadOnly = True
        Me.col3.Width = 300
        '
        'col4
        '
        Me.col4.HeaderText = "HDD"
        Me.col4.Name = "col4"
        Me.col4.ReadOnly = True
        Me.col4.Width = 250
        '
        'col5
        '
        Me.col5.HeaderText = "RAM"
        Me.col5.Name = "col5"
        Me.col5.ReadOnly = True
        '
        'col6
        '
        Me.col6.HeaderText = "VGA"
        Me.col6.Name = "col6"
        Me.col6.ReadOnly = True
        Me.col6.Width = 200
        '
        'col7
        '
        Me.col7.HeaderText = "OS"
        Me.col7.Name = "col7"
        Me.col7.ReadOnly = True
        Me.col7.Width = 200
        '
        'tab2
        '
        Me.tab2.Controls.Add(Me.SplitContainer7)
        Me.tab2.Location = New System.Drawing.Point(4, 22)
        Me.tab2.Name = "tab2"
        Me.tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.tab2.Size = New System.Drawing.Size(812, 463)
        Me.tab2.TabIndex = 1
        Me.tab2.Text = "List PC"
        Me.tab2.UseVisualStyleBackColor = True
        '
        'SplitContainer7
        '
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer7.Name = "SplitContainer7"
        Me.SplitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.Controls.Add(Me.btnDelPCs)
        Me.SplitContainer7.Panel1.Controls.Add(Me.btnPrintPCs)
        Me.SplitContainer7.Panel1.Controls.Add(Me.cbListRooms)
        Me.SplitContainer7.Panel1.Controls.Add(Me.btnGetPC)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.Controls.Add(Me.dgvView)
        Me.SplitContainer7.Size = New System.Drawing.Size(806, 457)
        Me.SplitContainer7.SplitterDistance = 29
        Me.SplitContainer7.TabIndex = 3
        '
        'btnDelPCs
        '
        Me.btnDelPCs.AutoSize = True
        Me.btnDelPCs.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelPCs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelPCs.ForeColor = System.Drawing.Color.Black
        Me.btnDelPCs.Location = New System.Drawing.Point(692, 0)
        Me.btnDelPCs.Name = "btnDelPCs"
        Me.btnDelPCs.Size = New System.Drawing.Size(109, 29)
        Me.btnDelPCs.TabIndex = 5
        Me.btnDelPCs.Text = "Delete PCs"
        Me.btnDelPCs.UseVisualStyleBackColor = False
        '
        'btnPrintPCs
        '
        Me.btnPrintPCs.AutoSize = True
        Me.btnPrintPCs.BackColor = System.Drawing.SystemColors.Control
        Me.btnPrintPCs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPCs.ForeColor = System.Drawing.Color.Black
        Me.btnPrintPCs.Location = New System.Drawing.Point(331, -1)
        Me.btnPrintPCs.Name = "btnPrintPCs"
        Me.btnPrintPCs.Size = New System.Drawing.Size(109, 29)
        Me.btnPrintPCs.TabIndex = 4
        Me.btnPrintPCs.Text = "Export PCs"
        Me.btnPrintPCs.UseVisualStyleBackColor = False
        '
        'cbListRooms
        '
        Me.cbListRooms.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbListRooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbListRooms.FormattingEnabled = True
        Me.cbListRooms.Location = New System.Drawing.Point(0, 0)
        Me.cbListRooms.Name = "cbListRooms"
        Me.cbListRooms.Size = New System.Drawing.Size(210, 28)
        Me.cbListRooms.TabIndex = 3
        Me.cbListRooms.Text = "Select one room to view..."
        '
        'btnGetPC
        '
        Me.btnGetPC.AutoSize = True
        Me.btnGetPC.BackColor = System.Drawing.SystemColors.Control
        Me.btnGetPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetPC.ForeColor = System.Drawing.Color.Black
        Me.btnGetPC.Location = New System.Drawing.Point(216, -1)
        Me.btnGetPC.Name = "btnGetPC"
        Me.btnGetPC.Size = New System.Drawing.Size(109, 29)
        Me.btnGetPC.TabIndex = 2
        Me.btnGetPC.Text = "Get PCs"
        Me.btnGetPC.UseVisualStyleBackColor = False
        '
        'dgvView
        '
        Me.dgvView.AllowUserToAddRows = False
        Me.dgvView.AllowUserToResizeRows = False
        Me.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dgvView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvView.Location = New System.Drawing.Point(0, 0)
        Me.dgvView.Name = "dgvView"
        Me.dgvView.ReadOnly = True
        Me.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvView.Size = New System.Drawing.Size(806, 424)
        Me.dgvView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Owner"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Processor"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "HDD"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 250
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "RAM"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "VGA"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "OS"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'tab3
        '
        Me.tab3.Controls.Add(Me.SplitContainer4)
        Me.tab3.Location = New System.Drawing.Point(4, 22)
        Me.tab3.Name = "tab3"
        Me.tab3.Padding = New System.Windows.Forms.Padding(3)
        Me.tab3.Size = New System.Drawing.Size(812, 463)
        Me.tab3.TabIndex = 2
        Me.tab3.Text = "Staff Management"
        Me.tab3.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.editBtn)
        Me.SplitContainer4.Panel1.Controls.Add(Me.createBtn)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.panelEdit)
        Me.SplitContainer4.Panel2.Controls.Add(Me.panelCreate)
        Me.SplitContainer4.Size = New System.Drawing.Size(806, 457)
        Me.SplitContainer4.SplitterDistance = 160
        Me.SplitContainer4.TabIndex = 0
        '
        'editBtn
        '
        Me.editBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBtn.Location = New System.Drawing.Point(0, 72)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(160, 72)
        Me.editBtn.TabIndex = 1
        Me.editBtn.Text = "Edit Staff"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'createBtn
        '
        Me.createBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.createBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createBtn.Location = New System.Drawing.Point(0, 0)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Size = New System.Drawing.Size(160, 72)
        Me.createBtn.TabIndex = 0
        Me.createBtn.Text = "Add Staff"
        Me.createBtn.UseVisualStyleBackColor = True
        '
        'panelEdit
        '
        Me.panelEdit.Controls.Add(Me.btnEditCari)
        Me.panelEdit.Controls.Add(Me.Label6)
        Me.panelEdit.Controls.Add(Me.tbEditCari)
        Me.panelEdit.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelEdit.Location = New System.Drawing.Point(250, 0)
        Me.panelEdit.Name = "panelEdit"
        Me.panelEdit.Size = New System.Drawing.Size(250, 457)
        Me.panelEdit.TabIndex = 0
        '
        'btnEditCari
        '
        Me.btnEditCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCari.Location = New System.Drawing.Point(161, 72)
        Me.btnEditCari.Name = "btnEditCari"
        Me.btnEditCari.Size = New System.Drawing.Size(75, 30)
        Me.btnEditCari.TabIndex = 9
        Me.btnEditCari.Text = "Search"
        Me.btnEditCari.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cari Username :"
        '
        'tbEditCari
        '
        Me.tbEditCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEditCari.Location = New System.Drawing.Point(22, 38)
        Me.tbEditCari.Name = "tbEditCari"
        Me.tbEditCari.Size = New System.Drawing.Size(214, 23)
        Me.tbEditCari.TabIndex = 9
        '
        'panelCreate
        '
        Me.panelCreate.Controls.Add(Me.Label5)
        Me.panelCreate.Controls.Add(Me.tbAddRePass)
        Me.panelCreate.Controls.Add(Me.Label4)
        Me.panelCreate.Controls.Add(Me.tbAddPassword)
        Me.panelCreate.Controls.Add(Me.Label3)
        Me.panelCreate.Controls.Add(Me.tbAddUsername)
        Me.panelCreate.Controls.Add(Me.Label2)
        Me.panelCreate.Controls.Add(Me.tbAddNama)
        Me.panelCreate.Controls.Add(Me.btnAddStaff)
        Me.panelCreate.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelCreate.Location = New System.Drawing.Point(0, 0)
        Me.panelCreate.Name = "panelCreate"
        Me.panelCreate.Size = New System.Drawing.Size(250, 457)
        Me.panelCreate.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Re-type Password :"
        '
        'tbAddRePass
        '
        Me.tbAddRePass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddRePass.Location = New System.Drawing.Point(17, 204)
        Me.tbAddRePass.Name = "tbAddRePass"
        Me.tbAddRePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbAddRePass.Size = New System.Drawing.Size(214, 23)
        Me.tbAddRePass.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password :"
        '
        'tbAddPassword
        '
        Me.tbAddPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddPassword.Location = New System.Drawing.Point(17, 147)
        Me.tbAddPassword.Name = "tbAddPassword"
        Me.tbAddPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbAddPassword.Size = New System.Drawing.Size(214, 23)
        Me.tbAddPassword.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username : "
        '
        'tbAddUsername
        '
        Me.tbAddUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddUsername.Location = New System.Drawing.Point(17, 92)
        Me.tbAddUsername.Name = "tbAddUsername"
        Me.tbAddUsername.Size = New System.Drawing.Size(214, 23)
        Me.tbAddUsername.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama : "
        '
        'tbAddNama
        '
        Me.tbAddNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddNama.Location = New System.Drawing.Point(17, 38)
        Me.tbAddNama.Name = "tbAddNama"
        Me.tbAddNama.Size = New System.Drawing.Size(214, 23)
        Me.tbAddNama.TabIndex = 1
        '
        'btnAddStaff
        '
        Me.btnAddStaff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStaff.Location = New System.Drawing.Point(156, 244)
        Me.btnAddStaff.Name = "btnAddStaff"
        Me.btnAddStaff.Size = New System.Drawing.Size(75, 30)
        Me.btnAddStaff.TabIndex = 0
        Me.btnAddStaff.Text = "Add"
        Me.btnAddStaff.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tabControls)
        Me.SplitContainer1.Size = New System.Drawing.Size(820, 534)
        Me.SplitContainer1.SplitterDistance = 41
        Me.SplitContainer1.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer2.Size = New System.Drawing.Size(820, 41)
        Me.SplitContainer2.SplitterDistance = 559
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.btnLogout)
        Me.SplitContainer6.Size = New System.Drawing.Size(257, 41)
        Me.SplitContainer6.SplitterDistance = 143
        Me.SplitContainer6.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.ForeColor = System.Drawing.Color.Black
        Me.SplitContainer3.IsSplitterFixed = True
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.lblUsername)
        Me.SplitContainer3.Size = New System.Drawing.Size(143, 41)
        Me.SplitContainer3.SplitterDistance = 25
        Me.SplitContainer3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome,"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Black
        Me.lblUsername.Location = New System.Drawing.Point(0, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(57, 17)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "Label1"
        '
        'btnLogout
        '
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLogout.Location = New System.Drawing.Point(0, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(110, 41)
        Me.btnLogout.TabIndex = 0
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'bw
        '
        Me.bw.WorkerSupportsCancellation = True
        '
        'mains
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 534)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "mains"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PC Inventories"
        Me.tabControls.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.PerformLayout()
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab2.ResumeLayout(False)
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel1.PerformLayout()
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer7.ResumeLayout(False)
        CType(Me.dgvView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab3.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.panelEdit.ResumeLayout(False)
        Me.panelEdit.PerformLayout()
        Me.panelCreate.ResumeLayout(False)
        Me.panelCreate.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControls As System.Windows.Forms.TabControl
    Friend WithEvents tab1 As System.Windows.Forms.TabPage
    Friend WithEvents tab2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tab3 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents createBtn As System.Windows.Forms.Button
    Friend WithEvents editBtn As System.Windows.Forms.Button
    Friend WithEvents panelCreate As System.Windows.Forms.Panel
    Friend WithEvents panelEdit As System.Windows.Forms.Panel
    Friend WithEvents btnAddStaff As System.Windows.Forms.Button
    Friend WithEvents tbAddNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbAddPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbAddUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbAddRePass As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbEditCari As System.Windows.Forms.TextBox
    Friend WithEvents btnEditCari As System.Windows.Forms.Button
    Friend WithEvents btnListen As System.Windows.Forms.Button
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvMain As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bw As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents cbListRooms As System.Windows.Forms.ComboBox
    Friend WithEvents btnGetPC As System.Windows.Forms.Button
    Friend WithEvents dgvView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrintPCs As System.Windows.Forms.Button
    Friend WithEvents btnDelPCs As System.Windows.Forms.Button
End Class

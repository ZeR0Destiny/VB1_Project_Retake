<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormScreenMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.users_lists = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_edit_user = New System.Windows.Forms.Button()
        Me.btn_single_user = New System.Windows.Forms.Button()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.users_lists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'users_lists
        '
        Me.users_lists.AllowUserToAddRows = False
        Me.users_lists.AllowUserToDeleteRows = False
        Me.users_lists.AllowUserToResizeColumns = False
        Me.users_lists.AllowUserToResizeRows = False
        Me.users_lists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.users_lists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.users_lists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.users_lists.Location = New System.Drawing.Point(32, 83)
        Me.users_lists.Name = "users_lists"
        Me.users_lists.Size = New System.Drawing.Size(731, 330)
        Me.users_lists.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(97, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(315, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Users List"
        '
        'btn_edit_user
        '
        Me.btn_edit_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_edit_user.Location = New System.Drawing.Point(344, 428)
        Me.btn_edit_user.Name = "btn_edit_user"
        Me.btn_edit_user.Size = New System.Drawing.Size(119, 31)
        Me.btn_edit_user.TabIndex = 3
        Me.btn_edit_user.Text = "Edit User"
        Me.btn_edit_user.UseVisualStyleBackColor = True
        '
        'btn_single_user
        '
        Me.btn_single_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_single_user.Location = New System.Drawing.Point(344, 428)
        Me.btn_single_user.Name = "btn_single_user"
        Me.btn_single_user.Size = New System.Drawing.Size(119, 31)
        Me.btn_single_user.TabIndex = 4
        Me.btn_single_user.Text = "User Info"
        Me.btn_single_user.UseVisualStyleBackColor = True
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VideoToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VideoToolStripMenuItem.Text = "Video"
        '
        'ScreenMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 471)
        Me.Controls.Add(Me.btn_single_user)
        Me.Controls.Add(Me.btn_edit_user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.users_lists)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ScreenMain"
        Me.Text = "Form1"
        CType(Me.users_lists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents users_lists As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_edit_user As Button
    Friend WithEvents btn_single_user As Button
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideoToolStripMenuItem As ToolStripMenuItem
End Class

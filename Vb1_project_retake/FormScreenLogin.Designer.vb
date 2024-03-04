<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormScreenLogin
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
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.btn_login.Location = New System.Drawing.Point(229, 315)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(111, 42)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(207, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Movie App"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label2.Location = New System.Drawing.Point(95, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label3.Location = New System.Drawing.Point(95, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 37)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Password"
        '
        'tb_username
        '
        Me.tb_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.tb_username.Location = New System.Drawing.Point(328, 174)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(166, 32)
        Me.tb_username.TabIndex = 6
        '
        'tb_password
        '
        Me.tb_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.tb_password.Location = New System.Drawing.Point(328, 241)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.Size = New System.Drawing.Size(166, 32)
        Me.tb_password.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(589, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ScreenLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 421)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "ScreenLogin"
        Me.Text = "ScreenLogin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_username As TextBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class

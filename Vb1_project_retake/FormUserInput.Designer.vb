<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUserInput
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tb_address = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.tb_firstname = New System.Windows.Forms.TextBox()
        Me.tb_lastname = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_admin = New System.Windows.Forms.RadioButton()
        Me.rb_user = New System.Windows.Forms.RadioButton()
        Me.tb_telephone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(439, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.GoBackToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'GoBackToolStripMenuItem
        '
        Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
        Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GoBackToolStripMenuItem.Text = "Go Back"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.tb_address, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.NumericUpDown1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_username, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_password, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_firstname, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_lastname, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_telephone, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(41, 107)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(348, 328)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'tb_address
        '
        Me.tb_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tb_address.Location = New System.Drawing.Point(112, 208)
        Me.tb_address.Name = "tb_address"
        Me.tb_address.Size = New System.Drawing.Size(191, 26)
        Me.tb_address.TabIndex = 11
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.NumericUpDown1.Location = New System.Drawing.Point(112, 167)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(82, 26)
        Me.NumericUpDown1.TabIndex = 2
        Me.NumericUpDown1.Value = New Decimal(New Integer() {18, 0, 0, 0})
        '
        'tb_username
        '
        Me.tb_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tb_username.Location = New System.Drawing.Point(112, 3)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(191, 26)
        Me.tb_username.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Firstname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label4.Location = New System.Drawing.Point(3, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lastname"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label6.Location = New System.Drawing.Point(3, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label7.Location = New System.Drawing.Point(3, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Telephone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label8.Location = New System.Drawing.Point(3, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 24)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Level"
        '
        'tb_password
        '
        Me.tb_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tb_password.Location = New System.Drawing.Point(112, 44)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.Size = New System.Drawing.Size(191, 26)
        Me.tb_password.TabIndex = 8
        '
        'tb_firstname
        '
        Me.tb_firstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tb_firstname.Location = New System.Drawing.Point(112, 85)
        Me.tb_firstname.Name = "tb_firstname"
        Me.tb_firstname.Size = New System.Drawing.Size(191, 26)
        Me.tb_firstname.TabIndex = 9
        '
        'tb_lastname
        '
        Me.tb_lastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tb_lastname.Location = New System.Drawing.Point(112, 126)
        Me.tb_lastname.Name = "tb_lastname"
        Me.tb_lastname.Size = New System.Drawing.Size(191, 26)
        Me.tb_lastname.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_admin)
        Me.GroupBox1.Controls.Add(Me.rb_user)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 35)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'rb_admin
        '
        Me.rb_admin.AutoSize = True
        Me.rb_admin.Location = New System.Drawing.Point(120, 12)
        Me.rb_admin.Name = "rb_admin"
        Me.rb_admin.Size = New System.Drawing.Size(54, 17)
        Me.rb_admin.TabIndex = 1
        Me.rb_admin.Text = "Admin"
        Me.rb_admin.UseVisualStyleBackColor = True
        '
        'rb_user
        '
        Me.rb_user.AutoSize = True
        Me.rb_user.Checked = True
        Me.rb_user.Location = New System.Drawing.Point(35, 12)
        Me.rb_user.Name = "rb_user"
        Me.rb_user.Size = New System.Drawing.Size(47, 17)
        Me.rb_user.TabIndex = 0
        Me.rb_user.TabStop = True
        Me.rb_user.Text = "User"
        Me.rb_user.UseVisualStyleBackColor = True
        '
        'tb_telephone
        '
        Me.tb_telephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.tb_telephone.Location = New System.Drawing.Point(112, 249)
        Me.tb_telephone.Name = "tb_telephone"
        Me.tb_telephone.Size = New System.Drawing.Size(191, 26)
        Me.tb_telephone.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label5.Location = New System.Drawing.Point(3, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Age"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label9.Location = New System.Drawing.Point(123, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 37)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "New User"
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_save.Location = New System.Drawing.Point(153, 453)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(107, 35)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label10.Location = New System.Drawing.Point(123, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 37)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "User Profile"
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_update.Location = New System.Drawing.Point(153, 453)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(107, 35)
        Me.btn_update.TabIndex = 5
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'UserInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 510)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UserInput"
        Me.Text = "UserInput"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoBackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tb_username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tb_password As TextBox
    Friend WithEvents tb_firstname As TextBox
    Friend WithEvents tb_lastname As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_admin As RadioButton
    Friend WithEvents rb_user As RadioButton
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents tb_address As TextBox
    Friend WithEvents tb_telephone As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents btn_update As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
End Class

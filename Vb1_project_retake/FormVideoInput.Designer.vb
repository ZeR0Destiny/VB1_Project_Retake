<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVideoInput
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tb_Title = New System.Windows.Forms.TextBox()
        Me.Num_Year = New System.Windows.Forms.NumericUpDown()
        Me.Num_Rating = New System.Windows.Forms.NumericUpDown()
        Me.Cb_Rated = New System.Windows.Forms.ComboBox()
        Me.Tb_duration = New System.Windows.Forms.TextBox()
        Me.Genre_Checklist = New System.Windows.Forms.CheckedListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoBackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Add_Movie = New System.Windows.Forms.Button()
        Me.Tb_Cast1 = New System.Windows.Forms.TextBox()
        Me.Tb_Cast2 = New System.Windows.Forms.TextBox()
        Me.Tb_Cast3 = New System.Windows.Forms.TextBox()
        Me.Tb_Cast4 = New System.Windows.Forms.TextBox()
        Me.Tb_Cast5 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Tb_as_cast1 = New System.Windows.Forms.TextBox()
        Me.Tb_as_cast5 = New System.Windows.Forms.TextBox()
        Me.Tb_as_cast2 = New System.Windows.Forms.TextBox()
        Me.Tb_as_cast4 = New System.Windows.Forms.TextBox()
        Me.Tb_as_cast3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Btn_update_movie = New System.Windows.Forms.Button()
        CType(Me.Num_Year, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Rating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!)
        Me.Label1.Location = New System.Drawing.Point(248, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add New Movie"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label2.Location = New System.Drawing.Point(48, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label3.Location = New System.Drawing.Point(48, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label4.Location = New System.Drawing.Point(48, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Rating"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label5.Location = New System.Drawing.Point(48, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Rated"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label6.Location = New System.Drawing.Point(48, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 26)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Duration"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label7.Location = New System.Drawing.Point(48, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Genre"
        '
        'Tb_Title
        '
        Me.Tb_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_Title.Location = New System.Drawing.Point(171, 85)
        Me.Tb_Title.Name = "Tb_Title"
        Me.Tb_Title.Size = New System.Drawing.Size(163, 26)
        Me.Tb_Title.TabIndex = 7
        '
        'Num_Year
        '
        Me.Num_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Num_Year.Location = New System.Drawing.Point(171, 138)
        Me.Num_Year.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.Num_Year.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        Me.Num_Year.Name = "Num_Year"
        Me.Num_Year.Size = New System.Drawing.Size(120, 26)
        Me.Num_Year.TabIndex = 8
        Me.Num_Year.Value = New Decimal(New Integer() {1990, 0, 0, 0})
        '
        'Num_Rating
        '
        Me.Num_Rating.DecimalPlaces = 1
        Me.Num_Rating.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Num_Rating.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.Num_Rating.Location = New System.Drawing.Point(171, 193)
        Me.Num_Rating.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Num_Rating.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Num_Rating.Name = "Num_Rating"
        Me.Num_Rating.Size = New System.Drawing.Size(120, 26)
        Me.Num_Rating.TabIndex = 9
        Me.Num_Rating.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Cb_Rated
        '
        Me.Cb_Rated.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Cb_Rated.FormattingEnabled = True
        Me.Cb_Rated.Items.AddRange(New Object() {"G", "PG", "PG-13", "R", "NC-17"})
        Me.Cb_Rated.Location = New System.Drawing.Point(171, 244)
        Me.Cb_Rated.Name = "Cb_Rated"
        Me.Cb_Rated.Size = New System.Drawing.Size(121, 28)
        Me.Cb_Rated.TabIndex = 10
        '
        'Tb_duration
        '
        Me.Tb_duration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_duration.Location = New System.Drawing.Point(171, 294)
        Me.Tb_duration.Name = "Tb_duration"
        Me.Tb_duration.Size = New System.Drawing.Size(100, 26)
        Me.Tb_duration.TabIndex = 11
        '
        'Genre_Checklist
        '
        Me.Genre_Checklist.CheckOnClick = True
        Me.Genre_Checklist.FormattingEnabled = True
        Me.Genre_Checklist.Items.AddRange(New Object() {"Action", "Adventure", "Crime", "Drama", "Comedy", "Historical", "Horror", "Sci-Fi", "Fantasy", "Family"})
        Me.Genre_Checklist.Location = New System.Drawing.Point(171, 344)
        Me.Genre_Checklist.Name = "Genre_Checklist"
        Me.Genre_Checklist.Size = New System.Drawing.Size(133, 124)
        Me.Genre_Checklist.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(908, 24)
        Me.MenuStrip1.TabIndex = 13
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
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'GoBackToolStripMenuItem
        '
        Me.GoBackToolStripMenuItem.Name = "GoBackToolStripMenuItem"
        Me.GoBackToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.GoBackToolStripMenuItem.Text = "Go Back"
        '
        'Add_Movie
        '
        Me.Add_Movie.Location = New System.Drawing.Point(493, 428)
        Me.Add_Movie.Name = "Add_Movie"
        Me.Add_Movie.Size = New System.Drawing.Size(121, 24)
        Me.Add_Movie.TabIndex = 14
        Me.Add_Movie.Text = "Add Movie"
        Me.Add_Movie.UseVisualStyleBackColor = True
        '
        'Tb_Cast1
        '
        Me.Tb_Cast1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_Cast1.Location = New System.Drawing.Point(111, 42)
        Me.Tb_Cast1.Name = "Tb_Cast1"
        Me.Tb_Cast1.Size = New System.Drawing.Size(162, 26)
        Me.Tb_Cast1.TabIndex = 16
        '
        'Tb_Cast2
        '
        Me.Tb_Cast2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_Cast2.Location = New System.Drawing.Point(111, 94)
        Me.Tb_Cast2.Name = "Tb_Cast2"
        Me.Tb_Cast2.Size = New System.Drawing.Size(162, 26)
        Me.Tb_Cast2.TabIndex = 17
        '
        'Tb_Cast3
        '
        Me.Tb_Cast3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_Cast3.Location = New System.Drawing.Point(111, 147)
        Me.Tb_Cast3.Name = "Tb_Cast3"
        Me.Tb_Cast3.Size = New System.Drawing.Size(162, 26)
        Me.Tb_Cast3.TabIndex = 18
        '
        'Tb_Cast4
        '
        Me.Tb_Cast4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_Cast4.Location = New System.Drawing.Point(111, 201)
        Me.Tb_Cast4.Name = "Tb_Cast4"
        Me.Tb_Cast4.Size = New System.Drawing.Size(162, 26)
        Me.Tb_Cast4.TabIndex = 19
        '
        'Tb_Cast5
        '
        Me.Tb_Cast5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_Cast5.Location = New System.Drawing.Point(111, 253)
        Me.Tb_Cast5.Name = "Tb_Cast5"
        Me.Tb_Cast5.Size = New System.Drawing.Size(162, 26)
        Me.Tb_Cast5.TabIndex = 20
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Tb_as_cast1)
        Me.GroupBox1.Controls.Add(Me.Tb_as_cast5)
        Me.GroupBox1.Controls.Add(Me.Tb_as_cast2)
        Me.GroupBox1.Controls.Add(Me.Tb_as_cast4)
        Me.GroupBox1.Controls.Add(Me.Tb_as_cast3)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Tb_Cast1)
        Me.GroupBox1.Controls.Add(Me.Tb_Cast5)
        Me.GroupBox1.Controls.Add(Me.Tb_Cast2)
        Me.GroupBox1.Controls.Add(Me.Tb_Cast4)
        Me.GroupBox1.Controls.Add(Me.Tb_Cast3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(368, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 314)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Top 5 Casts"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(290, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 20)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "As"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(290, 204)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 20)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "As"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(290, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 20)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "As"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(290, 97)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "As"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(290, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "As"
        '
        'Tb_as_cast1
        '
        Me.Tb_as_cast1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_as_cast1.Location = New System.Drawing.Point(335, 42)
        Me.Tb_as_cast1.Name = "Tb_as_cast1"
        Me.Tb_as_cast1.Size = New System.Drawing.Size(162, 26)
        Me.Tb_as_cast1.TabIndex = 26
        '
        'Tb_as_cast5
        '
        Me.Tb_as_cast5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_as_cast5.Location = New System.Drawing.Point(335, 253)
        Me.Tb_as_cast5.Name = "Tb_as_cast5"
        Me.Tb_as_cast5.Size = New System.Drawing.Size(162, 26)
        Me.Tb_as_cast5.TabIndex = 30
        '
        'Tb_as_cast2
        '
        Me.Tb_as_cast2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_as_cast2.Location = New System.Drawing.Point(335, 94)
        Me.Tb_as_cast2.Name = "Tb_as_cast2"
        Me.Tb_as_cast2.Size = New System.Drawing.Size(162, 26)
        Me.Tb_as_cast2.TabIndex = 27
        '
        'Tb_as_cast4
        '
        Me.Tb_as_cast4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_as_cast4.Location = New System.Drawing.Point(335, 201)
        Me.Tb_as_cast4.Name = "Tb_as_cast4"
        Me.Tb_as_cast4.Size = New System.Drawing.Size(162, 26)
        Me.Tb_as_cast4.TabIndex = 29
        '
        'Tb_as_cast3
        '
        Me.Tb_as_cast3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Tb_as_cast3.Location = New System.Drawing.Point(335, 147)
        Me.Tb_as_cast3.Name = "Tb_as_cast3"
        Me.Tb_as_cast3.Size = New System.Drawing.Size(162, 26)
        Me.Tb_as_cast3.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "5th Cast"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "4th Cast"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "3rd Cast"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "2nd Cast"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "1st Cast"
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
        'Btn_update_movie
        '
        Me.Btn_update_movie.Location = New System.Drawing.Point(631, 428)
        Me.Btn_update_movie.Name = "Btn_update_movie"
        Me.Btn_update_movie.Size = New System.Drawing.Size(121, 24)
        Me.Btn_update_movie.TabIndex = 22
        Me.Btn_update_movie.Text = "Update Movie"
        Me.Btn_update_movie.UseVisualStyleBackColor = True
        '
        'FormVideoInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 494)
        Me.Controls.Add(Me.Btn_update_movie)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Add_Movie)
        Me.Controls.Add(Me.Genre_Checklist)
        Me.Controls.Add(Me.Tb_duration)
        Me.Controls.Add(Me.Cb_Rated)
        Me.Controls.Add(Me.Num_Rating)
        Me.Controls.Add(Me.Num_Year)
        Me.Controls.Add(Me.Tb_Title)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormVideoInput"
        Me.Text = "FormVideoInput"
        CType(Me.Num_Year, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Rating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Tb_Title As TextBox
    Friend WithEvents Num_Year As NumericUpDown
    Friend WithEvents Num_Rating As NumericUpDown
    Friend WithEvents Cb_Rated As ComboBox
    Friend WithEvents Tb_duration As TextBox
    Friend WithEvents Genre_Checklist As CheckedListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoBackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Add_Movie As Button
    Friend WithEvents Tb_Cast1 As TextBox
    Friend WithEvents Tb_Cast2 As TextBox
    Friend WithEvents Tb_Cast3 As TextBox
    Friend WithEvents Tb_Cast4 As TextBox
    Friend WithEvents Tb_Cast5 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Tb_as_cast1 As TextBox
    Friend WithEvents Tb_as_cast5 As TextBox
    Friend WithEvents Tb_as_cast2 As TextBox
    Friend WithEvents Tb_as_cast4 As TextBox
    Friend WithEvents Tb_as_cast3 As TextBox
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents Btn_update_movie As Button
End Class

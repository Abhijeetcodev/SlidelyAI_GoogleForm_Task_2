Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    'Required by the Windows Form Designer
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGithub = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.btnStopwatch = New System.Windows.Forms.Button()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.tableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(18, 14)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(608, 29)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "ABhijeet Singh, Slidely Task 2 - Create Submission"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Location = New System.Drawing.Point(4, 0)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(154, 46)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEmail.Location = New System.Drawing.Point(4, 46)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(154, 46)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPhone.Location = New System.Drawing.Point(4, 92)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(154, 46)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone Num:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGithub
        '
        Me.lblGithub.AutoSize = True
        Me.lblGithub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGithub.Location = New System.Drawing.Point(4, 138)
        Me.lblGithub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(154, 47)
        Me.lblGithub.TabIndex = 7
        Me.lblGithub.Text = "Github Link For Task 2:"
        Me.lblGithub.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtName.Location = New System.Drawing.Point(166, 5)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(370, 26)
        Me.txtName.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmail.Location = New System.Drawing.Point(166, 51)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(370, 26)
        Me.txtEmail.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPhone.Location = New System.Drawing.Point(166, 97)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(370, 26)
        Me.txtPhone.TabIndex = 6
        '
        'txtGithub
        '
        Me.txtGithub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtGithub.Location = New System.Drawing.Point(166, 143)
        Me.txtGithub.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(370, 26)
        Me.txtGithub.TabIndex = 8
        '
        'btnStopwatch
        '
        Me.btnStopwatch.BackColor = System.Drawing.Color.Yellow
        Me.btnStopwatch.Location = New System.Drawing.Point(24, 258)
        Me.btnStopwatch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStopwatch.Name = "btnStopwatch"
        Me.btnStopwatch.Size = New System.Drawing.Size(225, 46)
        Me.btnStopwatch.TabIndex = 9
        Me.btnStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Me.btnStopwatch.UseVisualStyleBackColor = False
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.BackColor = System.Drawing.Color.DarkGray
        Me.lblStopwatch.Location = New System.Drawing.Point(393, 271)
        Me.lblStopwatch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(71, 20)
        Me.lblStopwatch.TabIndex = 10
        Me.lblStopwatch.Text = "00:00:00"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(210, 314)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(180, 46)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'tableLayoutPanel
        '
        Me.tableLayoutPanel.ColumnCount = 2
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.tableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tableLayoutPanel.Controls.Add(Me.lblName, 0, 0)
        Me.tableLayoutPanel.Controls.Add(Me.txtName, 1, 0)
        Me.tableLayoutPanel.Controls.Add(Me.lblEmail, 0, 1)
        Me.tableLayoutPanel.Controls.Add(Me.txtEmail, 1, 1)
        Me.tableLayoutPanel.Controls.Add(Me.lblPhone, 0, 2)
        Me.tableLayoutPanel.Controls.Add(Me.txtPhone, 1, 2)
        Me.tableLayoutPanel.Controls.Add(Me.lblGithub, 0, 3)
        Me.tableLayoutPanel.Controls.Add(Me.txtGithub, 1, 3)
        Me.tableLayoutPanel.Location = New System.Drawing.Point(24, 65)
        Me.tableLayoutPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tableLayoutPanel.Name = "tableLayoutPanel"
        Me.tableLayoutPanel.RowCount = 4
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tableLayoutPanel.Size = New System.Drawing.Size(540, 185)
        Me.tableLayoutPanel.TabIndex = 1
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 385)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.btnStopwatch)
        Me.Controls.Add(Me.tableLayoutPanel)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission"
        Me.tableLayoutPanel.ResumeLayout(False)
        Me.tableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtName As System.Windows.Forms.TextBox
    Private WithEvents txtEmail As System.Windows.Forms.TextBox
    Private WithEvents txtPhone As System.Windows.Forms.TextBox
    Private WithEvents txtGithub As System.Windows.Forms.TextBox
    Private WithEvents btnStopwatch As System.Windows.Forms.Button
    Private WithEvents lblStopwatch As System.Windows.Forms.Label
    Private WithEvents btnSubmit As System.Windows.Forms.Button
    Private WithEvents lblTitle As System.Windows.Forms.Label
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents lblEmail As System.Windows.Forms.Label
    Private WithEvents lblPhone As System.Windows.Forms.Label
    Private WithEvents lblGithub As System.Windows.Forms.Label
    Private WithEvents tableLayoutPanel As System.Windows.Forms.TableLayoutPanel
End Class

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
        Me.components = New System.ComponentModel.Container
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Button1 = New System.Windows.Forms.Button
        Me.serverBtn = New System.Windows.Forms.Button
        Me.restarterOptions = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.intervalTypeDropdown = New System.Windows.Forms.ComboBox
        Me.intervalUpDown = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.pathBtn = New System.Windows.Forms.Button
        Me.pathTxt = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.timerLabel = New System.Windows.Forms.Label
        Me.backupStatusLabel = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.restartStatusLabel = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.backupBtn = New System.Windows.Forms.Button
        Me.backupOptions = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.wholeServerRadio = New System.Windows.Forms.RadioButton
        Me.dbRadio = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.outputTxt = New System.Windows.Forms.TextBox
        Me.inputTxt = New System.Windows.Forms.TextBox
        Me.outputBtn = New System.Windows.Forms.Button
        Me.inputBtn = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.logBox = New System.Windows.Forms.RichTextBox
        Me.logMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToTextFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.restartTimer = New System.Windows.Forms.Timer(Me.components)
        Me.timerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.restarterOptions.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.intervalUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.backupOptions.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.logMenu.SuspendLayout()
        Me.notifyMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(358, 265)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.serverBtn)
        Me.TabPage1.Controls.Add(Me.restarterOptions)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(350, 239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Restarter"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "About"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'serverBtn
        '
        Me.serverBtn.Location = New System.Drawing.Point(138, 204)
        Me.serverBtn.Name = "serverBtn"
        Me.serverBtn.Size = New System.Drawing.Size(75, 23)
        Me.serverBtn.TabIndex = 2
        Me.serverBtn.Text = "Start Server"
        Me.serverBtn.UseVisualStyleBackColor = True
        '
        'restarterOptions
        '
        Me.restarterOptions.Controls.Add(Me.GroupBox3)
        Me.restarterOptions.Controls.Add(Me.pathBtn)
        Me.restarterOptions.Controls.Add(Me.pathTxt)
        Me.restarterOptions.Controls.Add(Me.Label1)
        Me.restarterOptions.Location = New System.Drawing.Point(24, 83)
        Me.restarterOptions.Name = "restarterOptions"
        Me.restarterOptions.Size = New System.Drawing.Size(303, 115)
        Me.restarterOptions.TabIndex = 1
        Me.restarterOptions.TabStop = False
        Me.restarterOptions.Text = "Options"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.intervalTypeDropdown)
        Me.GroupBox3.Controls.Add(Me.intervalUpDown)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 60)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(286, 48)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Automatic Restart"
        '
        'intervalTypeDropdown
        '
        Me.intervalTypeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.intervalTypeDropdown.FormattingEnabled = True
        Me.intervalTypeDropdown.Items.AddRange(New Object() {"Minute(s)", "Hour(s)", "Day(s)"})
        Me.intervalTypeDropdown.Location = New System.Drawing.Point(182, 16)
        Me.intervalTypeDropdown.Name = "intervalTypeDropdown"
        Me.intervalTypeDropdown.Size = New System.Drawing.Size(91, 21)
        Me.intervalTypeDropdown.TabIndex = 5
        '
        'intervalUpDown
        '
        Me.intervalUpDown.Location = New System.Drawing.Point(112, 16)
        Me.intervalUpDown.Name = "intervalUpDown"
        Me.intervalUpDown.Size = New System.Drawing.Size(63, 20)
        Me.intervalUpDown.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Restart once every:"
        '
        'pathBtn
        '
        Me.pathBtn.Location = New System.Drawing.Point(269, 31)
        Me.pathBtn.Name = "pathBtn"
        Me.pathBtn.Size = New System.Drawing.Size(28, 23)
        Me.pathBtn.TabIndex = 2
        Me.pathBtn.Text = "..."
        Me.pathBtn.UseVisualStyleBackColor = True
        '
        'pathTxt
        '
        Me.pathTxt.Location = New System.Drawing.Point(9, 32)
        Me.pathTxt.Name = "pathTxt"
        Me.pathTxt.Size = New System.Drawing.Size(255, 20)
        Me.pathTxt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Server Path"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.timerLabel)
        Me.GroupBox1.Controls.Add(Me.backupStatusLabel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.restartStatusLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status"
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.Location = New System.Drawing.Point(8, 52)
        Me.timerLabel.Name = "timerLabel"
        Me.timerLabel.Size = New System.Drawing.Size(69, 13)
        Me.timerLabel.TabIndex = 4
        Me.timerLabel.Text = "Next Restart:"
        '
        'backupStatusLabel
        '
        Me.backupStatusLabel.AutoSize = True
        Me.backupStatusLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backupStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.backupStatusLabel.Location = New System.Drawing.Point(127, 25)
        Me.backupStatusLabel.Name = "backupStatusLabel"
        Me.backupStatusLabel.Size = New System.Drawing.Size(75, 23)
        Me.backupStatusLabel.TabIndex = 3
        Me.backupStatusLabel.Text = "Backup"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(103, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "/"
        '
        'restartStatusLabel
        '
        Me.restartStatusLabel.AutoSize = True
        Me.restartStatusLabel.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restartStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.restartStatusLabel.Location = New System.Drawing.Point(4, 25)
        Me.restartStatusLabel.Name = "restartStatusLabel"
        Me.restartStatusLabel.Size = New System.Drawing.Size(93, 23)
        Me.restartStatusLabel.TabIndex = 0
        Me.restartStatusLabel.Text = "Restarter"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.backupBtn)
        Me.TabPage2.Controls.Add(Me.backupOptions)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(350, 239)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Backup"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(76, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "File will backup when the server restarts."
        '
        'backupBtn
        '
        Me.backupBtn.Location = New System.Drawing.Point(138, 173)
        Me.backupBtn.Name = "backupBtn"
        Me.backupBtn.Size = New System.Drawing.Size(75, 36)
        Me.backupBtn.TabIndex = 2
        Me.backupBtn.Text = "Enable Backup"
        Me.backupBtn.UseVisualStyleBackColor = True
        '
        'backupOptions
        '
        Me.backupOptions.Controls.Add(Me.GroupBox5)
        Me.backupOptions.Controls.Add(Me.Label7)
        Me.backupOptions.Controls.Add(Me.Label6)
        Me.backupOptions.Controls.Add(Me.outputTxt)
        Me.backupOptions.Controls.Add(Me.inputTxt)
        Me.backupOptions.Controls.Add(Me.outputBtn)
        Me.backupOptions.Controls.Add(Me.inputBtn)
        Me.backupOptions.Location = New System.Drawing.Point(21, 6)
        Me.backupOptions.Name = "backupOptions"
        Me.backupOptions.Size = New System.Drawing.Size(309, 161)
        Me.backupOptions.TabIndex = 1
        Me.backupOptions.TabStop = False
        Me.backupOptions.Text = "Options"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.wholeServerRadio)
        Me.GroupBox5.Controls.Add(Me.dbRadio)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(177, 43)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Backup Type"
        '
        'wholeServerRadio
        '
        Me.wholeServerRadio.AutoSize = True
        Me.wholeServerRadio.Location = New System.Drawing.Point(83, 19)
        Me.wholeServerRadio.Name = "wholeServerRadio"
        Me.wholeServerRadio.Size = New System.Drawing.Size(90, 17)
        Me.wholeServerRadio.TabIndex = 0
        Me.wholeServerRadio.Text = "Whole Server"
        Me.wholeServerRadio.UseVisualStyleBackColor = True
        '
        'dbRadio
        '
        Me.dbRadio.AutoSize = True
        Me.dbRadio.Checked = True
        Me.dbRadio.Location = New System.Drawing.Point(6, 19)
        Me.dbRadio.Name = "dbRadio"
        Me.dbRadio.Size = New System.Drawing.Size(71, 17)
        Me.dbRadio.TabIndex = 0
        Me.dbRadio.TabStop = True
        Me.dbRadio.Text = "Database"
        Me.dbRadio.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Output Directory"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "File to backup"
        '
        'outputTxt
        '
        Me.outputTxt.Location = New System.Drawing.Point(5, 127)
        Me.outputTxt.Name = "outputTxt"
        Me.outputTxt.Size = New System.Drawing.Size(260, 20)
        Me.outputTxt.TabIndex = 1
        '
        'inputTxt
        '
        Me.inputTxt.Location = New System.Drawing.Point(5, 84)
        Me.inputTxt.Name = "inputTxt"
        Me.inputTxt.Size = New System.Drawing.Size(260, 20)
        Me.inputTxt.TabIndex = 1
        '
        'outputBtn
        '
        Me.outputBtn.Location = New System.Drawing.Point(272, 126)
        Me.outputBtn.Name = "outputBtn"
        Me.outputBtn.Size = New System.Drawing.Size(30, 23)
        Me.outputBtn.TabIndex = 0
        Me.outputBtn.Text = "..."
        Me.outputBtn.UseVisualStyleBackColor = True
        '
        'inputBtn
        '
        Me.inputBtn.Location = New System.Drawing.Point(271, 83)
        Me.inputBtn.Name = "inputBtn"
        Me.inputBtn.Size = New System.Drawing.Size(30, 23)
        Me.inputBtn.TabIndex = 0
        Me.inputBtn.Text = "..."
        Me.inputBtn.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.logBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(350, 239)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Log"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Right-Click the log"
        '
        'logBox
        '
        Me.logBox.ContextMenuStrip = Me.logMenu
        Me.logBox.Location = New System.Drawing.Point(0, 0)
        Me.logBox.Name = "logBox"
        Me.logBox.ReadOnly = True
        Me.logBox.Size = New System.Drawing.Size(254, 239)
        Me.logBox.TabIndex = 0
        Me.logBox.Text = ""
        '
        'logMenu
        '
        Me.logMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToTextFileToolStripMenuItem, Me.ClearLogToolStripMenuItem})
        Me.logMenu.Name = "logMenu"
        Me.logMenu.Size = New System.Drawing.Size(159, 48)
        '
        'SaveToTextFileToolStripMenuItem
        '
        Me.SaveToTextFileToolStripMenuItem.Name = "SaveToTextFileToolStripMenuItem"
        Me.SaveToTextFileToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.SaveToTextFileToolStripMenuItem.Text = "Save to Text File"
        '
        'ClearLogToolStripMenuItem
        '
        Me.ClearLogToolStripMenuItem.Name = "ClearLogToolStripMenuItem"
        Me.ClearLogToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ClearLogToolStripMenuItem.Text = "Clear Log"
        '
        'restartTimer
        '
        '
        'timerTimer
        '
        Me.timerTimer.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.notifyMenu
        Me.NotifyIcon1.Text = "OT Auto Restarter"
        '
        'notifyMenu
        '
        Me.notifyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowProgramToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.notifyMenu.Name = "notifyMenu"
        Me.notifyMenu.Size = New System.Drawing.Size(153, 48)
        '
        'ShowProgramToolStripMenuItem
        '
        Me.ShowProgramToolStripMenuItem.Name = "ShowProgramToolStripMenuItem"
        Me.ShowProgramToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShowProgramToolStripMenuItem.Text = "Show Program"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "for more options"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 265)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OT Auto Restarter"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.restarterOptions.ResumeLayout(False)
        Me.restarterOptions.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.intervalUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.backupOptions.ResumeLayout(False)
        Me.backupOptions.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.logMenu.ResumeLayout(False)
        Me.notifyMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents pathBtn As System.Windows.Forms.Button
    Friend WithEvents restarterOptions As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents backupStatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents restartStatusLabel As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents pathTxt As System.Windows.Forms.TextBox
    Friend WithEvents serverBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents intervalTypeDropdown As System.Windows.Forms.ComboBox
    Friend WithEvents intervalUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents backupOptions As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents wholeServerRadio As System.Windows.Forms.RadioButton
    Friend WithEvents dbRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents outputTxt As System.Windows.Forms.TextBox
    Friend WithEvents inputTxt As System.Windows.Forms.TextBox
    Friend WithEvents outputBtn As System.Windows.Forms.Button
    Friend WithEvents inputBtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents backupBtn As System.Windows.Forms.Button
    Friend WithEvents logBox As System.Windows.Forms.RichTextBox
    Friend WithEvents restartTimer As System.Windows.Forms.Timer
    Friend WithEvents timerTimer As System.Windows.Forms.Timer
    Friend WithEvents timerLabel As System.Windows.Forms.Label
    Friend WithEvents logMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveToTextFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents notifyMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class

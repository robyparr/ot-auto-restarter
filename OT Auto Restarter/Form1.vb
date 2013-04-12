Public Class Form1
#Region "Variables"
    Dim ext As String
    Dim processName As String

    ' Timer Variables
    Dim hour As Long
    Dim min As Long
    Dim sec As Long
#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Logs the application started.
        logBox.AppendText("[" + TimeOfDay + "]" + " OT Auto Restarter Started." + vbNewLine)
    End Sub

    Private Sub pathBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pathBtn.Click
        ' Creates a new OpenFileDialog
        Dim ofd As New OpenFileDialog

        ofd.CheckFileExists = True
        ofd.Title = "Select your Server file."
        ofd.Filter = "Executable Files (.exe) |*.exe"
        If ofd.ShowDialog = DialogResult.OK Then
            pathTxt.Text = ofd.FileName
        End If
    End Sub

    'Backup - Input File
    Private Sub inputBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputBtn.Click
        Dim ofd As Object

        ' If the 'DataBase' Radio Button is checked
        If dbRadio.Checked Then
            ' Creates a OpenFileDialog
            ofd = New OpenFileDialog()

            ofd.CheckFileExists = True
            ofd.Title = "Select the file to backup."
            ofd.Filter = "All Files |*.*"
            ofd.FilterIndex = 1

            If ofd.ShowDialog = DialogResult.OK Then
                inputTxt.Text = ofd.FileName

                ' Gets the extention of the file being backed-up
                Dim fileExt As String = inputTxt.Text
                Dim fileArray() As String = Split(fileExt, ".")
                ext = "." + fileArray(fileArray.Length - 1)
            End If
        Else ' Whole Server
            ' Creates a FolderBrowserDialog
            ofd = New FolderBrowserDialog()

            ' Sets the description
            ofd.description = "Select your Server's Folder."

            ' If the OK button is pressed.
            If ofd.showdialog() = DialogResult.OK Then
                inputTxt.Text = ofd.SelectedPath
            End If
        End If
    End Sub

    ' Backup - Output File
    Private Sub outputBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles outputBtn.Click
        Dim sfd As Object

        ' Database only
        If dbRadio.Checked Then
            sfd = New SaveFileDialog

            sfd.Filter = "All Files |*.*"
            sfd.Title = "Save backup"
            If sfd.ShowDialog = DialogResult.OK Then
                Dim fileDir As String = sfd.FileName
                Dim fileArray() As String = Split(fileDir, ".")
                outputTxt.Text = fileArray(0) + ext
            End If
        Else ' Whole Server
            sfd = New FolderBrowserDialog

            sfd.description = "Select where you want to save the backup."

            If sfd.ShowDialog() = DialogResult.OK Then
                outputTxt.Text = sfd.SelectedPath
            End If
        End If
    End Sub

    Private Sub backupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backupBtn.Click
        If backupBtn.Text = "Enable Backup" Then
            ' Sets up error messages
            If inputTxt.Text = Nothing Or outputTxt.Text = Nothing Then
                MessageBox.Show("Please fill everything out.", "OT Auto Restarter - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                ' Disables backup options
                backupOptions.Enabled = False

                ' Changes Backup Button's text.
                backupBtn.Text = "Disable Backup"
            End If
        Else
            ' Enables backup options
            backupOptions.Enabled = True

            ' Changes Backup Button's text.
            backupBtn.Text = "Enable Backup"
        End If
    End Sub

    Private Sub serverBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles serverBtn.Click
        If serverBtn.Text = "Start Server" Then
            ' Sets up error messages
            If pathTxt.Text = Nothing Then
                MessageBox.Show("Please select your servers .exe file.", "OT Auto Restarter - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf intervalUpDown.Value = 0 Or intervalTypeDropdown.Text = Nothing Then
                MessageBox.Show("Please set the restart interval.", "OT Auto Restarter - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                ' Sets the interval for the restart process
                Select Case intervalTypeDropdown.Text
                    Case "Minute(s)"
                        restartTimer.Interval = intervalUpDown.Value * 60000
                    Case "Hour(s)"
                        restartTimer.Interval = intervalUpDown.Value * 60000 * 60
                    Case "Day(s)"
                        restartTimer.Interval = intervalUpDown.Value * 60000 * 60 * 24
                End Select

                ' Starts the Server.
                Shell(pathTxt.Text, AppWinStyle.MinimizedFocus)
                'Dim ProcID As Integer = Shell(pathTxt.Text, AppWinStyle.MinimizedFocus)
                'AppActivate(ProcID)

                ' Starts the Process's and Timer
                restartTimer.Start()
                timerTimer.Start()

                ' Logs the server starting
                If backupBtn.Text = "Disable Backup" Then
                    logBox.AppendText("[" + TimeOfDay + "]" + " Restart & Backup Process Started." + vbNewLine)
                Else
                    logBox.AppendText("[" + TimeOfDay + "]" + " Restart Process Started." + vbNewLine)
                End If

                ' Changes the Server button text
                serverBtn.Text = "Stop Server"

                ' Changes status label's color
                restartStatusLabel.ForeColor = Color.Lime
                If backupBtn.Text = "Disable Backup" Then
                    backupStatusLabel.ForeColor = Color.Lime
                End If

                ' Disables all options & backup button
                restarterOptions.Enabled = False
                backupOptions.Enabled = False
                backupBtn.Enabled = False
            End If
        Else
            'Stops the process's and timer
            restartTimer.Stop()
            timerTimer.Stop()

            ' Gets the filename
            Dim fileName() As String = Split(pathTxt.Text, "\")
            processName = fileName(fileName.Length - 1)
            Dim meh() As String = Split(processName, ".")
            processName = meh(0)

            ' Stops the Server
            Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName(processName)
            For Each proc As System.Diagnostics.Process In pList
                proc.Kill()
            Next

            ' Logs the stopped process('s)
            If backupBtn.Text = "Disable Backup" Then
                logBox.AppendText("[" + TimeOfDay + "]" + " Restart & Backup Process Stopped." + vbNewLine)
            Else
                logBox.AppendText("[" + TimeOfDay + "]" + " Restart Process Stopped." + vbNewLine)
            End If

            ' Sets status color to red
            restartStatusLabel.ForeColor = Color.Red
            If backupBtn.Text = "Disable Backup" Then
                backupStatusLabel.ForeColor = Color.Red
            End If

            ' Enable Options
            backupBtn.Enabled = True
            restarterOptions.Enabled = True
            If backupBtn.Text <> "Disable Backup" Then
                backupOptions.Enabled = True
            Else
                backupOptions.Enabled = False
            End If

            ' Changes button text
            serverBtn.Text = "Start Server"
        End If

        ' Timer
        Select Case intervalTypeDropdown.Text
            Case "Minute(s)"
                hour = 0
                min = intervalUpDown.Value - 1
                sec = 59
            Case "Hour(s)"
                hour = intervalUpDown.Value - 1
                min = 59
                sec = 59
            Case "Day(s)"
                hour = intervalUpDown.Value * 24 - 1
                min = 59
                sec = 59
        End Select

    End Sub

    Private Sub restartTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restartTimer.Tick
        Try
            ' Stops the process
            restartTimer.Stop()

            ' Stops the server
            Dim pList() As System.Diagnostics.Process = System.Diagnostics.Process.GetProcessesByName(processName)
            For Each proc As System.Diagnostics.Process In pList
                proc.Kill()
            Next

            ' Checks to see if Backup is enabled
            If backupStatusLabel.ForeColor = Color.Lime Then
                ' Checks to see if its copying a file or directory
                If dbRadio.Checked Then
                    ' Copies the file.
                    My.Computer.FileSystem.CopyFile(inputTxt.Text, outputTxt.Text, True)
                Else
                    ' Copies the directory
                    My.Computer.FileSystem.CopyDirectory(inputTxt.Text, outputTxt.Text, True)
                End If
            End If

            ' Checks how to restart server
            If backupStatusLabel.ForeColor = Color.Lime Then
                If dbRadio.Checked Then
                    Shell(pathTxt.Text, AppWinStyle.MinimizedFocus, True, 5000)
                Else
                    Shell(pathTxt.Text, AppWinStyle.MinimizedFocus, True, 10000)
                End If
            Else
                Shell(pathTxt.Text, AppWinStyle.MinimizedFocus)
            End If

            ' Logs completed tasks.
            logBox.SelectionColor = Color.Green
            If backupStatusLabel.ForeColor = Color.Lime Then
                logBox.AppendText("[" + TimeOfDay + "]" + " Restart & Backup Completed." + vbNewLine)
            Else
                logBox.AppendText("[" + TimeOfDay + "]" + " Restart Process Completed." + vbNewLine)
            End If

            ' Timer
            Select Case intervalTypeDropdown.Text
                Case "Minute(s)"
                    hour = 0
                    min = intervalUpDown.Value - 1
                    sec = 59
                Case "Hour(s)"
                    hour = intervalUpDown.Value - 1
                    min = 59
                    sec = 59
                Case "Day(s)"
                    hour = intervalUpDown.Value * 24 - 1
                    min = 59
                    sec = 59
            End Select

            'Starts the Timer
            restartTimer.Start()
        Catch ex As Exception
            MessageBox.Show(ex.ToString + vbNewLine + vbNewLine + "Take a screenshot of this error and post it on the thread you got this from", "OT Auto Restarter - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            logBox.SelectionColor = Color.Red
            logBox.AppendText("[" + TimeOfDay + "]" + " An Error has occured!" + vbNewLine + "Process is shutting down.")

            ' Stops Process
            restartTimer.Stop()
            timerTimer.Stop()

            ' Sets status color to red
            restartStatusLabel.ForeColor = Color.Red
            If backupBtn.Text = "Disable Backup" Then
                backupStatusLabel.ForeColor = Color.Red
            End If

            ' Enable Options
            backupBtn.Enabled = True
            restarterOptions.Enabled = True
            If backupBtn.Text <> "Disable Backup" Then
                backupOptions.Enabled = True
            Else
                backupOptions.Enabled = False
            End If

            ' Changes button text
            serverBtn.Text = "Start Server"
        End Try
    End Sub

    Private Sub timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerTimer.Tick
        sec -= 1

        If sec = 0 Then
            If min > 0 Then
                min -= 1
                sec = 59
            ElseIf min = 0 Then
                If hour > 0 Then
                    hour -= 1
                    sec = 59
                ElseIf hour = 0 And min = 0 And sec = 0 Then
                    timerTimer.Stop()
                    timerTimer.Start()
                    Exit Sub
                End If
            End If
        End If

        timerLabel.Text = "Time till next restart: " + hour.ToString + ":" + min.ToString + ":" + sec.ToString

        timerTimer.Stop()
        timerTimer.Start()
    End Sub

    Private Sub SaveToTextFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToTextFileToolStripMenuItem.Click
        Dim sfd As New SaveFileDialog()

        sfd.Filter = "Text Files |*.txt"
        sfd.Title = "Save Log to TextFile"
        If sfd.ShowDialog = DialogResult.OK Then
            logBox.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub ClearLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearLogToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to clear the log?", "OT Auto Restarter", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            logBox.Clear()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
            NotifyIcon1.Icon = Me.Icon
            NotifyIcon1.Visible = True
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ShowProgramToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowProgramToolStripMenuItem.Click
        Me.Show()
        NotifyIcon1.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class

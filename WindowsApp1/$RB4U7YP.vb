Public Class Form1
    'Public Class variables to hold registry data
    'Game Variable
    Dim SaveGame1 As Byte()
    Dim SaveGame2 As Byte()
    'Cache Variables
    Dim SaveGame1Cache As Byte()
    Dim SaveGame2Cache As Byte()

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'Copy SaveGame0 in Registry into a variable 
            SaveGame1 = My.Computer.Registry.GetValue _
            ("HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It", "SaveGame0_h1867918426", Nothing)

            'Copy SaveGame1 in Registry into a variable
            SaveGame2 = My.Computer.Registry.GetValue _
            ("HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It", "SaveGame1_h1867918427", Nothing)

            'Cache data into seprate Registry (Computer\HKEY_CURRENT_USER\GettingOverItCheckpointTool)
            My.Computer.Registry.CurrentUser.CreateSubKey("GettingOverItCheckpointTool")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\GettingOverItCheckpointTool", "SaveGame0_h1867918426", SaveGame1)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\GettingOverItCheckpointTool", "SaveGame1_h1867918427", SaveGame2)

            'Confirm action
            MessageBox.Show("Checkpoint Saved.", "Save location")
        Catch ex As Exception
            MessageBox.Show("An error occured while saving checkpoint.", "Error")
        End Try
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            'Kill Task to load Checkpoint
            Shell("taskkill /F /IM GettingOverIt.exe")

            'Copy SaveGame0 Cache in Registry into a variable
            SaveGame1Cache = My.Computer.Registry.GetValue _
                ("HKEY_CURRENT_USER\GettingOverItCheckpointTool", "SaveGame0_h1867918426", Nothing)

            'Copy SaveGame1 Cache in Registry into a variable
            SaveGame2Cache = My.Computer.Registry.GetValue _
                ("HKEY_CURRENT_USER\GettingOverItCheckpointTool", "SaveGame1_h1867918427", Nothing)

            'Replace data into Save (Computer\HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It)
            My.Computer.Registry.CurrentUser.CreateSubKey("GettingOverItCheckpointTool")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It", "SaveGame0_h1867918426", SaveGame1Cache)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Bennett Foddy\Getting Over It", "SaveGame1_h1867918427", SaveGame2Cache)

            'Open Getting Over It
            Process.Start("steam://rungameid/240720")
        Catch ex As Exception
            MessageBox.Show("An error occured while loading checkpoint.", "Error")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears Cache
        Try
            If MessageBox.Show("Are you sure you want to clear cache?", "Clear cache", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                My.Computer.Registry.CurrentUser.DeleteSubKeyTree("GettingOverItCheckpointTool")
                MessageBox.Show("Cleared Cache.", "Clear cache")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured while clearing cache.", "Error")
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Resets game
        Try
            If MessageBox.Show("Are you sure you want to reset the game?", "Reset game", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                My.Computer.Registry.CurrentUser.DeleteSubKeyTree("Software\Bennett Foddy")
                MessageBox.Show("Reset complete.", "Reset game")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured while resetting the game.", "Error")
        End Try
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'Opens about form
        Form2.Show()
    End Sub

    Private Sub ForceQuitGameToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Kill Task to load Checkpoint
        Shell("taskkill /F /IM GettingOverIt.exe")
    End Sub

    Private Sub LaunchGameNormallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaunchGameNormallyToolStripMenuItem.Click
        'Open Getting Over It
        Process.Start("steam://rungameid/240720")
    End Sub
End Class
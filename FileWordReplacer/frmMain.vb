Public Class frmMain

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        frmInfo.Show()
    End Sub

    Private Sub btnFolderPath_Click(sender As Object, e As EventArgs) Handles btnFolderPath.Click
        ' Opens folder popup and sets folder path if ok is pressed
        If (fbdSelectFolder.ShowDialog() = DialogResult.OK) Then
            txtFolderPath.Text = fbdSelectFolder.SelectedPath
        End If

    End Sub

    Private Sub btnDestinationPath_Click(sender As Object, e As EventArgs) Handles btnDestinationPath.Click
        ' Opens folder popup and sets destination path if ok is pressed
        If (fbdSelectFolder.ShowDialog() = DialogResult.OK) Then
            txtDestinationPath.Text = fbdSelectFolder.SelectedPath
        End If
    End Sub

    Private Sub btnCopyAndConvert_Click(sender As Object, e As EventArgs) Handles btnCopyAndConvert.Click
        ' Copies files from folder path to destination path and renames their filename and contents based on the replacement word list
        Try
            If validateForm() Then
                Dim randomTempDestination As String = "39hg239v9zz293fh2937"
                ' Copy folder to temp location
                My.Computer.FileSystem.CopyDirectory(txtFolderPath.Text, txtDestinationPath.Text + randomTempDestination, False)
                renameFiles()
                ' Merge temp folder into destination folder
                My.Computer.FileSystem.MoveDirectory(txtDestinationPath.Text + randomTempDestination, txtDestinationPath.Text, True)
                frmPopup.lblPopupMessage.Text = "Success!"
            End If
        Catch ex As Exception
            frmPopup.lblPopupMessage.Text = "Something has gone wrong. Check there are no files to overwrite in destination path"
        Finally
            frmPopup.Show()
        End Try

    End Sub

    Private Function validateForm() As Boolean
        ' Validates form: If there are any errors it sets the popup value to said erros and returns false, else true

        If Not My.Computer.FileSystem.DirectoryExists(txtFolderPath.Text) Or txtFolderPath.Text = "" Then
            frmPopup.lblPopupMessage.Text = "Invalid folder path"
            Return False
        ElseIf Not My.Computer.FileSystem.DirectoryExists(txtDestinationPath.Text) Or txtDestinationPath.Text = "" Then
            frmPopup.lblPopupMessage.Text = "Invalid destination path"
            Return False
        ElseIf txtDestinationPath.Text = txtFolderPath.Text Then
            frmPopup.lblPopupMessage.Text = "Destination path and folder path cannot be the same"
            Return False
        ElseIf lbWords.Items().Count() <= 0 Then
            frmPopup.lblPopupMessage.Text = "List of replacement words is empty. Please add some"
            Return False
        End If

        Return True
    End Function

    Private Sub renameFiles()
        ' Renames from destination path all file's and folder filename and contents based on the replacement word list 
        Dim dirinfo As New System.IO.DirectoryInfo(txtDestinationPath.Text)
        Dim files() As System.IO.FileInfo

        files = dirinfo.GetFiles("*java", IO.SearchOption.AllDirectories)
        For Each file In files
            If file.Name.EndsWith(".java") Then
                renameFile(file)
            End If
        Next
    End Sub

    Private Sub renameFile(file As System.IO.FileInfo)
        ' Renames filename and its contents replacing all words from replacement word list
        Dim splittedWord(), oldWord, newWord As String

        ' Iterate though all replacement words
        For Each wordPair In lbWords.Items()
            ' Fetch original word and replacement
            splittedWord = Split(wordPair, ":")
            oldWord = splittedWord(0)
            newWord = splittedWord(1)

            ' Rename filename
            Dim newFileName = (file.DirectoryName + "\" + file.Name).Replace(oldWord, newWord)
            file.MoveTo(newFileName)

            ' Rename file content
            Dim fileReader As String = My.Computer.FileSystem.ReadAllText(newFileName).Replace(oldWord, newWord)
            My.Computer.FileSystem.WriteAllText(newFileName, fileReader, False)

        Next



    End Sub

    Private Sub txtReplacement_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtReplacement.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Convert.ToInt32(e.KeyChar) = Keys.Back Or Convert.ToInt32(e.KeyChar) = Keys.Space Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtWord_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtWord.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or Convert.ToInt32(e.KeyChar) = Keys.Back Or Convert.ToInt32(e.KeyChar) = Keys.Space Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lbWords.Items.Add(txtWord.Text + ":" + txtReplacement.Text)
        txtWord.Clear()
        txtReplacement.Clear()
        txtWord.Focus()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lbWords.SelectedIndex > -1 Then
            lbWords.Items.RemoveAt(lbWords.SelectedIndex)
        End If
    End Sub


End Class

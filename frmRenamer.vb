Imports System.IO

Public Class frmRenamer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        Dim dir As New DirectoryInfo(txtPath.Text)
        Dim fileNumber As Integer = 0
        For Each file As FileInfo In dir.GetFiles
            Dim fileName As String = file.FullName
            Dim newName As String
            If chkRenameFilesToNumbers.Checked Then
                newName = Path.Combine(file.DirectoryName, fileNumber.ToString)
                fileNumber += 1
            Else
                If chkRemoveExistingExtensions.Checked Then
                    newName = Path.Combine(file.DirectoryName, fileName.Split("."c)(0))
                Else
                    newName = fileName
                End If
            End If

            System.IO.File.Move(fileName, String.Format("{0}.{1}", newName, txtExtension.Text))
        Next
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSelectPath.Click
        Dim dlg As New FolderBrowserDialog
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtPath.Text = dlg.SelectedPath
        End If
    End Sub
End Class

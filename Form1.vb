Imports System.IO

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            folder_broswer.Description = "Select L2J Old Pack Folder"
            folder_broswer.ShowDialog()
            old_pack_url.Text = folder_broswer.SelectedPath()
            error_provider.SetError(Me.old_pack_url, String.Empty)
        Catch ex As Exception
            MsgBox("Cannot find the folder. Something going wrong : " & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            folder_broswer.Description = "Select L2J New Pack Folder"
            folder_broswer.ShowDialog()
            new_pack_url.Text = folder_broswer.SelectedPath()
            error_provider.SetError(Me.new_pack_url, String.Empty)
        Catch ex As Exception
            MsgBox("Cannot find the folder. Something going wrong : " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (old_pack_url.Text() Is "") Then
            MessageBox.Show("You must select the L2J Old Pack Folder First !!!")
        ElseIf (new_pack_url.Text() Is "") Then
            MessageBox.Show("You must select the L2J New Pack Folder First !!!")
        ElseIf (old_pack_url.Text() = new_pack_url.Text()) Then
            MessageBox.Show("You can't have the same path for New & Old Folder !!!")
        ElseIf (Not Directory.Exists(old_pack_url.Text())) Then
            MessageBox.Show("L2J Old Pack Folder doesn't exist !!!")
        ElseIf (Not Directory.Exists(new_pack_url.Text())) Then
            MessageBox.Show("L2J New Pack Folder doesn't exist !!!")
        End If
    End Sub

    Private Sub old_pack_url_TextChanged(sender As Object, e As EventArgs) Handles old_pack_url.TextChanged
        If (old_pack_url.Text() = "") Then
            old_pack_url.BackColor = Color.Red
        Else
            old_pack_url.BackColor = Color.White
        End If
    End Sub

    Private Sub new_pack_url_TextChanged(sender As Object, e As EventArgs) Handles new_pack_url.TextChanged
        If (new_pack_url.Text() = "") Then
            new_pack_url.BackColor = Color.Red
        Else
            new_pack_url.BackColor = Color.White
        End If
    End Sub

    Private Sub old_pack_url_Validated(sender As Object, e As EventArgs) Handles old_pack_url.Validated
        If (Not Directory.Exists(old_pack_url.Text())) Then
            error_provider.SetError(Me.old_pack_url, "Folder doesn't exists")
        Else
            error_provider.SetError(Me.old_pack_url, String.Empty)

        End If

    End Sub

    Private Sub new_pack_url_Validated(sender As Object, e As EventArgs) Handles new_pack_url.Validated
        If (Not Directory.Exists(new_pack_url.Text())) Then
            error_provider.SetError(Me.new_pack_url, "Folder doesn't exists")
        Else
            error_provider.SetError(Me.new_pack_url, String.Empty)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Change default focused control cause of some problems starting from one textbox
        Me.ActiveControl = logo_icon

    End Sub
End Class

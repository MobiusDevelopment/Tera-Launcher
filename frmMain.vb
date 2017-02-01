Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class frmMain
    Private Sub pbxStart_Click(sender As Object, e As EventArgs) Handles pbxStart.Click
        'Check if info is entered.
        If txtAccount.Text.Equals("") Then
            MsgBox("Please enter your account name.", MsgBoxStyle.OkOnly, Me.Text)
            Exit Sub
        End If
        If txtPassword.Text.Equals("") Then
            MsgBox("Please enter your password.", MsgBoxStyle.OkOnly, Me.Text)
            Exit Sub
        End If
        'Check if tera.exe file exists.
        If Not File.Exists("tera.exe") Then
            MsgBox("Could not find tera.exe", MsgBoxStyle.OkOnly, Me.Text)
            Exit Sub
        End If
        'Start client with parameters.
        Process.Start("tera.exe", "1 " + getMD5(txtPassword.Text) + " 0 1 " + txtAccount.Text + " en")
        'Close launcher.
        End
    End Sub

    Private Sub pbxStart_MouseEnter(sender As Object, e As EventArgs) Handles pbxStart.MouseEnter
        pbxStart.Image = TERA_Launcher.My.Resources.Resources.start_hover
    End Sub

    Private Sub pbxStart_MouseLeave(sender As Object, e As EventArgs) Handles pbxStart.MouseLeave
        pbxStart.Image = TERA_Launcher.My.Resources.Resources.start_normal
    End Sub

    Private Sub pbxStart_MouseDown(sender As Object, e As MouseEventArgs) Handles pbxStart.MouseDown
        pbxStart.Image = TERA_Launcher.My.Resources.Resources.start_active
    End Sub

    Private Sub pbxStart_MouseUp(sender As Object, e As MouseEventArgs) Handles pbxStart.MouseUp
        pbxStart.Image = TERA_Launcher.My.Resources.Resources.start_normal
    End Sub

    Private Function getMD5(ByVal source As String) As String
        Dim Bytes() As Byte
        Dim sb As New StringBuilder()
        Bytes = Encoding.Default.GetBytes(source)
        Bytes = MD5.Create().ComputeHash(Bytes)
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next
        Return sb.ToString()
    End Function
End Class

Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Text
Imports System.Security.Cryptography


Public Class FrmLogin

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txPassword.Text = ""
        txPassword.PasswordChar = "●"
    End Sub

    Sub cekUser()
        If txUserName.Text = "" Or txPassword.Text = "" Then
            MessageBox.Show("Isi Username / Password Dulu", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call koneksidb()
            cmd = New SqlCommand("Select * From MstUser Where NamaUser = '" & txUserName.Text & "' and Password= '" & GetPassword(txUserName.Text, txPassword.Text, "", True) & "'", conn)
            DR = cmd.ExecuteReader
            DR.Read()

            If Not DR.HasRows Then
                MsgBox("userName atau Passsword Salah!")
            Else
                Me.Close()
                Menu_Utama.Show()
                Menu_Utama.Luser.Text = DR!NamaUser
                Menu_Utama.Llvl.Text = DR!Level

            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cekUser()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        End
    End Sub

    Private Sub txUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txUserName.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub


    Private Sub txPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
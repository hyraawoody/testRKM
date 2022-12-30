Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Frm_Master_User
    Dim objdataroom1 As DataTable
    Dim simpan As String
    Public Sub Bersih()
        txUser.Text = ""
        txPwd.Text = ""
        txLvl.Text = ""
        txUser.Focus()
    End Sub
    Private Sub cbDept()
        Dim i As Integer = 0
        objdataroom1 = ExecuteQuery("Select Kode_Dep From Departement Order By Kode_Dep")
        If objdataroom1.Rows.Count > 0 Then
            Do While i < objdataroom1.Rows.Count
                cbDpt.Items.Add(IIf(IsDBNull(objdataroom1.Rows(i).Item("Kode_Dep")), "", objdataroom1.Rows(i).Item("Kode_Dep")))
                i += 1
            Loop
            cbDpt.SelectedIndex = 0
        End If
    End Sub

    Private Sub Frm_Master_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksidb()
        Bersih()
        cbDept()
    End Sub
    Sub save()
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
         Call koneksidb()
        cmd = New SqlCommand("Select NamaUser From MstUser Where NamaUser ='" & txUser.Text & "'", conn)
        DR = cmd.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            MsgBox("Maaf Nama User dengan '" & txUser.Text & "' Tersebut Sudah Ada", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Call koneksidb()
            Dim simpan As String
            If MessageBox.Show("Apakah data sudah benar ???", "..: Message :..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                simpan = "insert into MstUser(NamaUser,Password,Level,Depart) values ('" & txUser.Text & "','" & GetPassword(txUser.Text, txPwd.Text, "", True) & "', '" & txLvl.Text & "','" & cbDpt.Text & "')"
                cmd = New SqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Sudah Tersimpan....?", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call Bersih()
            End If
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txUser.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txPwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txPwd.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txLvl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txLvl.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbDpt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbDpt.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class
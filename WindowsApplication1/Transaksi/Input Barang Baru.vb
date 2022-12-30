Imports System.Data.SqlClient

Public Class Input_Barang_Baru

    Private Sub Input_Barang_Baru_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Input Barang Baru"
        Call koneksidb()
    End Sub
    Private Sub bersih()
        txid.Text = ""
        txkdbrg.Text = ""
        txnmbrg.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call koneksidb()
        cmd = New SqlCommand("Select id From MstBrg Where id ='" & txid.Text & "'", conn)
        DR = cmd.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            MsgBox("Maaf Data dengan ID Barang tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
        Else
        Call koneksidb()
        Dim simpan As String
        If MessageBox.Show("Apakah data sudah benar ???", "..: Message :..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            simpan = "insert into MstBrg(id,kdbrg,nmbrg,qty,harga) values ('" & txid.Text & "','" & txkdbrg.Text & "','" & txnmbrg.Text & "','0','0')"
            cmd = New SqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Sudah Tersimpan....?", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call bersih()
            End If
        End If
    End Sub

    Private Sub txid_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txid.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txkdbrg.Focus()
        End If
    End Sub

    Private Sub txkdbrg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txkdbrg.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txnmbrg.Focus()
        End If
    End Sub

    Private Sub txnmbrg_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txnmbrg.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Button1.Focus()
        End If
    End Sub
End Class
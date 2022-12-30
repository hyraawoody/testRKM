Imports System.Data.SqlClient

Public Class Input_Barang_Keluar

    Private Sub Input_Barang_Keluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Input Barang Keluar"
        Call koneksidb()
    End Sub
    Private Sub bersih()
        txid.Text = ""
        txkdbrg.Text = ""
        txnmbrg.Text = ""
        txqty.Text = ""
        txharga.Text = ""
    End Sub
    Sub tampildata()
        Try
            Call koneksidb()
            Dim str As String
            str = "Select * from MstBrg where id = '" & txid.Text & "'"
            cmd = New SqlCommand(str, conn)
            DR = cmd.ExecuteReader

            DR.Read()
            If DR.HasRows Then
                txkdbrg.Text = DR.Item("kdbrg")
                txnmbrg.Text = DR.Item("nmbrg")
                txqty.Text = DR.Item("qty")

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim simpan As String
        Call koneksidb()
        If txqty.Text = 0 Then
            MessageBox.Show("Stok Kosong Tidak Dapat dikeluarkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txid.Focus()
            Exit Sub
        End If

        If MessageBox.Show("Apakah data sudah benar ???", "..: Message :..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            simpan = "insert into penjualan(id,kdbrg,nmbrg,qty,harga) values ('" & txid.Text & "','" & txkdbrg.Text & "','" & txnmbrg.Text & "','" & txqtyjual.Text & "','" & txharga.Text & "')"
            cmd = New SqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Sudah Tersimpan....?", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim ubah As String
            ubah = "update MstBrg set qty = '" & TextBox2.Text & "' where id='" & txid.Text & "'"
            cmd = New SqlCommand(ubah, conn)
            cmd.ExecuteNonQuery()
            Call bersih()
        End If
    End Sub

    Private Sub txid_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txid.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Call tampildata()
            txqtyjual.Focus()
        End If
    End Sub
    Sub hitstock()
        Dim stk1 As Double
        Dim stk2 As Double
        Dim hasil As Double


        stk1 = (Double.Parse(txqty.Text))
        stk2 = (Double.Parse(txqtyjual.Text))
        hasil = stk1 - stk2
        TextBox2.Text = hasil
    End Sub

    Private Sub txqtyjual_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txqtyjual.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Call hitstock()
            txharga.Focus()
        End If
    End Sub

    Private Sub txharga_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txharga.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        bersih()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class input_Supplier

    Private Sub Master_Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Input Master Supplier"
        Call koneksidb()
    End Sub
    Private Sub bersih()
        txkdsup.Text = ""
        txnmsup.Text = ""
        txalmt.Text = ""
        txkota.Text = ""
        txemail.Text = ""
    End Sub
    
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Call koneksidb()
        cmd = New SqlCommand("Select nmsup From MstSupp Where kdsup  ='" & txkdsup.Text & "'", conn)
        DR = cmd.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            MsgBox("Maaf Nama User dengan '" & txnmsup.Text & "' Tersebut Sudah Ada", MsgBoxStyle.Exclamation, "Peringatan")
        Else
            Call koneksidb()
            Dim simpan As String
            If MessageBox.Show("Apakah data sudah benar ???", "..: Message :..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                simpan = "insert into MstSupp(kdsup,nmsup,almt,kota,email) values ('" & txkdsup.Text & "','" & txnmsup.Text & "', '" & txalmt.Text & "','" & txkota.Text & "','" & txemail.Text & "')"
                cmd = New SqlCommand(simpan, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Data Sudah Tersimpan....?", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call bersih()
            End If
        End If
    End Sub

    Private Sub txkdsup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txkdsup.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txnmsup.Focus()
        End If
    End Sub

    Private Sub txnmsup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txnmsup.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txalmt.Focus()
        End If
    End Sub

    Private Sub txalmt_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txalmt.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txkota.Focus()
        End If
    End Sub

    Private Sub txkota_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txkota.KeyPress
        If (e.KeyChar = Chr(13)) Then
            txemail.Focus()
        End If
    End Sub

    Private Sub txemail_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txemail.KeyPress
        If (e.KeyChar = Chr(13)) Then
            btnsave.Focus()
        End If
    End Sub
  
End Class
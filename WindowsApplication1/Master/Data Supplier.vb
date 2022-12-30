Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Data_Supplier

    Private Sub Data_Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksidb()
        Me.Text = "Master Supplier"
        dgstyle(DataGridViewX1)
        datagrid()
        UkDg()
    End Sub
    Sub datagrid()
        Call koneksidb()
        DA = New SqlDataAdapter("Select * From MstSupp order by kdsup asc", conn)
        DS = New DataSet
        DA.Fill(DS, "MstSupp")
        DataGridViewX1.DataSource = DS.Tables("MstSupp")
        DataGridViewX1.ReadOnly = True
    End Sub
    Sub UkDg()
        DataGridViewX1.Columns(0).Width = 100
        DataGridViewX1.Columns(1).Width = 100
        DataGridViewX1.Columns(2).Width = 300
        DataGridViewX1.Columns(3).Width = 100
        DataGridViewX1.Columns(4).Width = 100
    End Sub
    Sub delete()
        Try
            Call koneksidb()
            Dim str As String
            str = "delete from MstSupp where kdsup = '" & txkdsup.Text & "'"
            cmd = New SqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Sudah berhasil dihapus")
            refresh()

        Catch ex As Exception

            MessageBox.Show("Data Gagal Dihapus")

        End Try
    End Sub
    Sub update()
        Try
            Call koneksidb()
            Dim str As String
            str = "Update MstSupp set nmsup='" & txnmsup.Text & "', almt='" & txalmsup.Text & "', kota='" & txkotas.Text & "', email='" & txemail.Text & "' where kdsup = '" & txkdsup.Text & "'"

            cmd = New SqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil diupdate")

        Catch ex As Exception
            MessageBox.Show("Update data Gagal")
        End Try
    End Sub
    Sub bersih()
        txkdsup.Text = ""
        txnmsup.Text = ""
        txalmsup.Text = ""
        txkotas.Text = ""
        txemail.Text = ""
    End Sub
    Private Sub DataGridViewX1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridViewX1.CellMouseClick
        txkdsup.Text = DataGridViewX1.Rows(e.RowIndex).Cells(0).Value
        txnmsup.Text = DataGridViewX1.Rows(e.RowIndex).Cells(1).Value
        txalmsup.Text = DataGridViewX1.Rows(e.RowIndex).Cells(2).Value
        txkotas.Text = DataGridViewX1.Rows(e.RowIndex).Cells(3).Value
        txemail.Text = DataGridViewX1.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub TextBoxX6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxX6.TextChanged
        Call koneksidb()
        DA = New SqlDataAdapter("Select * from MstSupp where kdsup like '" & TextBoxX6.Text & "%'", conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridViewX1.DataSource = DS.Tables(0)
    End Sub

    Private Sub bbdel_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bbdel.Click
        If txkdsup.Text = "" Then
            MessageBox.Show("Data tidak bisa di Hapus, kode Supplier tidak ada", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            delete()
        End If
    End Sub

    Private Sub bbubah_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bbubah.Click
        If MessageBox.Show("Apakah Yakin Akan diUpdate ???", "..: Message :..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            update()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub bbadd_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bbadd.Click
        input_Supplier.Show()
    End Sub

    Private Sub bbclose_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bbclose.Click
        Me.Close()
    End Sub

    Private Sub bbref_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bbref.Click
        bersih()
    End Sub
End Class
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class FrmMasterBarang
    Dim cRow As Short
    Dim skd As String
    Private Sub FrmMasterBarang_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        datagrid()
        dgstyle(DataGridView1)
    End Sub
    Sub refresh()
        txid.Text = ""
        txkdbrg.Text = ""
        txnmbrg.Text = ""
        txqty.Text = ""
        txhrg.Text = ""
        DataGridView1.Refresh()
    End Sub
    Sub datagrid()
        Call koneksidb()
        DA = New SqlDataAdapter("Select * From MstBrg order by id asc", conn)
        DS = New DataSet
        DA.Fill(DS, "MstBrg")
        DataGridView1.DataSource = DS.Tables("MstBrg")
        DataGridView1.ReadOnly = True
    End Sub
    Sub delete()
        Try
            Call koneksidb()
                Dim str As String
                str = "delete from Mstbrg where id = '" & txid.Text & "'"
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
            str = "Update Mstbrg set kdbrg='" & txkdbrg.Text & "', nmbrg='" & txnmbrg.Text & "', qty='" & txqty.Text & "', harga='" & txhrg.Text & "' where id = '" & txid.Text & "'"

            cmd = New SqlCommand(str, conn)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Data Berhasil diupdate")

        Catch ex As Exception
            MessageBox.Show("Update data Gagal")
        End Try
    End Sub
   
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call koneksidb()
        DA = New SqlDataAdapter("Select * from MstBrg where kdbrg like '" & TextBox1.Text & "%'", conn)
        DS = New DataSet
        DA.Fill(DS)
        DataGridView1.DataSource = DS.Tables(0)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        If txkdbrg.Text = "" Then
            MessageBox.Show("Data tidak bisa di Hapus, kode barang tidak ada", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            delete()
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        txid.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txkdbrg.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txnmbrg.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value

        txhrg.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txqty.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        refresh()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim sql As String
        Call koneksidb()
        sql = "Select * from MstBrg "
        
        Try
            Print.PersediaanDataSet1.Clear()
            Print.PersediaanDataSet1.EnforceConstraints = False
            Call koneksidb()
            cmd = New SqlCommand(sql, conn)
            DA.SelectCommand = cmd
            DA.Fill(Print.PersediaanDataSet1.MstBrg)
            cmd.Dispose()
            DA.Dispose()
            conn.Close()
        Catch ex As Exception
            conn.Close()
        End Try
        Print.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Print.ReportViewer1.ZoomMode = ZoomMode.Percent
        Print.Show()
    End Sub

    Private Sub bbadd_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bbadd.Click
        Input_Barang_Baru.Show()
    End Sub

    Private Sub bbdel_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bbdel.Click
        If txkdbrg.Text = "" Then
            MessageBox.Show("Data tidak bisa di Hapus, kode barang tidak ada", "informasi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            delete()
        End If
    End Sub

    Private Sub bbedit_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bbedit.Click
        update()
        refresh()
    End Sub

    Private Sub bbclose_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bbclose.Click
        Me.Close()
    End Sub

    Private Sub bbref_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bbref.Click
        refresh()
    End Sub
End Class
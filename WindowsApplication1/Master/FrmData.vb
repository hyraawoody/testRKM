Imports System.Data.Sql
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.Shared
Imports VB = Microsoft.VisualBasic
Public Class FrmData
    Dim objDatatable3 As New DataTable
    Dim colPos As Integer
    Dim npos As Integer
    Public Objdataroom As DataTable
    Public objDatakelas As DataTable
    Private Sub FrmData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksidb()
        isiGrid1()
        dgstyle(grid2)
        Me.Text = "Form Laporan Penjualan Barang"

    End Sub
    Private Sub isiGrid1()

        Dim total As Double = 0


        objDatatable3 = ExecuteQuery("select id,kdbrg,nmbrg,Nofaktur_jual,qty3,hrgfb3 from MstBrg INNER JOIN penjualan_2 ON MstBrg.kdbrg = penjualan_2.kdbrg3 Where kdbrg <> '' and len(kdbrg)>=3 order by kdbrg")

        grid2.RowHeadersVisible = False
        grid2.Text = "RECORD : " + objDatatable3.Rows.Count.ToString
        Label1.Text = "JUMLAH RECORD : " + objDatatable3.Rows.Count.ToString
        grid2.DataSource = objDatatable3
        grid2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grid2.Columns(4).DefaultCellStyle.Format = "##,#0.00"
        grid2.Columns(0).Frozen = True

    End Sub
    Private Sub grid2_CellStateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellStateChangedEventArgs) Handles grid2.CellStateChanged
        Label1.Text = "JUMLAH RECORD : " + ((e.Cell.RowIndex) + 1).ToString + "/" + objDatatable3.Rows.Count.ToString
        colPos = e.Cell.ColumnIndex
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Call koneksidb()

        DA = New SqlDataAdapter("select id,kdbrg,nmbrg,Nofaktur_jual,qty3,hrgfb3 from MstBrg INNER JOIN penjualan_2 ON MstBrg.kdbrg = penjualan_2.kdbrg3 where Nofaktur_Jual like '" & TextBox1.Text & "%'", conn)
        DS = New DataSet
        DA.Fill(DS)
        grid2.DataSource = DS.Tables(0)
        hitpc()
        hittot()
    End Sub
    Sub hitpc()
        Dim hitung As Integer
        For baris As Integer = 0 To grid2.RowCount - 1
            hitung = hitung + grid2.Rows(baris).Cells(4).Value
        Next
        LabelX1.Text = hitung
    End Sub
    Sub hittot()
        Dim hitung As Integer
        For baris As Integer = 0 To grid2.RowCount - 1
            hitung = hitung + grid2.Rows(baris).Cells(5).Value
        Next
        LabelX2.Text = hitung
    End Sub

    Private Sub grid2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid2.CellContentClick

    End Sub
End Class
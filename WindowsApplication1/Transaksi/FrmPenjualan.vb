Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class FrmPenjualan

    Private Sub FrmPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksidb()
        NoFJ()
        dgstyle(dg1)
    End Sub
    Private Sub NoFJ()
        Dim NoOtomatis As String
        Dim Hit As Long
        Call koneksidb()
        cmd = New SqlCommand("Select * from penjualan_1 Where NoFaktur_jual in (select max(NoFaktur_jual) From penjualan_1)", conn)
        DR = cmd.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            NoOtomatis = "FJ - " + "00001"
        Else
            Hit = Microsoft.VisualBasic.Right(DR.GetString(0), 5) + 1
            NoOtomatis = "FJ - " + Microsoft.VisualBasic.Right("00000" & Hit, 5)
        End If
        tfktJual.Text = NoOtomatis

    End Sub

    Private Sub tampildataFJ()
        Try
            Call koneksidb()
            Dim str As String
            str = "Select * from MstCustomer where kdCust = '" & tCust.Text & "'"
            cmd = New SqlCommand(str, conn)
            DR = cmd.ExecuteReader

            DR.Read()
            If DR.HasRows Then
                txNmCust.Text = DR.Item("NmCust")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tCust_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tCust.KeyPress
        If (e.KeyChar = Chr(13)) Then
            tampildataFJ()
            dtFb1.Focus()
        End If
    End Sub
    Sub hitpc()
        Dim hitung As Integer
        For baris As Integer = 0 To dg1.RowCount - 1
            hitung = hitung + dg1.Rows(baris).Cells(3).Value
        Next
        txtqtyB.Text = hitung
    End Sub
    Sub hithrg()
        Dim hitung1 As Integer
        For baris1 As Integer = 0 To dg1.RowCount - 1
            hitung1 = hitung1 + dg1.Rows(baris1).Cells(4).Value
        Next
        txthrgB.Text = hitung1
    End Sub
    Sub hitotal()
        Dim total As Integer
        Dim htg As String

        htg = Val(Double.Parse(txtqtyB.Text)) * Val(Double.Parse(txthrgB.Text))
        total = htg
        ttlfbB.Text = total
    End Sub

    Private Sub BtnOff_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles BtnOff.Click
        Me.Close()
    End Sub
    Private Sub dg1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg1.CellEndEdit
        hitpc()
        hithrg()
        'hitotal()
        Call koneksidb()
        Dim view As String

        If e.ColumnIndex = 0 Then
            view = "Select * from MstBrg where id = '" & dg1.CurrentCell.Value & "'"
            DA = New SqlDataAdapter(view, conn)
            DS = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count > 0 Then
                Dim dr As DataRow = DS.Tables(0).Rows(0)
                dg1.CurrentRow.Cells(1).Value = dr(1)
                dg1.CurrentRow.Cells(2).Value = dr(2)
            End If
        End If
    End Sub
    Private Sub dtFb1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtFb1.KeyPress
        If (e.KeyChar = Chr(13)) Then
            dg1.Focus()
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles btnAdd.Click
        Dim ubah As String
        Dim I As Integer
        Dim iKdBrg As String
        Dim iQtyStok, iHarga As Double
        'Call koneksidb()
        ' cmd = New SqlCommand("Select id From MstBrg Where id ='" & txid.Text & "'", conn)
        'DR = cmd.ExecuteReader
        ' DR.Read()
        'If DR.HasRows Then
        'MsgBox("Maaf Data dengan kode tersebut sudah ada", MsgBoxStyle.Exclamation, "Peringatan")
        'Else
        If txNmCust.Text = "" Then
            MessageBox.Show("Isi Nama Supplier!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tCust.Focus()
            Exit Sub
        End If
        If dg1.Rows(0).Cells(1).Value = "" Then
            MessageBox.Show("Harap Isi Kode Barang terlebih Dulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dg1.Focus()
            Exit Sub
        End If

        Call koneksidb()
        Dim simpan As String
        If MessageBox.Show("Apakah data sudah benar ???", "..: Message :..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            simpan = "insert into penjualan_1(Nofaktur_Jual,Kode_Customer,Nama_Customer,Tanggal,Total) values ('" & tfktJual.Text & "','" & tCust.Text & "','" & txNmCust.Text & "','" & Format(dtFb1.Value, "MM/dd/yyyy") & "','" & txthrgB.Text & "')"
            cmd = New SqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Sudah Tersimpan....?", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call koneksidb()
            Dim detail As String
            For isi As Integer = 0 To dg1.Rows.Count - 2
                detail = "Insert into penjualan_2(Nofaktur_Jual,idbrg,kdbrg3,nmbrg3,qty3,hrgfb3,tglfb3) values ('" & tfktJual.Text & "','" & dg1.Rows(isi).Cells(0).Value & "','" & dg1.Rows(isi).Cells(1).Value & "','" & dg1.Rows(isi).Cells(2).Value & "','" & dg1.Rows(isi).Cells(3).Value & "','" & dg1.Rows(isi).Cells(4).Value & "','" & Format(dtFb1.Value, "MM/dd/yyyy") & "')"
                cmd = New SqlCommand(detail, conn)
                cmd.ExecuteNonQuery()
            Next


            I = 0
            While I < dg1.Rows.Count - 1
                iKdBrg = IIf(IsDBNull(dg1.Item(0, I).Value), "", dg1.Item(0, I).Value)
                iQtyStok = IIf(IsDBNull(dg1.Item(3, I).Value), 0, dg1.Item(3, I).Value)
                iHarga = IIf(IsDBNull(dg1.Item(4, I).Value), 0, dg1.Item(4, I).Value)

                If iKdBrg <> "" Then
                    ubah = "Update Mstbrg set qty=qty-" & iQtyStok & " Where id='" & iKdBrg & "'"
                    cmd = New SqlCommand(ubah, conn)
                    cmd.ExecuteNonQuery()
                End If
                I += 1
            End While
            dg1.Rows.Clear()
        End If
    End Sub
End Class
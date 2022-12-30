Imports System.Data.SqlClient
Public Class FrmBrgMasuk

    Private Sub FrmBrgMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksidb()
        NoOb()
        Me.Text = "Input Barang Masuk"
        dgstyle(dg1)

    End Sub
    Private Sub bersih()
        tkdsup.Text = ""
        txnmsup.Text = ""
        dg1.Refresh()
        txtqty.Text = ""
        'txhrg.Text = ""
    End Sub
    Private Sub NoOb()
        Dim NoOtomatis As String
        Dim Hit As Long
        Call koneksidb()
        cmd = New SqlCommand("Select * from pembelian Where no_faktur in (select max(no_faktur) From pembelian)", conn)
        DR = cmd.ExecuteReader
        DR.Read()
        If Not DR.HasRows Then
            NoOtomatis = "FB - " + "00001"
        Else
            Hit = Microsoft.VisualBasic.Right(DR.GetString(0), 5) + 1
            NoOtomatis = "FB - " + Microsoft.VisualBasic.Right("00000" & Hit, 5)
        End If
        txfak.Text = NoOtomatis

    End Sub
    Sub tampildata()
        Try
            Call koneksidb()
            Dim str As String
            str = "Select * from MstSupp where kdsup = '" & tkdsup.Text & "'"
            cmd = New SqlCommand(str, conn)
            DR = cmd.ExecuteReader

            DR.Read()
            If DR.HasRows Then
                txnmsup.Text = DR.Item("nmsup")
            End If
        Catch ex As Exception

        End Try
    End Sub
    Sub hitpc()
        Dim hitung As Integer
        For baris As Integer = 0 To dg1.RowCount - 1
            hitung = hitung + dg1.Rows(baris).Cells(3).Value
        Next
        txtqty.Text = hitung
    End Sub
    Sub hithrg()
        Dim hitung1 As Integer
        For baris1 As Integer = 0 To dg1.RowCount - 1
            hitung1 = hitung1 + dg1.Rows(baris1).Cells(4).Value
        Next
        txthrg.Text = hitung1
    End Sub
    Sub hitotal()
        Dim total As Integer
        Dim htg As String

        htg = Val(Double.Parse(txtqty.Text)) * Val(Double.Parse(txthrg.Text))
        total = htg
        ttlfb.Text = total
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        bersih()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tkdsup.KeyPress

        If (e.KeyChar = Chr(13)) Then
            Call tampildata()
            dtFb.Focus()
        End If
    End Sub
    'Sub hitstock()
    ' stk1 As Double
    'Dim stk2 As Double
    'Dim hasil As Double


    'stk1 = (Double.Parse(txtglOb.Text))
    'stk2 = (Double.Parse(txqtybeli.Text))
    'hasil = stk1 + stk2
    'TextBox1.Text = hasil
    'End Sub

    Private Sub txqtybeli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar = Chr(13)) Then
            'Call hitstock()
            'txhrg.Focus()
        End If
    End Sub

    Private Sub dg1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg1.CellEndEdit
        Call hitpc()
        Call hithrg()
        'Call hitotal()
        Call koneksidb()
        Dim lihat As String
        If e.ColumnIndex = 0 Then
            lihat = "Select * from MstBrg where id = '" & dg1.CurrentCell.Value & "'"
            DA = New SqlDataAdapter(lihat, conn)
            DS = New DataSet()
            DA.Fill(DS)
            If DS.Tables(0).Rows.Count > 0 Then
                Dim dr As DataRow = DS.Tables(0).Rows(0)
                dg1.CurrentRow.Cells(1).Value = dr(1)
                dg1.CurrentRow.Cells(2).Value = dr(2)
            End If
        End If

    End Sub

    Private Sub dtFb_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles dtFb.KeyPress
        If (e.KeyChar = Chr(13)) Then
            dg1.Focus()
        End If
    End Sub

    Private Sub bbreffb_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bbreffb.Click
        bersih()
    End Sub

    Private Sub bbaddfb_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bbaddfb.Click

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
        If txnmsup.Text = "" Then
            MessageBox.Show("Isi Nama Supplier!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tkdsup.Focus()
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
            simpan = "insert into pembelian(no_faktur,kdsup,nmsup,tgl,ttlfb) values ('" & txfak.Text & "','" & tkdsup.Text & "','" & txnmsup.Text & "','" & Format(dtFb.Value, "MM/dd/yyyy") & "','" & txthrg.Text & "')"
            cmd = New SqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Sudah Tersimpan....?", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call koneksidb()
            Dim detail As String
            For isi As Integer = 0 To dg1.Rows.Count - 2
                detail = "Insert into pembelian2(nofak2,idbrg,kdbrg2,nmbrg2,qty2,hrgfb2,tglfb2) values ('" & txfak.Text & "','" & dg1.Rows(isi).Cells(0).Value & "','" & dg1.Rows(isi).Cells(1).Value & "','" & dg1.Rows(isi).Cells(2).Value & "','" & dg1.Rows(isi).Cells(3).Value & "','" & dg1.Rows(isi).Cells(4).Value & "','" & Format(dtFb.Value, "MM/dd/yyyy") & "')"
                cmd = New SqlCommand(detail, conn)
                cmd.ExecuteNonQuery()
            Next

            
            I = 0
            While I < dg1.Rows.Count - 1
                iKdBrg = IIf(IsDBNull(dg1.Item(0, I).Value), "", dg1.Item(0, I).Value)
                iQtyStok = IIf(IsDBNull(dg1.Item(3, I).Value), 0, dg1.Item(3, I).Value)
                iHarga = IIf(IsDBNull(dg1.Item(4, I).Value), 0, dg1.Item(4, I).Value)

                If iKdBrg <> "" Then
                    ubah = "Update Mstbrg set qty=qty+" & iQtyStok & ", harga=" & iHarga & " Where id='" & iKdBrg & "'"
                    cmd = New SqlCommand(ubah, conn)
                    cmd.ExecuteNonQuery()
                End If
                I += 1
            End While
            dg1.Rows.Clear()
        End If
    End Sub


    Private Sub BubbleButton3_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles BubbleButton3.Click
        Me.Close()
    End Sub
End Class
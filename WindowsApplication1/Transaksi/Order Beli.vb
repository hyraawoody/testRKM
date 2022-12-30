Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Order_Beli
    Private Sub NoOb()
        Dim no As String = ""
        Call koneksidb()

        Try
            cmd = New SqlCommand("Select TOP 1 right(noOb,3) + 1 as noOb from orderbeli1 ORDER BY noOb Desc ", conn)
            DR = cmd.ExecuteReader

            If DR.Read Then
                Select Case DR!noOb
                    Case Is <= 9
                        no = "OB" & "0000" & DR!noOb
                    Case Is <= 99
                        no = "OB" & "000" & DR!noOb
                End Select
            Else
                no = "OB" & "00001"
            End If

            txno.Text = no
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub tampildata()
        Call koneksidb()
        Try
            Call koneksidb()
            cmd = New SqlCommand("Select kdsup From MstSupp Order by kdsup asc", conn)
            DR = cmd.ExecuteReader
            While DR.Read
                cbsup.Items.Add(DR("kdsup"))

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Order_Beli_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Input Order Beli"
        Call NoOb()
        Call tampildata()
        Call kolombaru()

    End Sub

    Private Sub cbsup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbsup.SelectedIndexChanged
        Call koneksidb()
        Dim sql3 As String

        sql3 = "Select * from MstSupp where kdsup = '" & cbsup.Text & "'"

        cmd = New SqlCommand(sql3, conn)
        DR = cmd.ExecuteReader
        DR.Read()
        cbsup.Text = DR("kdsup")
        txnmsup.Text = DR("nmsup")
        DR.Close()
    End Sub
    Sub listbrg()
        Call koneksidb()
        DA = New SqlDataAdapter("Select id, kdbrg,nmbrg,qty,harga from MstBrg", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS)

        Dim cols As New DataGridViewComboBoxColumn
        cols.DataSource = DS.Tables(0)
        cols.DisplayMember = "nmbrg"
        DataGridViewX1.Columns.Add(cols)
        cols.HeaderText = "Nama Barang"
        cols.Width = 300
    End Sub
    Sub kolombaru()

        Call listbrg()
        DataGridViewX1.Columns.Add("Qty", "Qty")
        DataGridViewX1.Columns.Add("Harga", "Harga")
        DataGridViewX1.Columns.Add("Total", "Total")
    End Sub
    Sub hitpc()
        Dim hitung As Integer
        For baris As Integer = 0 To DataGridViewX1.RowCount - 1
            hitung = hitung + DataGridViewX1.Rows(baris).Cells(1).Value
        Next
        TextBoxX2.Text = hitung
    End Sub
    Sub hithrg()
        Dim hitung1 As Integer
        For baris1 As Integer = 0 To DataGridViewX1.RowCount - 1
            hitung1 = hitung1 + DataGridViewX1.Rows(baris1).Cells(2).Value
        Next
        TextBoxX3.Text = hitung1
    End Sub
    Sub hitotal()
        Dim total As Integer
        Dim htg As String

        htg = Val(Double.Parse(TextBoxX2.Text)) * Val(Double.Parse(TextBoxX3.Text))
        total = htg
        pntotal.Text = total
    End Sub

    Private Sub DataGridViewX1_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellEndEdit
        Call hithrg()
        Call hitpc()
        Call hitotal()
    End Sub
    Private Sub clear()
        txno.Text = ""
        cbsup.Refresh()
        txnmsup.Text = ""
        txket.Text = ""
        pntotal.Text = ""
    End Sub
    Sub save()
        Call koneksidb()
        Dim simpan As String
        If MessageBox.Show("Apakah data sudah benar ???", "..: Message :..", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            simpan = "insert into orderbeli1(noOb,kd_sup,nm_sup,ket,tgl_ob,total) values ('" & txno.Text & "','" & cbsup.Text & "','" & txnmsup.Text & "','" & txket.Text & "','" & Format(dtob.Value, "MM/dd/yyyy") & "','" & pntotal.Text & "')"
            cmd = New SqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data Sudah Tersimpan....?", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call koneksidb()
            Dim detail As String
            For isi As Integer = 0 To DataGridViewX1.Rows.Count - 2
                detail = "Insert into orderbeli2(noOb2,nmbrg,qty,hrg,tgl_ob1,total) values ('" & txno.Text & "','" & DataGridViewX1.Rows(isi).Cells(0).Value & "','" & DataGridViewX1.Rows(isi).Cells(1).Value & "','" & DataGridViewX1.Rows(isi).Cells(2).Value & "','" & Format(dtob.Value, "MM/dd/yyyy") & "','" & pntotal.Text & "')"
                cmd = New SqlCommand(detail, conn)
                cmd.ExecuteNonQuery()
            Next
            DataGridViewX1.Rows.Clear()
        End If
    End Sub

    Private Sub bbsave_Click(sender As System.Object, e As DevComponents.DotNetBar.ClickEventArgs) Handles bbsave.Click
        If pntotal.Text = "Total" Then
            MessageBox.Show("Silahkan Input Data !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbsup.Focus()
            Exit Sub
        End If
        save()
        Call clear()
    End Sub

    Private Sub bbclear_Click(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ClickEventArgs) Handles bbclear.Click
        clear()
        DataGridViewX1.Rows.Clear()
    End Sub

  
End Class
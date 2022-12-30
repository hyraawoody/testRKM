Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO

Public Class BackUp_Restore

    Dim sql As String
    Dim i As Integer
    Public Sub kondb()

        Try
            Call koneksidb()
            conn = New SqlConnection("Server='" & TextBox1.Text & "';User ID='" & TextBox3.Text & "';password='" & TextBox2.Text & ";Integrated Security=True")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                cmd = New SqlCommand("Select * from sysserver where srvproduct ='SQL server'", conn)
                DR = cmd.ExecuteReader()
            End If
        Catch ex As Exception
            MsgBox("Connection failed...!", MsgBoxStyle.Critical, "failed")
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Try
            Call koneksidb()
            Call kondb()
            sql = "SELECT DISTINCT TABLE_SCHEMA FROM information_schema.TABLES"
            DA = New SqlDataAdapter(sql, conn)
            DA.Fill(DT)
            i = 0

            ComboBox1.Enabled = True
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("***Select Database***")

            While i < DT.Rows.Count
                ComboBox1.Items.Add(DT.Rows(i)(0).ToString())
                i = i + 1

            End While
            ComboBox1.SelectedIndex = 0
            Button1.Enabled = True
            conn.Close()
            DT.Dispose()
            DA.Dispose()
            MsgBox("Connection Success", MsgBoxStyle.Information, "Information")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
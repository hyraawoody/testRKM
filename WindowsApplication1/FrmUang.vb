Public Class FrmUang
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.Text = FormatAngkaNol(TextBox1.Text, True)
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text = Terbilang(CDbl(FormatAngkaNol(TextBox1.Text, True))) & " Rupiah"
    End Sub

    Sub kosong()
        TextBox1.Text = ""
        TextBox2.Text = "0.00"
        TextBox3.Text = ""
        TextBox4.Text = ""
        ListBox1.Items.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kosong()
    End Sub

    Private Sub FrmUang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosong()
        liststyle(ListBox1)
        ListBox1.Sorted = True
    End Sub

    Private Sub bilPrim()
        kecil = Val(TextBox3.Text)
        besar = Val(TextBox4.Text)

        If ((kecil <> 0) And (besar <> 0)) Then
            If kecil <= 1 Then
                kecil = 2
            End If
            For x = kecil To besar
                z = 0
                For y = 2 To x
                    'hasil bagi 2 bilangan
                    hsl = x Mod y
                    If hsl = 0 Then
                        z = z + 1
                    End If
                Next y
                If z <= 1 Then
                    ListBox1.Items.Add(x)
                    ListBox2.Items.Add(x)
                    a = a + 1
                    Tot = Tot + x
                End If
            Next
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        bilPrim()

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (e.KeyChar = Chr(13)) Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Button2.Focus()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim ar(ListBox1.Items.Count - 1) As Integer
        ListBox1.Items.IndexOf(ar)

        Array.Reverse(ar)

        ListBox1.Items.Clear()
        ListBox1.Items.Add(x)


    End Sub


    Private Sub ListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
End Class
Public Class Menu_Utama

    Private Sub InputBarangMasukToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InputBarangMasukToolStripMenuItem.Click
        FrmBrgMasuk.MdiParent = Me
        FrmBrgMasuk.Show()
    End Sub

    Private Sub InputBarangKeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InputBarangKeluarToolStripMenuItem.Click
        FrmPenjualan.MdiParent = Me
        FrmPenjualan.Show()
        'Input_Barang_Keluar.MdiParent = Me
        'Input_Barang_Keluar.Show()
    End Sub

    Private Sub Menu_Utama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MenuStrip1.BackColor = Color.DeepPink
        Me.Text = "Menu Inventory"
        LJam.Text = TimeOfDay
        LTgl.Text = Today
       

    End Sub

    Private Sub OrderBeliToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OrderBeliToolStripMenuItem.Click
        Order_Beli.MdiParent = Me
        Order_Beli.Show()
    End Sub

    Private Sub MasterSupplierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MasterSupplierToolStripMenuItem.Click
        Data_Supplier.MdiParent = Me
        Data_Supplier.Show()
    End Sub

    Private Sub MasterBarangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MasterBarangToolStripMenuItem.Click
        FrmMasterBarang.MdiParent = Me
        FrmMasterBarang.Show()
    End Sub

    Private Sub InputUangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InputUangToolStripMenuItem.Click
        FrmUang.MdiParent = Me
        FrmUang.Show()
    End Sub

    Private Sub MasterUserToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MasterUserToolStripMenuItem.Click
        Frm_Master_User.MdiParent = Me
        Frm_Master_User.Show()
    End Sub

    Private Sub DataLaporanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataLaporanToolStripMenuItem.Click
        FrmData.MdiParent = Me
        FrmData.Show()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        FrmLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
End Class
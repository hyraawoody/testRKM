<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Utama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InputUangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Luser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Llvl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LTgl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputBarangMasukToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputBarangKeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderBeliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpRestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBackUpRestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataLaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.BackUpRestoreToolStripMenuItem, Me.InputUangToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.MToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(682, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InputUangToolStripMenuItem
        '
        Me.InputUangToolStripMenuItem.Name = "InputUangToolStripMenuItem"
        Me.InputUangToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.InputUangToolStripMenuItem.Text = "input uang"
        Me.InputUangToolStripMenuItem.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Luser, Me.Llvl, Me.LTgl, Me.LJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 298)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(682, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Luser
        '
        Me.Luser.Name = "Luser"
        Me.Luser.Size = New System.Drawing.Size(38, 17)
        Me.Luser.Text = "User :"
        '
        'Llvl
        '
        Me.Llvl.Name = "Llvl"
        Me.Llvl.Size = New System.Drawing.Size(42, 17)
        Me.Llvl.Text = "Level :"
        '
        'LTgl
        '
        Me.LTgl.Name = "LTgl"
        Me.LTgl.Size = New System.Drawing.Size(56, 17)
        Me.LTgl.Text = "Tanggal :"
        '
        'LJam
        '
        Me.LJam.Name = "LJam"
        Me.LJam.Size = New System.Drawing.Size(33, 17)
        Me.LJam.Text = "Jam :"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.WindowsApplication1.My.Resources.Resources.loc
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MToolStripMenuItem
        '
        Me.MToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterSupplierToolStripMenuItem, Me.MasterBarangToolStripMenuItem, Me.MasterUserToolStripMenuItem})
        Me.MToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.file_ico
        Me.MToolStripMenuItem.Name = "MToolStripMenuItem"
        Me.MToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.MToolStripMenuItem.Text = "Master"
        '
        'MasterSupplierToolStripMenuItem
        '
        Me.MasterSupplierToolStripMenuItem.Name = "MasterSupplierToolStripMenuItem"
        Me.MasterSupplierToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.MasterSupplierToolStripMenuItem.Text = "Master Supplier"
        '
        'MasterBarangToolStripMenuItem
        '
        Me.MasterBarangToolStripMenuItem.Name = "MasterBarangToolStripMenuItem"
        Me.MasterBarangToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.MasterBarangToolStripMenuItem.Text = "Master Barang"
        '
        'MasterUserToolStripMenuItem
        '
        Me.MasterUserToolStripMenuItem.Name = "MasterUserToolStripMenuItem"
        Me.MasterUserToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.MasterUserToolStripMenuItem.Text = "Master User"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputBarangMasukToolStripMenuItem, Me.InputBarangKeluarToolStripMenuItem, Me.OrderBeliToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.trx
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'InputBarangMasukToolStripMenuItem
        '
        Me.InputBarangMasukToolStripMenuItem.Name = "InputBarangMasukToolStripMenuItem"
        Me.InputBarangMasukToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.InputBarangMasukToolStripMenuItem.ShowShortcutKeys = False
        Me.InputBarangMasukToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.InputBarangMasukToolStripMenuItem.Text = "Input Barang Masuk"
        '
        'InputBarangKeluarToolStripMenuItem
        '
        Me.InputBarangKeluarToolStripMenuItem.Name = "InputBarangKeluarToolStripMenuItem"
        Me.InputBarangKeluarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.InputBarangKeluarToolStripMenuItem.ShowShortcutKeys = False
        Me.InputBarangKeluarToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.InputBarangKeluarToolStripMenuItem.Text = "Input Barang Keluar"
        '
        'OrderBeliToolStripMenuItem
        '
        Me.OrderBeliToolStripMenuItem.Name = "OrderBeliToolStripMenuItem"
        Me.OrderBeliToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.OrderBeliToolStripMenuItem.Text = "Order beli"
        '
        'BackUpRestoreToolStripMenuItem
        '
        Me.BackUpRestoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuBackUpRestoreToolStripMenuItem, Me.DataLaporanToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.BackUpRestoreToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.file_1
        Me.BackUpRestoreToolStripMenuItem.Name = "BackUpRestoreToolStripMenuItem"
        Me.BackUpRestoreToolStripMenuItem.Size = New System.Drawing.Size(107, 20)
        Me.BackUpRestoreToolStripMenuItem.Text = "Data Laporan"
        '
        'MenuBackUpRestoreToolStripMenuItem
        '
        Me.MenuBackUpRestoreToolStripMenuItem.Name = "MenuBackUpRestoreToolStripMenuItem"
        Me.MenuBackUpRestoreToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.MenuBackUpRestoreToolStripMenuItem.Visible = False
        '
        'DataLaporanToolStripMenuItem
        '
        Me.DataLaporanToolStripMenuItem.Name = "DataLaporanToolStripMenuItem"
        Me.DataLaporanToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DataLaporanToolStripMenuItem.Text = "Data laporan"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 320)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu_Utama"
        Me.Text = "Menu_Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputBarangMasukToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputBarangKeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderBeliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterBarangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackUpRestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBackUpRestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputUangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataLaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Luser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Llvl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LTgl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LJam As System.Windows.Forms.ToolStripStatusLabel
End Class

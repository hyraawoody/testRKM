<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMasterBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMasterBarang))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txhrg = New System.Windows.Forms.TextBox()
        Me.txqty = New System.Windows.Forms.TextBox()
        Me.txnmbrg = New System.Windows.Forms.TextBox()
        Me.txkdbrg = New System.Windows.Forms.TextBox()
        Me.txid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.CustomColorBlender1 = New DevComponents.DotNetBar.ColorPickers.CustomColorBlender()
        Me.bb = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.bbadd = New DevComponents.DotNetBar.BubbleButton()
        Me.bbdel = New DevComponents.DotNetBar.BubbleButton()
        Me.bbedit = New DevComponents.DotNetBar.BubbleButton()
        Me.bbclose = New DevComponents.DotNetBar.BubbleButton()
        Me.bbref = New DevComponents.DotNetBar.BubbleButton()
        Me.BubbleButton6 = New DevComponents.DotNetBar.BubbleButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(868, 198)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(50, 53)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "FIND"
        '
        'txhrg
        '
        Me.txhrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txhrg.Location = New System.Drawing.Point(528, 15)
        Me.txhrg.Name = "txhrg"
        Me.txhrg.Size = New System.Drawing.Size(161, 20)
        Me.txhrg.TabIndex = 10
        '
        'txqty
        '
        Me.txqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txqty.Location = New System.Drawing.Point(695, 15)
        Me.txqty.Name = "txqty"
        Me.txqty.Size = New System.Drawing.Size(161, 20)
        Me.txqty.TabIndex = 9
        '
        'txnmbrg
        '
        Me.txnmbrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txnmbrg.Location = New System.Drawing.Point(361, 15)
        Me.txnmbrg.Name = "txnmbrg"
        Me.txnmbrg.Size = New System.Drawing.Size(161, 20)
        Me.txnmbrg.TabIndex = 8
        '
        'txkdbrg
        '
        Me.txkdbrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txkdbrg.Location = New System.Drawing.Point(185, 15)
        Me.txkdbrg.Name = "txkdbrg"
        Me.txkdbrg.Size = New System.Drawing.Size(161, 20)
        Me.txkdbrg.TabIndex = 7
        '
        'txid
        '
        Me.txid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txid.Location = New System.Drawing.Point(10, 14)
        Me.txid.Name = "txid"
        Me.txid.Size = New System.Drawing.Size(161, 20)
        Me.txid.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "KODE BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(401, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "NAMA BARANG"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(761, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "QTY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(574, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "HARGA"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(333, 368)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(868, 324)
        Me.ShapeContainer1.TabIndex = 19
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -3
        Me.LineShape2.X2 = 872
        Me.LineShape2.Y1 = 79
        Me.LineShape2.Y2 = 78
        '
        'LineShape1
        '
        Me.LineShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -3
        Me.LineShape1.X2 = 869
        Me.LineShape1.Y1 = 46
        Me.LineShape1.Y2 = 44
        '
        'CustomColorBlender1
        '
        Me.CustomColorBlender1.Location = New System.Drawing.Point(209, 44)
        Me.CustomColorBlender1.Name = "CustomColorBlender1"
        Me.CustomColorBlender1.Size = New System.Drawing.Size(661, 36)
        Me.CustomColorBlender1.TabIndex = 20
        Me.CustomColorBlender1.Text = "CustomColorBlender1"
        '
        'bb
        '
        Me.bb.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Bottom
        Me.bb.AntiAlias = True
        '
        '
        '
        Me.bb.BackgroundStyle.Class = ""
        Me.bb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.bb.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bb.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bb.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.bb.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bb.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bb.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.bb.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bb.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.bb.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bb.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.bb.ButtonBackAreaStyle.Class = ""
        Me.bb.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.bb.ButtonBackAreaStyle.PaddingBottom = 3
        Me.bb.ButtonBackAreaStyle.PaddingLeft = 3
        Me.bb.ButtonBackAreaStyle.PaddingRight = 3
        Me.bb.ButtonBackAreaStyle.PaddingTop = 3
        Me.bb.ButtonSpacing = 10
        Me.bb.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bb.ImageSizeNormal = New System.Drawing.Size(24, 24)
        Me.bb.Location = New System.Drawing.Point(0, 81)
        Me.bb.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.bb.Name = "bb"
        Me.bb.SelectedTab = Me.BubbleBarTab1
        Me.bb.SelectedTabColors.BackColor = System.Drawing.Color.Yellow
        Me.bb.SelectedTabColors.BackColor2 = System.Drawing.Color.Blue
        Me.bb.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.bb.Size = New System.Drawing.Size(868, 45)
        Me.bb.TabIndex = 21
        Me.bb.Tabs.Add(Me.BubbleBarTab1)
        Me.bb.TabsVisible = False
        '
        'BubbleBarTab1
        '
        Me.BubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.bbadd, Me.bbdel, Me.bbedit, Me.bbclose, Me.bbref, Me.BubbleButton6})
        Me.BubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab1.Name = "BubbleBarTab1"
        Me.BubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab1.Text = "BubbleBarTab1"
        Me.BubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'bbadd
        '
        Me.bbadd.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.bbadd.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.add
        Me.bbadd.Name = "bbadd"
        Me.bbadd.TooltipText = "Add"
        '
        'bbdel
        '
        Me.bbdel.Image = Global.WindowsApplication1.My.Resources.Resources.del
        Me.bbdel.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.del
        Me.bbdel.Name = "bbdel"
        Me.bbdel.TooltipText = "Delete"
        '
        'bbedit
        '
        Me.bbedit.Image = Global.WindowsApplication1.My.Resources.Resources.edit
        Me.bbedit.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.edit1
        Me.bbedit.Name = "bbedit"
        Me.bbedit.TooltipText = "Update"
        '
        'bbclose
        '
        Me.bbclose.Image = Global.WindowsApplication1.My.Resources.Resources.off
        Me.bbclose.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.off
        Me.bbclose.Name = "bbclose"
        Me.bbclose.TooltipText = "Close"
        '
        'bbref
        '
        Me.bbref.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.bbref.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.bbref.Name = "bbref"
        Me.bbref.TooltipText = "Refresh"
        '
        'BubbleButton6
        '
        Me.BubbleButton6.Image = CType(resources.GetObject("BubbleButton6.Image"), System.Drawing.Image)
        Me.BubbleButton6.ImageLarge = CType(resources.GetObject("BubbleButton6.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton6.Name = "BubbleButton6"
        Me.BubbleButton6.Visible = False
        '
        'FrmMasterBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 324)
        Me.Controls.Add(Me.bb)
        Me.Controls.Add(Me.CustomColorBlender1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txhrg)
        Me.Controls.Add(Me.txqty)
        Me.Controls.Add(Me.txnmbrg)
        Me.Controls.Add(Me.txkdbrg)
        Me.Controls.Add(Me.txid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMasterBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txhrg As System.Windows.Forms.TextBox
    Friend WithEvents txqty As System.Windows.Forms.TextBox
    Friend WithEvents txnmbrg As System.Windows.Forms.TextBox
    Friend WithEvents txkdbrg As System.Windows.Forms.TextBox
    Friend WithEvents txid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents CustomColorBlender1 As DevComponents.DotNetBar.ColorPickers.CustomColorBlender
    Friend WithEvents bb As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents bbdel As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bbedit As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bbclose As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bbref As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton6 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bbadd As DevComponents.DotNetBar.BubbleButton
End Class

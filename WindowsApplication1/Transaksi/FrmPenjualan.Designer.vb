<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenjualan
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
        Me.ttlfbB = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txthrgB = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtqtyB = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.dtFb1 = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tfktJual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txNmCust = New System.Windows.Forms.TextBox()
        Me.tCust = New System.Windows.Forms.TextBox()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.btnAdd = New DevComponents.DotNetBar.BubbleButton()
        Me.BtnRefresh = New DevComponents.DotNetBar.BubbleButton()
        Me.BtnOff = New DevComponents.DotNetBar.BubbleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.idkd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kdbrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nmbrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtybrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtFb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ttlfbB
        '
        '
        '
        '
        Me.ttlfbB.Border.Class = "TextBoxBorder"
        Me.ttlfbB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ttlfbB.Location = New System.Drawing.Point(423, 68)
        Me.ttlfbB.Name = "ttlfbB"
        Me.ttlfbB.Size = New System.Drawing.Size(100, 20)
        Me.ttlfbB.TabIndex = 35
        Me.ttlfbB.Visible = False
        '
        'txthrgB
        '
        '
        '
        '
        Me.txthrgB.Border.Class = "TextBoxBorder"
        Me.txthrgB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txthrgB.Location = New System.Drawing.Point(476, 42)
        Me.txthrgB.Name = "txthrgB"
        Me.txthrgB.Size = New System.Drawing.Size(100, 20)
        Me.txthrgB.TabIndex = 34
        '
        'txtqtyB
        '
        '
        '
        '
        Me.txtqtyB.Border.Class = "TextBoxBorder"
        Me.txtqtyB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtqtyB.Location = New System.Drawing.Point(371, 42)
        Me.txtqtyB.Name = "txtqtyB"
        Me.txtqtyB.Size = New System.Drawing.Size(100, 20)
        Me.txtqtyB.TabIndex = 33
        '
        'dtFb1
        '
        '
        '
        '
        Me.dtFb1.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFb1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFb1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtFb1.ButtonDropDown.Visible = True
        Me.dtFb1.IsPopupCalendarOpen = False
        Me.dtFb1.Location = New System.Drawing.Point(371, 13)
        '
        '
        '
        Me.dtFb1.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFb1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtFb1.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtFb1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFb1.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFb1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFb1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFb1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFb1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFb1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFb1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFb1.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtFb1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFb1.MonthCalendar.DisplayMonth = New Date(2022, 7, 1, 0, 0, 0, 0)
        Me.dtFb1.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtFb1.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFb1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFb1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFb1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFb1.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtFb1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFb1.MonthCalendar.TodayButtonVisible = True
        Me.dtFb1.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtFb1.Name = "dtFb1"
        Me.dtFb1.Size = New System.Drawing.Size(200, 20)
        Me.dtFb1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFb1.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "No Faktur Beli"
        '
        'tfktJual
        '
        Me.tfktJual.Location = New System.Drawing.Point(132, 13)
        Me.tfktJual.Name = "tfktJual"
        Me.tfktJual.ReadOnly = True
        Me.tfktJual.Size = New System.Drawing.Size(172, 20)
        Me.tfktJual.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nama Customer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Kode Customer"
        '
        'txNmCust
        '
        Me.txNmCust.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txNmCust.Location = New System.Drawing.Point(132, 69)
        Me.txNmCust.Name = "txNmCust"
        Me.txNmCust.ReadOnly = True
        Me.txNmCust.Size = New System.Drawing.Size(172, 20)
        Me.txNmCust.TabIndex = 27
        '
        'tCust
        '
        Me.tCust.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tCust.Location = New System.Drawing.Point(132, 43)
        Me.tCust.Name = "tCust"
        Me.tCust.Size = New System.Drawing.Size(172, 20)
        Me.tCust.TabIndex = 26
        '
        'BubbleBar1
        '
        Me.BubbleBar1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Top
        Me.BubbleBar1.AntiAlias = True
        '
        '
        '
        Me.BubbleBar1.BackgroundStyle.Class = ""
        Me.BubbleBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.BubbleBar1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBar1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.BubbleBar1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.BubbleBar1.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.BubbleBar1.ButtonBackAreaStyle.Class = ""
        Me.BubbleBar1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingBottom = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingLeft = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingRight = 3
        Me.BubbleBar1.ButtonBackAreaStyle.PaddingTop = 3
        Me.BubbleBar1.ButtonSpacing = 10
        Me.BubbleBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BubbleBar1.ImageSizeNormal = New System.Drawing.Size(24, 24)
        Me.BubbleBar1.Location = New System.Drawing.Point(0, 319)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(604, 31)
        Me.BubbleBar1.TabIndex = 37
        Me.BubbleBar1.Tabs.Add(Me.BubbleBarTab1)
        Me.BubbleBar1.Text = "BubbleBar1"
        '
        'BubbleBarTab1
        '
        Me.BubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.btnAdd, Me.BtnRefresh, Me.BtnOff})
        Me.BubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab1.Name = "BubbleBarTab1"
        Me.BubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab1.Text = "BubbleBarTab1"
        Me.BubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'btnAdd
        '
        Me.btnAdd.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.btnAdd.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.add
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.TooltipText = "Add"
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.BtnRefresh.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.TooltipText = "Refresh"
        '
        'BtnOff
        '
        Me.BtnOff.Image = Global.WindowsApplication1.My.Resources.Resources.off
        Me.BtnOff.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.off
        Me.BtnOff.Name = "BtnOff"
        Me.BtnOff.TooltipText = "Close"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tCust)
        Me.Panel1.Controls.Add(Me.txNmCust)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ttlfbB)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txthrgB)
        Me.Panel1.Controls.Add(Me.tfktJual)
        Me.Panel1.Controls.Add(Me.txtqtyB)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtFb1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 96)
        Me.Panel1.TabIndex = 38
        '
        'dg1
        '
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idkd, Me.kdbrg, Me.nmbrg, Me.qtybrg, Me.hrg})
        Me.dg1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg1.Location = New System.Drawing.Point(0, 96)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(604, 223)
        Me.dg1.TabIndex = 39
        '
        'idkd
        '
        Me.idkd.HeaderText = "ID"
        Me.idkd.Name = "idkd"
        '
        'kdbrg
        '
        Me.kdbrg.HeaderText = "Kode Barang"
        Me.kdbrg.Name = "kdbrg"
        Me.kdbrg.Width = 150
        '
        'nmbrg
        '
        Me.nmbrg.HeaderText = "Nama Barang"
        Me.nmbrg.Name = "nmbrg"
        Me.nmbrg.Width = 200
        '
        'qtybrg
        '
        Me.qtybrg.HeaderText = "QTY"
        Me.qtybrg.Name = "qtybrg"
        Me.qtybrg.Width = 50
        '
        'hrg
        '
        Me.hrg.HeaderText = "Harga"
        Me.hrg.Name = "hrg"
        '
        'FrmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 350)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BubbleBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPenjualan"
        CType(Me.dtFb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ttlfbB As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txthrgB As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtqtyB As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents dtFb1 As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tfktJual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txNmCust As System.Windows.Forms.TextBox
    Friend WithEvents tCust As System.Windows.Forms.TextBox
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents btnAdd As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BtnRefresh As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BtnOff As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents idkd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kdbrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nmbrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qtybrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hrg As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

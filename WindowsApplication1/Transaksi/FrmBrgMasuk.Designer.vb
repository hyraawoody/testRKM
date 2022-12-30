<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBrgMasuk
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
        Me.tkdsup = New System.Windows.Forms.TextBox()
        Me.txnmsup = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg1 = New System.Windows.Forms.DataGridView()
        Me.idkd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kdbrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nmbrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtybrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txfak = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFb = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.bbaddfb = New DevComponents.DotNetBar.BubbleButton()
        Me.bbreffb = New DevComponents.DotNetBar.BubbleButton()
        Me.BubbleButton3 = New DevComponents.DotNetBar.BubbleButton()
        Me.txtqty = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txthrg = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ttlfb = New DevComponents.DotNetBar.Controls.TextBoxX()
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tkdsup
        '
        Me.tkdsup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tkdsup.Location = New System.Drawing.Point(107, 42)
        Me.tkdsup.Name = "tkdsup"
        Me.tkdsup.Size = New System.Drawing.Size(172, 20)
        Me.tkdsup.TabIndex = 0
        '
        'txnmsup
        '
        Me.txnmsup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txnmsup.Location = New System.Drawing.Point(107, 68)
        Me.txnmsup.Name = "txnmsup"
        Me.txnmsup.ReadOnly = True
        Me.txnmsup.Size = New System.Drawing.Size(172, 20)
        Me.txnmsup.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kode Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nama Supplier"
        '
        'dg1
        '
        Me.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idkd, Me.kdbrg, Me.nmbrg, Me.qtybrg, Me.hrg})
        Me.dg1.Location = New System.Drawing.Point(4, 125)
        Me.dg1.Name = "dg1"
        Me.dg1.Size = New System.Drawing.Size(558, 150)
        Me.dg1.TabIndex = 18
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
        '
        'nmbrg
        '
        Me.nmbrg.HeaderText = "Nama Barang"
        Me.nmbrg.Name = "nmbrg"
        '
        'qtybrg
        '
        Me.qtybrg.HeaderText = "QTY"
        Me.qtybrg.Name = "qtybrg"
        '
        'hrg
        '
        Me.hrg.HeaderText = "Harga"
        Me.hrg.Name = "hrg"
        '
        'txfak
        '
        Me.txfak.Location = New System.Drawing.Point(107, 13)
        Me.txfak.Name = "txfak"
        Me.txfak.ReadOnly = True
        Me.txfak.Size = New System.Drawing.Size(172, 20)
        Me.txfak.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "No Faktur Beli"
        '
        'dtFb
        '
        '
        '
        '
        Me.dtFb.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtFb.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFb.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtFb.ButtonDropDown.Visible = True
        Me.dtFb.IsPopupCalendarOpen = False
        Me.dtFb.Location = New System.Drawing.Point(346, 12)
        '
        '
        '
        Me.dtFb.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFb.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtFb.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtFb.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFb.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtFb.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtFb.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFb.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtFb.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtFb.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtFb.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtFb.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtFb.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFb.MonthCalendar.DisplayMonth = New Date(2022, 7, 1, 0, 0, 0, 0)
        Me.dtFb.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtFb.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtFb.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtFb.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtFb.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtFb.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtFb.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtFb.MonthCalendar.TodayButtonVisible = True
        Me.dtFb.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtFb.Name = "dtFb"
        Me.dtFb.Size = New System.Drawing.Size(200, 20)
        Me.dtFb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtFb.TabIndex = 21
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
        Me.BubbleBar1.Location = New System.Drawing.Point(0, 264)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(562, 54)
        Me.BubbleBar1.TabIndex = 22
        Me.BubbleBar1.Tabs.Add(Me.BubbleBarTab1)
        Me.BubbleBar1.TabsVisible = False
        '
        'BubbleBarTab1
        '
        Me.BubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.bbaddfb, Me.bbreffb, Me.BubbleButton3})
        Me.BubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab1.Name = "BubbleBarTab1"
        Me.BubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab1.Text = "BubbleBarTab1"
        Me.BubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'bbaddfb
        '
        Me.bbaddfb.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.bbaddfb.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.add
        Me.bbaddfb.Name = "bbaddfb"
        Me.bbaddfb.TooltipText = "Add"
        '
        'bbreffb
        '
        Me.bbreffb.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.bbreffb.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.bbreffb.Name = "bbreffb"
        Me.bbreffb.TooltipText = "Refresh"
        '
        'BubbleButton3
        '
        Me.BubbleButton3.Image = Global.WindowsApplication1.My.Resources.Resources.off
        Me.BubbleButton3.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.off
        Me.BubbleButton3.Name = "BubbleButton3"
        Me.BubbleButton3.TooltipText = "Close"
        '
        'txtqty
        '
        '
        '
        '
        Me.txtqty.Border.Class = "TextBoxBorder"
        Me.txtqty.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtqty.Location = New System.Drawing.Point(346, 41)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(100, 20)
        Me.txtqty.TabIndex = 23
        '
        'txthrg
        '
        '
        '
        '
        Me.txthrg.Border.Class = "TextBoxBorder"
        Me.txthrg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txthrg.Location = New System.Drawing.Point(452, 41)
        Me.txthrg.Name = "txthrg"
        Me.txthrg.Size = New System.Drawing.Size(100, 20)
        Me.txthrg.TabIndex = 24
        '
        'ttlfb
        '
        '
        '
        '
        Me.ttlfb.Border.Class = "TextBoxBorder"
        Me.ttlfb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ttlfb.Location = New System.Drawing.Point(398, 67)
        Me.ttlfb.Name = "ttlfb"
        Me.ttlfb.Size = New System.Drawing.Size(100, 20)
        Me.ttlfb.TabIndex = 25
        '
        'FrmBrgMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 318)
        Me.Controls.Add(Me.ttlfb)
        Me.Controls.Add(Me.txthrg)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.BubbleBar1)
        Me.Controls.Add(Me.dtFb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txfak)
        Me.Controls.Add(Me.dg1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txnmsup)
        Me.Controls.Add(Me.tkdsup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FrmBrgMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBrgMasuk"
        CType(Me.dg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tkdsup As System.Windows.Forms.TextBox
    Friend WithEvents txnmsup As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dg1 As System.Windows.Forms.DataGridView
    Friend WithEvents txfak As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents idkd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kdbrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nmbrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qtybrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtFb As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents bbaddfb As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bbreffb As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton3 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents txtqty As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txthrg As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ttlfb As DevComponents.DotNetBar.Controls.TextBoxX
End Class

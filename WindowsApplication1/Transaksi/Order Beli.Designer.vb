<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Beli
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Order_Beli))
        Me.txno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtob = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.pKepala = New DevComponents.DotNetBar.PanelEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txket = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txnmsup = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbsup = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TextBoxX3 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.pntotal = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.CustomColorBlender1 = New DevComponents.DotNetBar.ColorPickers.CustomColorBlender()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.BubbleBar1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.bbsave = New DevComponents.DotNetBar.BubbleButton()
        Me.bbclear = New DevComponents.DotNetBar.BubbleButton()
        Me.BubbleButton3 = New DevComponents.DotNetBar.BubbleButton()
        CType(Me.dtob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pKepala.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txno
        '
        Me.txno.Location = New System.Drawing.Point(96, 9)
        Me.txno.Name = "txno"
        Me.txno.ReadOnly = True
        Me.txno.Size = New System.Drawing.Size(160, 20)
        Me.txno.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No Order Beli"
        '
        'dtob
        '
        '
        '
        '
        Me.dtob.BackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtob.BackgroundStyle.BackColor2 = System.Drawing.Color.Cyan
        Me.dtob.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial
        Me.dtob.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.DashDotDot
        Me.dtob.BackgroundStyle.BorderColor = System.Drawing.Color.Black
        Me.dtob.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.DashDotDot
        Me.dtob.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.DashDotDot
        Me.dtob.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.DashDotDot
        Me.dtob.BackgroundStyle.BorderTopColor = System.Drawing.Color.Black
        Me.dtob.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtob.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.dtob.BackgroundStyle.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Square
        Me.dtob.BackgroundStyle.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Square
        Me.dtob.BackgroundStyle.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Rounded
        Me.dtob.BackgroundStyle.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Rounded
        Me.dtob.BackgroundStyle.Font = New System.Drawing.Font("Sitka Small", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtob.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtob.ButtonDropDown.Visible = True
        Me.dtob.CustomFormat = "dd/MM/yyyy"
        Me.dtob.IsPopupCalendarOpen = False
        Me.dtob.Location = New System.Drawing.Point(388, 7)
        '
        '
        '
        Me.dtob.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtob.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.dtob.MonthCalendar.BackgroundStyle.Class = ""
        Me.dtob.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtob.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtob.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtob.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtob.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtob.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtob.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtob.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtob.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.dtob.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtob.MonthCalendar.DisplayMonth = New Date(2022, 7, 1, 0, 0, 0, 0)
        Me.dtob.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtob.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtob.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtob.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtob.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtob.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.dtob.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtob.MonthCalendar.TodayButtonVisible = True
        Me.dtob.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtob.Name = "dtob"
        Me.dtob.Size = New System.Drawing.Size(150, 20)
        Me.dtob.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtob.TabIndex = 2
        '
        'pKepala
        '
        Me.pKepala.CanvasColor = System.Drawing.SystemColors.Control
        Me.pKepala.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pKepala.Controls.Add(Me.Label4)
        Me.pKepala.Controls.Add(Me.txket)
        Me.pKepala.Controls.Add(Me.Label3)
        Me.pKepala.Controls.Add(Me.txnmsup)
        Me.pKepala.Controls.Add(Me.Label2)
        Me.pKepala.Controls.Add(Me.cbsup)
        Me.pKepala.Controls.Add(Me.Label1)
        Me.pKepala.Controls.Add(Me.txno)
        Me.pKepala.Location = New System.Drawing.Point(-8, 35)
        Me.pKepala.Name = "pKepala"
        Me.pKepala.Size = New System.Drawing.Size(572, 69)
        Me.pKepala.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pKepala.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pKepala.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pKepala.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pKepala.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pKepala.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pKepala.Style.GradientAngle = 90
        Me.pKepala.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(278, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Keterangan"
        '
        'txket
        '
        '
        '
        '
        Me.txket.Border.Class = "TextBoxBorder"
        Me.txket.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txket.Location = New System.Drawing.Point(357, 31)
        Me.txket.Multiline = True
        Me.txket.Name = "txket"
        Me.txket.Size = New System.Drawing.Size(189, 35)
        Me.txket.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(278, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Supplier"
        '
        'txnmsup
        '
        '
        '
        '
        Me.txnmsup.Border.Class = "TextBoxBorder"
        Me.txnmsup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txnmsup.Location = New System.Drawing.Point(357, 8)
        Me.txnmsup.Name = "txnmsup"
        Me.txnmsup.ReadOnly = True
        Me.txnmsup.Size = New System.Drawing.Size(189, 20)
        Me.txnmsup.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kode Supplier"
        '
        'cbsup
        '
        Me.cbsup.DisplayMember = "Text"
        Me.cbsup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbsup.FormattingEnabled = True
        Me.cbsup.ItemHeight = 14
        Me.cbsup.Location = New System.Drawing.Point(96, 36)
        Me.cbsup.Name = "cbsup"
        Me.cbsup.Size = New System.Drawing.Size(160, 20)
        Me.cbsup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbsup.TabIndex = 2
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(2, 110)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(550, 172)
        Me.DataGridViewX1.TabIndex = 4
        '
        'TextBoxX2
        '
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.Location = New System.Drawing.Point(2, 288)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxX2.TabIndex = 5
        Me.TextBoxX2.Visible = False
        '
        'TextBoxX3
        '
        '
        '
        '
        Me.TextBoxX3.Border.Class = "TextBoxBorder"
        Me.TextBoxX3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX3.Location = New System.Drawing.Point(115, 288)
        Me.TextBoxX3.Name = "TextBoxX3"
        Me.TextBoxX3.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxX3.TabIndex = 6
        Me.TextBoxX3.Visible = False
        '
        'pntotal
        '
        Me.pntotal.CanvasColor = System.Drawing.SystemColors.Control
        Me.pntotal.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.pntotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pntotal.Location = New System.Drawing.Point(380, 0)
        Me.pntotal.Name = "pntotal"
        Me.pntotal.Size = New System.Drawing.Size(175, 50)
        Me.pntotal.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.pntotal.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.pntotal.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.pntotal.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.pntotal.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.pntotal.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.pntotal.Style.GradientAngle = 90
        Me.pntotal.TabIndex = 7
        Me.pntotal.Text = "Total"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.CustomColorBlender1)
        Me.PanelEx2.Controls.Add(Me.PanelEx3)
        Me.PanelEx2.Controls.Add(Me.pntotal)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx2.Location = New System.Drawing.Point(0, 285)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(555, 90)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 8
        '
        'CustomColorBlender1
        '
        Me.CustomColorBlender1.Location = New System.Drawing.Point(-8, 55)
        Me.CustomColorBlender1.Name = "CustomColorBlender1"
        Me.CustomColorBlender1.Size = New System.Drawing.Size(572, 23)
        Me.CustomColorBlender1.TabIndex = 9
        Me.CustomColorBlender1.Text = "CustomColorBlender1"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.BubbleBar1)
        Me.PanelEx3.Location = New System.Drawing.Point(3, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(371, 50)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 8
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
        Me.BubbleBar1.Location = New System.Drawing.Point(0, 14)
        Me.BubbleBar1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.BubbleBar1.Name = "BubbleBar1"
        Me.BubbleBar1.SelectedTab = Me.BubbleBarTab1
        Me.BubbleBar1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.BubbleBar1.Size = New System.Drawing.Size(371, 36)
        Me.BubbleBar1.TabIndex = 0
        Me.BubbleBar1.Tabs.Add(Me.BubbleBarTab1)
        Me.BubbleBar1.TabsVisible = False
        '
        'BubbleBarTab1
        '
        Me.BubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.bbsave, Me.bbclear, Me.BubbleButton3})
        Me.BubbleBarTab1.DarkBorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BubbleBarTab1.LightBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BubbleBarTab1.Name = "BubbleBarTab1"
        Me.BubbleBarTab1.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue
        Me.BubbleBarTab1.Text = "BubbleBarTab1"
        Me.BubbleBarTab1.TextColor = System.Drawing.Color.Black
        '
        'bbsave
        '
        Me.bbsave.Image = Global.WindowsApplication1.My.Resources.Resources.add
        Me.bbsave.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.add
        Me.bbsave.Name = "bbsave"
        Me.bbsave.TooltipText = "Add"
        '
        'bbclear
        '
        Me.bbclear.Image = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.bbclear.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.bbclear.Name = "bbclear"
        Me.bbclear.TooltipText = "Refresh"
        '
        'BubbleButton3
        '
        Me.BubbleButton3.Image = CType(resources.GetObject("BubbleButton3.Image"), System.Drawing.Image)
        Me.BubbleButton3.ImageLarge = CType(resources.GetObject("BubbleButton3.ImageLarge"), System.Drawing.Image)
        Me.BubbleButton3.Name = "BubbleButton3"
        '
        'Order_Beli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 375)
        Me.Controls.Add(Me.PanelEx2)
        Me.Controls.Add(Me.TextBoxX3)
        Me.Controls.Add(Me.TextBoxX2)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.pKepala)
        Me.Controls.Add(Me.dtob)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Order_Beli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order_Beli"
        CType(Me.dtob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pKepala.ResumeLayout(False)
        Me.pKepala.PerformLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        CType(Me.BubbleBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtob As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents pKepala As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbsup As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txnmsup As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txket As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TextBoxX3 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents pntotal As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents BubbleBar1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents bbsave As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bbclear As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents BubbleButton3 As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents CustomColorBlender1 As DevComponents.DotNetBar.ColorPickers.CustomColorBlender
End Class

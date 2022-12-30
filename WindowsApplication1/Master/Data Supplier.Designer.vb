<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Supplier
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
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.txkdsup = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txnmsup = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txalmsup = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txkotas = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txemail = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TextBoxX6 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.CustomColorBlender1 = New DevComponents.DotNetBar.ColorPickers.CustomColorBlender()
        Me.bb1 = New DevComponents.DotNetBar.BubbleBar()
        Me.BubbleBarTab1 = New DevComponents.DotNetBar.BubbleBarTab(Me.components)
        Me.bbadd = New DevComponents.DotNetBar.BubbleButton()
        Me.bbdel = New DevComponents.DotNetBar.BubbleButton()
        Me.bbubah = New DevComponents.DotNetBar.BubbleButton()
        Me.bbclose = New DevComponents.DotNetBar.BubbleButton()
        Me.bbref = New DevComponents.DotNetBar.BubbleButton()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridViewX1.Location = New System.Drawing.Point(2, 116)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.Size = New System.Drawing.Size(733, 150)
        Me.DataGridViewX1.TabIndex = 1
        '
        'txkdsup
        '
        '
        '
        '
        Me.txkdsup.Border.Class = "TextBoxBorder"
        Me.txkdsup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txkdsup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txkdsup.Location = New System.Drawing.Point(2, 23)
        Me.txkdsup.Name = "txkdsup"
        Me.txkdsup.Size = New System.Drawing.Size(85, 20)
        Me.txkdsup.TabIndex = 2
        '
        'txnmsup
        '
        '
        '
        '
        Me.txnmsup.Border.Class = "TextBoxBorder"
        Me.txnmsup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txnmsup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txnmsup.Location = New System.Drawing.Point(93, 23)
        Me.txnmsup.Multiline = True
        Me.txnmsup.Name = "txnmsup"
        Me.txnmsup.Size = New System.Drawing.Size(137, 45)
        Me.txnmsup.TabIndex = 3
        '
        'txalmsup
        '
        '
        '
        '
        Me.txalmsup.Border.Class = "TextBoxBorder"
        Me.txalmsup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txalmsup.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txalmsup.Location = New System.Drawing.Point(236, 23)
        Me.txalmsup.Multiline = True
        Me.txalmsup.Name = "txalmsup"
        Me.txalmsup.Size = New System.Drawing.Size(220, 45)
        Me.txalmsup.TabIndex = 4
        '
        'txkotas
        '
        '
        '
        '
        Me.txkotas.Border.Class = "TextBoxBorder"
        Me.txkotas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txkotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txkotas.Location = New System.Drawing.Point(462, 23)
        Me.txkotas.Name = "txkotas"
        Me.txkotas.Size = New System.Drawing.Size(136, 20)
        Me.txkotas.TabIndex = 5
        '
        'txemail
        '
        '
        '
        '
        Me.txemail.Border.Class = "TextBoxBorder"
        Me.txemail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txemail.Location = New System.Drawing.Point(604, 23)
        Me.txemail.Name = "txemail"
        Me.txemail.Size = New System.Drawing.Size(122, 20)
        Me.txemail.TabIndex = 6
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(741, 310)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -3
        Me.LineShape2.X2 = 742
        Me.LineShape2.Y1 = 109
        Me.LineShape2.Y2 = 109
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 745
        Me.LineShape1.Y1 = 73
        Me.LineShape1.Y2 = 73
        '
        'TextBoxX6
        '
        '
        '
        '
        Me.TextBoxX6.Border.Class = "TextBoxBorder"
        Me.TextBoxX6.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxX6.Location = New System.Drawing.Point(93, 82)
        Me.TextBoxX6.Name = "TextBoxX6"
        Me.TextBoxX6.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxX6.TabIndex = 8
        '
        'CustomColorBlender1
        '
        Me.CustomColorBlender1.Location = New System.Drawing.Point(245, 73)
        Me.CustomColorBlender1.Name = "CustomColorBlender1"
        Me.CustomColorBlender1.Size = New System.Drawing.Size(493, 37)
        Me.CustomColorBlender1.TabIndex = 9
        Me.CustomColorBlender1.Text = "CustomColorBlender1"
        '
        'bb1
        '
        Me.bb1.Alignment = DevComponents.DotNetBar.eBubbleButtonAlignment.Top
        Me.bb1.AntiAlias = True
        '
        '
        '
        Me.bb1.BackgroundStyle.Class = ""
        Me.bb1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.bb1.ButtonBackAreaStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.bb1.ButtonBackAreaStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bb1.ButtonBackAreaStyle.BorderBottomWidth = 1
        Me.bb1.ButtonBackAreaStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.bb1.ButtonBackAreaStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bb1.ButtonBackAreaStyle.BorderLeftWidth = 1
        Me.bb1.ButtonBackAreaStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bb1.ButtonBackAreaStyle.BorderRightWidth = 1
        Me.bb1.ButtonBackAreaStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.bb1.ButtonBackAreaStyle.BorderTopWidth = 1
        Me.bb1.ButtonBackAreaStyle.Class = ""
        Me.bb1.ButtonBackAreaStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.bb1.ButtonBackAreaStyle.PaddingBottom = 3
        Me.bb1.ButtonBackAreaStyle.PaddingLeft = 3
        Me.bb1.ButtonBackAreaStyle.PaddingRight = 3
        Me.bb1.ButtonBackAreaStyle.PaddingTop = 3
        Me.bb1.ButtonSpacing = 10
        Me.bb1.ImageSizeNormal = New System.Drawing.Size(24, 24)
        Me.bb1.Location = New System.Drawing.Point(93, 266)
        Me.bb1.MouseOverTabColors.BorderColor = System.Drawing.SystemColors.Highlight
        Me.bb1.Name = "bb1"
        Me.bb1.SelectedTab = Me.BubbleBarTab1
        Me.bb1.SelectedTabColors.BorderColor = System.Drawing.Color.Black
        Me.bb1.Size = New System.Drawing.Size(560, 41)
        Me.bb1.TabIndex = 10
        Me.bb1.Tabs.Add(Me.BubbleBarTab1)
        Me.bb1.TabsVisible = False
        '
        'BubbleBarTab1
        '
        Me.BubbleBarTab1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.BubbleBarTab1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.BubbleBarTab1.Buttons.AddRange(New DevComponents.DotNetBar.BubbleButton() {Me.bbadd, Me.bbdel, Me.bbubah, Me.bbclose, Me.bbref})
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
        'bbubah
        '
        Me.bbubah.Image = Global.WindowsApplication1.My.Resources.Resources.edit
        Me.bbubah.ImageLarge = Global.WindowsApplication1.My.Resources.Resources.edit
        Me.bbubah.Name = "bbubah"
        Me.bbubah.TooltipText = "Update"
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
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(10, -1)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(70, 21)
        Me.LabelX1.TabIndex = 11
        Me.LabelX1.Text = "Kode Supplier"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(118, 1)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(81, 21)
        Me.LabelX2.TabIndex = 12
        Me.LabelX2.Text = "Nama Supplier"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Location = New System.Drawing.Point(298, 0)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(86, 21)
        Me.LabelX3.TabIndex = 13
        Me.LabelX3.Text = "Alamat Supplier"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Location = New System.Drawing.Point(496, 0)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(70, 21)
        Me.LabelX4.TabIndex = 14
        Me.LabelX4.Text = "      Kota"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Location = New System.Drawing.Point(629, 0)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(70, 21)
        Me.LabelX5.TabIndex = 15
        Me.LabelX5.Text = "       Email"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Location = New System.Drawing.Point(17, 80)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(70, 21)
        Me.LabelX6.TabIndex = 16
        Me.LabelX6.Text = "FIND"
        '
        'Data_Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 310)
        Me.Controls.Add(Me.LabelX6)
        Me.Controls.Add(Me.LabelX5)
        Me.Controls.Add(Me.LabelX4)
        Me.Controls.Add(Me.LabelX3)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.bb1)
        Me.Controls.Add(Me.CustomColorBlender1)
        Me.Controls.Add(Me.TextBoxX6)
        Me.Controls.Add(Me.txemail)
        Me.Controls.Add(Me.txkotas)
        Me.Controls.Add(Me.txalmsup)
        Me.Controls.Add(Me.txnmsup)
        Me.Controls.Add(Me.txkdsup)
        Me.Controls.Add(Me.DataGridViewX1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Data_Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents txkdsup As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txnmsup As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txalmsup As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txkotas As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txemail As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TextBoxX6 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents CustomColorBlender1 As DevComponents.DotNetBar.ColorPickers.CustomColorBlender
    Friend WithEvents bb1 As DevComponents.DotNetBar.BubbleBar
    Friend WithEvents BubbleBarTab1 As DevComponents.DotNetBar.BubbleBarTab
    Friend WithEvents bbadd As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bbdel As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bbref As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bbclose As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents bbubah As DevComponents.DotNetBar.BubbleButton
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
End Class

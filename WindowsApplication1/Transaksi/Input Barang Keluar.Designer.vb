<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Input_Barang_Keluar
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
        Me.txqty = New System.Windows.Forms.TextBox()
        Me.txnmbrg = New System.Windows.Forms.TextBox()
        Me.txkdbrg = New System.Windows.Forms.TextBox()
        Me.txid = New System.Windows.Forms.TextBox()
        Me.txharga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txqtyjual = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txqty
        '
        Me.txqty.Location = New System.Drawing.Point(84, 94)
        Me.txqty.Name = "txqty"
        Me.txqty.Size = New System.Drawing.Size(161, 20)
        Me.txqty.TabIndex = 7
        '
        'txnmbrg
        '
        Me.txnmbrg.Location = New System.Drawing.Point(84, 68)
        Me.txnmbrg.Name = "txnmbrg"
        Me.txnmbrg.Size = New System.Drawing.Size(161, 20)
        Me.txnmbrg.TabIndex = 6
        '
        'txkdbrg
        '
        Me.txkdbrg.Location = New System.Drawing.Point(84, 42)
        Me.txkdbrg.Name = "txkdbrg"
        Me.txkdbrg.Size = New System.Drawing.Size(161, 20)
        Me.txkdbrg.TabIndex = 5
        '
        'txid
        '
        Me.txid.Location = New System.Drawing.Point(84, 16)
        Me.txid.Name = "txid"
        Me.txid.Size = New System.Drawing.Size(161, 20)
        Me.txid.TabIndex = 4
        '
        'txharga
        '
        Me.txharga.Location = New System.Drawing.Point(84, 163)
        Me.txharga.Name = "txharga"
        Me.txharga.Size = New System.Drawing.Size(161, 20)
        Me.txharga.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Harga Jual"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txqtyjual
        '
        Me.txqtyjual.Location = New System.Drawing.Point(84, 124)
        Me.txqtyjual.Name = "txqtyjual"
        Me.txqtyjual.Size = New System.Drawing.Size(161, 20)
        Me.txqtyjual.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "QTY Jual"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(84, 124)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(78, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(159, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2000
        Me.GroupPanel1.Controls.Add(Me.Button1)
        Me.GroupPanel1.Controls.Add(Me.Button3)
        Me.GroupPanel1.Controls.Add(Me.Button2)
        Me.GroupPanel1.Location = New System.Drawing.Point(5, 196)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(240, 63)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 20
        Me.GroupPanel1.Text = "Choice"
        '
        'Input_Barang_Keluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 265)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txqtyjual)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txharga)
        Me.Controls.Add(Me.txqty)
        Me.Controls.Add(Me.txnmbrg)
        Me.Controls.Add(Me.txkdbrg)
        Me.Controls.Add(Me.txid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Input_Barang_Keluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input_Barang_Keluar"
        Me.GroupPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txqty As System.Windows.Forms.TextBox
    Friend WithEvents txnmbrg As System.Windows.Forms.TextBox
    Friend WithEvents txkdbrg As System.Windows.Forms.TextBox
    Friend WithEvents txid As System.Windows.Forms.TextBox
    Friend WithEvents txharga As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txqtyjual As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
End Class

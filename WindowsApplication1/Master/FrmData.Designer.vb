<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmData
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
        Me.grid2 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kdbrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nmbrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nofaktur_Jual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrgfb3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid2
        '
        Me.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.kdbrg, Me.nmbrg, Me.Nofaktur_Jual, Me.qty3, Me.hrgfb3})
        Me.grid2.Location = New System.Drawing.Point(10, 52)
        Me.grid2.Name = "grid2"
        Me.grid2.ReadOnly = True
        Me.grid2.Size = New System.Drawing.Size(744, 150)
        Me.grid2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(589, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Num Of Record"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Location = New System.Drawing.Point(127, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "FIND NO FAKTUR"
        '
        'id
        '
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "ID BARANG"
        Me.id.Name = "id"
        '
        'kdbrg
        '
        Me.kdbrg.DataPropertyName = "kdbrg"
        Me.kdbrg.HeaderText = "KODE BARANG"
        Me.kdbrg.Name = "kdbrg"
        Me.kdbrg.Width = 150
        '
        'nmbrg
        '
        Me.nmbrg.DataPropertyName = "nmbrg"
        Me.nmbrg.HeaderText = "NAMA BARANG"
        Me.nmbrg.Name = "nmbrg"
        Me.nmbrg.Width = 150
        '
        'Nofaktur_Jual
        '
        Me.Nofaktur_Jual.DataPropertyName = "Nofaktur_Jual"
        Me.Nofaktur_Jual.HeaderText = "No Faktur"
        Me.Nofaktur_Jual.Name = "Nofaktur_Jual"
        Me.Nofaktur_Jual.Width = 120
        '
        'qty3
        '
        Me.qty3.DataPropertyName = "qty3"
        Me.qty3.HeaderText = "QTY BELI"
        Me.qty3.Name = "qty3"
        '
        'hrgfb3
        '
        Me.hrgfb3.DataPropertyName = "hrgfb3"
        Me.hrgfb3.HeaderText = "HARGA BELI"
        Me.hrgfb3.Name = "hrgfb3"
        Me.hrgfb3.Width = 120
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(368, 2)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX1.Size = New System.Drawing.Size(102, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Total Qty"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(465, 2)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.SingleLineColor = System.Drawing.Color.Transparent
        Me.LabelX2.Size = New System.Drawing.Size(102, 23)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LabelX2.TabIndex = 6
        Me.LabelX2.Text = "Nilai Faktur"
        '
        'FrmData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 214)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmData"
        CType(Me.grid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents kdbrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nmbrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nofaktur_Jual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hrgfb3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class

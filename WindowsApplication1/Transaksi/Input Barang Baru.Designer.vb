<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Input_Barang_Baru
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
        Me.txnmbrg = New System.Windows.Forms.TextBox()
        Me.txkdbrg = New System.Windows.Forms.TextBox()
        Me.txid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txnmbrg
        '
        Me.txnmbrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txnmbrg.Location = New System.Drawing.Point(88, 76)
        Me.txnmbrg.Name = "txnmbrg"
        Me.txnmbrg.Size = New System.Drawing.Size(161, 20)
        Me.txnmbrg.TabIndex = 5
        '
        'txkdbrg
        '
        Me.txkdbrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txkdbrg.Location = New System.Drawing.Point(88, 50)
        Me.txkdbrg.Name = "txkdbrg"
        Me.txkdbrg.Size = New System.Drawing.Size(161, 20)
        Me.txkdbrg.TabIndex = 4
        '
        'txid
        '
        Me.txid.Location = New System.Drawing.Point(88, 24)
        Me.txid.Name = "txid"
        Me.txid.Size = New System.Drawing.Size(161, 20)
        Me.txid.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nama Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID Barang"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Input_Barang_Baru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 142)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txnmbrg)
        Me.Controls.Add(Me.txkdbrg)
        Me.Controls.Add(Me.txid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Input_Barang_Baru"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input_Barang_Baru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txnmbrg As System.Windows.Forms.TextBox
    Friend WithEvents txkdbrg As System.Windows.Forms.TextBox
    Friend WithEvents txid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

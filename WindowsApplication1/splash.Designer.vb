<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ProgressBarX1
        '
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.Class = ""
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.ChunkColor = System.Drawing.Color.Yellow
        Me.ProgressBarX1.ChunkColor2 = System.Drawing.Color.Blue
        Me.ProgressBarX1.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Paused
        Me.ProgressBarX1.Location = New System.Drawing.Point(3, 28)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee
        Me.ProgressBarX1.Size = New System.Drawing.Size(604, 17)
        Me.ProgressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7
        Me.ProgressBarX1.TabIndex = 1
        Me.ProgressBarX1.Text = "ProgressBarX1"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(185, 0)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(234, 23)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "APLIKASI INVENTORY SEDERHANA"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(195, 46)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(202, 21)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005
        Me.LabelX2.TabIndex = 3
        Me.LabelX2.Text = "Copyright 2022 by woodyadmoko"
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 71)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.ProgressBarX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splash"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
End Class

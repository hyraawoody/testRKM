<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Print
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MstBrgBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PersediaanDataSet1 = New WindowsApplication1.PersediaanDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MstBrgTableAdapter = New WindowsApplication1.PersediaanDataSet1TableAdapters.MstBrgTableAdapter()
        Me.PersediaanDataSet2 = New WindowsApplication1.PersediaanDataSet2()
        CType(Me.MstBrgBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersediaanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersediaanDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MstBrgBindingSource
        '
        Me.MstBrgBindingSource.DataMember = "MstBrg"
        Me.MstBrgBindingSource.DataSource = Me.PersediaanDataSet1
        '
        'PersediaanDataSet1
        '
        Me.PersediaanDataSet1.DataSetName = "PersediaanDataSet1"
        Me.PersediaanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MstBrgBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(541, 261)
        Me.ReportViewer1.TabIndex = 0
        '
        'MstBrgTableAdapter
        '
        Me.MstBrgTableAdapter.ClearBeforeFill = True
        '
        'PersediaanDataSet2
        '
        Me.PersediaanDataSet2.DataSetName = "PersediaanDataSet2"
        Me.PersediaanDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 261)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Print"
        Me.Text = "Print"
        CType(Me.MstBrgBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersediaanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersediaanDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MstBrgBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PersediaanDataSet1 As WindowsApplication1.PersediaanDataSet1
    Friend WithEvents MstBrgTableAdapter As WindowsApplication1.PersediaanDataSet1TableAdapters.MstBrgTableAdapter
    Friend WithEvents PersediaanDataSet2 As WindowsApplication1.PersediaanDataSet2
End Class

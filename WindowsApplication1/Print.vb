Public Class Print

    Private Sub Print_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PersediaanDataSet1.MstBrg' table. You can move, or remove it, as needed.
        Me.MstBrgTableAdapter.Fill(Me.PersediaanDataSet1.MstBrg)
        'TODO: This line of code loads data into the 'PersediaanDataSet1.MstBrg' table. You can move, or remove it, as needed.
        'Me.MstBrgTableAdapter.Fill(Me.PersediaanDataSet1.MstBrg)
        'TODO: This line of code loads data into the 'PersediaanDataSet2.MstBrg' table. You can move, or remove it, as needed.
        ' Me.MstBrgTableAdapter.Fill(Me.PersediaanDataSet2.MstBrg)
        'TODO: This line of code loads data into the 'PersediaanDataSet1.MstBrg' table. You can move, or remove it, as needed.
        'Me.MstBrgTableAdapter.Fill(Me.PersediaanDataSet1.MstBrg)

        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class
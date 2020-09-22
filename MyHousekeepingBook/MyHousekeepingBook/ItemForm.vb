Public Class ItemForm
    Private Sub ItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(ByVal dsCategory As CategoryDataSet)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        CategoryDataSet.Merge(dsCategory)
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

End Class
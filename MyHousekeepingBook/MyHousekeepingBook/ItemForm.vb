Public Class ItemForm
    Private Sub ItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub New(ByVal dsCategory As CategoryDataSet)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        CategoryDataSet.Merge(dsCategory)
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

    End Sub

    Public Sub New(dsCategory As CategoryDataSet,
                nowDate As Date,
                category As String,
                item As String,
                money As Integer,
                remarks As String)

        InitializeComponent() '初期化処理
        CategoryDataSet.Merge(dsCategory)
        MonthCalendar1.SetDate(nowDate)
        cmbCategory.Text = category
        txtItem.Text = item
        mtxtMoney.Text = money.ToString()
        txtRemarks.Text = remarks

    End Sub

End Class
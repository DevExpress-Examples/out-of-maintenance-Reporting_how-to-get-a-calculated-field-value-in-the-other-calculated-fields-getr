Imports System
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.Data.Filtering.Helpers
Imports System.Data
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports DevExpress.Data.Browsing
Imports System.Linq

Namespace dxSample
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub calculatedField2_GetValue(ByVal sender As Object, ByVal e As GetValueEventArgs) Handles calculatedField2.GetValue
            Dim expression As String = calculatedField_Base.Expression
            Dim currentRow As Object = GetCurrentRow()
            Dim dataSource As Object = If(calculatedField_Base.DataSource Is Nothing, DataSource, calculatedField_Base.DataSource)
            Dim dataMember As String = calculatedField_Base.DataMember

            Dim props As PropertyDescriptorCollection
            Using context As New DataContext()
                props = context.GetListItemProperties(dataSource, dataMember)
            End Using
            Dim result As Object = (New ExpressionEvaluator(props, CriteriaOperator.Parse(expression))).Evaluate(currentRow)

            e.Value = result
        End Sub
    End Class
End Namespace

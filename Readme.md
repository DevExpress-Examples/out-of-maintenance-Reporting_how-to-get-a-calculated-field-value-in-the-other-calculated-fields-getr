<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* **[XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))**
<!-- default file list end -->
# How to get a calculated field value in the other calculated field's GetResult event handler by using ExpressionEvaluator


This example demonstrates how to evaluate an expression to obtain a calculated field value at runtime. The calculated field value is used to provide the result in another calculated fiel's GetValue event handler.<br><br>To obtain the calculated field value, the auxiliary <strong>DevExpress.Data.Filtering.Helpers.ExpressionEvaluator</strong> class is used. <br>It has the Evaluate method allowing you to obtain an expression value for a certain data row. Please note that the evaluated expression should be constructed according to the <strong><a href="https://documentation.devexpress.com/#CoreLibraries/CustomDocument4928">Criteria Language Syntax</a></strong>.<br><br>You can find other examples of using <strong>DevExpress.Data.Filtering.Helpers.ExpressionEvaluator</strong> here:<br><a href="https://www.devexpress.com/Support/Center/p/T328522">SqlDataSource - How to select those records that do not match the specified filter expression </a><br><a href="https://www.devexpress.com/Support/Center/p/T242016">How to evaluate the calculated field expression</a><br><a href="https://www.devexpress.com/Support/Center/p/T195040">First and last column value</a>

<br/>



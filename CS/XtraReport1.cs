using System;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering.Helpers;
using System.Data;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using DevExpress.Data.Browsing;
using System.Linq;

namespace dxSample {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }
        private void calculatedField2_GetValue(object sender, GetValueEventArgs e) {
            string expression = calculatedField_Base.Expression;
            object currentRow = GetCurrentRow();
            object dataSource = calculatedField_Base.DataSource == null ? DataSource : calculatedField_Base.DataSource;
            string dataMember = calculatedField_Base.DataMember;

            PropertyDescriptorCollection props;
            using(DataContext context = new DataContext()) {
                props = context.GetListItemProperties(dataSource, dataMember);
            }
            object result = new ExpressionEvaluator(props, CriteriaOperator.Parse(expression)).Evaluate(currentRow);
            
            e.Value = result;
        }
    }
}

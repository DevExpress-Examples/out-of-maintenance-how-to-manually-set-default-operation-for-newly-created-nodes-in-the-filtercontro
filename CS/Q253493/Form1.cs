using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Filtering;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using Q253493.FilterControl;

namespace Q253493 {
    public partial class Form1 :Form {
        private const string Field1 = "Field1";
        private const string Field2 = "Field2";

        public Form1() {
            InitializeComponent();
            InitializeUnboundColumns();
        }

        private void InitializeUnboundColumns() {
            filterControl.FilterColumns.Add(new UnboundFilterColumn("Column 1", Field1, typeof(string), textEditor, 
                    FilterColumnClauseClass.String));
            filterControl.FilterColumns.Add(new UnboundFilterColumn("Column 2", Field2, typeof(int), spinEditor,
                    FilterColumnClauseClass.Generic));
        }

        void OnGetDefaultOperation(object sender, GetDefaultOperationEventArgs e) {
            switch (e.OperandProperty.Name) {
                case Field1: e.ClauseType = ClauseType.Contains; break;
                case Field2: e.ClauseType = ClauseType.Greater; break;
            }
        }
    }
}

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

namespace Q253493 {
    public partial class Form1 :Form {
        private const string Field1 = "Field1";
        private const string Field2 = "Field2";

        public Form1() {
            InitializeComponent();
            InitializeUnboundColumns();
        }

        private void InitializeUnboundColumns() {
            MyFilterColumnCollection columns = new MyFilterColumnCollection();
            columns.Add(new UnboundFilterColumn("Column 1", Field1, typeof(string), textEditor, 
                    FilterColumnClauseClass.String));
            columns.Add(new UnboundFilterColumn("Column 2", Field2, typeof(int), spinEditor,
                    FilterColumnClauseClass.Generic));
            columns.OnGetDefaultOperation += OnFilterColumnCollectionGetDefaultOperation;
            filterControl.SetFilterColumnsCollection(columns);
        }

        private void OnFilterColumnCollectionGetDefaultOperation(object sender, 
            GetDefaultOperationEventArgs e) {
            switch (e.OperandProperty.PropertyName) {
                case Field1: e.ClauseType = ClauseType.Contains; break;
                case Field2: e.ClauseType = ClauseType.Greater; break;
            }
        }
    }

    public class MyFilterColumnCollection :FilterColumnCollection {
        public MyFilterColumnCollection() : base() { }

        private GetDefaultOperationEventHandler fGetDefaultOperation;
        public event GetDefaultOperationEventHandler OnGetDefaultOperation {
            add { fGetDefaultOperation += value; }
            remove { fGetDefaultOperation -= value; }
        }
        private ClauseType RaiseOnGetDefaultOperation(OperandProperty operandProperty, ClauseType clauseType) {
            GetDefaultOperationEventArgs args = new GetDefaultOperationEventArgs(operandProperty, clauseType); 
            if (fGetDefaultOperation != null)
                fGetDefaultOperation(this, args);
            return args.ClauseType;
        }

        public override ClauseType GetDefaultOperation(OperandProperty operandProperty) {
            return RaiseOnGetDefaultOperation(operandProperty, base.GetDefaultOperation(operandProperty));
        }
    }

    public delegate void GetDefaultOperationEventHandler(object sender, GetDefaultOperationEventArgs e);
    public class GetDefaultOperationEventArgs :EventArgs {
        public GetDefaultOperationEventArgs(OperandProperty property, ClauseType operation) {
            fOperandProperty = property;
            fClauseType = operation;
        }

        private ClauseType fClauseType;
        public ClauseType ClauseType { 
            get { return fClauseType; } 
            set { fClauseType = value; }
        }

        private OperandProperty fOperandProperty;
        public OperandProperty OperandProperty { get { return fOperandProperty; } }
    }
}

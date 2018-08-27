using DevExpress.Data;
using DevExpress.XtraEditors.Filtering;

namespace Q253493.FilterControl {
    public class CustomWinFilterTreeNodeModel :WinFilterTreeNodeModel {
        public CustomWinFilterTreeNodeModel(DevExpress.XtraEditors.FilterControl control)
            : base(control) { }

        protected override ClauseNode CreateDefaultClauseNode(IBoundProperty property, IBoundPropertyCollection currentFilterProperties)
        {
            ClauseNode result = base.CreateDefaultClauseNode(property, FilterProperties);
            result.Operation = ((CustomFilterControl)Control).GetDefaultOperationCore(result.Property, result.Operation);
            return result;
        }

        public override ClauseNode CreateClauseNode() {
            return new CustomClauseNode(this);
        }
    }
}

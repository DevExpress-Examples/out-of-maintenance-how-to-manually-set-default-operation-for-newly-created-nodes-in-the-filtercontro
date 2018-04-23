﻿using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Filtering;

namespace Q253493.FilterControl {
    public class CustomClauseNode :ClauseNode {
        public CustomClauseNode(FilterTreeNodeModel model): base(model) { }

        protected override void ClauseNodeFirstOperandChanged(OperandProperty newProp, int elementIndex) {
            base.ClauseNodeFirstOperandChanged(newProp, elementIndex);
            Operation = ((CustomFilterControl)((WinFilterTreeNodeModel)Model).Control).GetDefaultOperationCore(
                FilterProperties.GetProperty(newProp), Operation);
        }
    }
}

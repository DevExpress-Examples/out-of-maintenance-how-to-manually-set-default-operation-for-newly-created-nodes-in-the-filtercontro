using System;
using DevExpress.Data;
using DevExpress.XtraEditors.Filtering;
using DevExpress.Data.Filtering.Helpers;

namespace Q253493.FilterControl {
    public class CustomFilterControl :DevExpress.XtraEditors.FilterControl {
        protected override WinFilterTreeNodeModel CreateModel() {
            return new CustomWinFilterTreeNodeModel(this);
        }

        void RaiseGetDefaultOperation(GetDefaultOperationEventArgs args) {
            EventHandler<GetDefaultOperationEventArgs> handler = Events[fGetDefaultOperation]
                as EventHandler<GetDefaultOperationEventArgs>;
            if (handler != null)
                handler(this, args);
        }

        internal ClauseType GetDefaultOperationCore(IBoundProperty property, ClauseType operation) {
            GetDefaultOperationEventArgs args = new GetDefaultOperationEventArgs(property, operation);
            RaiseGetDefaultOperation(args);
            return args.ClauseType;
        }

        static readonly object fGetDefaultOperation = new object();
        public event EventHandler<GetDefaultOperationEventArgs> GetDefaultOperation {
            add { Events.AddHandler(fGetDefaultOperation, value); }
            remove { Events.RemoveHandler(fGetDefaultOperation, value); }
        }
    }
}

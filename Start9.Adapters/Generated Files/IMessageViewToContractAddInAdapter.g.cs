//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Start9.Api.AddInSideAdapters
{
    
    public class IMessageViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IMessageContract
    {
        private Start9.Api.IMessage _view;
        public IMessageViewToContractAddInAdapter(Start9.Api.IMessage view)
        {
            _view = view;
        }
        public object Object
        {
            get
            {
                return _view.Object;
            }
        }
        public Start9.Api.Contracts.IMessageEntryContract MessageEntry
        {
            get
            {
                return Start9.Api.AddInSideAdapters.IMessageEntryAddInAdapter.ViewToContractAdapter(_view.MessageEntry);
            }
        }
        internal Start9.Api.IMessage GetSourceView()
        {
            return _view;
        }
    }
}


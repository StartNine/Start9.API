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
    
    public class IConfigurationEntryContractToViewAddInAdapter : Start9.Api.IConfigurationEntry
    {
        private Start9.Api.Contracts.IConfigurationEntryContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IConfigurationEntryContractToViewAddInAdapter()
        {
        }
        public IConfigurationEntryContractToViewAddInAdapter(Start9.Api.Contracts.IConfigurationEntryContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public object Object
        {
            get
            {
                return _contract.Object;
            }
        }
        public System.Type Type
        {
            get
            {
                return _contract.Type;
            }
        }
        internal Start9.Api.Contracts.IConfigurationEntryContract GetSourceContract()
        {
            return _contract;
        }
    }
}


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
    
    public class ConfigurationChangedEventArgsContractToViewAddInAdapter : Start9.Api.AConfigurationChangedEventArgs
    {
        private Start9.Api.Contracts.IConfigurationChangedEventArgsContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static ConfigurationChangedEventArgsContractToViewAddInAdapter()
        {
        }
        public ConfigurationChangedEventArgsContractToViewAddInAdapter(Start9.Api.Contracts.IConfigurationChangedEventArgsContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public override Start9.Api.IConfigurationEntry Old
        {
            get
            {
                return Start9.Api.AddInSideAdapters.IConfigurationEntryAddInAdapter.ContractToViewAdapter(_contract.Old);
            }
        }
        public override Start9.Api.IConfigurationEntry New
        {
            get
            {
                return Start9.Api.AddInSideAdapters.IConfigurationEntryAddInAdapter.ContractToViewAdapter(_contract.New);
            }
        }
        internal Start9.Api.Contracts.IConfigurationChangedEventArgsContract GetSourceContract()
        {
            return _contract;
        }
    }
}


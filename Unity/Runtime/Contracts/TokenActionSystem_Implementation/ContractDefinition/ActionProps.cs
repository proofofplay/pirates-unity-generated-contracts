using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.TokenActionSystem_Implementation.ContractDefinition
{
    public partial class ActionProps : ActionPropsBase { }

    public class ActionPropsBase 
    {
        [Parameter("bool", "enabled", 1)]
        public virtual bool Enabled { get; set; }
        [Parameter("bool", "consumable", 2)]
        public virtual bool Consumable { get; set; }
        [Parameter("bytes", "initData", 3)]
        public virtual byte[] InitData { get; set; }
    }
}

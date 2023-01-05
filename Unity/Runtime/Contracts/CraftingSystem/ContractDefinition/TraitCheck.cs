using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.CraftingSystem.ContractDefinition
{
    public partial class TraitCheck : TraitCheckBase { }

    public class TraitCheckBase 
    {
        [Parameter("uint8", "checkType", 1)]
        public virtual byte CheckType { get; set; }
        [Parameter("uint256", "traitId", 2)]
        public virtual BigInteger TraitId { get; set; }
        [Parameter("int256", "traitValue", 3)]
        public virtual BigInteger TraitValue { get; set; }
    }
}

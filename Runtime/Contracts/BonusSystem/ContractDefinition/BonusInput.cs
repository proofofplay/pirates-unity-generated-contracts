using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace SimpleStorage.BonusSystem.ContractDefinition
{
    public partial class BonusInput : BonusInputBase { }

    public class BonusInputBase 
    {
        [Parameter("tuple", "tokenPointer", 1)]
        public virtual TokenPointer TokenPointer { get; set; }
        [Parameter("tuple[]", "traitChecks", 2)]
        public virtual List<TraitCheck> TraitChecks { get; set; }
    }
}

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.CraftingSystem_Implementation.ContractDefinition
{
    public partial class RecipeInput : RecipeInputBase { }

    public class RecipeInputBase 
    {
        [Parameter("tuple", "tokenPointer", 1)]
        public virtual TokenPointer TokenPointer { get; set; }
        [Parameter("tuple[]", "traitChecks", 2)]
        public virtual List<TraitCheck> TraitChecks { get; set; }
        [Parameter("bool", "required", 3)]
        public virtual bool Required { get; set; }
        [Parameter("bool", "consumable", 4)]
        public virtual bool Consumable { get; set; }
        [Parameter("uint256", "failureBurnProbability", 5)]
        public virtual BigInteger FailureBurnProbability { get; set; }
        [Parameter("uint256", "successBurnProbability", 6)]
        public virtual BigInteger SuccessBurnProbability { get; set; }
        [Parameter("uint32", "xpEarnedPercent", 7)]
        public virtual uint XpEarnedPercent { get; set; }
    }
}

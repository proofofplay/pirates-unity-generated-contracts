using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.QuestSystem_Implementation.ContractDefinition
{
    public partial class QuestInput : QuestInputBase { }

    public class QuestInputBase 
    {
        [Parameter("tuple", "tokenPointer", 1)]
        public virtual TokenPointer TokenPointer { get; set; }
        [Parameter("tuple[]", "traitChecks", 2)]
        public virtual List<TraitCheck> TraitChecks { get; set; }
        [Parameter("uint256", "energyRequired", 3)]
        public virtual BigInteger EnergyRequired { get; set; }
        [Parameter("bool", "required", 4)]
        public virtual bool Required { get; set; }
        [Parameter("bool", "consumable", 5)]
        public virtual bool Consumable { get; set; }
        [Parameter("uint32", "failureBurnProbability", 6)]
        public virtual uint FailureBurnProbability { get; set; }
        [Parameter("uint32", "successBurnProbability", 7)]
        public virtual uint SuccessBurnProbability { get; set; }
        [Parameter("uint32", "xpEarnedPercent", 8)]
        public virtual uint XpEarnedPercent { get; set; }
    }
}

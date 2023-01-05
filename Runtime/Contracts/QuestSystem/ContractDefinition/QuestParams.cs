using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.QuestSystem.ContractDefinition
{
    public partial class QuestParams : QuestParamsBase { }

    public class QuestParamsBase 
    {
        [Parameter("uint32", "questId", 1)]
        public virtual uint QuestId { get; set; }
        [Parameter("tuple[]", "inputs", 2)]
        public virtual List<TokenPointer> Inputs { get; set; }
    }
}

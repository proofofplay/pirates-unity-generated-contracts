using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.QuestSystem.ContractDefinition
{
    public partial class ActiveQuest : ActiveQuestBase { }

    public class ActiveQuestBase 
    {
        [Parameter("uint8", "status", 1)]
        public virtual byte Status { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
        [Parameter("uint32", "questId", 3)]
        public virtual uint QuestId { get; set; }
        [Parameter("uint32", "startTime", 4)]
        public virtual uint StartTime { get; set; }
        [Parameter("tuple[]", "inputs", 5)]
        public virtual List<ReservedToken> Inputs { get; set; }
    }
}

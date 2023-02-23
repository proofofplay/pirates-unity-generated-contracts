using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.BossCombatable.ContractDefinition
{
    public partial class CombatStats : CombatStatsBase { }

    public class CombatStatsBase 
    {
        [Parameter("int64", "damage", 1)]
        public virtual long Damage { get; set; }
        [Parameter("int64", "evasion", 2)]
        public virtual long Evasion { get; set; }
        [Parameter("int64", "speed", 3)]
        public virtual long Speed { get; set; }
        [Parameter("int64", "accuracy", 4)]
        public virtual long Accuracy { get; set; }
        [Parameter("uint64", "health", 5)]
        public virtual ulong Health { get; set; }
        [Parameter("uint64", "affinity", 6)]
        public virtual ulong Affinity { get; set; }
        [Parameter("uint64", "move", 7)]
        public virtual ulong Move { get; set; }
    }
}

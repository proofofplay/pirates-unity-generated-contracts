using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.HoldingSystem.ContractDefinition
{
    public partial class Milestone : MilestoneBase { }

    public class MilestoneBase 
    {
        [Parameter("uint256", "timeHeldSeconds", 1)]
        public virtual BigInteger TimeHeldSeconds { get; set; }
        [Parameter("tuple[]", "loots", 2)]
        public virtual List<Loot> Loots { get; set; }
    }
}

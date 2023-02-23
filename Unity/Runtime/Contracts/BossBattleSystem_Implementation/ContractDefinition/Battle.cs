using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.BossBattleSystem_Implementation.ContractDefinition
{
    public partial class Battle : BattleBase { }

    public class BattleBase 
    {
        [Parameter("uint256", "battleEntity", 1)]
        public virtual BigInteger BattleEntity { get; set; }
        [Parameter("uint256", "battleSeed", 2)]
        public virtual BigInteger BattleSeed { get; set; }
        [Parameter("uint256", "attackerEntity", 3)]
        public virtual BigInteger AttackerEntity { get; set; }
        [Parameter("uint256", "defenderEntity", 4)]
        public virtual BigInteger DefenderEntity { get; set; }
        [Parameter("uint256[]", "attackerOverloads", 5)]
        public virtual List<BigInteger> AttackerOverloads { get; set; }
        [Parameter("uint256[]", "defenderOverloads", 6)]
        public virtual List<BigInteger> DefenderOverloads { get; set; }
        [Parameter("address", "attackerCombatable", 7)]
        public virtual string AttackerCombatable { get; set; }
        [Parameter("address", "defenderCombatable", 8)]
        public virtual string DefenderCombatable { get; set; }
    }
}

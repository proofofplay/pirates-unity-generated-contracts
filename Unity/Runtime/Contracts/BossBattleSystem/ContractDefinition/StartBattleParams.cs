using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.BossBattleSystem.ContractDefinition
{
    public partial class StartBattleParams : StartBattleParamsBase { }

    public class StartBattleParamsBase 
    {
        [Parameter("uint256", "battleSeed", 1)]
        public virtual BigInteger BattleSeed { get; set; }
        [Parameter("uint256", "shipEntity", 2)]
        public virtual BigInteger ShipEntity { get; set; }
        [Parameter("uint256", "bossEntity", 3)]
        public virtual BigInteger BossEntity { get; set; }
        [Parameter("uint256[]", "shipOverloads", 4)]
        public virtual List<BigInteger> ShipOverloads { get; set; }
    }
}

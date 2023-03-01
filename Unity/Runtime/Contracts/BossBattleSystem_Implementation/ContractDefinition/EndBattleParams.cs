using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.BossBattleSystem_Implementation.ContractDefinition
{
    public partial class EndBattleParams : EndBattleParamsBase { }

    public class EndBattleParamsBase 
    {
        [Parameter("uint256", "battleEntity", 1)]
        public virtual BigInteger BattleEntity { get; set; }
        [Parameter("uint256", "totalDamageTaken", 2)]
        public virtual BigInteger TotalDamageTaken { get; set; }
        [Parameter("uint256", "totalDamageDealt", 3)]
        public virtual BigInteger TotalDamageDealt { get; set; }
        [Parameter("uint256[]", "moves", 4)]
        public virtual List<BigInteger> Moves { get; set; }
    }
}

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.LootSystem.ContractDefinition
{
    public partial class Loot : LootBase { }

    public class LootBase 
    {
        [Parameter("uint8", "lootType", 1)]
        public virtual byte LootType { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "lootId", 3)]
        public virtual BigInteger LootId { get; set; }
        [Parameter("uint256", "amount", 4)]
        public virtual BigInteger Amount { get; set; }
    }
}

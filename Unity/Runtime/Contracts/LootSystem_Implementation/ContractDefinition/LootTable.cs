using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.LootSystem_Implementation.ContractDefinition
{
    public partial class LootTable : LootTableBase { }

    public class LootTableBase 
    {
        [Parameter("tuple[][]", "loots", 1)]
        public virtual List<List<Loot>> Loots { get; set; }
        [Parameter("uint32[]", "weights", 2)]
        public virtual List<uint> Weights { get; set; }
        [Parameter("uint32[]", "maxSupply", 3)]
        public virtual List<uint> MaxSupply { get; set; }
        [Parameter("uint32[]", "mints", 4)]
        public virtual List<uint> Mints { get; set; }
        [Parameter("uint256", "totalWeight", 5)]
        public virtual BigInteger TotalWeight { get; set; }
    }
}

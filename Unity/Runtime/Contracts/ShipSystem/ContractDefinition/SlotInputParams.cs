using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.ShipSystem.ContractDefinition
{
    public partial class SlotInputParams : SlotInputParamsBase { }

    public class SlotInputParamsBase 
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("address", "gameItemContract", 3)]
        public virtual string GameItemContract { get; set; }
        [Parameter("uint8[]", "slotIds", 4)]
        public virtual List<byte> SlotIds { get; set; }
        [Parameter("uint256[]", "componentIds", 5)]
        public virtual List<BigInteger> ComponentIds { get; set; }
    }
}

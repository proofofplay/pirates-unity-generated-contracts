using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.ShipSystem_Implementation.ContractDefinition
{
    public partial class ShipSlot : ShipSlotBase { }

    public class ShipSlotBase 
    {
        [Parameter("address", "gameItemContractAddress", 1)]
        public virtual string GameItemContractAddress { get; set; }
        [Parameter("uint256", "gameItemId", 2)]
        public virtual BigInteger GameItemId { get; set; }
    }
}

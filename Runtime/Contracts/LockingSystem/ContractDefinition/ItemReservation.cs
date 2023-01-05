using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.LockingSystem.ContractDefinition
{
    public partial class ItemReservation : ItemReservationBase { }

    public class ItemReservationBase 
    {
        [Parameter("uint256", "amount", 1)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bool", "exclusive", 2)]
        public virtual bool Exclusive { get; set; }
        [Parameter("uint32", "timestamp", 3)]
        public virtual uint Timestamp { get; set; }
        [Parameter("uint32", "data", 4)]
        public virtual uint Data { get; set; }
    }
}

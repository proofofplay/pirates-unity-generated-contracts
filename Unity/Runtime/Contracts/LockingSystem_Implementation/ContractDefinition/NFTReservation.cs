using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.LockingSystem_Implementation.ContractDefinition
{
    public partial class NFTReservation : NFTReservationBase { }

    public class NFTReservationBase 
    {
        [Parameter("bool", "exclusive", 1)]
        public virtual bool Exclusive { get; set; }
        [Parameter("uint32", "timestamp", 2)]
        public virtual uint Timestamp { get; set; }
        [Parameter("uint32", "data", 3)]
        public virtual uint Data { get; set; }
    }
}

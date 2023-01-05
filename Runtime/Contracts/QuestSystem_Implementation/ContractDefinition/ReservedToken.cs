using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.QuestSystem_Implementation.ContractDefinition
{
    public partial class ReservedToken : ReservedTokenBase { }

    public class ReservedTokenBase 
    {
        [Parameter("uint8", "tokenType", 1)]
        public virtual byte TokenType { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 4)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("uint32", "reservationId", 5)]
        public virtual uint ReservationId { get; set; }
    }
}

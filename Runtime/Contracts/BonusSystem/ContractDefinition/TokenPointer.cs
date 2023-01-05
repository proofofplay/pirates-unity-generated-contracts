using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace SimpleStorage.BonusSystem.ContractDefinition
{
    public partial class TokenPointer : TokenPointerBase { }

    public class TokenPointerBase 
    {
        [Parameter("uint8", "tokenType", 1)]
        public virtual byte TokenType { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 4)]
        public virtual BigInteger Amount { get; set; }
    }
}

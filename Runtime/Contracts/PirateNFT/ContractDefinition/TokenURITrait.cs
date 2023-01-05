using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.PirateNFT.ContractDefinition
{
    public partial class TokenURITrait : TokenURITraitBase { }

    public class TokenURITraitBase 
    {
        [Parameter("string", "name", 1)]
        public virtual string Name { get; set; }
        [Parameter("string", "stringValue", 2)]
        public virtual string StringValue { get; set; }
        [Parameter("int256", "int256Value", 3)]
        public virtual BigInteger Int256Value { get; set; }
        [Parameter("uint8", "dataType", 4)]
        public virtual byte DataType { get; set; }
        [Parameter("bool", "isTopLevelProperty", 5)]
        public virtual bool IsTopLevelProperty { get; set; }
    }
}

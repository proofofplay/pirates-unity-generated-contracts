using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.GameItemsTokenURIHandler.ContractDefinition
{
    public partial class TokenURITrait : TokenURITraitBase { }

    public class TokenURITraitBase 
    {
        [Parameter("string", "name", 1)]
        public virtual string Name { get; set; }
        [Parameter("bytes", "value", 2)]
        public virtual byte[] Value { get; set; }
        [Parameter("uint8", "dataType", 3)]
        public virtual byte DataType { get; set; }
        [Parameter("bool", "isTopLevelProperty", 4)]
        public virtual bool IsTopLevelProperty { get; set; }
    }
}

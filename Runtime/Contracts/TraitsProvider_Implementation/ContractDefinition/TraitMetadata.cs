using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.TraitsProvider_Implementation.ContractDefinition
{
    public partial class TraitMetadata : TraitMetadataBase { }

    public class TraitMetadataBase 
    {
        [Parameter("string", "name", 1)]
        public virtual string Name { get; set; }
        [Parameter("uint8", "behavior", 2)]
        public virtual byte Behavior { get; set; }
        [Parameter("uint8", "dataType", 3)]
        public virtual byte DataType { get; set; }
        [Parameter("bool", "isTopLevelProperty", 4)]
        public virtual bool IsTopLevelProperty { get; set; }
    }
}

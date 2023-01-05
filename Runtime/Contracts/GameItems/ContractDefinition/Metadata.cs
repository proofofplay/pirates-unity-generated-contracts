using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.GameItems.ContractDefinition
{
    public partial class Metadata : MetadataBase { }

    public class MetadataBase 
    {
        [Parameter("string", "name", 1)]
        public virtual string Name { get; set; }
        [Parameter("string", "imageUrl", 2)]
        public virtual string ImageUrl { get; set; }
    }
}

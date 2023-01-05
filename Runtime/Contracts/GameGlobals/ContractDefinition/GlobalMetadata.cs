using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.GameGlobals.ContractDefinition
{
    public partial class GlobalMetadata : GlobalMetadataBase { }

    public class GlobalMetadataBase 
    {
        [Parameter("string", "name", 1)]
        public virtual string Name { get; set; }
        [Parameter("uint8", "dataType", 2)]
        public virtual byte DataType { get; set; }
    }
}

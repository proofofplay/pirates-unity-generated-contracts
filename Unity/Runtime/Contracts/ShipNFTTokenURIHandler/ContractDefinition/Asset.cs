using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.ShipNFTTokenURIHandler.ContractDefinition
{
    public partial class Asset : AssetBase { }

    public class AssetBase 
    {
        [Parameter("string", "traitName", 1)]
        public virtual string TraitName { get; set; }
        [Parameter("string", "uri", 2)]
        public virtual string Uri { get; set; }
        [Parameter("string", "mimeType", 3)]
        public virtual string MimeType { get; set; }
        [Parameter("uint16", "width", 4)]
        public virtual ushort Width { get; set; }
        [Parameter("uint16", "height", 5)]
        public virtual ushort Height { get; set; }
    }
}

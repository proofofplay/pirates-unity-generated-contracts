using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.GameItems.ContractDefinition
{
    public partial class TypeInfo : TypeInfoBase { }

    public class TypeInfoBase 
    {
        [Parameter("bool", "recyclable", 1)]
        public virtual bool Recyclable { get; set; }
        [Parameter("uint256", "mints", 2)]
        public virtual BigInteger Mints { get; set; }
        [Parameter("uint256", "burns", 3)]
        public virtual BigInteger Burns { get; set; }
        [Parameter("uint256", "maxSupply", 4)]
        public virtual BigInteger MaxSupply { get; set; }
    }
}

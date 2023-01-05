using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace SimpleStorage.BonusSystem.ContractDefinition
{
    public partial class BonusParams : BonusParamsBase { }

    public class BonusParamsBase 
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint32[]", "bonusIds", 2)]
        public virtual List<uint> BonusIds { get; set; }
        [Parameter("tuple", "input", 3)]
        public virtual BonusInput Input { get; set; }
        [Parameter("tuple", "receiver", 4)]
        public virtual BonusReceiver Receiver { get; set; }
        [Parameter("uint256", "principal", 5)]
        public virtual BigInteger Principal { get; set; }
    }
}

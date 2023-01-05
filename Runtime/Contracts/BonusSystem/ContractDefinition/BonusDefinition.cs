using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace SimpleStorage.BonusSystem.ContractDefinition
{
    public partial class BonusDefinition : BonusDefinitionBase { }

    public class BonusDefinitionBase 
    {
        [Parameter("tuple", "receiver", 1)]
        public virtual BonusReceiver Receiver { get; set; }
        [Parameter("tuple", "input", 2)]
        public virtual BonusInput Input { get; set; }
        [Parameter("tuple[]", "requirements", 3)]
        public virtual List<AccountRequirement> Requirements { get; set; }
        [Parameter("uint256", "percentage", 4)]
        public virtual BigInteger Percentage { get; set; }
    }
}

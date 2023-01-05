using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.RequirementSystem_Implementation.ContractDefinition
{
    public partial class AccountRequirement : AccountRequirementBase { }

    public class AccountRequirementBase 
    {
        [Parameter("uint32", "requirementId", 1)]
        public virtual uint RequirementId { get; set; }
        [Parameter("bytes", "requirementData", 2)]
        public virtual byte[] RequirementData { get; set; }
    }
}

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.CraftingSystem_Implementation.ContractDefinition
{
    public partial class CraftParams : CraftParamsBase { }

    public class CraftParamsBase 
    {
        [Parameter("uint32", "recipeId", 1)]
        public virtual uint RecipeId { get; set; }
        [Parameter("tuple[]", "inputs", 2)]
        public virtual List<TokenPointer> Inputs { get; set; }
        [Parameter("uint8", "craftAmount", 3)]
        public virtual byte CraftAmount { get; set; }
    }
}

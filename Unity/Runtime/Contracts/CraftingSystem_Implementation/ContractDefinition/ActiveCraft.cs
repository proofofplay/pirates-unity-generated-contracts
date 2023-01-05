using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.CraftingSystem_Implementation.ContractDefinition
{
    public partial class ActiveCraft : ActiveCraftBase { }

    public class ActiveCraftBase 
    {
        [Parameter("uint8", "status", 1)]
        public virtual byte Status { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
        [Parameter("uint32", "recipeId", 3)]
        public virtual uint RecipeId { get; set; }
        [Parameter("tuple[]", "inputs", 4)]
        public virtual List<ReservedToken> Inputs { get; set; }
        [Parameter("uint8", "craftAmount", 5)]
        public virtual byte CraftAmount { get; set; }
    }
}

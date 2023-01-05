using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace PirateNationContracts.CraftingSystem_Implementation.ContractDefinition
{
    public partial class RecipeDefinition : RecipeDefinitionBase { }

    public class RecipeDefinitionBase 
    {
        [Parameter("bool", "enabled", 1)]
        public virtual bool Enabled { get; set; }
        [Parameter("tuple[]", "requirements", 2)]
        public virtual List<AccountRequirement> Requirements { get; set; }
        [Parameter("tuple[]", "inputs", 3)]
        public virtual List<RecipeInput> Inputs { get; set; }
        [Parameter("tuple[]", "loots", 4)]
        public virtual List<Loot> Loots { get; set; }
        [Parameter("uint32", "baseSuccessProbability", 5)]
        public virtual uint BaseSuccessProbability { get; set; }
        [Parameter("uint32", "cooldownSeconds", 6)]
        public virtual uint CooldownSeconds { get; set; }
        [Parameter("uint32", "successXp", 7)]
        public virtual uint SuccessXp { get; set; }
        [Parameter("uint32", "maxCompletions", 8)]
        public virtual uint MaxCompletions { get; set; }
    }
}

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace SimpleStorage.TraitsLibrary.ContractDefinition
{


    public partial class TraitsLibraryDeployment : TraitsLibraryDeploymentBase
    {
        public TraitsLibraryDeployment() : base(BYTECODE) { }
        public TraitsLibraryDeployment(string byteCode) : base(byteCode) { }
    }

    public class TraitsLibraryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "6102eb61003a600b82828239805160001a60731461002d57634e487b7160e01b600052600060045260246000fd5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600436106101b35760003560e01c806371d0214811610103578063c32dcf2f116100a1578063f04345fe1161007b578063f04345fe14610292578063f8887e641461029b578063fa791fe2146102a4578063fdc25137146102ac57600080fd5b8063c32dcf2f14610278578063cfe9f9a814610280578063d3ccdd431461028957600080fd5b8063843c4378116100dd578063843c43781461025657806397d940991461025e578063bad4b72e14610267578063c08e27ca1461027057600080fd5b806371d021481461023d5780637502b4d8146102455780637a8e93331461024e57600080fd5b80632f854de41161017057806347069f1b1161014a57806347069f1b1461021b5780634c9278fd1461022357806356d5cb7b1461022c57806364359a8d1461023457600080fd5b80632f854de41461020257806342aa633c1461020a578063447495f01461021257600080fd5b806303992be7146101b85780631494d8c5146101da5780631fb337e5146101e2578063243baaf2146101ea5780632baaabd7146101f25780632c5b4eaa146101fa575b600080fd5b6101c16103f281565b60405163ffffffff909116815260200160405180910390f35b6101c1600c81565b6101c1600481565b6101c1600d81565b6101c1600781565b6101c1600381565b6101c1600681565b6101c1600281565b6101c16103ee81565b6101c1600f81565b6101c16103ea81565b6101c1600581565b6101c16103eb81565b6101c1600b81565b6101c16103f081565b6101c1600981565b6101c1600881565b6101c16103f381565b6101c16103f181565b6101c1600a81565b6101c1600e81565b6101c16103ec81565b6101c16103ed81565b6101c16103ef81565b6101c16103e981565b6101c1600181565b6101c16103e88156fea264697066735822122070800d6eb696e0999955f50b48d2f031c536340303d39e64a6d4232d70cd868164736f6c63430008100033";
        public TraitsLibraryDeploymentBase() : base(BYTECODE) { }
        public TraitsLibraryDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class COMMAND_RANK_TRAIT_IDFunction : COMMAND_RANK_TRAIT_IDFunctionBase { }

    [Function("COMMAND_RANK_TRAIT_ID", "uint32")]
    public class COMMAND_RANK_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class DESCRIPTION_TRAIT_IDFunction : DESCRIPTION_TRAIT_IDFunctionBase { }

    [Function("DESCRIPTION_TRAIT_ID", "uint32")]
    public class DESCRIPTION_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class DICE_ROLL_1_TRAIT_IDFunction : DICE_ROLL_1_TRAIT_IDFunctionBase { }

    [Function("DICE_ROLL_1_TRAIT_ID", "uint32")]
    public class DICE_ROLL_1_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class DICE_ROLL_2_TRAIT_IDFunction : DICE_ROLL_2_TRAIT_IDFunctionBase { }

    [Function("DICE_ROLL_2_TRAIT_ID", "uint32")]
    public class DICE_ROLL_2_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class ELEMENTAL_AFFINITY_TRAIT_IDFunction : ELEMENTAL_AFFINITY_TRAIT_IDFunctionBase { }

    [Function("ELEMENTAL_AFFINITY_TRAIT_ID", "uint32")]
    public class ELEMENTAL_AFFINITY_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class GENERATION_TRAIT_IDFunction : GENERATION_TRAIT_IDFunctionBase { }

    [Function("GENERATION_TRAIT_ID", "uint32")]
    public class GENERATION_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class IMAGE_HASH_TRAIT_IDFunction : IMAGE_HASH_TRAIT_IDFunctionBase { }

    [Function("IMAGE_HASH_TRAIT_ID", "uint32")]
    public class IMAGE_HASH_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class IS_NAVY_TRAIT_IDFunction : IS_NAVY_TRAIT_IDFunctionBase { }

    [Function("IS_NAVY_TRAIT_ID", "uint32")]
    public class IS_NAVY_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class NAME_TRAIT_IDFunction : NAME_TRAIT_IDFunctionBase { }

    [Function("NAME_TRAIT_ID", "uint32")]
    public class NAME_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_BACKGROUND_TRAIT_IDFunction : PROFILE_BACKGROUND_TRAIT_IDFunctionBase { }

    [Function("PROFILE_BACKGROUND_TRAIT_ID", "uint32")]
    public class PROFILE_BACKGROUND_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_CHARACTER_TYPEFunction : PROFILE_CHARACTER_TYPEFunctionBase { }

    [Function("PROFILE_CHARACTER_TYPE", "uint32")]
    public class PROFILE_CHARACTER_TYPEFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_COAT_TRAIT_IDFunction : PROFILE_COAT_TRAIT_IDFunctionBase { }

    [Function("PROFILE_COAT_TRAIT_ID", "uint32")]
    public class PROFILE_COAT_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_EARRING_TRAIT_IDFunction : PROFILE_EARRING_TRAIT_IDFunctionBase { }

    [Function("PROFILE_EARRING_TRAIT_ID", "uint32")]
    public class PROFILE_EARRING_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_EYES_TRAIT_IDFunction : PROFILE_EYES_TRAIT_IDFunctionBase { }

    [Function("PROFILE_EYES_TRAIT_ID", "uint32")]
    public class PROFILE_EYES_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_EYE_COVERING_TRAIT_IDFunction : PROFILE_EYE_COVERING_TRAIT_IDFunctionBase { }

    [Function("PROFILE_EYE_COVERING_TRAIT_ID", "uint32")]
    public class PROFILE_EYE_COVERING_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_FACIAL_HAIR_TRAIT_IDFunction : PROFILE_FACIAL_HAIR_TRAIT_IDFunctionBase { }

    [Function("PROFILE_FACIAL_HAIR_TRAIT_ID", "uint32")]
    public class PROFILE_FACIAL_HAIR_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_HAIR_TRAIT_IDFunction : PROFILE_HAIR_TRAIT_IDFunctionBase { }

    [Function("PROFILE_HAIR_TRAIT_ID", "uint32")]
    public class PROFILE_HAIR_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_HEADWEAR_TRAIT_IDFunction : PROFILE_HEADWEAR_TRAIT_IDFunctionBase { }

    [Function("PROFILE_HEADWEAR_TRAIT_ID", "uint32")]
    public class PROFILE_HEADWEAR_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_IS_LEGENDARY_TRAIT_IDFunction : PROFILE_IS_LEGENDARY_TRAIT_IDFunctionBase { }

    [Function("PROFILE_IS_LEGENDARY_TRAIT_ID", "uint32")]
    public class PROFILE_IS_LEGENDARY_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_MAGE_GEM_TRAIT_IDFunction : PROFILE_MAGE_GEM_TRAIT_IDFunctionBase { }

    [Function("PROFILE_MAGE_GEM_TRAIT_ID", "uint32")]
    public class PROFILE_MAGE_GEM_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class PROFILE_SKIN_TRAIT_IDFunction : PROFILE_SKIN_TRAIT_IDFunctionBase { }

    [Function("PROFILE_SKIN_TRAIT_ID", "uint32")]
    public class PROFILE_SKIN_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class RARITY_TRAIT_IDFunction : RARITY_TRAIT_IDFunctionBase { }

    [Function("RARITY_TRAIT_ID", "uint32")]
    public class RARITY_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class SHIP_GOLD_CAPACITY_TRAIT_IDFunction : SHIP_GOLD_CAPACITY_TRAIT_IDFunctionBase { }

    [Function("SHIP_GOLD_CAPACITY_TRAIT_ID", "uint32")]
    public class SHIP_GOLD_CAPACITY_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class SHIP_GOLD_PER_DAY_TRAIT_IDFunction : SHIP_GOLD_PER_DAY_TRAIT_IDFunctionBase { }

    [Function("SHIP_GOLD_PER_DAY_TRAIT_ID", "uint32")]
    public class SHIP_GOLD_PER_DAY_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class SHIP_RANK_TRAIT_IDFunction : SHIP_RANK_TRAIT_IDFunctionBase { }

    [Function("SHIP_RANK_TRAIT_ID", "uint32")]
    public class SHIP_RANK_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class STAR_SIGNFunction : STAR_SIGNFunctionBase { }

    [Function("STAR_SIGN", "uint32")]
    public class STAR_SIGNFunctionBase : FunctionMessage
    {

    }

    public partial class XP_TRAIT_IDFunction : XP_TRAIT_IDFunctionBase { }

    [Function("XP_TRAIT_ID", "uint32")]
    public class XP_TRAIT_IDFunctionBase : FunctionMessage
    {

    }

    public partial class COMMAND_RANK_TRAIT_IDOutputDTO : COMMAND_RANK_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class COMMAND_RANK_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class DESCRIPTION_TRAIT_IDOutputDTO : DESCRIPTION_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class DESCRIPTION_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class DICE_ROLL_1_TRAIT_IDOutputDTO : DICE_ROLL_1_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class DICE_ROLL_1_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class DICE_ROLL_2_TRAIT_IDOutputDTO : DICE_ROLL_2_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class DICE_ROLL_2_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class ELEMENTAL_AFFINITY_TRAIT_IDOutputDTO : ELEMENTAL_AFFINITY_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class ELEMENTAL_AFFINITY_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class GENERATION_TRAIT_IDOutputDTO : GENERATION_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class GENERATION_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class IMAGE_HASH_TRAIT_IDOutputDTO : IMAGE_HASH_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class IMAGE_HASH_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class IS_NAVY_TRAIT_IDOutputDTO : IS_NAVY_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class IS_NAVY_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class NAME_TRAIT_IDOutputDTO : NAME_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class NAME_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_BACKGROUND_TRAIT_IDOutputDTO : PROFILE_BACKGROUND_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_BACKGROUND_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_CHARACTER_TYPEOutputDTO : PROFILE_CHARACTER_TYPEOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_CHARACTER_TYPEOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_COAT_TRAIT_IDOutputDTO : PROFILE_COAT_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_COAT_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_EARRING_TRAIT_IDOutputDTO : PROFILE_EARRING_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_EARRING_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_EYES_TRAIT_IDOutputDTO : PROFILE_EYES_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_EYES_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_EYE_COVERING_TRAIT_IDOutputDTO : PROFILE_EYE_COVERING_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_EYE_COVERING_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_FACIAL_HAIR_TRAIT_IDOutputDTO : PROFILE_FACIAL_HAIR_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_FACIAL_HAIR_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_HAIR_TRAIT_IDOutputDTO : PROFILE_HAIR_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_HAIR_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_HEADWEAR_TRAIT_IDOutputDTO : PROFILE_HEADWEAR_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_HEADWEAR_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_IS_LEGENDARY_TRAIT_IDOutputDTO : PROFILE_IS_LEGENDARY_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_IS_LEGENDARY_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_MAGE_GEM_TRAIT_IDOutputDTO : PROFILE_MAGE_GEM_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_MAGE_GEM_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class PROFILE_SKIN_TRAIT_IDOutputDTO : PROFILE_SKIN_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class PROFILE_SKIN_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class RARITY_TRAIT_IDOutputDTO : RARITY_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class RARITY_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class SHIP_GOLD_CAPACITY_TRAIT_IDOutputDTO : SHIP_GOLD_CAPACITY_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class SHIP_GOLD_CAPACITY_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class SHIP_GOLD_PER_DAY_TRAIT_IDOutputDTO : SHIP_GOLD_PER_DAY_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class SHIP_GOLD_PER_DAY_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class SHIP_RANK_TRAIT_IDOutputDTO : SHIP_RANK_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class SHIP_RANK_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class STAR_SIGNOutputDTO : STAR_SIGNOutputDTOBase { }

    [FunctionOutput]
    public class STAR_SIGNOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }

    public partial class XP_TRAIT_IDOutputDTO : XP_TRAIT_IDOutputDTOBase { }

    [FunctionOutput]
    public class XP_TRAIT_IDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
    }
}

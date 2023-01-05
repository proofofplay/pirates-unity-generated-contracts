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

namespace SimpleStorage.TraitsConsumer.ContractDefinition
{


    public partial class TraitsConsumerDeployment : TraitsConsumerDeploymentBase
    {
        public TraitsConsumerDeployment() : base(BYTECODE) { }
        public TraitsConsumerDeployment(string byteCode) : base(byteCode) { }
    }

    public class TraitsConsumerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public TraitsConsumerDeploymentBase() : base(BYTECODE) { }
        public TraitsConsumerDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class BaseExternalURIFunction : BaseExternalURIFunctionBase { }

    [Function("_baseExternalURI", "string")]
    public class BaseExternalURIFunctionBase : FunctionMessage
    {

    }

    public partial class BaseImageURIFunction : BaseImageURIFunctionBase { }

    [Function("_baseImageURI", "string")]
    public class BaseImageURIFunctionBase : FunctionMessage
    {

    }

    public partial class DefaultDescriptionFunction : DefaultDescriptionFunctionBase { }

    [Function("_defaultDescription", "string")]
    public class DefaultDescriptionFunctionBase : FunctionMessage
    {

    }

    public partial class DefaultImageURIFunction : DefaultImageURIFunctionBase { }

    [Function("_defaultImageURI", "string")]
    public class DefaultImageURIFunctionBase : FunctionMessage
    {

    }

    public partial class UriFunction : UriFunctionBase { }

    [Function("_uri", "string")]
    public class UriFunctionBase : FunctionMessage
    {

    }

    public partial class DecrementTraitFunction : DecrementTraitFunctionBase { }

    [Function("decrementTrait")]
    public class DecrementTraitFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "traitId", 2)]
        public virtual uint TraitId { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class ExternalURIFunction : ExternalURIFunctionBase { }

    [Function("externalURI", "string")]
    public class ExternalURIFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class FulfillRandomWordsCallbackFunction : FulfillRandomWordsCallbackFunctionBase { }

    [Function("fulfillRandomWordsCallback")]
    public class FulfillRandomWordsCallbackFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "requestId", 1)]
        public virtual BigInteger RequestId { get; set; }
        [Parameter("uint256[]", "randomWords", 2)]
        public virtual List<BigInteger> RandomWords { get; set; }
    }

    public partial class GetExtraTraitsFunction : GetExtraTraitsFunctionBase { }

    [Function("getExtraTraits", typeof(GetExtraTraitsOutputDTO))]
    public class GetExtraTraitsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetTraitInt256Function : GetTraitInt256FunctionBase { }

    [Function("getTraitInt256", "int256")]
    public class GetTraitInt256FunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "traitId", 2)]
        public virtual uint TraitId { get; set; }
    }

    public partial class GetTraitUint256Function : GetTraitUint256FunctionBase { }

    [Function("getTraitUint256", "uint256")]
    public class GetTraitUint256FunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "traitId", 2)]
        public virtual uint TraitId { get; set; }
    }

    public partial class GetTraitUint8Function : GetTraitUint8FunctionBase { }

    [Function("getTraitUint8", "uint8")]
    public class GetTraitUint8FunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "traitId", 2)]
        public virtual uint TraitId { get; set; }
    }

    public partial class HasTraitFunction : HasTraitFunctionBase { }

    [Function("hasTrait", "bool")]
    public class HasTraitFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "traitId", 2)]
        public virtual uint TraitId { get; set; }
    }

    public partial class ImageURIFunction : ImageURIFunctionBase { }

    [Function("imageURI", "string")]
    public class ImageURIFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class IncrementTraitFunction : IncrementTraitFunctionBase { }

    [Function("incrementTrait")]
    public class IncrementTraitFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "traitId", 2)]
        public virtual uint TraitId { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SetBaseExternalURIFunction : SetBaseExternalURIFunctionBase { }

    [Function("setBaseExternalURI")]
    public class SetBaseExternalURIFunctionBase : FunctionMessage
    {
        [Parameter("string", "newURI", 1)]
        public virtual string NewURI { get; set; }
    }

    public partial class SetBaseImageURIFunction : SetBaseImageURIFunctionBase { }

    [Function("setBaseImageURI")]
    public class SetBaseImageURIFunctionBase : FunctionMessage
    {
        [Parameter("string", "newURI", 1)]
        public virtual string NewURI { get; set; }
    }

    public partial class SetGameRegistryFunction : SetGameRegistryFunctionBase { }

    [Function("setGameRegistry")]
    public class SetGameRegistryFunctionBase : FunctionMessage
    {
        [Parameter("address", "gameRegistryAddress", 1)]
        public virtual string GameRegistryAddress { get; set; }
    }

    public partial class SetTraitInt256Function : SetTraitInt256FunctionBase { }

    [Function("setTraitInt256")]
    public class SetTraitInt256FunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "traitId", 2)]
        public virtual uint TraitId { get; set; }
        [Parameter("int256", "value", 3)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class SetTraitsProviderFunction : SetTraitsProviderFunctionBase { }

    [Function("setTraitsProvider")]
    public class SetTraitsProviderFunctionBase : FunctionMessage
    {
        [Parameter("address", "traitsProviderAddress", 1)]
        public virtual string TraitsProviderAddress { get; set; }
    }

    public partial class SetURIFunction : SetURIFunctionBase { }

    [Function("setURI")]
    public class SetURIFunctionBase : FunctionMessage
    {
        [Parameter("string", "newURI", 1)]
        public virtual string NewURI { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class TokenDescriptionFunction : TokenDescriptionFunctionBase { }

    [Function("tokenDescription", "string")]
    public class TokenDescriptionFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TokenNameFunction : TokenNameFunctionBase { }

    [Function("tokenName", "string")]
    public class TokenNameFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class BaseExternalURIOutputDTO : BaseExternalURIOutputDTOBase { }

    [FunctionOutput]
    public class BaseExternalURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class BaseImageURIOutputDTO : BaseImageURIOutputDTOBase { }

    [FunctionOutput]
    public class BaseImageURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class DefaultDescriptionOutputDTO : DefaultDescriptionOutputDTOBase { }

    [FunctionOutput]
    public class DefaultDescriptionOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class DefaultImageURIOutputDTO : DefaultImageURIOutputDTOBase { }

    [FunctionOutput]
    public class DefaultImageURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class UriOutputDTO : UriOutputDTOBase { }

    [FunctionOutput]
    public class UriOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class ExternalURIOutputDTO : ExternalURIOutputDTOBase { }

    [FunctionOutput]
    public class ExternalURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class GetExtraTraitsOutputDTO : GetExtraTraitsOutputDTOBase { }

    [FunctionOutput]
    public class GetExtraTraitsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "", 1)]
        public virtual List<TokenURITrait> ReturnValue1 { get; set; }
    }

    public partial class GetTraitInt256OutputDTO : GetTraitInt256OutputDTOBase { }

    [FunctionOutput]
    public class GetTraitInt256OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("int256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetTraitUint256OutputDTO : GetTraitUint256OutputDTOBase { }

    [FunctionOutput]
    public class GetTraitUint256OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetTraitUint8OutputDTO : GetTraitUint8OutputDTOBase { }

    [FunctionOutput]
    public class GetTraitUint8OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }

    public partial class HasTraitOutputDTO : HasTraitOutputDTOBase { }

    [FunctionOutput]
    public class HasTraitOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class ImageURIOutputDTO : ImageURIOutputDTOBase { }

    [FunctionOutput]
    public class ImageURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }















    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class TokenDescriptionOutputDTO : TokenDescriptionOutputDTOBase { }

    [FunctionOutput]
    public class TokenDescriptionOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TokenNameOutputDTO : TokenNameOutputDTOBase { }

    [FunctionOutput]
    public class TokenNameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }


}

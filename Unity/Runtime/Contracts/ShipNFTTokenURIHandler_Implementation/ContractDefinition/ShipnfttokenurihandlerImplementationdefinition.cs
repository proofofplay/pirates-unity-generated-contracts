using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace PirateNationContracts.ShipNFTTokenURIHandler_Implementation.ContractDefinition
{


    public partial class ShipnfttokenurihandlerImplementationDeployment : ShipnfttokenurihandlerImplementationDeploymentBase
    {
        public ShipnfttokenurihandlerImplementationDeployment() : base(BYTECODE) { }
        public ShipnfttokenurihandlerImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class ShipnfttokenurihandlerImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506115aa806100206000396000f3fe608060405234801561001057600080fd5b50600436106100f55760003560e01c806377cedfa911610097578063dfd01ff311610066578063dfd01ff3146101f9578063ed022ebd14610219578063f2fde38b1461022f578063f4bef99c1461024257600080fd5b806377cedfa91461018e5780638da5cb5b146101ae578063c4d66de8146101d3578063dd898b2f146101e657600080fd5b8063572b6c05116100d3578063572b6c051461014a5780635c975abb1461016d5780635d1ca63114610175578063715018a61461018657600080fd5b806306c1cb91146100fa57806316c38b3c1461010e5780632371b58d14610121575b600080fd5b61010c61010836600461106e565b5050565b005b61010c61011c36600461112e565b610262565b61013461012f366004611160565b610283565b6040516101419190611299565b60405180910390f35b61015d6101583660046112ac565b6104c6565b6040519015158152602001610141565b61015d610513565b609854604051908152602001610141565b61010c61059e565b6101a161019c3660046112ac565b6105b2565b60405161014191906112c9565b6033546001600160a01b03165b6040516001600160a01b039091168152602001610141565b61010c6101e13660046112ac565b6105dd565b61010c6101f43660046112ac565b610715565b61020c610207366004611160565b610760565b604051610141919061130d565b60975461010090046001600160a01b03166101bb565b61010c61023d3660046112ac565b6109ab565b610255610250366004611390565b610a21565b60405161014191906113d1565b61026a610ad7565b801561027b57610278610b50565b50565b610278610bed565b6040805160028082526060828101909352849160009082816020015b6102c8604080516080810182526060808252602082015290810160008152600060209091015290565b81526020019060019003908161029f579050506040805160c081018252600c608082019081526b195e1d195c9b985b17dd5c9b60a21b60a0830152815290516374ca428360e01b8152600481018890529192509060208201906001600160a01b038616906374ca428390602401600060405180830381865afa158015610352573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f1916820160405261037a91908101906113e4565b60405160200161038a91906113d1565b60408051808303601f19018152918152908252600460208301526001910152815182906000906103bc576103bc611478565b60200260200101819052506040518060800160405280604051806040016040528060068152602001651b1bd8dad95960d21b81525081526020016103fe610c6e565b60405163a3c0a3cb60e01b81526001600160a01b038a81166004830152602482018a9052919091169063a3c0a3cb90604401602060405180830381865afa15801561044d573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610471919061148e565b6040805191151560208301520160408051808303601f190181529181529082526003602083015260009101528151829060019081106104b2576104b2611478565b602090810291909101015295945050505050565b60975460009061010090046001600160a01b03161580159061050d575061050d7fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610d00565b92915050565b60975460009060ff16806105995750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610575573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610599919061148e565b905090565b6105a6610ad7565b6105b06000610d7b565b565b6001600160a01b03811660009081526099602052604090206060906105d681610dcd565b9392505050565b600054610100900460ff16158080156105fd5750600054600160ff909116105b806106175750303b158015610617575060005460ff166001145b61067f5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff1916600117905580156106a2576000805461ff0019166101001790555b6106cc827f0a334a0edad868c015110baa7966b62e3d1a412c3818a1eb0f831f949e829175610dda565b8015610108576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b61071d610ad7565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102785760405163a4b9148160e01b815260040160405180910390fd5b61079a6040518060a00160405280606081526020016060815260200160608152602001600061ffff168152602001600061ffff1681525090565b6001600160a01b03831660009081526099602090815260408083208584526002810190925291829020825160a081019093528054919291829082906107de906114ab565b80601f016020809104026020016040519081016040528092919081815260200182805461080a906114ab565b80156108575780601f1061082c57610100808354040283529160200191610857565b820191906000526020600020905b81548152906001019060200180831161083a57829003601f168201915b50505050508152602001600182018054610870906114ab565b80601f016020809104026020016040519081016040528092919081815260200182805461089c906114ab565b80156108e95780601f106108be576101008083540402835291602001916108e9565b820191906000526020600020905b8154815290600101906020018083116108cc57829003601f168201915b50505050508152602001600282018054610902906114ab565b80601f016020809104026020016040519081016040528092919081815260200182805461092e906114ab565b801561097b5780601f106109505761010080835404028352916020019161097b565b820191906000526020600020905b81548152906001019060200180831161095e57829003601f168201915b50505091835250506003919091015461ffff80821660208401526201000090910416604090910152949350505050565b6109b3610ad7565b6001600160a01b038116610a185760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610676565b61027881610d7b565b60606000610a4e7f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610e67565b9050806001600160a01b031663d25ba1438585610a6b8888610283565b6040518463ffffffff1660e01b8152600401610a89939291906114e5565b600060405180830381865afa158015610aa6573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f19168201604052610ace91908101906113e4565b95945050505050565b610adf610eda565b6001600160a01b0316610afa6033546001600160a01b031690565b6001600160a01b0316146105b05760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610676565b60975460ff1615610b9a5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610676565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610bd0610eda565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610c3b5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610676565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610bd0610eda565b6097546040516329f20e0f60e11b81527f014f6fb700e688e304b410f81545ae2d4da13a493bf857fd2bf0f97da00bf997600482015260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610cdc573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610599919061150c565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610d57573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105d6919061148e565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b606060006105d683610f08565b600054610100900460ff16610e015760405162461bcd60e51b815260040161067690611529565b610e09610f64565b610e11610f93565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610e545760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610eb6573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061050d919061150c565b600060143610801590610ef15750610ef1336104c6565b15610f03575060131936013560601c90565b503390565b606081600001805480602002602001604051908101604052809291908181526020018280548015610f5857602002820191906000526020600020905b815481526020019060010190808311610f44575b50505050509050919050565b600054610100900460ff16610f8b5760405162461bcd60e51b815260040161067690611529565b6105b0610fc2565b600054610100900460ff16610fba5760405162461bcd60e51b815260040161067690611529565b6105b0610ff9565b600054610100900460ff16610fe95760405162461bcd60e51b815260040161067690611529565b6105b0610ff4610eda565b610d7b565b600054610100900460ff166110205760405162461bcd60e51b815260040161067690611529565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff8111828210171561106657611066611027565b604052919050565b6000806040838503121561108157600080fd5b8235915060208084013567ffffffffffffffff808211156110a157600080fd5b818601915086601f8301126110b557600080fd5b8135818111156110c7576110c7611027565b8060051b91506110d884830161103d565b81815291830184019184810190898411156110f257600080fd5b938501935b83851015611110578435825293850193908501906110f7565b8096505050505050509250929050565b801515811461027857600080fd5b60006020828403121561114057600080fd5b81356105d681611120565b6001600160a01b038116811461027857600080fd5b6000806040838503121561117357600080fd5b823561117e8161114b565b946020939093013593505050565b60005b838110156111a757818101518382015260200161118f565b838111156111b6576000848401525b50505050565b600081518084526111d481602086016020860161118c565b601f01601f19169290920160200192915050565b60008282518085526020808601955060058183821b8501018287016000805b8681101561128a57601f19888503018b5282516080815181875261122d828801826111bc565b915050878201518682038988015261124582826111bc565b91505060408083015188811061126957634e487b7160e01b86526021600452602486fd5b90870152606091820151151591909501529985019991850191600101611207565b50919998505050505050505050565b6020815260006105d660208301846111e8565b6000602082840312156112be57600080fd5b81356105d68161114b565b6020808252825182820181905260009190848201906040850190845b81811015611301578351835292840192918401916001016112e5565b50909695505050505050565b602081526000825160a0602084015261132960c08401826111bc565b90506020840151601f198085840301604086015261134783836111bc565b925060408601519150808584030160608601525061136582826111bc565b915050606084015161ffff80821660808601528060808701511660a086015250508091505092915050565b6000806000606084860312156113a557600080fd5b83356113b08161114b565b925060208401356113c08161114b565b929592945050506040919091013590565b6020815260006105d660208301846111bc565b6000602082840312156113f657600080fd5b815167ffffffffffffffff8082111561140e57600080fd5b818401915084601f83011261142257600080fd5b81518181111561143457611434611027565b611447601f8201601f191660200161103d565b915080825285602082850101111561145e57600080fd5b61146f81602084016020860161118c565b50949350505050565b634e487b7160e01b600052603260045260246000fd5b6000602082840312156114a057600080fd5b81516105d681611120565b600181811c908216806114bf57607f821691505b6020821081036114df57634e487b7160e01b600052602260045260246000fd5b50919050565b60018060a01b0384168152826020820152606060408201526000610ace60608301846111e8565b60006020828403121561151e57600080fd5b81516105d68161114b565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea26469706673582212204e59abc8b8fe70c3e12f19d1aab03bc08b51f5397052632df794d631d9ca91f464736f6c634300080d0033";
        public ShipnfttokenurihandlerImplementationDeploymentBase() : base(BYTECODE) { }
        public ShipnfttokenurihandlerImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class GetAssetFunction : GetAssetFunctionBase { }

    [Function("getAsset", typeof(GetAssetOutputDTO))]
    public class GetAssetFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "traitId", 2)]
        public virtual BigInteger TraitId { get; set; }
    }

    public partial class GetAssetTraitIdsFunction : GetAssetTraitIdsFunctionBase { }

    [Function("getAssetTraitIds", "uint256[]")]
    public class GetAssetTraitIdsFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
    }

    public partial class GetExtraTraitsFunction : GetExtraTraitsFunctionBase { }

    [Function("getExtraTraits", typeof(GetExtraTraitsOutputDTO))]
    public class GetExtraTraitsFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GetGameRegistryFunction : GetGameRegistryFunctionBase { }

    [Function("getGameRegistry", "address")]
    public class GetGameRegistryFunctionBase : FunctionMessage
    {

    }

    public partial class GetIdFunction : GetIdFunctionBase { }

    [Function("getId", "uint256")]
    public class GetIdFunctionBase : FunctionMessage
    {

    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {
        [Parameter("address", "gameRegistryAddress", 1)]
        public virtual string GameRegistryAddress { get; set; }
    }

    public partial class IsTrustedForwarderFunction : IsTrustedForwarderFunctionBase { }

    [Function("isTrustedForwarder", "bool")]
    public class IsTrustedForwarderFunctionBase : FunctionMessage
    {
        [Parameter("address", "forwarder", 1)]
        public virtual string Forwarder { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PausedFunction : PausedFunctionBase { }

    [Function("paused", "bool")]
    public class PausedFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SetGameRegistryFunction : SetGameRegistryFunctionBase { }

    [Function("setGameRegistry")]
    public class SetGameRegistryFunctionBase : FunctionMessage
    {
        [Parameter("address", "gameRegistryAddress", 1)]
        public virtual string GameRegistryAddress { get; set; }
    }

    public partial class SetPausedFunction : SetPausedFunctionBase { }

    [Function("setPaused")]
    public class SetPausedFunctionBase : FunctionMessage
    {
        [Parameter("bool", "shouldPause", 1)]
        public virtual bool ShouldPause { get; set; }
    }

    public partial class TokenURIFunction : TokenURIFunctionBase { }

    [Function("tokenURI", "string")]
    public class TokenURIFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class InitializedEventDTO : InitializedEventDTOBase { }

    [Event("Initialized")]
    public class InitializedEventDTOBase : IEventDTO
    {
        [Parameter("uint8", "version", 1, false )]
        public virtual byte Version { get; set; }
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

    public partial class PausedEventDTO : PausedEventDTOBase { }

    [Event("Paused")]
    public class PausedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false )]
        public virtual string Account { get; set; }
    }

    public partial class UnpausedEventDTO : UnpausedEventDTOBase { }

    [Event("Unpaused")]
    public class UnpausedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false )]
        public virtual string Account { get; set; }
    }



    public partial class MissingRoleError : MissingRoleErrorBase { }

    [Error("MissingRole")]
    public class MissingRoleErrorBase : IErrorDTO
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("bytes32", "expectedRole", 2)]
        public virtual byte[] ExpectedRole { get; set; }
    }



    public partial class GetAssetOutputDTO : GetAssetOutputDTOBase { }

    [FunctionOutput]
    public class GetAssetOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual Asset ReturnValue1 { get; set; }
    }

    public partial class GetAssetTraitIdsOutputDTO : GetAssetTraitIdsOutputDTOBase { }

    [FunctionOutput]
    public class GetAssetTraitIdsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
    }

    public partial class GetExtraTraitsOutputDTO : GetExtraTraitsOutputDTOBase { }

    [FunctionOutput]
    public class GetExtraTraitsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "", 1)]
        public virtual List<TokenURITrait> ReturnValue1 { get; set; }
    }

    public partial class GetGameRegistryOutputDTO : GetGameRegistryOutputDTOBase { }

    [FunctionOutput]
    public class GetGameRegistryOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetIdOutputDTO : GetIdOutputDTOBase { }

    [FunctionOutput]
    public class GetIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class IsTrustedForwarderOutputDTO : IsTrustedForwarderOutputDTOBase { }

    [FunctionOutput]
    public class IsTrustedForwarderOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class PausedOutputDTO : PausedOutputDTOBase { }

    [FunctionOutput]
    public class PausedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }







    public partial class TokenURIOutputDTO : TokenURIOutputDTOBase { }

    [FunctionOutput]
    public class TokenURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }


}

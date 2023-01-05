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

namespace PirateNationContracts.TA_GiveEnergy_Implementation.ContractDefinition
{


    public partial class TaGiveenergyImplementationDeployment : TaGiveenergyImplementationDeploymentBase
    {
        public TaGiveenergyImplementationDeployment() : base(BYTECODE) { }
        public TaGiveenergyImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class TaGiveenergyImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5061102a806100206000396000f3fe608060405234801561001057600080fd5b50600436106100cf5760003560e01c80638da5cb5b1161008c578063c4d66de811610066578063c4d66de814610190578063dd898b2f146101a3578063ed022ebd146101b6578063f2fde38b146101cc57600080fd5b80638da5cb5b146101445780639050ffa214610169578063bb42b3601461017c57600080fd5b806306c1cb91146100d457806316c38b3c146100e8578063572b6c05146100fb5780635c975abb146101235780635d1ca6311461012b578063715018a61461013c575b600080fd5b6100e66100e2366004610ca4565b5050565b005b6100e66100f6366004610d64565b6101df565b61010e610109366004610d96565b610200565b60405190151581526020015b60405180910390f35b61010e61024d565b60985460405190815260200161011a565b6100e66102d8565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161011a565b6100e6610177366004610e23565b6102ec565b61010e61018a366004610ebe565b50600190565b6100e661019e366004610d96565b61055f565b6100e66101b1366004610d96565b610697565b60975461010090046001600160a01b0316610151565b6100e66101da366004610d96565b6106e2565b6101e7610758565b80156101f8576101f56107d1565b50565b6101f561086e565b60975460009061010090046001600160a01b03161580159061024757506102477fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d2836108ef565b92915050565b60975460009060ff16806102d35750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156102af573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102d39190610efb565b905090565b6102e0610758565b6102ea6000610971565b565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb5361031e816103196109c3565b6109f1565b600080838060200190518101906103359190610f18565b91509150886001600160a01b0316826001600160a01b0316636352211e836040518263ffffffff1660e01b815260040161037191815260200190565b602060405180830381865afa15801561038e573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103b29190610f46565b6001600160a01b0316146103d9576040516330cd747160e01b815260040160405180910390fd5b60006104047f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610a9a565b604051630b3f2a6360e01b81526001600160a01b038b81166004830152602482018b90527f61dfd4eb986bd6430f322079d6c4d3bbcbb51b96fc0218628ec2362908aa1bf26044830152919250600091831690630b3f2a6390606401602060405180830381865afa15801561047d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906104a19190610f63565b905060006104ce7fdaad241cf87e359c1cee61c121d111147c0d3638669248f816e3e289aec4e8f5610a9a565b90506001600160a01b038116637b8d7de886866104eb8d87610f7c565b6040516001600160e01b031960e086901b1681526001600160a01b03909316600484015260248301919091526044820152606401600060405180830381600087803b15801561053957600080fd5b505af115801561054d573d6000803e3d6000fd5b50505050505050505050505050505050565b600054610100900460ff161580801561057f5750600054600160ff909116105b806105995750303b158015610599575060005460ff166001145b6106015760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610624576000805461ff0019166101001790555b61064e827f6b6aaa80eba658fae16517e0e804832bdc80968eaced65a3c6e285bbc4cb6d95610b0d565b80156100e2576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b61069f610758565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556101f55760405163a4b9148160e01b815260040160405180910390fd5b6106ea610758565b6001600160a01b03811661074f5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016105f8565b6101f581610971565b6107606109c3565b6001600160a01b031661077b6033546001600160a01b031690565b6001600160a01b0316146102ea5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016105f8565b60975460ff161561081b5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016105f8565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a2586108516109c3565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146108bc5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016105f8565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa6108516109c3565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610946573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061096a9190610efb565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6000601436108015906109da57506109da33610200565b156109ec575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610a48573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610a6c9190610efb565b6100e25760405162b0d32560e11b81526001600160a01b0382166004820152602481018390526044016105f8565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610ae9573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102479190610f46565b600054610100900460ff16610b345760405162461bcd60e51b81526004016105f890610fa9565b610b3c610b9a565b610b44610bc9565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610b875760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600054610100900460ff16610bc15760405162461bcd60e51b81526004016105f890610fa9565b6102ea610bf8565b600054610100900460ff16610bf05760405162461bcd60e51b81526004016105f890610fa9565b6102ea610c2f565b600054610100900460ff16610c1f5760405162461bcd60e51b81526004016105f890610fa9565b6102ea610c2a6109c3565b610971565b600054610100900460ff16610c565760405162461bcd60e51b81526004016105f890610fa9565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff81118282101715610c9c57610c9c610c5d565b604052919050565b60008060408385031215610cb757600080fd5b8235915060208084013567ffffffffffffffff80821115610cd757600080fd5b818601915086601f830112610ceb57600080fd5b813581811115610cfd57610cfd610c5d565b8060051b9150610d0e848301610c73565b8181529183018401918481019089841115610d2857600080fd5b938501935b83851015610d4657843582529385019390850190610d2d565b8096505050505050509250929050565b80151581146101f557600080fd5b600060208284031215610d7657600080fd5b813561096a81610d56565b6001600160a01b03811681146101f557600080fd5b600060208284031215610da857600080fd5b813561096a81610d81565b600082601f830112610dc457600080fd5b813567ffffffffffffffff811115610dde57610dde610c5d565b610df1601f8201601f1916602001610c73565b818152846020838601011115610e0657600080fd5b816020850160208301376000918101602001919091529392505050565b60008060008060008060c08789031215610e3c57600080fd5b8635610e4781610d81565b95506020870135610e5781610d81565b94506040870135935060608701359250608087013567ffffffffffffffff80821115610e8257600080fd5b610e8e8a838b01610db3565b935060a0890135915080821115610ea457600080fd5b50610eb189828a01610db3565b9150509295509295509295565b600060208284031215610ed057600080fd5b813567ffffffffffffffff811115610ee757600080fd5b610ef384828501610db3565b949350505050565b600060208284031215610f0d57600080fd5b815161096a81610d56565b60008060408385031215610f2b57600080fd5b8251610f3681610d81565b6020939093015192949293505050565b600060208284031215610f5857600080fd5b815161096a81610d81565b600060208284031215610f7557600080fd5b5051919050565b6000816000190483118215151615610fa457634e487b7160e01b600052601160045260246000fd5b500290565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea26469706673582212200158637f93fc3ec18c584e96bb21b08cba4e4696cd8a476cce284ecc7de71e7b64736f6c634300080d0033";
        public TaGiveenergyImplementationDeploymentBase() : base(BYTECODE) { }
        public TaGiveenergyImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class IsInitDataValidFunction : IsInitDataValidFunctionBase { }

    [Function("isInitDataValid", "bool")]
    public class IsInitDataValidFunctionBase : FunctionMessage
    {
        [Parameter("bytes", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
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

    public partial class PerformGameItemActionFunction : PerformGameItemActionFunctionBase { }

    [Function("performGameItemAction")]
    public class PerformGameItemActionFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 4)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "", 5)]
        public virtual byte[] ReturnValue5 { get; set; }
        [Parameter("bytes", "runtimeData", 6)]
        public virtual byte[] RuntimeData { get; set; }
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



    public partial class IsInitDataValidOutputDTO : IsInitDataValidOutputDTOBase { }

    [FunctionOutput]
    public class IsInitDataValidOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
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










}

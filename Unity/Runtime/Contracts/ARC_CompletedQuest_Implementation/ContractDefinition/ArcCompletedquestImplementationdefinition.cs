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

namespace PirateNationContracts.ARC_CompletedQuest_Implementation.ContractDefinition
{


    public partial class ArcCompletedquestImplementationDeployment : ArcCompletedquestImplementationDeploymentBase
    {
        public ArcCompletedquestImplementationDeployment() : base(BYTECODE) { }
        public ArcCompletedquestImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class ArcCompletedquestImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610dad806100206000396000f3fe608060405234801561001057600080fd5b50600436106100cf5760003560e01c80638da5cb5b1161008c578063c4d66de811610066578063c4d66de81461018f578063dd898b2f146101a2578063ed022ebd146101b5578063f2fde38b146101cb57600080fd5b80638da5cb5b1461014457806396ae3e2814610169578063c2aa83471461017c57600080fd5b806306c1cb91146100d457806316c38b3c146100e8578063572b6c05146100fb5780635c975abb146101235780635d1ca6311461012b578063715018a61461013c575b600080fd5b6100e66100e2366004610a7f565b5050565b005b6100e66100f6366004610b3f565b6101de565b61010e610109366004610b71565b6101ff565b60405190151581526020015b60405180910390f35b61010e61024c565b60985460405190815260200161011a565b6100e66102d7565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161011a565b61010e610177366004610bfe565b6102eb565b61010e61018a366004610c3b565b610311565b6100e661019d366004610b71565b6103e3565b6100e66101b0366004610b71565b61051b565b60975461010090046001600160a01b0316610151565b6100e66101d9366004610b71565b610566565b6101e66105dc565b80156101f7576101f4610655565b50565b6101f46106f2565b60975460009061010090046001600160a01b03161580159061024657506102467fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610773565b92915050565b60975460009060ff16806102d25750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156102ae573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102d29190610c8b565b905090565b6102df6105dc565b6102e960006107f5565b565b600080828060200190518101906103029190610cc1565b63ffffffff1615159392505050565b600080828060200190518101906103289190610cc1565b905060006103557f6ca5170d1bcda38a89155470b10913febdfd206ef03be60025fbbbc7766d5536610847565b604051634426444360e11b81526001600160a01b03878116600483015263ffffffff8516602483015291925060009183169063884c8886906044016040805180830381865afa1580156103ac573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103d09190610cdc565b5063ffffffff1615159695505050505050565b600054610100900460ff16158080156104035750600054600160ff909116105b8061041d5750303b15801561041d575060005460ff166001145b6104855760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff1916600117905580156104a8576000805461ff0019166101001790555b6104d2827fdc38c937ce2376b71c8dfa5c0c58dbcf2101518f9ccc2ae820aaa6d998345c5d6108ba565b80156100e2576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6105236105dc565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556101f45760405163a4b9148160e01b815260040160405180910390fd5b61056e6105dc565b6001600160a01b0381166105d35760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b606482015260840161047c565b6101f4816107f5565b6105e4610947565b6001600160a01b03166105ff6033546001600160a01b031690565b6001600160a01b0316146102e95760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604482015260640161047c565b60975460ff161561069f5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161047c565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a2586106d5610947565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146107405760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161047c565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa6106d5610947565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa1580156107ca573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906107ee9190610c8b565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610896573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102469190610d0f565b600054610100900460ff166108e15760405162461bcd60e51b815260040161047c90610d2c565b6108e9610975565b6108f16109a4565b60978054610100600160a81b0319166101006001600160a01b038516908102919091179091556109345760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b60006014361080159061095e575061095e336101ff565b15610970575060131936013560601c90565b503390565b600054610100900460ff1661099c5760405162461bcd60e51b815260040161047c90610d2c565b6102e96109d3565b600054610100900460ff166109cb5760405162461bcd60e51b815260040161047c90610d2c565b6102e9610a0a565b600054610100900460ff166109fa5760405162461bcd60e51b815260040161047c90610d2c565b6102e9610a05610947565b6107f5565b600054610100900460ff16610a315760405162461bcd60e51b815260040161047c90610d2c565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff81118282101715610a7757610a77610a38565b604052919050565b60008060408385031215610a9257600080fd5b8235915060208084013567ffffffffffffffff80821115610ab257600080fd5b818601915086601f830112610ac657600080fd5b813581811115610ad857610ad8610a38565b8060051b9150610ae9848301610a4e565b8181529183018401918481019089841115610b0357600080fd5b938501935b83851015610b2157843582529385019390850190610b08565b8096505050505050509250929050565b80151581146101f457600080fd5b600060208284031215610b5157600080fd5b81356107ee81610b31565b6001600160a01b03811681146101f457600080fd5b600060208284031215610b8357600080fd5b81356107ee81610b5c565b600082601f830112610b9f57600080fd5b813567ffffffffffffffff811115610bb957610bb9610a38565b610bcc601f8201601f1916602001610a4e565b818152846020838601011115610be157600080fd5b816020850160208301376000918101602001919091529392505050565b600060208284031215610c1057600080fd5b813567ffffffffffffffff811115610c2757600080fd5b610c3384828501610b8e565b949350505050565b60008060408385031215610c4e57600080fd5b8235610c5981610b5c565b9150602083013567ffffffffffffffff811115610c7557600080fd5b610c8185828601610b8e565b9150509250929050565b600060208284031215610c9d57600080fd5b81516107ee81610b31565b805163ffffffff81168114610cbc57600080fd5b919050565b600060208284031215610cd357600080fd5b6107ee82610ca8565b60008060408385031215610cef57600080fd5b610cf883610ca8565b9150610d0660208401610ca8565b90509250929050565b600060208284031215610d2157600080fd5b81516107ee81610b5c565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea2646970667358221220153c115fe5e7b6678a547fb4151ab4b8399e68113afce5189ed93d8a7b2ad26364736f6c634300080d0033";
        public ArcCompletedquestImplementationDeploymentBase() : base(BYTECODE) { }
        public ArcCompletedquestImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class IsDataValidFunction : IsDataValidFunctionBase { }

    [Function("isDataValid", "bool")]
    public class IsDataValidFunctionBase : FunctionMessage
    {
        [Parameter("bytes", "data", 1)]
        public virtual byte[] Data { get; set; }
    }

    public partial class IsTrustedForwarderFunction : IsTrustedForwarderFunctionBase { }

    [Function("isTrustedForwarder", "bool")]
    public class IsTrustedForwarderFunctionBase : FunctionMessage
    {
        [Parameter("address", "forwarder", 1)]
        public virtual string Forwarder { get; set; }
    }

    public partial class MeetsRequirementFunction : MeetsRequirementFunctionBase { }

    [Function("meetsRequirement", "bool")]
    public class MeetsRequirementFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("bytes", "data", 2)]
        public virtual byte[] Data { get; set; }
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



    public partial class IsDataValidOutputDTO : IsDataValidOutputDTOBase { }

    [FunctionOutput]
    public class IsDataValidOutputDTOBase : IFunctionOutputDTO 
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

    public partial class MeetsRequirementOutputDTO : MeetsRequirementOutputDTOBase { }

    [FunctionOutput]
    public class MeetsRequirementOutputDTOBase : IFunctionOutputDTO 
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

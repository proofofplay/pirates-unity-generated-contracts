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

namespace PirateNationContracts.Randomizer.ContractDefinition
{


    public partial class RandomizerDeployment : RandomizerDeploymentBase
    {
        public RandomizerDeployment() : base(BYTECODE) { }
        public RandomizerDeployment(string byteCode) : base(byteCode) { }
    }

    public class RandomizerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6101006040523480156200001257600080fd5b5060405162000f8d38038062000f8d83398101604081905262000035916200025e565b6001600160a01b038416608052807f61a08aff0763da990caa98ab17070d5b543908be98734b1d6fc5b759bb4d3ba76200007862000072620000f4565b62000126565b600280546001600160a01b0319166001600160a01b0384169081179091556001829055620000b95760405163a4b9148160e01b815260040160405180910390fd5b50506000805460ff60a01b1916600160a01b179055506001600160a01b0390921660a0526001600160401b0390911660c05260e052620002e4565b6000601436108015906200010e57506200010e3362000176565b1562000121575060131936013560601c90565b503390565b600080546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b6002546000906001600160a01b031615801590620001bb5750620001bb7fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283620001c1565b92915050565b6002546040516361b6ebf560e11b8152600481018490526001600160a01b038381166024830152600092169063c36dd7ea90604401602060405180830381865afa15801562000214573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906200023a9190620002c0565b9392505050565b80516001600160a01b03811681146200025957600080fd5b919050565b600080600080608085870312156200027557600080fd5b620002808562000241565b6020860151604087015191955093506001600160401b0381168114620002a557600080fd5b9150620002b56060860162000241565b905092959194509250565b600060208284031215620002d357600080fd5b815180151581146200023a57600080fd5b60805160a05160c05160e051610c6862000325600039600061046d0152600061049c015260006104e201526000818161028301526102c50152610c686000f3fe608060405234801561001057600080fd5b50600436106100ea5760003560e01c80635d1ca6311161008c578063dd898b2f11610066578063dd898b2f146101d6578063df97f69c146101e9578063ed022ebd146101fc578063f2fde38b1461020d57600080fd5b80635d1ca63114610197578063715018a6146101a95780638da5cb5b146101b157600080fd5b806316c38b3c116100c857806316c38b3c146101565780631fe543e314610169578063572b6c051461017c5780635c975abb1461018f57600080fd5b806301ffc9a7146100ef57806306c1cb911461011757806316221fdf1461012b575b600080fd5b6101026100fd3660046109ec565b610220565b60405190151581526020015b60405180910390f35b610129610125366004610a2c565b5050565b005b610102610139366004610af6565b6000908152600360205260409020546001600160a01b0316151590565b610129610164366004610b1d565b610257565b610129610177366004610a2c565b610278565b61010261018a366004610b4f565b610301565b610102610343565b6001545b60405190815260200161010e565b6101296103d3565b6000546001600160a01b03165b6040516001600160a01b03909116815260200161010e565b6101296101e4366004610b4f565b6103e7565b61019b6101f7366004610b6c565b61042a565b6002546001600160a01b03166101be565b61012961021b366004610b4f565b61058a565b60006001600160e01b031982166337e5fda760e21b148061025157506301ffc9a760e01b6001600160e01b03198316145b92915050565b61025f610600565b80156102705761026d610679565b50565b61026d610723565b336001600160a01b037f000000000000000000000000000000000000000000000000000000000000000016146102f75760405163073e64fd60e21b81523360048201526001600160a01b037f00000000000000000000000000000000000000000000000000000000000000001660248201526044015b60405180910390fd5b61012582826107ae565b6002546000906001600160a01b03161580159061025157506102517fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d28361084e565b60008054600160a01b900460ff16806103ce5750600260009054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156103aa573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103ce9190610bae565b905090565b6103db610600565b6103e560006108cb565b565b6103ef610600565b600280546001600160a01b0319166001600160a01b03831690811790915561026d5760405163a4b9148160e01b815260040160405180910390fd5b60007fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb5361045e8161045961091b565b610949565b6040516305d3b1d360e41b81527f0000000000000000000000000000000000000000000000000000000000000000600482015267ffffffffffffffff7f000000000000000000000000000000000000000000000000000000000000000016602482015260036044820152620f4240606482015263ffffffff841660848201526000907f00000000000000000000000000000000000000000000000000000000000000006001600160a01b031690635d3b1d309060a4016020604051808303816000875af1158015610533573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105579190610bcb565b600081815260036020526040902080546001600160a01b0388166001600160a01b03199091161790559250505092915050565b610592610600565b6001600160a01b0381166105f75760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016102ee565b61026d816108cb565b61060861091b565b6001600160a01b03166106236000546001600160a01b031690565b6001600160a01b0316146103e55760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016102ee565b600054600160a01b900460ff16156106ca5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016102ee565b6000805460ff60a01b1916600160a01b1790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a25861070661091b565b6040516001600160a01b03909116815260200160405180910390a1565b600054600160a01b900460ff1615156001146107785760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016102ee565b6000805460ff60a01b191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa61070661091b565b6000828152600360205260409020546001600160a01b03168015610849576040516306c1cb9160e01b81526001600160a01b038216906306c1cb91906107fa9086908690600401610be4565b600060405180830381600087803b15801561081457600080fd5b505af1158015610828573d6000803e3d6000fd5b505050600084815260036020526040902080546001600160a01b0319169055505b505050565b6002546040516361b6ebf560e11b8152600481018490526001600160a01b038381166024830152600092169063c36dd7ea90604401602060405180830381865afa1580156108a0573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906108c49190610bae565b9392505050565b600080546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b600060143610801590610932575061093233610301565b15610944575060131936013560601c90565b503390565b6002546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301529091169063c36dd7ea90604401602060405180830381865afa15801561099a573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109be9190610bae565b6101255760405162b0d32560e11b81526001600160a01b0382166004820152602481018390526044016102ee565b6000602082840312156109fe57600080fd5b81356001600160e01b0319811681146108c457600080fd5b634e487b7160e01b600052604160045260246000fd5b60008060408385031215610a3f57600080fd5b8235915060208084013567ffffffffffffffff80821115610a5f57600080fd5b818601915086601f830112610a7357600080fd5b813581811115610a8557610a85610a16565b8060051b604051601f19603f83011681018181108582111715610aaa57610aaa610a16565b604052918252848201925083810185019189831115610ac857600080fd5b938501935b82851015610ae657843584529385019392850192610acd565b8096505050505050509250929050565b600060208284031215610b0857600080fd5b5035919050565b801515811461026d57600080fd5b600060208284031215610b2f57600080fd5b81356108c481610b0f565b6001600160a01b038116811461026d57600080fd5b600060208284031215610b6157600080fd5b81356108c481610b3a565b60008060408385031215610b7f57600080fd5b8235610b8a81610b3a565b9150602083013563ffffffff81168114610ba357600080fd5b809150509250929050565b600060208284031215610bc057600080fd5b81516108c481610b0f565b600060208284031215610bdd57600080fd5b5051919050565b6000604082018483526020604081850152818551808452606086019150828701935060005b81811015610c2557845183529383019391830191600101610c09565b509097965050505050505056fea26469706673582212209ee739d08c686c1c81f12d9b6933f89253271e3af3c6e507538e42e002a914ca64736f6c634300080d0033";
        public RandomizerDeploymentBase() : base(BYTECODE) { }
        public RandomizerDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_vrfCoordinator", 1)]
        public virtual string VrfCoordinator { get; set; }
        [Parameter("bytes32", "_keyHash", 2)]
        public virtual byte[] KeyHash { get; set; }
        [Parameter("uint64", "_subscriptionId", 3)]
        public virtual ulong SubscriptionId { get; set; }
        [Parameter("address", "_gameRegistryAddress", 4)]
        public virtual string GameRegistryAddress { get; set; }
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

    public partial class IsRequestPendingFunction : IsRequestPendingFunctionBase { }

    [Function("isRequestPending", "bool")]
    public class IsRequestPendingFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "requestId", 1)]
        public virtual BigInteger RequestId { get; set; }
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

    public partial class RawFulfillRandomWordsFunction : RawFulfillRandomWordsFunctionBase { }

    [Function("rawFulfillRandomWords")]
    public class RawFulfillRandomWordsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "requestId", 1)]
        public virtual BigInteger RequestId { get; set; }
        [Parameter("uint256[]", "randomWords", 2)]
        public virtual List<BigInteger> RandomWords { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class RequestRandomWordsFunction : RequestRandomWordsFunctionBase { }

    [Function("requestRandomWords", "uint256")]
    public class RequestRandomWordsFunctionBase : FunctionMessage
    {
        [Parameter("address", "randomizerCallback", 1)]
        public virtual string RandomizerCallback { get; set; }
        [Parameter("uint32", "numWords", 2)]
        public virtual uint NumWords { get; set; }
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

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
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

    public partial class OnlyCoordinatorCanFulfillError : OnlyCoordinatorCanFulfillErrorBase { }

    [Error("OnlyCoordinatorCanFulfill")]
    public class OnlyCoordinatorCanFulfillErrorBase : IErrorDTO
    {
        [Parameter("address", "have", 1)]
        public virtual string Have { get; set; }
        [Parameter("address", "want", 2)]
        public virtual string Want { get; set; }
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

    public partial class IsRequestPendingOutputDTO : IsRequestPendingOutputDTOBase { }

    [FunctionOutput]
    public class IsRequestPendingOutputDTOBase : IFunctionOutputDTO 
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











    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }


}

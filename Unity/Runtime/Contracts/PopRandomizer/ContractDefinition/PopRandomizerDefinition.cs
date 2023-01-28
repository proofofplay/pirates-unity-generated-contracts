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

namespace PirateNationContracts.PopRandomizer.ContractDefinition
{


    public partial class PopRandomizerDeployment : PopRandomizerDeploymentBase
    {
        public PopRandomizerDeployment() : base(BYTECODE) { }
        public PopRandomizerDeployment(string byteCode) : base(byteCode) { }
    }

    public class PopRandomizerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60806040523480156200001157600080fd5b5060405162000ec838038062000ec8833981016040819052620000349162000252565b807f61a08aff0763da990caa98ab17070d5b543908be98734b1d6fc5b759bb4d3ba76200006a62000064620000e8565b6200011a565b600280546001600160a01b0319166001600160a01b0384169081179091556001829055620000ab5760405163a4b9148160e01b815260040160405180910390fd5b50506000805460ff60a01b1916600160a01b17905550600380546001600160a01b039092166001600160a01b0319909216919091179055620002ae565b60006014361080159062000102575062000102336200016a565b1562000115575060131936013560601c90565b503390565b600080546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b6002546000906001600160a01b031615801590620001af5750620001af7fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283620001b5565b92915050565b6002546040516361b6ebf560e11b8152600481018490526001600160a01b038381166024830152600092169063c36dd7ea90604401602060405180830381865afa15801562000208573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906200022e91906200028a565b9392505050565b80516001600160a01b03811681146200024d57600080fd5b919050565b600080604083850312156200026657600080fd5b620002718362000235565b9150620002816020840162000235565b90509250929050565b6000602082840312156200029d57600080fd5b815180151581146200022e57600080fd5b610c0a80620002be6000396000f3fe608060405234801561001057600080fd5b50600436106100ea5760003560e01c8063644b93c61161008c578063dd898b2f11610066578063dd898b2f146101d6578063df97f69c146101e9578063ed022ebd146101fc578063f2fde38b1461020d57600080fd5b8063644b93c614610196578063715018a6146101a95780638da5cb5b146101b157600080fd5b806316c38b3c116100c857806316c38b3c14610156578063572b6c05146101695780635c975abb1461017c5780635d1ca6311461018457600080fd5b806301ffc9a7146100ef57806306c1cb911461011757806316221fdf1461012b575b600080fd5b6101026100fd366004610956565b610220565b60405190151581526020015b60405180910390f35b610129610125366004610996565b5050565b005b610102610139366004610a60565b6000908152600460205260409020546001600160a01b0316151590565b610129610164366004610a87565b610257565b610102610177366004610ab9565b610278565b6101026102ba565b6001545b60405190815260200161010e565b6101296101a4366004610ad6565b61034a565b61012961042c565b6000546001600160a01b03165b6040516001600160a01b03909116815260200161010e565b6101296101e4366004610ab9565b610440565b6101886101f7366004610af8565b610483565b6002546001600160a01b03166101be565b61012961021b366004610ab9565b610594565b60006001600160e01b031982166337e5fda760e21b148061025157506301ffc9a760e01b6001600160e01b03198316145b92915050565b61025f61060a565b80156102705761026d610683565b50565b61026d61072d565b6002546000906001600160a01b03161580159061025157506102517fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d2836107b8565b60008054600160a01b900460ff16806103455750600260009054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610321573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103459190610b3a565b905090565b6000828152600460205260409020546001600160a01b031680156104275760408051600180825281830190925260009160208083019080368337019050509050828160008151811061039e5761039e610b57565b60209081029190910101526040516306c1cb9160e01b81526001600160a01b038316906306c1cb91906103d79087908590600401610b6d565b600060405180830381600087803b1580156103f157600080fd5b505af1158015610405573d6000803e3d6000fd5b505050600085815260046020526040902080546001600160a01b031916905550505b505050565b61043461060a565b61043e6000610835565b565b61044861060a565b600280546001600160a01b0319166001600160a01b03831690811790915561026d5760405163a4b9148160e01b815260040160405180910390fd5b60007fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536104b7816104b2610885565b6108b3565b8263ffffffff166001146104f25760405163734a0f5f60e01b81526001600482015263ffffffff841660248201526044015b60405180910390fd5b6003546040805163338cdca160e01b815290516000926001600160a01b03169163338cdca1916004808301926020929190829003018187875af115801561053d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105619190610bbb565b600081815260046020526040902080546001600160a01b0388166001600160a01b03199091161790559250505092915050565b61059c61060a565b6001600160a01b0381166106015760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016104e9565b61026d81610835565b610612610885565b6001600160a01b031661062d6000546001600160a01b031690565b6001600160a01b03161461043e5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016104e9565b600054600160a01b900460ff16156106d45760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016104e9565b6000805460ff60a01b1916600160a01b1790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610710610885565b6040516001600160a01b03909116815260200160405180910390a1565b600054600160a01b900460ff1615156001146107825760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016104e9565b6000805460ff60a01b191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610710610885565b6002546040516361b6ebf560e11b8152600481018490526001600160a01b038381166024830152600092169063c36dd7ea90604401602060405180830381865afa15801561080a573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061082e9190610b3a565b9392505050565b600080546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b60006014361080159061089c575061089c33610278565b156108ae575060131936013560601c90565b503390565b6002546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301529091169063c36dd7ea90604401602060405180830381865afa158015610904573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109289190610b3a565b6101255760405162b0d32560e11b81526001600160a01b0382166004820152602481018390526044016104e9565b60006020828403121561096857600080fd5b81356001600160e01b03198116811461082e57600080fd5b634e487b7160e01b600052604160045260246000fd5b600080604083850312156109a957600080fd5b8235915060208084013567ffffffffffffffff808211156109c957600080fd5b818601915086601f8301126109dd57600080fd5b8135818111156109ef576109ef610980565b8060051b604051601f19603f83011681018181108582111715610a1457610a14610980565b604052918252848201925083810185019189831115610a3257600080fd5b938501935b82851015610a5057843584529385019392850192610a37565b8096505050505050509250929050565b600060208284031215610a7257600080fd5b5035919050565b801515811461026d57600080fd5b600060208284031215610a9957600080fd5b813561082e81610a79565b6001600160a01b038116811461026d57600080fd5b600060208284031215610acb57600080fd5b813561082e81610aa4565b60008060408385031215610ae957600080fd5b50508035926020909101359150565b60008060408385031215610b0b57600080fd5b8235610b1681610aa4565b9150602083013563ffffffff81168114610b2f57600080fd5b809150509250929050565b600060208284031215610b4c57600080fd5b815161082e81610a79565b634e487b7160e01b600052603260045260246000fd5b6000604082018483526020604081850152818551808452606086019150828701935060005b81811015610bae57845183529383019391830191600101610b92565b5090979650505050505050565b600060208284031215610bcd57600080fd5b505191905056fea26469706673582212204fa76d3f4bcea1faeacf0cb48abd2247df200932ddbb2bba50ef7f67d552a65d64736f6c634300080d0033";
        public PopRandomizerDeploymentBase() : base(BYTECODE) { }
        public PopRandomizerDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_vrfCoordinator", 1)]
        public virtual string VrfCoordinator { get; set; }
        [Parameter("address", "_gameRegistryAddress", 2)]
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

    public partial class RecievedRandomNumberFunction : RecievedRandomNumberFunctionBase { }

    [Function("recievedRandomNumber")]
    public class RecievedRandomNumberFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "requestId", 1)]
        public virtual BigInteger RequestId { get; set; }
        [Parameter("uint256", "randomNumber", 2)]
        public virtual BigInteger RandomNumber { get; set; }
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



    public partial class InvalidNumWordsError : InvalidNumWordsErrorBase { }

    [Error("InvalidNumWords")]
    public class InvalidNumWordsErrorBase : IErrorDTO
    {
        [Parameter("uint256", "expected", 1)]
        public virtual BigInteger Expected { get; set; }
        [Parameter("uint256", "actual", 2)]
        public virtual BigInteger Actual { get; set; }
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

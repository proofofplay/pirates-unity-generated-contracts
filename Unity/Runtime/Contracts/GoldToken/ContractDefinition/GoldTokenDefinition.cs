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

namespace PirateNationContracts.GoldToken.ContractDefinition
{


    public partial class GoldTokenDeployment : GoldTokenDeploymentBase
    {
        public GoldTokenDeployment() : base(BYTECODE) { }
        public GoldTokenDeployment(string byteCode) : base(byteCode) { }
    }

    public class GoldTokenDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60806040523480156200001157600080fd5b506040516200176c3803806200176c833981016040819052620000349162000344565b604080518082018252600b81526a141a5c985d194811dbdb1960aa1b602080830191909152825180840190935260048352631411d31160e21b908301528291827f8295f748d7955cd31cd7354dac4663ef7fb45d79270898ce6535392c6c6d1792620000a9620000a362000135565b62000151565b600280546001600160a01b0319166001600160a01b0384169081179091556001829055620000ea5760405163a4b9148160e01b815260040160405180910390fd5b50506000805460ff60a01b1916600160a01b1790558151620001149060069060208501906200029e565b5080516200012a9060079060208401906200029e565b5050505050620003cf565b60006200014c620001a160201b620007b61760201c565b905090565b600080546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b600060143610801590620001bb5750620001bb33620001d3565b15620001ce575060131936013560601c90565b503390565b6002546000906001600160a01b031615801590620002185750620002187fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d2836200021e565b92915050565b6002546040516361b6ebf560e11b8152600481018490526001600160a01b038381166024830152600092169063c36dd7ea90604401602060405180830381865afa15801562000271573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906200029791906200036f565b9392505050565b828054620002ac9062000393565b90600052602060002090601f016020900481019282620002d057600085556200031b565b82601f10620002eb57805160ff19168380011785556200031b565b828001600101855582156200031b579182015b828111156200031b578251825591602001919060010190620002fe565b50620003299291506200032d565b5090565b5b808211156200032957600081556001016200032e565b6000602082840312156200035757600080fd5b81516001600160a01b03811681146200029757600080fd5b6000602082840312156200038257600080fd5b815180151581146200029757600080fd5b600181811c90821680620003a857607f821691505b602082108103620003c957634e487b7160e01b600052602260045260246000fd5b50919050565b61138d80620003df6000396000f3fe608060405234801561001057600080fd5b50600436106101585760003560e01c806370a08231116100c3578063a9059cbb1161007c578063a9059cbb146102c6578063b5f46b17146102d9578063dd62ed3e146102ec578063dd898b2f146102ff578063ed022ebd14610312578063f2fde38b1461032357600080fd5b806370a0823114610242578063715018a61461026b5780638da5cb5b1461027357806395d89b41146102985780639dc29fac146102a0578063a457c2d7146102b357600080fd5b8063313ce56711610115578063313ce567146101ea57806339509351146101f957806340c10f191461020c578063572b6c051461021f5780635c975abb146102325780635d1ca6311461023a57600080fd5b806306c1cb911461015d57806306fdde0314610171578063095ea7b31461018f57806316c38b3c146101b257806318160ddd146101c557806323b872dd146101d7575b600080fd5b61016f61016b3660046110c0565b5050565b005b610179610336565b604051610186919061118a565b60405180910390f35b6101a261019d3660046111fb565b6103c8565b6040519015158152602001610186565b61016f6101c0366004611233565b6103ea565b6005545b604051908152602001610186565b6101a26101e5366004611250565b61040b565b60405160128152602001610186565b6101a26102073660046111fb565b61046b565b61016f61021a3660046111fb565b610497565b6101a261022d36600461128c565b6104e0565b6101a2610528565b6001546101c9565b6101c961025036600461128c565b6001600160a01b031660009081526003602052604090205490565b61016f6105b8565b6000546001600160a01b03165b6040516001600160a01b039091168152602001610186565b6101796105cc565b61016f6102ae3660046111fb565b6105db565b6101a26102c13660046111fb565b61061a565b6101a26102d43660046111fb565b6106b0565b61016f6102e73660046111fb565b6106c8565b6101c96102fa3660046112a7565b6106d2565b61016f61030d36600461128c565b6106fd565b6002546001600160a01b0316610280565b61016f61033136600461128c565b610740565b606060068054610345906112da565b80601f0160208091040260200160405190810160405280929190818152602001828054610371906112da565b80156103be5780601f10610393576101008083540402835291602001916103be565b820191906000526020600020905b8154815290600101906020018083116103a157829003601f168201915b5050505050905090565b6000806103d36107e4565b90506103e08185856107ee565b5060019392505050565b6103f2610912565b80156104035761040061098b565b50565b610400610a35565b600061043e7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a66104396107e4565b610ac0565b156104565761044e848484610b36565b506001610464565b610461848484610ce3565b90505b9392505050565b6000806104766107e4565b90506103e081858561048885896106d2565b6104929190611314565b6107ee565b61049f610d06565b7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a66104d1816104cc6107e4565b610d4e565b6104db8383610df1565b505050565b6002546000906001600160a01b03161580159061052257506105227fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610ac0565b92915050565b60008054600160a01b900460ff16806105b35750600260009054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa15801561058f573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105b3919061133a565b905090565b6105c0610912565b6105ca6000610eb2565b565b606060078054610345906112da565b6105e3610d06565b7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a6610610816104cc6107e4565b6104db8383610f02565b6000806106256107e4565b9050600061063382866106d2565b9050838110156106985760405162461bcd60e51b815260206004820152602560248201527f45524332303a2064656372656173656420616c6c6f77616e63652062656c6f77604482015264207a65726f60d81b60648201526084015b60405180910390fd5b6106a582868684036107ee565b506001949350505050565b6000806106bb6107e4565b90506103e0818585610b36565b61016b8282610df1565b6001600160a01b03918216600090815260046020908152604080832093909416825291909152205490565b610705610912565b600280546001600160a01b0319166001600160a01b0383169081179091556104005760405163a4b9148160e01b815260040160405180910390fd5b610748610912565b6001600160a01b0381166107ad5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b606482015260840161068f565b61040081610eb2565b6000601436108015906107cd57506107cd336104e0565b156107df575060131936013560601c90565b503390565b60006105b36107b6565b6001600160a01b0383166108505760405162461bcd60e51b8152602060048201526024808201527f45524332303a20617070726f76652066726f6d20746865207a65726f206164646044820152637265737360e01b606482015260840161068f565b6001600160a01b0382166108b15760405162461bcd60e51b815260206004820152602260248201527f45524332303a20617070726f766520746f20746865207a65726f206164647265604482015261737360f01b606482015260840161068f565b6001600160a01b0383811660008181526004602090815260408083209487168084529482529182902085905590518481527f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925910160405180910390a3505050565b61091a6107e4565b6001600160a01b03166109356000546001600160a01b031690565b6001600160a01b0316146105ca5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604482015260640161068f565b600054600160a01b900460ff16156109dc5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161068f565b6000805460ff60a01b1916600160a01b1790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610a186107e4565b6040516001600160a01b03909116815260200160405180910390a1565b600054600160a01b900460ff161515600114610a8a5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161068f565b6000805460ff60a01b191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610a186107e4565b6002546040516361b6ebf560e11b8152600481018490526001600160a01b038381166024830152600092169063c36dd7ea90604401602060405180830381865afa158015610b12573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610464919061133a565b6001600160a01b038316610b9a5760405162461bcd60e51b815260206004820152602560248201527f45524332303a207472616e736665722066726f6d20746865207a65726f206164604482015264647265737360d81b606482015260840161068f565b6001600160a01b038216610bfc5760405162461bcd60e51b815260206004820152602360248201527f45524332303a207472616e7366657220746f20746865207a65726f206164647260448201526265737360e81b606482015260840161068f565b6001600160a01b03831660009081526003602052604090205481811015610c745760405162461bcd60e51b815260206004820152602660248201527f45524332303a207472616e7366657220616d6f756e7420657863656564732062604482015265616c616e636560d01b606482015260840161068f565b6001600160a01b0380851660008181526003602052604080822086860390559286168082529083902080548601905591517fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef90610cd49086815260200190565b60405180910390a35b50505050565b600080610cee6107e4565b9050610cfb858285611036565b6106a5858585610b36565b610d0e610528565b156105ca5760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b604482015260640161068f565b6002546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301529091169063c36dd7ea90604401602060405180830381865afa158015610d9f573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610dc3919061133a565b61016b5760405162b0d32560e11b81526001600160a01b03821660048201526024810183905260440161068f565b6001600160a01b038216610e475760405162461bcd60e51b815260206004820152601f60248201527f45524332303a206d696e7420746f20746865207a65726f206164647265737300604482015260640161068f565b8060056000828254610e599190611314565b90915550506001600160a01b0382166000818152600360209081526040808320805486019055518481527fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef910160405180910390a35050565b600080546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b6001600160a01b038216610f625760405162461bcd60e51b815260206004820152602160248201527f45524332303a206275726e2066726f6d20746865207a65726f206164647265736044820152607360f81b606482015260840161068f565b6001600160a01b03821660009081526003602052604090205481811015610fd65760405162461bcd60e51b815260206004820152602260248201527f45524332303a206275726e20616d6f756e7420657863656564732062616c616e604482015261636560f01b606482015260840161068f565b6001600160a01b03831660008181526003602090815260408083208686039055600580548790039055518581529192917fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef910160405180910390a3505050565b600061104284846106d2565b90506000198114610cdd578181101561109d5760405162461bcd60e51b815260206004820152601d60248201527f45524332303a20696e73756666696369656e7420616c6c6f77616e6365000000604482015260640161068f565b610cdd84848484036107ee565b634e487b7160e01b600052604160045260246000fd5b600080604083850312156110d357600080fd5b8235915060208084013567ffffffffffffffff808211156110f357600080fd5b818601915086601f83011261110757600080fd5b813581811115611119576111196110aa565b8060051b604051601f19603f8301168101818110858211171561113e5761113e6110aa565b60405291825284820192508381018501918983111561115c57600080fd5b938501935b8285101561117a57843584529385019392850192611161565b8096505050505050509250929050565b600060208083528351808285015260005b818110156111b75785810183015185820160400152820161119b565b818111156111c9576000604083870101525b50601f01601f1916929092016040019392505050565b80356001600160a01b03811681146111f657600080fd5b919050565b6000806040838503121561120e57600080fd5b611217836111df565b946020939093013593505050565b801515811461040057600080fd5b60006020828403121561124557600080fd5b813561046481611225565b60008060006060848603121561126557600080fd5b61126e846111df565b925061127c602085016111df565b9150604084013590509250925092565b60006020828403121561129e57600080fd5b610464826111df565b600080604083850312156112ba57600080fd5b6112c3836111df565b91506112d1602084016111df565b90509250929050565b600181811c908216806112ee57607f821691505b60208210810361130e57634e487b7160e01b600052602260045260246000fd5b50919050565b6000821982111561133557634e487b7160e01b600052601160045260246000fd5b500190565b60006020828403121561134c57600080fd5b81516104648161122556fea26469706673582212200f90af907fdfd99706fd256b70a38b7fdbe041039dbaa56b004eb8811689b28e64736f6c634300080d0033";
        public GoldTokenDeploymentBase() : base(BYTECODE) { }
        public GoldTokenDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "gameRegistryAddress", 1)]
        public virtual string GameRegistryAddress { get; set; }
    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "uint256")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2)]
        public virtual string Spender { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve", "bool")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
    }

    public partial class BurnFunction : BurnFunctionBase { }

    [Function("burn")]
    public class BurnFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class DecimalsFunction : DecimalsFunctionBase { }

    [Function("decimals", "uint8")]
    public class DecimalsFunctionBase : FunctionMessage
    {

    }

    public partial class DecreaseAllowanceFunction : DecreaseAllowanceFunctionBase { }

    [Function("decreaseAllowance", "bool")]
    public class DecreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "subtractedValue", 2)]
        public virtual BigInteger SubtractedValue { get; set; }
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

    public partial class IncreaseAllowanceFunction : IncreaseAllowanceFunctionBase { }

    [Function("increaseAllowance", "bool")]
    public class IncreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "addedValue", 2)]
        public virtual BigInteger AddedValue { get; set; }
    }

    public partial class IsTrustedForwarderFunction : IsTrustedForwarderFunctionBase { }

    [Function("isTrustedForwarder", "bool")]
    public class IsTrustedForwarderFunctionBase : FunctionMessage
    {
        [Parameter("address", "forwarder", 1)]
        public virtual string Forwarder { get; set; }
    }

    public partial class MintFunction : MintFunctionBase { }

    [Function("mint")]
    public class MintFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class MintForTestsFunction : MintForTestsFunctionBase { }

    [Function("mintForTests")]
    public class MintForTestsFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

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

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer", "bool")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom", "bool")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
        [Parameter("address", "recipient", 2)]
        public virtual string Recipient { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2, true )]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
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

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
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

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class DecimalsOutputDTO : DecimalsOutputDTOBase { }

    [FunctionOutput]
    public class DecimalsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
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





    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
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

    public partial class PausedOutputDTO : PausedOutputDTOBase { }

    [FunctionOutput]
    public class PausedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }







    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }






}

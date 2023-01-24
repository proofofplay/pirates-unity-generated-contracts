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

namespace PirateNationContracts.GameItemsTokenURIHandler_Implementation.ContractDefinition
{


    public partial class GameitemstokenurihandlerImplementationDeployment : GameitemstokenurihandlerImplementationDeploymentBase
    {
        public GameitemstokenurihandlerImplementationDeployment() : base(BYTECODE) { }
        public GameitemstokenurihandlerImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class GameitemstokenurihandlerImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506112c5806100206000396000f3fe608060405234801561001057600080fd5b50600436106100cf5760003560e01c8063715018a61161008c578063dd898b2f11610066578063dd898b2f146101a0578063ed022ebd146101b3578063f2fde38b146101c9578063f4bef99c146101dc57600080fd5b8063715018a6146101605780638da5cb5b14610168578063c4d66de81461018d57600080fd5b806306c1cb91146100d457806316c38b3c146100e85780632371b58d146100fb578063572b6c05146101245780635c975abb146101475780635d1ca6311461014f575b600080fd5b6100e66100e2366004610e81565b5050565b005b6100e66100f6366004610f41565b6101fc565b61010e610109366004610f73565b61021d565b60405161011b91906110ac565b60405180910390f35b6101376101323660046110bf565b61063f565b604051901515815260200161011b565b61013761068c565b60985460405190815260200161011b565b6100e6610717565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161011b565b6100e661019b3660046110bf565b61072b565b6100e66101ae3660046110bf565b610863565b60975461010090046001600160a01b0316610175565b6100e66101d73660046110bf565b6108ae565b6101ef6101ea3660046110dc565b610924565b60405161011b919061111d565b6102046109b3565b801561021557610212610a2c565b50565b610212610ac9565b60408051600480825260a082019092526060918491600091816020015b610263604080516080810182526060808252602082015290810160008152600060209091015290565b81526020019060019003908161023a579050506040805160c081018252600460808201818152636e616d6560e01b60a08401528252915163e725f87760e01b815291820187905291925060208201906001600160a01b0385169063e725f87790602401600060405180830381865afa1580156102e3573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f1916820160405261030b9190810190611130565b60405160200161031b919061111d565b60408051808303601f190181529181529082526004602083015260019101528151829060009061034d5761034d6111c4565b6020026020010181905250604051806080016040528060405180604001604052806005815260200164696d61676560d81b8152508152602001836001600160a01b0316638f742d16876040518263ffffffff1660e01b81526004016103b491815260200190565b600060405180830381865afa1580156103d1573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526103f99190810190611130565b604051602001610409919061111d565b60408051601f19818403018152919052815260200160048152602001600115158152508160018151811061043f5761043f6111c4565b602002602001018190525060405180608001604052806040518060400160405280600b81526020016a3232b9b1b934b83a34b7b760a91b8152508152602001836001600160a01b031663a0c6d537876040518263ffffffff1660e01b81526004016104ac91815260200190565b600060405180830381865afa1580156104c9573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526104f19190810190611130565b604051602001610501919061111d565b60408051808303601f19018152918152908252600460208301526001910152815182906002908110610535576105356111c4565b602002602001018190525060405180608001604052806040518060400160405280600c81526020016b195e1d195c9b985b17dd5c9b60a21b8152508152602001836001600160a01b03166374ca4283876040518263ffffffff1660e01b81526004016105a391815260200190565b600060405180830381865afa1580156105c0573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526105e89190810190611130565b6040516020016105f8919061111d565b60408051808303601f1901815291815290825260046020830152600191015281518290600390811061062c5761062c6111c4565b6020908102919091010152949350505050565b60975460009061010090046001600160a01b03161580159061068657506106867fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610b4a565b92915050565b60975460009060ff16806107125750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156106ee573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061071291906111da565b905090565b61071f6109b3565b6107296000610bcc565b565b600054610100900460ff161580801561074b5750600054600160ff909116105b806107655750303b158015610765575060005460ff166001145b6107cd5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff1916600117905580156107f0576000805461ff0019166101001790555b61081a827ff01e1531fe9f69c43c079e606512d2a7bf211b0fa0ee89e0fc78705657d4f431610c1e565b80156100e2576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b61086b6109b3565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102125760405163a4b9148160e01b815260040160405180910390fd5b6108b66109b3565b6001600160a01b03811661091b5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016107c4565b61021281610bcc565b606061092e610cab565b6001600160a01b031663d25ba1438484610948878761021d565b6040518463ffffffff1660e01b8152600401610966939291906111f7565b600060405180830381865afa158015610983573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526109ab9190810190611130565b949350505050565b6109bb610cd6565b6001600160a01b03166109d66033546001600160a01b031690565b6001600160a01b0316146107295760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016107c4565b60975460ff1615610a765760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016107c4565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610aac610cd6565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610b175760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016107c4565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610aac610cd6565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610ba1573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610bc591906111da565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600054610100900460ff16610c455760405162461bcd60e51b81526004016107c490611227565b610c4d610d04565b610c55610d33565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610c985760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b60006107127f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610d62565b600060143610801590610ced5750610ced3361063f565b15610cff575060131936013560601c90565b503390565b600054610100900460ff16610d2b5760405162461bcd60e51b81526004016107c490611227565b610729610dd5565b600054610100900460ff16610d5a5760405162461bcd60e51b81526004016107c490611227565b610729610e0c565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610db1573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906106869190611272565b600054610100900460ff16610dfc5760405162461bcd60e51b81526004016107c490611227565b610729610e07610cd6565b610bcc565b600054610100900460ff16610e335760405162461bcd60e51b81526004016107c490611227565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff81118282101715610e7957610e79610e3a565b604052919050565b60008060408385031215610e9457600080fd5b8235915060208084013567ffffffffffffffff80821115610eb457600080fd5b818601915086601f830112610ec857600080fd5b813581811115610eda57610eda610e3a565b8060051b9150610eeb848301610e50565b8181529183018401918481019089841115610f0557600080fd5b938501935b83851015610f2357843582529385019390850190610f0a565b8096505050505050509250929050565b801515811461021257600080fd5b600060208284031215610f5357600080fd5b8135610bc581610f33565b6001600160a01b038116811461021257600080fd5b60008060408385031215610f8657600080fd5b8235610f9181610f5e565b946020939093013593505050565b60005b83811015610fba578181015183820152602001610fa2565b83811115610fc9576000848401525b50505050565b60008151808452610fe7816020860160208601610f9f565b601f01601f19169290920160200192915050565b60008282518085526020808601955060058183821b8501018287016000805b8681101561109d57601f19888503018b5282516080815181875261104082880182610fcf565b91505087820151868203898801526110588282610fcf565b91505060408083015188811061107c57634e487b7160e01b86526021600452602486fd5b9087015260609182015115159190950152998501999185019160010161101a565b50919998505050505050505050565b602081526000610bc56020830184610ffb565b6000602082840312156110d157600080fd5b8135610bc581610f5e565b6000806000606084860312156110f157600080fd5b83356110fc81610f5e565b9250602084013561110c81610f5e565b929592945050506040919091013590565b602081526000610bc56020830184610fcf565b60006020828403121561114257600080fd5b815167ffffffffffffffff8082111561115a57600080fd5b818401915084601f83011261116e57600080fd5b81518181111561118057611180610e3a565b611193601f8201601f1916602001610e50565b91508082528560208285010111156111aa57600080fd5b6111bb816020840160208601610f9f565b50949350505050565b634e487b7160e01b600052603260045260246000fd5b6000602082840312156111ec57600080fd5b8151610bc581610f33565b60018060a01b038416815282602082015260606040820152600061121e6060830184610ffb565b95945050505050565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b60006020828403121561128457600080fd5b8151610bc581610f5e56fea2646970667358221220fb95b43603fffbcc62e79e534a2073ec5e8306c2cf155afcb3fa4128a9cd277564736f6c634300080d0033";
        public GameitemstokenurihandlerImplementationDeploymentBase() : base(BYTECODE) { }
        public GameitemstokenurihandlerImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

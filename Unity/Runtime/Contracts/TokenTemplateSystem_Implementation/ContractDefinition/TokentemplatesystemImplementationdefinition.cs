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

namespace PirateNationContracts.TokenTemplateSystem_Implementation.ContractDefinition
{


    public partial class TokentemplatesystemImplementationDeployment : TokentemplatesystemImplementationDeploymentBase
    {
        public TokentemplatesystemImplementationDeployment() : base(BYTECODE) { }
        public TokentemplatesystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class TokentemplatesystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610c94806100206000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c8063715018a611610071578063715018a6146101345780638da5cb5b1461013c578063c4d66de814610161578063dd898b2f14610174578063ed022ebd14610187578063f2fde38b1461019d57600080fd5b806306c1cb91146100b957806316c38b3c146100cd5780634f558e79146100e0578063572b6c05146101085780635c975abb1461011b5780635d1ca63114610123575b600080fd5b6100cb6100c7366004610a30565b5050565b005b6100cb6100db366004610ae0565b6101b0565b6100f36100ee366004610afd565b6101d1565b60405190151581526020015b60405180910390f35b6100f3610116366004610b2b565b610259565b6100f36102a6565b6098546040519081526020016100ff565b6100cb610331565b6033546001600160a01b03165b6040516001600160a01b0390911681526020016100ff565b6100cb61016f366004610b2b565b610345565b6100cb610182366004610b2b565b61047d565b60975461010090046001600160a01b0316610149565b6100cb6101ab366004610b2b565b6104c8565b6101b861053e565b80156101c9576101c66105b7565b50565b6101c6610654565b6000806101dc6106d5565b604051632c5fa69f60e11b8152306004820152602481018590526001600160a01b0391909116906358bf4d3e90604401600060405180830381865afa158015610229573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526102519190810190610b48565b511192915050565b60975460009061010090046001600160a01b0316158015906102a057506102a07fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610700565b92915050565b60975460009060ff168061032c5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610308573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061032c9190610bd9565b905090565b61033961053e565b6103436000610782565b565b600054610100900460ff16158080156103655750600054600160ff909116105b8061037f5750303b15801561037f575060005460ff166001145b6103e75760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff19166001179055801561040a576000805461ff0019166101001790555b610434827f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a310056107d4565b80156100c7576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b61048561053e565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556101c65760405163a4b9148160e01b815260040160405180910390fd5b6104d061053e565b6001600160a01b0381166105355760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016103de565b6101c681610782565b610546610861565b6001600160a01b03166105616033546001600160a01b031690565b6001600160a01b0316146103435760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016103de565b60975460ff16156106015760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016103de565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610637610861565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146106a25760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016103de565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610637610861565b600061032c7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba61088f565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610757573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061077b9190610bd9565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600054610100900460ff166107fb5760405162461bcd60e51b81526004016103de90610bf6565b610803610902565b61080b610931565b60978054610100600160a81b0319166101006001600160a01b0385169081029190911790915561084e5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600060143610801590610878575061087833610259565b1561088a575060131936013560601c90565b503390565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa1580156108de573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102a09190610c41565b600054610100900460ff166109295760405162461bcd60e51b81526004016103de90610bf6565b610343610960565b600054610100900460ff166109585760405162461bcd60e51b81526004016103de90610bf6565b610343610997565b600054610100900460ff166109875760405162461bcd60e51b81526004016103de90610bf6565b610343610992610861565b610782565b600054610100900460ff166109be5760405162461bcd60e51b81526004016103de90610bf6565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff81118282101715610a0457610a046109c5565b604052919050565b600067ffffffffffffffff821115610a2657610a266109c5565b5060051b60200190565b60008060408385031215610a4357600080fd5b8235915060208084013567ffffffffffffffff811115610a6257600080fd5b8401601f81018613610a7357600080fd5b8035610a86610a8182610a0c565b6109db565b81815260059190911b82018301908381019088831115610aa557600080fd5b928401925b82841015610ac357833582529284019290840190610aaa565b80955050505050509250929050565b80151581146101c657600080fd5b600060208284031215610af257600080fd5b813561077b81610ad2565b600060208284031215610b0f57600080fd5b5035919050565b6001600160a01b03811681146101c657600080fd5b600060208284031215610b3d57600080fd5b813561077b81610b16565b60006020808385031215610b5b57600080fd5b825167ffffffffffffffff811115610b7257600080fd5b8301601f81018513610b8357600080fd5b8051610b91610a8182610a0c565b81815260059190911b82018301908381019087831115610bb057600080fd5b928401925b82841015610bce57835182529284019290840190610bb5565b979650505050505050565b600060208284031215610beb57600080fd5b815161077b81610ad2565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b600060208284031215610c5357600080fd5b815161077b81610b1656fea26469706673582212206a0c6cf32a386d7f4b355b00385227f4719f21b9ef4bc0e81b4c76aa04a7039364736f6c634300080d0033";
        public TokentemplatesystemImplementationDeploymentBase() : base(BYTECODE) { }
        public TokentemplatesystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class ExistsFunction : ExistsFunctionBase { }

    [Function("exists", "bool")]
    public class ExistsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "templateId", 1)]
        public virtual BigInteger TemplateId { get; set; }
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

    public partial class ExistsOutputDTO : ExistsOutputDTOBase { }

    [FunctionOutput]
    public class ExistsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
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








}

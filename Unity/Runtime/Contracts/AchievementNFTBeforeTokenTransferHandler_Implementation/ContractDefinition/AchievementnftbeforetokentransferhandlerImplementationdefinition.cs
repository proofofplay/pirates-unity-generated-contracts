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

namespace PirateNationContracts.AchievementNFTBeforeTokenTransferHandler_Implementation.ContractDefinition
{


    public partial class AchievementnftbeforetokentransferhandlerImplementationDeployment : AchievementnftbeforetokentransferhandlerImplementationDeploymentBase
    {
        public AchievementnftbeforetokentransferhandlerImplementationDeployment() : base(BYTECODE) { }
        public AchievementnftbeforetokentransferhandlerImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class AchievementnftbeforetokentransferhandlerImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610dad806100206000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c806374c916861161007157806374c91686146101295780638da5cb5b1461013c578063c4d66de814610161578063dd898b2f14610174578063ed022ebd14610187578063f2fde38b1461019d57600080fd5b806306c1cb91146100b957806316c38b3c146100cd578063572b6c05146100e05780635c975abb146101085780635d1ca63114610110578063715018a614610121575b600080fd5b6100cb6100c7366004610b16565b5050565b005b6100cb6100db366004610bee565b6101b0565b6100f36100ee366004610c20565b6101d1565b60405190151581526020015b60405180910390f35b6100f361021e565b6098546040519081526020016100ff565b6100cb6102a9565b6100cb610137366004610c3d565b6102bd565b6033546001600160a01b03165b6040516001600160a01b0390911681526020016100ff565b6100cb61016f366004610c20565b610480565b6100cb610182366004610c20565b6105b8565b60975461010090046001600160a01b0316610149565b6100cb6101ab366004610c20565b610603565b6101b8610679565b80156101c9576101c66106f2565b50565b6101c661078f565b60975460009061010090046001600160a01b03161580159061021857506102187fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610810565b92915050565b60975460009060ff16806102a45750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610280573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102a49190610cab565b905090565b6102b1610679565b6102bb6000610892565b565b6001600160a01b038416158015906102dd57506001600160a01b03831615155b156104785760006102ec6108e4565b905060005b828110156104755760006103058286610cde565b604051639b9a15b360e01b81526001600160a01b038b81166004830152602482018390527f9e7ed7f8e6dcd193d98e2fd5ebd44790ad3072ac13a6c8399c17d661a1faa4bd604483015291925090841690639b9a15b390606401602060405180830381865afa15801561037c573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103a09190610cab565b801561044457506040516339050c9160e01b81526001600160a01b038a81166004830152602482018390527f9e7ed7f8e6dcd193d98e2fd5ebd44790ad3072ac13a6c8399c17d661a1faa4bd60448301528416906339050c9190606401602060405180830381865afa15801561041a573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061043e9190610cab565b15156001145b15610462576040516358b2164f60e11b815260040160405180910390fd5b508061046d81610cf6565b9150506102f1565b50505b505050505050565b600054610100900460ff16158080156104a05750600054600160ff909116105b806104ba5750303b1580156104ba575060005460ff166001145b6105225760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610545576000805461ff0019166101001790555b61056f827f8d4203c95cc38f8f7e90300dcdade8889bf103a3484b60cb044d398b252ba47e61090f565b80156100c7576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6105c0610679565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556101c65760405163a4b9148160e01b815260040160405180910390fd5b61060b610679565b6001600160a01b0381166106705760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610519565b6101c681610892565b61068161099c565b6001600160a01b031661069c6033546001600160a01b031690565b6001600160a01b0316146102bb5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610519565b60975460ff161561073c5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610519565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a25861077261099c565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146107dd5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610519565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa61077261099c565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610867573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061088b9190610cab565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b60006102a47f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba6109ca565b600054610100900460ff166109365760405162461bcd60e51b815260040161051990610d0f565b61093e610a3d565b610946610a6c565b60978054610100600160a81b0319166101006001600160a01b038516908102919091179091556109895760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b6000601436108015906109b357506109b3336101d1565b156109c5575060131936013560601c90565b503390565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610a19573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102189190610d5a565b600054610100900460ff16610a645760405162461bcd60e51b815260040161051990610d0f565b6102bb610a9b565b600054610100900460ff16610a935760405162461bcd60e51b815260040161051990610d0f565b6102bb610ad2565b600054610100900460ff16610ac25760405162461bcd60e51b815260040161051990610d0f565b6102bb610acd61099c565b610892565b600054610100900460ff16610af95760405162461bcd60e51b815260040161051990610d0f565b6001606555565b634e487b7160e01b600052604160045260246000fd5b60008060408385031215610b2957600080fd5b8235915060208084013567ffffffffffffffff80821115610b4957600080fd5b818601915086601f830112610b5d57600080fd5b813581811115610b6f57610b6f610b00565b8060051b604051601f19603f83011681018181108582111715610b9457610b94610b00565b604052918252848201925083810185019189831115610bb257600080fd5b938501935b82851015610bd057843584529385019392850192610bb7565b8096505050505050509250929050565b80151581146101c657600080fd5b600060208284031215610c0057600080fd5b813561088b81610be0565b6001600160a01b03811681146101c657600080fd5b600060208284031215610c3257600080fd5b813561088b81610c0b565b60008060008060008060c08789031215610c5657600080fd5b8635610c6181610c0b565b95506020870135610c7181610c0b565b94506040870135610c8181610c0b565b93506060870135610c9181610c0b565b9598949750929560808101359460a0909101359350915050565b600060208284031215610cbd57600080fd5b815161088b81610be0565b634e487b7160e01b600052601160045260246000fd5b60008219821115610cf157610cf1610cc8565b500190565b600060018201610d0857610d08610cc8565b5060010190565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b600060208284031215610d6c57600080fd5b815161088b81610c0b56fea26469706673582212203abd1a9a7cca9f4c3f585c806e1f3288a06c671fc23314abfd2ae6f31f38565b64736f6c634300080d0033";
        public AchievementnftbeforetokentransferhandlerImplementationDeploymentBase() : base(BYTECODE) { }
        public AchievementnftbeforetokentransferhandlerImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

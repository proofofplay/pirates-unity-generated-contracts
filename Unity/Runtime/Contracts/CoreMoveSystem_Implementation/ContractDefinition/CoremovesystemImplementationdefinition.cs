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

namespace PirateNationContracts.CoreMoveSystem_Implementation.ContractDefinition
{


    public partial class CoremovesystemImplementationDeployment : CoremovesystemImplementationDeploymentBase
    {
        public CoremovesystemImplementationDeployment() : base(BYTECODE) { }
        public CoremovesystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class CoremovesystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610e81806100206000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c80638ca755c2116100715780638ca755c2146101295780638da5cb5b14610149578063c4d66de81461016e578063dd898b2f14610181578063ed022ebd14610194578063f2fde38b146101aa57600080fd5b806306c1cb91146100b957806316c38b3c146100cd578063572b6c05146100e05780635c975abb146101085780635d1ca63114610110578063715018a614610121575b600080fd5b6100cb6100c7366004610bd9565b5050565b005b6100cb6100db366004610c89565b6101bd565b6100f36100ee366004610cbb565b6101de565b60405190151581526020015b60405180910390f35b6100f361022b565b6098546040519081526020016100ff565b6100cb6102b6565b61013c610137366004610cd8565b6102ca565b6040516100ff9190610cf1565b6033546001600160a01b03165b6040516001600160a01b0390911681526020016100ff565b6100cb61017c366004610cbb565b610384565b6100cb61018f366004610cbb565b610658565b60975461010090046001600160a01b0316610156565b6100cb6101b8366004610cbb565b6106a3565b6101c5610719565b80156101d6576101d3610792565b50565b6101d361082f565b60975460009061010090046001600160a01b03161580159061022557506102257fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d2836108b0565b92915050565b60975460009060ff16806102b15750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa15801561028d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102b19190610d35565b905090565b6102be610719565b6102c8600061092b565b565b606060006102f77fc0e7068c38f4dd33745694538d7c751535e23340d842d6b01b1fd58194132da461097d565b6000848152609960205260409081902054905163254da91360e01b81529192506001600160a01b0383169163254da913916103389160040190815260200190565b600060405180830381865afa158015610355573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f1916820160405261037d9190810190610d52565b9392505050565b600054610100900460ff16158080156103a45750600054600160ff909116105b806103be5750303b1580156103be575060005460ff166001145b6104265760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610449576000805461ff0019166101001790555b610473827f7a085781a4f509f705ae7172fa5414831ad1fa18fc3df61794293eaf9fb46ec96109f0565b60996020527fd13d07625649d7128dac9c189f4de67a5027de968548860794cfa1b5ec7e34e77fbb86fbc034f4e382929974bcd8419ed626b0ea647f962d89ba2fb6bd28785ab9557fbd7200da0400faa19d7b201ce484b96c13956fbbd25f6d465c36da9040b1e2687f18ea924a307d8c2826d960b81412f2a6543a75ca2d379ff3a056ee960e83da3b557f69411342758f0c054176b709961a2088495f5048f4fe087c650317b7600004d87f6c77eb307b8608348a606f5e0b4d324399953b26ef9d20fe80d55a613696457f557fffeae8855e458924f53a063c2c1343cd0557f84285d2cdfe5e6cb9255860b1617f6d01ba8ffed4ce500f24b73f45df7dc163a96f64ced987d8ee795c34e371362e557f59b2b350092c0785046aeae1f3697d8fde99a6c484e207f24923f0c4126279ba7f040cf2419a167b50f7187f9a4e1a349aba510080d50f17f1ba8d50dffbc8570f5560066000527f916949edc7bb9c98278cac5071ae7555f3157d333402c76b2643ff671a2d5faa7f7b278d3f7106f3f66574f80d29bf9c35c5455b3ed6633ff8dcea771dec080f635580156100c7576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b610660610719565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556101d35760405163a4b9148160e01b815260040160405180910390fd5b6106ab610719565b6001600160a01b0381166107105760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b606482015260840161041d565b6101d38161092b565b610721610a7d565b6001600160a01b031661073c6033546001600160a01b031690565b6001600160a01b0316146102c85760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604482015260640161041d565b60975460ff16156107dc5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161041d565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610812610a7d565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff16151560011461087d5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161041d565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610812610a7d565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610907573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061037d9190610d35565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa1580156109cc573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102259190610de3565b600054610100900460ff16610a175760405162461bcd60e51b815260040161041d90610e00565b610a1f610aab565b610a27610ada565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610a6a5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600060143610801590610a945750610a94336101de565b15610aa6575060131936013560601c90565b503390565b600054610100900460ff16610ad25760405162461bcd60e51b815260040161041d90610e00565b6102c8610b09565b600054610100900460ff16610b015760405162461bcd60e51b815260040161041d90610e00565b6102c8610b40565b600054610100900460ff16610b305760405162461bcd60e51b815260040161041d90610e00565b6102c8610b3b610a7d565b61092b565b600054610100900460ff16610b675760405162461bcd60e51b815260040161041d90610e00565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff81118282101715610bad57610bad610b6e565b604052919050565b600067ffffffffffffffff821115610bcf57610bcf610b6e565b5060051b60200190565b60008060408385031215610bec57600080fd5b8235915060208084013567ffffffffffffffff811115610c0b57600080fd5b8401601f81018613610c1c57600080fd5b8035610c2f610c2a82610bb5565b610b84565b81815260059190911b82018301908381019088831115610c4e57600080fd5b928401925b82841015610c6c57833582529284019290840190610c53565b80955050505050509250929050565b80151581146101d357600080fd5b600060208284031215610c9b57600080fd5b813561037d81610c7b565b6001600160a01b03811681146101d357600080fd5b600060208284031215610ccd57600080fd5b813561037d81610ca6565b600060208284031215610cea57600080fd5b5035919050565b6020808252825182820181905260009190848201906040850190845b81811015610d2957835183529284019291840191600101610d0d565b50909695505050505050565b600060208284031215610d4757600080fd5b815161037d81610c7b565b60006020808385031215610d6557600080fd5b825167ffffffffffffffff811115610d7c57600080fd5b8301601f81018513610d8d57600080fd5b8051610d9b610c2a82610bb5565b81815260059190911b82018301908381019087831115610dba57600080fd5b928401925b82841015610dd857835182529284019290840190610dbf565b979650505050505050565b600060208284031215610df557600080fd5b815161037d81610ca6565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea2646970667358221220e2421c2942e278e9ce9d0bdd9d0093a640d6d13e34ffa18d88e7a71fdc76d5d564736f6c634300080d0033";
        public CoremovesystemImplementationDeploymentBase() : base(BYTECODE) { }
        public CoremovesystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class GetCombatModifiersFunction : GetCombatModifiersFunctionBase { }

    [Function("getCombatModifiers", "int256[]")]
    public class GetCombatModifiersFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "moveId", 1)]
        public virtual BigInteger MoveId { get; set; }
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



    public partial class GetCombatModifiersOutputDTO : GetCombatModifiersOutputDTOBase { }

    [FunctionOutput]
    public class GetCombatModifiersOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("int256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
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

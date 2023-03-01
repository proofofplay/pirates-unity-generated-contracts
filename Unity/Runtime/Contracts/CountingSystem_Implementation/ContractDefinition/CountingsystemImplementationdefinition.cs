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

namespace PirateNationContracts.CountingSystem_Implementation.ContractDefinition
{


    public partial class CountingsystemImplementationDeployment : CountingsystemImplementationDeploymentBase
    {
        public CountingsystemImplementationDeployment() : base(BYTECODE) { }
        public CountingsystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class CountingsystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610dd7806100206000396000f3fe608060405234801561001057600080fd5b50600436106100f55760003560e01c80635dfe52e711610097578063dd898b2f11610066578063dd898b2f14610210578063ed022ebd14610223578063f2fde38b14610239578063f89e027d1461024c57600080fd5b80635dfe52e7146101a5578063715018a6146101d05780638da5cb5b146101d8578063c4d66de8146101fd57600080fd5b80635343011c116100d35780635343011c1461015f578063572b6c05146101725780635c975abb146101955780635d1ca6311461019d57600080fd5b806306c1cb91146100fa57806316c38b3c1461010e5780634348417d14610121575b600080fd5b61010c610108366004610ba7565b5050565b005b61010c61011c366004610c7f565b61025f565b61014c61012f366004610c9c565b600091825260996020908152604080842092845291905290205490565b6040519081526020015b60405180910390f35b61010c61016d366004610cbe565b610280565b610185610180366004610cea565b610349565b6040519015158152602001610156565b610185610396565b60985461014c565b61014c6101b3366004610c9c565b609960209081526000928352604080842090915290825290205481565b61010c610421565b6033546001600160a01b03165b6040516001600160a01b039091168152602001610156565b61010c61020b366004610cea565b610435565b61010c61021e366004610cea565b61056d565b60975461010090046001600160a01b03166101e5565b61010c610247366004610cea565b6105b8565b61010c61025a366004610cbe565b61062e565b6102676106bb565b801561027857610275610734565b50565b6102756107d1565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536102b2816102ad61084e565b61087c565b6102ba610925565b6000848152609960209081526040808320868452909152812080548492906102e3908490610d13565b90915550506000848152609960209081526040808320868452825291829020548251878152918201869052918101919091527f07b139a03d6e8fe0000625b64d0583aaf9be7ddc825d4891c3c92f4601910735906060015b60405180910390a150505050565b60975460009061010090046001600160a01b03161580159061039057506103907fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d28361096d565b92915050565b60975460009060ff168061041c5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156103f8573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061041c9190610d39565b905090565b6104296106bb565b61043360006109ef565b565b600054610100900460ff16158080156104555750600054600160ff909116105b8061046f5750303b15801561046f575060005460ff166001145b6104d75760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff1916600117905580156104fa576000805461ff0019166101001790555b610524827fe9aefd331a51b33332dd533066e256e751ed19e0d50c4410084e9b537ab1f0dd610a41565b8015610108576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6105756106bb565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102755760405163a4b9148160e01b815260040160405180910390fd5b6105c06106bb565b6001600160a01b0381166106255760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016104ce565b610275816109ef565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb5361065b816102ad61084e565b610663610925565b600084815260996020908152604080832086845282529182902084905581518681529081018590529081018390527f07b139a03d6e8fe0000625b64d0583aaf9be7ddc825d4891c3c92f46019107359060600161033b565b6106c361084e565b6001600160a01b03166106de6033546001600160a01b031690565b6001600160a01b0316146104335760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016104ce565b60975460ff161561077e5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016104ce565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a2586107b461084e565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff16151560011461081f5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016104ce565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa6107b45b600060143610801590610865575061086533610349565b15610877575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa1580156108d3573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906108f79190610d39565b6101085760405162b0d32560e11b81526001600160a01b0382166004820152602481018390526044016104ce565b61092d610396565b156104335760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b60448201526064016104ce565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa1580156109c4573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109e89190610d39565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600054610100900460ff16610a685760405162461bcd60e51b81526004016104ce90610d56565b610a70610ace565b610a78610afd565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610abb5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600054610100900460ff16610af55760405162461bcd60e51b81526004016104ce90610d56565b610433610b2c565b600054610100900460ff16610b245760405162461bcd60e51b81526004016104ce90610d56565b610433610b63565b600054610100900460ff16610b535760405162461bcd60e51b81526004016104ce90610d56565b610433610b5e61084e565b6109ef565b600054610100900460ff16610b8a5760405162461bcd60e51b81526004016104ce90610d56565b6001606555565b634e487b7160e01b600052604160045260246000fd5b60008060408385031215610bba57600080fd5b8235915060208084013567ffffffffffffffff80821115610bda57600080fd5b818601915086601f830112610bee57600080fd5b813581811115610c0057610c00610b91565b8060051b604051601f19603f83011681018181108582111715610c2557610c25610b91565b604052918252848201925083810185019189831115610c4357600080fd5b938501935b82851015610c6157843584529385019392850192610c48565b8096505050505050509250929050565b801515811461027557600080fd5b600060208284031215610c9157600080fd5b81356109e881610c71565b60008060408385031215610caf57600080fd5b50508035926020909101359150565b600080600060608486031215610cd357600080fd5b505081359360208301359350604090920135919050565b600060208284031215610cfc57600080fd5b81356001600160a01b03811681146109e857600080fd5b60008219821115610d3457634e487b7160e01b600052601160045260246000fd5b500190565b600060208284031215610d4b57600080fd5b81516109e881610c71565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea26469706673582212208021c71a7f7259eb341ba8570bfddf4fdb629360896e8f29a9782bf729e5090964736f6c634300080d0033";
        public CountingsystemImplementationDeploymentBase() : base(BYTECODE) { }
        public CountingsystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CountersFunction : CountersFunctionBase { }

    [Function("counters", "uint256")]
    public class CountersFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
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

    public partial class GetCountFunction : GetCountFunctionBase { }

    [Function("getCount", "uint256")]
    public class GetCountFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entity", 1)]
        public virtual BigInteger Entity { get; set; }
        [Parameter("uint256", "key", 2)]
        public virtual BigInteger Key { get; set; }
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

    public partial class IncrementCountFunction : IncrementCountFunctionBase { }

    [Function("incrementCount")]
    public class IncrementCountFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entity", 1)]
        public virtual BigInteger Entity { get; set; }
        [Parameter("uint256", "key", 2)]
        public virtual BigInteger Key { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
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

    public partial class SetCountFunction : SetCountFunctionBase { }

    [Function("setCount")]
    public class SetCountFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entity", 1)]
        public virtual BigInteger Entity { get; set; }
        [Parameter("uint256", "key", 2)]
        public virtual BigInteger Key { get; set; }
        [Parameter("uint256", "value", 3)]
        public virtual BigInteger Value { get; set; }
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

    public partial class CountSetEventDTO : CountSetEventDTOBase { }

    [Event("CountSet")]
    public class CountSetEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "entity", 1, false )]
        public virtual BigInteger Entity { get; set; }
        [Parameter("uint256", "key", 2, false )]
        public virtual BigInteger Key { get; set; }
        [Parameter("uint256", "newTotal", 3, false )]
        public virtual BigInteger NewTotal { get; set; }
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

    public partial class CountersOutputDTO : CountersOutputDTOBase { }

    [FunctionOutput]
    public class CountersOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class GetCountOutputDTO : GetCountOutputDTOBase { }

    [FunctionOutput]
    public class GetCountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
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

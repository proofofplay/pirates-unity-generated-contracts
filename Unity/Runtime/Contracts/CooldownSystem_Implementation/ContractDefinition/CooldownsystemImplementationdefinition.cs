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

namespace PirateNationContracts.CooldownSystem_Implementation.ContractDefinition
{


    public partial class CooldownsystemImplementationDeployment : CooldownsystemImplementationDeploymentBase
    {
        public CooldownsystemImplementationDeployment() : base(BYTECODE) { }
        public CooldownsystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class CooldownsystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610e4a806100206000396000f3fe608060405234801561001057600080fd5b50600436106101005760003560e01c80638da5cb5b11610097578063df0aa3f611610066578063df0aa3f614610219578063ed022ebd1461025f578063f2fde38b14610275578063fb06734f1461028857600080fd5b80638da5cb5b146101bb578063adf81d13146101e0578063c4d66de8146101f3578063dd898b2f1461020657600080fd5b80635c975abb116100d35780635c975abb146101875780635d1ca6311461018f578063715018a6146101a05780638b7ccb2b146101a857600080fd5b806306c1cb911461010557806316c38b3c14610119578063218ac5291461012c578063572b6c0514610174575b600080fd5b610117610113366004610bc7565b5050565b005b610117610127366004610c9f565b61029b565b61015f61013a366004610cbc565b600091825260996020908152604080842092845291905290205463ffffffff16421090565b60405190151581526020015b60405180910390f35b61015f610182366004610cde565b6102bc565b61015f610309565b60985460405190815260200161016b565b610117610394565b6101176101b6366004610cbc565b6103a8565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161016b565b61015f6101ee366004610d07565b610401565b610117610201366004610cde565b6104a6565b610117610214366004610cde565b6105de565b61024a610227366004610cbc565b600091825260996020908152604080842092845291905290205463ffffffff1690565b60405163ffffffff909116815260200161016b565b60975461010090046001600160a01b03166101c8565b610117610283366004610cde565b610629565b610117610296366004610d07565b61069f565b6102a361071f565b80156102b4576102b1610798565b50565b6102b1610835565b60975460009061010090046001600160a01b03161580159061030357506103037fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d2836108b6565b92915050565b60975460009060ff168061038f5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa15801561036b573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061038f9190610d49565b905090565b61039c61071f565b6103a66000610938565b565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536103da816103d561098a565b6109b8565b5060009182526099602090815260408084209284529190529020805463ffffffff19169055565b60007fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb53610430816103d561098a565b600085815260996020908152604080832087845290915290205463ffffffff164210610499576104608342610d7c565b60008681526099602090815260408083208884529091528120805463ffffffff191663ffffffff9390931692909217909155915061049e565b600191505b509392505050565b600054610100900460ff16158080156104c65750600054600160ff909116105b806104e05750303b1580156104e0575060005460ff166001145b6105485760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff19166001179055801561056b576000805461ff0019166101001790555b610595827f36f28d4c25b7b66b22d16aba7dfec7cb499704d25d3620993ff142d57ffa0683610a61565b8015610113576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6105e661071f565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102b15760405163a4b9148160e01b815260040160405180910390fd5b61063161071f565b6001600160a01b0381166106965760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b606482015260840161053f565b6102b181610938565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536106cc816103d561098a565b6000848152609960209081526040808320868452909152812080548492906106fb90849063ffffffff16610da4565b92506101000a81548163ffffffff021916908363ffffffff16021790555050505050565b61072761098a565b6001600160a01b03166107426033546001600160a01b031690565b6001600160a01b0316146103a65760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604482015260640161053f565b60975460ff16156107e25760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161053f565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a25861081861098a565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146108835760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161053f565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa61081861098a565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa15801561090d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109319190610d49565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6000601436108015906109a157506109a1336102bc565b156109b3575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610a0f573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610a339190610d49565b6101135760405162b0d32560e11b81526001600160a01b03821660048201526024810183905260440161053f565b600054610100900460ff16610a885760405162461bcd60e51b815260040161053f90610dc9565b610a90610aee565b610a98610b1d565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610adb5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600054610100900460ff16610b155760405162461bcd60e51b815260040161053f90610dc9565b6103a6610b4c565b600054610100900460ff16610b445760405162461bcd60e51b815260040161053f90610dc9565b6103a6610b83565b600054610100900460ff16610b735760405162461bcd60e51b815260040161053f90610dc9565b6103a6610b7e61098a565b610938565b600054610100900460ff16610baa5760405162461bcd60e51b815260040161053f90610dc9565b6001606555565b634e487b7160e01b600052604160045260246000fd5b60008060408385031215610bda57600080fd5b8235915060208084013567ffffffffffffffff80821115610bfa57600080fd5b818601915086601f830112610c0e57600080fd5b813581811115610c2057610c20610bb1565b8060051b604051601f19603f83011681018181108582111715610c4557610c45610bb1565b604052918252848201925083810185019189831115610c6357600080fd5b938501935b82851015610c8157843584529385019392850192610c68565b8096505050505050509250929050565b80151581146102b157600080fd5b600060208284031215610cb157600080fd5b813561093181610c91565b60008060408385031215610ccf57600080fd5b50508035926020909101359150565b600060208284031215610cf057600080fd5b81356001600160a01b038116811461093157600080fd5b600080600060608486031215610d1c57600080fd5b8335925060208401359150604084013563ffffffff81168114610d3e57600080fd5b809150509250925092565b600060208284031215610d5b57600080fd5b815161093181610c91565b634e487b7160e01b600052601160045260246000fd5b600063ffffffff808316818516808303821115610d9b57610d9b610d66565b01949350505050565b600063ffffffff83811690831681811015610dc157610dc1610d66565b039392505050565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea264697066735822122096d8fb2035b775fb59b8ad3099b643ee9b7e938971176eadb4592109817d613664736f6c634300080d0033";
        public CooldownsystemImplementationDeploymentBase() : base(BYTECODE) { }
        public CooldownsystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class DeleteCooldownFunction : DeleteCooldownFunctionBase { }

    [Function("deleteCooldown")]
    public class DeleteCooldownFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entity", 1)]
        public virtual BigInteger Entity { get; set; }
        [Parameter("uint256", "cooldownId", 2)]
        public virtual BigInteger CooldownId { get; set; }
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

    public partial class GetCooldownFunction : GetCooldownFunctionBase { }

    [Function("getCooldown", "uint32")]
    public class GetCooldownFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entity", 1)]
        public virtual BigInteger Entity { get; set; }
        [Parameter("uint256", "cooldownId", 2)]
        public virtual BigInteger CooldownId { get; set; }
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

    public partial class IsInCooldownFunction : IsInCooldownFunctionBase { }

    [Function("isInCooldown", "bool")]
    public class IsInCooldownFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entity", 1)]
        public virtual BigInteger Entity { get; set; }
        [Parameter("uint256", "cooldownId", 2)]
        public virtual BigInteger CooldownId { get; set; }
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

    public partial class ReduceCooldownFunction : ReduceCooldownFunctionBase { }

    [Function("reduceCooldown")]
    public class ReduceCooldownFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entity", 1)]
        public virtual BigInteger Entity { get; set; }
        [Parameter("uint256", "cooldownId", 2)]
        public virtual BigInteger CooldownId { get; set; }
        [Parameter("uint32", "cooldownTime", 3)]
        public virtual uint CooldownTime { get; set; }
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

    public partial class UpdateAndCheckCooldownFunction : UpdateAndCheckCooldownFunctionBase { }

    [Function("updateAndCheckCooldown", "bool")]
    public class UpdateAndCheckCooldownFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entity", 1)]
        public virtual BigInteger Entity { get; set; }
        [Parameter("uint256", "cooldownId", 2)]
        public virtual BigInteger CooldownId { get; set; }
        [Parameter("uint32", "cooldownTime", 3)]
        public virtual uint CooldownTime { get; set; }
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





    public partial class GetCooldownOutputDTO : GetCooldownOutputDTOBase { }

    [FunctionOutput]
    public class GetCooldownOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32", "", 1)]
        public virtual uint ReturnValue1 { get; set; }
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



    public partial class IsInCooldownOutputDTO : IsInCooldownOutputDTOBase { }

    [FunctionOutput]
    public class IsInCooldownOutputDTOBase : IFunctionOutputDTO 
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

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
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5061126d806100206000396000f3fe608060405234801561001057600080fd5b50600436106100cf5760003560e01c80638ca755c21161008c578063cc989bd911610066578063cc989bd91461019c578063dd898b2f146101af578063ed022ebd146101c2578063f2fde38b146101d857600080fd5b80638ca755c2146101445780638da5cb5b14610164578063c4d66de81461018957600080fd5b806306c1cb91146100d457806316c38b3c146100e8578063572b6c05146100fb5780635c975abb146101235780635d1ca6311461012b578063715018a61461013c575b600080fd5b6100e66100e2366004610eee565b5050565b005b6100e66100f6366004610f9e565b6101eb565b61010e610109366004610fd0565b61020c565b60405190151581526020015b60405180910390f35b61010e610259565b60985460405190815260200161011a565b6100e66102e4565b610157610152366004610fed565b6102f8565b60405161011a9190611006565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161011a565b6100e6610197366004610fd0565b6103a8565b6100e66101aa36600461104a565b61067c565b6100e66101bd366004610fd0565b610875565b60975461010090046001600160a01b0316610171565b6100e66101e6366004610fd0565b6108c0565b6101f3610936565b8015610204576102016109af565b50565b610201610a4c565b60975460009061010090046001600160a01b03161580159061025357506102537fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610acd565b92915050565b60975460009060ff16806102df5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156102bb573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102df91906110bf565b905090565b6102ec610936565b6102f66000610b4f565b565b60606103237fc0e7068c38f4dd33745694538d7c751535e23340d842d6b01b1fd58194132da4610ba1565b6000838152609960205260409081902054905163254da91360e01b81526001600160a01b03929092169163254da913916103639160040190815260200190565b600060405180830381865afa158015610380573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f1916820160405261025391908101906110dc565b600054610100900460ff16158080156103c85750600054600160ff909116105b806103e25750303b1580156103e2575060005460ff166001145b61044a5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff19166001179055801561046d576000805461ff0019166101001790555b610497827f7a085781a4f509f705ae7172fa5414831ad1fa18fc3df61794293eaf9fb46ec9610c14565b60996020527f59b2b350092c0785046aeae1f3697d8fde99a6c484e207f24923f0c4126279ba7fbb86fbc034f4e382929974bcd8419ed626b0ea647f962d89ba2fb6bd28785ab9557fffeae8855e458924f53a063c2c1343cd0557f84285d2cdfe5e6cb9255860b1617f18ea924a307d8c2826d960b81412f2a6543a75ca2d379ff3a056ee960e83da3b557f69411342758f0c054176b709961a2088495f5048f4fe087c650317b7600004d87f6c77eb307b8608348a606f5e0b4d324399953b26ef9d20fe80d55a613696457f557fd13d07625649d7128dac9c189f4de67a5027de968548860794cfa1b5ec7e34e77f6d01ba8ffed4ce500f24b73f45df7dc163a96f64ced987d8ee795c34e371362e557fbd7200da0400faa19d7b201ce484b96c13956fbbd25f6d465c36da9040b1e2687f040cf2419a167b50f7187f9a4e1a349aba510080d50f17f1ba8d50dffbc8570f5560066000527f916949edc7bb9c98278cac5071ae7555f3157d333402c76b2643ff671a2d5faa7f7b278d3f7106f3f66574f80d29bf9c35c5455b3ed6633ff8dcea771dec080f635580156100e2576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a66106ae816106a9610ca1565b610ccf565b6106b6610d78565b6106c260016007611183565b82146106e157604051639861a6a960e01b815260040160405180910390fd5b6040805160c0810182527f59b2b350092c0785046aeae1f3697d8fde99a6c484e207f24923f0c4126279ba81527fffeae8855e458924f53a063c2c1343cd0557f84285d2cdfe5e6cb9255860b16160208201527f69411342758f0c054176b709961a2088495f5048f4fe087c650317b7600004d8918101919091527fd13d07625649d7128dac9c189f4de67a5027de968548860794cfa1b5ec7e34e760608201527fbd7200da0400faa19d7b201ce484b96c13956fbbd25f6d465c36da9040b1e26860808201527f916949edc7bb9c98278cac5071ae7555f3157d333402c76b2643ff671a2d5faa60a08201526000805b60ff811685111561086d5785858260ff168181106107f2576107f261119a565b602002919091013592505060078210158061080b575081155b1561082c57604051631e16093960e11b815260048101839052602401610441565b828160ff16600681106108415761084161119a565b602090810291909101516000848152609990925260409091205580610865816111b0565b9150506107d2565b505050505050565b61087d610936565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102015760405163a4b9148160e01b815260040160405180910390fd5b6108c8610936565b6001600160a01b03811661092d5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610441565b61020181610b4f565b61093e610ca1565b6001600160a01b03166109596033546001600160a01b031690565b6001600160a01b0316146102f65760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610441565b60975460ff16156109f95760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610441565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610a2f610ca1565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610a9a5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610441565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610a2f610ca1565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610b24573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610b4891906110bf565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610bf0573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061025391906111cf565b600054610100900460ff16610c3b5760405162461bcd60e51b8152600401610441906111ec565b610c43610dc0565b610c4b610def565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610c8e5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600060143610801590610cb85750610cb83361020c565b15610cca575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610d26573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610d4a91906110bf565b6100e25760405162b0d32560e11b81526001600160a01b038216600482015260248101839052604401610441565b610d80610259565b156102f65760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b6044820152606401610441565b600054610100900460ff16610de75760405162461bcd60e51b8152600401610441906111ec565b6102f6610e1e565b600054610100900460ff16610e165760405162461bcd60e51b8152600401610441906111ec565b6102f6610e55565b600054610100900460ff16610e455760405162461bcd60e51b8152600401610441906111ec565b6102f6610e50610ca1565b610b4f565b600054610100900460ff16610e7c5760405162461bcd60e51b8152600401610441906111ec565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff81118282101715610ec257610ec2610e83565b604052919050565b600067ffffffffffffffff821115610ee457610ee4610e83565b5060051b60200190565b60008060408385031215610f0157600080fd5b8235915060208084013567ffffffffffffffff811115610f2057600080fd5b8401601f81018613610f3157600080fd5b8035610f44610f3f82610eca565b610e99565b81815260059190911b82018301908381019088831115610f6357600080fd5b928401925b82841015610f8157833582529284019290840190610f68565b80955050505050509250929050565b801515811461020157600080fd5b600060208284031215610fb057600080fd5b8135610b4881610f90565b6001600160a01b038116811461020157600080fd5b600060208284031215610fe257600080fd5b8135610b4881610fbb565b600060208284031215610fff57600080fd5b5035919050565b6020808252825182820181905260009190848201906040850190845b8181101561103e57835183529284019291840191600101611022565b50909695505050505050565b6000806020838503121561105d57600080fd5b823567ffffffffffffffff8082111561107557600080fd5b818501915085601f83011261108957600080fd5b81358181111561109857600080fd5b8660208260051b85010111156110ad57600080fd5b60209290920196919550909350505050565b6000602082840312156110d157600080fd5b8151610b4881610f90565b600060208083850312156110ef57600080fd5b825167ffffffffffffffff81111561110657600080fd5b8301601f8101851361111757600080fd5b8051611125610f3f82610eca565b81815260059190911b8201830190838101908783111561114457600080fd5b928401925b8284101561116257835182529284019290840190611149565b979650505050505050565b634e487b7160e01b600052601160045260246000fd5b6000828210156111955761119561116d565b500390565b634e487b7160e01b600052603260045260246000fd5b600060ff821660ff81036111c6576111c661116d565b60010192915050565b6000602082840312156111e157600080fd5b8151610b4881610fbb565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea26469706673582212204cb78882f2a29cc7033ad6c13299914390666ef66357915354c495ddd592a8fb64736f6c634300080d0033";
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

    public partial class SetAllMovesFunction : SetAllMovesFunctionBase { }

    [Function("setAllMoves")]
    public class SetAllMovesFunctionBase : FunctionMessage
    {
        [Parameter("uint256[]", "moveIds", 1)]
        public virtual List<BigInteger> MoveIds { get; set; }
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



    public partial class InvalidMoveIdError : InvalidMoveIdErrorBase { }

    [Error("InvalidMoveId")]
    public class InvalidMoveIdErrorBase : IErrorDTO
    {
        [Parameter("uint256", "moveId", 1)]
        public virtual BigInteger MoveId { get; set; }
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

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

namespace PirateNationContracts.GameItemsBeforeTokenTransferHandler_Implementation.ContractDefinition
{


    public partial class GameitemsbeforetokentransferhandlerImplementationDeployment : GameitemsbeforetokentransferhandlerImplementationDeploymentBase
    {
        public GameitemsbeforetokentransferhandlerImplementationDeployment() : base(BYTECODE) { }
        public GameitemsbeforetokentransferhandlerImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class GameitemsbeforetokentransferhandlerImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50611071806100206000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c80638da5cb5b116100715780638da5cb5b14610129578063c4d66de81461014e578063d6052ceb14610161578063dd898b2f14610174578063ed022ebd14610187578063f2fde38b1461019d57600080fd5b806306c1cb91146100b957806316c38b3c146100cd578063572b6c05146100e05780635c975abb146101085780635d1ca63114610110578063715018a614610121575b600080fd5b6100cb6100c7366004610d07565b5050565b005b6100cb6100db366004610d5c565b6101b0565b6100f36100ee366004610d9e565b6101d1565b60405190151581526020015b60405180910390f35b6100f361021e565b6098546040519081526020016100ff565b6100cb6102a9565b6033546001600160a01b03165b6040516001600160a01b0390911681526020016100ff565b6100cb61015c366004610d9e565b6102bd565b6100cb61016f366004610e2b565b6103f5565b6100cb610182366004610d9e565b610666565b60975461010090046001600160a01b0316610136565b6100cb6101ab366004610d9e565b6106b1565b6101b8610727565b80156101c9576101c66107a0565b50565b6101c661083d565b60975460009061010090046001600160a01b03161580159061021857506102187fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d2836108be565b92915050565b60975460009060ff16806102a45750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610280573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102a49190610efa565b905090565b6102b1610727565b6102bb6000610940565b565b600054610100900460ff16158080156102dd5750600054600160ff909116105b806102f75750303b1580156102f7575060005460ff166001145b61035f5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610382576000805461ff0019166101001790555b6103ac827fba63863aea32db48f1ead39d22982e57f98fa552fbc0a2be2285c0c20df10b5d610992565b80156100c7576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6001600160a01b0385161561065d5761040c610a1f565b6001600160a01b03166380e67f81868986866040518563ffffffff1660e01b815260040161043d9493929190610f52565b602060405180830381865afa15801561045a573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061047e9190610efa565b15156000036104a05760405163caa30f5560e01b815260040160405180910390fd5b6001600160a01b0384161561065d5760006104b9610ab1565b905060005b84518160ff16101561065a576000858260ff16815181106104e1576104e1610f90565b6020908102919091010151604051639b9a15b360e01b81526001600160a01b038c81166004830152602482018390527f9e7ed7f8e6dcd193d98e2fd5ebd44790ad3072ac13a6c8399c17d661a1faa4bd604483015291925090841690639b9a15b390606401602060405180830381865afa158015610563573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105879190610efa565b801561062b57506040516339050c9160e01b81526001600160a01b038b81166004830152602482018390527f9e7ed7f8e6dcd193d98e2fd5ebd44790ad3072ac13a6c8399c17d661a1faa4bd60448301528416906339050c9190606401602060405180830381865afa158015610601573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906106259190610efa565b15156001145b15610649576040516358b2164f60e11b815260040160405180910390fd5b5061065381610fa6565b90506104be565b50505b50505050505050565b61066e610727565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556101c65760405163a4b9148160e01b815260040160405180910390fd5b6106b9610727565b6001600160a01b03811661071e5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610356565b6101c681610940565b61072f610adc565b6001600160a01b031661074a6033546001600160a01b031690565b6001600160a01b0316146102bb5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610356565b60975460ff16156107ea5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610356565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610820610adc565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff16151560011461088b5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610356565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610820610adc565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610915573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109399190610efa565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600054610100900460ff166109b95760405162461bcd60e51b815260040161035690610fd3565b6109c1610b0a565b6109c9610b39565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610a0c5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b6097546040516329f20e0f60e11b81527f014f6fb700e688e304b410f81545ae2d4da13a493bf857fd2bf0f97da00bf997600482015260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610a8d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102a4919061101e565b60006102a47f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610b68565b600060143610801590610af35750610af3336101d1565b15610b05575060131936013560601c90565b503390565b600054610100900460ff16610b315760405162461bcd60e51b815260040161035690610fd3565b6102bb610bdb565b600054610100900460ff16610b605760405162461bcd60e51b815260040161035690610fd3565b6102bb610c12565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610bb7573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610218919061101e565b600054610100900460ff16610c025760405162461bcd60e51b815260040161035690610fd3565b6102bb610c0d610adc565b610940565b600054610100900460ff16610c395760405162461bcd60e51b815260040161035690610fd3565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff81118282101715610c7f57610c7f610c40565b604052919050565b600082601f830112610c9857600080fd5b8135602067ffffffffffffffff821115610cb457610cb4610c40565b8160051b610cc3828201610c56565b9283528481018201928281019087851115610cdd57600080fd5b83870192505b84831015610cfc57823582529183019190830190610ce3565b979650505050505050565b60008060408385031215610d1a57600080fd5b82359150602083013567ffffffffffffffff811115610d3857600080fd5b610d4485828601610c87565b9150509250929050565b80151581146101c657600080fd5b600060208284031215610d6e57600080fd5b813561093981610d4e565b6001600160a01b03811681146101c657600080fd5b8035610d9981610d79565b919050565b600060208284031215610db057600080fd5b813561093981610d79565b600082601f830112610dcc57600080fd5b813567ffffffffffffffff811115610de657610de6610c40565b610df9601f8201601f1916602001610c56565b818152846020838601011115610e0e57600080fd5b816020850160208301376000918101602001919091529392505050565b600080600080600080600060e0888a031215610e4657600080fd5b8735610e5181610d79565b96506020880135610e6181610d79565b9550610e6f60408901610d8e565b9450610e7d60608901610d8e565b9350608088013567ffffffffffffffff80821115610e9a57600080fd5b610ea68b838c01610c87565b945060a08a0135915080821115610ebc57600080fd5b610ec88b838c01610c87565b935060c08a0135915080821115610ede57600080fd5b50610eeb8a828b01610dbb565b91505092959891949750929550565b600060208284031215610f0c57600080fd5b815161093981610d4e565b600081518084526020808501945080840160005b83811015610f4757815187529582019590820190600101610f2b565b509495945050505050565b6001600160a01b03858116825284166020820152608060408201819052600090610f7e90830185610f17565b8281036060840152610cfc8185610f17565b634e487b7160e01b600052603260045260246000fd5b600060ff821660ff8103610fca57634e487b7160e01b600052601160045260246000fd5b60010192915050565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b60006020828403121561103057600080fd5b815161093981610d7956fea26469706673582212206a0cd17e9d97bdcf8c3ca2dd1d541fc9b3e128af0b1a18cc4589e24a3ca5a02f64736f6c634300080d0033";
        public GameitemsbeforetokentransferhandlerImplementationDeploymentBase() : base(BYTECODE) { }
        public GameitemsbeforetokentransferhandlerImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

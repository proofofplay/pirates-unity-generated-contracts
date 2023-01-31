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

namespace PirateNationContracts.ShipSystem_Implementation.ContractDefinition
{


    public partial class ShipsystemImplementationDeployment : ShipsystemImplementationDeploymentBase
    {
        public ShipsystemImplementationDeployment() : base(BYTECODE) { }
        public ShipsystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class ShipsystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50611113806100206000396000f3fe608060405234801561001057600080fd5b50600436106100ea5760003560e01c8063715018a61161008c578063dd898b2f11610066578063dd898b2f146101b9578063ed022ebd146101cc578063f2beec94146101e2578063f2fde38b146101f557600080fd5b8063715018a6146101795780638da5cb5b14610181578063c4d66de8146101a657600080fd5b806334514247116100c85780633451424714610133578063572b6c05146101465780635c975abb146101695780635d1ca6311461017157600080fd5b806306c1cb91146100ef57806316c38b3c146101035780631b068ea814610116575b600080fd5b6101016100fd366004610eb6565b5050565b005b610101610111366004610f8e565b610208565b6099546101209081565b6040519081526020015b60405180910390f35b610101610141366004610fc0565b610229565b610159610154366004610ff5565b610239565b604051901515815260200161012a565b610159610286565b609854610120565b610101610311565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161012a565b6101016101b4366004610ff5565b610325565b6101016101c7366004610ff5565b61045d565b60975461010090046001600160a01b031661018e565b6101016101f0366004610fc0565b6104a8565b610101610203366004610ff5565b6104f3565b610210610569565b80156102215761021e6105e2565b50565b61021e61067f565b610234838383610700565b505050565b60975460009061010090046001600160a01b03161580159061028057506102807fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610a69565b92915050565b60975460009060ff168061030c5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156102e8573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061030c9190611012565b905090565b610319610569565b6103236000610aeb565b565b600054610100900460ff16158080156103455750600054600160ff909116105b8061035f5750303b15801561035f575060005460ff166001145b6103c75760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff1916600117905580156103ea576000805461ff0019166101001790555b610414827f8cc789c2d3266e9e63dd5b8192283743f1bdbee94b3d14699dfb608d2adffac1610b3d565b80156100fd576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b610465610569565b60978054610100600160a81b0319166101006001600160a01b0384169081029190911790915561021e5760405163a4b9148160e01b815260040160405180910390fd5b7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a66104da816104d5610bca565b610bf8565b6104e2610ca1565b6104ed848484610700565b50505050565b6104fb610569565b6001600160a01b0381166105605760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016103be565b61021e81610aeb565b610571610bca565b6001600160a01b031661058c6033546001600160a01b031690565b6001600160a01b0316146103235760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016103be565b60975460ff161561062c5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016103be565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610662610bca565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146106cd5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016103be565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610662610bca565b600181101561072257604051639482a43760e01b815260040160405180910390fd5b600061074d7faeca1b630a909fd2c24c10ed836dbecc723968d7724ecc7c4d13aa36a4e43008610ce9565b90506000610759610d5c565b905060006107867f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610ce9565b90508060005b858160ff161015610a5f57604051634f558e7960e01b8152600481018890526001600160a01b03831690634f558e7990602401602060405180830381865afa1580156107dc573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906108009190611012565b61082057604051632afa89e560e21b8152600481018890526024016103be565b61082e609980546001019055565b600061083960995490565b6040516340c10f1960e01b81526001600160a01b038b8116600483015260248201839052919250908716906340c10f1990604401600060405180830381600087803b15801561088757600080fd5b505af115801561089b573d6000803e3d6000fd5b505060405163fb5b859760e01b81526001600160a01b03898116600483015260248201859052604482018c90528616925063fb5b85979150606401600060405180830381600087803b1580156108f057600080fd5b505af1158015610904573d6000803e3d6000fd5b5050604051632218394360e11b81526001600160a01b038781166004830152602482018c90527f9005b4bf3e8c5705ff2b172ed7c0ff76f0096efed0943457e640b66da01b97d260448301526000935088169150634430728690606401602060405180830381865afa15801561097e573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109a2919061102f565b90506001600160a01b038616637d4ec3b388847f0800a4644d961a76e563e14ed4e1c1a13617cefd5c4c7ab3dc25232976c4d7a66109df86610d87565b6040516001600160e01b031960e087901b1681526001600160a01b039094166004850152602484019290925260448301526064820152608401600060405180830381600087803b158015610a3257600080fd5b505af1158015610a46573d6000803e3d6000fd5b5050505050508080610a5790611048565b91505061078c565b5050505050505050565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610ac0573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610ae49190611012565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600054610100900460ff16610b645760405162461bcd60e51b81526004016103be90611075565b610b6c610ddd565b610b74610e0c565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610bb75760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600060143610801590610be15750610be133610239565b15610bf3575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610c4f573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610c739190611012565b6100fd5760405162b0d32560e11b81526001600160a01b0382166004820152602481018390526044016103be565b610ca9610286565b156103235760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b60448201526064016103be565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610d38573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061028091906110c0565b600061030c7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610ce9565b600080821215610dd95760405162461bcd60e51b815260206004820181905260248201527f53616665436173743a2076616c7565206d75737420626520706f73697469766560448201526064016103be565b5090565b600054610100900460ff16610e045760405162461bcd60e51b81526004016103be90611075565b610323610e3b565b600054610100900460ff16610e335760405162461bcd60e51b81526004016103be90611075565b610323610e72565b600054610100900460ff16610e625760405162461bcd60e51b81526004016103be90611075565b610323610e6d610bca565b610aeb565b600054610100900460ff16610e995760405162461bcd60e51b81526004016103be90611075565b6001606555565b634e487b7160e01b600052604160045260246000fd5b60008060408385031215610ec957600080fd5b8235915060208084013567ffffffffffffffff80821115610ee957600080fd5b818601915086601f830112610efd57600080fd5b813581811115610f0f57610f0f610ea0565b8060051b604051601f19603f83011681018181108582111715610f3457610f34610ea0565b604052918252848201925083810185019189831115610f5257600080fd5b938501935b82851015610f7057843584529385019392850192610f57565b8096505050505050509250929050565b801515811461021e57600080fd5b600060208284031215610fa057600080fd5b8135610ae481610f80565b6001600160a01b038116811461021e57600080fd5b600080600060608486031215610fd557600080fd5b8335610fe081610fab565b95602085013595506040909401359392505050565b60006020828403121561100757600080fd5b8135610ae481610fab565b60006020828403121561102457600080fd5b8151610ae481610f80565b60006020828403121561104157600080fd5b5051919050565b600060ff821660ff810361106c57634e487b7160e01b600052601160045260246000fd5b60010192915050565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b6000602082840312156110d257600080fd5b8151610ae481610fab56fea26469706673582212206baf8c281a7acb162e7fd63cdb6bc1ed975897876bbe4a124d2e417c8389b33664736f6c634300080d0033";
        public ShipsystemImplementationDeploymentBase() : base(BYTECODE) { }
        public ShipsystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CurrentShipIdFunction : CurrentShipIdFunctionBase { }

    [Function("currentShipId", "uint256")]
    public class CurrentShipIdFunctionBase : FunctionMessage
    {

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

    public partial class GrantLootFunction : GrantLootFunctionBase { }

    [Function("grantLoot")]
    public class GrantLootFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "lootId", 2)]
        public virtual BigInteger LootId { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class GrantLootForTestsFunction : GrantLootForTestsFunctionBase { }

    [Function("grantLootForTests")]
    public class GrantLootForTestsFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "lootId", 2)]
        public virtual BigInteger LootId { get; set; }
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





    public partial class InvalidShipIdError : InvalidShipIdErrorBase { }

    [Error("InvalidShipId")]
    public class InvalidShipIdErrorBase : IErrorDTO
    {
        [Parameter("uint256", "shipId", 1)]
        public virtual BigInteger ShipId { get; set; }
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

    public partial class CurrentShipIdOutputDTO : CurrentShipIdOutputDTOBase { }

    [FunctionOutput]
    public class CurrentShipIdOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "_value", 1)]
        public virtual BigInteger Value { get; set; }
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

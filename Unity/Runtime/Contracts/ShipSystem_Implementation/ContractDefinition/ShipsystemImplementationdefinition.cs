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
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5061169a806100206000396000f3fe608060405234801561001057600080fd5b50600436106101005760003560e01c8063715018a611610097578063dd898b2f11610066578063dd898b2f1461022e578063ed022ebd14610241578063f2beec9414610257578063f2fde38b1461026a57600080fd5b8063715018a6146101b3578063865ef243146101bb5780638da5cb5b146101f6578063c4d66de81461021b57600080fd5b80631b068ea8116100d35780631b068ea814610168578063572b6c05146101805780635c975abb146101a35780635d1ca631146101ab57600080fd5b8063010fd1d3146101055780630695dc561461011a57806306c1cb911461014357806316c38b3c14610155575b600080fd5b610118610113366004611347565b61027d565b005b61012d610128366004611397565b6102ac565b60405161013a91906113c3565b60405180910390f35b610118610151366004611431565b5050565b610118610163366004611509565b610340565b609a546101729081565b60405190815260200161013a565b61019361018e366004611526565b61035e565b604051901515815260200161013a565b6101936103ab565b609854610172565b610118610436565b6101ce6101c9366004611397565b61044a565b604080519586526020860194909452928401919091526060830152608082015260a00161013a565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161013a565b610118610229366004611526565b610848565b61011861023c366004611526565b610980565b60975461010090046001600160a01b0316610203565b610118610265366004611543565b6109cb565b610118610278366004611526565b610cf2565b610285610d68565b61028d610dc1565b600061029f61029a610e09565b610e37565b5050600160655550565b50565b6001600160a01b03821660009081526099602090815260408083208484528252808320805482518185028101850190935280835260609492939192909184015b82821015610334576000848152602090819020604080518082019091526002850290910180546001600160a01b031682526001908101548284015290835290920191016102ec565b50505050905092915050565b610348610eb3565b8015610356576102a9610f2c565b6102a9610fc9565b60975460009061010090046001600160a01b0316158015906103a557506103a57fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d28361104a565b92915050565b60975460009060ff16806104315750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa15801561040d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906104319190611578565b905090565b61043e610eb3565b61044860006110cc565b565b6000808080808061047a7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba61111e565b905060006104a77f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a3100561111e565b604051630b3f2a6360e01b81529091506000906001600160a01b03841690630b3f2a63906104fd908d908d907f9319bf1fd23873eaf43c06bb91a1db3e678411d693e959f1512879196908f12c90600401611595565b602060405180830381865afa15801561051a573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061053e91906115b6565b604051630b3f2a6360e01b81529091506000906001600160a01b03851690630b3f2a639061059490869086907f9005b4bf3e8c5705ff2b172ed7c0ff76f0096efed0943457e640b66da01b97d290600401611595565b602060405180830381865afa1580156105b1573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105d591906115b6565b604051630b3f2a6360e01b81529091506000906001600160a01b03861690630b3f2a639061062b90879087907f5103b477c9d08fbf653bd237772c36affbe8076fa6a9db4b4e6f17566044d41d90600401611595565b602060405180830381865afa158015610648573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061066c91906115b6565b604051630b3f2a6360e01b81529091506000906001600160a01b03871690630b3f2a63906106c290889088907f1aa3a92bf48444ec6c0ba221a56ba9a0eedb5e06c28b451a0096d0683ff4fdd390600401611595565b602060405180830381865afa1580156106df573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061070391906115b6565b604051630b3f2a6360e01b81529091506000906001600160a01b03881690630b3f2a639061075990899089907ffc56d60e2673ff4d0153a38470f3eee3bd706beb27296af9527af376772d03ec90600401611595565b602060405180830381865afa158015610776573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061079a91906115b6565b604051630b3f2a6360e01b81529091506000906001600160a01b03891690630b3f2a63906107f0908a908a907f212b8ca5b73d02e6853e972c50e032a23a9ec9c10fde0611fab187b57ca0686790600401611595565b602060405180830381865afa15801561080d573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061083191906115b6565b949f939e50939c50909a5098509650505050505050565b600054610100900460ff16158080156108685750600054600160ff909116105b806108825750303b158015610882575060005460ff166001145b6108ea5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff19166001179055801561090d576000805461ff0019166101001790555b610937827f8cc789c2d3266e9e63dd5b8192283743f1bdbee94b3d14699dfb608d2adffac1611155565b8015610151576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b610988610eb3565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102a95760405163a4b9148160e01b815260040160405180910390fd5b7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a66109fd816109f8610e09565b6111e2565b610a05610dc1565b6000610a307faeca1b630a909fd2c24c10ed836dbecc723968d7724ecc7c4d13aa36a4e4300861111e565b90506000610a5d7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba61111e565b905060005b848160ff161015610ce957610a7b609a80546001019055565b6000610a86609a5490565b6040516340c10f1960e01b81526001600160a01b038a8116600483015260248201839052919250908516906340c10f1990604401600060405180830381600087803b158015610ad457600080fd5b505af1158015610ae8573d6000803e3d6000fd5b5050604051637d4ec3b360e01b81526001600160a01b038781166004830152602482018590527f9319bf1fd23873eaf43c06bb91a1db3e678411d693e959f1512879196908f12c6044830152606482018b905286169250637d4ec3b39150608401600060405180830381600087803b158015610b6357600080fd5b505af1158015610b77573d6000803e3d6000fd5b505050506000610ba97f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a3100560001c61111e565b604051630b3f2a6360e01b81529091506000906001600160a01b03861690630b3f2a6390610bff9085908d907f9005b4bf3e8c5705ff2b172ed7c0ff76f0096efed0943457e640b66da01b97d290600401611595565b602060405180830381865afa158015610c1c573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610c4091906115b6565b604051637d4ec3b360e01b81526001600160a01b038881166004830152602482018690527f0800a4644d961a76e563e14ed4e1c1a13617cefd5c4c7ab3dc25232976c4d7a660448301526064820183905291925090861690637d4ec3b390608401600060405180830381600087803b158015610cbb57600080fd5b505af1158015610ccf573d6000803e3d6000fd5b505050505050508080610ce1906115cf565b915050610a62565b50505050505050565b610cfa610eb3565b6001600160a01b038116610d5f5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016108e1565b6102a9816110cc565b600260655403610dba5760405162461bcd60e51b815260206004820152601f60248201527f5265656e7472616e637947756172643a207265656e7472616e742063616c6c0060448201526064016108e1565b6002606555565b610dc96103ab565b156104485760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b60448201526064016108e1565b600060143610801590610e205750610e203361035e565b15610e32575060131936013560601c90565b503390565b6097546040516393f7cc9960e01b81526001600160a01b038381166004830152600092610100900416906393f7cc99906024015b602060405180830381865afa158015610e88573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103a591906115fc565b6001606555565b610ebb610e09565b6001600160a01b0316610ed66033546001600160a01b031690565b6001600160a01b0316146104485760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016108e1565b60975460ff1615610f765760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016108e1565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610fac610e09565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146110175760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016108e1565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610fac610e09565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa1580156110a1573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906110c59190611578565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401610e6b565b600054610100900460ff1661117c5760405162461bcd60e51b81526004016108e190611619565b61118461128b565b61118c6112ba565b60978054610100600160a81b0319166101006001600160a01b038516908102919091179091556111cf5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015611239573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061125d9190611578565b6101515760405162b0d32560e11b81526001600160a01b0382166004820152602481018390526044016108e1565b600054610100900460ff166112b25760405162461bcd60e51b81526004016108e190611619565b6104486112e9565b600054610100900460ff166112e15760405162461bcd60e51b81526004016108e190611619565b610448611320565b600054610100900460ff166113105760405162461bcd60e51b81526004016108e190611619565b61044861131b610e09565b6110cc565b600054610100900460ff16610eac5760405162461bcd60e51b81526004016108e190611619565b60006020828403121561135957600080fd5b813567ffffffffffffffff81111561137057600080fd5b820160a081850312156110c557600080fd5b6001600160a01b03811681146102a957600080fd5b600080604083850312156113aa57600080fd5b82356113b581611382565b946020939093013593505050565b602080825282518282018190526000919060409081850190868401855b8281101561140e57815180516001600160a01b031685528601518685015292840192908501906001016113e0565b5091979650505050505050565b634e487b7160e01b600052604160045260246000fd5b6000806040838503121561144457600080fd5b8235915060208084013567ffffffffffffffff8082111561146457600080fd5b818601915086601f83011261147857600080fd5b81358181111561148a5761148a61141b565b8060051b604051601f19603f830116810181811085821117156114af576114af61141b565b6040529182528482019250838101850191898311156114cd57600080fd5b938501935b828510156114eb578435845293850193928501926114d2565b8096505050505050509250929050565b80151581146102a957600080fd5b60006020828403121561151b57600080fd5b81356110c5816114fb565b60006020828403121561153857600080fd5b81356110c581611382565b60008060006060848603121561155857600080fd5b833561156381611382565b95602085013595506040909401359392505050565b60006020828403121561158a57600080fd5b81516110c5816114fb565b6001600160a01b039390931683526020830191909152604082015260600190565b6000602082840312156115c857600080fd5b5051919050565b600060ff821660ff81036115f357634e487b7160e01b600052601160045260246000fd5b60010192915050565b60006020828403121561160e57600080fd5b81516110c581611382565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea26469706673582212202fc1b4b46007872d15c57a0d615386fdb6676b8bdec49bdbf514d68b7771f37d64736f6c634300080d0033";
        public ShipsystemImplementationDeploymentBase() : base(BYTECODE) { }
        public ShipsystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CurrentShipIdFunction : CurrentShipIdFunctionBase { }

    [Function("currentShipId", "uint256")]
    public class CurrentShipIdFunctionBase : FunctionMessage
    {

    }

    public partial class EquipFunction : EquipFunctionBase { }

    [Function("equip")]
    public class EquipFunctionBase : FunctionMessage
    {
        [Parameter("tuple", "params", 1)]
        public virtual SlotInputParams Params { get; set; }
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

    public partial class GetSlotsFunction : GetSlotsFunctionBase { }

    [Function("getSlots", typeof(GetSlotsOutputDTO))]
    public class GetSlotsFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GetTokenTotalsDataFunction : GetTokenTotalsDataFunctionBase { }

    [Function("getTokenTotalsData", typeof(GetTokenTotalsDataOutputDTO))]
    public class GetTokenTotalsDataFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class EquippedEventDTO : EquippedEventDTOBase { }

    [Event("Equipped")]
    public class EquippedEventDTOBase : IEventDTO
    {
        [Parameter("address", "shipContract", 1, false )]
        public virtual string ShipContract { get; set; }
        [Parameter("uint256", "shipId", 2, false )]
        public virtual BigInteger ShipId { get; set; }
        [Parameter("address", "tokenContract", 3, false )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 4, false )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint8", "slotId", 5, false )]
        public virtual byte SlotId { get; set; }
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



    public partial class InvalidSlotIdError : InvalidSlotIdErrorBase { }

    [Error("InvalidSlotId")]
    public class InvalidSlotIdErrorBase : IErrorDTO
    {
        [Parameter("uint8", "slotId", 1)]
        public virtual byte SlotId { get; set; }
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

    public partial class GetSlotsOutputDTO : GetSlotsOutputDTOBase { }

    [FunctionOutput]
    public class GetSlotsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "", 1)]
        public virtual List<ShipSlot> ReturnValue1 { get; set; }
    }

    public partial class GetTokenTotalsDataOutputDTO : GetTokenTotalsDataOutputDTOBase { }

    [FunctionOutput]
    public class GetTokenTotalsDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("uint256", "", 4)]
        public virtual BigInteger ReturnValue4 { get; set; }
        [Parameter("uint256", "", 5)]
        public virtual BigInteger ReturnValue5 { get; set; }
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

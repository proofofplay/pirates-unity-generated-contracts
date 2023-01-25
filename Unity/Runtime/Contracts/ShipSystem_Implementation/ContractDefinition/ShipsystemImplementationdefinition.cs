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
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50611374806100206000396000f3fe608060405234801561001057600080fd5b50600436106100ea5760003560e01c8063865ef2431161008c578063dd898b2f11610066578063dd898b2f146101e1578063ed022ebd146101f4578063f2beec941461020a578063f2fde38b1461021d57600080fd5b8063865ef2431461016e5780638da5cb5b146101a9578063c4d66de8146101ce57600080fd5b8063572b6c05116100c8578063572b6c05146101335780635c975abb146101565780635d1ca6311461015e578063715018a61461016657600080fd5b806306c1cb91146100ef57806316c38b3c146101035780631b068ea814610116575b600080fd5b6101016100fd3660046110ca565b5050565b005b6101016101113660046111a2565b610230565b609a546101209081565b6040519081526020015b60405180910390f35b6101466101413660046111d4565b610251565b604051901515815260200161012a565b61014661029e565b609854610120565b610101610329565b61018161017c3660046111f1565b61033d565b604080519586526020860194909452928401919091526060830152608082015260a00161012a565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161012a565b6101016101dc3660046111d4565b610676565b6101016101ef3660046111d4565b6107ae565b60975461010090046001600160a01b03166101b6565b61010161021836600461121d565b6107f9565b61010161022b3660046111d4565b610af1565b610238610b67565b801561024957610246610be0565b50565b610246610c7d565b60975460009061010090046001600160a01b03161580159061029857506102987fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610cfe565b92915050565b60975460009060ff16806103245750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610300573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103249190611252565b905090565b610331610b67565b61033b6000610d80565b565b6000808080808061036d7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610dd2565b604051630b3f2a6360e01b81529091506000906001600160a01b03831690630b3f2a63906103c3908c908c907f9005b4bf3e8c5705ff2b172ed7c0ff76f0096efed0943457e640b66da01b97d29060040161126f565b602060405180830381865afa1580156103e0573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906104049190611290565b604051630b3f2a6360e01b81529091506000906001600160a01b03841690630b3f2a639061045a908d908d907f5103b477c9d08fbf653bd237772c36affbe8076fa6a9db4b4e6f17566044d41d9060040161126f565b602060405180830381865afa158015610477573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061049b9190611290565b604051630b3f2a6360e01b81529091506000906001600160a01b03851690630b3f2a63906104f1908e908e907f1aa3a92bf48444ec6c0ba221a56ba9a0eedb5e06c28b451a0096d0683ff4fdd39060040161126f565b602060405180830381865afa15801561050e573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105329190611290565b604051630b3f2a6360e01b81529091506000906001600160a01b03861690630b3f2a6390610588908f908f907ffc56d60e2673ff4d0153a38470f3eee3bd706beb27296af9527af376772d03ec9060040161126f565b602060405180830381865afa1580156105a5573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105c99190611290565b90506000856001600160a01b0316630b3f2a638e8e7f212b8ca5b73d02e6853e972c50e032a23a9ec9c10fde0611fab187b57ca0686760001c6040518463ffffffff1660e01b81526004016106209392919061126f565b602060405180830381865afa15801561063d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906106619190611290565b949d939c50939a509098509650945050505050565b600054610100900460ff16158080156106965750600054600160ff909116105b806106b05750303b1580156106b0575060005460ff166001145b6107185760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff19166001179055801561073b576000805461ff0019166101001790555b610765827f8cc789c2d3266e9e63dd5b8192283743f1bdbee94b3d14699dfb608d2adffac1610e45565b80156100fd576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6107b6610b67565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102465760405163a4b9148160e01b815260040160405180910390fd5b7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a661082b81610826610ed2565b610f00565b610833610fa9565b600061085e7faeca1b630a909fd2c24c10ed836dbecc723968d7724ecc7c4d13aa36a4e43008610dd2565b9050600061088b7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610dd2565b905060006108b87f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610dd2565b90508060005b868160ff161015610ae6576108d7609a80546001019055565b60006108e2609a5490565b6040516340c10f1960e01b81526001600160a01b038c8116600483015260248201839052919250908716906340c10f1990604401600060405180830381600087803b15801561093057600080fd5b505af1158015610944573d6000803e3d6000fd5b505060405163fb5b859760e01b81526001600160a01b038616925063fb5b8597915061097890899085908e9060040161126f565b600060405180830381600087803b15801561099257600080fd5b505af11580156109a6573d6000803e3d6000fd5b5050604051630b3f2a6360e01b8152600092506001600160a01b0388169150630b3f2a63906109fd9088908e907f9005b4bf3e8c5705ff2b172ed7c0ff76f0096efed0943457e640b66da01b97d29060040161126f565b602060405180830381865afa158015610a1a573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610a3e9190611290565b604051637d4ec3b360e01b81526001600160a01b038981166004830152602482018590527f0800a4644d961a76e563e14ed4e1c1a13617cefd5c4c7ab3dc25232976c4d7a660448301526064820183905291925090871690637d4ec3b390608401600060405180830381600087803b158015610ab957600080fd5b505af1158015610acd573d6000803e3d6000fd5b5050505050508080610ade906112a9565b9150506108be565b505050505050505050565b610af9610b67565b6001600160a01b038116610b5e5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b606482015260840161070f565b61024681610d80565b610b6f610ed2565b6001600160a01b0316610b8a6033546001600160a01b031690565b6001600160a01b03161461033b5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604482015260640161070f565b60975460ff1615610c2a5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161070f565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610c60610ed2565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610ccb5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161070f565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610c60610ed2565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610d55573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610d799190611252565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610e21573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061029891906112d6565b600054610100900460ff16610e6c5760405162461bcd60e51b815260040161070f906112f3565b610e74610ff1565b610e7c611020565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610ebf5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600060143610801590610ee95750610ee933610251565b15610efb575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610f57573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610f7b9190611252565b6100fd5760405162b0d32560e11b81526001600160a01b03821660048201526024810183905260440161070f565b610fb161029e565b1561033b5760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b604482015260640161070f565b600054610100900460ff166110185760405162461bcd60e51b815260040161070f906112f3565b61033b61104f565b600054610100900460ff166110475760405162461bcd60e51b815260040161070f906112f3565b61033b611086565b600054610100900460ff166110765760405162461bcd60e51b815260040161070f906112f3565b61033b611081610ed2565b610d80565b600054610100900460ff166110ad5760405162461bcd60e51b815260040161070f906112f3565b6001606555565b634e487b7160e01b600052604160045260246000fd5b600080604083850312156110dd57600080fd5b8235915060208084013567ffffffffffffffff808211156110fd57600080fd5b818601915086601f83011261111157600080fd5b813581811115611123576111236110b4565b8060051b604051601f19603f83011681018181108582111715611148576111486110b4565b60405291825284820192508381018501918983111561116657600080fd5b938501935b828510156111845784358452938501939285019261116b565b8096505050505050509250929050565b801515811461024657600080fd5b6000602082840312156111b457600080fd5b8135610d7981611194565b6001600160a01b038116811461024657600080fd5b6000602082840312156111e657600080fd5b8135610d79816111bf565b6000806040838503121561120457600080fd5b823561120f816111bf565b946020939093013593505050565b60008060006060848603121561123257600080fd5b833561123d816111bf565b95602085013595506040909401359392505050565b60006020828403121561126457600080fd5b8151610d7981611194565b6001600160a01b039390931683526020830191909152604082015260600190565b6000602082840312156112a257600080fd5b5051919050565b600060ff821660ff81036112cd57634e487b7160e01b600052601160045260246000fd5b60010192915050565b6000602082840312156112e857600080fd5b8151610d79816111bf565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea26469706673582212205f0f889d268d00f0909e5734c66076034bf040d1ce53d42b6b84cd44595a7b1c64736f6c634300080d0033";
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

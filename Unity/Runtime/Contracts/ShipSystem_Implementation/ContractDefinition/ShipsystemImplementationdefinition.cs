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
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50611494806100206000396000f3fe608060405234801561001057600080fd5b50600436106100ea5760003560e01c8063865ef2431161008c578063dd898b2f11610066578063dd898b2f146101e1578063ed022ebd146101f4578063f2beec941461020a578063f2fde38b1461021d57600080fd5b8063865ef2431461016e5780638da5cb5b146101a9578063c4d66de8146101ce57600080fd5b8063572b6c05116100c8578063572b6c05146101335780635c975abb146101565780635d1ca6311461015e578063715018a61461016657600080fd5b806306c1cb91146100ef57806316c38b3c146101035780631b068ea814610116575b600080fd5b6101016100fd3660046111ea565b5050565b005b6101016101113660046112c2565b610230565b6099546101209081565b6040519081526020015b60405180910390f35b6101466101413660046112f4565b610251565b604051901515815260200161012a565b61014661029e565b609854610120565b610101610329565b61018161017c366004611311565b61033d565b604080519586526020860194909452928401919091526060830152608082015260a00161012a565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161012a565b6101016101dc3660046112f4565b610676565b6101016101ef3660046112f4565b6107ae565b60975461010090046001600160a01b03166101b6565b61010161021836600461133d565b6107f9565b61010161022b3660046112f4565b610b90565b610238610c06565b801561024957610246610c7f565b50565b610246610d1c565b60975460009061010090046001600160a01b03161580159061029857506102987fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610d9d565b92915050565b60975460009060ff16806103245750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610300573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103249190611372565b905090565b610331610c06565b61033b6000610e1f565b565b6000808080808061036d7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610e71565b604051630b3f2a6360e01b81529091506000906001600160a01b03831690630b3f2a63906103c3908c908c907f9005b4bf3e8c5705ff2b172ed7c0ff76f0096efed0943457e640b66da01b97d29060040161138f565b602060405180830381865afa1580156103e0573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061040491906113b0565b604051630b3f2a6360e01b81529091506000906001600160a01b03841690630b3f2a639061045a908d908d907f5103b477c9d08fbf653bd237772c36affbe8076fa6a9db4b4e6f17566044d41d9060040161138f565b602060405180830381865afa158015610477573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061049b91906113b0565b604051630b3f2a6360e01b81529091506000906001600160a01b03851690630b3f2a63906104f1908e908e907f1aa3a92bf48444ec6c0ba221a56ba9a0eedb5e06c28b451a0096d0683ff4fdd39060040161138f565b602060405180830381865afa15801561050e573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061053291906113b0565b604051630b3f2a6360e01b81529091506000906001600160a01b03861690630b3f2a6390610588908f908f907ffc56d60e2673ff4d0153a38470f3eee3bd706beb27296af9527af376772d03ec9060040161138f565b602060405180830381865afa1580156105a5573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105c991906113b0565b90506000856001600160a01b0316630b3f2a638e8e7f212b8ca5b73d02e6853e972c50e032a23a9ec9c10fde0611fab187b57ca0686760001c6040518463ffffffff1660e01b81526004016106209392919061138f565b602060405180830381865afa15801561063d573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061066191906113b0565b949d939c50939a509098509650945050505050565b600054610100900460ff16158080156106965750600054600160ff909116105b806106b05750303b1580156106b0575060005460ff166001145b6107185760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff19166001179055801561073b576000805461ff0019166101001790555b610765827f8cc789c2d3266e9e63dd5b8192283743f1bdbee94b3d14699dfb608d2adffac1610ee4565b80156100fd576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6107b6610c06565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102465760405163a4b9148160e01b815260040160405180910390fd5b7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a661082b81610826610f71565b610f9f565b610833611048565b600182101561085557604051639482a43760e01b815260040160405180910390fd5b60006108807faeca1b630a909fd2c24c10ed836dbecc723968d7724ecc7c4d13aa36a4e43008610e71565b9050600061088c611090565b905060006108b97f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610e71565b90508060005b868160ff161015610b8557604051634f558e7960e01b8152600481018990526001600160a01b03831690634f558e7990602401602060405180830381865afa15801561090f573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109339190611372565b61095357604051632afa89e560e21b81526004810189905260240161070f565b610961609980546001019055565b600061096c60995490565b6040516340c10f1960e01b81526001600160a01b038c8116600483015260248201839052919250908716906340c10f1990604401600060405180830381600087803b1580156109ba57600080fd5b505af11580156109ce573d6000803e3d6000fd5b505060405163fb5b859760e01b81526001600160a01b038616925063fb5b85979150610a0290899085908e9060040161138f565b600060405180830381600087803b158015610a1c57600080fd5b505af1158015610a30573d6000803e3d6000fd5b5050604051632218394360e11b8152600092506001600160a01b0388169150634430728690610a879088908e907f9005b4bf3e8c5705ff2b172ed7c0ff76f0096efed0943457e640b66da01b97d29060040161138f565b602060405180830381865afa158015610aa4573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610ac891906113b0565b90506001600160a01b038616637d4ec3b388847f0800a4644d961a76e563e14ed4e1c1a13617cefd5c4c7ab3dc25232976c4d7a6610b05866110bb565b6040516001600160e01b031960e087901b1681526001600160a01b039094166004850152602484019290925260448301526064820152608401600060405180830381600087803b158015610b5857600080fd5b505af1158015610b6c573d6000803e3d6000fd5b5050505050508080610b7d906113c9565b9150506108bf565b505050505050505050565b610b98610c06565b6001600160a01b038116610bfd5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b606482015260840161070f565b61024681610e1f565b610c0e610f71565b6001600160a01b0316610c296033546001600160a01b031690565b6001600160a01b03161461033b5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604482015260640161070f565b60975460ff1615610cc95760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161070f565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610cff610f71565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610d6a5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161070f565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610cff610f71565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610df4573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610e189190611372565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610ec0573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061029891906113f6565b600054610100900460ff16610f0b5760405162461bcd60e51b815260040161070f90611413565b610f13611111565b610f1b611140565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610f5e5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600060143610801590610f885750610f8833610251565b15610f9a575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610ff6573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061101a9190611372565b6100fd5760405162b0d32560e11b81526001600160a01b03821660048201526024810183905260440161070f565b61105061029e565b1561033b5760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b604482015260640161070f565b60006103247f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610e71565b60008082121561110d5760405162461bcd60e51b815260206004820181905260248201527f53616665436173743a2076616c7565206d75737420626520706f736974697665604482015260640161070f565b5090565b600054610100900460ff166111385760405162461bcd60e51b815260040161070f90611413565b61033b61116f565b600054610100900460ff166111675760405162461bcd60e51b815260040161070f90611413565b61033b6111a6565b600054610100900460ff166111965760405162461bcd60e51b815260040161070f90611413565b61033b6111a1610f71565b610e1f565b600054610100900460ff166111cd5760405162461bcd60e51b815260040161070f90611413565b6001606555565b634e487b7160e01b600052604160045260246000fd5b600080604083850312156111fd57600080fd5b8235915060208084013567ffffffffffffffff8082111561121d57600080fd5b818601915086601f83011261123157600080fd5b813581811115611243576112436111d4565b8060051b604051601f19603f83011681018181108582111715611268576112686111d4565b60405291825284820192508381018501918983111561128657600080fd5b938501935b828510156112a45784358452938501939285019261128b565b8096505050505050509250929050565b801515811461024657600080fd5b6000602082840312156112d457600080fd5b8135610e18816112b4565b6001600160a01b038116811461024657600080fd5b60006020828403121561130657600080fd5b8135610e18816112df565b6000806040838503121561132457600080fd5b823561132f816112df565b946020939093013593505050565b60008060006060848603121561135257600080fd5b833561135d816112df565b95602085013595506040909401359392505050565b60006020828403121561138457600080fd5b8151610e18816112b4565b6001600160a01b039390931683526020830191909152604082015260600190565b6000602082840312156113c257600080fd5b5051919050565b600060ff821660ff81036113ed57634e487b7160e01b600052601160045260246000fd5b60010192915050565b60006020828403121561140857600080fd5b8151610e18816112df565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea2646970667358221220bae8e680f0e10606ed4c44d3cfb2c89ea3ee1c0281be55e73d2408b7461ed8fa64736f6c634300080d0033";
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

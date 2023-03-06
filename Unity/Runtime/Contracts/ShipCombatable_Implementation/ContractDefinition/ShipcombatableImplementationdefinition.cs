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

namespace PirateNationContracts.ShipCombatable_Implementation.ContractDefinition
{


    public partial class ShipcombatableImplementationDeployment : ShipcombatableImplementationDeploymentBase
    {
        public ShipcombatableImplementationDeployment() : base(BYTECODE) { }
        public ShipcombatableImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class ShipcombatableImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50611c1a806100206000396000f3fe608060405234801561001057600080fd5b50600436106101005760003560e01c80638003af0611610097578063c4d66de811610066578063c4d66de814610271578063dd898b2f14610284578063ed022ebd14610297578063f2fde38b146102ad57600080fd5b80638003af06146101a05780638da5cb5b146101b3578063a7518eb1146101d8578063aca2be77146101eb57600080fd5b8063572b6c05116100d3578063572b6c051461016b5780635c975abb1461017e5780635d1ca63114610186578063715018a61461019857600080fd5b806306c1cb911461010557806316c38b3c146101195780631f895fe01461012c57806334e7494114610154575b600080fd5b610117610113366004611740565b5050565b005b6101176101273660046117ef565b6102c0565b61013f61013a36600461186c565b6102e1565b60405190151581526020015b60405180910390f35b61013f6101623660046118c7565b60009392505050565b61013f610179366004611912565b610577565b61013f6105c4565b6098545b60405190815260200161014b565b61011761064f565b61018a6101ae36600461192f565b610663565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161014b565b61018a6101e636600461195f565b6106fe565b6101fe6101f9366004611981565b610744565b60405161014b9190600060e082019050825160070b8252602083015160070b6020830152604083015160070b6040830152606083015160070b606083015260808301516001600160401b0380821660808501528060a08601511660a08501528060c08601511660c0850152505092915050565b61011761027f366004611912565b610a12565b610117610292366004611912565b610b45565b60975461010090046001600160a01b03166101c0565b6101176102bb366004611912565b610b90565b6102c8610c06565b80156102d9576102d6610c7f565b50565b6102d6610d1c565b60008181036103035760405163d619882360e01b815260040160405180910390fd5b6000806103288585600081811061031c5761031c6119e1565b90506020020135610d9d565b909250905060006103587f95d42941a26c3bee551eb6f25644dd7ee2e9ee7546c58726e8391b6797fae479610dcb565b9050806001600160a01b0316836001600160a01b0316146103a4576040516316394eb760e31b81526001600160a01b038085166004830152821660248201526044015b60405180910390fd5b6040516331a9108f60e11b8152600481018390526001600160a01b03841690636352211e90602401602060405180830381865afa1580156103e9573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061040d91906119f7565b6001600160a01b0316886001600160a01b03161461045b5785856000818110610438576104386119e1565b905060200201356040516309acb99760e31b815260040161039b91815260200190565b61046487610d9d565b90935091506104927faeca1b630a909fd2c24c10ed836dbecc723968d7724ecc7c4d13aa36a4e43008610dcb565b6001600160a01b0316836001600160a01b0316146104c35760405163d2eff18b60e01b815260040160405180910390fd5b6040516331a9108f60e11b8152600481018390526001600160a01b03841690636352211e90602401602060405180830381865afa158015610508573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061052c91906119f7565b6001600160a01b0316886001600160a01b031614610560576040516309acb99760e31b81526004810188905260240161039b565b61056a8383610e3e565b1598975050505050505050565b60975460009061010090046001600160a01b0316158015906105be57506105be7fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610ed1565b92915050565b60975460009060ff168061064a5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610626573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061064a9190611a14565b905090565b610657610c06565b6106616000610f53565b565b600080600061067185610d9d565b604051630b3f2a6360e01b815291935091506001600160a01b03851690630b3f2a63906106b49085908590600080516020611bc583398151915290600401611a31565b602060405180830381865afa1580156106d1573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906106f59190611a52565b95945050505050565b60007fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536107328161072d610fa5565b610fd3565b61073c848461107c565b949350505050565b6040805160e081018252600080825260208201819052918101829052606081018290526080810182905260a0810182905260c08101919091526001821461079e5760405163d619882360e01b815260040160405180910390fd5b6000806107b78585600081811061031c5761031c6119e1565b9150915060006107c6896111c8565b905060006107f37f7a085781a4f509f705ae7172fa5414831ad1fa18fc3df61794293eaf9fb46ec9610dcb565b6001600160a01b0316638ca755c2896040518263ffffffff1660e01b815260040161082091815260200190565b600060405180830381865afa15801561083d573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526108659190810190611a6b565b90506040518060e0016040528082600081518110610885576108856119e1565b6020026020010151846000015161089c9190611b11565b60070b8152602001826001815181106108b7576108b76119e1565b602002602001015184602001516108ce9190611b11565b60070b8152602001826002815181106108e9576108e96119e1565b602002602001015184604001516109009190611b11565b60070b81526020018260038151811061091b5761091b6119e1565b602002602001015184606001516109329190611b11565b60070b815260200183608001516001600160401b0316815260200161095561155c565b604051630b3f2a6360e01b81526001600160a01b039190911690630b3f2a63906109a790899089907fc1d53b1a42e431705924ad84e50d0f360a4c24f43ce8baaeb54a46bf0fb0544490600401611a31565b602060405180830381865afa1580156109c4573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109e89190611a52565b6001600160401b03168152602001896001600160401b031681525094505050505095945050505050565b600054610100900460ff1615808015610a325750600054600160ff909116105b80610a4c5750303b158015610a4c575060005460ff166001145b610aaf5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b606482015260840161039b565b6000805460ff191660011790558015610ad2576000805461ff0019166101001790555b610afc827f0c25b7dd6caa5a04fed833204750a71d51cc9b254e1ecd29a0d9e68e8e91869e611587565b8015610113576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b610b4d610c06565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102d65760405163a4b9148160e01b815260040160405180910390fd5b610b98610c06565b6001600160a01b038116610bfd5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b606482015260840161039b565b6102d681610f53565b610c0e610fa5565b6001600160a01b0316610c296033546001600160a01b031690565b6001600160a01b0316146106615760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604482015260640161039b565b60975460ff1615610cc95760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161039b565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610cff610fa5565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610d6a5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161039b565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610cff610fa5565b8060a081901c6001600160a01b031982166001600160a01b03831617808314610dc557600080fd5b50915091565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610e1a573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105be91906119f7565b6000610e4861155c565b604051630b3f2a6360e01b81526001600160a01b039190911690630b3f2a6390610e889086908690600080516020611bc583398151915290600401611a31565b602060405180830381865afa158015610ea5573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610ec99190611a52565b159392505050565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610f28573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610f4c9190611a14565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600060143610801590610fbc5750610fbc33610577565b15610fce575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa15801561102a573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061104e9190611a14565b6101135760405162b0d32560e11b81526001600160a01b03821660048201526024810183905260440161039b565b600080600061108a85610d9d565b91509150600061109861155c565b604051630b3f2a6360e01b81526001600160a01b039190911690630b3f2a63906110d89086908690600080516020611bc583398151915290600401611a31565b602060405180830381865afa1580156110f5573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906111199190611a52565b905080851061112b5760009350611138565b6111358582611b62565b93505b61114061155c565b604051637d4ec3b360e01b81526001600160a01b03858116600483015260248201859052600080516020611bc58339815191526044830152606482018790529190911690637d4ec3b390608401600060405180830381600087803b1580156111a757600080fd5b505af11580156111bb573d6000803e3d6000fd5b5050505050505092915050565b6040805160e081018252600080825260208201819052918101829052606081018290526080810182905260a0810182905260c081018290529061122a7f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610dcb565b905060008061123885610d9d565b6040805160e0810191829052632218394360e11b9091529193509150806001600160a01b038516634430728661129386867f5103b477c9d08fbf653bd237772c36affbe8076fa6a9db4b4e6f17566044d41d60e48701611a31565b602060405180830381865afa1580156112b0573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906112d49190611a52565b60070b8152604051632218394360e11b81526020909101906001600160a01b0386169063443072869061132f90879087907f212b8ca5b73d02e6853e972c50e032a23a9ec9c10fde0611fab187b57ca0686790600401611a31565b602060405180830381865afa15801561134c573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906113709190611a52565b60070b8152604051632218394360e11b81526020909101906001600160a01b038616906344307286906113cb90879087907f1aa3a92bf48444ec6c0ba221a56ba9a0eedb5e06c28b451a0096d0683ff4fdd390600401611a31565b602060405180830381865afa1580156113e8573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061140c9190611a52565b60070b8152604051632218394360e11b81526020909101906001600160a01b0386169063443072869061146790879087907ffc56d60e2673ff4d0153a38470f3eee3bd706beb27296af9527af376772d03ec90600401611a31565b602060405180830381865afa158015611484573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906114a89190611a52565b60070b81526020016114b861155c565b604051630b3f2a6360e01b81526001600160a01b039190911690630b3f2a63906114f89087908790600080516020611bc583398151915290600401611a31565b602060405180830381865afa158015611515573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906115399190611a52565b6001600160401b0316815260006020820181905260409091015295945050505050565b600061064a7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610dcb565b600054610100900460ff166115ae5760405162461bcd60e51b815260040161039b90611b79565b6115b6611614565b6115be611643565b60978054610100600160a81b0319166101006001600160a01b038516908102919091179091556116015760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600054610100900460ff1661163b5760405162461bcd60e51b815260040161039b90611b79565b610661611672565b600054610100900460ff1661166a5760405162461bcd60e51b815260040161039b90611b79565b6106616116a9565b600054610100900460ff166116995760405162461bcd60e51b815260040161039b90611b79565b6106616116a4610fa5565b610f53565b600054610100900460ff166116d05760405162461bcd60e51b815260040161039b90611b79565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f191681016001600160401b0381118282101715611715576117156116d7565b604052919050565b60006001600160401b03821115611736576117366116d7565b5060051b60200190565b6000806040838503121561175357600080fd5b823591506020808401356001600160401b0381111561177157600080fd5b8401601f8101861361178257600080fd5b80356117956117908261171d565b6116ed565b81815260059190911b820183019083810190888311156117b457600080fd5b928401925b828410156117d2578335825292840192908401906117b9565b80955050505050509250929050565b80151581146102d657600080fd5b60006020828403121561180157600080fd5b8135610f4c816117e1565b6001600160a01b03811681146102d657600080fd5b60008083601f84011261183357600080fd5b5081356001600160401b0381111561184a57600080fd5b6020830191508360208260051b850101111561186557600080fd5b9250929050565b6000806000806060858703121561188257600080fd5b843561188d8161180c565b93506020850135925060408501356001600160401b038111156118af57600080fd5b6118bb87828801611821565b95989497509550505050565b6000806000604084860312156118dc57600080fd5b8335925060208401356001600160401b038111156118f957600080fd5b61190586828701611821565b9497909650939450505050565b60006020828403121561192457600080fd5b8135610f4c8161180c565b6000806040838503121561194257600080fd5b8235915060208301356119548161180c565b809150509250929050565b6000806040838503121561197257600080fd5b50508035926020909101359150565b60008060008060006080868803121561199957600080fd5b85359450602086013593506040860135925060608601356001600160401b038111156119c457600080fd5b6119d088828901611821565b969995985093965092949392505050565b634e487b7160e01b600052603260045260246000fd5b600060208284031215611a0957600080fd5b8151610f4c8161180c565b600060208284031215611a2657600080fd5b8151610f4c816117e1565b6001600160a01b039390931683526020830191909152604082015260600190565b600060208284031215611a6457600080fd5b5051919050565b60006020808385031215611a7e57600080fd5b82516001600160401b03811115611a9457600080fd5b8301601f81018513611aa557600080fd5b8051611ab36117908261171d565b81815260059190911b82018301908381019087831115611ad257600080fd5b928401925b82841015611af057835182529284019290840190611ad7565b979650505050505050565b634e487b7160e01b600052601160045260246000fd5b60008160070b8360070b6000821282677fffffffffffffff03821381151615611b3c57611b3c611afb565b82677fffffffffffffff19038212811615611b5957611b59611afb565b50019392505050565b600082821015611b7457611b74611afb565b500390565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fe0800a4644d961a76e563e14ed4e1c1a13617cefd5c4c7ab3dc25232976c4d7a6a2646970667358221220e65790a35d99f93fa39a2ae3aac62680dc5e7fdaf56c544263dd07ee4bc8110964736f6c634300080d0033";
        public ShipcombatableImplementationDeploymentBase() : base(BYTECODE) { }
        public ShipcombatableImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CanAttackFunction : CanAttackFunctionBase { }

    [Function("canAttack", "bool")]
    public class CanAttackFunctionBase : FunctionMessage
    {
        [Parameter("address", "caller", 1)]
        public virtual string Caller { get; set; }
        [Parameter("uint256", "entityId", 2)]
        public virtual BigInteger EntityId { get; set; }
        [Parameter("uint256[]", "overloads", 3)]
        public virtual List<BigInteger> Overloads { get; set; }
    }

    public partial class CanBeAttackedFunction : CanBeAttackedFunctionBase { }

    [Function("canBeAttacked", "bool")]
    public class CanBeAttackedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
        [Parameter("uint256[]", "", 2)]
        public virtual List<BigInteger> ReturnValue2 { get; set; }
    }

    public partial class DecreaseHealthFunction : DecreaseHealthFunctionBase { }

    [Function("decreaseHealth", "uint256")]
    public class DecreaseHealthFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entityId", 1)]
        public virtual BigInteger EntityId { get; set; }
        [Parameter("uint256", "amount", 2)]
        public virtual BigInteger Amount { get; set; }
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

    public partial class GetCombatStatsFunction : GetCombatStatsFunctionBase { }

    [Function("getCombatStats", typeof(GetCombatStatsOutputDTO))]
    public class GetCombatStatsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entityId", 1)]
        public virtual BigInteger EntityId { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("uint256", "moveId", 3)]
        public virtual BigInteger MoveId { get; set; }
        [Parameter("uint256[]", "overloads", 4)]
        public virtual List<BigInteger> Overloads { get; set; }
    }

    public partial class GetCurrentHealthFunction : GetCurrentHealthFunctionBase { }

    [Function("getCurrentHealth", "uint256")]
    public class GetCurrentHealthFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entityId", 1)]
        public virtual BigInteger EntityId { get; set; }
        [Parameter("address", "traitsProvider", 2)]
        public virtual string TraitsProvider { get; set; }
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



    public partial class InvalidPirateEntityError : InvalidPirateEntityErrorBase { }

    [Error("InvalidPirateEntity")]
    public class InvalidPirateEntityErrorBase : IErrorDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "", 2)]
        public virtual string ReturnValue2 { get; set; }
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

    public partial class NotOwnerError : NotOwnerErrorBase { }

    [Error("NotOwner")]
    public class NotOwnerErrorBase : IErrorDTO
    {
        [Parameter("uint256", "entityId", 1)]
        public virtual BigInteger EntityId { get; set; }
    }

    public partial class CanAttackOutputDTO : CanAttackOutputDTOBase { }

    [FunctionOutput]
    public class CanAttackOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class CanBeAttackedOutputDTO : CanBeAttackedOutputDTOBase { }

    [FunctionOutput]
    public class CanBeAttackedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }





    public partial class GetCombatStatsOutputDTO : GetCombatStatsOutputDTOBase { }

    [FunctionOutput]
    public class GetCombatStatsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual CombatStats ReturnValue1 { get; set; }
    }

    public partial class GetCurrentHealthOutputDTO : GetCurrentHealthOutputDTOBase { }

    [FunctionOutput]
    public class GetCurrentHealthOutputDTOBase : IFunctionOutputDTO 
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

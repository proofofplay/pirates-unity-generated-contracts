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

namespace PirateNationContracts.BossCombatable_Implementation.ContractDefinition
{


    public partial class BosscombatableImplementationDeployment : BosscombatableImplementationDeploymentBase
    {
        public BosscombatableImplementationDeployment() : base(BYTECODE) { }
        public BosscombatableImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class BosscombatableImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50611bbb806100206000396000f3fe608060405234801561001057600080fd5b50600436106101005760003560e01c80638003af0611610097578063c4d66de811610066578063c4d66de814610272578063dd898b2f14610285578063ed022ebd14610298578063f2fde38b146102ae57600080fd5b80638003af06146101a15780638da5cb5b146101b4578063a7518eb1146101d9578063aca2be77146101ec57600080fd5b8063572b6c05116100d3578063572b6c051461016c5780635c975abb1461017f5780635d1ca63114610187578063715018a61461019957600080fd5b806306c1cb911461010557806316c38b3c146101195780631f895fe01461012c57806334e7494114610159575b600080fd5b6101176101133660046116a7565b5050565b005b610117610127366004611756565b6102c1565b61014461013a3660046117d3565b6000949350505050565b60405190151581526020015b60405180910390f35b61014461016736600461182e565b6102e2565b61014461017a366004611879565b6104d4565b610144610521565b6098545b604051908152602001610150565b6101176105ac565b61018b6101af366004611896565b6105c0565b6033546001600160a01b03165b6040516001600160a01b039091168152602001610150565b61018b6101e73660046118c6565b61065b565b6101ff6101fa3660046118e8565b6106a1565b6040516101509190600060e082019050825160070b8252602083015160070b6020830152604083015160070b6040830152606083015160070b606083015260808301516001600160401b0380821660808501528060a08601511660a08501528060c08601511660c0850152505092915050565b610117610280366004611879565b61097b565b610117610293366004611879565b610ab3565b60975461010090046001600160a01b03166101c1565b6101176102bc366004611879565b610afe565b6102c9610b74565b80156102da576102d7610bed565b50565b6102d7610c8a565b60008060006102f086610d0b565b909250905061031e7f249f0029b58f324a3bcbecb56b6a93c463fbd1b75602a5aa9668226882f72545610d39565b6001600160a01b0316826001600160a01b03161461034f5760405163a9b5474760e01b815260040160405180910390fd5b600061037a7f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610d39565b604051630b3f2a6360e01b81529091506001600160a01b03821690630b3f2a63906103cd90869086907f283ca8d922279ebaba7b9617c775745b18b1c077ab61d09f071f0a5f39bd1d6b90600401611948565b602060405180830381865afa1580156103ea573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061040e9190611969565b421115806104ab5750604051630b3f2a6360e01b81526001600160a01b03821690630b3f2a639061046790869086907f218a0ce77df998fbb8654700e61349d1ad3534572bdde072a3a35bdbd614325790600401611948565b602060405180830381865afa158015610484573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906104a89190611969565b42115b156104bc57600093505050506104cd565b6104c68383610dac565b1593505050505b9392505050565b60975460009061010090046001600160a01b03161580159061051b575061051b7fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610e3f565b92915050565b60975460009060ff16806105a75750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610583573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105a79190611982565b905090565b6105b4610b74565b6105be6000610eba565b565b60008060006105ce85610d0b565b604051630b3f2a6360e01b815291935091506001600160a01b03851690630b3f2a63906106119085908590600080516020611b6683398151915290600401611948565b602060405180830381865afa15801561062e573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906106529190611969565b95945050505050565b60007fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb5361068f8161068a610f0c565b610f3a565b6106998484610fe3565b949350505050565b6040805160e081018252600080825260208201819052918101829052606081018290526080810182905260a0810182905260c0810182905290806106e488610d0b565b9150915060006106f38961112f565b9050600061070260068a61199f565b61070d9060016119d7565b9050600061073a7f7a085781a4f509f705ae7172fa5414831ad1fa18fc3df61794293eaf9fb46ec9610d39565b6001600160a01b0316638ca755c2836040518263ffffffff1660e01b815260040161076791815260200190565b600060405180830381865afa158015610784573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526107ac91908101906119ef565b90506040518060e00160405280826000815181106107cc576107cc611a7f565b602002602001015185600001516107e39190611a95565b60070b8152602001826001815181106107fe576107fe611a7f565b602002602001015185602001516108159190611a95565b60070b81526020018260028151811061083057610830611a7f565b602002602001015185604001516108479190611a95565b60070b81526020018260038151811061086257610862611a7f565b602002602001015185606001516108799190611a95565b60070b815260808501516001600160401b031660208201526040016108bd7f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610d39565b604051630b3f2a6360e01b81526001600160a01b039190911690630b3f2a639061090f908a908a907f45e804e8a8529dd5d30f66de8e7afaa2118a3bf9f14118a31e49f11b3abdb30190600401611948565b602060405180830381865afa15801561092c573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109509190611969565b6001600160401b03168152602001836001600160401b03168152509550505050505095945050505050565b600054610100900460ff161580801561099b5750600054600160ff909116105b806109b55750303b1580156109b5575060005460ff166001145b610a1d5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610a40576000805461ff0019166101001790555b610a6a827f735cd0a2931e539b8755c36b1776b7f2b2bf3b5b3ed5b2088e156704e4f172086114c3565b8015610113576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b610abb610b74565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102d75760405163a4b9148160e01b815260040160405180910390fd5b610b06610b74565b6001600160a01b038116610b6b5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610a14565b6102d781610eba565b610b7c610f0c565b6001600160a01b0316610b976033546001600160a01b031690565b6001600160a01b0316146105be5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610a14565b60975460ff1615610c375760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610a14565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610c6d610f0c565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610cd85760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610a14565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610c6d610f0c565b8060a081901c6001600160a01b031982166001600160a01b03831617808314610d3357600080fd5b50915091565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610d88573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061051b9190611ae6565b6000610db6611550565b604051630b3f2a6360e01b81526001600160a01b039190911690630b3f2a6390610df69086908690600080516020611b6683398151915290600401611948565b602060405180830381865afa158015610e13573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610e379190611969565b159392505050565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610e96573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906104cd9190611982565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600060143610801590610f235750610f23336104d4565b15610f35575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610f91573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610fb59190611982565b6101135760405162b0d32560e11b81526001600160a01b038216600482015260248101839052604401610a14565b6000806000610ff185610d0b565b915091506000610fff611550565b604051630b3f2a6360e01b81526001600160a01b039190911690630b3f2a639061103f9086908690600080516020611b6683398151915290600401611948565b602060405180830381865afa15801561105c573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906110809190611969565b9050808510611092576000935061109f565b61109c8582611b03565b93505b6110a7611550565b604051637d4ec3b360e01b81526001600160a01b03858116600483015260248201859052600080516020611b668339815191526044830152606482018790529190911690637d4ec3b390608401600060405180830381600087803b15801561110e57600080fd5b505af1158015611122573d6000803e3d6000fd5b5050505050505092915050565b6040805160e081018252600080825260208201819052918101829052606081018290526080810182905260a0810182905260c08101829052906111917f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610d39565b905060008061119f85610d0b565b6040805160e0810191829052632218394360e11b9091529193509150806001600160a01b03851663443072866111fa86867f5103b477c9d08fbf653bd237772c36affbe8076fa6a9db4b4e6f17566044d41d60e48701611948565b602060405180830381865afa158015611217573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061123b9190611969565b60070b8152604051632218394360e11b81526020909101906001600160a01b0386169063443072869061129690879087907f212b8ca5b73d02e6853e972c50e032a23a9ec9c10fde0611fab187b57ca0686790600401611948565b602060405180830381865afa1580156112b3573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906112d79190611969565b60070b8152604051632218394360e11b81526020909101906001600160a01b0386169063443072869061133290879087907f1aa3a92bf48444ec6c0ba221a56ba9a0eedb5e06c28b451a0096d0683ff4fdd390600401611948565b602060405180830381865afa15801561134f573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906113739190611969565b60070b8152604051632218394360e11b81526020909101906001600160a01b038616906344307286906113ce90879087907ffc56d60e2673ff4d0153a38470f3eee3bd706beb27296af9527af376772d03ec90600401611948565b602060405180830381865afa1580156113eb573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061140f9190611969565b60070b815260200161141f611550565b604051630b3f2a6360e01b81526001600160a01b039190911690630b3f2a639061145f9087908790600080516020611b6683398151915290600401611948565b602060405180830381865afa15801561147c573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906114a09190611969565b6001600160401b0316815260006020820181905260409091015295945050505050565b600054610100900460ff166114ea5760405162461bcd60e51b8152600401610a1490611b1a565b6114f261157b565b6114fa6115aa565b60978054610100600160a81b0319166101006001600160a01b0385169081029190911790915561153d5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b60006105a77f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610d39565b600054610100900460ff166115a25760405162461bcd60e51b8152600401610a1490611b1a565b6105be6115d9565b600054610100900460ff166115d15760405162461bcd60e51b8152600401610a1490611b1a565b6105be611610565b600054610100900460ff166116005760405162461bcd60e51b8152600401610a1490611b1a565b6105be61160b610f0c565b610eba565b600054610100900460ff166116375760405162461bcd60e51b8152600401610a1490611b1a565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f191681016001600160401b038111828210171561167c5761167c61163e565b604052919050565b60006001600160401b0382111561169d5761169d61163e565b5060051b60200190565b600080604083850312156116ba57600080fd5b823591506020808401356001600160401b038111156116d857600080fd5b8401601f810186136116e957600080fd5b80356116fc6116f782611684565b611654565b81815260059190911b8201830190838101908883111561171b57600080fd5b928401925b8284101561173957833582529284019290840190611720565b80955050505050509250929050565b80151581146102d757600080fd5b60006020828403121561176857600080fd5b81356104cd81611748565b6001600160a01b03811681146102d757600080fd5b60008083601f84011261179a57600080fd5b5081356001600160401b038111156117b157600080fd5b6020830191508360208260051b85010111156117cc57600080fd5b9250929050565b600080600080606085870312156117e957600080fd5b84356117f481611773565b93506020850135925060408501356001600160401b0381111561181657600080fd5b61182287828801611788565b95989497509550505050565b60008060006040848603121561184357600080fd5b8335925060208401356001600160401b0381111561186057600080fd5b61186c86828701611788565b9497909650939450505050565b60006020828403121561188b57600080fd5b81356104cd81611773565b600080604083850312156118a957600080fd5b8235915060208301356118bb81611773565b809150509250929050565b600080604083850312156118d957600080fd5b50508035926020909101359150565b60008060008060006080868803121561190057600080fd5b85359450602086013593506040860135925060608601356001600160401b0381111561192b57600080fd5b61193788828901611788565b969995985093965092949392505050565b6001600160a01b039390931683526020830191909152604082015260600190565b60006020828403121561197b57600080fd5b5051919050565b60006020828403121561199457600080fd5b81516104cd81611748565b6000826119bc57634e487b7160e01b600052601260045260246000fd5b500690565b634e487b7160e01b600052601160045260246000fd5b600082198211156119ea576119ea6119c1565b500190565b60006020808385031215611a0257600080fd5b82516001600160401b03811115611a1857600080fd5b8301601f81018513611a2957600080fd5b8051611a376116f782611684565b81815260059190911b82018301908381019087831115611a5657600080fd5b928401925b82841015611a7457835182529284019290840190611a5b565b979650505050505050565b634e487b7160e01b600052603260045260246000fd5b60008160070b8360070b6000821282677fffffffffffffff03821381151615611ac057611ac06119c1565b82677fffffffffffffff19038212811615611add57611add6119c1565b50019392505050565b600060208284031215611af857600080fd5b81516104cd81611773565b600082821015611b1557611b156119c1565b500390565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fe0800a4644d961a76e563e14ed4e1c1a13617cefd5c4c7ab3dc25232976c4d7a6a2646970667358221220f2707795b11b5cb1e6324226219f33297a6a48365a794c9b048f418b452d6af164736f6c634300080d0033";
        public BosscombatableImplementationDeploymentBase() : base(BYTECODE) { }
        public BosscombatableImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class CanAttackFunction : CanAttackFunctionBase { }

    [Function("canAttack", "bool")]
    public class CanAttackFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("uint256[]", "", 3)]
        public virtual List<BigInteger> ReturnValue3 { get; set; }
    }

    public partial class CanBeAttackedFunction : CanBeAttackedFunctionBase { }

    [Function("canBeAttacked", "bool")]
    public class CanBeAttackedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "entityId", 1)]
        public virtual BigInteger EntityId { get; set; }
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
        [Parameter("uint256", "roll", 2)]
        public virtual BigInteger Roll { get; set; }
        [Parameter("uint256", "", 3)]
        public virtual BigInteger ReturnValue3 { get; set; }
        [Parameter("uint256[]", "", 4)]
        public virtual List<BigInteger> ReturnValue4 { get; set; }
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





    public partial class MissingRoleError : MissingRoleErrorBase { }

    [Error("MissingRole")]
    public class MissingRoleErrorBase : IErrorDTO
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("bytes32", "expectedRole", 2)]
        public virtual byte[] ExpectedRole { get; set; }
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

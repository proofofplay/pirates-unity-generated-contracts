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

namespace PirateNationContracts.TokenActionSystem_Implementation.ContractDefinition
{


    public partial class TokenactionsystemImplementationDeployment : TokenactionsystemImplementationDeploymentBase
    {
        public TokenactionsystemImplementationDeployment() : base(BYTECODE) { }
        public TokenactionsystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class TokenactionsystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5061192e806100206000396000f3fe608060405234801561001057600080fd5b50600436106101005760003560e01c80638621240c11610097578063d7b017c711610066578063d7b017c714610220578063dd898b2f14610233578063ed022ebd14610246578063f2fde38b1461025c57600080fd5b80638621240c146101c95780638da5cb5b146101e957806390836160146101fa578063c4d66de81461020d57600080fd5b80635c975abb116100d35780635c975abb146101675780635d1ca6311461016f57806363b9491814610180578063715018a6146101c157600080fd5b806306c1cb911461010557806316c38b3c1461011957806343d18e551461012c578063572b6c051461013f575b600080fd5b61011761011336600461114e565b5050565b005b61011761012736600461120e565b61026f565b61011761013a366004611240565b610290565b61015261014d366004611305565b610538565b60405190151581526020015b60405180910390f35b610152610585565b60985460405190815260200161015e565b6101a961018e366004611322565b6000908152609960205260409020546001600160a01b031690565b6040516001600160a01b03909116815260200161015e565b610117610610565b6101dc6101d736600461133b565b610624565b60405161015e91906113bd565b6033546001600160a01b03166101a9565b6101176102083660046113f8565b61072b565b61011761021b366004611305565b6107e7565b61011761022e36600461147b565b61091a565b610117610241366004611305565b610a9f565b60975461010090046001600160a01b03166101a9565b61011761026a366004611305565b610aea565b610277610b60565b801561028857610285610bd9565b50565b610285610c76565b610298610cf7565b6102a0610d50565b60006102b26102ad610d98565b610dc6565b6000848152609960205260409020549091506001600160a01b0316806102f35760405163e16a9d4b60e01b8152600481018590526024015b60405180910390fd5b6001600160a01b0387166000908152609a6020908152604080832089845282528083208784529091529020805460ff1661034357604051636e9e363f60e01b8152600481018690526024016102ea565b604051627eeac760e11b81526001600160a01b03848116600483015260248201899052899160009183169062fdd58e90604401602060405180830381865afa158015610393573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103b791906114e3565b9050808811156103e457604051636584853f60e01b815260048101899052602481018290526044016102ea565b8254610100900460ff161561045d57604051637a94c56560e11b81526001600160a01b038681166004830152602482018b9052604482018a90528b169063f5298aca90606401600060405180830381600087803b15801561044457600080fd5b505af1158015610458573d6000803e3d6000fd5b505050505b6040516348287fd160e11b81526001600160a01b03851690639050ffa2906104969088908e908e908e9060018b01908e90600401611536565b600060405180830381600087803b1580156104b057600080fd5b505af11580156104c4573d6000803e3d6000fd5b5050604080516001600160a01b03808a1682528e1660208201529081018c9052606081018b9052608081018a90527f2f6a39e9fc9144751ab2648c46e182b869a591ded4a2b760b8c8b8b179cf6aa7925060a001905060405180910390a150505050506105316001606555565b5050505050565b60975460009061010090046001600160a01b03161580159061057f575061057f7fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610e41565b92915050565b60975460009060ff168061060b5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156105e7573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061060b91906115f9565b905090565b610618610b60565b6106226000610ec3565b565b6040805160608082018352600080835260208084018290528385018390526001600160a01b0388168252609a8152848220878352815284822086835281529084902084519283018552805460ff80821615158552610100909104161515918301919091526001810180549394929391928401916106a0906114fc565b80601f01602080910402602001604051908101604052809291908181526020018280546106cc906114fc565b80156107195780601f106106ee57610100808354040283529160200191610719565b820191906000526020600020905b8154815290600101906020018083116106fc57829003601f168201915b50505050508152505090509392505050565b7f241ecf16d79d0f8dbfb92cbc07fe17840425976cf0667f022fe9877caa831b0861075d81610758610d98565b610f15565b6000848460405161076f929190611616565b60408051918290038220600081815260996020529190912080546001600160a01b0319166001600160a01b038716179055915081907fdb6b78f4c98b1ea74526412b971e79b29292dac767309a5057e977e7e37a3165906107d790839089908990899061164f565b60405180910390a1505050505050565b600054610100900460ff16158080156108075750600054600160ff909116105b806108215750303b158015610821575060005460ff166001145b6108845760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084016102ea565b6000805460ff1916600117905580156108a7576000805461ff0019166101001790555b6108d1827fc85c265658fd924d2389a93b80a0ae1b6dec77536c7435229f25b554fa1e1380610fbe565b8015610113576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b7f241ecf16d79d0f8dbfb92cbc07fe17840425976cf0667f022fe9877caa831b0861094781610758610d98565b6000838152609960205260409020546001600160a01b0316806109805760405163e16a9d4b60e01b8152600481018590526024016102ea565b6001600160a01b0386166000908152609a602090815260408083208884528252808320878452909152902083906109b782826117df565b50506001600160a01b03811663bb42b3606109d56040860186611682565b6040518363ffffffff1660e01b81526004016109f292919061187c565b602060405180830381865afa158015610a0f573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610a3391906115f9565b1515600003610a5857604051635c5a36f560e01b8152600481018590526024016102ea565b604080516001600160a01b0388168152602081018790529081018590527f9198e319b9fda8eefb3d4d6f8f3a0f61378e262897ad4085e1580061094a7c42906060016107d7565b610aa7610b60565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102855760405163a4b9148160e01b815260040160405180910390fd5b610af2610b60565b6001600160a01b038116610b575760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016102ea565b61028581610ec3565b610b68610d98565b6001600160a01b0316610b836033546001600160a01b031690565b6001600160a01b0316146106225760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016102ea565b60975460ff1615610c235760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016102ea565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610c59610d98565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610cc45760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b60448201526064016102ea565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610c59610d98565b600260655403610d495760405162461bcd60e51b815260206004820152601f60248201527f5265656e7472616e637947756172643a207265656e7472616e742063616c6c0060448201526064016102ea565b6002606555565b610d58610585565b156106225760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b60448201526064016102ea565b600060143610801590610daf5750610daf33610538565b15610dc1575060131936013560601c90565b503390565b6097546040516393f7cc9960e01b81526001600160a01b038381166004830152600092610100900416906393f7cc9990602401602060405180830381865afa158015610e16573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061057f9190611890565b6001606555565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610e98573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610ebc91906115f9565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610f6c573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610f9091906115f9565b6101135760405162b0d32560e11b81526001600160a01b0382166004820152602481018390526044016102ea565b600054610100900460ff16610fe55760405162461bcd60e51b81526004016102ea906118ad565b610fed61104b565b610ff561107a565b60978054610100600160a81b0319166101006001600160a01b038516908102919091179091556110385760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600054610100900460ff166110725760405162461bcd60e51b81526004016102ea906118ad565b6106226110a9565b600054610100900460ff166110a15760405162461bcd60e51b81526004016102ea906118ad565b6106226110e0565b600054610100900460ff166110d05760405162461bcd60e51b81526004016102ea906118ad565b6106226110db610d98565b610ec3565b600054610100900460ff16610e3a5760405162461bcd60e51b81526004016102ea906118ad565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff8111828210171561114657611146611107565b604052919050565b6000806040838503121561116157600080fd5b8235915060208084013567ffffffffffffffff8082111561118157600080fd5b818601915086601f83011261119557600080fd5b8135818111156111a7576111a7611107565b8060051b91506111b884830161111d565b81815291830184019184810190898411156111d257600080fd5b938501935b838510156111f0578435825293850193908501906111d7565b8096505050505050509250929050565b801515811461028557600080fd5b60006020828403121561122057600080fd5b8135610ebc81611200565b6001600160a01b038116811461028557600080fd5b600080600080600060a0868803121561125857600080fd5b85356112638161122b565b945060208681013594506040870135935060608701359250608087013567ffffffffffffffff8082111561129657600080fd5b818901915089601f8301126112aa57600080fd5b8135818111156112bc576112bc611107565b6112ce601f8201601f1916850161111d565b91508082528a848285010111156112e457600080fd5b80848401858401376000848284010152508093505050509295509295909350565b60006020828403121561131757600080fd5b8135610ebc8161122b565b60006020828403121561133457600080fd5b5035919050565b60008060006060848603121561135057600080fd5b833561135b8161122b565b95602085013595506040909401359392505050565b6000815180845260005b818110156113965760208185018101518683018201520161137a565b818111156113a8576000602083870101525b50601f01601f19169290920160200192915050565b60208152815115156020820152602082015115156040820152600060408301516060808401526113f06080840182611370565b949350505050565b60008060006040848603121561140d57600080fd5b833567ffffffffffffffff8082111561142557600080fd5b818601915086601f83011261143957600080fd5b81358181111561144857600080fd5b87602082850101111561145a57600080fd5b602092830195509350508401356114708161122b565b809150509250925092565b6000806000806080858703121561149157600080fd5b843561149c8161122b565b93506020850135925060408501359150606085013567ffffffffffffffff8111156114c657600080fd5b8501606081880312156114d857600080fd5b939692955090935050565b6000602082840312156114f557600080fd5b5051919050565b600181811c9082168061151057607f821691505b60208210810361153057634e487b7160e01b600052602260045260246000fd5b50919050565b600060018060a01b03808916835260208189168185015287604085015286606085015260c0608085015260009150855461156f816114fc565b8060c087015260e060018084166000811461159157600181146115a6576115d4565b60ff19851689840152610100890196506115d4565b8a6000528560002060005b858110156115cc5781548b82018601529083019087016115b1565b8a0184019750505b50505050505082810360a08401526115ec8185611370565b9998505050505050505050565b60006020828403121561160b57600080fd5b8151610ebc81611200565b8183823760009101908152919050565b81835281816020850137506000828201602090810191909152601f909101601f19169091010190565b848152606060208201526000611669606083018587611626565b905060018060a01b038316604083015295945050505050565b6000808335601e1984360301811261169957600080fd5b83018035915067ffffffffffffffff8211156116b457600080fd5b6020019150368190038213156116c957600080fd5b9250929050565b601f82111561171a57600081815260208120601f850160051c810160208610156116f75750805b601f850160051c820191505b8181101561171657828155600101611703565b5050505b505050565b67ffffffffffffffff83111561173757611737611107565b61174b8361174583546114fc565b836116d0565b6000601f84116001811461177f57600085156117675750838201355b600019600387901b1c1916600186901b178355610531565b600083815260209020601f19861690835b828110156117b05786850135825560209485019460019092019101611790565b50868210156117cd5760001960f88860031b161c19848701351681555b505060018560011b0183555050505050565b81356117ea81611200565b815460ff19811691151560ff169182178355602084013561180a81611200565b61ffff199190911690911790151560081b61ff0016178155604082013536839003601e1901811261183a57600080fd5b8201803567ffffffffffffffff81111561185357600080fd5b60208201915080360382131561186857600080fd5b61187681836001860161171f565b50505050565b6020815260006113f0602083018486611626565b6000602082840312156118a257600080fd5b8151610ebc8161122b565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea2646970667358221220daf32de52f16e13a95042eb14510f14fd1db50c6cb7462787be6ba9250ee50ef64736f6c634300080d0033";
        public TokenactionsystemImplementationDeploymentBase() : base(BYTECODE) { }
        public TokenactionsystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class GetActionForTokenFunction : GetActionForTokenFunctionBase { }

    [Function("getActionForToken", typeof(GetActionForTokenOutputDTO))]
    public class GetActionForTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "actionId", 3)]
        public virtual BigInteger ActionId { get; set; }
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

    public partial class GetTokenActionContractFunction : GetTokenActionContractFunctionBase { }

    [Function("getTokenActionContract", "address")]
    public class GetTokenActionContractFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "actionId", 1)]
        public virtual BigInteger ActionId { get; set; }
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

    public partial class PerformGameItemActionFunction : PerformGameItemActionFunctionBase { }

    [Function("performGameItemAction")]
    public class PerformGameItemActionFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("uint256", "actionId", 4)]
        public virtual BigInteger ActionId { get; set; }
        [Parameter("bytes", "runtimeData", 5)]
        public virtual byte[] RuntimeData { get; set; }
    }

    public partial class RegisterTokenActionContractFunction : RegisterTokenActionContractFunctionBase { }

    [Function("registerTokenActionContract")]
    public class RegisterTokenActionContractFunctionBase : FunctionMessage
    {
        [Parameter("string", "actionName", 1)]
        public virtual string ActionName { get; set; }
        [Parameter("address", "tokenActionContract", 2)]
        public virtual string TokenActionContract { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SetActionForTokenFunction : SetActionForTokenFunctionBase { }

    [Function("setActionForToken")]
    public class SetActionForTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "actionId", 3)]
        public virtual BigInteger ActionId { get; set; }
        [Parameter("tuple", "actionProps", 4)]
        public virtual ActionProps ActionProps { get; set; }
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

    public partial class PerformGameItemActionEventDTO : PerformGameItemActionEventDTOBase { }

    [Event("PerformGameItemAction")]
    public class PerformGameItemActionEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false )]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2, false )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3, false )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 4, false )]
        public virtual BigInteger Amount { get; set; }
        [Parameter("uint256", "actionId", 5, false )]
        public virtual BigInteger ActionId { get; set; }
    }

    public partial class RegisterTokenActionEventDTO : RegisterTokenActionEventDTOBase { }

    [Event("RegisterTokenAction")]
    public class RegisterTokenActionEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "actionId", 1, false )]
        public virtual BigInteger ActionId { get; set; }
        [Parameter("string", "actionName", 2, false )]
        public virtual string ActionName { get; set; }
        [Parameter("address", "tokenActionContract", 3, false )]
        public virtual string TokenActionContract { get; set; }
    }

    public partial class SetActionForTokenEventDTO : SetActionForTokenEventDTOBase { }

    [Event("SetActionForToken")]
    public class SetActionForTokenEventDTOBase : IEventDTO
    {
        [Parameter("address", "tokenContract", 1, false )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2, false )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "actionId", 3, false )]
        public virtual BigInteger ActionId { get; set; }
    }

    public partial class UnpausedEventDTO : UnpausedEventDTOBase { }

    [Event("Unpaused")]
    public class UnpausedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false )]
        public virtual string Account { get; set; }
    }

    public partial class ActionNotEnabledError : ActionNotEnabledErrorBase { }

    [Error("ActionNotEnabled")]
    public class ActionNotEnabledErrorBase : IErrorDTO
    {
        [Parameter("uint256", "actionId", 1)]
        public virtual BigInteger ActionId { get; set; }
    }

    public partial class ActionNotRegisteredError : ActionNotRegisteredErrorBase { }

    [Error("ActionNotRegistered")]
    public class ActionNotRegisteredErrorBase : IErrorDTO
    {
        [Parameter("uint256", "actionId", 1)]
        public virtual BigInteger ActionId { get; set; }
    }



    public partial class InvalidInitDataError : InvalidInitDataErrorBase { }

    [Error("InvalidInitData")]
    public class InvalidInitDataErrorBase : IErrorDTO
    {
        [Parameter("uint256", "actionId", 1)]
        public virtual BigInteger ActionId { get; set; }
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

    public partial class NotEnoughTokensError : NotEnoughTokensErrorBase { }

    [Error("NotEnoughTokens")]
    public class NotEnoughTokensErrorBase : IErrorDTO
    {
        [Parameter("uint256", "expected", 1)]
        public virtual BigInteger Expected { get; set; }
        [Parameter("uint256", "actual", 2)]
        public virtual BigInteger Actual { get; set; }
    }



    public partial class GetActionForTokenOutputDTO : GetActionForTokenOutputDTOBase { }

    [FunctionOutput]
    public class GetActionForTokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual ActionProps ReturnValue1 { get; set; }
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

    public partial class GetTokenActionContractOutputDTO : GetTokenActionContractOutputDTOBase { }

    [FunctionOutput]
    public class GetTokenActionContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
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

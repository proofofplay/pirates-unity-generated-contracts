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

namespace PirateNationContracts.AchievementNFTTokenURIHandler_Implementation.ContractDefinition
{


    public partial class AchievementnfttokenurihandlerImplementationDeployment : AchievementnfttokenurihandlerImplementationDeploymentBase
    {
        public AchievementnfttokenurihandlerImplementationDeployment() : base(BYTECODE) { }
        public AchievementnfttokenurihandlerImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class AchievementnfttokenurihandlerImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50611cbb806100206000396000f3fe608060405234801561001057600080fd5b50600436106100f55760003560e01c806377cedfa911610097578063dfd01ff311610066578063dfd01ff3146101f9578063ed022ebd14610219578063f2fde38b1461022f578063f4bef99c1461024257600080fd5b806377cedfa91461018e5780638da5cb5b146101ae578063c4d66de8146101d3578063dd898b2f146101e657600080fd5b8063572b6c05116100d3578063572b6c051461014a5780635c975abb1461016d5780635d1ca63114610175578063715018a61461018657600080fd5b806306c1cb91146100fa57806316c38b3c1461010e5780632371b58d14610121575b600080fd5b61010c610108366004611733565b5050565b005b61010c61011c3660046117f3565b610262565b61013461012f366004611825565b610283565b604051610141919061195d565b60405180910390f35b61015d610158366004611970565b610c1d565b6040519015158152602001610141565b61015d610c6a565b609854604051908152602001610141565b61010c610cf5565b6101a161019c366004611970565b610d09565b604051610141919061198d565b6033546001600160a01b03165b6040516001600160a01b039091168152602001610141565b61010c6101e1366004611970565b610d34565b61010c6101f4366004611970565b610e6c565b61020c610207366004611825565b610eb7565b60405161014191906119d1565b60975461010090046001600160a01b03166101bb565b61010c61023d366004611970565b611102565b610255610250366004611a54565b611178565b6040516101419190611a95565b61026a61122e565b801561027b576102786112a7565b50565b610278611344565b60608260006102b17f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a310056113c5565b60408051600580825260c082019092529192509060009082816020015b6102f7604080516080810182526060808252602082015290810160008152600060209091015290565b8152602001906001900390816102ce579050506040805160c081018252600c608082019081526b195e1d195c9b985b17dd5c9b60a21b60a0830152815290516374ca428360e01b8152600481018990529192509060208201906001600160a01b038716906374ca428390602401600060405180830381865afa158015610381573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526103a99190810190611af7565b6040516020016103b99190611a95565b60408051808303601f19018152918152908252600460208301526001910152815182906000906103eb576103eb611b48565b6020908102919091018101919091526040805160c081018252600460808201818152636e616d6560e01b60a084015282529151639b9a15b360e01b815290928301916001600160a01b03871691639b9a15b39161045c918d918d91600080516020611c668339815191529101611b5e565b602060405180830381865afa158015610479573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061049d9190611b7f565b6105325760405163e725f87760e01b8152600481018990526001600160a01b0387169063e725f87790602401600060405180830381865afa1580156104e6573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f1916820160405261050e9190810190611af7565b60405160200161051e9190611a95565b6040516020818303038152906040526105b5565b60405163108e6af960e21b81526001600160a01b03861690634239abe490610570908c908c90600080516020611c6683398151915290600401611b5e565b600060405180830381865afa15801561058d573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526105b59190810190611af7565b81526020016004815260200160011515815250816001815181106105db576105db611b48565b6020908102919091018101919091526040805160c08101825260056080820190815264696d61676560d81b60a083015281529051639b9a15b360e01b815290918201906001600160a01b03861690639b9a15b390610661908c908c907fdd8c1d6d2c9a745d80261bb0d7b0c6ba96f1ea6479fc4ab1935153a72f28db1f90600401611b5e565b602060405180830381865afa15801561067e573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906106a29190611b7f565b610737576040516347ba168b60e11b8152600481018990526001600160a01b03871690638f742d1690602401600060405180830381865afa1580156106eb573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526107139190810190611af7565b6040516020016107239190611a95565b6040516020818303038152906040526107cc565b60405163108e6af960e21b81526001600160a01b03861690634239abe490610787908c908c907fdd8c1d6d2c9a745d80261bb0d7b0c6ba96f1ea6479fc4ab1935153a72f28db1f90600401611b5e565b600060405180830381865afa1580156107a4573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526107cc9190810190611af7565b81526020016004815260200160011515815250816002815181106107f2576107f2611b48565b6020908102919091018101919091526040805160c081018252600b608082019081526a3232b9b1b934b83a34b7b760a91b60a083015281529051639b9a15b360e01b815290918201906001600160a01b03861690639b9a15b39061087e908c908c907f7452e56ec9dd836d15d444262499c5f01e617174be1abe27bc773c8a8890b9cb90600401611b5e565b602060405180830381865afa15801561089b573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906108bf9190611b7f565b6109545760405163a0c6d53760e01b8152600481018990526001600160a01b0387169063a0c6d53790602401600060405180830381865afa158015610908573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526109309190810190611af7565b6040516020016109409190611a95565b6040516020818303038152906040526109e9565b60405163108e6af960e21b81526001600160a01b03861690634239abe4906109a4908c908c907f7452e56ec9dd836d15d444262499c5f01e617174be1abe27bc773c8a8890b9cb90600401611b5e565b600060405180830381865afa1580156109c1573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526109e99190810190611af7565b8152602001600481526020016001151581525081600381518110610a0f57610a0f611b48565b6020908102919091018101919091526040805160c081018252600b608082019081526a1058da1a595d995b595b9d60aa1b60a083015281529051639b9a15b360e01b815290918201906001600160a01b03861690639b9a15b390610a89908c908c90600080516020611c6683398151915290600401611b5e565b602060405180830381865afa158015610aa6573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610aca9190611b7f565b610b5f5760405163e725f87760e01b8152600481018990526001600160a01b0387169063e725f87790602401600060405180830381865afa158015610b13573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f19168201604052610b3b9190810190611af7565b604051602001610b4b9190611a95565b604051602081830303815290604052610be2565b60405163108e6af960e21b81526001600160a01b03861690634239abe490610b9d908c908c90600080516020611c6683398151915290600401611b5e565b600060405180830381865afa158015610bba573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f19168201604052610be29190810190611af7565b8152602001600481526020016000151581525081600481518110610c0857610c08611b48565b60209081029190910101529695505050505050565b60975460009061010090046001600160a01b031615801590610c645750610c647fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283611438565b92915050565b60975460009060ff1680610cf05750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610ccc573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610cf09190611b7f565b905090565b610cfd61122e565b610d0760006114b3565b565b6001600160a01b0381166000908152609960205260409020606090610d2d81611505565b9392505050565b600054610100900460ff1615808015610d545750600054600160ff909116105b80610d6e5750303b158015610d6e575060005460ff166001145b610dd65760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610df9576000805461ff0019166101001790555b610e23827f0136299c864bcbe7021d81aa25b0f41b146c4a771a8c912aa808a142dd430b18611512565b8015610108576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b610e7461122e565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102785760405163a4b9148160e01b815260040160405180910390fd5b610ef16040518060a00160405280606081526020016060815260200160608152602001600061ffff168152602001600061ffff1681525090565b6001600160a01b03831660009081526099602090815260408083208584526002810190925291829020825160a08101909352805491929182908290610f3590611b9c565b80601f0160208091040260200160405190810160405280929190818152602001828054610f6190611b9c565b8015610fae5780601f10610f8357610100808354040283529160200191610fae565b820191906000526020600020905b815481529060010190602001808311610f9157829003601f168201915b50505050508152602001600182018054610fc790611b9c565b80601f0160208091040260200160405190810160405280929190818152602001828054610ff390611b9c565b80156110405780601f1061101557610100808354040283529160200191611040565b820191906000526020600020905b81548152906001019060200180831161102357829003601f168201915b5050505050815260200160028201805461105990611b9c565b80601f016020809104026020016040519081016040528092919081815260200182805461108590611b9c565b80156110d25780601f106110a7576101008083540402835291602001916110d2565b820191906000526020600020905b8154815290600101906020018083116110b557829003601f168201915b50505091835250506003919091015461ffff80821660208401526201000090910416604090910152949350505050565b61110a61122e565b6001600160a01b03811661116f5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610dcd565b610278816114b3565b606060006111a57f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a310056113c5565b9050806001600160a01b0316639b6ddb0e85856111c28888610283565b6040518463ffffffff1660e01b81526004016111e093929190611bd6565b600060405180830381865afa1580156111fd573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526112259190810190611af7565b95945050505050565b61123661159f565b6001600160a01b03166112516033546001600160a01b031690565b6001600160a01b031614610d075760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610dcd565b60975460ff16156112f15760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610dcd565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a25861132761159f565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146113925760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610dcd565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa61132761159f565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015611414573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610c649190611bfd565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa15801561148f573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610d2d9190611b7f565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b60606000610d2d836115cd565b600054610100900460ff166115395760405162461bcd60e51b8152600401610dcd90611c1a565b611541611629565b611549611658565b60978054610100600160a81b0319166101006001600160a01b0385169081029190911790915561158c5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b6000601436108015906115b657506115b633610c1d565b156115c8575060131936013560601c90565b503390565b60608160000180548060200260200160405190810160405280929190818152602001828054801561161d57602002820191906000526020600020905b815481526020019060010190808311611609575b50505050509050919050565b600054610100900460ff166116505760405162461bcd60e51b8152600401610dcd90611c1a565b610d07611687565b600054610100900460ff1661167f5760405162461bcd60e51b8152600401610dcd90611c1a565b610d076116be565b600054610100900460ff166116ae5760405162461bcd60e51b8152600401610dcd90611c1a565b610d076116b961159f565b6114b3565b600054610100900460ff166116e55760405162461bcd60e51b8152600401610dcd90611c1a565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff8111828210171561172b5761172b6116ec565b604052919050565b6000806040838503121561174657600080fd5b8235915060208084013567ffffffffffffffff8082111561176657600080fd5b818601915086601f83011261177a57600080fd5b81358181111561178c5761178c6116ec565b8060051b915061179d848301611702565b81815291830184019184810190898411156117b757600080fd5b938501935b838510156117d5578435825293850193908501906117bc565b8096505050505050509250929050565b801515811461027857600080fd5b60006020828403121561180557600080fd5b8135610d2d816117e5565b6001600160a01b038116811461027857600080fd5b6000806040838503121561183857600080fd5b823561184381611810565b946020939093013593505050565b60005b8381101561186c578181015183820152602001611854565b8381111561187b576000848401525b50505050565b60008151808452611899816020860160208601611851565b601f01601f19169290920160200192915050565b600082825180855260208086019550808260051b8401018186016000805b8581101561194f57601f19878503018a528251608081518187526118f182880182611881565b91505086820151868203888801526119098282611881565b9150506040808301516007811061192e57634e487b7160e01b86526021600452602486fd5b908701526060918201511515919095015298840198918401916001016118cb565b509198975050505050505050565b602081526000610d2d60208301846118ad565b60006020828403121561198257600080fd5b8135610d2d81611810565b6020808252825182820181905260009190848201906040850190845b818110156119c5578351835292840192918401916001016119a9565b50909695505050505050565b602081526000825160a060208401526119ed60c0840182611881565b90506020840151601f1980858403016040860152611a0b8383611881565b9250604086015191508085840301606086015250611a298282611881565b915050606084015161ffff80821660808601528060808701511660a086015250508091505092915050565b600080600060608486031215611a6957600080fd5b8335611a7481611810565b92506020840135611a8481611810565b929592945050506040919091013590565b602081526000610d2d6020830184611881565b600067ffffffffffffffff831115611ac257611ac26116ec565b611ad5601f8401601f1916602001611702565b9050828152838383011115611ae957600080fd5b610d2d836020830184611851565b600060208284031215611b0957600080fd5b815167ffffffffffffffff811115611b2057600080fd5b8201601f81018413611b3157600080fd5b611b4084825160208401611aa8565b949350505050565b634e487b7160e01b600052603260045260246000fd5b6001600160a01b039390931683526020830191909152604082015260600190565b600060208284031215611b9157600080fd5b8151610d2d816117e5565b600181811c90821680611bb057607f821691505b602082108103611bd057634e487b7160e01b600052602260045260246000fd5b50919050565b60018060a01b038416815282602082015260606040820152600061122560608301846118ad565b600060208284031215611c0f57600080fd5b8151610d2d81611810565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056feb5e7e7e737f64f2b9cbe8f990b1f427fc2a03b47e93daeea99b83c32061778a7a2646970667358221220c4a8c2c1d0427e63daec65b955f03253ee0868b97ccbfb6bcac69d2e84620c0864736f6c634300080d0033";
        public AchievementnfttokenurihandlerImplementationDeploymentBase() : base(BYTECODE) { }
        public AchievementnfttokenurihandlerImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class GetAssetFunction : GetAssetFunctionBase { }

    [Function("getAsset", typeof(GetAssetOutputDTO))]
    public class GetAssetFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "traitId", 2)]
        public virtual BigInteger TraitId { get; set; }
    }

    public partial class GetAssetTraitIdsFunction : GetAssetTraitIdsFunctionBase { }

    [Function("getAssetTraitIds", "uint256[]")]
    public class GetAssetTraitIdsFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
    }

    public partial class GetExtraTraitsFunction : GetExtraTraitsFunctionBase { }

    [Function("getExtraTraits", typeof(GetExtraTraitsOutputDTO))]
    public class GetExtraTraitsFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class TokenURIFunction : TokenURIFunctionBase { }

    [Function("tokenURI", "string")]
    public class TokenURIFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
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



    public partial class GetAssetOutputDTO : GetAssetOutputDTOBase { }

    [FunctionOutput]
    public class GetAssetOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual Asset ReturnValue1 { get; set; }
    }

    public partial class GetAssetTraitIdsOutputDTO : GetAssetTraitIdsOutputDTOBase { }

    [FunctionOutput]
    public class GetAssetTraitIdsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
    }

    public partial class GetExtraTraitsOutputDTO : GetExtraTraitsOutputDTOBase { }

    [FunctionOutput]
    public class GetExtraTraitsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple[]", "", 1)]
        public virtual List<TokenURITrait> ReturnValue1 { get; set; }
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







    public partial class TokenURIOutputDTO : TokenURIOutputDTOBase { }

    [FunctionOutput]
    public class TokenURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }


}

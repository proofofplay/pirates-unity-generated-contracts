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

namespace PirateNationContracts.GameRegistry_Implementation.ContractDefinition
{


    public partial class GameregistryImplementationDeployment : GameregistryImplementationDeploymentBase
    {
        public GameregistryImplementationDeployment() : base(BYTECODE) { }
        public GameregistryImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class GameregistryImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506122f1806100206000396000f3fe608060405234801561001057600080fd5b50600436106101735760003560e01c80635c975abb116100de57806393f7cc9911610097578063d547741f11610071578063d547741f14610340578063d8cf98ca14610353578063e6ce49b014610366578063f2fde38b1461038657600080fd5b806393f7cc9914610312578063a217fddf14610325578063c36dd7ea1461032d57600080fd5b80635c975abb146102c3578063715018a6146102cb5780638129fc1c146102d3578063868b4ea3146102db5780638da5cb5b146102ee57806391d14854146102ff57600080fd5b80632f2ff15d116101305780632f2ff15d1461022157806336568abe146102345780634b9b233d1461024757806353e41c1e14610267578063552b6cbd146102a8578063572b6c05146102b057600080fd5b806301ffc9a7146101785780631548a8de146101a057806316c38b3c146101c057806323b73080146101d5578063248a9ca3146101eb5780632e9e37da1461020e575b600080fd5b61018b610186366004611d56565b610399565b60405190151581526020015b60405180910390f35b6101b36101ae366004611d9c565b6103df565b6040516101979190611e3a565b6101d36101ce366004611e4d565b610447565b005b6101dd607881565b604051908152602001610197565b6101dd6101f9366004611e6f565b60009081526065602052604090206001015490565b6101d361021c366004611e88565b61050c565b6101d361022f366004611e88565b61056d565b6101d3610242366004611e88565b610597565b61025a610255366004611eb4565b610625565b6040516101979190611ecf565b610290610275366004611e6f565b600090815260fc60205260409020546001600160a01b031690565b6040516001600160a01b039091168152602001610197565b6101dd601e81565b61018b6102be366004611eb4565b610649565b61018b610675565b6101d3610688565b6101d361069c565b6101d36102e9366004611f1c565b610959565b6097546001600160a01b0316610290565b61018b61030d366004611e88565b610c8b565b610290610320366004611eb4565b610cb6565b6101dd600081565b61018b61033b366004611e88565b610d65565b6101d361034e366004611e88565b610d71565b6101d3610361366004611eb4565b610d96565b6101dd610374366004611eb4565b60fb6020526000908152604090205481565b6101d3610394366004611eb4565b610ee2565b60006001600160e01b03198216631c5dda8360e21b14806103ca57506001600160e01b031982166301ffc9a760e01b145b806103d957506103d982610f58565b92915050565b60606103f5846001600160a01b03166014610f8d565b610409866001600160a01b03166014610f8d565b61041285611129565b61041b85611129565b60405160200161042e9493929190611fc0565b6040516020818303038152906040529050949350505050565b6097546001600160a01b031661045b6111bc565b6001600160a01b0316148061049757506104977f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a61030d6111bc565b156104b55780156104ad576104aa6111ea565b50565b6104aa611245565b6104bd6111bc565b60405162b0d32560e11b81526001600160a01b0390911660048201527f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a60248201526044015b60405180910390fd5b610514611280565b600082815260fc602052604080822080546001600160a01b0319166001600160a01b0385169081179091559051909184917f4ad49251ddae0b218995a7fd001ab79155bdbb25933c94a417e2d67103cfe3499190a35050565b600082815260656020526040902060010154610588816112f9565b610592838361130a565b505050565b61059f6111bc565b6001600160a01b0316816001600160a01b0316146106175760405162461bcd60e51b815260206004820152602f60248201527f416363657373436f6e74726f6c3a2063616e206f6e6c792072656e6f756e636560448201526e103937b632b9903337b91039b2b63360891b6064820152608401610503565b6106218282611391565b5050565b6001600160a01b038116600090815260fe602052604090206060906103d990611416565b60006103d97fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610d65565b600061068360c95460ff1690565b905090565b610690611280565b61069a6000611423565b565b600054610100900460ff16158080156106bc5750600054600160ff909116105b806106d65750303b1580156106d6575060005460ff166001145b6107395760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b6064820152608401610503565b6000805460ff19166001179055801561075c576000805461ff0019166101001790555b610764611475565b61076c61149c565b6107746114cb565b61078660006107816111bc565b6114fa565b6107b17f65d7a28e3265b37a6474929f336521b332c1681b933f6cb9f3376673440d862a6000611504565b6107dc7f2655a103c156cf5b3a7254f7196a0a309d0c771f90c6f1d6b33a609c14b9c65a6000611504565b6108077f8f4f2da22e8ac8f11e15f9fc141cddbb5deea8800186560abb6e68c5496619a96000611504565b6108327f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a66000611504565b61085d7f241ecf16d79d0f8dbfb92cbc07fe17840425976cf0667f022fe9877caa831b086000611504565b6108887f5a0afddc7ecb0deaa549d40e18566f1c87c8ed09187b6915eaf44079f37e2aca6000611504565b6108b37fdef43b3901ce74522c0564b6b61fb50e09ecc39765fd64702dad6f2446fc4b636000611504565b6108de7ff7b302cb700b7a54f3e005e07d62e8f53814068ec358c9a9e3f0423fa744c6a76000611504565b6109097fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536000611504565b6109116111ea565b80156104aa576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a150565b61096161154f565b826001600160a01b03166109736111bc565b6001600160a01b03161461099a576040516348f5c3ed60e01b815260040160405180910390fd5b6001600160a01b038416600090815260fb60205260409020546078906109c090426120e3565b10156109df57604051633026d65960e11b815260040160405180910390fd5b836001600160a01b0316836001600160a01b03161480610a0657506001600160a01b038316155b15610a245760405163eb32d3bf60e01b815260040160405180910390fd5b4282108015610a3257508115155b15610a5057604051631b437f1160e11b815260040160405180910390fd5b43811115610a7157604051631391e11b60e21b815260040160405180910390fd5b610a7c601e826120fa565b431115610a9c57604051636264a42360e11b815260040160405180910390fd5b6001600160a01b03808416600090815260fd602090815260409182902082518084019093528054909316808352600190930154908201529015801590610af85750846001600160a01b031681600001516001600160a01b031614155b15610b16576040516342ee68b560e01b815260040160405180910390fd5b6000610b24868686866103df565b90506000610b3182611597565b90506000610b75828b8b8080601f0160208091040260200160405190810160405280939291908181526020018383808284376000920191909152506115d292505050565b9050806001600160a01b0316886001600160a01b031614610bbc57604051639be21ff160e01b81526001600160a01b03808a16600483015282166024820152604401610503565b6040805180820182526001600160a01b038a811680835260208084018b81528c8416600090815260fd8352868120955186546001600160a01b031916951694909417855551600190940193909355815260fe90915220610c1c90886115f6565b506001600160a01b03888116600081815260fb60209081526040918290204290558151928352928a16928201929092529081018790527fdcb4af7d57cc106724f816a55242fbe9d45d800af6a574cb2814d7adf23e49409060600160405180910390a150505050505050505050565b60009182526065602090815260408084206001600160a01b0393909316845291905290205460ff1690565b60006001600160a01b038216610cdf5760405163eb32d3bf60e01b815260040160405180910390fd5b6001600160a01b03808316600090815260fd60209081526040918290208251808401909352805490931680835260019093015490820152908015610d5657428260200151108015610d335750602082015115155b15610d515760405163b2861d8f60e01b815260040160405180910390fd5b610d5e565b509192915050565b9392505050565b6000610d5e8383610c8b565b600082815260656020526040902060010154610d8c816112f9565b6105928383611391565b6001600160a01b03808216600090815260fd60205260409020541680610dcf576040516325ec6c1f60e01b815260040160405180910390fd5b610dd76111bc565b6001600160a01b0316826001600160a01b031614158015610e115750610dfb6111bc565b6001600160a01b0316816001600160a01b031614155b15610e2f5760405163361140f160e21b815260040160405180910390fd5b6001600160a01b03808316600090815260fd6020908152604080832080546001600160a01b0319168155600101839055928416825260fe9052908120610e75908461160b565b9050600181151514610e9a576040516325ec6c1f60e01b815260040160405180910390fd5b604080516001600160a01b038086168252841660208201527f31e0adfec71bccee37b6e83a90c2fedb17d8f1693fee863c4771e7bfe2aed580910160405180910390a1505050565b610eea611280565b6001600160a01b038116610f4f5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610503565b6104aa81611423565b60006001600160e01b03198216637965db0b60e01b14806103d957506301ffc9a760e01b6001600160e01b03198316146103d9565b60606000610f9c836002612112565b610fa79060026120fa565b67ffffffffffffffff811115610fbf57610fbf612131565b6040519080825280601f01601f191660200182016040528015610fe9576020820181803683370190505b509050600360fc1b8160008151811061100457611004612147565b60200101906001600160f81b031916908160001a905350600f60fb1b8160018151811061103357611033612147565b60200101906001600160f81b031916908160001a9053506000611057846002612112565b6110629060016120fa565b90505b60018111156110da576f181899199a1a9b1b9c1cb0b131b232b360811b85600f166010811061109657611096612147565b1a60f81b8282815181106110ac576110ac612147565b60200101906001600160f81b031916908160001a90535060049490941c936110d38161215d565b9050611065565b508315610d5e5760405162461bcd60e51b815260206004820181905260248201527f537472696e67733a20686578206c656e67746820696e73756666696369656e746044820152606401610503565b6060600061113683611620565b600101905060008167ffffffffffffffff81111561115657611156612131565b6040519080825280601f01601f191660200182016040528015611180576020820181803683370190505b5090508181016020015b600019016f181899199a1a9b1b9c1cb0b131b232b360811b600a86061a8153600a850494508461118a57509392505050565b6000601436108015906111d357506111d333610649565b156111e5575060131936013560601c90565b503390565b6111f261154f565b60c9805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a2586112286111bc565b6040516001600160a01b03909116815260200160405180910390a1565b61124d6116f8565b60c9805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa6112286111bc565b6112886111bc565b6001600160a01b03166112a36097546001600160a01b031690565b6001600160a01b03161461069a5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610503565b6104aa816113056111bc565b611743565b6113148282610c8b565b6106215760008281526065602090815260408083206001600160a01b03851684529091529020805460ff1916600117905561134d6111bc565b6001600160a01b0316816001600160a01b0316837f2f8788117e7eff1d82e926ec794901d17c78024a50270940304540a733656f0d60405160405180910390a45050565b61139b8282610c8b565b156106215760008281526065602090815260408083206001600160a01b03851684529091529020805460ff191690556113d26111bc565b6001600160a01b0316816001600160a01b0316837ff6391f5c32d9c69d2a47ea670b442974b53935d1edc7fd64eb21e047a839171b60405160405180910390a45050565b60606000610d5e8361179c565b609780546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600054610100900460ff1661069a5760405162461bcd60e51b815260040161050390612174565b600054610100900460ff166114c35760405162461bcd60e51b815260040161050390612174565b61069a6117f8565b600054610100900460ff166114f25760405162461bcd60e51b815260040161050390612174565b61069a61182f565b610621828261130a565b600082815260656020526040808220600101805490849055905190918391839186917fbd79b86ffe0ab8e8776151514217cd7cacd52c909f66475c3af44e129f0b00ff9190a4505050565b611557610675565b1561069a5760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b6044820152606401610503565b60006115a38251611129565b826040516020016115b59291906121bf565b604051602081830303815290604052805190602001209050919050565b60008060006115e18585611862565b915091506115ee816118a7565b509392505050565b6000610d5e836001600160a01b0384166119f1565b6000610d5e836001600160a01b038416611a40565b60008072184f03e93ff9f4daa797ed6e38ed64bf6a1f0160401b831061165f5772184f03e93ff9f4daa797ed6e38ed64bf6a1f0160401b830492506040015b6d04ee2d6d415b85acef8100000000831061168b576d04ee2d6d415b85acef8100000000830492506020015b662386f26fc1000083106116a957662386f26fc10000830492506010015b6305f5e10083106116c1576305f5e100830492506008015b61271083106116d557612710830492506004015b606483106116e7576064830492506002015b600a83106103d95760010192915050565b611700610675565b61069a5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610503565b61174d8282610c8b565b6106215761175a81611b33565b611765836020611b45565b60405160200161177692919061221a565b60408051601f198184030181529082905262461bcd60e51b825261050391600401611e3a565b6060816000018054806020026020016040519081016040528092919081815260200182805480156117ec57602002820191906000526020600020905b8154815260200190600101908083116117d8575b50505050509050919050565b600054610100900460ff1661181f5760405162461bcd60e51b815260040161050390612174565b61069a61182a6111bc565b611423565b600054610100900460ff166118565760405162461bcd60e51b815260040161050390612174565b60c9805460ff19169055565b60008082516041036118985760208301516040840151606085015160001a61188c87828585611c92565b945094505050506118a0565b506000905060025b9250929050565b60008160048111156118bb576118bb61228f565b036118c35750565b60018160048111156118d7576118d761228f565b036119245760405162461bcd60e51b815260206004820152601860248201527f45434453413a20696e76616c6964207369676e617475726500000000000000006044820152606401610503565b60028160048111156119385761193861228f565b036119855760405162461bcd60e51b815260206004820152601f60248201527f45434453413a20696e76616c6964207369676e6174757265206c656e677468006044820152606401610503565b60038160048111156119995761199961228f565b036104aa5760405162461bcd60e51b815260206004820152602260248201527f45434453413a20696e76616c6964207369676e6174757265202773272076616c604482015261756560f01b6064820152608401610503565b6000818152600183016020526040812054611a38575081546001818101845560008481526020808220909301849055845484825282860190935260409020919091556103d9565b5060006103d9565b60008181526001830160205260408120548015611b29576000611a646001836120e3565b8554909150600090611a78906001906120e3565b9050818114611add576000866000018281548110611a9857611a98612147565b9060005260206000200154905080876000018481548110611abb57611abb612147565b6000918252602080832090910192909255918252600188019052604090208390555b8554869080611aee57611aee6122a5565b6001900381819060005260206000200160009055905585600101600086815260200190815260200160002060009055600193505050506103d9565b60009150506103d9565b60606103d96001600160a01b03831660145b60606000611b54836002612112565b611b5f9060026120fa565b67ffffffffffffffff811115611b7757611b77612131565b6040519080825280601f01601f191660200182016040528015611ba1576020820181803683370190505b509050600360fc1b81600081518110611bbc57611bbc612147565b60200101906001600160f81b031916908160001a905350600f60fb1b81600181518110611beb57611beb612147565b60200101906001600160f81b031916908160001a9053506000611c0f846002612112565b611c1a9060016120fa565b90505b60018111156110da576f181899199a1a9b1b9c1cb0b131b232b360811b85600f1660108110611c4e57611c4e612147565b1a60f81b828281518110611c6457611c64612147565b60200101906001600160f81b031916908160001a90535060049490941c93611c8b8161215d565b9050611c1d565b6000807f7fffffffffffffffffffffffffffffff5d576e7357a4501ddfe92f46681b20a0831115611cc95750600090506003611d4d565b6040805160008082526020820180845289905260ff881692820192909252606081018690526080810185905260019060a0016020604051602081039080840390855afa158015611d1d573d6000803e3d6000fd5b5050604051601f1901519150506001600160a01b038116611d4657600060019250925050611d4d565b9150600090505b94509492505050565b600060208284031215611d6857600080fd5b81356001600160e01b031981168114610d5e57600080fd5b80356001600160a01b0381168114611d9757600080fd5b919050565b60008060008060808587031215611db257600080fd5b611dbb85611d80565b9350611dc960208601611d80565b93969395505050506040820135916060013590565b60005b83811015611df9578181015183820152602001611de1565b83811115611e08576000848401525b50505050565b60008151808452611e26816020860160208601611dde565b601f01601f19169290920160200192915050565b602081526000610d5e6020830184611e0e565b600060208284031215611e5f57600080fd5b81358015158114610d5e57600080fd5b600060208284031215611e8157600080fd5b5035919050565b60008060408385031215611e9b57600080fd5b82359150611eab60208401611d80565b90509250929050565b600060208284031215611ec657600080fd5b610d5e82611d80565b6020808252825182820181905260009190848201906040850190845b81811015611f105783516001600160a01b031683529284019291840191600101611eeb565b50909695505050505050565b60008060008060008060a08789031215611f3557600080fd5b863567ffffffffffffffff80821115611f4d57600080fd5b818901915089601f830112611f6157600080fd5b813581811115611f7057600080fd5b8a6020828501011115611f8257600080fd5b602092830198509650611f989189019050611d80565b9350611fa660408801611d80565b925060608701359150608087013590509295509295509295565b7f417574686f72697a65206f70657261746f72206163636f756e74200000000000815260008551611ff881601b850160208a01611dde565b7f20746f20706572666f726d2067616d65706c617920616374696f6e73206f6e20601b918401918201527f626568616c66206f6620706c61796572206163636f756e742000000000000000603b820152855161205b816054840160208a01611dde565b700103bb4ba341032bc3834b930ba34b7b71607d1b60549290910191820152845161208d816065840160208901611dde565b7001039b4b3b732b21030ba10313637b1b59607d1b6065929091019182015283516120bf816076840160208801611dde565b016076019695505050505050565b634e487b7160e01b600052601160045260246000fd5b6000828210156120f5576120f56120cd565b500390565b6000821982111561210d5761210d6120cd565b500190565b600081600019048311821515161561212c5761212c6120cd565b500290565b634e487b7160e01b600052604160045260246000fd5b634e487b7160e01b600052603260045260246000fd5b60008161216c5761216c6120cd565b506000190190565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b7f19457468657265756d205369676e6564204d6573736167653a0a0000000000008152600083516121f781601a850160208801611dde565b83519083019061220e81601a840160208801611dde565b01601a01949350505050565b7f416363657373436f6e74726f6c3a206163636f756e7420000000000000000000815260008351612252816017850160208801611dde565b7001034b99036b4b9b9b4b733903937b6329607d1b6017918401918201528351612283816028840160208801611dde565b01602801949350505050565b634e487b7160e01b600052602160045260246000fd5b634e487b7160e01b600052603160045260246000fdfea2646970667358221220251a076f8ba8ea791cbdfc95bf790f6cf3293f5ac09bc872847194a0d9e2cacd64736f6c634300080d0033";
        public GameregistryImplementationDeploymentBase() : base(BYTECODE) { }
        public GameregistryImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class DefaultAdminRoleFunction : DefaultAdminRoleFunctionBase { }

    [Function("DEFAULT_ADMIN_ROLE", "bytes32")]
    public class DefaultAdminRoleFunctionBase : FunctionMessage
    {

    }

    public partial class OperatorMessageBlockLimitFunction : OperatorMessageBlockLimitFunctionBase { }

    [Function("OPERATOR_MESSAGE_BLOCK_LIMIT", "uint256")]
    public class OperatorMessageBlockLimitFunctionBase : FunctionMessage
    {

    }

    public partial class RegisterOperatorCooldownLimitFunction : RegisterOperatorCooldownLimitFunctionBase { }

    [Function("REGISTER_OPERATOR_COOLDOWN_LIMIT", "uint256")]
    public class RegisterOperatorCooldownLimitFunctionBase : FunctionMessage
    {

    }

    public partial class DeregisterOperatorFunction : DeregisterOperatorFunctionBase { }

    [Function("deregisterOperator")]
    public class DeregisterOperatorFunctionBase : FunctionMessage
    {
        [Parameter("address", "operatorToDeregister", 1)]
        public virtual string OperatorToDeregister { get; set; }
    }

    public partial class GetOperatorAccountRegistrationMessageToSignFunction : GetOperatorAccountRegistrationMessageToSignFunctionBase { }

    [Function("getOperatorAccountRegistrationMessageToSign", "bytes")]
    public class GetOperatorAccountRegistrationMessageToSignFunctionBase : FunctionMessage
    {
        [Parameter("address", "player", 1)]
        public virtual string Player { get; set; }
        [Parameter("address", "operator", 2)]
        public virtual string Operator { get; set; }
        [Parameter("uint256", "expiration", 3)]
        public virtual BigInteger Expiration { get; set; }
        [Parameter("uint256", "blockNumber", 4)]
        public virtual BigInteger BlockNumber { get; set; }
    }

    public partial class GetPlayerAccountFunction : GetPlayerAccountFunctionBase { }

    [Function("getPlayerAccount", "address")]
    public class GetPlayerAccountFunctionBase : FunctionMessage
    {
        [Parameter("address", "operatorAddress", 1)]
        public virtual string OperatorAddress { get; set; }
    }

    public partial class GetRegisteredOperatorsFunction : GetRegisteredOperatorsFunctionBase { }

    [Function("getRegisteredOperators", "address[]")]
    public class GetRegisteredOperatorsFunctionBase : FunctionMessage
    {
        [Parameter("address", "player", 1)]
        public virtual string Player { get; set; }
    }

    public partial class GetRoleAdminFunction : GetRoleAdminFunctionBase { }

    [Function("getRoleAdmin", "bytes32")]
    public class GetRoleAdminFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
    }

    public partial class GetSystemFunction : GetSystemFunctionBase { }

    [Function("getSystem", "address")]
    public class GetSystemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "systemId", 1)]
        public virtual BigInteger SystemId { get; set; }
    }

    public partial class GrantRoleFunction : GrantRoleFunctionBase { }

    [Function("grantRole")]
    public class GrantRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class HasAccessRoleFunction : HasAccessRoleFunctionBase { }

    [Function("hasAccessRole", "bool")]
    public class HasAccessRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class HasRoleFunction : HasRoleFunctionBase { }

    [Function("hasRole", "bool")]
    public class HasRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {

    }

    public partial class IsTrustedForwarderFunction : IsTrustedForwarderFunctionBase { }

    [Function("isTrustedForwarder", "bool")]
    public class IsTrustedForwarderFunctionBase : FunctionMessage
    {
        [Parameter("address", "forwarder", 1)]
        public virtual string Forwarder { get; set; }
    }

    public partial class LastRegisterOperatorTimeFunction : LastRegisterOperatorTimeFunctionBase { }

    [Function("lastRegisterOperatorTime", "uint256")]
    public class LastRegisterOperatorTimeFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
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

    public partial class RegisterOperatorFunction : RegisterOperatorFunctionBase { }

    [Function("registerOperator")]
    public class RegisterOperatorFunctionBase : FunctionMessage
    {
        [Parameter("bytes", "signature", 1)]
        public virtual byte[] Signature { get; set; }
        [Parameter("address", "player", 2)]
        public virtual string Player { get; set; }
        [Parameter("address", "operator", 3)]
        public virtual string Operator { get; set; }
        [Parameter("uint256", "expiration", 4)]
        public virtual BigInteger Expiration { get; set; }
        [Parameter("uint256", "blockNumber", 5)]
        public virtual BigInteger BlockNumber { get; set; }
    }

    public partial class RegisterSystemFunction : RegisterSystemFunctionBase { }

    [Function("registerSystem")]
    public class RegisterSystemFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "systemId", 1)]
        public virtual BigInteger SystemId { get; set; }
        [Parameter("address", "systemAddress", 2)]
        public virtual string SystemAddress { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceRoleFunction : RenounceRoleFunctionBase { }

    [Function("renounceRole")]
    public class RenounceRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class RevokeRoleFunction : RevokeRoleFunctionBase { }

    [Function("revokeRole")]
    public class RevokeRoleFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "role", 1)]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2)]
        public virtual string Account { get; set; }
    }

    public partial class SetPausedFunction : SetPausedFunctionBase { }

    [Function("setPaused")]
    public class SetPausedFunctionBase : FunctionMessage
    {
        [Parameter("bool", "_paused", 1)]
        public virtual bool Paused { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
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

    public partial class OperatorDeregisteredEventDTO : OperatorDeregisteredEventDTOBase { }

    [Event("OperatorDeregistered")]
    public class OperatorDeregisteredEventDTOBase : IEventDTO
    {
        [Parameter("address", "operator", 1, false )]
        public virtual string Operator { get; set; }
        [Parameter("address", "player", 2, false )]
        public virtual string Player { get; set; }
    }

    public partial class OperatorRegisteredEventDTO : OperatorRegisteredEventDTOBase { }

    [Event("OperatorRegistered")]
    public class OperatorRegisteredEventDTOBase : IEventDTO
    {
        [Parameter("address", "player", 1, false )]
        public virtual string Player { get; set; }
        [Parameter("address", "operator", 2, false )]
        public virtual string Operator { get; set; }
        [Parameter("uint256", "expiration", 3, false )]
        public virtual BigInteger Expiration { get; set; }
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

    public partial class RoleAdminChangedEventDTO : RoleAdminChangedEventDTOBase { }

    [Event("RoleAdminChanged")]
    public class RoleAdminChangedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("bytes32", "previousAdminRole", 2, true )]
        public virtual byte[] PreviousAdminRole { get; set; }
        [Parameter("bytes32", "newAdminRole", 3, true )]
        public virtual byte[] NewAdminRole { get; set; }
    }

    public partial class RoleGrantedEventDTO : RoleGrantedEventDTOBase { }

    [Event("RoleGranted")]
    public class RoleGrantedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "sender", 3, true )]
        public virtual string Sender { get; set; }
    }

    public partial class RoleRevokedEventDTO : RoleRevokedEventDTOBase { }

    [Event("RoleRevoked")]
    public class RoleRevokedEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "role", 1, true )]
        public virtual byte[] Role { get; set; }
        [Parameter("address", "account", 2, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "sender", 3, true )]
        public virtual string Sender { get; set; }
    }

    public partial class SystemRegisteredEventDTO : SystemRegisteredEventDTOBase { }

    [Event("SystemRegistered")]
    public class SystemRegisteredEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "id", 1, true )]
        public virtual BigInteger Id { get; set; }
        [Parameter("address", "systemAddress", 2, true )]
        public virtual string SystemAddress { get; set; }
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







    public partial class PlayerSignerMismatchError : PlayerSignerMismatchErrorBase { }

    [Error("PlayerSignerMismatch")]
    public class PlayerSignerMismatchErrorBase : IErrorDTO
    {
        [Parameter("address", "expected", 1)]
        public virtual string Expected { get; set; }
        [Parameter("address", "actual", 2)]
        public virtual string Actual { get; set; }
    }



    public partial class DefaultAdminRoleOutputDTO : DefaultAdminRoleOutputDTOBase { }

    [FunctionOutput]
    public class DefaultAdminRoleOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class OperatorMessageBlockLimitOutputDTO : OperatorMessageBlockLimitOutputDTOBase { }

    [FunctionOutput]
    public class OperatorMessageBlockLimitOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class RegisterOperatorCooldownLimitOutputDTO : RegisterOperatorCooldownLimitOutputDTOBase { }

    [FunctionOutput]
    public class RegisterOperatorCooldownLimitOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class GetOperatorAccountRegistrationMessageToSignOutputDTO : GetOperatorAccountRegistrationMessageToSignOutputDTOBase { }

    [FunctionOutput]
    public class GetOperatorAccountRegistrationMessageToSignOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetPlayerAccountOutputDTO : GetPlayerAccountOutputDTOBase { }

    [FunctionOutput]
    public class GetPlayerAccountOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetRegisteredOperatorsOutputDTO : GetRegisteredOperatorsOutputDTOBase { }

    [FunctionOutput]
    public class GetRegisteredOperatorsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address[]", "", 1)]
        public virtual List<string> ReturnValue1 { get; set; }
    }

    public partial class GetRoleAdminOutputDTO : GetRoleAdminOutputDTOBase { }

    [FunctionOutput]
    public class GetRoleAdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetSystemOutputDTO : GetSystemOutputDTOBase { }

    [FunctionOutput]
    public class GetSystemOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class HasAccessRoleOutputDTO : HasAccessRoleOutputDTOBase { }

    [FunctionOutput]
    public class HasAccessRoleOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class HasRoleOutputDTO : HasRoleOutputDTOBase { }

    [FunctionOutput]
    public class HasRoleOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }



    public partial class IsTrustedForwarderOutputDTO : IsTrustedForwarderOutputDTOBase { }

    [FunctionOutput]
    public class IsTrustedForwarderOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class LastRegisterOperatorTimeOutputDTO : LastRegisterOperatorTimeOutputDTOBase { }

    [FunctionOutput]
    public class LastRegisterOperatorTimeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
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













    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }


}

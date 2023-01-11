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

namespace PirateNationContracts.LootSystem_Implementation.ContractDefinition
{


    public partial class LootsystemImplementationDeployment : LootsystemImplementationDeploymentBase
    {
        public LootsystemImplementationDeployment() : base(BYTECODE) { }
        public LootsystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class LootsystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50612bb9806100206000396000f3fe608060405234801561001057600080fd5b506004361061010b5760003560e01c8063715018a6116100a2578063c4d66de811610071578063c4d66de814610212578063dd898b2f14610225578063ed022ebd14610238578063ed8e5cbf1461024e578063f2fde38b1461026157600080fd5b8063715018a6146101bf5780637748f269146101c75780637f508db2146101da5780638da5cb5b146101ed57600080fd5b806339d3f5c7116100de57806339d3f5c714610180578063572b6c05146101935780635c975abb146101a65780635d1ca631146101ae57600080fd5b806301ffc9a71461011057806306c1cb911461013857806316c38b3c1461014d5780633058ccb214610160575b600080fd5b61012361011e3660046122bc565b610274565b60405190151581526020015b60405180910390f35b61014b61014636600461232d565b6102ab565b005b61014b61015b3660046123ed565b610420565b61017361016e36600461240a565b610441565b60405161012f919061249c565b61012361018e366004612613565b610737565b6101236101a136600461266a565b6107a9565b6101236107f0565b60985460405190815260200161012f565b61014b61087b565b61014b6101d5366004612687565b61088f565b61014b6101e8366004612721565b610aa5565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161012f565b61014b61022036600461266a565b610e4b565b61014b61023336600461266a565b610fbe565b60975461010090046001600160a01b03166101fa565b61014b61025c3660046127c5565b611009565b61014b61026f36600461266a565b6110ac565b60006001600160e01b0319821663a3155b1160e01b14806102a557506001600160e01b031982166301ffc9a760e01b145b92915050565b7f2655a103c156cf5b3a7254f7196a0a309d0c771f90c6f1d6b33a609c14b9c65a6102dd816102d8611122565b611150565b6000838152609a6020526040902080546001600160a01b0316600182018115610418576103eb8282805480602002602001604051908101604052809291908181526020016000905b828210156103c7576000848152602090206040805160808101909152600384029091018054829060ff16600481111561036057610360612423565b600481111561037157610371612423565b81526020016000820160019054906101000a90046001600160a01b03166001600160a01b03166001600160a01b031681526020016001820154815260200160028201548152505081526020019060010190610325565b50505050876000815181106103de576103de612821565b60200260200101516111f9565b6000868152609a6020526040812080546001600160a01b0319168155906104156001830182612100565b50505b505050505050565b610428611305565b80156104395761043661137e565b50565b61043661141b565b6104736040518060a0016040528060608152602001606081526020016060815260200160608152602001600081525090565b60008281526099602090815260408083208151815460c09481028201850190935260a08101838152909491938593919285929185015b8282101561059257838290600052602060002001805480602002602001604051908101604052809291908181526020016000905b8282101561057f576000848152602090206040805160808101909152600384029091018054829060ff16600481111561051857610518612423565b600481111561052957610529612423565b81526020016000820160019054906101000a90046001600160a01b03166001600160a01b03166001600160a01b0316815260200160018201548152602001600282015481525050815260200190600101906104dd565b50505050815260200190600101906104a9565b5050505081526020016001820180548060200260200160405190810160405280929190818152602001828054801561061557602002820191906000526020600020906000905b82829054906101000a900463ffffffff1663ffffffff16815260200190600401906020826003010492830192600103820291508084116105d85790505b505050505081526020016002820180548060200260200160405190810160405280929190818152602001828054801561069957602002820191906000526020600020906000905b82829054906101000a900463ffffffff1663ffffffff168152602001906004019060208260030104928301926001038202915080841161065c5790505b505050505081526020016003820180548060200260200160405190810160405280929190818152602001828054801561071d57602002820191906000526020600020906000905b82829054906101000a900463ffffffff1663ffffffff16815260200190600401906020826003010492830192600103820291508084116106e05790505b505050505081526020016004820154815250509050919050565b6000805b61ffff81168311156107a257600084848361ffff1681811061075f5761075f612821565b9050608002018036038101906107759190612844565b905060006107828261149c565b9050838061078d5750805b935050508061079b906128cf565b905061073b565b5092915050565b60975460009061010090046001600160a01b0316158015906102a557506102a57fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283611663565b60975460009060ff16806108765750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610852573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061087691906128f0565b905090565b610883611305565b61088d60006116e5565b565b610897611737565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536108c4816102d8611122565b6000805b60ff811684111561092f57600485858360ff168181106108ea576108ea612821565b610900926020608090920201908101915061290d565b600481111561091157610911612423565b0361091f576001915061092f565b6109288161292a565b90506108c8565b508015610a365760006109426001611790565b6000818152609a6020526040812080546001600160a01b0319166001600160a01b038a161781559192505b60ff8116861115610a2e578160010187878360ff1681811061099157610991612821565b8354600181018555600094855260209094206080909102929092019260030290910190506109bf8282612949565b5050610a1e888888808060200260200160405190810160405280939291908181526020016000905b82821015610a1357610a0460808302860136819003810190612844565b815260200190600101906109e7565b5050505050856111f9565b610a278161292a565b905061096d565b505050610a94565b610a94858585808060200260200160405190810160405280939291908181526020016000905b82821015610a8857610a7960808302860136819003810190612844565b81526020019060010190610a5c565b505050505060006111f9565b5050610aa06001606555565b505050565b7f241ecf16d79d0f8dbfb92cbc07fe17840425976cf0667f022fe9877caa831b08610ad2816102d8611122565b8584141580610ae15750858214155b15610aff5760405163c52a5cdd60e01b815260040160405180910390fd5b61ffff861115610b2257604051632c6560f760e21b815260040160405180910390fd5b600088815260996020526040812090610b3c908290612121565b6000805b61ffff8116891115610d865760008a8a8361ffff16818110610b6457610b64612821565b9050602002810190610b7691906129cc565b808060200260200160405190810160405280939291908181526020016000905b82821015610bc257610bb360808302860136819003810190612844565b81526020019060010190610b96565b50508754600101808955600089815294955088935061ffff8716925082109050610bee57610bee612821565b90600052602060002001905060005b82518161ffff161015610d35576004838261ffff1681518110610c2257610c22612821565b6020026020010151600001516004811115610c3f57610c3f612423565b03610c5d5760405163e6d972d960e01b815260040160405180910390fd5b610c83838261ffff1681518110610c7657610c76612821565b602002602001015161149c565b5081838261ffff1681518110610c9b57610c9b612821565b60209081029190910181015182546001818101855560009485529290932081516003909402018054919390929091839160ff1990911690836004811115610ce457610ce4612423565b0217905550602082015181546001600160a01b0390911661010002610100600160a81b031990911617815560408201516001820155606090910151600290910155610d2e816128cf565b9050610bfd565b5089898461ffff16818110610d4c57610d4c612821565b9050602002016020810190610d619190612a16565b610d719063ffffffff1685612a3c565b9350505080610d7f906128cf565b9050610b40565b5060048201819055610d9c60018301888861213f565b50610dab60028301868661213f565b506003820154600003610e1457815467ffffffffffffffff811115610dd257610dd26122e6565b604051908082528060200260200182016040528015610dfb578160200160208202803683370190505b508051610e129160038501916020909101906121f0565b505b6040518a907f1537e567df9ed7ceddca570794ab08b8b2bf7f034793ff53bb7cba2a0f1cb0e990600090a250505050505050505050565b600054610100900460ff1615808015610e6b5750600054600160ff909116105b80610e855750303b158015610e85575060005460ff166001145b610eed5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610f10576000805461ff0019166101001790555b610f3a827fb70091829c991f37878ffa710da8e35fe9b352fb6a91589a70d340c2f17aeea4611819565b60408051608081018252600080825260208201819052918101829052606001819052609b80546001600160a81b0319169055609c819055609d558015610fba576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15b5050565b610fc6611305565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556104365760405163a4b9148160e01b815260040160405180910390fd5b611011611737565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb5361103e816102d8611122565b61109b858585808060200260200160405190810160405280939291908181526020016000905b828210156110905761108160808302860136819003810190612844565b81526020019060010190611064565b5050505050846111f9565b506110a66001606555565b50505050565b6110b4611305565b6001600160a01b0381166111195760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610ee4565b610436816116e5565b6000601436108015906111395750611139336107a9565b1561114b575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa1580156111a7573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906111cb91906128f0565b610fba5760405162b0d32560e11b81526001600160a01b038216600482015260248101839052604401610ee4565b60005b82518160ff1610156110a6576000838260ff168151811061121f5761121f612821565b6020026020010151905060048081111561123b5761123b612423565b8151600481111561124e5761124e612423565b036112ea578260000361127357604051622b0e1f60ea1b815260040160405180910390fd5b604080820151600090815260996020522061128d846118a6565b9350600061129b82866118ea565b905060005b81518160ff1610156112e2576112d288838360ff16815181106112c5576112c5612821565b6020026020010151611cbd565b6112db8161292a565b90506112a0565b5050506112f4565b6112f48582611cbd565b506112fe8161292a565b90506111fc565b61130d611122565b6001600160a01b03166113286033546001600160a01b031690565b6001600160a01b03161461088d5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610ee4565b60975460ff16156113c85760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610ee4565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a2586113fe611122565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146114695760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610ee4565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa6113fe611122565b600081606001516000036114c3576040516319018bd560e21b815260040160405180910390fd5b6001825160048111156114d8576114d8612423565b036115165760208201516001600160a01b031661151157815160208301516040516325e88e0360e11b8152610ee4929190600401612a54565b919050565b60028251600481111561152b5761152b612423565b036115645760208201516001600160a01b031661151157815160208301516040516325e88e0360e11b8152610ee4929190600401612a54565b60038251600481111561157957611579612423565b036115b25760208201516001600160a01b031661151157815160208301516040516325e88e0360e11b8152610ee4929190600401612a54565b6004825160048111156115c7576115c7612423565b036116475760208201516001600160a01b03161561160157815160208301516040516325e88e0360e11b8152610ee4929190600401612a54565b60408083015160009081526099602052908120805490910361163e578260400151604051631450eb4760e01b8152600401610ee491815260200190565b50600192915050565b815160405163e5eeccfb60e01b8152610ee49190600401612a7a565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa1580156116ba573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906116de91906128f0565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6002606554036117895760405162461bcd60e51b815260206004820152601f60248201527f5265656e7472616e637947756172643a207265656e7472616e742063616c6c006044820152606401610ee4565b6002606555565b600061179a611e69565b6040516337e5fda760e21b815230600482015263ffffffff841660248201526001600160a01b03919091169063df97f69c906044016020604051808303816000875af11580156117ee573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102a59190612a88565b6001606555565b600054610100900460ff166118405760405162461bcd60e51b8152600401610ee490612aa1565b611848611efb565b611850611f2a565b60978054610100600160a81b0319166101006001600160a01b038516908102919091179091556118935760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600044425a60408051602081019490945283019190915260608201526080810183905260a00160408051601f19818403018152919052805160209091012092915050565b60608260040154600003611900575060606102a5565b60008360040154836119129190612aec565b90506000805b855461ffff82161015611bc257856001018161ffff168154811061193e5761193e612821565b6000918252602090912060088204015461196a916007166004026101000a900463ffffffff1683612a3c565b915081831015611bb257856003018161ffff168154811061198d5761198d612821565b906000526020600020906008918282040191900660040281819054906101000a900463ffffffff16809291906119c290612b0e565b91906101000a81548163ffffffff021916908363ffffffff16021790555050856002018161ffff16815481106119fa576119fa612821565b90600052602060002090600891828204019190066004029054906101000a900463ffffffff1663ffffffff16866003018261ffff1681548110611a3f57611a3f612821565b6000918252602090912060088204015460079091166004026101000a900463ffffffff1603611abf576000866001018261ffff1681548110611a8357611a83612821565b90600052602060002090600891828204019190066004026101000a81548163ffffffff021916908363ffffffff160217905550611abf86611f59565b856000018161ffff1681548110611ad857611ad8612821565b90600052602060002001805480602002602001604051908101604052809291908181526020016000905b82821015611ba4576000848152602090206040805160808101909152600384029091018054829060ff166004811115611b3d57611b3d612423565b6004811115611b4e57611b4e612423565b81526020016000820160019054906101000a90046001600160a01b03166001600160a01b03166001600160a01b031681526020016001820154815260200160028201548152505081526020019060010190611b02565b5050505093505050506102a5565b611bbb816128cf565b9050611918565b5084548590611bd390600190612b27565b81548110611be357611be3612821565b90600052602060002001805480602002602001604051908101604052809291908181526020016000905b82821015611caf576000848152602090206040805160808101909152600384029091018054829060ff166004811115611c4857611c48612423565b6004811115611c5957611c59612423565b81526020016000820160019054906101000a90046001600160a01b03166001600160a01b03166001600160a01b031681526020016001820154815260200160028201548152505081526020019060010190611c0d565b505050509250505092915050565b600181516004811115611cd257611cd2612423565b03611d4157602081015160608201516040516340c10f1960e01b81526001600160a01b03858116600483015260248201929092529116906340c10f19906044015b600060405180830381600087803b158015611d2d57600080fd5b505af1158015610418573d6000803e3d6000fd5b600381516004811115611d5657611d56612423565b03611dc05780602001516001600160a01b031663156e29f683611d7c8460400151611fd8565b60608501516040516001600160e01b031960e086901b1681526001600160a01b03909316600484015263ffffffff9190911660248301526044820152606401611d13565b600281516004811115611dd557611dd5612423565b03611e2f5780602001516001600160a01b031663c68295a483611dfb8460600151612041565b6040516001600160e01b031960e085901b1681526001600160a01b03909216600483015260ff166024820152604401611d13565b600081516004811115611e4457611e44612423565b03611e4d575050565b805160405163e5eeccfb60e01b8152610ee49190600401612a7a565b6097546040516329f20e0f60e11b81527f61a08aff0763da990caa98ab17070d5b543908be98734b1d6fc5b759bb4d3ba7600482015260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015611ed7573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906108769190612b3e565b600054610100900460ff16611f225760405162461bcd60e51b8152600401610ee490612aa1565b61088d6120a2565b600054610100900460ff16611f515760405162461bcd60e51b8152600401610ee490612aa1565b61088d6120d9565b6000805b600183015461ffff82161015611fc957826001018161ffff1681548110611f8657611f86612821565b90600052602060002090600891828204019190066004029054906101000a900463ffffffff1682611fb79190612b5b565b9150611fc2816128cf565b9050611f5d565b5063ffffffff16600490910155565b600063ffffffff82111561203d5760405162461bcd60e51b815260206004820152602660248201527f53616665436173743a2076616c756520646f65736e27742066697420696e203360448201526532206269747360d01b6064820152608401610ee4565b5090565b600060ff82111561203d5760405162461bcd60e51b815260206004820152602560248201527f53616665436173743a2076616c756520646f65736e27742066697420696e2038604482015264206269747360d81b6064820152608401610ee4565b600054610100900460ff166120c95760405162461bcd60e51b8152600401610ee490612aa1565b61088d6120d4611122565b6116e5565b600054610100900460ff166118125760405162461bcd60e51b8152600401610ee490612aa1565b5080546000825560030290600052602060002090810190610436919061225d565b5080546000825590600052602060002090810190610436919061228a565b828054828255906000526020600020906007016008900481019282156121e45791602002820160005b838211156121b257833563ffffffff1683826101000a81548163ffffffff021916908363ffffffff1602179055509260200192600401602081600301049283019260010302612168565b80156121e25782816101000a81549063ffffffff02191690556004016020816003010492830192600103026121b2565b505b5061203d9291506122a7565b828054828255906000526020600020906007016008900481019282156121e45791602002820160005b838211156121b257835183826101000a81548163ffffffff021916908363ffffffff1602179055509260200192600401602081600301049283019260010302612219565b5b8082111561203d5780546001600160a81b0319168155600060018201819055600282015560030161225e565b8082111561203d57600061229e8282612100565b5060010161228a565b5b8082111561203d57600081556001016122a8565b6000602082840312156122ce57600080fd5b81356001600160e01b0319811681146116de57600080fd5b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff81118282101715612325576123256122e6565b604052919050565b6000806040838503121561234057600080fd5b8235915060208084013567ffffffffffffffff8082111561236057600080fd5b818601915086601f83011261237457600080fd5b813581811115612386576123866122e6565b8060051b91506123978483016122fc565b81815291830184019184810190898411156123b157600080fd5b938501935b838510156123cf578435825293850193908501906123b6565b8096505050505050509250929050565b801515811461043657600080fd5b6000602082840312156123ff57600080fd5b81356116de816123df565b60006020828403121561241c57600080fd5b5035919050565b634e487b7160e01b600052602160045260246000fd5b6005811061245757634e487b7160e01b600052602160045260246000fd5b9052565b600081518084526020808501945080840160005b8381101561249157815163ffffffff168752958201959082019060010161246f565b509495945050505050565b6000602080835260c08301845160a08386015281815180845260e08701915060e08160051b880101935084830192506000805b828110156125535788860360df19018452845180518088529088019088880190845b8181101561253d578351612506848251612439565b808c01516001600160a01b0316848d01526040808201519085015260609081015190840152928a01926080909201916001016124f1565b50909750505093860193928601926001016124cf565b5050505050818501519150601f1980858303016040860152612575828461245b565b92506040860151915080858403016060860152612592838361245b565b92506060860151915080858403016080860152506125b0828261245b565b915050608084015160a08401528091505092915050565b60008083601f8401126125d957600080fd5b50813567ffffffffffffffff8111156125f157600080fd5b6020830191508360208260071b850101111561260c57600080fd5b9250929050565b6000806020838503121561262657600080fd5b823567ffffffffffffffff81111561263d57600080fd5b612649858286016125c7565b90969095509350505050565b6001600160a01b038116811461043657600080fd5b60006020828403121561267c57600080fd5b81356116de81612655565b60008060006040848603121561269c57600080fd5b83356126a781612655565b9250602084013567ffffffffffffffff8111156126c357600080fd5b6126cf868287016125c7565b9497909650939450505050565b60008083601f8401126126ee57600080fd5b50813567ffffffffffffffff81111561270657600080fd5b6020830191508360208260051b850101111561260c57600080fd5b60008060008060008060006080888a03121561273c57600080fd5b87359650602088013567ffffffffffffffff8082111561275b57600080fd5b6127678b838c016126dc565b909850965060408a013591508082111561278057600080fd5b61278c8b838c016126dc565b909650945060608a01359150808211156127a557600080fd5b506127b28a828b016126dc565b989b979a50959850939692959293505050565b600080600080606085870312156127db57600080fd5b84356127e681612655565b9350602085013567ffffffffffffffff81111561280257600080fd5b61280e878288016125c7565b9598909750949560400135949350505050565b634e487b7160e01b600052603260045260246000fd5b6005811061043657600080fd5b60006080828403121561285657600080fd5b6040516080810181811067ffffffffffffffff82111715612879576128796122e6565b604052823561288781612837565b8152602083013561289781612655565b6020820152604083810135908201526060928301359281019290925250919050565b634e487b7160e01b600052601160045260246000fd5b600061ffff8083168181036128e6576128e66128b9565b6001019392505050565b60006020828403121561290257600080fd5b81516116de816123df565b60006020828403121561291f57600080fd5b81356116de81612837565b600060ff821660ff8103612940576129406128b9565b60010192915050565b813561295481612837565b6005811061297257634e487b7160e01b600052602160045260246000fd5b815460ff821691508160ff198216178355602084013561299181612655565b6001600160a81b03199190911690911760089190911b610100600160a81b031617815560408201356001820155606090910135600290910155565b6000808335601e198436030181126129e357600080fd5b83018035915067ffffffffffffffff8211156129fe57600080fd5b6020019150600781901b360382131561260c57600080fd5b600060208284031215612a2857600080fd5b813563ffffffff811681146116de57600080fd5b60008219821115612a4f57612a4f6128b9565b500190565b60408101612a628285612439565b6001600160a01b039290921660209190910152919050565b602081016102a58284612439565b600060208284031215612a9a57600080fd5b5051919050565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b600082612b0957634e487b7160e01b600052601260045260246000fd5b500690565b600063ffffffff8083168181036128e6576128e66128b9565b600082821015612b3957612b396128b9565b500390565b600060208284031215612b5057600080fd5b81516116de81612655565b600063ffffffff808316818516808303821115612b7a57612b7a6128b9565b0194935050505056fea264697066735822122047ce4022305017b87b3c2e6cedf7be8c4f68b789ad01300660dc03955d4d03e064736f6c634300080d0033";
        public LootsystemImplementationDeploymentBase() : base(BYTECODE) { }
        public LootsystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class GetLootTableFunction : GetLootTableFunctionBase { }

    [Function("getLootTable", typeof(GetLootTableOutputDTO))]
    public class GetLootTableFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "lootTableId", 1)]
        public virtual BigInteger LootTableId { get; set; }
    }

    public partial class GrantLootFunction : GrantLootFunctionBase { }

    [Function("grantLoot")]
    public class GrantLootFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("tuple[]", "loots", 2)]
        public virtual List<Loot> Loots { get; set; }
    }

    public partial class GrantLootWithRandomWordFunction : GrantLootWithRandomWordFunctionBase { }

    [Function("grantLootWithRandomWord")]
    public class GrantLootWithRandomWordFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("tuple[]", "loots", 2)]
        public virtual List<Loot> Loots { get; set; }
        [Parameter("uint256", "randomWord", 3)]
        public virtual BigInteger RandomWord { get; set; }
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

    public partial class SetLootTableFunction : SetLootTableFunctionBase { }

    [Function("setLootTable")]
    public class SetLootTableFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "lootTableId", 1)]
        public virtual BigInteger LootTableId { get; set; }
        [Parameter("tuple[][]", "loots", 2)]
        public virtual List<List<Loot>> Loots { get; set; }
        [Parameter("uint32[]", "weights", 3)]
        public virtual List<uint> Weights { get; set; }
        [Parameter("uint32[]", "maxSupply", 4)]
        public virtual List<uint> MaxSupply { get; set; }
    }

    public partial class SetPausedFunction : SetPausedFunctionBase { }

    [Function("setPaused")]
    public class SetPausedFunctionBase : FunctionMessage
    {
        [Parameter("bool", "shouldPause", 1)]
        public virtual bool ShouldPause { get; set; }
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

    public partial class ValidateLootsFunction : ValidateLootsFunctionBase { }

    [Function("validateLoots", "bool")]
    public class ValidateLootsFunctionBase : FunctionMessage
    {
        [Parameter("tuple[]", "loots", 1)]
        public virtual List<Loot> Loots { get; set; }
    }

    public partial class InitializedEventDTO : InitializedEventDTOBase { }

    [Event("Initialized")]
    public class InitializedEventDTOBase : IEventDTO
    {
        [Parameter("uint8", "version", 1, false )]
        public virtual byte Version { get; set; }
    }

    public partial class LootTableUpdatedEventDTO : LootTableUpdatedEventDTOBase { }

    [Event("LootTableUpdated")]
    public class LootTableUpdatedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "lootTableId", 1, true )]
        public virtual BigInteger LootTableId { get; set; }
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

    public partial class InvalidContractAddressError : InvalidContractAddressErrorBase { }

    [Error("InvalidContractAddress")]
    public class InvalidContractAddressErrorBase : IErrorDTO
    {
        [Parameter("uint8", "lootType", 1)]
        public virtual byte LootType { get; set; }
        [Parameter("address", "contractAddress", 2)]
        public virtual string ContractAddress { get; set; }
    }





    public partial class InvalidLootTypeError : InvalidLootTypeErrorBase { }

    [Error("InvalidLootType")]
    public class InvalidLootTypeErrorBase : IErrorDTO
    {
        [Parameter("uint8", "lootType", 1)]
        public virtual byte LootType { get; set; }
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

    public partial class NoLootsForLootTableError : NoLootsForLootTableErrorBase { }

    [Error("NoLootsForLootTable")]
    public class NoLootsForLootTableErrorBase : IErrorDTO
    {
        [Parameter("uint256", "lootTableId", 1)]
        public virtual BigInteger LootTableId { get; set; }
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

    public partial class GetLootTableOutputDTO : GetLootTableOutputDTOBase { }

    [FunctionOutput]
    public class GetLootTableOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual LootTable ReturnValue1 { get; set; }
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









    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }



    public partial class ValidateLootsOutputDTO : ValidateLootsOutputDTOBase { }

    [FunctionOutput]
    public class ValidateLootsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "needsVRF", 1)]
        public virtual bool NeedsVRF { get; set; }
    }
}
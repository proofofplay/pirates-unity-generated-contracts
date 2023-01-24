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
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50612c70806100206000396000f3fe608060405234801561001057600080fd5b506004361061010b5760003560e01c8063715018a6116100a2578063c4d66de811610071578063c4d66de814610212578063dd898b2f14610225578063ed022ebd14610238578063ed8e5cbf1461024e578063f2fde38b1461026157600080fd5b8063715018a6146101bf5780637748f269146101c75780637f508db2146101da5780638da5cb5b146101ed57600080fd5b806339d3f5c7116100de57806339d3f5c714610180578063572b6c05146101935780635c975abb146101a65780635d1ca631146101ae57600080fd5b806301ffc9a71461011057806306c1cb911461013857806316c38b3c1461014d5780633058ccb214610160575b600080fd5b61012361011e366004612373565b610274565b60405190151581526020015b60405180910390f35b61014b6101463660046123e4565b6102ab565b005b61014b61015b3660046124a4565b610420565b61017361016e3660046124c1565b610441565b60405161012f9190612553565b61012361018e3660046126ca565b610737565b6101236101a1366004612721565b6107a9565b6101236107f0565b60985460405190815260200161012f565b61014b61087b565b61014b6101d536600461273e565b61088f565b61014b6101e83660046127d8565b610aa5565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161012f565b61014b610220366004612721565b610e4b565b61014b610233366004612721565b610fbe565b60975461010090046001600160a01b03166101fa565b61014b61025c36600461287c565b611009565b61014b61026f366004612721565b6110ac565b60006001600160e01b0319821663a3155b1160e01b14806102a557506001600160e01b031982166301ffc9a760e01b145b92915050565b7f2655a103c156cf5b3a7254f7196a0a309d0c771f90c6f1d6b33a609c14b9c65a6102dd816102d8611122565b611150565b6000838152609a6020526040902080546001600160a01b0316600182018115610418576103eb8282805480602002602001604051908101604052809291908181526020016000905b828210156103c7576000848152602090206040805160808101909152600384029091018054829060ff166005811115610360576103606124da565b6005811115610371576103716124da565b81526020016000820160019054906101000a90046001600160a01b03166001600160a01b03166001600160a01b031681526020016001820154815260200160028201548152505081526020019060010190610325565b50505050876000815181106103de576103de6128d8565b60200260200101516111f9565b6000868152609a6020526040812080546001600160a01b03191681559061041560018301826121b7565b50505b505050505050565b610428611306565b80156104395761043661137f565b50565b61043661141c565b6104736040518060a0016040528060608152602001606081526020016060815260200160608152602001600081525090565b60008281526099602090815260408083208151815460c09481028201850190935260a08101838152909491938593919285929185015b8282101561059257838290600052602060002001805480602002602001604051908101604052809291908181526020016000905b8282101561057f576000848152602090206040805160808101909152600384029091018054829060ff166005811115610518576105186124da565b6005811115610529576105296124da565b81526020016000820160019054906101000a90046001600160a01b03166001600160a01b03166001600160a01b0316815260200160018201548152602001600282015481525050815260200190600101906104dd565b50505050815260200190600101906104a9565b5050505081526020016001820180548060200260200160405190810160405280929190818152602001828054801561061557602002820191906000526020600020906000905b82829054906101000a900463ffffffff1663ffffffff16815260200190600401906020826003010492830192600103820291508084116105d85790505b505050505081526020016002820180548060200260200160405190810160405280929190818152602001828054801561069957602002820191906000526020600020906000905b82829054906101000a900463ffffffff1663ffffffff168152602001906004019060208260030104928301926001038202915080841161065c5790505b505050505081526020016003820180548060200260200160405190810160405280929190818152602001828054801561071d57602002820191906000526020600020906000905b82829054906101000a900463ffffffff1663ffffffff16815260200190600401906020826003010492830192600103820291508084116106e05790505b505050505081526020016004820154815250509050919050565b6000805b61ffff81168311156107a257600084848361ffff1681811061075f5761075f6128d8565b90506080020180360381019061077591906128fb565b905060006107828261149d565b9050838061078d5750805b935050508061079b90612986565b905061073b565b5092915050565b60975460009061010090046001600160a01b0316158015906102a557506102a57fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d2836116b2565b60975460009060ff16806108765750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610852573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061087691906129a7565b905090565b610883611306565b61088d6000611734565b565b610897611786565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536108c4816102d8611122565b6000805b60ff811684111561092f57600485858360ff168181106108ea576108ea6128d8565b61090092602060809092020190810191506129c4565b6005811115610911576109116124da565b0361091f576001915061092f565b610928816129e1565b90506108c8565b508015610a3657600061094260016117df565b6000818152609a6020526040812080546001600160a01b0319166001600160a01b038a161781559192505b60ff8116861115610a2e578160010187878360ff16818110610991576109916128d8565b8354600181018555600094855260209094206080909102929092019260030290910190506109bf8282612a00565b5050610a1e888888808060200260200160405190810160405280939291908181526020016000905b82821015610a1357610a04608083028601368190038101906128fb565b815260200190600101906109e7565b5050505050856111f9565b610a27816129e1565b905061096d565b505050610a94565b610a94858585808060200260200160405190810160405280939291908181526020016000905b82821015610a8857610a79608083028601368190038101906128fb565b81526020019060010190610a5c565b505050505060006111f9565b5050610aa06001606555565b505050565b7f241ecf16d79d0f8dbfb92cbc07fe17840425976cf0667f022fe9877caa831b08610ad2816102d8611122565b8584141580610ae15750858214155b15610aff5760405163c52a5cdd60e01b815260040160405180910390fd5b61ffff861115610b2257604051632c6560f760e21b815260040160405180910390fd5b600088815260996020526040812090610b3c9082906121d8565b6000805b61ffff8116891115610d865760008a8a8361ffff16818110610b6457610b646128d8565b9050602002810190610b769190612a83565b808060200260200160405190810160405280939291908181526020016000905b82821015610bc257610bb3608083028601368190038101906128fb565b81526020019060010190610b96565b50508754600101808955600089815294955088935061ffff8716925082109050610bee57610bee6128d8565b90600052602060002001905060005b82518161ffff161015610d35576004838261ffff1681518110610c2257610c226128d8565b6020026020010151600001516005811115610c3f57610c3f6124da565b03610c5d5760405163e6d972d960e01b815260040160405180910390fd5b610c83838261ffff1681518110610c7657610c766128d8565b602002602001015161149d565b5081838261ffff1681518110610c9b57610c9b6128d8565b60209081029190910181015182546001818101855560009485529290932081516003909402018054919390929091839160ff1990911690836005811115610ce457610ce46124da565b0217905550602082015181546001600160a01b0390911661010002610100600160a81b031990911617815560408201516001820155606090910151600290910155610d2e81612986565b9050610bfd565b5089898461ffff16818110610d4c57610d4c6128d8565b9050602002016020810190610d619190612acd565b610d719063ffffffff1685612af3565b9350505080610d7f90612986565b9050610b40565b5060048201819055610d9c6001830188886121f6565b50610dab6002830186866121f6565b506003820154600003610e1457815467ffffffffffffffff811115610dd257610dd261239d565b604051908082528060200260200182016040528015610dfb578160200160208202803683370190505b508051610e129160038501916020909101906122a7565b505b6040518a907f1537e567df9ed7ceddca570794ab08b8b2bf7f034793ff53bb7cba2a0f1cb0e990600090a250505050505050505050565b600054610100900460ff1615808015610e6b5750600054600160ff909116105b80610e855750303b158015610e85575060005460ff166001145b610eed5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610f10576000805461ff0019166101001790555b610f3a827fb70091829c991f37878ffa710da8e35fe9b352fb6a91589a70d340c2f17aeea4611868565b60408051608081018252600080825260208201819052918101829052606001819052609b80546001600160a81b0319169055609c819055609d558015610fba576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15b5050565b610fc6611306565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556104365760405163a4b9148160e01b815260040160405180910390fd5b611011611786565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb5361103e816102d8611122565b61109b858585808060200260200160405190810160405280939291908181526020016000905b8282101561109057611081608083028601368190038101906128fb565b81526020019060010190611064565b5050505050846111f9565b506110a66001606555565b50505050565b6110b4611306565b6001600160a01b0381166111195760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610ee4565b61043681611734565b6000601436108015906111395750611139336107a9565b1561114b575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa1580156111a7573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906111cb91906129a7565b610fba5760405162b0d32560e11b81526001600160a01b038216600482015260248101839052604401610ee4565b60005b82518160ff1610156110a6576000838260ff168151811061121f5761121f6128d8565b602002602001015190506004600581111561123c5761123c6124da565b8151600581111561124f5761124f6124da565b036112eb578260000361127457604051622b0e1f60ea1b815260040160405180910390fd5b604080820151600090815260996020522061128e846118f5565b9350600061129c8286611939565b905060005b81518160ff1610156112e3576112d388838360ff16815181106112c6576112c66128d8565b6020026020010151611d0c565b6112dc816129e1565b90506112a1565b5050506112f5565b6112f58582611d0c565b506112ff816129e1565b90506111fc565b61130e611122565b6001600160a01b03166113296033546001600160a01b031690565b6001600160a01b03161461088d5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610ee4565b60975460ff16156113c95760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610ee4565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a2586113ff611122565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff16151560011461146a5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610ee4565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa6113ff611122565b600081606001516000036114c4576040516319018bd560e21b815260040160405180910390fd5b6001825160058111156114d9576114d96124da565b036115175760208201516001600160a01b031661151257815160208301516040516325e88e0360e11b8152610ee4929190600401612b0b565b919050565b60028251600581111561152c5761152c6124da565b036115655760208201516001600160a01b031661151257815160208301516040516325e88e0360e11b8152610ee4929190600401612b0b565b60038251600581111561157a5761157a6124da565b036115b35760208201516001600160a01b031661151257815160208301516040516325e88e0360e11b8152610ee4929190600401612b0b565b6004825160058111156115c8576115c86124da565b036116485760208201516001600160a01b03161561160257815160208301516040516325e88e0360e11b8152610ee4929190600401612b0b565b60408083015160009081526099602052908120805490910361163f578260400151604051631450eb4760e01b8152600401610ee491815260200190565b50600192915050565b60058251600581111561165d5761165d6124da565b036116965760208201516001600160a01b031661151257815160208301516040516325e88e0360e11b8152610ee4929190600401612b0b565b815160405163e5eeccfb60e01b8152610ee49190600401612b31565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015611709573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061172d91906129a7565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6002606554036117d85760405162461bcd60e51b815260206004820152601f60248201527f5265656e7472616e637947756172643a207265656e7472616e742063616c6c006044820152606401610ee4565b6002606555565b60006117e9611f20565b6040516337e5fda760e21b815230600482015263ffffffff841660248201526001600160a01b03919091169063df97f69c906044016020604051808303816000875af115801561183d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102a59190612b3f565b6001606555565b600054610100900460ff1661188f5760405162461bcd60e51b8152600401610ee490612b58565b611897611fb2565b61189f611fe1565b60978054610100600160a81b0319166101006001600160a01b038516908102919091179091556118e25760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600044425a60408051602081019490945283019190915260608201526080810183905260a00160408051601f19818403018152919052805160209091012092915050565b6060826004015460000361194f575060606102a5565b60008360040154836119619190612ba3565b90506000805b855461ffff82161015611c1157856001018161ffff168154811061198d5761198d6128d8565b600091825260209091206008820401546119b9916007166004026101000a900463ffffffff1683612af3565b915081831015611c0157856003018161ffff16815481106119dc576119dc6128d8565b906000526020600020906008918282040191900660040281819054906101000a900463ffffffff1680929190611a1190612bc5565b91906101000a81548163ffffffff021916908363ffffffff16021790555050856002018161ffff1681548110611a4957611a496128d8565b90600052602060002090600891828204019190066004029054906101000a900463ffffffff1663ffffffff16866003018261ffff1681548110611a8e57611a8e6128d8565b6000918252602090912060088204015460079091166004026101000a900463ffffffff1603611b0e576000866001018261ffff1681548110611ad257611ad26128d8565b90600052602060002090600891828204019190066004026101000a81548163ffffffff021916908363ffffffff160217905550611b0e86612010565b856000018161ffff1681548110611b2757611b276128d8565b90600052602060002001805480602002602001604051908101604052809291908181526020016000905b82821015611bf3576000848152602090206040805160808101909152600384029091018054829060ff166005811115611b8c57611b8c6124da565b6005811115611b9d57611b9d6124da565b81526020016000820160019054906101000a90046001600160a01b03166001600160a01b03166001600160a01b031681526020016001820154815260200160028201548152505081526020019060010190611b51565b5050505093505050506102a5565b611c0a81612986565b9050611967565b5084548590611c2290600190612bde565b81548110611c3257611c326128d8565b90600052602060002001805480602002602001604051908101604052809291908181526020016000905b82821015611cfe576000848152602090206040805160808101909152600384029091018054829060ff166005811115611c9757611c976124da565b6005811115611ca857611ca86124da565b81526020016000820160019054906101000a90046001600160a01b03166001600160a01b03166001600160a01b031681526020016001820154815260200160028201548152505081526020019060010190611c5c565b505050509250505092915050565b600181516005811115611d2157611d216124da565b03611d9057602081015160608201516040516340c10f1960e01b81526001600160a01b03858116600483015260248201929092529116906340c10f19906044015b600060405180830381600087803b158015611d7c57600080fd5b505af1158015610418573d6000803e3d6000fd5b600381516005811115611da557611da56124da565b03611e0f5780602001516001600160a01b031663156e29f683611dcb846040015161208f565b60608501516040516001600160e01b031960e086901b1681526001600160a01b03909316600484015263ffffffff9190911660248301526044820152606401611d62565b600281516005811115611e2457611e246124da565b03611e7e5780602001516001600160a01b031663c68295a483611e4a84606001516120f8565b6040516001600160e01b031960e085901b1681526001600160a01b03909216600483015260ff166024820152604401611d62565b600581516005811115611e9357611e936124da565b03611ee657602081015160408083015160608401519151633cafbb2560e21b81526001600160a01b038681166004830152602482019290925260448101929092529091169063f2beec9490606401611d62565b600081516005811115611efb57611efb6124da565b03611f04575050565b805160405163e5eeccfb60e01b8152610ee49190600401612b31565b6097546040516329f20e0f60e11b81527f61a08aff0763da990caa98ab17070d5b543908be98734b1d6fc5b759bb4d3ba7600482015260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015611f8e573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906108769190612bf5565b600054610100900460ff16611fd95760405162461bcd60e51b8152600401610ee490612b58565b61088d612159565b600054610100900460ff166120085760405162461bcd60e51b8152600401610ee490612b58565b61088d612190565b6000805b600183015461ffff8216101561208057826001018161ffff168154811061203d5761203d6128d8565b90600052602060002090600891828204019190066004029054906101000a900463ffffffff168261206e9190612c12565b915061207981612986565b9050612014565b5063ffffffff16600490910155565b600063ffffffff8211156120f45760405162461bcd60e51b815260206004820152602660248201527f53616665436173743a2076616c756520646f65736e27742066697420696e203360448201526532206269747360d01b6064820152608401610ee4565b5090565b600060ff8211156120f45760405162461bcd60e51b815260206004820152602560248201527f53616665436173743a2076616c756520646f65736e27742066697420696e2038604482015264206269747360d81b6064820152608401610ee4565b600054610100900460ff166121805760405162461bcd60e51b8152600401610ee490612b58565b61088d61218b611122565b611734565b600054610100900460ff166118615760405162461bcd60e51b8152600401610ee490612b58565b50805460008255600302906000526020600020908101906104369190612314565b50805460008255906000526020600020908101906104369190612341565b8280548282559060005260206000209060070160089004810192821561229b5791602002820160005b8382111561226957833563ffffffff1683826101000a81548163ffffffff021916908363ffffffff160217905550926020019260040160208160030104928301926001030261221f565b80156122995782816101000a81549063ffffffff0219169055600401602081600301049283019260010302612269565b505b506120f492915061235e565b8280548282559060005260206000209060070160089004810192821561229b5791602002820160005b8382111561226957835183826101000a81548163ffffffff021916908363ffffffff16021790555092602001926004016020816003010492830192600103026122d0565b5b808211156120f45780546001600160a81b03191681556000600182018190556002820155600301612315565b808211156120f457600061235582826121b7565b50600101612341565b5b808211156120f4576000815560010161235f565b60006020828403121561238557600080fd5b81356001600160e01b03198116811461172d57600080fd5b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff811182821017156123dc576123dc61239d565b604052919050565b600080604083850312156123f757600080fd5b8235915060208084013567ffffffffffffffff8082111561241757600080fd5b818601915086601f83011261242b57600080fd5b81358181111561243d5761243d61239d565b8060051b915061244e8483016123b3565b818152918301840191848101908984111561246857600080fd5b938501935b838510156124865784358252938501939085019061246d565b8096505050505050509250929050565b801515811461043657600080fd5b6000602082840312156124b657600080fd5b813561172d81612496565b6000602082840312156124d357600080fd5b5035919050565b634e487b7160e01b600052602160045260246000fd5b6006811061250e57634e487b7160e01b600052602160045260246000fd5b9052565b600081518084526020808501945080840160005b8381101561254857815163ffffffff1687529582019590820190600101612526565b509495945050505050565b6000602080835260c08301845160a08386015281815180845260e08701915060e08160051b880101935084830192506000805b8281101561260a5788860360df19018452845180518088529088019088880190845b818110156125f45783516125bd8482516124f0565b808c01516001600160a01b0316848d01526040808201519085015260609081015190840152928a01926080909201916001016125a8565b5090975050509386019392860192600101612586565b5050505050818501519150601f198085830301604086015261262c8284612512565b925060408601519150808584030160608601526126498383612512565b92506060860151915080858403016080860152506126678282612512565b915050608084015160a08401528091505092915050565b60008083601f84011261269057600080fd5b50813567ffffffffffffffff8111156126a857600080fd5b6020830191508360208260071b85010111156126c357600080fd5b9250929050565b600080602083850312156126dd57600080fd5b823567ffffffffffffffff8111156126f457600080fd5b6127008582860161267e565b90969095509350505050565b6001600160a01b038116811461043657600080fd5b60006020828403121561273357600080fd5b813561172d8161270c565b60008060006040848603121561275357600080fd5b833561275e8161270c565b9250602084013567ffffffffffffffff81111561277a57600080fd5b6127868682870161267e565b9497909650939450505050565b60008083601f8401126127a557600080fd5b50813567ffffffffffffffff8111156127bd57600080fd5b6020830191508360208260051b85010111156126c357600080fd5b60008060008060008060006080888a0312156127f357600080fd5b87359650602088013567ffffffffffffffff8082111561281257600080fd5b61281e8b838c01612793565b909850965060408a013591508082111561283757600080fd5b6128438b838c01612793565b909650945060608a013591508082111561285c57600080fd5b506128698a828b01612793565b989b979a50959850939692959293505050565b6000806000806060858703121561289257600080fd5b843561289d8161270c565b9350602085013567ffffffffffffffff8111156128b957600080fd5b6128c58782880161267e565b9598909750949560400135949350505050565b634e487b7160e01b600052603260045260246000fd5b6006811061043657600080fd5b60006080828403121561290d57600080fd5b6040516080810181811067ffffffffffffffff821117156129305761293061239d565b604052823561293e816128ee565b8152602083013561294e8161270c565b6020820152604083810135908201526060928301359281019290925250919050565b634e487b7160e01b600052601160045260246000fd5b600061ffff80831681810361299d5761299d612970565b6001019392505050565b6000602082840312156129b957600080fd5b815161172d81612496565b6000602082840312156129d657600080fd5b813561172d816128ee565b600060ff821660ff81036129f7576129f7612970565b60010192915050565b8135612a0b816128ee565b60068110612a2957634e487b7160e01b600052602160045260246000fd5b815460ff821691508160ff1982161783556020840135612a488161270c565b6001600160a81b03199190911690911760089190911b610100600160a81b031617815560408201356001820155606090910135600290910155565b6000808335601e19843603018112612a9a57600080fd5b83018035915067ffffffffffffffff821115612ab557600080fd5b6020019150600781901b36038213156126c357600080fd5b600060208284031215612adf57600080fd5b813563ffffffff8116811461172d57600080fd5b60008219821115612b0657612b06612970565b500190565b60408101612b1982856124f0565b6001600160a01b039290921660209190910152919050565b602081016102a582846124f0565b600060208284031215612b5157600080fd5b5051919050565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b600082612bc057634e487b7160e01b600052601260045260246000fd5b500690565b600063ffffffff80831681810361299d5761299d612970565b600082821015612bf057612bf0612970565b500390565b600060208284031215612c0757600080fd5b815161172d8161270c565b600063ffffffff808316818516808303821115612c3157612c31612970565b0194935050505056fea264697066735822122005a0f3136278754301a4980dbd016f7b4a817d1f7f241d0df4efbdbbda1b1b8864736f6c634300080d0033";
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

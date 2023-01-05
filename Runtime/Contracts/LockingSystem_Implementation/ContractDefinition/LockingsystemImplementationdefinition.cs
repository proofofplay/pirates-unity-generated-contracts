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

namespace PirateNationContracts.LockingSystem_Implementation.ContractDefinition
{


    public partial class LockingsystemImplementationDeployment : LockingsystemImplementationDeploymentBase
    {
        public LockingsystemImplementationDeployment() : base(BYTECODE) { }
        public LockingsystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class LockingsystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506126db806100206000396000f3fe608060405234801561001057600080fd5b50600436106101cf5760003560e01c806387505e7911610104578063dd898b2f116100a2578063ed022ebd11610071578063ed022ebd1461049e578063f28b1639146104b4578063f2fde38b146104c7578063fc3c13f9146104da57600080fd5b8063dd898b2f14610452578063e0c68b2914610465578063e376f98414610478578063e90a449f1461048b57600080fd5b8063a236bfd2116100de578063a236bfd2146103cb578063a3c0a3cb146103f3578063bfaf30ba1461042c578063c4d66de81461043f57600080fd5b806387505e79146103885780638da5cb5b1461039b57806398010ad5146103c057600080fd5b80635c975abb11610171578063760e4c531161014b578063760e4c53146102dd5780637d9ee4911461031d57806380e67f8114610362578063834306351461037557600080fd5b80635c975abb146102bb5780635d1ca631146102c3578063715018a6146102d557600080fd5b806310cc8c0d116101ad57806310cc8c0d1461023057806316c38b3c146102825780633161c00d14610295578063572b6c05146102a857600080fd5b806301ffc9a7146101d457806306c1cb91146101fc5780630bb7c1bf14610210575b600080fd5b6101e76101e2366004612125565b6104e7565b60405190151581526020015b60405180910390f35b61020e61020a366004612200565b5050565b005b61022361021e36600461225c565b61051e565b6040516101f39190612288565b61024361023e3660046122eb565b6105c5565b60408051825181526020808401511515908201528282015163ffffffff90811692820192909252606092830151909116918101919091526080016101f3565b61020e61029036600461234a565b610689565b61020e6102a3366004612367565b6106aa565b6101e76102b63660046123a5565b610930565b6101e7610977565b6098545b6040519081526020016101f3565b61020e610a02565b6102c76102eb3660046123c2565b6001600160a01b0392831660009081526099602090815260408083209490951682529283528381209181529152205490565b61033061032b366004612367565b610a16565b6040805182511515815260208084015163ffffffff9081169183019190915292820151909216908201526060016101f3565b6101e7610370366004612403565b610ab9565b61020e6103833660046123c2565b610bea565b61020e61039636600461234a565b610d2f565b6033546001600160a01b03165b6040516001600160a01b0390911681526020016101f3565b609b5460ff166101e7565b6103de6103d936600461248c565b610d4a565b60405163ffffffff90911681526020016101f3565b6101e761040136600461225c565b6001600160a01b03919091166000908152609a60209081526040808320938352929052205460ff1690565b61020e61043a36600461225c565b6110ba565b61020e61044d3660046123a5565b611250565b61020e6104603660046123a5565b61138d565b61020e6104733660046122eb565b6113d8565b6103de6104863660046124f8565b611743565b6102c76104993660046123c2565b611989565b60975461010090046001600160a01b03166103a8565b6102236104c23660046123c2565b611a30565b61020e6104d53660046123a5565b611ae4565b609b546101e79060ff1681565b60006001600160e01b03198216630b31767d60e21b148061051857506001600160e01b031982166301ffc9a760e01b145b92915050565b6001600160a01b0382166000908152609a6020908152604080832084845282529182902060018101805484518185028101850190955280855260609492938301828280156105b757602002820191906000526020600020906000905b82829054906101000a900463ffffffff1663ffffffff168152602001906004019060208260030104928301926001038202915080841161057a5790505b505050505091505092915050565b60408051608080820183526000808352602080840182905283850182905260608085018390526001600160a01b038a8116845260998352868420908a1684528252858320888452825285832063ffffffff888116855260058201845287852088519687018952805487526001015460ff811615159487019490945261010084048116978601889052600160281b909304909216908401529293900361067d5760405163222d729160e11b815260040160405180910390fd5b9150505b949350505050565b610691611b5a565b80156106a25761069f611bd3565b50565b61069f611c70565b6106b2611cf1565b6000805160206126868339815191526106d2816106cd611d4a565b611d78565b6001600160a01b0384166000908152609a60209081526040808320868452825280832063ffffffff80871685526002820190935290832080549193909261010090920490911690036107375760405163222d729160e11b815260040160405180910390fd5b63ffffffff8085166000908152600384016020526040902054600180850154919092169161076491612554565b8163ffffffff161461082e576001808401805460009261078391612554565b815481106107935761079361256b565b90600052602060002090600891828204019190066004029054906101000a900463ffffffff16905080846001018363ffffffff16815481106107d7576107d761256b565b600091825260208083206008830401805460079093166004026101000a63ffffffff81810219909416958416029490941790935592831681526003860190915260409020805463ffffffff19169183169190911790555b8260010180548061084157610841612581565b600082815260209020600860001990920191820401805463ffffffff600460078516026101000a02191690559055815460ff161561088357825461ff00191683555b63ffffffff851660009081526002840160209081526040808320805468ffffffffffffffffff19169055600386019091529020805463ffffffff1916905560018301541580156108d95750825460ff1615156001145b1561091d57825460ff1916835560405186906001600160a01b038916907ff15274e1fe5043a963d7d1dfdb31b4c69407f0c6f0fc77ddf03f605961cfe28490600090a35b5050505061092b6001606555565b505050565b60975460009061010090046001600160a01b03161580159061051857506105187fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283611e28565b60975460009060ff16806109fd5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156109d9573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109fd9190612597565b905090565b610a0a611b5a565b610a146000611eaa565b565b6040805160608082018352600080835260208084018290528385018290526001600160a01b0388168252609a8152848220878352815284822063ffffffff8781168452600282018352868420875195860188525460ff81161515865261010081048216938601849052600160281b900416958401959095529293929003610ab05760405163222d729160e11b815260040160405180910390fd5b95945050505050565b6000805b83518160ff161015610bde576000848260ff1681518110610ae057610ae061256b565b602002602001015190506000848360ff1681518110610b0157610b0161256b565b6020908102919091018101516001600160a01b038a81166000818152609985526040808220938d1680835293865280822088835290955284812080549551627eeac760e11b81526004810193909352602483018890529395509293919062fdd58e90604401602060405180830381865afa158015610b83573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610ba791906125b4565b610bb19190612554565b905082811015610bc957600095505050505050610681565b5050505080610bd7906125cd565b9050610abd565b50600195945050505050565b610bf2611cf1565b609b5460ff161515600114610c1a5760405163e817c0bb60e01b815260040160405180910390fd5b610c22611d4a565b6001600160a01b0316836001600160a01b031614610c53576040516330cd747160e01b815260040160405180910390fd5b6001600160a01b038084166000908152609960209081526040808320938616835292815282822084835290522080548015610cd2576000825560405181815283906001600160a01b0380871691908816907f1a5ae07720269c1762e933d7b9fbc6127d6fae29ba748699caa84a42e181978c9060200160405180910390a45b6001600160a01b03808616600090815260996020908152604080832093881683529281528282208683529052908120818155600181018290556002810182905560038101805463ffffffff191690559061091d60048301826120f0565b610d37611b5a565b609b805460ff1916911515919091179055565b6000610d54611cf1565b600080516020612686833981519152610d6f816106cd611d4a565b6001600160a01b038089166000908152609960209081526040808320938b168352928152828220898352905290812090869003610dbf5760405163162908e360e11b815260040160405180910390fd5b610de97ff7b302cb700b7a54f3e005e07d62e8f53814068ec358c9a9e3f0423fa744c6a789611e28565b1515600003610e1b576040516341d1699160e01b81526001600160a01b03891660048201526024015b60405180910390fd5b604051627eeac760e11b81526001600160a01b038a8116600483015260248201899052600091908a169062fdd58e90604401602060405180830381865afa158015610e6a573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610e8e91906125b4565b905060008615610ea757610ea28284611efc565b610eb6565b6001830154610eb69083612554565b905080881115610ee357604051631d7b46b360e01b81526004810189905260248101829052604401610e12565b6000610eed611f1d565b90508715610f145788846001016000828254610f0991906125ec565b90915550610f289050565b8360020154891115610f2857600284018990555b604080516080810182528a815289151560208083019182524263ffffffff9081168486019081528c821660608601908152878316600081815260058d018652978820965187559451600196870180549351925164ffffffffff1990941691151564ffffffff0019169190911761010092851683021768ffffffff00000000001916600160281b93851693909302929092179091556004808b01805480880182558189529490972060088504018054600790951690910290910a9182021990921692029190911790559054610ffc9190612554565b63ffffffff82811660009081526006870160205260409020805463ffffffff19169290911691909117905583546002850154600186015461103d91906125ec565b80865581101561109f578a8c6001600160a01b03168e6001600160a01b03167f1e6a45a29298c2bbcc4346611ba88dcc3157d5ede15ff7adfc3374b7dd57c16384896000015461108d9190612554565b60405190815260200160405180910390a45b509450505050506110b06001606555565b9695505050505050565b6110c2611cf1565b609b5460ff1615156001146110ea5760405163e817c0bb60e01b815260040160405180910390fd5b6110f2611d4a565b6040516331a9108f60e11b8152600481018390526001600160a01b0391821691841690636352211e90602401602060405180830381865afa15801561113b573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061115f9190612604565b6001600160a01b031614611186576040516330cd747160e01b815260040160405180910390fd5b6001600160a01b0382166000908152609a6020908152604080832084845290915290205460ff16151560010361120a576001600160a01b0382166000818152609a60209081526040808320858452909152808220805460ff19169055518392917ff15274e1fe5043a963d7d1dfdb31b4c69407f0c6f0fc77ddf03f605961cfe28491a35b6001600160a01b0382166000908152609a602090815260408083208484529091528120805461ffff191681559061124460018301826120f0565b505061020a6001606555565b600054610100900460ff16158080156112705750600054600160ff909116105b8061128a5750303b15801561128a575060005460ff166001145b6112ed5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b6064820152608401610e12565b6000805460ff191660011790558015611310576000805461ff0019166101001790555b61133a827f014f6fb700e688e304b410f81545ae2d4da13a493bf857fd2bf0f97da00bf997611f3e565b609b805460ff19169055801561020a576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b611395611b5a565b60978054610100600160a81b0319166101006001600160a01b0384169081029190911790915561069f5760405163a4b9148160e01b815260040160405180910390fd5b6113e0611cf1565b6000805160206126868339815191526113fb816106cd611d4a565b6001600160a01b0380861660009081526099602090815260408083209388168352928152828220868352815282822063ffffffff80871684526005820190925292822060018101549092610100909104909116900361146d5760405163222d729160e11b815260040160405180910390fd5b63ffffffff8085166000908152600684016020526040902054600484015491169061149a90600190612554565b8163ffffffff161461156757600483018054600091906114bc90600190612554565b815481106114cc576114cc61256b565b90600052602060002090600891828204019190066004029054906101000a900463ffffffff16905080846004018363ffffffff16815481106115105761151061256b565b600091825260208083206008830401805460079093166004026101000a63ffffffff81810219909416958416029490941790935592831681526006860190915260409020805463ffffffff19169183169190911790555b8260040180548061157a5761157a612581565b600082815260209020600860001990920191820401805463ffffffff600460078516026101000a02191690559055600182015460ff16156115d65781546001840180546000906115cb908490612554565b9091555061166f9050565b6000805b60048501548110156116685760008560050160008760040184815481106116035761160361256b565b6000918252602080832060088304015460079092166004026101000a90910463ffffffff1683528201929092526040019020600181015490915060ff1615801561164d5750805483105b1561165757805492505b5061166181612621565b90506115da565b5060028401555b63ffffffff8516600090815260058401602090815260408083208381556001908101805468ffffffffffffffffff1916905560068701909252909120805463ffffffff19169055835460028501549185015490916116cc916125ec565b80855581111561172e5786886001600160a01b03168a6001600160a01b03167f1a5ae07720269c1762e933d7b9fbc6127d6fae29ba748699caa84a42e181978c87600001548561171c9190612554565b60405190815260200160405180910390a45b505050505061173d6001606555565b50505050565b600061174d611cf1565b600080516020612686833981519152611768816106cd611d4a565b6001600160a01b0386166000908152609a6020908152604080832088845290915290206117b57f5a0afddc7ecb0deaa549d40e18566f1c87c8ed09187b6915eaf44079f37e2aca88611e28565b15156001146117e2576040516341d1699160e01b81526001600160a01b0388166004820152602401610e12565b60018515151480156118005750805460ff6101009091041615156001145b1561181e57604051631c74411b60e01b815260040160405180910390fd5b6000611828611f1d565b9050851561183e57815461ff0019166101001782555b6040805160608101825287151581524263ffffffff9081166020808401918252898316848601908152868416600081815260028a018452968720955186549451925164ffffffffff1990951690151564ffffffff0019161761010092861683021768ffffffff00000000001916600160281b94861694909402939093179094556001808801805480830182558188529290962060088304018054600790931660040290950a93840219909116929091029190911790915590546119019190612554565b63ffffffff82811660009081526003850160205260408120805463ffffffff191693909216929092179055825460ff161515900361197b57815460ff1916600117825560405187906001600160a01b038a16907fa9262575db5f22d8b54192efce38602ac59d04bcdbcba1962fc351473de5614690600090a35b925050506106816001606555565b6001600160a01b0383811660008181526099602090815260408083209487168084529482528083208684529091528082209051627eeac760e11b81526004810193909352602483018590529092909183919062fdd58e90604401602060405180830381865afa158015611a00573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190611a2491906125b4565b90506110b08183611efc565b6001600160a01b03808416600090815260996020908152604080832093861683529281528282208483528152908290206004810180548451818502810185019095528085526060949293830182828015611ad557602002820191906000526020600020906000905b82829054906101000a900463ffffffff1663ffffffff1681526020019060040190602082600301049283019260010382029150808411611a985790505b50505050509150509392505050565b611aec611b5a565b6001600160a01b038116611b515760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610e12565b61069f81611eaa565b611b62611d4a565b6001600160a01b0316611b7d6033546001600160a01b031690565b6001600160a01b031614610a145760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610e12565b60975460ff1615611c1d5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610e12565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258611c53611d4a565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114611cbe5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610e12565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa611c53611d4a565b600260655403611d435760405162461bcd60e51b815260206004820152601f60248201527f5265656e7472616e637947756172643a207265656e7472616e742063616c6c006044820152606401610e12565b6002606555565b600060143610801590611d615750611d6133610930565b15611d73575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015611dcf573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190611df39190612597565b61020a5760405162b0d32560e11b81526001600160a01b038216600482015260248101839052604401610e12565b6001606555565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015611e7f573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190611ea39190612597565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b60008160020154826001015484611f139190612554565b611ea39190612554565b6000611f2d609c80546001019055565b6109fd611f39609c5490565b611fcb565b600054610100900460ff16611f655760405162461bcd60e51b8152600401610e129061263a565b611f6d612034565b611f75612063565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155611fb85760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600063ffffffff8211156120305760405162461bcd60e51b815260206004820152602660248201527f53616665436173743a2076616c756520646f65736e27742066697420696e203360448201526532206269747360d01b6064820152608401610e12565b5090565b600054610100900460ff1661205b5760405162461bcd60e51b8152600401610e129061263a565b610a14612092565b600054610100900460ff1661208a5760405162461bcd60e51b8152600401610e129061263a565b610a146120c9565b600054610100900460ff166120b95760405162461bcd60e51b8152600401610e129061263a565b610a146120c4611d4a565b611eaa565b600054610100900460ff16611e215760405162461bcd60e51b8152600401610e129061263a565b50805460008255600701600890049060005260206000209081019061069f91905b808211156120305760008155600101612111565b60006020828403121561213757600080fd5b81356001600160e01b031981168114611ea357600080fd5b634e487b7160e01b600052604160045260246000fd5b600082601f83011261217657600080fd5b8135602067ffffffffffffffff808311156121935761219361214f565b8260051b604051601f19603f830116810181811084821117156121b8576121b861214f565b6040529384528581018301938381019250878511156121d657600080fd5b83870191505b848210156121f5578135835291830191908301906121dc565b979650505050505050565b6000806040838503121561221357600080fd5b82359150602083013567ffffffffffffffff81111561223157600080fd5b61223d85828601612165565b9150509250929050565b6001600160a01b038116811461069f57600080fd5b6000806040838503121561226f57600080fd5b823561227a81612247565b946020939093013593505050565b6020808252825182820181905260009190848201906040850190845b818110156122c657835163ffffffff16835292840192918401916001016122a4565b50909695505050505050565b803563ffffffff811681146122e657600080fd5b919050565b6000806000806080858703121561230157600080fd5b843561230c81612247565b9350602085013561231c81612247565b925060408501359150612331606086016122d2565b905092959194509250565b801515811461069f57600080fd5b60006020828403121561235c57600080fd5b8135611ea38161233c565b60008060006060848603121561237c57600080fd5b833561238781612247565b92506020840135915061239c604085016122d2565b90509250925092565b6000602082840312156123b757600080fd5b8135611ea381612247565b6000806000606084860312156123d757600080fd5b83356123e281612247565b925060208401356123f281612247565b929592945050506040919091013590565b6000806000806080858703121561241957600080fd5b843561242481612247565b9350602085013561243481612247565b9250604085013567ffffffffffffffff8082111561245157600080fd5b61245d88838901612165565b9350606087013591508082111561247357600080fd5b5061248087828801612165565b91505092959194509250565b60008060008060008060c087890312156124a557600080fd5b86356124b081612247565b955060208701356124c081612247565b9450604087013593506060870135925060808701356124de8161233c565b91506124ec60a088016122d2565b90509295509295509295565b6000806000806080858703121561250e57600080fd5b843561251981612247565b93506020850135925060408501356125308161233c565b9150612331606086016122d2565b634e487b7160e01b600052601160045260246000fd5b6000828210156125665761256661253e565b500390565b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052603160045260246000fd5b6000602082840312156125a957600080fd5b8151611ea38161233c565b6000602082840312156125c657600080fd5b5051919050565b600060ff821660ff81036125e3576125e361253e565b60010192915050565b600082198211156125ff576125ff61253e565b500190565b60006020828403121561261657600080fd5b8151611ea381612247565b6000600182016126335761263361253e565b5060010190565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fed3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb53a2646970667358221220037f16e2ed9ebc7b2f71e0dc65843879c172bd55fb1496e65aacf5fac790dba264736f6c634300080d0033";
        public LockingsystemImplementationDeploymentBase() : base(BYTECODE) { }
        public LockingsystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AddItemReservationFunction : AddItemReservationFunctionBase { }

    [Function("addItemReservation", "uint32")]
    public class AddItemReservationFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 4)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bool", "exclusive", 5)]
        public virtual bool Exclusive { get; set; }
        [Parameter("uint32", "data", 6)]
        public virtual uint Data { get; set; }
    }

    public partial class AddNFTReservationFunction : AddNFTReservationFunctionBase { }

    [Function("addNFTReservation", "uint32")]
    public class AddNFTReservationFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("bool", "exclusive", 3)]
        public virtual bool Exclusive { get; set; }
        [Parameter("uint32", "data", 4)]
        public virtual uint Data { get; set; }
    }

    public partial class CanTransferItemsFunction : CanTransferItemsFunctionBase { }

    [Function("canTransferItems", "bool")]
    public class CanTransferItemsFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256[]", "ids", 3)]
        public virtual List<BigInteger> Ids { get; set; }
        [Parameter("uint256[]", "amounts", 4)]
        public virtual List<BigInteger> Amounts { get; set; }
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

    public partial class GetItemReservationFunction : GetItemReservationFunctionBase { }

    [Function("getItemReservation", typeof(GetItemReservationOutputDTO))]
    public class GetItemReservationFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "reservationId", 4)]
        public virtual uint ReservationId { get; set; }
    }

    public partial class GetItemReservationIdsFunction : GetItemReservationIdsFunctionBase { }

    [Function("getItemReservationIds", "uint32[]")]
    public class GetItemReservationIdsFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GetNFTReservationFunction : GetNFTReservationFunctionBase { }

    [Function("getNFTReservation", typeof(GetNFTReservationOutputDTO))]
    public class GetNFTReservationFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "reservationId", 3)]
        public virtual uint ReservationId { get; set; }
    }

    public partial class GetNFTReservationIdsFunction : GetNFTReservationIdsFunctionBase { }

    [Function("getNFTReservationIds", "uint32[]")]
    public class GetNFTReservationIdsFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GetRescueUnlockEnabledFunction : GetRescueUnlockEnabledFunctionBase { }

    [Function("getRescueUnlockEnabled", "bool")]
    public class GetRescueUnlockEnabledFunctionBase : FunctionMessage
    {

    }

    public partial class InitializeFunction : InitializeFunctionBase { }

    [Function("initialize")]
    public class InitializeFunctionBase : FunctionMessage
    {
        [Parameter("address", "gameRegistryAddress", 1)]
        public virtual string GameRegistryAddress { get; set; }
    }

    public partial class IsNFTLockedFunction : IsNFTLockedFunctionBase { }

    [Function("isNFTLocked", "bool")]
    public class IsNFTLockedFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class IsTrustedForwarderFunction : IsTrustedForwarderFunctionBase { }

    [Function("isTrustedForwarder", "bool")]
    public class IsTrustedForwarderFunctionBase : FunctionMessage
    {
        [Parameter("address", "forwarder", 1)]
        public virtual string Forwarder { get; set; }
    }

    public partial class ItemAmountLockedFunction : ItemAmountLockedFunctionBase { }

    [Function("itemAmountLocked", "uint256")]
    public class ItemAmountLockedFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ItemAmountUnlockedFunction : ItemAmountUnlockedFunctionBase { }

    [Function("itemAmountUnlocked", "uint256")]
    public class ItemAmountUnlockedFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class RemoveItemReservationFunction : RemoveItemReservationFunctionBase { }

    [Function("removeItemReservation")]
    public class RemoveItemReservationFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "reservationId", 4)]
        public virtual uint ReservationId { get; set; }
    }

    public partial class RemoveNFTReservationFunction : RemoveNFTReservationFunctionBase { }

    [Function("removeNFTReservation")]
    public class RemoveNFTReservationFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint32", "reservationId", 3)]
        public virtual uint ReservationId { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class RescueUnlockEnabledFunction : RescueUnlockEnabledFunctionBase { }

    [Function("rescueUnlockEnabled", "bool")]
    public class RescueUnlockEnabledFunctionBase : FunctionMessage
    {

    }

    public partial class RescueUnlockItemsFunction : RescueUnlockItemsFunctionBase { }

    [Function("rescueUnlockItems")]
    public class RescueUnlockItemsFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class RescueUnlockNFTFunction : RescueUnlockNFTFunctionBase { }

    [Function("rescueUnlockNFT")]
    public class RescueUnlockNFTFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class SetRescueUnlockEnabledFunction : SetRescueUnlockEnabledFunctionBase { }

    [Function("setRescueUnlockEnabled")]
    public class SetRescueUnlockEnabledFunctionBase : FunctionMessage
    {
        [Parameter("bool", "_enabled", 1)]
        public virtual bool Enabled { get; set; }
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

    public partial class ItemLockedEventDTO : ItemLockedEventDTOBase { }

    [Event("ItemLocked")]
    public class ItemLockedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2, true )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 4, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class ItemUnlockedEventDTO : ItemUnlockedEventDTOBase { }

    [Event("ItemUnlocked")]
    public class ItemUnlockedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "tokenContract", 2, true )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 4, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class NFTLockedEventDTO : NFTLockedEventDTOBase { }

    [Event("NFTLocked")]
    public class NFTLockedEventDTOBase : IEventDTO
    {
        [Parameter("address", "tokenContract", 1, true )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2, true )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class NFTUnlockedEventDTO : NFTUnlockedEventDTOBase { }

    [Event("NFTUnlocked")]
    public class NFTUnlockedEventDTOBase : IEventDTO
    {
        [Parameter("address", "tokenContract", 1, true )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2, true )]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class ContractNotAllowlistedError : ContractNotAllowlistedErrorBase { }

    [Error("ContractNotAllowlisted")]
    public class ContractNotAllowlistedErrorBase : IErrorDTO
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
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



    public partial class NotEnoughUnlockedTokensError : NotEnoughUnlockedTokensErrorBase { }

    [Error("NotEnoughUnlockedTokens")]
    public class NotEnoughUnlockedTokensErrorBase : IErrorDTO
    {
        [Parameter("uint256", "expected", 1)]
        public virtual BigInteger Expected { get; set; }
        [Parameter("uint256", "available", 2)]
        public virtual BigInteger Available { get; set; }
    }











    public partial class CanTransferItemsOutputDTO : CanTransferItemsOutputDTOBase { }

    [FunctionOutput]
    public class CanTransferItemsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
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

    public partial class GetItemReservationOutputDTO : GetItemReservationOutputDTOBase { }

    [FunctionOutput]
    public class GetItemReservationOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual ItemReservation ReturnValue1 { get; set; }
    }

    public partial class GetItemReservationIdsOutputDTO : GetItemReservationIdsOutputDTOBase { }

    [FunctionOutput]
    public class GetItemReservationIdsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32[]", "", 1)]
        public virtual List<uint> ReturnValue1 { get; set; }
    }

    public partial class GetNFTReservationOutputDTO : GetNFTReservationOutputDTOBase { }

    [FunctionOutput]
    public class GetNFTReservationOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual NFTReservation ReturnValue1 { get; set; }
    }

    public partial class GetNFTReservationIdsOutputDTO : GetNFTReservationIdsOutputDTOBase { }

    [FunctionOutput]
    public class GetNFTReservationIdsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint32[]", "", 1)]
        public virtual List<uint> ReturnValue1 { get; set; }
    }

    public partial class GetRescueUnlockEnabledOutputDTO : GetRescueUnlockEnabledOutputDTOBase { }

    [FunctionOutput]
    public class GetRescueUnlockEnabledOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }



    public partial class IsNFTLockedOutputDTO : IsNFTLockedOutputDTOBase { }

    [FunctionOutput]
    public class IsNFTLockedOutputDTOBase : IFunctionOutputDTO 
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

    public partial class ItemAmountLockedOutputDTO : ItemAmountLockedOutputDTOBase { }

    [FunctionOutput]
    public class ItemAmountLockedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class ItemAmountUnlockedOutputDTO : ItemAmountUnlockedOutputDTOBase { }

    [FunctionOutput]
    public class ItemAmountUnlockedOutputDTOBase : IFunctionOutputDTO 
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







    public partial class RescueUnlockEnabledOutputDTO : RescueUnlockEnabledOutputDTOBase { }

    [FunctionOutput]
    public class RescueUnlockEnabledOutputDTOBase : IFunctionOutputDTO 
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

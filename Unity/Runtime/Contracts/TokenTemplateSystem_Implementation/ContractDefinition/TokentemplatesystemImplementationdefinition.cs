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

namespace PirateNationContracts.TokenTemplateSystem_Implementation.ContractDefinition
{


    public partial class TokentemplatesystemImplementationDeployment : TokentemplatesystemImplementationDeploymentBase
    {
        public TokentemplatesystemImplementationDeployment() : base(BYTECODE) { }
        public TokentemplatesystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class TokentemplatesystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506129da806100206000396000f3fe608060405234801561001057600080fd5b506004361061010b5760003560e01c8063715018a6116100a2578063dd898b2f11610071578063dd898b2f14610222578063ed022ebd14610235578063f2fde38b1461024b578063f75103921461025e578063fb5b85971461029057600080fd5b8063715018a6146101cf5780638da5cb5b146101d7578063c4d66de8146101fc578063d25ba1431461020f57600080fd5b8063572b6c05116100de578063572b6c051461018357806358bf4d3e146101965780635c975abb146101b65780635d1ca631146101be57600080fd5b806306c1cb911461011057806313613d4d1461012457806316c38b3c1461014d5780634f558e7914610160575b600080fd5b61012261011e366004611f42565b5050565b005b610137610132366004611ff8565b6102a3565b6040516101449190612054565b60405180910390f35b61012261015b3660046120a5565b610313565b61017361016e3660046120c2565b610334565b6040519015158152602001610144565b6101736101913660046120db565b6103bc565b6101a96101a4366004611ff8565b610409565b60405161014491906120f8565b61017361041d565b609854604051908152602001610144565b6101226104a8565b6033546001600160a01b03165b6040516001600160a01b039091168152602001610144565b61012261020a3660046120db565b6104bc565b61013761021d3660046121d4565b6105f4565b6101226102303660046120db565b610609565b60975461010090046001600160a01b03166101e4565b6101226102593660046120db565b610654565b61027161026c366004611ff8565b6106ca565b604080516001600160a01b039093168352602083019190915201610144565b61012261029e36600461232e565b6106ea565b606061030c8383600060405190808252806020026020018201604052801561030657816020015b6102f3604080516080810182526060808252602082015290810160008152600060209091015290565b8152602001906001900390816102ca5790505b506107d0565b9392505050565b61031b610ace565b801561032c57610329610b47565b50565b610329610be4565b60008061033f610c65565b604051632c5fa69f60e11b8152306004820152602481018590526001600160a01b0391909116906358bf4d3e90604401600060405180830381865afa15801561038c573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526103b49190810190612363565b511192915050565b60975460009061010090046001600160a01b03161580159061040357506104037fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610c90565b92915050565b606061030c610416610c65565b8484610d0b565b60975460009060ff16806104a35750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa15801561047f573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906104a391906123e8565b905090565b6104b0610ace565b6104ba6000610f58565b565b600054610100900460ff16158080156104dc5750600054600160ff909116105b806104f65750303b1580156104f6575060005460ff166001145b61055e5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610581576000805461ff0019166101001790555b6105ab827f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610faa565b801561011e576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b60606106018484846107d0565b949350505050565b610611610ace565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556103295760405163a4b9148160e01b815260040160405180910390fd5b61065c610ace565b6001600160a01b0381166106c15760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610555565b61032981610f58565b6000806106df6106d8610c65565b8585611037565b915091509250929050565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb5361071c8161071761118a565b6111b8565b610724610c65565b6001600160a01b0316637d4ec3b385857f9319bf1fd23873eaf43c06bb91a1db3e678411d693e959f1512879196908f12c61075f3088611261565b6040516001600160e01b031960e087901b1681526001600160a01b039094166004850152602484019290925260448301526064820152608401600060405180830381600087803b1580156107b257600080fd5b505af11580156107c6573d6000803e3d6000fd5b5050505050505050565b606060006107dc610c65565b604051632c5fa69f60e11b81526001600160a01b03871660048201526024810186905290915060009030906358bf4d3e90604401600060405180830381865afa15801561082d573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526108559190810190612363565b9050600084518251610867919061241b565b6001600160401b0381111561087e5761087e611eb1565b6040519080825280602002602001820160405280156108d857816020015b6108c5604080516080810182526060808252602082015290810160008152600060209091015290565b81526020019060019003908161089c5790505b50905060005b8251811015610a585760008382815181106108fb576108fb612433565b602002602001015190506000856001600160a01b031663d1bfc2af836040518263ffffffff1660e01b815260040161093591815260200190565b600060405180830381865afa158015610952573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f1916820160405261097a9190810190612499565b9050806000015184848151811061099357610993612433565b60200260200101516000018190525080604001518484815181106109b9576109b9612433565b60200260200101516040019060048111156109d6576109d6612548565b908160048111156109e9576109e9612548565b815250508060600151848481518110610a0457610a04612433565b6020908102919091010151901515606090910152610a24868b8b856112e2565b848481518110610a3657610a36612433565b602002602001015160200181905250505080610a519061255e565b90506108de565b5060005b8551811015610ab957858181518110610a7757610a77612433565b602002602001015182828551610a8d919061241b565b81518110610a9d57610a9d612433565b602002602001018190525080610ab29061255e565b9050610a5c565b50610ac38161143b565b979650505050505050565b610ad661118a565b6001600160a01b0316610af16033546001600160a01b031690565b6001600160a01b0316146104ba5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610555565b60975460ff1615610b915760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610555565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610bc761118a565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610c325760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610555565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610bc761118a565b60006104a37f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba6114ee565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610ce7573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061030c91906123e8565b6060600080610d1b868686611037565b90925090506001600160a01b03821615801590610d385750600081115b15610eda576000610d4a878484610d0b565b604051632c5fa69f60e11b81526001600160a01b038881166004830152602482018890529192506000918916906358bf4d3e90604401600060405180830381865afa158015610d9d573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f19168201604052610dc59190810190612363565b9050600082518251610dd7919061241b565b6001600160401b03811115610dee57610dee611eb1565b604051908082528060200260200182016040528015610e17578160200160208202803683370190505b50905060005b8351811015610e6d57838181518110610e3857610e38612433565b6020026020010151828281518110610e5257610e52612433565b6020908102919091010152610e668161255e565b9050610e1d565b5060005b8251811015610ecd57828181518110610e8c57610e8c612433565b602002602001015182828651610ea2919061241b565b81518110610eb257610eb2612433565b6020908102919091010152610ec68161255e565b9050610e71565b50945061030c9350505050565b604051632c5fa69f60e11b81526001600160a01b038681166004830152602482018690528716906358bf4d3e90604401600060405180830381865afa158015610f27573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f19168201604052610f4f9190810190612363565b9250505061030c565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600054610100900460ff16610fd15760405162461bcd60e51b815260040161055590612577565b610fd9611561565b610fe1611590565b60978054610100600160a81b0319166101006001600160a01b038516908102919091179091556110245760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b604051639b9a15b360e01b815260009081906001600160a01b03861690639b9a15b39061108c90879087907f9319bf1fd23873eaf43c06bb91a1db3e678411d693e959f1512879196908f12c906004016125c2565b602060405180830381865afa1580156110a9573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906110cd91906123e8565b1561117b57604051630b3f2a6360e01b81526000906001600160a01b03871690630b3f2a639061112590889088907f9319bf1fd23873eaf43c06bb91a1db3e678411d693e959f1512879196908f12c906004016125c2565b602060405180830381865afa158015611142573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061116691906125e3565b9050611171816115bf565b9250925050611182565b5060009050805b935093915050565b6000601436108015906111a157506111a1336103bc565b156111b3575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa15801561120f573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061123391906123e8565b61011e5760405162b0d32560e11b81526001600160a01b038216600482015260248101839052604401610555565b60006bffffffffffffffffffffffff8211156112cb5760405162461bcd60e51b815260206004820152602360248201527f746f6b656e4964206973206c6172676572207468616e207061636b61626c65206044820152620dac2f60eb1b6064820152608401610555565b5060a081901b6001600160a01b0383161792915050565b604051639b9a15b360e01b81526060906001600160a01b03861690639b9a15b390611315908790879087906004016125c2565b602060405180830381865afa158015611332573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061135691906123e8565b156113d75760405163108e6af960e21b81526001600160a01b03861690634239abe49061138b908790879087906004016125c2565b600060405180830381865afa1580156113a8573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526113d091908101906125fc565b9050610601565b6000806113e5878787611037565b90925090506001600160a01b038216158015906114025750600081115b1561141c57611413878383876112e2565b92505050610601565b8585856040516307d100d760e51b8152600401610555939291906125c2565b60606000611448836115ed565b90506000611455846116d2565b90506000808351116114765760405180602001604052806000815250611491565b604051806040016040528060018152602001600b60fa1b8152505b905060008382846040516020016114aa93929190612644565b60405160208183030381529060405290506114c4816117f1565b6040516020016114d491906126c2565b604051602081830303815290604052945050505050919050565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa15801561153d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906104039190612707565b600054610100900460ff166115885760405162461bcd60e51b815260040161055590612577565b6104ba611943565b600054610100900460ff166115b75760405162461bcd60e51b815260040161055590612577565b6104ba61197a565b8060a081901c6001600160a01b031982166001600160a01b038316178083146115e757600080fd5b50915091565b60408051602081019091526000808252606091906001905b84518110156116c957600085828151811061162257611622612433565b6020026020010151905080606001511515600015150361164257506116b9565b600061164d826119a8565b905060008461167557604051806040016040528060018152602001600b60fa1b815250611686565b604051806020016040528060008152505b83516040519192506116a091889184918690602001612724565b6040516020818303038152906040529550600094505050505b6116c28161255e565b9050611605565b50909392505050565b60408051602081019091526000808252606091906001905b84518110156116c957600085828151811061170757611707612433565b6020026020010151905080606001511515600115150361172757506117e1565b60048160400151600481111561173f5761173f612548565b1480156117625750806020015180602001905181019061175f9190612798565b51155b1561176d57506117e1565b600061177882611b9d565b90506000846117a057604051806040016040528060018152602001600b60fa1b8152506117b1565b604051806020016040528060008152505b90508581836040516020016117c8939291906127cc565b6040516020818303038152906040529550600094505050505b6117ea8161255e565b90506116ea565b6060815160000361181057505060408051602081019091526000815290565b6000604051806060016040528060408152602001612965604091399050600060038451600261183f919061241b565b6118499190612825565b611854906004612839565b6001600160401b0381111561186b5761186b611eb1565b6040519080825280601f01601f191660200182016040528015611895576020820181803683370190505b509050600182016020820185865187015b80821015611901576003820191508151603f8160121c168501518453600184019350603f81600c1c168501518453600184019350603f8160061c168501518453600184019350603f81168501518453506001830192506118a6565b505060038651066001811461191d576002811461193057611938565b603d6001830353603d6002830353611938565b603d60018303535b509195945050505050565b600054610100900460ff1661196a5760405162461bcd60e51b815260040161055590612577565b6104ba61197561118a565b610f58565b600054610100900460ff166119a15760405162461bcd60e51b815260040161055590612577565b6001606555565b604081015160609060048160048111156119c4576119c4612548565b03611a0e57600083602001518060200190518101906119e39190612798565b9050806040516020016119f69190612858565b60405160208183030381529060405292505050919050565b6003816004811115611a2257611a22612548565b03611a945760008360200151806020019051810190611a4191906123e8565b905080611a6d5760405180604001604052806007815260200166113330b639b29160c91b815250610601565b60405180604001604052806006815260200165113a393ab29160d11b815250949350505050565b6002816004811115611aa857611aa8612548565b03611af75760008360200151806020019051810190611ac791906125e3565b9050633b9aca00811115611aee57611ade81611bd7565b6040516020016119f69190612858565b61060181611bd7565b6001816004811115611b0b57611b0b612548565b03611b7e5760008360200151806020019051810190611b2a91906125e3565b90506000611b3782611c69565b9050633b9aca00821380611b4f5750633b9ac9ff1982125b156106015780604051602001611b659190612858565b6040516020818303038152906040529350505050919050565b8260400151604051633cd8199760e11b81526004016105559190612886565b60606000611baa836119a8565b8351604051919250611bc09183906020016128ae565b604051602081830303815290604052915050919050565b60606000611be483611dd9565b60010190506000816001600160401b03811115611c0357611c03611eb1565b6040519080825280601f01601f191660200182016040528015611c2d576020820181803683370190505b5090508181016020015b600019016f181899199a1a9b1b9c1cb0b131b232b360811b600a86061a8153600a8504945084611c3757509392505050565b606081600003611c905750506040805180820190915260018152600360fc1b602082015290565b60008083129081611ca15783611caa565b611caa8461291d565b905080600083611cbb576000611cbe565b60015b60ff1690505b8115611cea5780611cd48161255e565b9150611ce39050600a83612825565b9150611cc4565b6000816001600160401b03811115611d0457611d04611eb1565b6040519080825280601f01601f191660200182016040528015611d2e576020820181803683370190505b5090505b8315611d9957611d43600183612939565b9150611d50600a85612950565b611d5b90603061241b565b60f81b818381518110611d7057611d70612433565b60200101906001600160f81b031916908160001a905350611d92600a85612825565b9350611d32565b8415611dcf57602d60f81b81600081518110611db757611db7612433565b60200101906001600160f81b031916908160001a9053505b9695505050505050565b60008072184f03e93ff9f4daa797ed6e38ed64bf6a1f0160401b8310611e185772184f03e93ff9f4daa797ed6e38ed64bf6a1f0160401b830492506040015b6d04ee2d6d415b85acef81000000008310611e44576d04ee2d6d415b85acef8100000000830492506020015b662386f26fc100008310611e6257662386f26fc10000830492506010015b6305f5e1008310611e7a576305f5e100830492506008015b6127108310611e8e57612710830492506004015b60648310611ea0576064830492506002015b600a83106104035760010192915050565b634e487b7160e01b600052604160045260246000fd5b604051608081016001600160401b0381118282101715611ee957611ee9611eb1565b60405290565b604051601f8201601f191681016001600160401b0381118282101715611f1757611f17611eb1565b604052919050565b60006001600160401b03821115611f3857611f38611eb1565b5060051b60200190565b60008060408385031215611f5557600080fd5b823591506020808401356001600160401b03811115611f7357600080fd5b8401601f81018613611f8457600080fd5b8035611f97611f9282611f1f565b611eef565b81815260059190911b82018301908381019088831115611fb657600080fd5b928401925b82841015611fd457833582529284019290840190611fbb565b80955050505050509250929050565b6001600160a01b038116811461032957600080fd5b6000806040838503121561200b57600080fd5b823561201681611fe3565b946020939093013593505050565b60005b8381101561203f578181015183820152602001612027565b8381111561204e576000848401525b50505050565b6020815260008251806020840152612073816040850160208701612024565b601f01601f19169190910160400192915050565b801515811461032957600080fd5b80356120a081612087565b919050565b6000602082840312156120b757600080fd5b813561030c81612087565b6000602082840312156120d457600080fd5b5035919050565b6000602082840312156120ed57600080fd5b813561030c81611fe3565b6020808252825182820181905260009190848201906040850190845b8181101561213057835183529284019291840191600101612114565b50909695505050505050565b60006001600160401b0382111561215557612155611eb1565b50601f01601f191660200190565b6000612171611f928461213c565b905082815283838301111561218557600080fd5b828260208301376000602084830101529392505050565b600082601f8301126121ad57600080fd5b61030c83833560208501612163565b6005811061032957600080fd5b80356120a0816121bc565b6000806000606084860312156121e957600080fd5b83356121f481611fe3565b9250602084810135925060408501356001600160401b038082111561221857600080fd5b818701915087601f83011261222c57600080fd5b813561223a611f9282611f1f565b81815260059190911b8301840190848101908a83111561225957600080fd5b8585015b8381101561231d5780358581111561227457600080fd5b86016080818e03601f1901121561228a57600080fd5b612292611ec7565b88820135878111156122a357600080fd5b8201603f81018f136122b457600080fd5b6122c58f8b83013560408401612163565b8252506040820135878111156122da57600080fd5b6122e88f8b8386010161219c565b8a830152506122f9606083016121c9565b604082015261230a60808301612095565b606082015284525091860191860161225d565b508096505050505050509250925092565b60008060006060848603121561234357600080fd5b833561234e81611fe3565b95602085013595506040909401359392505050565b6000602080838503121561237657600080fd5b82516001600160401b0381111561238c57600080fd5b8301601f8101851361239d57600080fd5b80516123ab611f9282611f1f565b81815260059190911b820183019083810190878311156123ca57600080fd5b928401925b82841015610ac3578351825292840192908401906123cf565b6000602082840312156123fa57600080fd5b815161030c81612087565b634e487b7160e01b600052601160045260246000fd5b6000821982111561242e5761242e612405565b500190565b634e487b7160e01b600052603260045260246000fd5b6000612457611f928461213c565b905082815283838301111561246b57600080fd5b61030c836020830184612024565b600082601f83011261248a57600080fd5b61030c83835160208501612449565b6000602082840312156124ab57600080fd5b81516001600160401b03808211156124c257600080fd5b90830190608082860312156124d657600080fd5b6124de611ec7565b8251828111156124ed57600080fd5b6124f987828601612479565b8252506020830151915061250c826121bc565b81602082015260408301519150612522826121bc565b8160408201526060830151925061253883612087565b6060810192909252509392505050565b634e487b7160e01b600052602160045260246000fd5b60006001820161257057612570612405565b5060010190565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b6001600160a01b039390931683526020830191909152604082015260600190565b6000602082840312156125f557600080fd5b5051919050565b60006020828403121561260e57600080fd5b81516001600160401b0381111561262457600080fd5b8201601f8101841361263557600080fd5b61060184825160208401612449565b607b60f81b815260008451612660816001850160208901612024565b845190830190612677816001840160208901612024565b6d2261747472696275746573223a5b60901b6001929091019182015283516126a681600f840160208801612024565b615d7d60f01b600f929091019182015260110195945050505050565b7f646174613a6170706c69636174696f6e2f6a736f6e3b6261736536342c0000008152600082516126fa81601d850160208701612024565b91909101601d0192915050565b60006020828403121561271957600080fd5b815161030c81611fe3565b60008551612736818460208a01612024565b85519083019061274a818360208a01612024565b601160f91b91019081528451612767816001840160208901612024565b61111d60f11b60019290910191820152835161278a816003840160208801612024565b016003019695505050505050565b6000602082840312156127aa57600080fd5b81516001600160401b038111156127c057600080fd5b61060184828501612479565b600084516127de818460208901612024565b8451908301906127f2818360208901612024565b8451910190612805818360208801612024565b0195945050505050565b634e487b7160e01b600052601260045260246000fd5b6000826128345761283461280f565b500490565b600081600019048311821515161561285357612853612405565b500290565b6000601160f91b8083528351612875816001860160208801612024565b600193019283015250600201919050565b60208101600583106128a857634e487b7160e01b600052602160045260246000fd5b91905290565b6e3d913a3930b4ba2fba3cb832911d1160891b815282516000906128d981600f850160208801612024565b691116113b30b63ab2911d60b11b600f918401918201528351612903816019840160208801612024565b607d60f81b60199290910191820152601a01949350505050565b6000600160ff1b820161293257612932612405565b5060000390565b60008282101561294b5761294b612405565b500390565b60008261295f5761295f61280f565b50069056fe4142434445464748494a4b4c4d4e4f505152535455565758595a6162636465666768696a6b6c6d6e6f707172737475767778797a303132333435363738392b2fa2646970667358221220aa58abbf55519cdd99ed5a5ddfb513e7750f09177a9b35a2db0818173073961f64736f6c634300080d0033";
        public TokentemplatesystemImplementationDeploymentBase() : base(BYTECODE) { }
        public TokentemplatesystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class ExistsFunction : ExistsFunctionBase { }

    [Function("exists", "bool")]
    public class ExistsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "templateId", 1)]
        public virtual BigInteger TemplateId { get; set; }
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

    public partial class GenerateTokenURIFunction : GenerateTokenURIFunctionBase { }

    [Function("generateTokenURI", "string")]
    public class GenerateTokenURIFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GenerateTokenURI1Function : GenerateTokenURI1FunctionBase { }

    [Function("generateTokenURI", "string")]
    public class GenerateTokenURI1FunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("tuple[]", "extraTraits", 3)]
        public virtual List<TokenURITrait> ExtraTraits { get; set; }
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

    public partial class GetTemplateFunction : GetTemplateFunctionBase { }

    [Function("getTemplate", typeof(GetTemplateOutputDTO))]
    public class GetTemplateFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GetTraitIdsFunction : GetTraitIdsFunctionBase { }

    [Function("getTraitIds", "uint256[]")]
    public class GetTraitIdsFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class SetTemplateFunction : SetTemplateFunctionBase { }

    [Function("setTemplate")]
    public class SetTemplateFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "templateId", 3)]
        public virtual BigInteger TemplateId { get; set; }
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



    public partial class InvalidTraitDataTypeError : InvalidTraitDataTypeErrorBase { }

    [Error("InvalidTraitDataType")]
    public class InvalidTraitDataTypeErrorBase : IErrorDTO
    {
        [Parameter("uint8", "dataType", 1)]
        public virtual byte DataType { get; set; }
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

    public partial class MissingTraitError : MissingTraitErrorBase { }

    [Error("MissingTrait")]
    public class MissingTraitErrorBase : IErrorDTO
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
    }

    public partial class ExistsOutputDTO : ExistsOutputDTOBase { }

    [FunctionOutput]
    public class ExistsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }



    public partial class GenerateTokenURIOutputDTO : GenerateTokenURIOutputDTOBase { }

    [FunctionOutput]
    public class GenerateTokenURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GenerateTokenURI1OutputDTO : GenerateTokenURI1OutputDTOBase { }

    [FunctionOutput]
    public class GenerateTokenURI1OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
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

    public partial class GetTemplateOutputDTO : GetTemplateOutputDTOBase { }

    [FunctionOutput]
    public class GetTemplateOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
    }

    public partial class GetTraitIdsOutputDTO : GetTraitIdsOutputDTOBase { }

    [FunctionOutput]
    public class GetTraitIdsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
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

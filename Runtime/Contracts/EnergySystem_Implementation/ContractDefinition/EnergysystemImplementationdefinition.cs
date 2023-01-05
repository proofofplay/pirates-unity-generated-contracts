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

namespace PirateNationContracts.EnergySystem_Implementation.ContractDefinition
{


    public partial class EnergysystemImplementationDeployment : EnergysystemImplementationDeploymentBase
    {
        public EnergysystemImplementationDeployment() : base(BYTECODE) { }
        public EnergysystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class EnergysystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50611b71806100206000396000f3fe608060405234801561001057600080fd5b50600436106101165760003560e01c806386431ebe116100a2578063dd898b2f11610071578063dd898b2f14610271578063dfc06a4214610284578063ed022ebd146102b0578063f2fde38b146102c6578063fa747110146102d957600080fd5b806386431ebe146101c95780638da5cb5b146101dc5780639f292d7614610201578063c4d66de81461025e57600080fd5b8063572b6c05116100e9578063572b6c051461017b5780635c975abb1461019e5780635d1ca631146101a6578063715018a6146101ae5780637b8d7de8146101b657600080fd5b806306c1cb911461011b57806316c38b3c1461012f57806325d31360146101425780632fcccd4b14610155575b600080fd5b61012d6101293660046117b7565b5050565b005b61012d61013d366004611867565b6102ec565b61012d610150366004611899565b61030d565b6101686101633660046118d2565b6103c7565b6040519081526020015b60405180910390f35b61018e6101893660046118fe565b6103dc565b6040519015158152602001610172565b61018e610423565b609854610168565b61012d6104ae565b61012d6101c436600461191b565b6104c2565b6101686101d73660046118d2565b6106d9565b6033546001600160a01b03165b6040516001600160a01b039091168152602001610172565b61021461020f3660046118d2565b6106e5565b604080519a8b5260208b0199909952978901969096526060880194909452608087019290925260a086015260c085015260e084015261010083015261012082015261014001610172565b61012d61026c3660046118fe565b61079d565b61012d61027f3660046118fe565b6108d0565b61018e6102923660046118fe565b6001600160a01b031660009081526099602052604090205460ff1690565b60975461010090046001600160a01b03166101e9565b61012d6102d43660046118fe565b61091b565b61012d6102e736600461191b565b610991565b6102f4610af5565b801561030557610302610b6e565b50565b610302610c0b565b7f241ecf16d79d0f8dbfb92cbc07fe17840425976cf0667f022fe9877caa831b0861033f8161033a610c88565b610cb6565b6103697f5a0afddc7ecb0deaa549d40e18566f1c87c8ed09187b6915eaf44079f37e2aca84610d5f565b151560000361039b5760405163648194a960e11b81526001600160a01b03841660048201526024015b60405180910390fd5b506001600160a01b03919091166000908152609960205260409020805460ff1916911515919091179055565b60006103d38383610dda565b90505b92915050565b60975460009061010090046001600160a01b0316158015906103d657506103d67fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610d5f565b60975460009060ff16806104a95750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610485573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906104a99190611950565b905090565b6104b6610af5565b6104c06000610e6a565b565b6104ca610ebc565b6104d2610f04565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536104ff8161033a610c88565b6001600160a01b03841660009081526099602052604090205460ff1615156001146105485760405163075b77c560e01b81526001600160a01b0385166004820152602401610392565b60006105548585610dda565b9050670de0b6b3a764000081101561057f5760405163333bb0df60e01b815260040160405180910390fd5b6001600160a01b0385166000818152609a602090815260408083208884528252808320938352609b82528083208884529091528120906105bf8888610f5d565b905060006105cd8989610fd1565b90508082106105f957604051639e725df360e01b81526004810183905260248101829052604401610392565b86858111156106055750845b808560010160008282546106199190611983565b9091555050600185015482101561064e5781856001015461063a919061199b565b610644908261199b565b6001860183905590505b610658818761199b565b845561066342611108565b63ffffffff166001850155886001600160a01b038b16610681610c88565b6001600160a01b03167f973accd24a7590b0d9d69bf724e4fcae3ec69659ed10b2616816fd19bbd2e49a8b6040516106bb91815260200190565b60405180910390a4505050505050506106d46001606555565b505050565b60006103d38383610f5d565b6001600160a01b0382166000818152609a602090815260408083208584528252808320938352609b8252808320858452909152812090918291829182918291829182918291829182916107388e8e610f5d565b9b506107448e8e610fd1565b9a506107508e8e611178565b9950816001015497508160000154985061076a8e8e610dda565b81546001830154919850965094506107806112d6565b935061078a611399565b925050509295989b9194979a5092959850565b600054610100900460ff16158080156107bd5750600054600160ff909116105b806107d75750303b1580156107d7575060005460ff166001145b61083a5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b6064820152608401610392565b6000805460ff19166001179055801561085d576000805461ff0019166101001790555b610887827fdaad241cf87e359c1cee61c121d111147c0d3638669248f816e3e289aec4e8f5611448565b8015610129576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6108d8610af5565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556103025760405163a4b9148160e01b815260040160405180910390fd5b610923610af5565b6001600160a01b0381166109885760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610392565b61030281610e6a565b610999610ebc565b6109a1610f04565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536109ce8161033a610c88565b60006109da8585610f5d565b905082811015610a075760405163d1ace93760e01b81526004810184905260248101829052604401610392565b6001600160a01b03851660009081526099602052604090205460ff161515600114610a505760405163075b77c560e01b81526001600160a01b0386166004820152602401610392565b6001600160a01b0385166000908152609a602090815260408083208784529091529020610a7d848361199b565b6001820155610a8b42611108565b63ffffffff168155846001600160a01b038716610aa6610c88565b6001600160a01b03167feeb026bbab10fcfc225534cf0df1480cfdf3ade29fe5265ae68db0e023bcebf287604051610ae091815260200190565b60405180910390a45050506106d46001606555565b610afd610c88565b6001600160a01b0316610b186033546001600160a01b031690565b6001600160a01b0316146104c05760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610392565b60975460ff1615610bb85760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610392565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610bee610c88565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610c595760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610392565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610bee5b600060143610801590610c9f5750610c9f336103dc565b15610cb1575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610d0d573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610d319190611950565b6101295760405162b0d32560e11b81526001600160a01b038216600482015260248101839052604401610392565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610db6573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103d39190611950565b6001600160a01b0382166000908152609b60209081526040808320848452909152812081610e06611399565b90508160010154600003610e1d5791506103d69050565b6000610e276112d6565b6001840154610e36904261199b565b610e4091906119b2565b8354610e4c9190611983565b905081811115610e60575091506103d69050565b92506103d6915050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b610ec4610423565b156104c05760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b6044820152606401610392565b600260655403610f565760405162461bcd60e51b815260206004820152601f60248201527f5265656e7472616e637947756172643a207265656e7472616e742063616c6c006044820152606401610392565b6002606555565b6001600160a01b0382166000908152609a60209081526040808320848452909152812081610f8b8585610fd1565b8254909150600003610fa05791506103d69050565b6000610fac8686611178565b8354610fb8904261199b565b610fc291906119b2565b8360010154610e4c9190611983565b600080610feb600080516020611b1c8339815191526114d5565b604051631192054960e21b81527f8d23e28e812d175ad845aae00b4915192aab307091d3d09fc2e365df549e5ee360048201529091506000906001600160a01b03831690634648152490602401600060405180830381865afa158015611055573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f1916820160405261107d91908101906119d1565b905060006110aa7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba6114d5565b905060006110b9828888611548565b905082518110156110e9578281815181106110d6576110d6611a62565b60200260200101519450505050506103d6565b82600184516110f8919061199b565b815181106110d6576110d6611a62565b600063ffffffff82111561116d5760405162461bcd60e51b815260206004820152602660248201527f53616665436173743a2076616c756520646f65736e27742066697420696e203360448201526532206269747360d01b6064820152608401610392565b5090565b6001606555565b600080611192600080516020611b1c8339815191526114d5565b604051631192054960e21b81527fb590bf31a141074a90164f11f3321fd5f9b9393322df495ab0d17a44da7d8e6860048201529091506000906001600160a01b03831690634648152490602401600060405180830381865afa1580156111fc573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f1916820160405261122491908101906119d1565b905060006112517f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba6114d5565b90506000611260828888611548565b90506000835182101561128e5783828151811061127f5761127f611a62565b602002602001015190506112b8565b836001855161129d919061199b565b815181106112ad576112ad611a62565b602002602001015190505b6112ca81670de0b6b3a7640000611a78565b98975050505050505050565b6000806112f0600080516020611b1c8339815191526114d5565b604051631106aeeb60e21b81527f3aba2503faad59e759c7447c4626ac8e4183b9b51b37c95781413b6f44e6183860048201529091506000906001600160a01b0383169063441abbac90602401602060405180830381865afa15801561135a573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061137e9190611a9a565b905061139281670de0b6b3a7640000611a78565b9250505090565b6000806113b3600080516020611b1c8339815191526114d5565b604051631106aeeb60e21b81527fd0f017d7e4ebc8e337dbe823d382ac51338bbc7f246aa258152efadf646a21c660048201529091506000906001600160a01b0383169063441abbac90602401602060405180830381865afa15801561141d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906114419190611a9a565b9392505050565b600054610100900460ff1661146f5760405162461bcd60e51b815260040161039290611ab3565b611477611690565b61147f6116bf565b60978054610100600160a81b0319166101006001600160a01b038516908102919091179091556114c25760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015611524573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103d69190611afe565b604051639b9a15b360e01b81526001600160a01b038381166004830152602482018390527fd7fe74ba2795604f471717a6182ac81070ad95ecee0b7d8ebcfbec785af7e796604483015260009190851690639b9a15b390606401602060405180830381865afa1580156115bf573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906115e39190611950565b1561168657604051630b3f2a6360e01b81526001600160a01b038481166004830152602482018490527fd7fe74ba2795604f471717a6182ac81070ad95ecee0b7d8ebcfbec785af7e7966044830152851690630b3f2a6390606401602060405180830381865afa15801561165b573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061167f9190611a9a565b9050611441565b5060009392505050565b600054610100900460ff166116b75760405162461bcd60e51b815260040161039290611ab3565b6104c06116ee565b600054610100900460ff166116e65760405162461bcd60e51b815260040161039290611ab3565b6104c0611725565b600054610100900460ff166117155760405162461bcd60e51b815260040161039290611ab3565b6104c0611720610c88565b610e6a565b600054610100900460ff166111715760405162461bcd60e51b815260040161039290611ab3565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff8111828210171561178b5761178b61174c565b604052919050565b600067ffffffffffffffff8211156117ad576117ad61174c565b5060051b60200190565b600080604083850312156117ca57600080fd5b8235915060208084013567ffffffffffffffff8111156117e957600080fd5b8401601f810186136117fa57600080fd5b803561180d61180882611793565b611762565b81815260059190911b8201830190838101908883111561182c57600080fd5b928401925b8284101561184a57833582529284019290840190611831565b80955050505050509250929050565b801515811461030257600080fd5b60006020828403121561187957600080fd5b813561144181611859565b6001600160a01b038116811461030257600080fd5b600080604083850312156118ac57600080fd5b82356118b781611884565b915060208301356118c781611859565b809150509250929050565b600080604083850312156118e557600080fd5b82356118f081611884565b946020939093013593505050565b60006020828403121561191057600080fd5b813561144181611884565b60008060006060848603121561193057600080fd5b833561193b81611884565b95602085013595506040909401359392505050565b60006020828403121561196257600080fd5b815161144181611859565b634e487b7160e01b600052601160045260246000fd5b600082198211156119965761199661196d565b500190565b6000828210156119ad576119ad61196d565b500390565b60008160001904831182151516156119cc576119cc61196d565b500290565b600060208083850312156119e457600080fd5b825167ffffffffffffffff8111156119fb57600080fd5b8301601f81018513611a0c57600080fd5b8051611a1a61180882611793565b81815260059190911b82018301908381019087831115611a3957600080fd5b928401925b82841015611a5757835182529284019290840190611a3e565b979650505050505050565b634e487b7160e01b600052603260045260246000fd5b600082611a9557634e487b7160e01b600052601260045260246000fd5b500490565b600060208284031215611aac57600080fd5b5051919050565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b600060208284031215611b1057600080fd5b81516114418161188456fec0e7068c38f4dd33745694538d7c751535e23340d842d6b01b1fd58194132da4a2646970667358221220bb5e0e78f2b00f0dd82e3a47e8a633281f676dd7c22116a312e88216c1fef84664736f6c634300080d0033";
        public EnergysystemImplementationDeploymentBase() : base(BYTECODE) { }
        public EnergysystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class GetContractActiveFunction : GetContractActiveFunctionBase { }

    [Function("getContractActive", "bool")]
    public class GetContractActiveFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
    }

    public partial class GetEnergyFunction : GetEnergyFunctionBase { }

    [Function("getEnergy", "uint256")]
    public class GetEnergyFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GetEnergyEarnableFunction : GetEnergyEarnableFunctionBase { }

    [Function("getEnergyEarnable", "uint256")]
    public class GetEnergyEarnableFunctionBase : FunctionMessage
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

    public partial class GetTokenDataFunction : GetTokenDataFunctionBase { }

    [Function("getTokenData", typeof(GetTokenDataOutputDTO))]
    public class GetTokenDataFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class GiveEnergyFunction : GiveEnergyFunctionBase { }

    [Function("giveEnergy")]
    public class GiveEnergyFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class SetContractActiveFunction : SetContractActiveFunctionBase { }

    [Function("setContractActive")]
    public class SetContractActiveFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("bool", "active", 2)]
        public virtual bool Active { get; set; }
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

    public partial class SpendEnergyFunction : SpendEnergyFunctionBase { }

    [Function("spendEnergy")]
    public class SpendEnergyFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 3)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class EnergyGainedEventDTO : EnergyGainedEventDTOBase { }

    [Event("EnergyGained")]
    public class EnergyGainedEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "tokenContract", 2, true )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 4, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class EnergySpentEventDTO : EnergySpentEventDTOBase { }

    [Event("EnergySpent")]
    public class EnergySpentEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "tokenContract", 2, true )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "amount", 4, false )]
        public virtual BigInteger Amount { get; set; }
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

    public partial class AtMaxEnergyError : AtMaxEnergyErrorBase { }

    [Error("AtMaxEnergy")]
    public class AtMaxEnergyErrorBase : IErrorDTO
    {
        [Parameter("uint256", "current", 1)]
        public virtual BigInteger Current { get; set; }
        [Parameter("uint256", "max", 2)]
        public virtual BigInteger Max { get; set; }
    }



    public partial class ContractNotActiveError : ContractNotActiveErrorBase { }

    [Error("ContractNotActive")]
    public class ContractNotActiveErrorBase : IErrorDTO
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
    }

    public partial class ContractNotGameNFTError : ContractNotGameNFTErrorBase { }

    [Error("ContractNotGameNFT")]
    public class ContractNotGameNFTErrorBase : IErrorDTO
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

    public partial class NotEnoughEnergyError : NotEnoughEnergyErrorBase { }

    [Error("NotEnoughEnergy")]
    public class NotEnoughEnergyErrorBase : IErrorDTO
    {
        [Parameter("uint256", "expected", 1)]
        public virtual BigInteger Expected { get; set; }
        [Parameter("uint256", "actual", 2)]
        public virtual BigInteger Actual { get; set; }
    }



    public partial class GetContractActiveOutputDTO : GetContractActiveOutputDTOBase { }

    [FunctionOutput]
    public class GetContractActiveOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class GetEnergyOutputDTO : GetEnergyOutputDTOBase { }

    [FunctionOutput]
    public class GetEnergyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetEnergyEarnableOutputDTO : GetEnergyEarnableOutputDTOBase { }

    [FunctionOutput]
    public class GetEnergyEarnableOutputDTOBase : IFunctionOutputDTO 
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

    public partial class GetTokenDataOutputDTO : GetTokenDataOutputDTOBase { }

    [FunctionOutput]
    public class GetTokenDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "currentEnergy", 1)]
        public virtual BigInteger CurrentEnergy { get; set; }
        [Parameter("uint256", "maxEnergy", 2)]
        public virtual BigInteger MaxEnergy { get; set; }
        [Parameter("uint256", "energyRegenPerSecond", 3)]
        public virtual BigInteger EnergyRegenPerSecond { get; set; }
        [Parameter("uint256", "lastSpendTimestamp", 4)]
        public virtual BigInteger LastSpendTimestamp { get; set; }
        [Parameter("uint256", "lastEnergyAmount", 5)]
        public virtual BigInteger LastEnergyAmount { get; set; }
        [Parameter("uint256", "currentEnergyEarnable", 6)]
        public virtual BigInteger CurrentEnergyEarnable { get; set; }
        [Parameter("uint256", "lastEnergyEarnable", 7)]
        public virtual BigInteger LastEnergyEarnable { get; set; }
        [Parameter("uint256", "lastEarnTimestamp", 8)]
        public virtual BigInteger LastEarnTimestamp { get; set; }
        [Parameter("uint256", "earnableRegenPerSecond", 9)]
        public virtual BigInteger EarnableRegenPerSecond { get; set; }
        [Parameter("uint256", "maxEnergyEarnable", 10)]
        public virtual BigInteger MaxEnergyEarnable { get; set; }
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

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

namespace PirateNationContracts.EnergySystemV2_Implementation.ContractDefinition
{


    public partial class Energysystemv2ImplementationDeployment : Energysystemv2ImplementationDeploymentBase
    {
        public Energysystemv2ImplementationDeployment() : base(BYTECODE) { }
        public Energysystemv2ImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class Energysystemv2ImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506119c2806100206000396000f3fe608060405234801561001057600080fd5b50600436106101005760003560e01c806386431ebe11610097578063dd898b2f11610066578063dd898b2f14610248578063ed022ebd1461025b578063f2fde38b14610271578063fa7471101461028457600080fd5b806386431ebe146101a05780638da5cb5b146101b35780639f292d76146101d8578063c4d66de81461023557600080fd5b80635c975abb116100d35780635c975abb146101755780635d1ca6311461017d578063715018a6146101855780637b8d7de81461018d57600080fd5b806306c1cb911461010557806316c38b3c146101195780632fcccd4b1461012c578063572b6c0514610152575b600080fd5b610117610113366004611641565b5050565b005b6101176101273660046116f1565b610297565b61013f61013a366004611723565b6102b8565b6040519081526020015b60405180910390f35b61016561016036600461174f565b6102cd565b6040519015158152602001610149565b610165610314565b60985461013f565b61011761039f565b61011761019b36600461176c565b6103b3565b61013f6101ae366004611723565b610594565b6033546001600160a01b03165b6040516001600160a01b039091168152602001610149565b6101eb6101e6366004611723565b6105a0565b604080519a8b5260208b0199909952978901969096526060880194909452608087019290925260a086015260c085015260e084015261010083015261012082015261014001610149565b61011761024336600461174f565b610645565b61011761025636600461174f565b610778565b60975461010090046001600160a01b03166101c0565b61011761027f36600461174f565b6107c3565b61011761029236600461176c565b610839565b61029f610963565b80156102b0576102ad6109dc565b50565b6102ad610a79565b60006102c48383610afa565b90505b92915050565b60975460009061010090046001600160a01b0316158015906102c757506102c77fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610b8d565b60975460009060ff168061039a5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610376573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061039a91906117a1565b905090565b6103a7610963565b6103b16000610c08565b565b6103bb610c5a565b6103c3610ca2565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536103f5816103f0610cfb565b610d29565b60006104018585610dd2565b9050600061040f8686610afa565b90508115806104255750670de0b6b3a764000081105b156104435760405163333bb0df60e01b815260040160405180910390fd5b6001600160a01b03861660009081526099602090815260408083208884529091528120906104718888610f1e565b90508381106104a257604051639e725df360e01b815260048101829052602481018590526044015b60405180910390fd5b85838111156104ae5750825b808360010160008282546104c291906117d4565b909155505060018301548510156104f7578483600101546104e391906117ec565b6104ed90826117ec565b6001840186905590505b600061050382866117ec565b60028501819055905061051542610f92565b63ffffffff166003850155886001600160a01b038b16610533610cfb565b6001600160a01b03167fdf743f12a2098dc499262a777173c72af0c44c9d0751b9e456676285be18c6f68585604051610576929190918252602082015260400190565b60405180910390a45050505050505061058f6001606555565b505050565b60006102c48383610f1e565b6001600160a01b038216600090815260996020908152604080832084845290915281208190819081908190819081908190819081906105df8d8d610f1e565b9a506105eb8d8d610dd2565b99506105f78d8d611002565b985080600101549650806000015497506106118d8d610afa565b95508060020154945080600301549350610629611160565b9250610633611223565b9150509295989b9194979a5092959850565b600054610100900460ff16158080156106655750600054600160ff909116105b8061067f5750303b15801561067f575060005460ff166001145b6106e25760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b6064820152608401610499565b6000805460ff191660011790558015610705576000805461ff0019166101001790555b61072f827fdaad241cf87e359c1cee61c121d111147c0d3638669248f816e3e289aec4e8f56112d2565b8015610113576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b610780610963565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102ad5760405163a4b9148160e01b815260040160405180910390fd5b6107cb610963565b6001600160a01b0381166108305760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610499565b6102ad81610c08565b610841610c5a565b610849610ca2565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb53610876816103f0610cfb565b60006108828585610f1e565b9050828110156108af5760405163d1ace93760e01b81526004810184905260248101829052604401610499565b6001600160a01b03851660009081526099602090815260408083208784529091528120906108dd85846117ec565b6001830181905590506108ef42610f92565b63ffffffff168255856001600160a01b03881661090a610cfb565b6001600160a01b03167fab97f5db29bcb973ec77ad37e90d217566de8607d8765db0a419495a5084b604888560405161094d929190918252602082015260400190565b60405180910390a45050505061058f6001606555565b61096b610cfb565b6001600160a01b03166109866033546001600160a01b031690565b6001600160a01b0316146103b15760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610499565b60975460ff1615610a265760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610499565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610a5c610cfb565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610ac75760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610499565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610a5c610cfb565b6001600160a01b0382166000908152609960209081526040808320848452909152812081610b26611223565b90508160030154600003610b3d5791506102c79050565b6000610b47611160565b6003840154610b5690426117ec565b610b609190611803565b8360020154610b6f91906117d4565b905081811115610b83575091506102c79050565b92506102c7915050565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610be4573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102c491906117a1565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b610c62610314565b156103b15760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b6044820152606401610499565b600260655403610cf45760405162461bcd60e51b815260206004820152601f60248201527f5265656e7472616e637947756172643a207265656e7472616e742063616c6c006044820152606401610499565b6002606555565b600060143610801590610d125750610d12336102cd565b15610d24575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610d80573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610da491906117a1565b6101135760405162b0d32560e11b81526001600160a01b038216600482015260248101839052604401610499565b600080610dec60008051602061196d83398151915261135f565b604051631192054960e21b81527f8d23e28e812d175ad845aae00b4915192aab307091d3d09fc2e365df549e5ee360048201529091506000906001600160a01b03831690634648152490602401600060405180830381865afa158015610e56573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f19168201604052610e7e9190810190611822565b90506000610eab7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba61135f565b90506000610eba8288886113d2565b905080600003610ed15760009450505050506102c7565b8251811015610eff57828181518110610eec57610eec6118b3565b60200260200101519450505050506102c7565b8260018451610f0e91906117ec565b81518110610eec57610eec6118b3565b6001600160a01b0382166000908152609960209081526040808320848452909152812081610f4c8585610dd2565b8254909150600003610f615791506102c79050565b6000610f6d8686611002565b8354610f7990426117ec565b610f839190611803565b8360010154610b6f91906117d4565b600063ffffffff821115610ff75760405162461bcd60e51b815260206004820152602660248201527f53616665436173743a2076616c756520646f65736e27742066697420696e203360448201526532206269747360d01b6064820152608401610499565b5090565b6001606555565b60008061101c60008051602061196d83398151915261135f565b604051631192054960e21b81527fa39da4b9c6b77bc29b5a0869b181b3d8c590b7e1572c516dcc6b5ee24ff1220860048201529091506000906001600160a01b03831690634648152490602401600060405180830381865afa158015611086573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526110ae9190810190611822565b905060006110db7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba61135f565b905060006110ea8288886113d2565b90506000835182101561111857838281518110611109576111096118b3565b60200260200101519050611142565b836001855161112791906117ec565b81518110611137576111376118b3565b602002602001015190505b61115481670de0b6b3a76400006118c9565b98975050505050505050565b60008061117a60008051602061196d83398151915261135f565b604051631106aeeb60e21b81527f3aba2503faad59e759c7447c4626ac8e4183b9b51b37c95781413b6f44e6183860048201529091506000906001600160a01b0383169063441abbac90602401602060405180830381865afa1580156111e4573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061120891906118eb565b905061121c81670de0b6b3a76400006118c9565b9250505090565b60008061123d60008051602061196d83398151915261135f565b604051631106aeeb60e21b81527fd0f017d7e4ebc8e337dbe823d382ac51338bbc7f246aa258152efadf646a21c660048201529091506000906001600160a01b0383169063441abbac90602401602060405180830381865afa1580156112a7573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906112cb91906118eb565b9392505050565b600054610100900460ff166112f95760405162461bcd60e51b815260040161049990611904565b61130161151a565b611309611549565b60978054610100600160a81b0319166101006001600160a01b0385169081029190911790915561134c5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa1580156113ae573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102c7919061194f565b604051639b9a15b360e01b81526001600160a01b038381166004830152602482018390527fd7fe74ba2795604f471717a6182ac81070ad95ecee0b7d8ebcfbec785af7e796604483015260009190851690639b9a15b390606401602060405180830381865afa158015611449573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061146d91906117a1565b1561151057604051630b3f2a6360e01b81526001600160a01b038481166004830152602482018490527fd7fe74ba2795604f471717a6182ac81070ad95ecee0b7d8ebcfbec785af7e7966044830152851690630b3f2a6390606401602060405180830381865afa1580156114e5573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061150991906118eb565b90506112cb565b5060009392505050565b600054610100900460ff166115415760405162461bcd60e51b815260040161049990611904565b6103b1611578565b600054610100900460ff166115705760405162461bcd60e51b815260040161049990611904565b6103b16115af565b600054610100900460ff1661159f5760405162461bcd60e51b815260040161049990611904565b6103b16115aa610cfb565b610c08565b600054610100900460ff16610ffb5760405162461bcd60e51b815260040161049990611904565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff81118282101715611615576116156115d6565b604052919050565b600067ffffffffffffffff821115611637576116376115d6565b5060051b60200190565b6000806040838503121561165457600080fd5b8235915060208084013567ffffffffffffffff81111561167357600080fd5b8401601f8101861361168457600080fd5b80356116976116928261161d565b6115ec565b81815260059190911b820183019083810190888311156116b657600080fd5b928401925b828410156116d4578335825292840192908401906116bb565b80955050505050509250929050565b80151581146102ad57600080fd5b60006020828403121561170357600080fd5b81356112cb816116e3565b6001600160a01b03811681146102ad57600080fd5b6000806040838503121561173657600080fd5b82356117418161170e565b946020939093013593505050565b60006020828403121561176157600080fd5b81356112cb8161170e565b60008060006060848603121561178157600080fd5b833561178c8161170e565b95602085013595506040909401359392505050565b6000602082840312156117b357600080fd5b81516112cb816116e3565b634e487b7160e01b600052601160045260246000fd5b600082198211156117e7576117e76117be565b500190565b6000828210156117fe576117fe6117be565b500390565b600081600019048311821515161561181d5761181d6117be565b500290565b6000602080838503121561183557600080fd5b825167ffffffffffffffff81111561184c57600080fd5b8301601f8101851361185d57600080fd5b805161186b6116928261161d565b81815260059190911b8201830190838101908783111561188a57600080fd5b928401925b828410156118a85783518252928401929084019061188f565b979650505050505050565b634e487b7160e01b600052603260045260246000fd5b6000826118e657634e487b7160e01b600052601260045260246000fd5b500490565b6000602082840312156118fd57600080fd5b5051919050565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b60006020828403121561196157600080fd5b81516112cb8161170e56fec0e7068c38f4dd33745694538d7c751535e23340d842d6b01b1fd58194132da4a26469706673582212205f445a8151715d4844b56f9ba8911b9f90674b5a19c000083689e26076b3996b64736f6c634300080d0033";
        public Energysystemv2ImplementationDeploymentBase() : base(BYTECODE) { }
        public Energysystemv2ImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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
        [Parameter("uint256", "amountGained", 4, false )]
        public virtual BigInteger AmountGained { get; set; }
        [Parameter("uint256", "lastEnergyEarnable", 5, false )]
        public virtual BigInteger LastEnergyEarnable { get; set; }
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
        [Parameter("uint256", "amountSpent", 4, false )]
        public virtual BigInteger AmountSpent { get; set; }
        [Parameter("uint256", "lastEnergyAmount", 5, false )]
        public virtual BigInteger LastEnergyAmount { get; set; }
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

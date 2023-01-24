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
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50611b79806100206000396000f3fe608060405234801561001057600080fd5b50600436106101215760003560e01c80637b8d7de8116100ad578063dd898b2f11610071578063dd898b2f1461026d578063dfc06a4214610280578063ed022ebd146102ac578063f2fde38b146102c2578063fa747110146102d557600080fd5b80637b8d7de8146101fc57806386431ebe1461020f5780638da5cb5b146102225780639f292d7614610247578063c4d66de81461025a57600080fd5b806331dfa414116100f457806331dfa41414610186578063572b6c05146101c15780635c975abb146101e45780635d1ca631146101ec578063715018a6146101f457600080fd5b806306c1cb911461012657806316c38b3c1461013a57806325d313601461014d5780632fcccd4b14610160575b600080fd5b6101386101343660046117bf565b5050565b005b61013861014836600461186f565b6102e8565b61013861015b3660046118a1565b610309565b61017361016e3660046118da565b6103c3565b6040519081526020015b60405180910390f35b6101996101943660046118da565b6103d8565b604080519586526020860194909452928401919091526060830152608082015260a00161017d565b6101d46101cf366004611906565b61043a565b604051901515815260200161017d565b6101d4610481565b609854610173565b61013861050c565b61013861020a366004611923565b610520565b61017361021d3660046118da565b610737565b6033546001600160a01b03165b6040516001600160a01b03909116815260200161017d565b6101996102553660046118da565b610743565b610138610268366004611906565b6107a5565b61013861027b366004611906565b6108d8565b6101d461028e366004611906565b6001600160a01b031660009081526099602052604090205460ff1690565b60975461010090046001600160a01b031661022f565b6101386102d0366004611906565b610923565b6101386102e3366004611923565b610999565b6102f0610afd565b8015610301576102fe610b76565b50565b6102fe610c13565b7f241ecf16d79d0f8dbfb92cbc07fe17840425976cf0667f022fe9877caa831b0861033b81610336610c90565b610cbe565b6103657f5a0afddc7ecb0deaa549d40e18566f1c87c8ed09187b6915eaf44079f37e2aca84610d67565b15156000036103975760405163648194a960e11b81526001600160a01b03841660048201526024015b60405180910390fd5b506001600160a01b03919091166000908152609960205260409020805460ff1916911515919091179055565b60006103cf8383610de2565b90505b92915050565b6001600160a01b0382166000908152609b602090815260408083208484529091528120819081908190819061040d8888610de2565b8154600183015491975095509350610423610e72565b925061042d610f35565b9150509295509295909350565b60975460009061010090046001600160a01b0316158015906103d257506103d27fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610d67565b60975460009060ff16806105075750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156104e3573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105079190611958565b905090565b610514610afd565b61051e6000610fe4565b565b610528611036565b61053061107e565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb5361055d81610336610c90565b6001600160a01b03841660009081526099602052604090205460ff1615156001146105a65760405163075b77c560e01b81526001600160a01b038516600482015260240161038e565b60006105b28585610de2565b9050670de0b6b3a76400008110156105dd5760405163333bb0df60e01b815260040160405180910390fd5b6001600160a01b0385166000818152609a602090815260408083208884528252808320938352609b825280832088845290915281209061061d88886110d7565b9050600061062b898961114b565b905080821061065757604051639e725df360e01b8152600481018390526024810182905260440161038e565b86858111156106635750845b80856001016000828254610677919061198b565b909155505060018501548210156106ac5781856001015461069891906119a3565b6106a290826119a3565b6001860183905590505b6106b681876119a3565b84556106c142611282565b63ffffffff166001850155886001600160a01b038b166106df610c90565b6001600160a01b03167f973accd24a7590b0d9d69bf724e4fcae3ec69659ed10b2616816fd19bbd2e49a8b60405161071991815260200190565b60405180910390a4505050505050506107326001606555565b505050565b60006103cf83836110d7565b6001600160a01b0382166000908152609a602090815260408083208484529091528120819081908190819061077888886110d7565b9550610784888861114b565b945061079088886112f2565b60018201549154969995985096509392505050565b600054610100900460ff16158080156107c55750600054600160ff909116105b806107df5750303b1580156107df575060005460ff166001145b6108425760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b606482015260840161038e565b6000805460ff191660011790558015610865576000805461ff0019166101001790555b61088f827fdaad241cf87e359c1cee61c121d111147c0d3638669248f816e3e289aec4e8f5611450565b8015610134576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6108e0610afd565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102fe5760405163a4b9148160e01b815260040160405180910390fd5b61092b610afd565b6001600160a01b0381166109905760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b606482015260840161038e565b6102fe81610fe4565b6109a1611036565b6109a961107e565b7fd3dc2a3a14cbd0cdbf3069fc3927e48506f271b9dda2c21625b93e6a99d3eb536109d681610336610c90565b60006109e285856110d7565b905082811015610a0f5760405163d1ace93760e01b8152600481018490526024810182905260440161038e565b6001600160a01b03851660009081526099602052604090205460ff161515600114610a585760405163075b77c560e01b81526001600160a01b038616600482015260240161038e565b6001600160a01b0385166000908152609a602090815260408083208784529091529020610a8584836119a3565b6001820155610a9342611282565b63ffffffff168155846001600160a01b038716610aae610c90565b6001600160a01b03167feeb026bbab10fcfc225534cf0df1480cfdf3ade29fe5265ae68db0e023bcebf287604051610ae891815260200190565b60405180910390a45050506107326001606555565b610b05610c90565b6001600160a01b0316610b206033546001600160a01b031690565b6001600160a01b03161461051e5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604482015260640161038e565b60975460ff1615610bc05760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161038e565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610bf6610c90565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610c615760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161038e565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610bf65b600060143610801590610ca75750610ca73361043a565b15610cb9575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610d15573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610d399190611958565b6101345760405162b0d32560e11b81526001600160a01b03821660048201526024810183905260440161038e565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610dbe573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103cf9190611958565b6001600160a01b0382166000908152609b60209081526040808320848452909152812081610e0e610f35565b90508160010154600003610e255791506103d29050565b6000610e2f610e72565b6001840154610e3e90426119a3565b610e4891906119ba565b8354610e54919061198b565b905081811115610e68575091506103d29050565b92506103d2915050565b600080610e8c600080516020611b248339815191526114dd565b604051631106aeeb60e21b81527f3aba2503faad59e759c7447c4626ac8e4183b9b51b37c95781413b6f44e6183860048201529091506000906001600160a01b0383169063441abbac90602401602060405180830381865afa158015610ef6573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610f1a91906119d9565b9050610f2e81670de0b6b3a76400006119f2565b9250505090565b600080610f4f600080516020611b248339815191526114dd565b604051631106aeeb60e21b81527fd0f017d7e4ebc8e337dbe823d382ac51338bbc7f246aa258152efadf646a21c660048201529091506000906001600160a01b0383169063441abbac90602401602060405180830381865afa158015610fb9573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610fdd91906119d9565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b61103e610481565b1561051e5760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b604482015260640161038e565b6002606554036110d05760405162461bcd60e51b815260206004820152601f60248201527f5265656e7472616e637947756172643a207265656e7472616e742063616c6c00604482015260640161038e565b6002606555565b6001600160a01b0382166000908152609a60209081526040808320848452909152812081611105858561114b565b825490915060000361111a5791506103d29050565b600061112686866112f2565b835461113290426119a3565b61113c91906119ba565b8360010154610e54919061198b565b600080611165600080516020611b248339815191526114dd565b604051631192054960e21b81527f8d23e28e812d175ad845aae00b4915192aab307091d3d09fc2e365df549e5ee360048201529091506000906001600160a01b03831690634648152490602401600060405180830381865afa1580156111cf573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f191682016040526111f79190810190611a14565b905060006112247f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba6114dd565b90506000611233828888611550565b905082518110156112635782818151811061125057611250611aa5565b60200260200101519450505050506103d2565b826001845161127291906119a3565b8151811061125057611250611aa5565b600063ffffffff8211156112e75760405162461bcd60e51b815260206004820152602660248201527f53616665436173743a2076616c756520646f65736e27742066697420696e203360448201526532206269747360d01b606482015260840161038e565b5090565b6001606555565b60008061130c600080516020611b248339815191526114dd565b604051631192054960e21b81527fb590bf31a141074a90164f11f3321fd5f9b9393322df495ab0d17a44da7d8e6860048201529091506000906001600160a01b03831690634648152490602401600060405180830381865afa158015611376573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f1916820160405261139e9190810190611a14565b905060006113cb7f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba6114dd565b905060006113da828888611550565b905060008351821015611408578382815181106113f9576113f9611aa5565b60200260200101519050611432565b836001855161141791906119a3565b8151811061142757611427611aa5565b602002602001015190505b61144481670de0b6b3a76400006119f2565b98975050505050505050565b600054610100900460ff166114775760405162461bcd60e51b815260040161038e90611abb565b61147f611698565b6114876116c7565b60978054610100600160a81b0319166101006001600160a01b038516908102919091179091556114ca5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa15801561152c573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103d29190611b06565b604051639b9a15b360e01b81526001600160a01b038381166004830152602482018390527fd7fe74ba2795604f471717a6182ac81070ad95ecee0b7d8ebcfbec785af7e796604483015260009190851690639b9a15b390606401602060405180830381865afa1580156115c7573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906115eb9190611958565b1561168e57604051630b3f2a6360e01b81526001600160a01b038481166004830152602482018490527fd7fe74ba2795604f471717a6182ac81070ad95ecee0b7d8ebcfbec785af7e7966044830152851690630b3f2a6390606401602060405180830381865afa158015611663573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061168791906119d9565b9050610fdd565b5060009392505050565b600054610100900460ff166116bf5760405162461bcd60e51b815260040161038e90611abb565b61051e6116f6565b600054610100900460ff166116ee5760405162461bcd60e51b815260040161038e90611abb565b61051e61172d565b600054610100900460ff1661171d5760405162461bcd60e51b815260040161038e90611abb565b61051e611728610c90565b610fe4565b600054610100900460ff166112eb5760405162461bcd60e51b815260040161038e90611abb565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff8111828210171561179357611793611754565b604052919050565b600067ffffffffffffffff8211156117b5576117b5611754565b5060051b60200190565b600080604083850312156117d257600080fd5b8235915060208084013567ffffffffffffffff8111156117f157600080fd5b8401601f8101861361180257600080fd5b80356118156118108261179b565b61176a565b81815260059190911b8201830190838101908883111561183457600080fd5b928401925b8284101561185257833582529284019290840190611839565b80955050505050509250929050565b80151581146102fe57600080fd5b60006020828403121561188157600080fd5b8135610fdd81611861565b6001600160a01b03811681146102fe57600080fd5b600080604083850312156118b457600080fd5b82356118bf8161188c565b915060208301356118cf81611861565b809150509250929050565b600080604083850312156118ed57600080fd5b82356118f88161188c565b946020939093013593505050565b60006020828403121561191857600080fd5b8135610fdd8161188c565b60008060006060848603121561193857600080fd5b83356119438161188c565b95602085013595506040909401359392505050565b60006020828403121561196a57600080fd5b8151610fdd81611861565b634e487b7160e01b600052601160045260246000fd5b6000821982111561199e5761199e611975565b500190565b6000828210156119b5576119b5611975565b500390565b60008160001904831182151516156119d4576119d4611975565b500290565b6000602082840312156119eb57600080fd5b5051919050565b600082611a0f57634e487b7160e01b600052601260045260246000fd5b500490565b60006020808385031215611a2757600080fd5b825167ffffffffffffffff811115611a3e57600080fd5b8301601f81018513611a4f57600080fd5b8051611a5d6118108261179b565b81815260059190911b82018301908381019087831115611a7c57600080fd5b928401925b82841015611a9a57835182529284019290840190611a81565b979650505050505050565b634e487b7160e01b600052603260045260246000fd5b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b600060208284031215611b1857600080fd5b8151610fdd8161188c56fec0e7068c38f4dd33745694538d7c751535e23340d842d6b01b1fd58194132da4a2646970667358221220a2c13ce7b94226706da12c3f4f4106553e85371a6f82e3a67e070dbd67e6076964736f6c634300080d0033";
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

    public partial class GetEarnableDataFunction : GetEarnableDataFunctionBase { }

    [Function("getEarnableData", typeof(GetEarnableDataOutputDTO))]
    public class GetEarnableDataFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class GetEarnableDataOutputDTO : GetEarnableDataOutputDTOBase { }

    [FunctionOutput]
    public class GetEarnableDataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "currentEnergyEarnable", 1)]
        public virtual BigInteger CurrentEnergyEarnable { get; set; }
        [Parameter("uint256", "lastEnergyEarnable", 2)]
        public virtual BigInteger LastEnergyEarnable { get; set; }
        [Parameter("uint256", "lastEarnTimestamp", 3)]
        public virtual BigInteger LastEarnTimestamp { get; set; }
        [Parameter("uint256", "earnableRegenPerSecond", 4)]
        public virtual BigInteger EarnableRegenPerSecond { get; set; }
        [Parameter("uint256", "maxEnergyEarnable", 5)]
        public virtual BigInteger MaxEnergyEarnable { get; set; }
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

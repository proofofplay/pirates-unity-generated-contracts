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

namespace PirateNationContracts.BossSpawn_Implementation.ContractDefinition
{


    public partial class BossspawnImplementationDeployment : BossspawnImplementationDeploymentBase
    {
        public BossspawnImplementationDeployment() : base(BYTECODE) { }
        public BossspawnImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class BossspawnImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610fbd806100206000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c80638da5cb5b116100715780638da5cb5b14610129578063c4d66de81461014e578063d3f725b614610161578063dd898b2f14610174578063ed022ebd14610187578063f2fde38b1461019d57600080fd5b806306c1cb91146100b957806316c38b3c146100cd578063572b6c05146100e05780635c975abb146101085780635d1ca63114610110578063715018a614610121575b600080fd5b6100cb6100c7366004610da9565b5050565b005b6100cb6100db366004610e81565b6101b0565b6100f36100ee366004610eb3565b6101d1565b60405190151581526020015b60405180910390f35b6100f361021e565b6098546040519081526020016100ff565b6100cb6102a9565b6033546001600160a01b03165b6040516001600160a01b0390911681526020016100ff565b6100cb61015c366004610eb3565b6102bd565b6100cb61016f366004610ed0565b6103f5565b6100cb610182366004610eb3565b61074c565b60975461010090046001600160a01b0316610136565b6100cb6101ab366004610eb3565b610797565b6101b861080d565b80156101c9576101c6610886565b50565b6101c6610923565b60975460009061010090046001600160a01b03161580159061021857506102187fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d2836109a4565b92915050565b60975460009060ff16806102a45750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610280573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102a49190610ee9565b905090565b6102b161080d565b6102bb6000610a26565b565b600054610100900460ff16158080156102dd5750600054600160ff909116105b806102f75750303b1580156102f7575060005460ff166001145b61035f5760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610382576000805461ff0019166101001790555b6103ac827f249f0029b58f324a3bcbecb56b6a93c463fbd1b75602a5aa9668226882f72545610a78565b80156100c7576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b7f9f2df0fed2c77648de5860a4cc508cd0818c85b8b8a1ab4ceeef8d981c8956a661042781610422610b05565b610b33565b60006104527f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610bdc565b604051634f558e7960e01b8152600481018590529091506001600160a01b03821690634f558e7990602401602060405180830381865afa15801561049a573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906104be9190610ee9565b6104de576040516315b32c8b60e01b815260048101849052602401610356565b60405163fb5b859760e01b815230600482015260248101849052604481018490526001600160a01b0382169063fb5b859790606401600060405180830381600087803b15801561052d57600080fd5b505af1158015610541573d6000803e3d6000fd5b5050604051639b9a15b360e01b8152306004820152602481018690527ff534f3513839a03dbb1fc9c3b8eb61febdadaec4faa64d5567e64ec1eee074b860448201526001600160a01b0384169250639b9a15b39150606401602060405180830381865afa1580156105b6573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105da9190610ee9565b15156000036105ff576040516315b32c8b60e01b815260048101849052602401610356565b604051632218394360e11b8152306004820152602481018490527f9005b4bf3e8c5705ff2b172ed7c0ff76f0096efed0943457e640b66da01b97d260448201526000906001600160a01b03831690634430728690606401602060405180830381865afa158015610673573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906106979190610f06565b90506106a1610c4f565b6001600160a01b0316637d4ec3b330867f0800a4644d961a76e563e14ed4e1c1a13617cefd5c4c7ab3dc25232976c4d7a66106db86610c7a565b6040516001600160e01b031960e087901b1681526001600160a01b039094166004850152602484019290925260448301526064820152608401600060405180830381600087803b15801561072e57600080fd5b505af1158015610742573d6000803e3d6000fd5b5050505050505050565b61075461080d565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556101c65760405163a4b9148160e01b815260040160405180910390fd5b61079f61080d565b6001600160a01b0381166108045760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610356565b6101c681610a26565b610815610b05565b6001600160a01b03166108306033546001600160a01b031690565b6001600160a01b0316146102bb5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610356565b60975460ff16156108d05760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610356565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610906610b05565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146109715760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610356565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610906610b05565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa1580156109fb573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610a1f9190610ee9565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600054610100900460ff16610a9f5760405162461bcd60e51b815260040161035690610f1f565b610aa7610cd0565b610aaf610cff565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610af25760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600060143610801590610b1c5750610b1c336101d1565b15610b2e575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610b8a573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610bae9190610ee9565b6100c75760405162b0d32560e11b81526001600160a01b038216600482015260248101839052604401610356565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610c2b573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102189190610f6a565b60006102a47f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610bdc565b600080821215610ccc5760405162461bcd60e51b815260206004820181905260248201527f53616665436173743a2076616c7565206d75737420626520706f7369746976656044820152606401610356565b5090565b600054610100900460ff16610cf75760405162461bcd60e51b815260040161035690610f1f565b6102bb610d2e565b600054610100900460ff16610d265760405162461bcd60e51b815260040161035690610f1f565b6102bb610d65565b600054610100900460ff16610d555760405162461bcd60e51b815260040161035690610f1f565b6102bb610d60610b05565b610a26565b600054610100900460ff16610d8c5760405162461bcd60e51b815260040161035690610f1f565b6001606555565b634e487b7160e01b600052604160045260246000fd5b60008060408385031215610dbc57600080fd5b8235915060208084013567ffffffffffffffff80821115610ddc57600080fd5b818601915086601f830112610df057600080fd5b813581811115610e0257610e02610d93565b8060051b604051601f19603f83011681018181108582111715610e2757610e27610d93565b604052918252848201925083810185019189831115610e4557600080fd5b938501935b82851015610e6357843584529385019392850192610e4a565b8096505050505050509250929050565b80151581146101c657600080fd5b600060208284031215610e9357600080fd5b8135610a1f81610e73565b6001600160a01b03811681146101c657600080fd5b600060208284031215610ec557600080fd5b8135610a1f81610e9e565b600060208284031215610ee257600080fd5b5035919050565b600060208284031215610efb57600080fd5b8151610a1f81610e73565b600060208284031215610f1857600080fd5b5051919050565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b606082015260800190565b600060208284031215610f7c57600080fd5b8151610a1f81610e9e56fea2646970667358221220b85539f9044097b6a3a5b2dc68d451989820b1ef0c4618452ff1354120980b0364736f6c634300080d0033";
        public BossspawnImplementationDeploymentBase() : base(BYTECODE) { }
        public BossspawnImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class SpawnBossFunction : SpawnBossFunctionBase { }

    [Function("spawnBoss")]
    public class SpawnBossFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "templateId", 1)]
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

    public partial class InvalidBossError : InvalidBossErrorBase { }

    [Error("InvalidBoss")]
    public class InvalidBossErrorBase : IErrorDTO
    {
        [Parameter("uint256", "templateId", 1)]
        public virtual BigInteger TemplateId { get; set; }
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










}

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

namespace PirateNationContracts.AchievementSystem_Implementation.ContractDefinition
{


    public partial class AchievementsystemImplementationDeployment : AchievementsystemImplementationDeploymentBase
    {
        public AchievementsystemImplementationDeployment() : base(BYTECODE) { }
        public AchievementsystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class AchievementsystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610e5f806100206000396000f3fe608060405234801561001057600080fd5b50600436106100cf5760003560e01c8063715018a61161008c578063c4d66de811610066578063c4d66de81461018b578063dd898b2f1461019e578063ed022ebd146101b1578063f2fde38b146101c757600080fd5b8063715018a61461014b5780638da5cb5b146101535780639907019c1461017857600080fd5b806306c1cb91146100d4578063077b2c72146100e857806316c38b3c14610105578063572b6c05146101185780635c975abb1461013b5780635d1ca63114610143575b600080fd5b6100e66100e2366004610c51565b5050565b005b6099546100f29081565b6040519081526020015b60405180910390f35b6100e6610113366004610d29565b6101da565b61012b610126366004610d5b565b6101fb565b60405190151581526020016100fc565b61012b610248565b6098546100f2565b6100e66102d3565b6033546001600160a01b03165b6040516001600160a01b0390911681526020016100fc565b6100e6610186366004610d78565b6102e7565b6100e6610199366004610d5b565b6104fa565b6100e66101ac366004610d5b565b61062d565b60975461010090046001600160a01b0316610160565b6100e66101d5366004610d5b565b610678565b6101e26106ee565b80156101f3576101f0610767565b50565b6101f0610804565b60975460009061010090046001600160a01b03161580159061024257506102427fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610885565b92915050565b60975460009060ff16806102ce5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa1580156102aa573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102ce9190610da4565b905090565b6102db6106ee565b6102e56000610907565b565b7f241ecf16d79d0f8dbfb92cbc07fe17840425976cf0667f022fe9877caa831b0861031981610314610959565b610987565b610321610a30565b600061034c7f2c2d40eeff1f4f25f4f661cf77c17af6d4eb58cd3b12f5d111b212823463a9a4610a78565b905060006103797f1394d23be0cf5885e168405ae63ff5950957f68642f89ac0163e136664a31005610a78565b604051634f558e7960e01b8152600481018690529091506001600160a01b03821690634f558e7990602401602060405180830381865afa1580156103c1573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103e59190610da4565b61040a57604051633a1c10e360e11b8152600481018590526024015b60405180910390fd5b610418609980546001019055565b600061042360995490565b6040516340c10f1960e01b81526001600160a01b03888116600483015260248201839052919250908416906340c10f1990604401600060405180830381600087803b15801561047157600080fd5b505af1158015610485573d6000803e3d6000fd5b505060405163fb5b859760e01b81526001600160a01b03868116600483015260248201859052604482018990528516925063fb5b85979150606401600060405180830381600087803b1580156104da57600080fd5b505af11580156104ee573d6000803e3d6000fd5b50505050505050505050565b600054610100900460ff161580801561051a5750600054600160ff909116105b806105345750303b158015610534575060005460ff166001145b6105975760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b6064820152608401610401565b6000805460ff1916600117905580156105ba576000805461ff0019166101001790555b6105e4827fd1b5c08000d068b85d2d4469d042708b01d6a4f2ff07656a1a46165db9ff3880610aeb565b80156100e2576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6106356106ee565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556101f05760405163a4b9148160e01b815260040160405180910390fd5b6106806106ee565b6001600160a01b0381166106e55760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610401565b6101f081610907565b6106f6610959565b6001600160a01b03166107116033546001600160a01b031690565b6001600160a01b0316146102e55760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610401565b60975460ff16156107b15760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610401565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a2586107e7610959565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146108525760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610401565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa6107e7610959565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa1580156108dc573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906109009190610da4565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6000601436108015906109705750610970336101fb565b15610982575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa1580156109de573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610a029190610da4565b6100e25760405162b0d32560e11b81526001600160a01b038216600482015260248101839052604401610401565b610a38610248565b156102e55760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b6044820152606401610401565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610ac7573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102429190610dc1565b600054610100900460ff16610b125760405162461bcd60e51b815260040161040190610dde565b610b1a610b78565b610b22610ba7565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610b655760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600054610100900460ff16610b9f5760405162461bcd60e51b815260040161040190610dde565b6102e5610bd6565b600054610100900460ff16610bce5760405162461bcd60e51b815260040161040190610dde565b6102e5610c0d565b600054610100900460ff16610bfd5760405162461bcd60e51b815260040161040190610dde565b6102e5610c08610959565b610907565b600054610100900460ff16610c345760405162461bcd60e51b815260040161040190610dde565b6001606555565b634e487b7160e01b600052604160045260246000fd5b60008060408385031215610c6457600080fd5b8235915060208084013567ffffffffffffffff80821115610c8457600080fd5b818601915086601f830112610c9857600080fd5b813581811115610caa57610caa610c3b565b8060051b604051601f19603f83011681018181108582111715610ccf57610ccf610c3b565b604052918252848201925083810185019189831115610ced57600080fd5b938501935b82851015610d0b57843584529385019392850192610cf2565b8096505050505050509250929050565b80151581146101f057600080fd5b600060208284031215610d3b57600080fd5b813561090081610d1b565b6001600160a01b03811681146101f057600080fd5b600060208284031215610d6d57600080fd5b813561090081610d46565b60008060408385031215610d8b57600080fd5b8235610d9681610d46565b946020939093013593505050565b600060208284031215610db657600080fd5b815161090081610d1b565b600060208284031215610dd357600080fd5b815161090081610d46565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea2646970667358221220ecf7ca8a9df4185a0f30672a99837da9fc3e4a5e2089a2047ceaacea1e65aede64736f6c634300080d0033";
        public AchievementsystemImplementationDeploymentBase() : base(BYTECODE) { }
        public AchievementsystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AchievementsIssuedFunction : AchievementsIssuedFunctionBase { }

    [Function("achievementsIssued", "uint256")]
    public class AchievementsIssuedFunctionBase : FunctionMessage
    {

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

    public partial class GrantAchievementFunction : GrantAchievementFunctionBase { }

    [Function("grantAchievement")]
    public class GrantAchievementFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "templateId", 2)]
        public virtual BigInteger TemplateId { get; set; }
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



    public partial class InvalidTemplateIdError : InvalidTemplateIdErrorBase { }

    [Error("InvalidTemplateId")]
    public class InvalidTemplateIdErrorBase : IErrorDTO
    {
        [Parameter("uint256", "missingTemplateId", 1)]
        public virtual BigInteger MissingTemplateId { get; set; }
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

    public partial class AchievementsIssuedOutputDTO : AchievementsIssuedOutputDTOBase { }

    [FunctionOutput]
    public class AchievementsIssuedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "_value", 1)]
        public virtual BigInteger Value { get; set; }
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

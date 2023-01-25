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

namespace PirateNationContracts.CaptainSystem_Implementation.ContractDefinition
{


    public partial class CaptainsystemImplementationDeployment : CaptainsystemImplementationDeploymentBase
    {
        public CaptainsystemImplementationDeployment() : base(BYTECODE) { }
        public CaptainsystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class CaptainsystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506112e2806100206000396000f3fe608060405234801561001057600080fd5b50600436106100ea5760003560e01c8063a729663d1161008c578063dd898b2f11610066578063dd898b2f14610214578063ed022ebd14610227578063f09cf0b71461023d578063f2fde38b1461025057600080fd5b8063a729663d14610185578063c2e187a5146101ae578063c4d66de81461020157600080fd5b80635c975abb116100c85780635c975abb1461013e5780635d1ca63114610146578063715018a6146101585780638da5cb5b1461016057600080fd5b806306c1cb91146100ef57806316c38b3c14610103578063572b6c0514610116575b600080fd5b6101016100fd366004611070565b5050565b005b610101610111366004611148565b610263565b61012961012436600461117a565b610284565b60405190151581526020015b60405180910390f35b6101296102d1565b6098545b604051908152602001610135565b61010161035c565b6033546001600160a01b03165b6040516001600160a01b039091168152602001610135565b61014a61019336600461117a565b6001600160a01b03166000908152609a602052604090205490565b6101e26101bc36600461117a565b6001600160a01b0390811660009081526099602052604090208054600190910154911691565b604080516001600160a01b039093168352602083019190915201610135565b61010161020f36600461117a565b610370565b61010161022236600461117a565b6104a8565b60975461010090046001600160a01b031661016d565b61010161024b366004611197565b6104f3565b61010161025e36600461117a565b61094a565b61026b6109c0565b801561027c57610279610a39565b50565b610279610ad6565b60975460009061010090046001600160a01b0316158015906102cb57506102cb7fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610b57565b92915050565b60975460009060ff16806103575750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610333573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061035791906111c3565b905090565b6103646109c0565b61036e6000610bd9565b565b600054610100900460ff16158080156103905750600054600160ff909116105b806103aa5750303b1580156103aa575060005460ff166001145b6104125760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610435576000805461ff0019166101001790555b61045f827f836fcb5bd6072516b89e7dbd42daa3e4d37328276bcb1e88ea4a844bdf84c090610c2b565b80156100fd576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b6104b06109c0565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556102795760405163a4b9148160e01b815260040160405180910390fd5b6104fb610cb8565b610503610d00565b6000610515610510610d59565b610d87565b905060006105427fc0e7068c38f4dd33745694538d7c751535e23340d842d6b01b1fd58194132da4610dfc565b604051631106aeeb60e21b81527ff4b0b2b4231c761c6d2572a43d0186b68acdc7c620093d1fa6e235097a1d75b260048201529091506001600160a01b0382169063441abbac90602401602060405180830381865afa1580156105a9573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105cd91906111e0565b6001600160a01b0383166000908152609a60205260409020546105f090426111f9565b101561060f57604051631c2348b760e11b815260040160405180910390fd5b6001600160a01b038216600090815260996020526040812090610630610e33565b600283015490915063ffffffff16156106ce57815460018301546002840154604051633161c00d60e01b81526001600160a01b039384166004820152602481019290925263ffffffff16604482015290821690633161c00d90606401600060405180830381600087803b1580156106a657600080fd5b505af11580156106ba573d6000803e3d6000fd5b50505060028301805463ffffffff19169055505b6001600160a01b038616156108e05760006107087f01f158cde3348caf657c186dba8f4f8ad98b974273df8754bfbbcf30386dabba610dfc565b9050610715818888610ec5565b151560011461073757604051630711f0af60e21b815260040160405180910390fd5b6040516331a9108f60e11b8152600481018790526001600160a01b038087169190891690636352211e90602401602060405180830381865afa158015610781573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906107a5919061121e565b6001600160a01b0316146107cc576040516330cd747160e01b815260040160405180910390fd5b82546001600160a01b0319166001600160a01b038881169182178555600185018890556040516338ddbe6160e21b8152600481019290925260248201889052600060448301819052606483015283169063e376f984906084016020604051808303816000875af1158015610844573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610868919061123b565b60028401805463ffffffff191663ffffffff9290921691909117905560405186906001600160a01b0389811691908816907f78a4b9a3bfd8ca7f178f1b6514eb2ea7b855a9f4d02ca70f3171251b863a60af90600090a4506001600160a01b0384166000908152609a6020526040902042905561093c565b81546001600160a01b031916825560006001830181905560028301805463ffffffff1916905560405181906001600160a01b038716907f78a4b9a3bfd8ca7f178f1b6514eb2ea7b855a9f4d02ca70f3171251b863a60af908390a45b505050506100fd6001606555565b6109526109c0565b6001600160a01b0381166109b75760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b6064820152608401610409565b61027981610bd9565b6109c8610d59565b6001600160a01b03166109e36033546001600160a01b031690565b6001600160a01b03161461036e5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e65726044820152606401610409565b60975460ff1615610a835760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610409565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a258610ab9610d59565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610b245760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b6044820152606401610409565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa610ab9610d59565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610bae573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610bd291906111c3565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600054610100900460ff16610c525760405162461bcd60e51b815260040161040990611261565b610c5a610f9e565b610c62610fcd565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610ca55760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b610cc06102d1565b1561036e5760405162461bcd60e51b815260206004820152601060248201526f14185d5cd8589b194e881c185d5cd95960821b6044820152606401610409565b600260655403610d525760405162461bcd60e51b815260206004820152601f60248201527f5265656e7472616e637947756172643a207265656e7472616e742063616c6c006044820152606401610409565b6002606555565b600060143610801590610d705750610d7033610284565b15610d82575060131936013560601c90565b503390565b6097546040516393f7cc9960e01b81526001600160a01b038381166004830152600092610100900416906393f7cc99906024015b602060405180830381865afa158015610dd8573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102cb919061121e565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401610dbb565b6097546040516329f20e0f60e11b81527f014f6fb700e688e304b410f81545ae2d4da13a493bf857fd2bf0f97da00bf997600482015260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa158015610ea1573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610357919061121e565b6000610ef17f5a0afddc7ecb0deaa549d40e18566f1c87c8ed09187b6915eaf44079f37e2aca84610b57565b8015610f8f5750604051639b9a15b360e01b81526001600160a01b038481166004830152602482018490527f96cec73f5a3b78b0c240a9a3c0dc2911cf853e4207c62a392f49e54a8606a0036044830152851690639b9a15b390606401602060405180830381865afa158015610f6b573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610f8f91906111c3565b949350505050565b6001606555565b600054610100900460ff16610fc55760405162461bcd60e51b815260040161040990611261565b61036e610ffc565b600054610100900460ff16610ff45760405162461bcd60e51b815260040161040990611261565b61036e611033565b600054610100900460ff166110235760405162461bcd60e51b815260040161040990611261565b61036e61102e610d59565b610bd9565b600054610100900460ff16610f975760405162461bcd60e51b815260040161040990611261565b634e487b7160e01b600052604160045260246000fd5b6000806040838503121561108357600080fd5b8235915060208084013567ffffffffffffffff808211156110a357600080fd5b818601915086601f8301126110b757600080fd5b8135818111156110c9576110c961105a565b8060051b604051601f19603f830116810181811085821117156110ee576110ee61105a565b60405291825284820192508381018501918983111561110c57600080fd5b938501935b8285101561112a57843584529385019392850192611111565b8096505050505050509250929050565b801515811461027957600080fd5b60006020828403121561115a57600080fd5b8135610bd28161113a565b6001600160a01b038116811461027957600080fd5b60006020828403121561118c57600080fd5b8135610bd281611165565b600080604083850312156111aa57600080fd5b82356111b581611165565b946020939093013593505050565b6000602082840312156111d557600080fd5b8151610bd28161113a565b6000602082840312156111f257600080fd5b5051919050565b60008282101561121957634e487b7160e01b600052601160045260246000fd5b500390565b60006020828403121561123057600080fd5b8151610bd281611165565b60006020828403121561124d57600080fd5b815163ffffffff81168114610bd257600080fd5b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea26469706673582212204ac0a6841fe16356e00cafb7dd14eb48c28f7f008b6232074f6ef98e595c1c1364736f6c634300080d0033";
        public CaptainsystemImplementationDeploymentBase() : base(BYTECODE) { }
        public CaptainsystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class GetCaptainNFTFunction : GetCaptainNFTFunctionBase { }

    [Function("getCaptainNFT", typeof(GetCaptainNFTOutputDTO))]
    public class GetCaptainNFTFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
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

    public partial class GetLastSetCaptainTimeFunction : GetLastSetCaptainTimeFunctionBase { }

    [Function("getLastSetCaptainTime", "uint256")]
    public class GetLastSetCaptainTimeFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
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

    public partial class SetCaptainNFTFunction : SetCaptainNFTFunctionBase { }

    [Function("setCaptainNFT")]
    public class SetCaptainNFTFunctionBase : FunctionMessage
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

    public partial class SetCaptainEventDTO : SetCaptainEventDTOBase { }

    [Event("SetCaptain")]
    public class SetCaptainEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "tokenContract", 2, true )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
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







    public partial class GetCaptainNFTOutputDTO : GetCaptainNFTOutputDTOBase { }

    [FunctionOutput]
    public class GetCaptainNFTOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
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

    public partial class GetLastSetCaptainTimeOutputDTO : GetLastSetCaptainTimeOutputDTOBase { }

    [FunctionOutput]
    public class GetLastSetCaptainTimeOutputDTOBase : IFunctionOutputDTO 
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

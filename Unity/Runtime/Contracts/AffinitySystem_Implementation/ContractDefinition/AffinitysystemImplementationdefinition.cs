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

namespace PirateNationContracts.AffinitySystem_Implementation.ContractDefinition
{


    public partial class AffinitysystemImplementationDeployment : AffinitysystemImplementationDeploymentBase
    {
        public AffinitysystemImplementationDeployment() : base(BYTECODE) { }
        public AffinitysystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class AffinitysystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610e2d806100206000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c80638da5cb5b116100715780638da5cb5b1461012a578063b77776aa1461014f578063c4d66de814610162578063dd898b2f14610175578063ed022ebd14610188578063f2fde38b1461019e57600080fd5b806306c1cb91146100b957806316c38b3c146100cd578063572b6c05146100e05780635c975abb146101085780635d1ca63114610110578063715018a614610122575b600080fd5b6100cb6100c7366004610baa565b5050565b005b6100cb6100db366004610c5a565b6101b1565b6100f36100ee366004610c8c565b6101d2565b60405190151581526020015b60405180910390f35b6100f361021f565b6098545b6040519081526020016100ff565b6100cb6102aa565b6033546001600160a01b03165b6040516001600160a01b0390911681526020016100ff565b61011461015d366004610ca9565b6102be565b6100cb610170366004610c8c565b610391565b6100cb610183366004610c8c565b610622565b60975461010090046001600160a01b0316610137565b6100cb6101ac366004610c8c565b61066d565b6101b96106e3565b80156101ca576101c761075c565b50565b6101c76107f9565b60975460009061010090046001600160a01b03161580159061021957506102197fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d28361087a565b92915050565b60975460009060ff16806102a55750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610281573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102a59190610ccb565b905090565b6102b26106e3565b6102bc60006108fc565b565b6000806102ea7fc0e7068c38f4dd33745694538d7c751535e23340d842d6b01b1fd58194132da461094e565b600085815260996020526040808220549051631192054960e21b81526004810191909152919250906001600160a01b03831690634648152490602401600060405180830381865afa158015610343573d6000803e3d6000fd5b505050506040513d6000823e601f3d908101601f1916820160405261036b9190810190610ce8565b905080848151811061037f5761037f610d79565b60200260200101519250505092915050565b600054610100900460ff16158080156103b15750600054600160ff909116105b806103cb5750303b1580156103cb575060005460ff166001145b6104335760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610456576000805461ff0019166101001790555b610480827fabe3c8e38f28cb706bd4e0d5bcc1be8e1b268f2d0f17513177134d70ae55bc706109c1565b60996020527fb741afa439968a55430dda60f401a91a5f7af0a359eaef33849dacc33775ff137fbb86fbc034f4e382929974bcd8419ed626b0ea647f962d89ba2fb6bd28785ab9557ff35a1ca223ff7950d5f13ae2c96f660eb4a74123ad6937ae2398172f94d2ebd67f18ea924a307d8c2826d960b81412f2a6543a75ca2d379ff3a056ee960e83da3b557f9c1f0efca287ff818b62abeed41e8381c8a0fd184bc217b2b6e943a4d35270927f6c77eb307b8608348a606f5e0b4d324399953b26ef9d20fe80d55a613696457f557ff94201a7360dac3457cc8fc156d0451c1d6263087a48bacacdfeb5421c03d1597f6d01ba8ffed4ce500f24b73f45df7dc163a96f64ced987d8ee795c34e371362e5560056000527f9b9b381acc5750e6bd31bb914b6e6f8ad707a31ed495f53e34030a732b34f3ec7f040cf2419a167b50f7187f9a4e1a349aba510080d50f17f1ba8d50dffbc8570f5580156100c7576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b61062a6106e3565b60978054610100600160a81b0319166101006001600160a01b038416908102919091179091556101c75760405163a4b9148160e01b815260040160405180910390fd5b6106756106e3565b6001600160a01b0381166106da5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b606482015260840161042a565b6101c7816108fc565b6106eb610a4e565b6001600160a01b03166107066033546001600160a01b031690565b6001600160a01b0316146102bc5760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604482015260640161042a565b60975460ff16156107a65760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161042a565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a2586107dc610a4e565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff1615156001146108475760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161042a565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa6107dc610a4e565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa1580156108d1573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906108f59190610ccb565b9392505050565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b6097546040516329f20e0f60e11b81526004810183905260009161010090046001600160a01b0316906353e41c1e90602401602060405180830381865afa15801561099d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906102199190610d8f565b600054610100900460ff166109e85760405162461bcd60e51b815260040161042a90610dac565b6109f0610a7c565b6109f8610aab565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610a3b5760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600060143610801590610a655750610a65336101d2565b15610a77575060131936013560601c90565b503390565b600054610100900460ff16610aa35760405162461bcd60e51b815260040161042a90610dac565b6102bc610ada565b600054610100900460ff16610ad25760405162461bcd60e51b815260040161042a90610dac565b6102bc610b11565b600054610100900460ff16610b015760405162461bcd60e51b815260040161042a90610dac565b6102bc610b0c610a4e565b6108fc565b600054610100900460ff16610b385760405162461bcd60e51b815260040161042a90610dac565b6001606555565b634e487b7160e01b600052604160045260246000fd5b604051601f8201601f1916810167ffffffffffffffff81118282101715610b7e57610b7e610b3f565b604052919050565b600067ffffffffffffffff821115610ba057610ba0610b3f565b5060051b60200190565b60008060408385031215610bbd57600080fd5b8235915060208084013567ffffffffffffffff811115610bdc57600080fd5b8401601f81018613610bed57600080fd5b8035610c00610bfb82610b86565b610b55565b81815260059190911b82018301908381019088831115610c1f57600080fd5b928401925b82841015610c3d57833582529284019290840190610c24565b80955050505050509250929050565b80151581146101c757600080fd5b600060208284031215610c6c57600080fd5b81356108f581610c4c565b6001600160a01b03811681146101c757600080fd5b600060208284031215610c9e57600080fd5b81356108f581610c77565b60008060408385031215610cbc57600080fd5b50508035926020909101359150565b600060208284031215610cdd57600080fd5b81516108f581610c4c565b60006020808385031215610cfb57600080fd5b825167ffffffffffffffff811115610d1257600080fd5b8301601f81018513610d2357600080fd5b8051610d31610bfb82610b86565b81815260059190911b82018301908381019087831115610d5057600080fd5b928401925b82841015610d6e57835182529284019290840190610d55565b979650505050505050565b634e487b7160e01b600052603260045260246000fd5b600060208284031215610da157600080fd5b81516108f581610c77565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea26469706673582212205031927eb7259f5d7288d4f0e918d33c6585d3f86a9d8587ba311884b2e0c55864736f6c634300080d0033";
        public AffinitysystemImplementationDeploymentBase() : base(BYTECODE) { }
        public AffinitysystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class GetDamageModifierFunction : GetDamageModifierFunctionBase { }

    [Function("getDamageModifier", "uint256")]
    public class GetDamageModifierFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "affinityA", 1)]
        public virtual BigInteger AffinityA { get; set; }
        [Parameter("uint256", "affinityB", 2)]
        public virtual BigInteger AffinityB { get; set; }
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



    public partial class MissingRoleError : MissingRoleErrorBase { }

    [Error("MissingRole")]
    public class MissingRoleErrorBase : IErrorDTO
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("bytes32", "expectedRole", 2)]
        public virtual byte[] ExpectedRole { get; set; }
    }



    public partial class GetDamageModifierOutputDTO : GetDamageModifierOutputDTOBase { }

    [FunctionOutput]
    public class GetDamageModifierOutputDTOBase : IFunctionOutputDTO 
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

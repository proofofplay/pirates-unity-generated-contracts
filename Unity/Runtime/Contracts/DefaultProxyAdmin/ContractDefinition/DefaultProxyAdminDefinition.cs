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

namespace PirateNationContracts.DefaultProxyAdmin.ContractDefinition
{


    public partial class DefaultProxyAdminDeployment : DefaultProxyAdminDeploymentBase
    {
        public DefaultProxyAdminDeployment() : base(BYTECODE) { }
        public DefaultProxyAdminDeployment(string byteCode) : base(byteCode) { }
    }

    public class DefaultProxyAdminDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50604051610b17380380610b1783398101604081905261002f91610090565b8061003981610040565b50506100c0565b600080546001600160a01b038381166001600160a01b0319831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b6000602082840312156100a257600080fd5b81516001600160a01b03811681146100b957600080fd5b9392505050565b610a48806100cf6000396000f3fe60806040526004361061007b5760003560e01c80639623609d1161004e5780639623609d1461012b57806399a88ec41461013e578063f2fde38b1461015e578063f3b7dead1461017e57600080fd5b8063204e1c7a14610080578063715018a6146100c95780637eff275e146100e05780638da5cb5b14610100575b600080fd5b34801561008c57600080fd5b506100a061009b3660046107e4565b61019e565b60405173ffffffffffffffffffffffffffffffffffffffff909116815260200160405180910390f35b3480156100d557600080fd5b506100de610255565b005b3480156100ec57600080fd5b506100de6100fb366004610808565b6102e7565b34801561010c57600080fd5b5060005473ffffffffffffffffffffffffffffffffffffffff166100a0565b6100de610139366004610870565b6103ee565b34801561014a57600080fd5b506100de610159366004610808565b6104fc565b34801561016a57600080fd5b506100de6101793660046107e4565b6105d1565b34801561018a57600080fd5b506100a06101993660046107e4565b610701565b60008060008373ffffffffffffffffffffffffffffffffffffffff166040516101ea907f5c60da1b00000000000000000000000000000000000000000000000000000000815260040190565b600060405180830381855afa9150503d8060008114610225576040519150601f19603f3d011682016040523d82523d6000602084013e61022a565b606091505b50915091508161023957600080fd5b8080602001905181019061024d9190610964565b949350505050565b60005473ffffffffffffffffffffffffffffffffffffffff1633146102db576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064015b60405180910390fd5b6102e5600061074d565b565b60005473ffffffffffffffffffffffffffffffffffffffff163314610368576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016102d2565b6040517f8f28397000000000000000000000000000000000000000000000000000000000815273ffffffffffffffffffffffffffffffffffffffff8281166004830152831690638f283970906024015b600060405180830381600087803b1580156103d257600080fd5b505af11580156103e6573d6000803e3d6000fd5b505050505050565b60005473ffffffffffffffffffffffffffffffffffffffff16331461046f576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016102d2565b6040517f4f1ef28600000000000000000000000000000000000000000000000000000000815273ffffffffffffffffffffffffffffffffffffffff841690634f1ef2869034906104c59086908690600401610981565b6000604051808303818588803b1580156104de57600080fd5b505af11580156104f2573d6000803e3d6000fd5b5050505050505050565b60005473ffffffffffffffffffffffffffffffffffffffff16331461057d576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016102d2565b6040517f3659cfe600000000000000000000000000000000000000000000000000000000815273ffffffffffffffffffffffffffffffffffffffff8281166004830152831690633659cfe6906024016103b8565b60005473ffffffffffffffffffffffffffffffffffffffff163314610652576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016102d2565b73ffffffffffffffffffffffffffffffffffffffff81166106f5576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201527f646472657373000000000000000000000000000000000000000000000000000060648201526084016102d2565b6106fe8161074d565b50565b60008060008373ffffffffffffffffffffffffffffffffffffffff166040516101ea907ff851a44000000000000000000000000000000000000000000000000000000000815260040190565b6000805473ffffffffffffffffffffffffffffffffffffffff8381167fffffffffffffffffffffffff0000000000000000000000000000000000000000831681178455604051919092169283917f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e09190a35050565b73ffffffffffffffffffffffffffffffffffffffff811681146106fe57600080fd5b6000602082840312156107f657600080fd5b8135610801816107c2565b9392505050565b6000806040838503121561081b57600080fd5b8235610826816107c2565b91506020830135610836816107c2565b809150509250929050565b7f4e487b7100000000000000000000000000000000000000000000000000000000600052604160045260246000fd5b60008060006060848603121561088557600080fd5b8335610890816107c2565b925060208401356108a0816107c2565b9150604084013567ffffffffffffffff808211156108bd57600080fd5b818601915086601f8301126108d157600080fd5b8135818111156108e3576108e3610841565b604051601f82017fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe0908116603f0116810190838211818310171561092957610929610841565b8160405282815289602084870101111561094257600080fd5b8260208601602083013760006020848301015280955050505050509250925092565b60006020828403121561097657600080fd5b8151610801816107c2565b73ffffffffffffffffffffffffffffffffffffffff8316815260006020604081840152835180604085015260005b818110156109cb578581018301518582016060015282016109af565b818111156109dd576000606083870101525b50601f017fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe0169290920160600194935050505056fea2646970667358221220bd6c09ab03bfaf9ec60a4bf8cd98903cecb891974e17e2d76a3b2002c97eeb8964736f6c634300080a0033";
        public DefaultProxyAdminDeploymentBase() : base(BYTECODE) { }
        public DefaultProxyAdminDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "initialOwner", 1)]
        public virtual string InitialOwner { get; set; }
    }

    public partial class ChangeProxyAdminFunction : ChangeProxyAdminFunctionBase { }

    [Function("changeProxyAdmin")]
    public class ChangeProxyAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "proxy", 1)]
        public virtual string Proxy { get; set; }
        [Parameter("address", "newAdmin", 2)]
        public virtual string NewAdmin { get; set; }
    }

    public partial class GetProxyAdminFunction : GetProxyAdminFunctionBase { }

    [Function("getProxyAdmin", "address")]
    public class GetProxyAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "proxy", 1)]
        public virtual string Proxy { get; set; }
    }

    public partial class GetProxyImplementationFunction : GetProxyImplementationFunctionBase { }

    [Function("getProxyImplementation", "address")]
    public class GetProxyImplementationFunctionBase : FunctionMessage
    {
        [Parameter("address", "proxy", 1)]
        public virtual string Proxy { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UpgradeFunction : UpgradeFunctionBase { }

    [Function("upgrade")]
    public class UpgradeFunctionBase : FunctionMessage
    {
        [Parameter("address", "proxy", 1)]
        public virtual string Proxy { get; set; }
        [Parameter("address", "implementation", 2)]
        public virtual string Implementation { get; set; }
    }

    public partial class UpgradeAndCallFunction : UpgradeAndCallFunctionBase { }

    [Function("upgradeAndCall")]
    public class UpgradeAndCallFunctionBase : FunctionMessage
    {
        [Parameter("address", "proxy", 1)]
        public virtual string Proxy { get; set; }
        [Parameter("address", "implementation", 2)]
        public virtual string Implementation { get; set; }
        [Parameter("bytes", "data", 3)]
        public virtual byte[] Data { get; set; }
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



    public partial class GetProxyAdminOutputDTO : GetProxyAdminOutputDTOBase { }

    [FunctionOutput]
    public class GetProxyAdminOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetProxyImplementationOutputDTO : GetProxyImplementationOutputDTOBase { }

    [FunctionOutput]
    public class GetProxyImplementationOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }








}

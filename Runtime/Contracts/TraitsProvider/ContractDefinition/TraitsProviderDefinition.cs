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

namespace PirateNationContracts.TraitsProvider.ContractDefinition
{


    public partial class TraitsProviderDeployment : TraitsProviderDeploymentBase
    {
        public TraitsProviderDeployment() : base(BYTECODE) { }
        public TraitsProviderDeployment(string byteCode) : base(byteCode) { }
    }

    public class TraitsProviderDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6080604052604051620011b2380380620011b2833981016040819052620000269162000519565b82816200005560017f360894a13ba1a3210667c828492db98dca3e2076cc3735a920a3ca505d382bbd620005f9565b6000805160206200116b833981519152146200007557620000756200061f565b6200008382826000620000e7565b50620000b3905060017fb53127684a568b3173ae13b9f8a6016e243e63b6e8ee1178d6a717850b5d6104620005f9565b6000805160206200114b83398151915214620000d357620000d36200061f565b620000de8262000124565b50505062000688565b620000f2836200017f565b600082511180620001005750805b156200011f576200011d8383620001c160201b620002ff1760201c565b505b505050565b7f7e644d79422f17c01e4894b5f4f588d331ebfa28653d42ae832dc59e38c9798f6200014f620001f0565b604080516001600160a01b03928316815291841660208301520160405180910390a16200017c8162000229565b50565b6200018a81620002de565b6040516001600160a01b038216907fbc7cd75a20ee27fd9adebab32041f755214dbc6bffa90cc0225b39da2e5c2d3b90600090a250565b6060620001e983836040518060600160405280602781526020016200118b6027913962000381565b9392505050565b60006200021a6000805160206200114b83398151915260001b6200046760201b620002731760201c565b546001600160a01b0316919050565b6001600160a01b038116620002945760405162461bcd60e51b815260206004820152602660248201527f455243313936373a206e65772061646d696e20697320746865207a65726f206160448201526564647265737360d01b60648201526084015b60405180910390fd5b80620002bd6000805160206200114b83398151915260001b6200046760201b620002731760201c565b80546001600160a01b0319166001600160a01b039290921691909117905550565b620002f4816200046a60201b6200032b1760201c565b620003585760405162461bcd60e51b815260206004820152602d60248201527f455243313936373a206e657720696d706c656d656e746174696f6e206973206e60448201526c1bdd08184818dbdb9d1c9858dd609a1b60648201526084016200028b565b80620002bd6000805160206200116b83398151915260001b6200046760201b620002731760201c565b60606001600160a01b0384163b620003eb5760405162461bcd60e51b815260206004820152602660248201527f416464726573733a2064656c65676174652063616c6c20746f206e6f6e2d636f6044820152651b9d1c9858dd60d21b60648201526084016200028b565b600080856001600160a01b03168560405162000408919062000635565b600060405180830381855af49150503d806000811462000445576040519150601f19603f3d011682016040523d82523d6000602084013e6200044a565b606091505b5090925090506200045d82828662000479565b9695505050505050565b90565b6001600160a01b03163b151590565b606083156200048a575081620001e9565b8251156200049b5782518084602001fd5b8160405162461bcd60e51b81526004016200028b919062000653565b80516001600160a01b0381168114620004cf57600080fd5b919050565b634e487b7160e01b600052604160045260246000fd5b60005b8381101562000507578181015183820152602001620004ed565b838111156200011d5750506000910152565b6000806000606084860312156200052f57600080fd5b6200053a84620004b7565b92506200054a60208501620004b7565b60408501519092506001600160401b03808211156200056857600080fd5b818601915086601f8301126200057d57600080fd5b815181811115620005925762000592620004d4565b604051601f8201601f19908116603f01168101908382118183101715620005bd57620005bd620004d4565b81604052828152896020848701011115620005d757600080fd5b620005ea836020830160208801620004ea565b80955050505050509250925092565b6000828210156200061a57634e487b7160e01b600052601160045260246000fd5b500390565b634e487b7160e01b600052600160045260246000fd5b6000825162000649818460208701620004ea565b9190910192915050565b602081526000825180602084015262000674816040850160208701620004ea565b601f01601f19169190910160400192915050565b610ab380620006986000396000f3fe60806040526004361061005e5760003560e01c80635c60da1b116100435780635c60da1b146100a85780638f283970146100e6578063f851a440146101065761006d565b80633659cfe6146100755780634f1ef286146100955761006d565b3661006d5761006b61011b565b005b61006b61011b565b34801561008157600080fd5b5061006b61009036600461091f565b610135565b61006b6100a336600461093a565b610196565b3480156100b457600080fd5b506100bd610221565b60405173ffffffffffffffffffffffffffffffffffffffff909116815260200160405180910390f35b3480156100f257600080fd5b5061006b61010136600461091f565b610276565b34801561011257600080fd5b506100bd6102ba565b610123610347565b61013361012e610435565b61043f565b565b61013d610463565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16141561018e5761018b816040518060200160405280600081525060006104a3565b50565b61018b61011b565b61019e610463565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161415610219576102148383838080601f016020809104026020016040519081016040528093929190818152602001838380828437600092019190915250600192506104a3915050565b505050565b61021461011b565b600061022b610463565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16141561026b57610266610435565b905090565b61027361011b565b90565b61027e610463565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16141561018e5761018b816104ce565b60006102c4610463565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16141561026b57610266610463565b60606103248383604051806060016040528060278152602001610a576027913961052f565b9392505050565b73ffffffffffffffffffffffffffffffffffffffff163b151590565b61034f610463565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161415610133576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152604260248201527f5472616e73706172656e745570677261646561626c6550726f78793a2061646d60448201527f696e2063616e6e6f742066616c6c6261636b20746f2070726f7879207461726760648201527f6574000000000000000000000000000000000000000000000000000000000000608482015260a4015b60405180910390fd5b6000610266610657565b3660008037600080366000845af43d6000803e80801561045e573d6000f35b3d6000fd5b60007fb53127684a568b3173ae13b9f8a6016e243e63b6e8ee1178d6a717850b5d61035b5473ffffffffffffffffffffffffffffffffffffffff16919050565b6104ac8361067f565b6000825111806104b95750805b15610214576104c883836102ff565b50505050565b7f7e644d79422f17c01e4894b5f4f588d331ebfa28653d42ae832dc59e38c9798f6104f7610463565b6040805173ffffffffffffffffffffffffffffffffffffffff928316815291841660208301520160405180910390a161018b816106cc565b606073ffffffffffffffffffffffffffffffffffffffff84163b6105d5576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152602660248201527f416464726573733a2064656c65676174652063616c6c20746f206e6f6e2d636f60448201527f6e74726163740000000000000000000000000000000000000000000000000000606482015260840161042c565b6000808573ffffffffffffffffffffffffffffffffffffffff16856040516105fd91906109e9565b600060405180830381855af49150503d8060008114610638576040519150601f19603f3d011682016040523d82523d6000602084013e61063d565b606091505b509150915061064d8282866107d8565b9695505050505050565b60007f360894a13ba1a3210667c828492db98dca3e2076cc3735a920a3ca505d382bbc610487565b6106888161082b565b60405173ffffffffffffffffffffffffffffffffffffffff8216907fbc7cd75a20ee27fd9adebab32041f755214dbc6bffa90cc0225b39da2e5c2d3b90600090a250565b73ffffffffffffffffffffffffffffffffffffffff811661076f576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152602660248201527f455243313936373a206e65772061646d696e20697320746865207a65726f206160448201527f6464726573730000000000000000000000000000000000000000000000000000606482015260840161042c565b807fb53127684a568b3173ae13b9f8a6016e243e63b6e8ee1178d6a717850b5d61035b80547fffffffffffffffffffffffff00000000000000000000000000000000000000001673ffffffffffffffffffffffffffffffffffffffff9290921691909117905550565b606083156107e7575081610324565b8251156107f75782518084602001fd5b816040517f08c379a000000000000000000000000000000000000000000000000000000000815260040161042c9190610a05565b73ffffffffffffffffffffffffffffffffffffffff81163b6108cf576040517f08c379a000000000000000000000000000000000000000000000000000000000815260206004820152602d60248201527f455243313936373a206e657720696d706c656d656e746174696f6e206973206e60448201527f6f74206120636f6e747261637400000000000000000000000000000000000000606482015260840161042c565b807f360894a13ba1a3210667c828492db98dca3e2076cc3735a920a3ca505d382bbc610792565b803573ffffffffffffffffffffffffffffffffffffffff8116811461091a57600080fd5b919050565b60006020828403121561093157600080fd5b610324826108f6565b60008060006040848603121561094f57600080fd5b610958846108f6565b9250602084013567ffffffffffffffff8082111561097557600080fd5b818601915086601f83011261098957600080fd5b81358181111561099857600080fd5b8760208285010111156109aa57600080fd5b6020830194508093505050509250925092565b60005b838110156109d85781810151838201526020016109c0565b838111156104c85750506000910152565b600082516109fb8184602087016109bd565b9190910192915050565b6020815260008251806020840152610a248160408501602087016109bd565b601f017fffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffffe016919091016040019291505056fe416464726573733a206c6f772d6c6576656c2064656c65676174652063616c6c206661696c6564a2646970667358221220b29caa54336b3ee836679675e9732ec5e526fb3f803cca2fe336cc3555aba62264736f6c634300080a0033b53127684a568b3173ae13b9f8a6016e243e63b6e8ee1178d6a717850b5d6103360894a13ba1a3210667c828492db98dca3e2076cc3735a920a3ca505d382bbc416464726573733a206c6f772d6c6576656c2064656c65676174652063616c6c206661696c6564";
        public TraitsProviderDeploymentBase() : base(BYTECODE) { }
        public TraitsProviderDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_logic", 1)]
        public virtual string Logic { get; set; }
        [Parameter("address", "admin_", 2)]
        public virtual string Admin { get; set; }
        [Parameter("bytes", "_data", 3)]
        public virtual byte[] Data { get; set; }
    }

    public partial class AdminFunction : AdminFunctionBase { }

    [Function("admin", "address")]
    public class AdminFunctionBase : FunctionMessage
    {

    }

    public partial class ChangeAdminFunction : ChangeAdminFunctionBase { }

    [Function("changeAdmin")]
    public class ChangeAdminFunctionBase : FunctionMessage
    {
        [Parameter("address", "newAdmin", 1)]
        public virtual string NewAdmin { get; set; }
    }

    public partial class ImplementationFunction : ImplementationFunctionBase { }

    [Function("implementation", "address")]
    public class ImplementationFunctionBase : FunctionMessage
    {

    }

    public partial class UpgradeToFunction : UpgradeToFunctionBase { }

    [Function("upgradeTo")]
    public class UpgradeToFunctionBase : FunctionMessage
    {
        [Parameter("address", "newImplementation", 1)]
        public virtual string NewImplementation { get; set; }
    }

    public partial class UpgradeToAndCallFunction : UpgradeToAndCallFunctionBase { }

    [Function("upgradeToAndCall")]
    public class UpgradeToAndCallFunctionBase : FunctionMessage
    {
        [Parameter("address", "newImplementation", 1)]
        public virtual string NewImplementation { get; set; }
        [Parameter("bytes", "data", 2)]
        public virtual byte[] Data { get; set; }
    }

    public partial class BatchSetTraitBoolFunction : BatchSetTraitBoolFunctionBase { }

    [Function("batchSetTraitBool")]
    public class BatchSetTraitBoolFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256[]", "tokenIds", 2)]
        public virtual List<BigInteger> TokenIds { get; set; }
        [Parameter("uint256[]", "traitIds", 3)]
        public virtual List<BigInteger> TraitIds { get; set; }
        [Parameter("bool[]", "values", 4)]
        public virtual List<bool> Values { get; set; }
    }

    public partial class BatchSetTraitInt256Function : BatchSetTraitInt256FunctionBase { }

    [Function("batchSetTraitInt256")]
    public class BatchSetTraitInt256FunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256[]", "tokenIds", 2)]
        public virtual List<BigInteger> TokenIds { get; set; }
        [Parameter("uint256[]", "traitIds", 3)]
        public virtual List<BigInteger> TraitIds { get; set; }
        [Parameter("int256[]", "values", 4)]
        public virtual List<BigInteger> Values { get; set; }
    }

    public partial class BatchSetTraitStringFunction : BatchSetTraitStringFunctionBase { }

    [Function("batchSetTraitString")]
    public class BatchSetTraitStringFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256[]", "tokenIds", 2)]
        public virtual List<BigInteger> TokenIds { get; set; }
        [Parameter("uint256[]", "traitIds", 3)]
        public virtual List<BigInteger> TraitIds { get; set; }
        [Parameter("string[]", "values", 4)]
        public virtual List<string> Values { get; set; }
    }

    public partial class BatchSetTraitUint256Function : BatchSetTraitUint256FunctionBase { }

    [Function("batchSetTraitUint256")]
    public class BatchSetTraitUint256FunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256[]", "tokenIds", 2)]
        public virtual List<BigInteger> TokenIds { get; set; }
        [Parameter("uint256[]", "traitIds", 3)]
        public virtual List<BigInteger> TraitIds { get; set; }
        [Parameter("uint256[]", "values", 4)]
        public virtual List<BigInteger> Values { get; set; }
    }

    public partial class DecrementTraitFunction : DecrementTraitFunctionBase { }

    [Function("decrementTrait")]
    public class DecrementTraitFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
        [Parameter("uint256", "amount", 4)]
        public virtual BigInteger Amount { get; set; }
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

    public partial class GetTraitBoolFunction : GetTraitBoolFunctionBase { }

    [Function("getTraitBool", "bool")]
    public class GetTraitBoolFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
    }

    public partial class GetTraitBytesFunction : GetTraitBytesFunctionBase { }

    [Function("getTraitBytes", "bytes")]
    public class GetTraitBytesFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
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

    public partial class GetTraitInt256Function : GetTraitInt256FunctionBase { }

    [Function("getTraitInt256", "int256")]
    public class GetTraitInt256FunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
    }

    public partial class GetTraitMetadataFunction : GetTraitMetadataFunctionBase { }

    [Function("getTraitMetadata", typeof(GetTraitMetadataOutputDTO))]
    public class GetTraitMetadataFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "traitId", 1)]
        public virtual BigInteger TraitId { get; set; }
    }

    public partial class GetTraitStringFunction : GetTraitStringFunctionBase { }

    [Function("getTraitString", "string")]
    public class GetTraitStringFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
    }

    public partial class GetTraitUint256Function : GetTraitUint256FunctionBase { }

    [Function("getTraitUint256", "uint256")]
    public class GetTraitUint256FunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
    }

    public partial class HasTraitFunction : HasTraitFunctionBase { }

    [Function("hasTrait", "bool")]
    public class HasTraitFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
    }

    public partial class IncrementTraitFunction : IncrementTraitFunctionBase { }

    [Function("incrementTrait")]
    public class IncrementTraitFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
        [Parameter("uint256", "amount", 4)]
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

    public partial class SetTraitBoolFunction : SetTraitBoolFunctionBase { }

    [Function("setTraitBool")]
    public class SetTraitBoolFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
        [Parameter("bool", "value", 4)]
        public virtual bool Value { get; set; }
    }

    public partial class SetTraitInt256Function : SetTraitInt256FunctionBase { }

    [Function("setTraitInt256")]
    public class SetTraitInt256FunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
        [Parameter("int256", "value", 4)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class SetTraitMetadataFunction : SetTraitMetadataFunctionBase { }

    [Function("setTraitMetadata")]
    public class SetTraitMetadataFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "traitId", 1)]
        public virtual BigInteger TraitId { get; set; }
        [Parameter("tuple", "traitMetadata", 2)]
        public virtual TraitMetadata TraitMetadata { get; set; }
    }

    public partial class SetTraitStringFunction : SetTraitStringFunctionBase { }

    [Function("setTraitString")]
    public class SetTraitStringFunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
        [Parameter("string", "value", 4)]
        public virtual string Value { get; set; }
    }

    public partial class SetTraitUint256Function : SetTraitUint256FunctionBase { }

    [Function("setTraitUint256")]
    public class SetTraitUint256FunctionBase : FunctionMessage
    {
        [Parameter("address", "tokenContract", 1)]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "traitId", 3)]
        public virtual BigInteger TraitId { get; set; }
        [Parameter("uint256", "value", 4)]
        public virtual BigInteger Value { get; set; }
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

    public partial class AdminChangedEventDTO : AdminChangedEventDTOBase { }

    [Event("AdminChanged")]
    public class AdminChangedEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousAdmin", 1, false )]
        public virtual string PreviousAdmin { get; set; }
        [Parameter("address", "newAdmin", 2, false )]
        public virtual string NewAdmin { get; set; }
    }

    public partial class BeaconUpgradedEventDTO : BeaconUpgradedEventDTOBase { }

    [Event("BeaconUpgraded")]
    public class BeaconUpgradedEventDTOBase : IEventDTO
    {
        [Parameter("address", "beacon", 1, true )]
        public virtual string Beacon { get; set; }
    }

    public partial class UpgradedEventDTO : UpgradedEventDTOBase { }

    [Event("Upgraded")]
    public class UpgradedEventDTOBase : IEventDTO
    {
        [Parameter("address", "implementation", 1, true )]
        public virtual string Implementation { get; set; }
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

    public partial class TraitMetadataSetEventDTO : TraitMetadataSetEventDTOBase { }

    [Event("TraitMetadataSet")]
    public class TraitMetadataSetEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "traitId", 1, true )]
        public virtual BigInteger TraitId { get; set; }
    }

    public partial class TraitsUpdatedEventDTO : TraitsUpdatedEventDTOBase { }

    [Event("TraitsUpdated")]
    public class TraitsUpdatedEventDTOBase : IEventDTO
    {
        [Parameter("address", "tokenContract", 1, false )]
        public virtual string TokenContract { get; set; }
        [Parameter("uint256", "tokenId", 2, false )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class UnpausedEventDTO : UnpausedEventDTOBase { }

    [Event("Unpaused")]
    public class UnpausedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, false )]
        public virtual string Account { get; set; }
    }

    public partial class DataTypeMismatchError : DataTypeMismatchErrorBase { }

    [Error("DataTypeMismatch")]
    public class DataTypeMismatchErrorBase : IErrorDTO
    {
        [Parameter("uint8", "expected", 1)]
        public virtual byte Expected { get; set; }
        [Parameter("uint8", "actual", 2)]
        public virtual byte Actual { get; set; }
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







































    public partial class GenerateTokenURIOutputDTO : GenerateTokenURIOutputDTOBase { }

    [FunctionOutput]
    public class GenerateTokenURIOutputDTOBase : IFunctionOutputDTO 
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

    public partial class GetTraitBoolOutputDTO : GetTraitBoolOutputDTOBase { }

    [FunctionOutput]
    public class GetTraitBoolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class GetTraitBytesOutputDTO : GetTraitBytesOutputDTOBase { }

    [FunctionOutput]
    public class GetTraitBytesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class GetTraitIdsOutputDTO : GetTraitIdsOutputDTOBase { }

    [FunctionOutput]
    public class GetTraitIdsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
    }

    public partial class GetTraitInt256OutputDTO : GetTraitInt256OutputDTOBase { }

    [FunctionOutput]
    public class GetTraitInt256OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("int256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetTraitMetadataOutputDTO : GetTraitMetadataOutputDTOBase { }

    [FunctionOutput]
    public class GetTraitMetadataOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("tuple", "", 1)]
        public virtual TraitMetadata ReturnValue1 { get; set; }
    }

    public partial class GetTraitStringOutputDTO : GetTraitStringOutputDTOBase { }

    [FunctionOutput]
    public class GetTraitStringOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetTraitUint256OutputDTO : GetTraitUint256OutputDTOBase { }

    [FunctionOutput]
    public class GetTraitUint256OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class HasTraitOutputDTO : HasTraitOutputDTOBase { }

    [FunctionOutput]
    public class HasTraitOutputDTOBase : IFunctionOutputDTO 
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

















    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }


}
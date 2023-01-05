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

namespace PirateNationContracts.RequirementSystem_Implementation.ContractDefinition
{


    public partial class RequirementsystemImplementationDeployment : RequirementsystemImplementationDeploymentBase
    {
        public RequirementsystemImplementationDeployment() : base(BYTECODE) { }
        public RequirementsystemImplementationDeployment(string byteCode) : base(byteCode) { }
    }

    public class RequirementsystemImplementationDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506112c2806100206000396000f3fe608060405234801561001057600080fd5b50600436106101005760003560e01c8063715018a611610097578063d7f78a2711610066578063d7f78a2714610219578063dd898b2f1461022c578063ed022ebd1461023f578063f2fde38b1461025557600080fd5b8063715018a6146101da5780638060cd69146101e25780638da5cb5b146101f5578063c4d66de81461020657600080fd5b80635c975abb116100d35780635c975abb1461019b5780635d1ca631146101a357806366e7f7b7146101b45780636f8e1e3c146101c757600080fd5b806306c1cb911461010557806316c38b3c146101195780633df922f61461012c578063572b6c0514610178575b600080fd5b610117610113366004610dcd565b5050565b005b610117610127366004610e7d565b610268565b61015b61013a366004610eb3565b63ffffffff166000908152609960205260409020546001600160a01b031690565b6040516001600160a01b0390911681526020015b60405180910390f35b61018b610186366004610ee5565b610289565b604051901515815260200161016f565b61018b6102d6565b60985460405190815260200161016f565b61018b6101c2366004610faf565b610361565b6101176101d5366004610ffd565b61041c565b610117610485565b61018b6101f03660046110bb565b610499565b6033546001600160a01b031661015b565b610117610214366004610ee5565b610594565b6101176102273660046110ff565b6106cc565b61011761023a366004610ee5565b6107e6565b60975461010090046001600160a01b031661015b565b610117610263366004610ee5565b610831565b6102706108a7565b80156102815761027e610920565b50565b61027e6109bd565b60975460009061010090046001600160a01b0316158015906102d057506102d07fd3df22cd6a774f62b0ae21ffd602cc92e7f3390518eee8b33307fc70380da7d283610a3e565b92915050565b60975460009060ff168061035c5750609760019054906101000a90046001600160a01b03166001600160a01b0316635c975abb6040518163ffffffff1660e01b8152600401602060405180830381865afa158015610338573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061035c919061113c565b905090565b805163ffffffff166000908152609960205260408120546001600160a01b031680158015906104035750602083015160405163c2aa834760e01b81526001600160a01b0383169163c2aa8347916103bc9188916004016111a6565b602060405180830381865afa1580156103d9573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103fd919061113c565b15156001145b156104125760019150506102d0565b5060009392505050565b7f241ecf16d79d0f8dbfb92cbc07fe17840425976cf0667f022fe9877caa831b0861044e81610449610ac0565b610aee565b5063ffffffff91909116600090815260996020526040902080546001600160a01b0319166001600160a01b03909216919091179055565b61048d6108a7565b6104976000610b97565b565b6000805b825181101561058a5760008382815181106104ba576104ba6111ca565b602090810291909101810151805163ffffffff16600090815260999092526040909120549091506001600160a01b03168015806105665750602082015160405163c2aa834760e01b81526001600160a01b0383169163c2aa834791610523918a916004016111a6565b602060405180830381865afa158015610540573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610564919061113c565b155b1561057757600093505050506102d0565b505080610583906111f6565b905061049d565b5060019392505050565b600054610100900460ff16158080156105b45750600054600160ff909116105b806105ce5750303b1580156105ce575060005460ff166001145b6106365760405162461bcd60e51b815260206004820152602e60248201527f496e697469616c697a61626c653a20636f6e747261637420697320616c72656160448201526d191e481a5b9a5d1a585b1a5e995960921b60648201526084015b60405180910390fd5b6000805460ff191660011790558015610659576000805461ff0019166101001790555b610683827f1e716b60f09d11191bc4ecb2b883c3cd07359b2e49afb83437f8712168b4d585610be9565b8015610113576000805461ff0019169055604051600181527f7f26b83ff96e1f2b6a682f133852f6798a09c465da95921460cefb38474024989060200160405180910390a15050565b60005b81518160ff161015610113576000828260ff16815181106106f2576106f26111ca565b602090810291909101810151805163ffffffff16600090815260999092526040909120549091506001600160a01b0316806107405760405163488dca4560e01b815260040160405180910390fd5b60208201516040516312d5c7c560e31b81526001600160a01b038316916396ae3e2891610770919060040161120f565b602060405180830381865afa15801561078d573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906107b1919061113c565b15156001146107d3576040516301faeccb60e41b815260040160405180910390fd5b5050806107df90611222565b90506106cf565b6107ee6108a7565b60978054610100600160a81b0319166101006001600160a01b0384169081029190911790915561027e5760405163a4b9148160e01b815260040160405180910390fd5b6108396108a7565b6001600160a01b03811661089e5760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b606482015260840161062d565b61027e81610b97565b6108af610ac0565b6001600160a01b03166108ca6033546001600160a01b031690565b6001600160a01b0316146104975760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e6572604482015260640161062d565b60975460ff161561096a5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161062d565b6097805460ff191660011790557f62e78cea01bee320cd4e420270b5ea74000d11b0c9f74754ebdbfc544b05a2586109a0610ac0565b6040516001600160a01b03909116815260200160405180910390a1565b60975460ff161515600114610a0b5760405162461bcd60e51b815260206004820152601460248201527314185d5cd8589b194e881b9bdd081c185d5cd95960621b604482015260640161062d565b6097805460ff191690557f5db9ee0a495bf2e6ff9c91a7834c1ba4fdd244a5e8aa4e537bd38aeae4b073aa6109a0610ac0565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526000926101009004169063c36dd7ea90604401602060405180830381865afa158015610a95573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610ab9919061113c565b9392505050565b600060143610801590610ad75750610ad733610289565b15610ae9575060131936013560601c90565b503390565b6097546040516361b6ebf560e11b8152600481018490526001600160a01b0383811660248301526101009092049091169063c36dd7ea90604401602060405180830381865afa158015610b45573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610b69919061113c565b6101135760405162b0d32560e11b81526001600160a01b03821660048201526024810183905260440161062d565b603380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b600054610100900460ff16610c105760405162461bcd60e51b815260040161062d90611241565b610c18610c76565b610c20610ca5565b60978054610100600160a81b0319166101006001600160a01b03851690810291909117909155610c635760405163a4b9148160e01b815260040160405180910390fd5b6097805460ff1916600117905560985550565b600054610100900460ff16610c9d5760405162461bcd60e51b815260040161062d90611241565b610497610cd4565b600054610100900460ff16610ccc5760405162461bcd60e51b815260040161062d90611241565b610497610d0b565b600054610100900460ff16610cfb5760405162461bcd60e51b815260040161062d90611241565b610497610d06610ac0565b610b97565b600054610100900460ff16610d325760405162461bcd60e51b815260040161062d90611241565b6001606555565b634e487b7160e01b600052604160045260246000fd5b6040805190810167ffffffffffffffff81118282101715610d7257610d72610d39565b60405290565b604051601f8201601f1916810167ffffffffffffffff81118282101715610da157610da1610d39565b604052919050565b600067ffffffffffffffff821115610dc357610dc3610d39565b5060051b60200190565b60008060408385031215610de057600080fd5b8235915060208084013567ffffffffffffffff811115610dff57600080fd5b8401601f81018613610e1057600080fd5b8035610e23610e1e82610da9565b610d78565b81815260059190911b82018301908381019088831115610e4257600080fd5b928401925b82841015610e6057833582529284019290840190610e47565b80955050505050509250929050565b801515811461027e57600080fd5b600060208284031215610e8f57600080fd5b8135610ab981610e6f565b803563ffffffff81168114610eae57600080fd5b919050565b600060208284031215610ec557600080fd5b610ab982610e9a565b80356001600160a01b0381168114610eae57600080fd5b600060208284031215610ef757600080fd5b610ab982610ece565b600060408284031215610f1257600080fd5b610f1a610d4f565b9050610f2582610e9a565b815260208083013567ffffffffffffffff80821115610f4357600080fd5b818501915085601f830112610f5757600080fd5b813581811115610f6957610f69610d39565b610f7b601f8201601f19168501610d78565b91508082528684828501011115610f9157600080fd5b80848401858401376000908201840152918301919091525092915050565b60008060408385031215610fc257600080fd5b610fcb83610ece565b9150602083013567ffffffffffffffff811115610fe757600080fd5b610ff385828601610f00565b9150509250929050565b6000806040838503121561101057600080fd5b61101983610e9a565b915061102760208401610ece565b90509250929050565b600082601f83011261104157600080fd5b81356020611051610e1e83610da9565b82815260059290921b8401810191818101908684111561107057600080fd5b8286015b848110156110b057803567ffffffffffffffff8111156110945760008081fd5b6110a28986838b0101610f00565b845250918301918301611074565b509695505050505050565b600080604083850312156110ce57600080fd5b6110d783610ece565b9150602083013567ffffffffffffffff8111156110f357600080fd5b610ff385828601611030565b60006020828403121561111157600080fd5b813567ffffffffffffffff81111561112857600080fd5b61113484828501611030565b949350505050565b60006020828403121561114e57600080fd5b8151610ab981610e6f565b6000815180845260005b8181101561117f57602081850181015186830182015201611163565b81811115611191576000602083870101525b50601f01601f19169290920160200192915050565b6001600160a01b038316815260406020820181905260009061113490830184611159565b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052601160045260246000fd5b600060018201611208576112086111e0565b5060010190565b602081526000610ab96020830184611159565b600060ff821660ff8103611238576112386111e0565b60010192915050565b6020808252602b908201527f496e697469616c697a61626c653a20636f6e7472616374206973206e6f74206960408201526a6e697469616c697a696e6760a81b60608201526080019056fea26469706673582212202fa0ef6b2e8593e2aae1b76da4b42469afcc174abc3a3cfcefbcd8a5424363a464736f6c634300080d0033";
        public RequirementsystemImplementationDeploymentBase() : base(BYTECODE) { }
        public RequirementsystemImplementationDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class GetAccountRequirementCheckerFunction : GetAccountRequirementCheckerFunctionBase { }

    [Function("getAccountRequirementChecker", "address")]
    public class GetAccountRequirementCheckerFunctionBase : FunctionMessage
    {
        [Parameter("uint32", "requirementId", 1)]
        public virtual uint RequirementId { get; set; }
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

    public partial class PerformAccountCheckFunction : PerformAccountCheckFunctionBase { }

    [Function("performAccountCheck", "bool")]
    public class PerformAccountCheckFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("tuple", "requirement", 2)]
        public virtual AccountRequirement Requirement { get; set; }
    }

    public partial class PerformAccountCheckBatchFunction : PerformAccountCheckBatchFunctionBase { }

    [Function("performAccountCheckBatch", "bool")]
    public class PerformAccountCheckBatchFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("tuple[]", "requirements", 2)]
        public virtual List<AccountRequirement> Requirements { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SetAccountRequirementCheckerFunction : SetAccountRequirementCheckerFunctionBase { }

    [Function("setAccountRequirementChecker")]
    public class SetAccountRequirementCheckerFunctionBase : FunctionMessage
    {
        [Parameter("uint32", "requirementId", 1)]
        public virtual uint RequirementId { get; set; }
        [Parameter("address", "requirementChecker", 2)]
        public virtual string RequirementChecker { get; set; }
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



    public partial class GetAccountRequirementCheckerOutputDTO : GetAccountRequirementCheckerOutputDTOBase { }

    [FunctionOutput]
    public class GetAccountRequirementCheckerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
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

    public partial class PerformAccountCheckOutputDTO : PerformAccountCheckOutputDTOBase { }

    [FunctionOutput]
    public class PerformAccountCheckOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class PerformAccountCheckBatchOutputDTO : PerformAccountCheckBatchOutputDTOBase { }

    [FunctionOutput]
    public class PerformAccountCheckBatchOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }










}

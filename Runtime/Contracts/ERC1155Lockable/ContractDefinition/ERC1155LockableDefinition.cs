using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace SimpleStorage.ERC1155Lockable.ContractDefinition
{


    public partial class ERC1155LockableDeployment : ERC1155LockableDeploymentBase
    {
        public ERC1155LockableDeployment() : base(BYTECODE) { }
        public ERC1155LockableDeployment(string byteCode) : base(byteCode) { }
    }

    public class ERC1155LockableDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60806040523480156200001157600080fd5b506040516200196438038062001964833981016040819052620000349162000070565b80620000408162000048565b5050620002a0565b6002620000568282620001d4565b5050565b634e487b7160e01b600052604160045260246000fd5b600060208083850312156200008457600080fd5b82516001600160401b03808211156200009c57600080fd5b818501915085601f830112620000b157600080fd5b815181811115620000c657620000c66200005a565b604051601f8201601f19908116603f01168101908382118183101715620000f157620000f16200005a565b8160405282815288868487010111156200010a57600080fd5b600093505b828410156200012e57848401860151818501870152928501926200010f565b600086848301015280965050505050505092915050565b600181811c908216806200015a57607f821691505b6020821081036200017b57634e487b7160e01b600052602260045260246000fd5b50919050565b601f821115620001cf57600081815260208120601f850160051c81016020861015620001aa5750805b601f850160051c820191505b81811015620001cb57828155600101620001b6565b5050505b505050565b81516001600160401b03811115620001f057620001f06200005a565b620002088162000201845462000145565b8462000181565b602080601f831160018114620002405760008415620002275750858301515b600019600386901b1c1916600185901b178555620001cb565b600085815260208120601f198616915b82811015620002715788860151825594840194600190910190840162000250565b5085821015620002905787850151600019600388901b60f8161c191681555b5050505050600190811b01905550565b6116b480620002b06000396000f3fe608060405234801561001057600080fd5b50600436106100b35760003560e01c80634e1273f4116100715780634e1273f41461015c57806398010ad51461017c578063a22cb46514610183578063e0d7d4a414610196578063e985e9c5146101cc578063f242432a1461020857600080fd5b8062fdd58e146100b857806301ffc9a7146100de5780630821dbae146101015780630e89341c146101165780632eb2c2d61461013657806333e48b3e14610149575b600080fd5b6100cb6100c6366004610e32565b61021b565b6040519081526020015b60405180910390f35b6100f16100ec366004610e75565b6102b4565b60405190151581526020016100d5565b61011461010f366004610e32565b6102d9565b005b610129610124366004610e92565b610331565b6040516100d59190610ef1565b610114610144366004611050565b6103c5565b6100cb610157366004610e32565b610411565b61016f61016a3660046110fa565b610450565b6040516100d59190611200565b60006100f1565b610114610191366004611213565b61057a565b6100cb6101a4366004610e32565b6001600160a01b03919091166000908152600360209081526040808320938352929052205490565b6100f16101da36600461124f565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205460ff1690565b610114610216366004611282565b610589565b60006001600160a01b03831661028b5760405162461bcd60e51b815260206004820152602a60248201527f455243313135353a2061646472657373207a65726f206973206e6f742061207660448201526930b634b21037bbb732b960b11b60648201526084015b60405180910390fd5b506000818152602081815260408083206001600160a01b03861684529091529020545b92915050565b60006001600160e01b03198216636999afcd60e11b14806102ae57506102ae826105ce565b60405162461bcd60e51b815260206004820152602760248201527f5245534355455f4e4f545f454e41424c45443a20546f6b656e206973206e6f74604482015266081b1bd8dad95960ca1b6064820152608401610282565b606060028054610340906112e7565b80601f016020809104026020016040519081016040528092919081815260200182805461036c906112e7565b80156103b95780601f1061038e576101008083540402835291602001916103b9565b820191906000526020600020905b81548152906001019060200180831161039c57829003601f168201915b50505050509050919050565b6001600160a01b0385163314806103e157506103e185336101da565b6103fd5760405162461bcd60e51b815260040161028290611321565b61040a858585858561061e565b5050505050565b6001600160a01b038216600090815260036020908152604080832084845290915281205461043f848461021b565b6104499190611386565b9392505050565b606081518351146104b55760405162461bcd60e51b815260206004820152602960248201527f455243313135353a206163636f756e747320616e6420696473206c656e677468604482015268040dad2e6dac2e8c6d60bb1b6064820152608401610282565b6000835167ffffffffffffffff8111156104d1576104d1610f04565b6040519080825280602002602001820160405280156104fa578160200160208202803683370190505b50905060005b84518110156105725761054585828151811061051e5761051e611399565b602002602001015185838151811061053857610538611399565b602002602001015161021b565b82828151811061055757610557611399565b602090810291909101015261056b816113af565b9050610500565b509392505050565b610585338383610809565b5050565b6001600160a01b0385163314806105a557506105a585336101da565b6105c15760405162461bcd60e51b815260040161028290611321565b61040a85858585856108e9565b60006001600160e01b03198216636cdb3d1360e11b14806105ff57506001600160e01b031982166303a24d0760e21b145b806102ae57506301ffc9a760e01b6001600160e01b03198316146102ae565b81518351146106805760405162461bcd60e51b815260206004820152602860248201527f455243313135353a2069647320616e6420616d6f756e7473206c656e677468206044820152670dad2e6dac2e8c6d60c31b6064820152608401610282565b6001600160a01b0384166106a65760405162461bcd60e51b8152600401610282906113c8565b336106b5818787878787610a21565b60005b845181101561079b5760008582815181106106d5576106d5611399565b6020026020010151905060008583815181106106f3576106f3611399565b602090810291909101810151600084815280835260408082206001600160a01b038e1683529093529190912054909150818110156107435760405162461bcd60e51b81526004016102829061140d565b6000838152602081815260408083206001600160a01b038e8116855292528083208585039055908b16825281208054849290610780908490611457565b9250508190555050505080610794906113af565b90506106b8565b50846001600160a01b0316866001600160a01b0316826001600160a01b03167f4a39dc06d4c0dbc64b70af90fd698a233a518aa5d07e595d983b8c0526c8f7fb87876040516107eb92919061146a565b60405180910390a4610801818787878787610bac565b505050505050565b816001600160a01b0316836001600160a01b03160361087c5760405162461bcd60e51b815260206004820152602960248201527f455243313135353a2073657474696e6720617070726f76616c20737461747573604482015268103337b91039b2b63360b91b6064820152608401610282565b6001600160a01b03838116600081815260016020908152604080832094871680845294825291829020805460ff191686151590811790915591519182527f17307eab39ab6107e8899845ad3d59bd9653f200f220920489ca2b5937696c31910160405180910390a3505050565b6001600160a01b03841661090f5760405162461bcd60e51b8152600401610282906113c8565b33600061091b85610d10565b9050600061092885610d10565b9050610938838989858589610a21565b6000868152602081815260408083206001600160a01b038c168452909152902054858110156109795760405162461bcd60e51b81526004016102829061140d565b6000878152602081815260408083206001600160a01b038d8116855292528083208985039055908a168252812080548892906109b6908490611457565b909155505060408051888152602081018890526001600160a01b03808b16928c821692918816917fc3d58168c5ae7397731d063d5bbf3d657854427343f4c083240f7aacaa2d0f62910160405180910390a4610a16848a8a8a8a8a610d5b565b505050505050505050565b6001600160a01b03851615610ba75760005b83518160ff161015610ba5576000848260ff1681518110610a5657610a56611399565b602002602001015190506000848360ff1681518110610a7757610a77611399565b60209081029190910101516040516319f2459f60e11b81526001600160a01b038a16600482015260248101849052909150819030906333e48b3e90604401602060405180830381865afa158015610ad2573d6000803e3d6000fd5b505050506040513d601f19601f82011682018060405250810190610af69190611498565b1015610b905760405162461bcd60e51b815260206004820152605960248201527f544f4b454e5f49535f4c4f434b45443a20546f6b656e7320617265206c6f636b60448201527f656420696e2d67616d6520616e642063616e6e6f74206265207472616e73666560648201527f7272656420756e74696c20697420697320756e6c6f636b656400000000000000608482015260a401610282565b50508080610b9d906114b1565b915050610a33565b505b610801565b6001600160a01b0384163b156108015760405163bc197c8160e01b81526001600160a01b0385169063bc197c8190610bf090899089908890889088906004016114d0565b6020604051808303816000875af1925050508015610c2b575060408051601f3d908101601f19168201909252610c289181019061152e565b60015b610cd757610c3761154b565b806308c379a003610c705750610c4b611567565b80610c565750610c72565b8060405162461bcd60e51b81526004016102829190610ef1565b505b60405162461bcd60e51b815260206004820152603460248201527f455243313135353a207472616e7366657220746f206e6f6e20455243313135356044820152732932b1b2b4bb32b91034b6b83632b6b2b73a32b960611b6064820152608401610282565b6001600160e01b0319811663bc197c8160e01b14610d075760405162461bcd60e51b8152600401610282906115f1565b50505050505050565b60408051600180825281830190925260609160009190602080830190803683370190505090508281600081518110610d4a57610d4a611399565b602090810291909101015292915050565b6001600160a01b0384163b156108015760405163f23a6e6160e01b81526001600160a01b0385169063f23a6e6190610d9f9089908990889088908890600401611639565b6020604051808303816000875af1925050508015610dda575060408051601f3d908101601f19168201909252610dd79181019061152e565b60015b610de657610c3761154b565b6001600160e01b0319811663f23a6e6160e01b14610d075760405162461bcd60e51b8152600401610282906115f1565b80356001600160a01b0381168114610e2d57600080fd5b919050565b60008060408385031215610e4557600080fd5b610e4e83610e16565b946020939093013593505050565b6001600160e01b031981168114610e7257600080fd5b50565b600060208284031215610e8757600080fd5b813561044981610e5c565b600060208284031215610ea457600080fd5b5035919050565b6000815180845260005b81811015610ed157602081850181015186830182015201610eb5565b506000602082860101526020601f19601f83011685010191505092915050565b6020815260006104496020830184610eab565b634e487b7160e01b600052604160045260246000fd5b601f8201601f1916810167ffffffffffffffff81118282101715610f4057610f40610f04565b6040525050565b600067ffffffffffffffff821115610f6157610f61610f04565b5060051b60200190565b600082601f830112610f7c57600080fd5b81356020610f8982610f47565b604051610f968282610f1a565b83815260059390931b8501820192828101915086841115610fb657600080fd5b8286015b84811015610fd15780358352918301918301610fba565b509695505050505050565b600082601f830112610fed57600080fd5b813567ffffffffffffffff81111561100757611007610f04565b60405161101e601f8301601f191660200182610f1a565b81815284602083860101111561103357600080fd5b816020850160208301376000918101602001919091529392505050565b600080600080600060a0868803121561106857600080fd5b61107186610e16565b945061107f60208701610e16565b9350604086013567ffffffffffffffff8082111561109c57600080fd5b6110a889838a01610f6b565b945060608801359150808211156110be57600080fd5b6110ca89838a01610f6b565b935060808801359150808211156110e057600080fd5b506110ed88828901610fdc565b9150509295509295909350565b6000806040838503121561110d57600080fd5b823567ffffffffffffffff8082111561112557600080fd5b818501915085601f83011261113957600080fd5b8135602061114682610f47565b6040516111538282610f1a565b83815260059390931b850182019282810191508984111561117357600080fd5b948201945b838610156111985761118986610e16565b82529482019490820190611178565b965050860135925050808211156111ae57600080fd5b506111bb85828601610f6b565b9150509250929050565b600081518084526020808501945080840160005b838110156111f5578151875295820195908201906001016111d9565b509495945050505050565b60208152600061044960208301846111c5565b6000806040838503121561122657600080fd5b61122f83610e16565b91506020830135801515811461124457600080fd5b809150509250929050565b6000806040838503121561126257600080fd5b61126b83610e16565b915061127960208401610e16565b90509250929050565b600080600080600060a0868803121561129a57600080fd5b6112a386610e16565b94506112b160208701610e16565b93506040860135925060608601359150608086013567ffffffffffffffff8111156112db57600080fd5b6110ed88828901610fdc565b600181811c908216806112fb57607f821691505b60208210810361131b57634e487b7160e01b600052602260045260246000fd5b50919050565b6020808252602f908201527f455243313135353a2063616c6c6572206973206e6f7420746f6b656e206f776e60408201526e195c881b9bdc88185c1c1c9bdd9959608a1b606082015260800190565b634e487b7160e01b600052601160045260246000fd5b818103818111156102ae576102ae611370565b634e487b7160e01b600052603260045260246000fd5b6000600182016113c1576113c1611370565b5060010190565b60208082526025908201527f455243313135353a207472616e7366657220746f20746865207a65726f206164604082015264647265737360d81b606082015260800190565b6020808252602a908201527f455243313135353a20696e73756666696369656e742062616c616e636520666f60408201526939103a3930b739b332b960b11b606082015260800190565b808201808211156102ae576102ae611370565b60408152600061147d60408301856111c5565b828103602084015261148f81856111c5565b95945050505050565b6000602082840312156114aa57600080fd5b5051919050565b600060ff821660ff81036114c7576114c7611370565b60010192915050565b6001600160a01b0386811682528516602082015260a0604082018190526000906114fc908301866111c5565b828103606084015261150e81866111c5565b905082810360808401526115228185610eab565b98975050505050505050565b60006020828403121561154057600080fd5b815161044981610e5c565b600060033d11156115645760046000803e5060005160e01c5b90565b600060443d10156115755790565b6040516003193d81016004833e81513d67ffffffffffffffff81602484011181841117156115a557505050505090565b82850191508151818111156115bd5750505050505090565b843d87010160208285010111156115d75750505050505090565b6115e660208286010187610f1a565b509095945050505050565b60208082526028908201527f455243313135353a204552433131353552656365697665722072656a656374656040820152676420746f6b656e7360c01b606082015260800190565b6001600160a01b03868116825285166020820152604081018490526060810183905260a06080820181905260009061167390830184610eab565b97965050505050505056fea2646970667358221220ea668e29ee861778a11a4aefaea0132c797842d2aaac415cc59c7c36e10a9ff264736f6c63430008100033";
        public ERC1155LockableDeploymentBase() : base(BYTECODE) { }
        public ERC1155LockableDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("string", "_uri", 1)]
        public virtual string Uri { get; set; }
    }

    public partial class AmountLockedFunction : AmountLockedFunctionBase { }

    [Function("amountLocked", "uint256")]
    public class AmountLockedFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "id", 2)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class AmountUnlockedFunction : AmountUnlockedFunctionBase { }

    [Function("amountUnlocked", "uint256")]
    public class AmountUnlockedFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "id", 2)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "id", 2)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class BalanceOfBatchFunction : BalanceOfBatchFunctionBase { }

    [Function("balanceOfBatch", "uint256[]")]
    public class BalanceOfBatchFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "accounts", 1)]
        public virtual List<string> Accounts { get; set; }
        [Parameter("uint256[]", "ids", 2)]
        public virtual List<BigInteger> Ids { get; set; }
    }

    public partial class GetRescueUnlockEnabledFunction : GetRescueUnlockEnabledFunctionBase { }

    [Function("getRescueUnlockEnabled", "bool")]
    public class GetRescueUnlockEnabledFunctionBase : FunctionMessage
    {

    }

    public partial class IsApprovedForAllFunction : IsApprovedForAllFunctionBase { }

    [Function("isApprovedForAll", "bool")]
    public class IsApprovedForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "operator", 2)]
        public virtual string Operator { get; set; }
    }

    public partial class RescueUnlockFunction : RescueUnlockFunctionBase { }

    [Function("rescueUnlock")]
    public class RescueUnlockFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "id", 2)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class SafeBatchTransferFromFunction : SafeBatchTransferFromFunctionBase { }

    [Function("safeBatchTransferFrom")]
    public class SafeBatchTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256[]", "ids", 3)]
        public virtual List<BigInteger> Ids { get; set; }
        [Parameter("uint256[]", "amounts", 4)]
        public virtual List<BigInteger> Amounts { get; set; }
        [Parameter("bytes", "data", 5)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SafeTransferFromFunction : SafeTransferFromFunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "id", 3)]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "amount", 4)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "data", 5)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SetApprovalForAllFunction : SetApprovalForAllFunctionBase { }

    [Function("setApprovalForAll")]
    public class SetApprovalForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 2)]
        public virtual bool Approved { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class UriFunction : UriFunctionBase { }

    [Function("uri", "string")]
    public class UriFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class ApprovalForAllEventDTO : ApprovalForAllEventDTOBase { }

    [Event("ApprovalForAll")]
    public class ApprovalForAllEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "operator", 2, true )]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 3, false )]
        public virtual bool Approved { get; set; }
    }

    public partial class TokenLockedEventDTO : TokenLockedEventDTOBase { }

    [Event("TokenLocked")]
    public class TokenLockedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, true )]
        public virtual string Account { get; set; }
        [Parameter("uint256", "id", 2, true )]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "amount", 3, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TokenUnlockedEventDTO : TokenUnlockedEventDTOBase { }

    [Event("TokenUnlocked")]
    public class TokenUnlockedEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, true )]
        public virtual string Account { get; set; }
        [Parameter("uint256", "id", 2, true )]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "amount", 3, false )]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class TransferBatchEventDTO : TransferBatchEventDTOBase { }

    [Event("TransferBatch")]
    public class TransferBatchEventDTOBase : IEventDTO
    {
        [Parameter("address", "operator", 1, true )]
        public virtual string Operator { get; set; }
        [Parameter("address", "from", 2, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 3, true )]
        public virtual string To { get; set; }
        [Parameter("uint256[]", "ids", 4, false )]
        public virtual List<BigInteger> Ids { get; set; }
        [Parameter("uint256[]", "values", 5, false )]
        public virtual List<BigInteger> Values { get; set; }
    }

    public partial class TransferSingleEventDTO : TransferSingleEventDTOBase { }

    [Event("TransferSingle")]
    public class TransferSingleEventDTOBase : IEventDTO
    {
        [Parameter("address", "operator", 1, true )]
        public virtual string Operator { get; set; }
        [Parameter("address", "from", 2, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 3, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "id", 4, false )]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "value", 5, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class URIEventDTO : URIEventDTOBase { }

    [Event("URI")]
    public class URIEventDTOBase : IEventDTO
    {
        [Parameter("string", "value", 1, false )]
        public virtual string Value { get; set; }
        [Parameter("uint256", "id", 2, true )]
        public virtual BigInteger Id { get; set; }
    }

    public partial class AmountLockedOutputDTO : AmountLockedOutputDTOBase { }

    [FunctionOutput]
    public class AmountLockedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class AmountUnlockedOutputDTO : AmountUnlockedOutputDTOBase { }

    [FunctionOutput]
    public class AmountUnlockedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BalanceOfBatchOutputDTO : BalanceOfBatchOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfBatchOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
    }

    public partial class GetRescueUnlockEnabledOutputDTO : GetRescueUnlockEnabledOutputDTOBase { }

    [FunctionOutput]
    public class GetRescueUnlockEnabledOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsApprovedForAllOutputDTO : IsApprovedForAllOutputDTOBase { }

    [FunctionOutput]
    public class IsApprovedForAllOutputDTOBase : IFunctionOutputDTO 
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

    public partial class UriOutputDTO : UriOutputDTOBase { }

    [FunctionOutput]
    public class UriOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }
}
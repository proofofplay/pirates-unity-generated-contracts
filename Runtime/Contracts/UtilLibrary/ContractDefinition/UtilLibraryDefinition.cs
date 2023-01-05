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

namespace SimpleStorage.UtilLibrary.ContractDefinition
{


    public partial class UtilLibraryDeployment : UtilLibraryDeploymentBase
    {
        public UtilLibraryDeployment() : base(BYTECODE) { }
        public UtilLibraryDeployment(string byteCode) : base(byteCode) { }
    }

    public class UtilLibraryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566037600b82828239805160001a607314602a57634e487b7160e01b600052600060045260246000fd5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea26469706673582212202f63c92bf4c4ace56b2175a3bc0365938331adbb8a15bfcb91a20dc60286fbf164736f6c63430008100033";
        public UtilLibraryDeploymentBase() : base(BYTECODE) { }
        public UtilLibraryDeploymentBase(string byteCode) : base(byteCode) { }

    }
}

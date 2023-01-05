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

namespace SimpleStorage.GameHelperLibrary.ContractDefinition
{


    public partial class GameHelperLibraryDeployment : GameHelperLibraryDeploymentBase
    {
        public GameHelperLibraryDeployment() : base(BYTECODE) { }
        public GameHelperLibraryDeployment(string byteCode) : base(byteCode) { }
    }

    public class GameHelperLibraryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566037600b82828239805160001a607314602a57634e487b7160e01b600052600060045260246000fd5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea2646970667358221220a30b02debbe48a6a331e304618d46eea2040930e8a7fee004ebf8528e979897b64736f6c63430008100033";
        public GameHelperLibraryDeploymentBase() : base(BYTECODE) { }
        public GameHelperLibraryDeploymentBase(string byteCode) : base(byteCode) { }

    }
}

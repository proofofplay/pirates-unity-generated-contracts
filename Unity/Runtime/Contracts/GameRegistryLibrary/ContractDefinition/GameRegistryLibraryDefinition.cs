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

namespace SimpleStorage.GameRegistryLibrary.ContractDefinition
{


    public partial class GameRegistryLibraryDeployment : GameRegistryLibraryDeploymentBase
    {
        public GameRegistryLibraryDeployment() : base(BYTECODE) { }
        public GameRegistryLibraryDeployment(string byteCode) : base(byteCode) { }
    }

    public class GameRegistryLibraryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60566037600b82828239805160001a607314602a57634e487b7160e01b600052600060045260246000fd5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea2646970667358221220ea5da9383cb5d9623687e9dbb2cea2a8dbd299fa5590f2950324f56234d1611a64736f6c63430008100033";
        public GameRegistryLibraryDeploymentBase() : base(BYTECODE) { }
        public GameRegistryLibraryDeploymentBase(string byteCode) : base(byteCode) { }

    }
}

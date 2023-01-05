using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using SimpleStorage.GameRegistryLibrary.ContractDefinition;

namespace SimpleStorage.GameRegistryLibrary
{
    public partial class GameRegistryLibraryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, GameRegistryLibraryDeployment gameRegistryLibraryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<GameRegistryLibraryDeployment>().SendRequestAndWaitForReceiptAsync(gameRegistryLibraryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, GameRegistryLibraryDeployment gameRegistryLibraryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<GameRegistryLibraryDeployment>().SendRequestAsync(gameRegistryLibraryDeployment);
        }

        public static async Task<GameRegistryLibraryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, GameRegistryLibraryDeployment gameRegistryLibraryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, gameRegistryLibraryDeployment, cancellationTokenSource);
            return new GameRegistryLibraryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public GameRegistryLibraryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}

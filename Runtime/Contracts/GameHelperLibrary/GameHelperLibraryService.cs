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
using SimpleStorage.GameHelperLibrary.ContractDefinition;

namespace SimpleStorage.GameHelperLibrary
{
    public partial class GameHelperLibraryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, GameHelperLibraryDeployment gameHelperLibraryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<GameHelperLibraryDeployment>().SendRequestAndWaitForReceiptAsync(gameHelperLibraryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, GameHelperLibraryDeployment gameHelperLibraryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<GameHelperLibraryDeployment>().SendRequestAsync(gameHelperLibraryDeployment);
        }

        public static async Task<GameHelperLibraryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, GameHelperLibraryDeployment gameHelperLibraryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, gameHelperLibraryDeployment, cancellationTokenSource);
            return new GameHelperLibraryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public GameHelperLibraryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}

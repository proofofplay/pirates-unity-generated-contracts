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
using SimpleStorage.UtilLibrary.ContractDefinition;

namespace SimpleStorage.UtilLibrary
{
    public partial class UtilLibraryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, UtilLibraryDeployment utilLibraryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<UtilLibraryDeployment>().SendRequestAndWaitForReceiptAsync(utilLibraryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, UtilLibraryDeployment utilLibraryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<UtilLibraryDeployment>().SendRequestAsync(utilLibraryDeployment);
        }

        public static async Task<UtilLibraryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, UtilLibraryDeployment utilLibraryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, utilLibraryDeployment, cancellationTokenSource);
            return new UtilLibraryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public UtilLibraryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }


    }
}

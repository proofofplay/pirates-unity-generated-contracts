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
using PirateNationContracts.DefaultProxyAdmin.ContractDefinition;

namespace PirateNationContracts.DefaultProxyAdmin
{
    public partial class DefaultProxyAdminService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, DefaultProxyAdminDeployment defaultProxyAdminDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<DefaultProxyAdminDeployment>().SendRequestAndWaitForReceiptAsync(defaultProxyAdminDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, DefaultProxyAdminDeployment defaultProxyAdminDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<DefaultProxyAdminDeployment>().SendRequestAsync(defaultProxyAdminDeployment);
        }

        public static async Task<DefaultProxyAdminService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, DefaultProxyAdminDeployment defaultProxyAdminDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, defaultProxyAdminDeployment, cancellationTokenSource);
            return new DefaultProxyAdminService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public DefaultProxyAdminService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> ChangeProxyAdminRequestAsync(ChangeProxyAdminFunction changeProxyAdminFunction)
        {
             return ContractHandler.SendRequestAsync(changeProxyAdminFunction);
        }

        public Task<TransactionReceipt> ChangeProxyAdminRequestAndWaitForReceiptAsync(ChangeProxyAdminFunction changeProxyAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(changeProxyAdminFunction, cancellationToken);
        }

        public Task<string> ChangeProxyAdminRequestAsync(string proxy, string newAdmin)
        {
            var changeProxyAdminFunction = new ChangeProxyAdminFunction();
                changeProxyAdminFunction.Proxy = proxy;
                changeProxyAdminFunction.NewAdmin = newAdmin;
            
             return ContractHandler.SendRequestAsync(changeProxyAdminFunction);
        }

        public Task<TransactionReceipt> ChangeProxyAdminRequestAndWaitForReceiptAsync(string proxy, string newAdmin, CancellationTokenSource cancellationToken = null)
        {
            var changeProxyAdminFunction = new ChangeProxyAdminFunction();
                changeProxyAdminFunction.Proxy = proxy;
                changeProxyAdminFunction.NewAdmin = newAdmin;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(changeProxyAdminFunction, cancellationToken);
        }

        public Task<string> GetProxyAdminQueryAsync(GetProxyAdminFunction getProxyAdminFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetProxyAdminFunction, string>(getProxyAdminFunction, blockParameter);
        }

        
        public Task<string> GetProxyAdminQueryAsync(string proxy, BlockParameter blockParameter = null)
        {
            var getProxyAdminFunction = new GetProxyAdminFunction();
                getProxyAdminFunction.Proxy = proxy;
            
            return ContractHandler.QueryAsync<GetProxyAdminFunction, string>(getProxyAdminFunction, blockParameter);
        }

        public Task<string> GetProxyImplementationQueryAsync(GetProxyImplementationFunction getProxyImplementationFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetProxyImplementationFunction, string>(getProxyImplementationFunction, blockParameter);
        }

        
        public Task<string> GetProxyImplementationQueryAsync(string proxy, BlockParameter blockParameter = null)
        {
            var getProxyImplementationFunction = new GetProxyImplementationFunction();
                getProxyImplementationFunction.Proxy = proxy;
            
            return ContractHandler.QueryAsync<GetProxyImplementationFunction, string>(getProxyImplementationFunction, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public Task<string> RenounceOwnershipRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> UpgradeRequestAsync(UpgradeFunction upgradeFunction)
        {
             return ContractHandler.SendRequestAsync(upgradeFunction);
        }

        public Task<TransactionReceipt> UpgradeRequestAndWaitForReceiptAsync(UpgradeFunction upgradeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeFunction, cancellationToken);
        }

        public Task<string> UpgradeRequestAsync(string proxy, string implementation)
        {
            var upgradeFunction = new UpgradeFunction();
                upgradeFunction.Proxy = proxy;
                upgradeFunction.Implementation = implementation;
            
             return ContractHandler.SendRequestAsync(upgradeFunction);
        }

        public Task<TransactionReceipt> UpgradeRequestAndWaitForReceiptAsync(string proxy, string implementation, CancellationTokenSource cancellationToken = null)
        {
            var upgradeFunction = new UpgradeFunction();
                upgradeFunction.Proxy = proxy;
                upgradeFunction.Implementation = implementation;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeFunction, cancellationToken);
        }

        public Task<string> UpgradeAndCallRequestAsync(UpgradeAndCallFunction upgradeAndCallFunction)
        {
             return ContractHandler.SendRequestAsync(upgradeAndCallFunction);
        }

        public Task<TransactionReceipt> UpgradeAndCallRequestAndWaitForReceiptAsync(UpgradeAndCallFunction upgradeAndCallFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeAndCallFunction, cancellationToken);
        }

        public Task<string> UpgradeAndCallRequestAsync(string proxy, string implementation, byte[] data)
        {
            var upgradeAndCallFunction = new UpgradeAndCallFunction();
                upgradeAndCallFunction.Proxy = proxy;
                upgradeAndCallFunction.Implementation = implementation;
                upgradeAndCallFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(upgradeAndCallFunction);
        }

        public Task<TransactionReceipt> UpgradeAndCallRequestAndWaitForReceiptAsync(string proxy, string implementation, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var upgradeAndCallFunction = new UpgradeAndCallFunction();
                upgradeAndCallFunction.Proxy = proxy;
                upgradeAndCallFunction.Implementation = implementation;
                upgradeAndCallFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeAndCallFunction, cancellationToken);
        }
    }
}

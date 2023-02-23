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
using PirateNationContracts.CooldownSystem_Implementation.ContractDefinition;

namespace PirateNationContracts.CooldownSystem_Implementation
{
    public partial class CooldownsystemImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, CooldownsystemImplementationDeployment cooldownsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<CooldownsystemImplementationDeployment>().SendRequestAndWaitForReceiptAsync(cooldownsystemImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, CooldownsystemImplementationDeployment cooldownsystemImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<CooldownsystemImplementationDeployment>().SendRequestAsync(cooldownsystemImplementationDeployment);
        }

        public static async Task<CooldownsystemImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, CooldownsystemImplementationDeployment cooldownsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, cooldownsystemImplementationDeployment, cancellationTokenSource);
            return new CooldownsystemImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public CooldownsystemImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> DeleteCooldownRequestAsync(DeleteCooldownFunction deleteCooldownFunction)
        {
             return ContractHandler.SendRequestAsync(deleteCooldownFunction);
        }

        public Task<TransactionReceipt> DeleteCooldownRequestAndWaitForReceiptAsync(DeleteCooldownFunction deleteCooldownFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(deleteCooldownFunction, cancellationToken);
        }

        public Task<string> DeleteCooldownRequestAsync(BigInteger entity, BigInteger cooldownId)
        {
            var deleteCooldownFunction = new DeleteCooldownFunction();
                deleteCooldownFunction.Entity = entity;
                deleteCooldownFunction.CooldownId = cooldownId;
            
             return ContractHandler.SendRequestAsync(deleteCooldownFunction);
        }

        public Task<TransactionReceipt> DeleteCooldownRequestAndWaitForReceiptAsync(BigInteger entity, BigInteger cooldownId, CancellationTokenSource cancellationToken = null)
        {
            var deleteCooldownFunction = new DeleteCooldownFunction();
                deleteCooldownFunction.Entity = entity;
                deleteCooldownFunction.CooldownId = cooldownId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(deleteCooldownFunction, cancellationToken);
        }

        public Task<string> FulfillRandomWordsCallbackRequestAsync(FulfillRandomWordsCallbackFunction fulfillRandomWordsCallbackFunction)
        {
             return ContractHandler.SendRequestAsync(fulfillRandomWordsCallbackFunction);
        }

        public Task<TransactionReceipt> FulfillRandomWordsCallbackRequestAndWaitForReceiptAsync(FulfillRandomWordsCallbackFunction fulfillRandomWordsCallbackFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(fulfillRandomWordsCallbackFunction, cancellationToken);
        }

        public Task<string> FulfillRandomWordsCallbackRequestAsync(BigInteger requestId, List<BigInteger> randomWords)
        {
            var fulfillRandomWordsCallbackFunction = new FulfillRandomWordsCallbackFunction();
                fulfillRandomWordsCallbackFunction.RequestId = requestId;
                fulfillRandomWordsCallbackFunction.RandomWords = randomWords;
            
             return ContractHandler.SendRequestAsync(fulfillRandomWordsCallbackFunction);
        }

        public Task<TransactionReceipt> FulfillRandomWordsCallbackRequestAndWaitForReceiptAsync(BigInteger requestId, List<BigInteger> randomWords, CancellationTokenSource cancellationToken = null)
        {
            var fulfillRandomWordsCallbackFunction = new FulfillRandomWordsCallbackFunction();
                fulfillRandomWordsCallbackFunction.RequestId = requestId;
                fulfillRandomWordsCallbackFunction.RandomWords = randomWords;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(fulfillRandomWordsCallbackFunction, cancellationToken);
        }

        public Task<uint> GetCooldownQueryAsync(GetCooldownFunction getCooldownFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCooldownFunction, uint>(getCooldownFunction, blockParameter);
        }

        
        public Task<uint> GetCooldownQueryAsync(BigInteger entity, BigInteger cooldownId, BlockParameter blockParameter = null)
        {
            var getCooldownFunction = new GetCooldownFunction();
                getCooldownFunction.Entity = entity;
                getCooldownFunction.CooldownId = cooldownId;
            
            return ContractHandler.QueryAsync<GetCooldownFunction, uint>(getCooldownFunction, blockParameter);
        }

        public Task<string> GetGameRegistryQueryAsync(GetGameRegistryFunction getGameRegistryFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetGameRegistryFunction, string>(getGameRegistryFunction, blockParameter);
        }

        
        public Task<string> GetGameRegistryQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetGameRegistryFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> GetIdQueryAsync(GetIdFunction getIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetIdFunction, BigInteger>(getIdFunction, blockParameter);
        }

        
        public Task<BigInteger> GetIdQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetIdFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<string> InitializeRequestAsync(string gameRegistryAddress)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.GameRegistryAddress = gameRegistryAddress;
            
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(string gameRegistryAddress, CancellationTokenSource cancellationToken = null)
        {
            var initializeFunction = new InitializeFunction();
                initializeFunction.GameRegistryAddress = gameRegistryAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<bool> IsInCooldownQueryAsync(IsInCooldownFunction isInCooldownFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsInCooldownFunction, bool>(isInCooldownFunction, blockParameter);
        }

        
        public Task<bool> IsInCooldownQueryAsync(BigInteger entity, BigInteger cooldownId, BlockParameter blockParameter = null)
        {
            var isInCooldownFunction = new IsInCooldownFunction();
                isInCooldownFunction.Entity = entity;
                isInCooldownFunction.CooldownId = cooldownId;
            
            return ContractHandler.QueryAsync<IsInCooldownFunction, bool>(isInCooldownFunction, blockParameter);
        }

        public Task<bool> IsTrustedForwarderQueryAsync(IsTrustedForwarderFunction isTrustedForwarderFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsTrustedForwarderFunction, bool>(isTrustedForwarderFunction, blockParameter);
        }

        
        public Task<bool> IsTrustedForwarderQueryAsync(string forwarder, BlockParameter blockParameter = null)
        {
            var isTrustedForwarderFunction = new IsTrustedForwarderFunction();
                isTrustedForwarderFunction.Forwarder = forwarder;
            
            return ContractHandler.QueryAsync<IsTrustedForwarderFunction, bool>(isTrustedForwarderFunction, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<bool> PausedQueryAsync(PausedFunction pausedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PausedFunction, bool>(pausedFunction, blockParameter);
        }

        
        public Task<bool> PausedQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PausedFunction, bool>(null, blockParameter);
        }

        public Task<string> ReduceCooldownRequestAsync(ReduceCooldownFunction reduceCooldownFunction)
        {
             return ContractHandler.SendRequestAsync(reduceCooldownFunction);
        }

        public Task<TransactionReceipt> ReduceCooldownRequestAndWaitForReceiptAsync(ReduceCooldownFunction reduceCooldownFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(reduceCooldownFunction, cancellationToken);
        }

        public Task<string> ReduceCooldownRequestAsync(BigInteger entity, BigInteger cooldownId, uint cooldownTime)
        {
            var reduceCooldownFunction = new ReduceCooldownFunction();
                reduceCooldownFunction.Entity = entity;
                reduceCooldownFunction.CooldownId = cooldownId;
                reduceCooldownFunction.CooldownTime = cooldownTime;
            
             return ContractHandler.SendRequestAsync(reduceCooldownFunction);
        }

        public Task<TransactionReceipt> ReduceCooldownRequestAndWaitForReceiptAsync(BigInteger entity, BigInteger cooldownId, uint cooldownTime, CancellationTokenSource cancellationToken = null)
        {
            var reduceCooldownFunction = new ReduceCooldownFunction();
                reduceCooldownFunction.Entity = entity;
                reduceCooldownFunction.CooldownId = cooldownId;
                reduceCooldownFunction.CooldownTime = cooldownTime;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(reduceCooldownFunction, cancellationToken);
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

        public Task<string> SetGameRegistryRequestAsync(SetGameRegistryFunction setGameRegistryFunction)
        {
             return ContractHandler.SendRequestAsync(setGameRegistryFunction);
        }

        public Task<TransactionReceipt> SetGameRegistryRequestAndWaitForReceiptAsync(SetGameRegistryFunction setGameRegistryFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setGameRegistryFunction, cancellationToken);
        }

        public Task<string> SetGameRegistryRequestAsync(string gameRegistryAddress)
        {
            var setGameRegistryFunction = new SetGameRegistryFunction();
                setGameRegistryFunction.GameRegistryAddress = gameRegistryAddress;
            
             return ContractHandler.SendRequestAsync(setGameRegistryFunction);
        }

        public Task<TransactionReceipt> SetGameRegistryRequestAndWaitForReceiptAsync(string gameRegistryAddress, CancellationTokenSource cancellationToken = null)
        {
            var setGameRegistryFunction = new SetGameRegistryFunction();
                setGameRegistryFunction.GameRegistryAddress = gameRegistryAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setGameRegistryFunction, cancellationToken);
        }

        public Task<string> SetPausedRequestAsync(SetPausedFunction setPausedFunction)
        {
             return ContractHandler.SendRequestAsync(setPausedFunction);
        }

        public Task<TransactionReceipt> SetPausedRequestAndWaitForReceiptAsync(SetPausedFunction setPausedFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setPausedFunction, cancellationToken);
        }

        public Task<string> SetPausedRequestAsync(bool shouldPause)
        {
            var setPausedFunction = new SetPausedFunction();
                setPausedFunction.ShouldPause = shouldPause;
            
             return ContractHandler.SendRequestAsync(setPausedFunction);
        }

        public Task<TransactionReceipt> SetPausedRequestAndWaitForReceiptAsync(bool shouldPause, CancellationTokenSource cancellationToken = null)
        {
            var setPausedFunction = new SetPausedFunction();
                setPausedFunction.ShouldPause = shouldPause;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setPausedFunction, cancellationToken);
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

        public Task<string> UpdateAndCheckCooldownRequestAsync(UpdateAndCheckCooldownFunction updateAndCheckCooldownFunction)
        {
             return ContractHandler.SendRequestAsync(updateAndCheckCooldownFunction);
        }

        public Task<TransactionReceipt> UpdateAndCheckCooldownRequestAndWaitForReceiptAsync(UpdateAndCheckCooldownFunction updateAndCheckCooldownFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updateAndCheckCooldownFunction, cancellationToken);
        }

        public Task<string> UpdateAndCheckCooldownRequestAsync(BigInteger entity, BigInteger cooldownId, uint cooldownTime)
        {
            var updateAndCheckCooldownFunction = new UpdateAndCheckCooldownFunction();
                updateAndCheckCooldownFunction.Entity = entity;
                updateAndCheckCooldownFunction.CooldownId = cooldownId;
                updateAndCheckCooldownFunction.CooldownTime = cooldownTime;
            
             return ContractHandler.SendRequestAsync(updateAndCheckCooldownFunction);
        }

        public Task<TransactionReceipt> UpdateAndCheckCooldownRequestAndWaitForReceiptAsync(BigInteger entity, BigInteger cooldownId, uint cooldownTime, CancellationTokenSource cancellationToken = null)
        {
            var updateAndCheckCooldownFunction = new UpdateAndCheckCooldownFunction();
                updateAndCheckCooldownFunction.Entity = entity;
                updateAndCheckCooldownFunction.CooldownId = cooldownId;
                updateAndCheckCooldownFunction.CooldownTime = cooldownTime;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updateAndCheckCooldownFunction, cancellationToken);
        }
    }
}

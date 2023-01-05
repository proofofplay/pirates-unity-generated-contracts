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
using PirateNationContracts.RequirementSystem_Implementation.ContractDefinition;

namespace PirateNationContracts.RequirementSystem_Implementation
{
    public partial class RequirementsystemImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, RequirementsystemImplementationDeployment requirementsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<RequirementsystemImplementationDeployment>().SendRequestAndWaitForReceiptAsync(requirementsystemImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, RequirementsystemImplementationDeployment requirementsystemImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<RequirementsystemImplementationDeployment>().SendRequestAsync(requirementsystemImplementationDeployment);
        }

        public static async Task<RequirementsystemImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, RequirementsystemImplementationDeployment requirementsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, requirementsystemImplementationDeployment, cancellationTokenSource);
            return new RequirementsystemImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public RequirementsystemImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
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

        public Task<string> GetAccountRequirementCheckerQueryAsync(GetAccountRequirementCheckerFunction getAccountRequirementCheckerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetAccountRequirementCheckerFunction, string>(getAccountRequirementCheckerFunction, blockParameter);
        }

        
        public Task<string> GetAccountRequirementCheckerQueryAsync(uint requirementId, BlockParameter blockParameter = null)
        {
            var getAccountRequirementCheckerFunction = new GetAccountRequirementCheckerFunction();
                getAccountRequirementCheckerFunction.RequirementId = requirementId;
            
            return ContractHandler.QueryAsync<GetAccountRequirementCheckerFunction, string>(getAccountRequirementCheckerFunction, blockParameter);
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

        public Task<bool> PerformAccountCheckQueryAsync(PerformAccountCheckFunction performAccountCheckFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PerformAccountCheckFunction, bool>(performAccountCheckFunction, blockParameter);
        }

        
        public Task<bool> PerformAccountCheckQueryAsync(string account, AccountRequirement requirement, BlockParameter blockParameter = null)
        {
            var performAccountCheckFunction = new PerformAccountCheckFunction();
                performAccountCheckFunction.Account = account;
                performAccountCheckFunction.Requirement = requirement;
            
            return ContractHandler.QueryAsync<PerformAccountCheckFunction, bool>(performAccountCheckFunction, blockParameter);
        }

        public Task<bool> PerformAccountCheckBatchQueryAsync(PerformAccountCheckBatchFunction performAccountCheckBatchFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PerformAccountCheckBatchFunction, bool>(performAccountCheckBatchFunction, blockParameter);
        }

        
        public Task<bool> PerformAccountCheckBatchQueryAsync(string account, List<AccountRequirement> requirements, BlockParameter blockParameter = null)
        {
            var performAccountCheckBatchFunction = new PerformAccountCheckBatchFunction();
                performAccountCheckBatchFunction.Account = account;
                performAccountCheckBatchFunction.Requirements = requirements;
            
            return ContractHandler.QueryAsync<PerformAccountCheckBatchFunction, bool>(performAccountCheckBatchFunction, blockParameter);
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

        public Task<string> SetAccountRequirementCheckerRequestAsync(SetAccountRequirementCheckerFunction setAccountRequirementCheckerFunction)
        {
             return ContractHandler.SendRequestAsync(setAccountRequirementCheckerFunction);
        }

        public Task<TransactionReceipt> SetAccountRequirementCheckerRequestAndWaitForReceiptAsync(SetAccountRequirementCheckerFunction setAccountRequirementCheckerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setAccountRequirementCheckerFunction, cancellationToken);
        }

        public Task<string> SetAccountRequirementCheckerRequestAsync(uint requirementId, string requirementChecker)
        {
            var setAccountRequirementCheckerFunction = new SetAccountRequirementCheckerFunction();
                setAccountRequirementCheckerFunction.RequirementId = requirementId;
                setAccountRequirementCheckerFunction.RequirementChecker = requirementChecker;
            
             return ContractHandler.SendRequestAsync(setAccountRequirementCheckerFunction);
        }

        public Task<TransactionReceipt> SetAccountRequirementCheckerRequestAndWaitForReceiptAsync(uint requirementId, string requirementChecker, CancellationTokenSource cancellationToken = null)
        {
            var setAccountRequirementCheckerFunction = new SetAccountRequirementCheckerFunction();
                setAccountRequirementCheckerFunction.RequirementId = requirementId;
                setAccountRequirementCheckerFunction.RequirementChecker = requirementChecker;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setAccountRequirementCheckerFunction, cancellationToken);
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
    }
}

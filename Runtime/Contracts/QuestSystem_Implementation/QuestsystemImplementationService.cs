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
using PirateNationContracts.QuestSystem_Implementation.ContractDefinition;

namespace PirateNationContracts.QuestSystem_Implementation
{
    public partial class QuestsystemImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, QuestsystemImplementationDeployment questsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<QuestsystemImplementationDeployment>().SendRequestAndWaitForReceiptAsync(questsystemImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, QuestsystemImplementationDeployment questsystemImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<QuestsystemImplementationDeployment>().SendRequestAsync(questsystemImplementationDeployment);
        }

        public static async Task<QuestsystemImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, QuestsystemImplementationDeployment questsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, questsystemImplementationDeployment, cancellationTokenSource);
            return new QuestsystemImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public QuestsystemImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<ActiveQuestsOutputDTO> ActiveQuestsQueryAsync(ActiveQuestsFunction activeQuestsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<ActiveQuestsFunction, ActiveQuestsOutputDTO>(activeQuestsFunction, blockParameter);
        }

        public Task<ActiveQuestsOutputDTO> ActiveQuestsQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var activeQuestsFunction = new ActiveQuestsFunction();
                activeQuestsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryDeserializingToObjectAsync<ActiveQuestsFunction, ActiveQuestsOutputDTO>(activeQuestsFunction, blockParameter);
        }

        public Task<QuestDefinitionsOutputDTO> QuestDefinitionsQueryAsync(QuestDefinitionsFunction questDefinitionsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<QuestDefinitionsFunction, QuestDefinitionsOutputDTO>(questDefinitionsFunction, blockParameter);
        }

        public Task<QuestDefinitionsOutputDTO> QuestDefinitionsQueryAsync(uint returnValue1, BlockParameter blockParameter = null)
        {
            var questDefinitionsFunction = new QuestDefinitionsFunction();
                questDefinitionsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryDeserializingToObjectAsync<QuestDefinitionsFunction, QuestDefinitionsOutputDTO>(questDefinitionsFunction, blockParameter);
        }

        public Task<List<BigInteger>> ActiveQuestIdsForAccountQueryAsync(ActiveQuestIdsForAccountFunction activeQuestIdsForAccountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ActiveQuestIdsForAccountFunction, List<BigInteger>>(activeQuestIdsForAccountFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> ActiveQuestIdsForAccountQueryAsync(string account, BlockParameter blockParameter = null)
        {
            var activeQuestIdsForAccountFunction = new ActiveQuestIdsForAccountFunction();
                activeQuestIdsForAccountFunction.Account = account;
            
            return ContractHandler.QueryAsync<ActiveQuestIdsForAccountFunction, List<BigInteger>>(activeQuestIdsForAccountFunction, blockParameter);
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

        public Task<GetActiveQuestOutputDTO> GetActiveQuestQueryAsync(GetActiveQuestFunction getActiveQuestFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetActiveQuestFunction, GetActiveQuestOutputDTO>(getActiveQuestFunction, blockParameter);
        }

        public Task<GetActiveQuestOutputDTO> GetActiveQuestQueryAsync(BigInteger activeQuestId, BlockParameter blockParameter = null)
        {
            var getActiveQuestFunction = new GetActiveQuestFunction();
                getActiveQuestFunction.ActiveQuestId = activeQuestId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetActiveQuestFunction, GetActiveQuestOutputDTO>(getActiveQuestFunction, blockParameter);
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

        public Task<GetQuestDataForAccountOutputDTO> GetQuestDataForAccountQueryAsync(GetQuestDataForAccountFunction getQuestDataForAccountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetQuestDataForAccountFunction, GetQuestDataForAccountOutputDTO>(getQuestDataForAccountFunction, blockParameter);
        }

        public Task<GetQuestDataForAccountOutputDTO> GetQuestDataForAccountQueryAsync(string account, uint questId, BlockParameter blockParameter = null)
        {
            var getQuestDataForAccountFunction = new GetQuestDataForAccountFunction();
                getQuestDataForAccountFunction.Account = account;
                getQuestDataForAccountFunction.QuestId = questId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetQuestDataForAccountFunction, GetQuestDataForAccountOutputDTO>(getQuestDataForAccountFunction, blockParameter);
        }

        public Task<GetQuestDefinitionOutputDTO> GetQuestDefinitionQueryAsync(GetQuestDefinitionFunction getQuestDefinitionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetQuestDefinitionFunction, GetQuestDefinitionOutputDTO>(getQuestDefinitionFunction, blockParameter);
        }

        public Task<GetQuestDefinitionOutputDTO> GetQuestDefinitionQueryAsync(uint questId, BlockParameter blockParameter = null)
        {
            var getQuestDefinitionFunction = new GetQuestDefinitionFunction();
                getQuestDefinitionFunction.QuestId = questId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetQuestDefinitionFunction, GetQuestDefinitionOutputDTO>(getQuestDefinitionFunction, blockParameter);
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

        public Task<bool> IsQuestAvailableQueryAsync(IsQuestAvailableFunction isQuestAvailableFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsQuestAvailableFunction, bool>(isQuestAvailableFunction, blockParameter);
        }

        
        public Task<bool> IsQuestAvailableQueryAsync(string account, uint questId, BlockParameter blockParameter = null)
        {
            var isQuestAvailableFunction = new IsQuestAvailableFunction();
                isQuestAvailableFunction.Account = account;
                isQuestAvailableFunction.QuestId = questId;
            
            return ContractHandler.QueryAsync<IsQuestAvailableFunction, bool>(isQuestAvailableFunction, blockParameter);
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

        public Task<string> SetQuestDefinitionRequestAsync(SetQuestDefinitionFunction setQuestDefinitionFunction)
        {
             return ContractHandler.SendRequestAsync(setQuestDefinitionFunction);
        }

        public Task<TransactionReceipt> SetQuestDefinitionRequestAndWaitForReceiptAsync(SetQuestDefinitionFunction setQuestDefinitionFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setQuestDefinitionFunction, cancellationToken);
        }

        public Task<string> SetQuestDefinitionRequestAsync(uint questId, QuestDefinition definition)
        {
            var setQuestDefinitionFunction = new SetQuestDefinitionFunction();
                setQuestDefinitionFunction.QuestId = questId;
                setQuestDefinitionFunction.Definition = definition;
            
             return ContractHandler.SendRequestAsync(setQuestDefinitionFunction);
        }

        public Task<TransactionReceipt> SetQuestDefinitionRequestAndWaitForReceiptAsync(uint questId, QuestDefinition definition, CancellationTokenSource cancellationToken = null)
        {
            var setQuestDefinitionFunction = new SetQuestDefinitionFunction();
                setQuestDefinitionFunction.QuestId = questId;
                setQuestDefinitionFunction.Definition = definition;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setQuestDefinitionFunction, cancellationToken);
        }

        public Task<string> SetQuestEnabledRequestAsync(SetQuestEnabledFunction setQuestEnabledFunction)
        {
             return ContractHandler.SendRequestAsync(setQuestEnabledFunction);
        }

        public Task<TransactionReceipt> SetQuestEnabledRequestAndWaitForReceiptAsync(SetQuestEnabledFunction setQuestEnabledFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setQuestEnabledFunction, cancellationToken);
        }

        public Task<string> SetQuestEnabledRequestAsync(uint questId, bool enabled)
        {
            var setQuestEnabledFunction = new SetQuestEnabledFunction();
                setQuestEnabledFunction.QuestId = questId;
                setQuestEnabledFunction.Enabled = enabled;
            
             return ContractHandler.SendRequestAsync(setQuestEnabledFunction);
        }

        public Task<TransactionReceipt> SetQuestEnabledRequestAndWaitForReceiptAsync(uint questId, bool enabled, CancellationTokenSource cancellationToken = null)
        {
            var setQuestEnabledFunction = new SetQuestEnabledFunction();
                setQuestEnabledFunction.QuestId = questId;
                setQuestEnabledFunction.Enabled = enabled;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setQuestEnabledFunction, cancellationToken);
        }

        public Task<string> StartQuestRequestAsync(StartQuestFunction startQuestFunction)
        {
             return ContractHandler.SendRequestAsync(startQuestFunction);
        }

        public Task<TransactionReceipt> StartQuestRequestAndWaitForReceiptAsync(StartQuestFunction startQuestFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(startQuestFunction, cancellationToken);
        }

        public Task<string> StartQuestRequestAsync(QuestParams @params)
        {
            var startQuestFunction = new StartQuestFunction();
                startQuestFunction.Params = @params;
            
             return ContractHandler.SendRequestAsync(startQuestFunction);
        }

        public Task<TransactionReceipt> StartQuestRequestAndWaitForReceiptAsync(QuestParams @params, CancellationTokenSource cancellationToken = null)
        {
            var startQuestFunction = new StartQuestFunction();
                startQuestFunction.Params = @params;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(startQuestFunction, cancellationToken);
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

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
using PirateNationContracts.CraftingSystem_Implementation.ContractDefinition;

namespace PirateNationContracts.CraftingSystem_Implementation
{
    public partial class CraftingsystemImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, CraftingsystemImplementationDeployment craftingsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<CraftingsystemImplementationDeployment>().SendRequestAndWaitForReceiptAsync(craftingsystemImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, CraftingsystemImplementationDeployment craftingsystemImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<CraftingsystemImplementationDeployment>().SendRequestAsync(craftingsystemImplementationDeployment);
        }

        public static async Task<CraftingsystemImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, CraftingsystemImplementationDeployment craftingsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, craftingsystemImplementationDeployment, cancellationTokenSource);
            return new CraftingsystemImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public CraftingsystemImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<List<BigInteger>> ActiveCraftIdsForAccountQueryAsync(ActiveCraftIdsForAccountFunction activeCraftIdsForAccountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ActiveCraftIdsForAccountFunction, List<BigInteger>>(activeCraftIdsForAccountFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> ActiveCraftIdsForAccountQueryAsync(string account, BlockParameter blockParameter = null)
        {
            var activeCraftIdsForAccountFunction = new ActiveCraftIdsForAccountFunction();
                activeCraftIdsForAccountFunction.Account = account;
            
            return ContractHandler.QueryAsync<ActiveCraftIdsForAccountFunction, List<BigInteger>>(activeCraftIdsForAccountFunction, blockParameter);
        }

        public Task<string> CraftRequestAsync(CraftFunction craftFunction)
        {
             return ContractHandler.SendRequestAsync(craftFunction);
        }

        public Task<TransactionReceipt> CraftRequestAndWaitForReceiptAsync(CraftFunction craftFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(craftFunction, cancellationToken);
        }

        public Task<string> CraftRequestAsync(CraftParams @params)
        {
            var craftFunction = new CraftFunction();
                craftFunction.Params = @params;
            
             return ContractHandler.SendRequestAsync(craftFunction);
        }

        public Task<TransactionReceipt> CraftRequestAndWaitForReceiptAsync(CraftParams @params, CancellationTokenSource cancellationToken = null)
        {
            var craftFunction = new CraftFunction();
                craftFunction.Params = @params;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(craftFunction, cancellationToken);
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

        public Task<GetActiveCraftOutputDTO> GetActiveCraftQueryAsync(GetActiveCraftFunction getActiveCraftFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetActiveCraftFunction, GetActiveCraftOutputDTO>(getActiveCraftFunction, blockParameter);
        }

        public Task<GetActiveCraftOutputDTO> GetActiveCraftQueryAsync(BigInteger activeCraftId, BlockParameter blockParameter = null)
        {
            var getActiveCraftFunction = new GetActiveCraftFunction();
                getActiveCraftFunction.ActiveCraftId = activeCraftId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetActiveCraftFunction, GetActiveCraftOutputDTO>(getActiveCraftFunction, blockParameter);
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

        public Task<GetRecipeDataForAccountOutputDTO> GetRecipeDataForAccountQueryAsync(GetRecipeDataForAccountFunction getRecipeDataForAccountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetRecipeDataForAccountFunction, GetRecipeDataForAccountOutputDTO>(getRecipeDataForAccountFunction, blockParameter);
        }

        public Task<GetRecipeDataForAccountOutputDTO> GetRecipeDataForAccountQueryAsync(string account, uint recipeId, BlockParameter blockParameter = null)
        {
            var getRecipeDataForAccountFunction = new GetRecipeDataForAccountFunction();
                getRecipeDataForAccountFunction.Account = account;
                getRecipeDataForAccountFunction.RecipeId = recipeId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetRecipeDataForAccountFunction, GetRecipeDataForAccountOutputDTO>(getRecipeDataForAccountFunction, blockParameter);
        }

        public Task<GetRecipeDefinitionOutputDTO> GetRecipeDefinitionQueryAsync(GetRecipeDefinitionFunction getRecipeDefinitionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetRecipeDefinitionFunction, GetRecipeDefinitionOutputDTO>(getRecipeDefinitionFunction, blockParameter);
        }

        public Task<GetRecipeDefinitionOutputDTO> GetRecipeDefinitionQueryAsync(uint recipeId, BlockParameter blockParameter = null)
        {
            var getRecipeDefinitionFunction = new GetRecipeDefinitionFunction();
                getRecipeDefinitionFunction.RecipeId = recipeId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetRecipeDefinitionFunction, GetRecipeDefinitionOutputDTO>(getRecipeDefinitionFunction, blockParameter);
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

        public Task<bool> IsRecipeAvailableQueryAsync(IsRecipeAvailableFunction isRecipeAvailableFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsRecipeAvailableFunction, bool>(isRecipeAvailableFunction, blockParameter);
        }

        
        public Task<bool> IsRecipeAvailableQueryAsync(string account, uint recipeId, BlockParameter blockParameter = null)
        {
            var isRecipeAvailableFunction = new IsRecipeAvailableFunction();
                isRecipeAvailableFunction.Account = account;
                isRecipeAvailableFunction.RecipeId = recipeId;
            
            return ContractHandler.QueryAsync<IsRecipeAvailableFunction, bool>(isRecipeAvailableFunction, blockParameter);
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

        public Task<string> SetRecipeDefinitionRequestAsync(SetRecipeDefinitionFunction setRecipeDefinitionFunction)
        {
             return ContractHandler.SendRequestAsync(setRecipeDefinitionFunction);
        }

        public Task<TransactionReceipt> SetRecipeDefinitionRequestAndWaitForReceiptAsync(SetRecipeDefinitionFunction setRecipeDefinitionFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setRecipeDefinitionFunction, cancellationToken);
        }

        public Task<string> SetRecipeDefinitionRequestAsync(uint recipeId, RecipeDefinition definition)
        {
            var setRecipeDefinitionFunction = new SetRecipeDefinitionFunction();
                setRecipeDefinitionFunction.RecipeId = recipeId;
                setRecipeDefinitionFunction.Definition = definition;
            
             return ContractHandler.SendRequestAsync(setRecipeDefinitionFunction);
        }

        public Task<TransactionReceipt> SetRecipeDefinitionRequestAndWaitForReceiptAsync(uint recipeId, RecipeDefinition definition, CancellationTokenSource cancellationToken = null)
        {
            var setRecipeDefinitionFunction = new SetRecipeDefinitionFunction();
                setRecipeDefinitionFunction.RecipeId = recipeId;
                setRecipeDefinitionFunction.Definition = definition;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setRecipeDefinitionFunction, cancellationToken);
        }

        public Task<string> SetRecipeEnabledRequestAsync(SetRecipeEnabledFunction setRecipeEnabledFunction)
        {
             return ContractHandler.SendRequestAsync(setRecipeEnabledFunction);
        }

        public Task<TransactionReceipt> SetRecipeEnabledRequestAndWaitForReceiptAsync(SetRecipeEnabledFunction setRecipeEnabledFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setRecipeEnabledFunction, cancellationToken);
        }

        public Task<string> SetRecipeEnabledRequestAsync(uint recipeId, bool enabled)
        {
            var setRecipeEnabledFunction = new SetRecipeEnabledFunction();
                setRecipeEnabledFunction.RecipeId = recipeId;
                setRecipeEnabledFunction.Enabled = enabled;
            
             return ContractHandler.SendRequestAsync(setRecipeEnabledFunction);
        }

        public Task<TransactionReceipt> SetRecipeEnabledRequestAndWaitForReceiptAsync(uint recipeId, bool enabled, CancellationTokenSource cancellationToken = null)
        {
            var setRecipeEnabledFunction = new SetRecipeEnabledFunction();
                setRecipeEnabledFunction.RecipeId = recipeId;
                setRecipeEnabledFunction.Enabled = enabled;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setRecipeEnabledFunction, cancellationToken);
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

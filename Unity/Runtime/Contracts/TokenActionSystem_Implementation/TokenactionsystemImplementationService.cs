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
using PirateNationContracts.TokenActionSystem_Implementation.ContractDefinition;

namespace PirateNationContracts.TokenActionSystem_Implementation
{
    public partial class TokenactionsystemImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, TokenactionsystemImplementationDeployment tokenactionsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<TokenactionsystemImplementationDeployment>().SendRequestAndWaitForReceiptAsync(tokenactionsystemImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, TokenactionsystemImplementationDeployment tokenactionsystemImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<TokenactionsystemImplementationDeployment>().SendRequestAsync(tokenactionsystemImplementationDeployment);
        }

        public static async Task<TokenactionsystemImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, TokenactionsystemImplementationDeployment tokenactionsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, tokenactionsystemImplementationDeployment, cancellationTokenSource);
            return new TokenactionsystemImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public TokenactionsystemImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
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

        public Task<GetActionForTokenOutputDTO> GetActionForTokenQueryAsync(GetActionForTokenFunction getActionForTokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetActionForTokenFunction, GetActionForTokenOutputDTO>(getActionForTokenFunction, blockParameter);
        }

        public Task<GetActionForTokenOutputDTO> GetActionForTokenQueryAsync(string tokenContract, BigInteger tokenId, BigInteger actionId, BlockParameter blockParameter = null)
        {
            var getActionForTokenFunction = new GetActionForTokenFunction();
                getActionForTokenFunction.TokenContract = tokenContract;
                getActionForTokenFunction.TokenId = tokenId;
                getActionForTokenFunction.ActionId = actionId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetActionForTokenFunction, GetActionForTokenOutputDTO>(getActionForTokenFunction, blockParameter);
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

        public Task<string> GetTokenActionContractQueryAsync(GetTokenActionContractFunction getTokenActionContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTokenActionContractFunction, string>(getTokenActionContractFunction, blockParameter);
        }

        
        public Task<string> GetTokenActionContractQueryAsync(BigInteger actionId, BlockParameter blockParameter = null)
        {
            var getTokenActionContractFunction = new GetTokenActionContractFunction();
                getTokenActionContractFunction.ActionId = actionId;
            
            return ContractHandler.QueryAsync<GetTokenActionContractFunction, string>(getTokenActionContractFunction, blockParameter);
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

        public Task<string> PerformGameItemActionRequestAsync(PerformGameItemActionFunction performGameItemActionFunction)
        {
             return ContractHandler.SendRequestAsync(performGameItemActionFunction);
        }

        public Task<TransactionReceipt> PerformGameItemActionRequestAndWaitForReceiptAsync(PerformGameItemActionFunction performGameItemActionFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(performGameItemActionFunction, cancellationToken);
        }

        public Task<string> PerformGameItemActionRequestAsync(string tokenContract, BigInteger tokenId, BigInteger amount, BigInteger actionId, byte[] runtimeData)
        {
            var performGameItemActionFunction = new PerformGameItemActionFunction();
                performGameItemActionFunction.TokenContract = tokenContract;
                performGameItemActionFunction.TokenId = tokenId;
                performGameItemActionFunction.Amount = amount;
                performGameItemActionFunction.ActionId = actionId;
                performGameItemActionFunction.RuntimeData = runtimeData;
            
             return ContractHandler.SendRequestAsync(performGameItemActionFunction);
        }

        public Task<TransactionReceipt> PerformGameItemActionRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, BigInteger amount, BigInteger actionId, byte[] runtimeData, CancellationTokenSource cancellationToken = null)
        {
            var performGameItemActionFunction = new PerformGameItemActionFunction();
                performGameItemActionFunction.TokenContract = tokenContract;
                performGameItemActionFunction.TokenId = tokenId;
                performGameItemActionFunction.Amount = amount;
                performGameItemActionFunction.ActionId = actionId;
                performGameItemActionFunction.RuntimeData = runtimeData;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(performGameItemActionFunction, cancellationToken);
        }

        public Task<string> RegisterTokenActionContractRequestAsync(RegisterTokenActionContractFunction registerTokenActionContractFunction)
        {
             return ContractHandler.SendRequestAsync(registerTokenActionContractFunction);
        }

        public Task<TransactionReceipt> RegisterTokenActionContractRequestAndWaitForReceiptAsync(RegisterTokenActionContractFunction registerTokenActionContractFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerTokenActionContractFunction, cancellationToken);
        }

        public Task<string> RegisterTokenActionContractRequestAsync(string actionName, string tokenActionContract)
        {
            var registerTokenActionContractFunction = new RegisterTokenActionContractFunction();
                registerTokenActionContractFunction.ActionName = actionName;
                registerTokenActionContractFunction.TokenActionContract = tokenActionContract;
            
             return ContractHandler.SendRequestAsync(registerTokenActionContractFunction);
        }

        public Task<TransactionReceipt> RegisterTokenActionContractRequestAndWaitForReceiptAsync(string actionName, string tokenActionContract, CancellationTokenSource cancellationToken = null)
        {
            var registerTokenActionContractFunction = new RegisterTokenActionContractFunction();
                registerTokenActionContractFunction.ActionName = actionName;
                registerTokenActionContractFunction.TokenActionContract = tokenActionContract;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerTokenActionContractFunction, cancellationToken);
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

        public Task<string> SetActionForTokenRequestAsync(SetActionForTokenFunction setActionForTokenFunction)
        {
             return ContractHandler.SendRequestAsync(setActionForTokenFunction);
        }

        public Task<TransactionReceipt> SetActionForTokenRequestAndWaitForReceiptAsync(SetActionForTokenFunction setActionForTokenFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setActionForTokenFunction, cancellationToken);
        }

        public Task<string> SetActionForTokenRequestAsync(string tokenContract, BigInteger tokenId, BigInteger actionId, ActionProps actionProps)
        {
            var setActionForTokenFunction = new SetActionForTokenFunction();
                setActionForTokenFunction.TokenContract = tokenContract;
                setActionForTokenFunction.TokenId = tokenId;
                setActionForTokenFunction.ActionId = actionId;
                setActionForTokenFunction.ActionProps = actionProps;
            
             return ContractHandler.SendRequestAsync(setActionForTokenFunction);
        }

        public Task<TransactionReceipt> SetActionForTokenRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, BigInteger actionId, ActionProps actionProps, CancellationTokenSource cancellationToken = null)
        {
            var setActionForTokenFunction = new SetActionForTokenFunction();
                setActionForTokenFunction.TokenContract = tokenContract;
                setActionForTokenFunction.TokenId = tokenId;
                setActionForTokenFunction.ActionId = actionId;
                setActionForTokenFunction.ActionProps = actionProps;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setActionForTokenFunction, cancellationToken);
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

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
using PirateNationContracts.GameItems.ContractDefinition;

namespace PirateNationContracts.GameItems
{
    public partial class GameItemsService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, GameItemsDeployment gameItemsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<GameItemsDeployment>().SendRequestAndWaitForReceiptAsync(gameItemsDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, GameItemsDeployment gameItemsDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<GameItemsDeployment>().SendRequestAsync(gameItemsDeployment);
        }

        public static async Task<GameItemsService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, GameItemsDeployment gameItemsDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, gameItemsDeployment, cancellationTokenSource);
            return new GameItemsService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public GameItemsService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<byte[]> ItraitsconsumerInterfaceidQueryAsync(ItraitsconsumerInterfaceidFunction itraitsconsumerInterfaceidFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ItraitsconsumerInterfaceidFunction, byte[]>(itraitsconsumerInterfaceidFunction, blockParameter);
        }

        
        public Task<byte[]> ItraitsconsumerInterfaceidQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ItraitsconsumerInterfaceidFunction, byte[]>(null, blockParameter);
        }

        public Task<string> BaseExternalURIQueryAsync(BaseExternalURIFunction baseExternalURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BaseExternalURIFunction, string>(baseExternalURIFunction, blockParameter);
        }

        
        public Task<string> BaseExternalURIQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BaseExternalURIFunction, string>(null, blockParameter);
        }

        public Task<string> BaseImageURIQueryAsync(BaseImageURIFunction baseImageURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BaseImageURIFunction, string>(baseImageURIFunction, blockParameter);
        }

        
        public Task<string> BaseImageURIQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BaseImageURIFunction, string>(null, blockParameter);
        }

        public Task<string> DefaultDescriptionQueryAsync(DefaultDescriptionFunction defaultDescriptionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DefaultDescriptionFunction, string>(defaultDescriptionFunction, blockParameter);
        }

        
        public Task<string> DefaultDescriptionQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DefaultDescriptionFunction, string>(null, blockParameter);
        }

        public Task<string> DefaultImageURIQueryAsync(DefaultImageURIFunction defaultImageURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DefaultImageURIFunction, string>(defaultImageURIFunction, blockParameter);
        }

        
        public Task<string> DefaultImageURIQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DefaultImageURIFunction, string>(null, blockParameter);
        }

        public Task<string> OverrideURIQueryAsync(OverrideURIFunction overrideURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OverrideURIFunction, string>(overrideURIFunction, blockParameter);
        }

        
        public Task<string> OverrideURIQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OverrideURIFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        
        public Task<BigInteger> BalanceOfQueryAsync(string account, BigInteger id, BlockParameter blockParameter = null)
        {
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.Account = account;
                balanceOfFunction.Id = id;
            
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public Task<List<BigInteger>> BalanceOfBatchQueryAsync(BalanceOfBatchFunction balanceOfBatchFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfBatchFunction, List<BigInteger>>(balanceOfBatchFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> BalanceOfBatchQueryAsync(List<string> accounts, List<BigInteger> ids, BlockParameter blockParameter = null)
        {
            var balanceOfBatchFunction = new BalanceOfBatchFunction();
                balanceOfBatchFunction.Accounts = accounts;
                balanceOfBatchFunction.Ids = ids;
            
            return ContractHandler.QueryAsync<BalanceOfBatchFunction, List<BigInteger>>(balanceOfBatchFunction, blockParameter);
        }

        public Task<string> BeforeTokenTransferHandlerQueryAsync(BeforeTokenTransferHandlerFunction beforeTokenTransferHandlerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BeforeTokenTransferHandlerFunction, string>(beforeTokenTransferHandlerFunction, blockParameter);
        }

        
        public Task<string> BeforeTokenTransferHandlerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BeforeTokenTransferHandlerFunction, string>(null, blockParameter);
        }

        public Task<string> BurnRequestAsync(BurnFunction burnFunction)
        {
             return ContractHandler.SendRequestAsync(burnFunction);
        }

        public Task<TransactionReceipt> BurnRequestAndWaitForReceiptAsync(BurnFunction burnFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(burnFunction, cancellationToken);
        }

        public Task<string> BurnRequestAsync(string from, BigInteger id, BigInteger amount)
        {
            var burnFunction = new BurnFunction();
                burnFunction.From = from;
                burnFunction.Id = id;
                burnFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(burnFunction);
        }

        public Task<TransactionReceipt> BurnRequestAndWaitForReceiptAsync(string from, BigInteger id, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var burnFunction = new BurnFunction();
                burnFunction.From = from;
                burnFunction.Id = id;
                burnFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(burnFunction, cancellationToken);
        }

        public Task<string> ContractURIQueryAsync(ContractURIFunction contractURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractURIFunction, string>(contractURIFunction, blockParameter);
        }

        
        public Task<string> ContractURIQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractURIFunction, string>(null, blockParameter);
        }

        public Task<string> ExternalURIQueryAsync(ExternalURIFunction externalURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ExternalURIFunction, string>(externalURIFunction, blockParameter);
        }

        
        public Task<string> ExternalURIQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var externalURIFunction = new ExternalURIFunction();
                externalURIFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<ExternalURIFunction, string>(externalURIFunction, blockParameter);
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

        public Task<GetInfoForTypeOutputDTO> GetInfoForTypeQueryAsync(GetInfoForTypeFunction getInfoForTypeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetInfoForTypeFunction, GetInfoForTypeOutputDTO>(getInfoForTypeFunction, blockParameter);
        }

        public Task<GetInfoForTypeOutputDTO> GetInfoForTypeQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var getInfoForTypeFunction = new GetInfoForTypeFunction();
                getInfoForTypeFunction.Id = id;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetInfoForTypeFunction, GetInfoForTypeOutputDTO>(getInfoForTypeFunction, blockParameter);
        }

        public Task<string> ImageURIQueryAsync(ImageURIFunction imageURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ImageURIFunction, string>(imageURIFunction, blockParameter);
        }

        
        public Task<string> ImageURIQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var imageURIFunction = new ImageURIFunction();
                imageURIFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<ImageURIFunction, string>(imageURIFunction, blockParameter);
        }

        public Task<bool> IsApprovedForAllQueryAsync(IsApprovedForAllFunction isApprovedForAllFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
        }

        
        public Task<bool> IsApprovedForAllQueryAsync(string account, string @operator, BlockParameter blockParameter = null)
        {
            var isApprovedForAllFunction = new IsApprovedForAllFunction();
                isApprovedForAllFunction.Account = account;
                isApprovedForAllFunction.Operator = @operator;
            
            return ContractHandler.QueryAsync<IsApprovedForAllFunction, bool>(isApprovedForAllFunction, blockParameter);
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

        public Task<string> MintRequestAsync(MintFunction mintFunction)
        {
             return ContractHandler.SendRequestAsync(mintFunction);
        }

        public Task<TransactionReceipt> MintRequestAndWaitForReceiptAsync(MintFunction mintFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintFunction, cancellationToken);
        }

        public Task<string> MintRequestAsync(string to, BigInteger id, BigInteger amount)
        {
            var mintFunction = new MintFunction();
                mintFunction.To = to;
                mintFunction.Id = id;
                mintFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(mintFunction);
        }

        public Task<TransactionReceipt> MintRequestAndWaitForReceiptAsync(string to, BigInteger id, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var mintFunction = new MintFunction();
                mintFunction.To = to;
                mintFunction.Id = id;
                mintFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintFunction, cancellationToken);
        }

        public Task<string> MintForTestsRequestAsync(MintForTestsFunction mintForTestsFunction)
        {
             return ContractHandler.SendRequestAsync(mintForTestsFunction);
        }

        public Task<TransactionReceipt> MintForTestsRequestAndWaitForReceiptAsync(MintForTestsFunction mintForTestsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintForTestsFunction, cancellationToken);
        }

        public Task<string> MintForTestsRequestAsync(uint tokenId, BigInteger amount)
        {
            var mintForTestsFunction = new MintForTestsFunction();
                mintForTestsFunction.TokenId = tokenId;
                mintForTestsFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(mintForTestsFunction);
        }

        public Task<TransactionReceipt> MintForTestsRequestAndWaitForReceiptAsync(uint tokenId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var mintForTestsFunction = new MintForTestsFunction();
                mintForTestsFunction.TokenId = tokenId;
                mintForTestsFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintForTestsFunction, cancellationToken);
        }

        public Task<BigInteger> MintedQueryAsync(MintedFunction mintedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MintedFunction, BigInteger>(mintedFunction, blockParameter);
        }

        
        public Task<BigInteger> MintedQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var mintedFunction = new MintedFunction();
                mintedFunction.Id = id;
            
            return ContractHandler.QueryAsync<MintedFunction, BigInteger>(mintedFunction, blockParameter);
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

        public Task<string> SafeBatchTransferFromRequestAsync(SafeBatchTransferFromFunction safeBatchTransferFromFunction)
        {
             return ContractHandler.SendRequestAsync(safeBatchTransferFromFunction);
        }

        public Task<TransactionReceipt> SafeBatchTransferFromRequestAndWaitForReceiptAsync(SafeBatchTransferFromFunction safeBatchTransferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeBatchTransferFromFunction, cancellationToken);
        }

        public Task<string> SafeBatchTransferFromRequestAsync(string from, string to, List<BigInteger> ids, List<BigInteger> amounts, byte[] data)
        {
            var safeBatchTransferFromFunction = new SafeBatchTransferFromFunction();
                safeBatchTransferFromFunction.From = from;
                safeBatchTransferFromFunction.To = to;
                safeBatchTransferFromFunction.Ids = ids;
                safeBatchTransferFromFunction.Amounts = amounts;
                safeBatchTransferFromFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(safeBatchTransferFromFunction);
        }

        public Task<TransactionReceipt> SafeBatchTransferFromRequestAndWaitForReceiptAsync(string from, string to, List<BigInteger> ids, List<BigInteger> amounts, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var safeBatchTransferFromFunction = new SafeBatchTransferFromFunction();
                safeBatchTransferFromFunction.From = from;
                safeBatchTransferFromFunction.To = to;
                safeBatchTransferFromFunction.Ids = ids;
                safeBatchTransferFromFunction.Amounts = amounts;
                safeBatchTransferFromFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeBatchTransferFromFunction, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(SafeTransferFromFunction safeTransferFromFunction)
        {
             return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFromFunction safeTransferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger id, BigInteger amount, byte[] data)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.Id = id;
                safeTransferFromFunction.Amount = amount;
                safeTransferFromFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger id, BigInteger amount, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.Id = id;
                safeTransferFromFunction.Amount = amount;
                safeTransferFromFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public Task<string> SetApprovalForAllRequestAsync(SetApprovalForAllFunction setApprovalForAllFunction)
        {
             return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(SetApprovalForAllFunction setApprovalForAllFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public Task<string> SetApprovalForAllRequestAsync(string @operator, bool approved)
        {
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
             return ContractHandler.SendRequestAsync(setApprovalForAllFunction);
        }

        public Task<TransactionReceipt> SetApprovalForAllRequestAndWaitForReceiptAsync(string @operator, bool approved, CancellationTokenSource cancellationToken = null)
        {
            var setApprovalForAllFunction = new SetApprovalForAllFunction();
                setApprovalForAllFunction.Operator = @operator;
                setApprovalForAllFunction.Approved = approved;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setApprovalForAllFunction, cancellationToken);
        }

        public Task<string> SetBaseExternalURIRequestAsync(SetBaseExternalURIFunction setBaseExternalURIFunction)
        {
             return ContractHandler.SendRequestAsync(setBaseExternalURIFunction);
        }

        public Task<TransactionReceipt> SetBaseExternalURIRequestAndWaitForReceiptAsync(SetBaseExternalURIFunction setBaseExternalURIFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBaseExternalURIFunction, cancellationToken);
        }

        public Task<string> SetBaseExternalURIRequestAsync(string newURI)
        {
            var setBaseExternalURIFunction = new SetBaseExternalURIFunction();
                setBaseExternalURIFunction.NewURI = newURI;
            
             return ContractHandler.SendRequestAsync(setBaseExternalURIFunction);
        }

        public Task<TransactionReceipt> SetBaseExternalURIRequestAndWaitForReceiptAsync(string newURI, CancellationTokenSource cancellationToken = null)
        {
            var setBaseExternalURIFunction = new SetBaseExternalURIFunction();
                setBaseExternalURIFunction.NewURI = newURI;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBaseExternalURIFunction, cancellationToken);
        }

        public Task<string> SetBaseImageURIRequestAsync(SetBaseImageURIFunction setBaseImageURIFunction)
        {
             return ContractHandler.SendRequestAsync(setBaseImageURIFunction);
        }

        public Task<TransactionReceipt> SetBaseImageURIRequestAndWaitForReceiptAsync(SetBaseImageURIFunction setBaseImageURIFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBaseImageURIFunction, cancellationToken);
        }

        public Task<string> SetBaseImageURIRequestAsync(string newURI)
        {
            var setBaseImageURIFunction = new SetBaseImageURIFunction();
                setBaseImageURIFunction.NewURI = newURI;
            
             return ContractHandler.SendRequestAsync(setBaseImageURIFunction);
        }

        public Task<TransactionReceipt> SetBaseImageURIRequestAndWaitForReceiptAsync(string newURI, CancellationTokenSource cancellationToken = null)
        {
            var setBaseImageURIFunction = new SetBaseImageURIFunction();
                setBaseImageURIFunction.NewURI = newURI;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBaseImageURIFunction, cancellationToken);
        }

        public Task<string> SetBeforeTokenTransferHandlerRequestAsync(SetBeforeTokenTransferHandlerFunction setBeforeTokenTransferHandlerFunction)
        {
             return ContractHandler.SendRequestAsync(setBeforeTokenTransferHandlerFunction);
        }

        public Task<TransactionReceipt> SetBeforeTokenTransferHandlerRequestAndWaitForReceiptAsync(SetBeforeTokenTransferHandlerFunction setBeforeTokenTransferHandlerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBeforeTokenTransferHandlerFunction, cancellationToken);
        }

        public Task<string> SetBeforeTokenTransferHandlerRequestAsync(string handlerAddress)
        {
            var setBeforeTokenTransferHandlerFunction = new SetBeforeTokenTransferHandlerFunction();
                setBeforeTokenTransferHandlerFunction.HandlerAddress = handlerAddress;
            
             return ContractHandler.SendRequestAsync(setBeforeTokenTransferHandlerFunction);
        }

        public Task<TransactionReceipt> SetBeforeTokenTransferHandlerRequestAndWaitForReceiptAsync(string handlerAddress, CancellationTokenSource cancellationToken = null)
        {
            var setBeforeTokenTransferHandlerFunction = new SetBeforeTokenTransferHandlerFunction();
                setBeforeTokenTransferHandlerFunction.HandlerAddress = handlerAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBeforeTokenTransferHandlerFunction, cancellationToken);
        }

        public Task<string> SetContractURIRequestAsync(SetContractURIFunction setContractURIFunction)
        {
             return ContractHandler.SendRequestAsync(setContractURIFunction);
        }

        public Task<TransactionReceipt> SetContractURIRequestAndWaitForReceiptAsync(SetContractURIFunction setContractURIFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setContractURIFunction, cancellationToken);
        }

        public Task<string> SetContractURIRequestAsync(string uri)
        {
            var setContractURIFunction = new SetContractURIFunction();
                setContractURIFunction.Uri = uri;
            
             return ContractHandler.SendRequestAsync(setContractURIFunction);
        }

        public Task<TransactionReceipt> SetContractURIRequestAndWaitForReceiptAsync(string uri, CancellationTokenSource cancellationToken = null)
        {
            var setContractURIFunction = new SetContractURIFunction();
                setContractURIFunction.Uri = uri;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setContractURIFunction, cancellationToken);
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

        public Task<string> SetTokenURIHandlerRequestAsync(SetTokenURIHandlerFunction setTokenURIHandlerFunction)
        {
             return ContractHandler.SendRequestAsync(setTokenURIHandlerFunction);
        }

        public Task<TransactionReceipt> SetTokenURIHandlerRequestAndWaitForReceiptAsync(SetTokenURIHandlerFunction setTokenURIHandlerFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTokenURIHandlerFunction, cancellationToken);
        }

        public Task<string> SetTokenURIHandlerRequestAsync(string handler)
        {
            var setTokenURIHandlerFunction = new SetTokenURIHandlerFunction();
                setTokenURIHandlerFunction.Handler = handler;
            
             return ContractHandler.SendRequestAsync(setTokenURIHandlerFunction);
        }

        public Task<TransactionReceipt> SetTokenURIHandlerRequestAndWaitForReceiptAsync(string handler, CancellationTokenSource cancellationToken = null)
        {
            var setTokenURIHandlerFunction = new SetTokenURIHandlerFunction();
                setTokenURIHandlerFunction.Handler = handler;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTokenURIHandlerFunction, cancellationToken);
        }

        public Task<string> SetTypeRequestAsync(SetTypeFunction setTypeFunction)
        {
             return ContractHandler.SendRequestAsync(setTypeFunction);
        }

        public Task<TransactionReceipt> SetTypeRequestAndWaitForReceiptAsync(SetTypeFunction setTypeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTypeFunction, cancellationToken);
        }

        public Task<string> SetTypeRequestAsync(BigInteger id, BigInteger maxSupply, bool recyclable)
        {
            var setTypeFunction = new SetTypeFunction();
                setTypeFunction.Id = id;
                setTypeFunction.MaxSupply = maxSupply;
                setTypeFunction.Recyclable = recyclable;
            
             return ContractHandler.SendRequestAsync(setTypeFunction);
        }

        public Task<TransactionReceipt> SetTypeRequestAndWaitForReceiptAsync(BigInteger id, BigInteger maxSupply, bool recyclable, CancellationTokenSource cancellationToken = null)
        {
            var setTypeFunction = new SetTypeFunction();
                setTypeFunction.Id = id;
                setTypeFunction.MaxSupply = maxSupply;
                setTypeFunction.Recyclable = recyclable;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTypeFunction, cancellationToken);
        }

        public Task<string> SetURIRequestAsync(SetURIFunction setURIFunction)
        {
             return ContractHandler.SendRequestAsync(setURIFunction);
        }

        public Task<TransactionReceipt> SetURIRequestAndWaitForReceiptAsync(SetURIFunction setURIFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setURIFunction, cancellationToken);
        }

        public Task<string> SetURIRequestAsync(string newURI)
        {
            var setURIFunction = new SetURIFunction();
                setURIFunction.NewURI = newURI;
            
             return ContractHandler.SendRequestAsync(setURIFunction);
        }

        public Task<TransactionReceipt> SetURIRequestAndWaitForReceiptAsync(string newURI, CancellationTokenSource cancellationToken = null)
        {
            var setURIFunction = new SetURIFunction();
                setURIFunction.NewURI = newURI;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setURIFunction, cancellationToken);
        }

        public Task<bool> SupportsInterfaceQueryAsync(SupportsInterfaceFunction supportsInterfaceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        
        public Task<bool> SupportsInterfaceQueryAsync(byte[] interfaceId, BlockParameter blockParameter = null)
        {
            var supportsInterfaceFunction = new SupportsInterfaceFunction();
                supportsInterfaceFunction.InterfaceId = interfaceId;
            
            return ContractHandler.QueryAsync<SupportsInterfaceFunction, bool>(supportsInterfaceFunction, blockParameter);
        }

        public Task<string> TokenDescriptionQueryAsync(TokenDescriptionFunction tokenDescriptionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenDescriptionFunction, string>(tokenDescriptionFunction, blockParameter);
        }

        
        public Task<string> TokenDescriptionQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var tokenDescriptionFunction = new TokenDescriptionFunction();
                tokenDescriptionFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<TokenDescriptionFunction, string>(tokenDescriptionFunction, blockParameter);
        }

        public Task<string> TokenNameQueryAsync(TokenNameFunction tokenNameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenNameFunction, string>(tokenNameFunction, blockParameter);
        }

        
        public Task<string> TokenNameQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var tokenNameFunction = new TokenNameFunction();
                tokenNameFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<TokenNameFunction, string>(tokenNameFunction, blockParameter);
        }

        public Task<string> TokenURIHandlerQueryAsync(TokenURIHandlerFunction tokenURIHandlerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenURIHandlerFunction, string>(tokenURIHandlerFunction, blockParameter);
        }

        
        public Task<string> TokenURIHandlerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenURIHandlerFunction, string>(null, blockParameter);
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

        public Task<string> UriQueryAsync(UriFunction uriFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<UriFunction, string>(uriFunction, blockParameter);
        }

        
        public Task<string> UriQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var uriFunction = new UriFunction();
                uriFunction.Id = id;
            
            return ContractHandler.QueryAsync<UriFunction, string>(uriFunction, blockParameter);
        }
    }
}

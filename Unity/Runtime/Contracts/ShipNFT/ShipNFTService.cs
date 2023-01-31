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
using PirateNationContracts.ShipNFT.ContractDefinition;

namespace PirateNationContracts.ShipNFT
{
    public partial class ShipNFTService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, ShipNFTDeployment shipNFTDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<ShipNFTDeployment>().SendRequestAndWaitForReceiptAsync(shipNFTDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, ShipNFTDeployment shipNFTDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<ShipNFTDeployment>().SendRequestAsync(shipNFTDeployment);
        }

        public static async Task<ShipNFTService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, ShipNFTDeployment shipNFTDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, shipNFTDeployment, cancellationTokenSource);
            return new ShipNFTService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public ShipNFTService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> BatchLimitQueryAsync(BatchLimitFunction batchLimitFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BatchLimitFunction, BigInteger>(batchLimitFunction, blockParameter);
        }

        
        public Task<BigInteger> BatchLimitQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BatchLimitFunction, BigInteger>(null, blockParameter);
        }

        public Task<byte[]> GamenftInterfaceidQueryAsync(GamenftInterfaceidFunction gamenftInterfaceidFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GamenftInterfaceidFunction, byte[]>(gamenftInterfaceidFunction, blockParameter);
        }

        
        public Task<byte[]> GamenftInterfaceidQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GamenftInterfaceidFunction, byte[]>(null, blockParameter);
        }

        public Task<byte[]> Ierc721bridgablechildInterfaceidQueryAsync(Ierc721bridgablechildInterfaceidFunction ierc721bridgablechildInterfaceidFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Ierc721bridgablechildInterfaceidFunction, byte[]>(ierc721bridgablechildInterfaceidFunction, blockParameter);
        }

        
        public Task<byte[]> Ierc721bridgablechildInterfaceidQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Ierc721bridgablechildInterfaceidFunction, byte[]>(null, blockParameter);
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

        public Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
        {
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<string> ApproveRequestAsync(string to, BigInteger tokenId)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        
        public Task<BigInteger> BalanceOfQueryAsync(string owner, BlockParameter blockParameter = null)
        {
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.Owner = owner;
            
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
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

        public Task<string> BurnRequestAsync(BigInteger id)
        {
            var burnFunction = new BurnFunction();
                burnFunction.Id = id;
            
             return ContractHandler.SendRequestAsync(burnFunction);
        }

        public Task<TransactionReceipt> BurnRequestAndWaitForReceiptAsync(BigInteger id, CancellationTokenSource cancellationToken = null)
        {
            var burnFunction = new BurnFunction();
                burnFunction.Id = id;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(burnFunction, cancellationToken);
        }

        public Task<string> BurnForTestsRequestAsync(BurnForTestsFunction burnForTestsFunction)
        {
             return ContractHandler.SendRequestAsync(burnForTestsFunction);
        }

        public Task<TransactionReceipt> BurnForTestsRequestAndWaitForReceiptAsync(BurnForTestsFunction burnForTestsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(burnForTestsFunction, cancellationToken);
        }

        public Task<string> BurnForTestsRequestAsync(BigInteger tokenId)
        {
            var burnForTestsFunction = new BurnForTestsFunction();
                burnForTestsFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(burnForTestsFunction);
        }

        public Task<TransactionReceipt> BurnForTestsRequestAndWaitForReceiptAsync(BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var burnForTestsFunction = new BurnForTestsFunction();
                burnForTestsFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(burnForTestsFunction, cancellationToken);
        }

        public Task<string> ContractURIQueryAsync(ContractURIFunction contractURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractURIFunction, string>(contractURIFunction, blockParameter);
        }

        
        public Task<string> ContractURIQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ContractURIFunction, string>(null, blockParameter);
        }

        public Task<string> DepositRequestAsync(DepositFunction depositFunction)
        {
             return ContractHandler.SendRequestAsync(depositFunction);
        }

        public Task<TransactionReceipt> DepositRequestAndWaitForReceiptAsync(DepositFunction depositFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositFunction, cancellationToken);
        }

        public Task<string> DepositRequestAsync(string to, byte[] depositData)
        {
            var depositFunction = new DepositFunction();
                depositFunction.To = to;
                depositFunction.DepositData = depositData;
            
             return ContractHandler.SendRequestAsync(depositFunction);
        }

        public Task<TransactionReceipt> DepositRequestAndWaitForReceiptAsync(string to, byte[] depositData, CancellationTokenSource cancellationToken = null)
        {
            var depositFunction = new DepositFunction();
                depositFunction.To = to;
                depositFunction.DepositData = depositData;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositFunction, cancellationToken);
        }

        public Task<string> DepositForTestsRequestAsync(DepositForTestsFunction depositForTestsFunction)
        {
             return ContractHandler.SendRequestAsync(depositForTestsFunction);
        }

        public Task<TransactionReceipt> DepositForTestsRequestAndWaitForReceiptAsync(DepositForTestsFunction depositForTestsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositForTestsFunction, cancellationToken);
        }

        public Task<string> DepositForTestsRequestAsync(string to, byte[] depositData)
        {
            var depositForTestsFunction = new DepositForTestsFunction();
                depositForTestsFunction.To = to;
                depositForTestsFunction.DepositData = depositData;
            
             return ContractHandler.SendRequestAsync(depositForTestsFunction);
        }

        public Task<TransactionReceipt> DepositForTestsRequestAndWaitForReceiptAsync(string to, byte[] depositData, CancellationTokenSource cancellationToken = null)
        {
            var depositForTestsFunction = new DepositForTestsFunction();
                depositForTestsFunction.To = to;
                depositForTestsFunction.DepositData = depositData;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(depositForTestsFunction, cancellationToken);
        }

        public Task<byte[]> EncodeTokenMetadataQueryAsync(EncodeTokenMetadataFunction encodeTokenMetadataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<EncodeTokenMetadataFunction, byte[]>(encodeTokenMetadataFunction, blockParameter);
        }

        
        public Task<byte[]> EncodeTokenMetadataQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var encodeTokenMetadataFunction = new EncodeTokenMetadataFunction();
                encodeTokenMetadataFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<EncodeTokenMetadataFunction, byte[]>(encodeTokenMetadataFunction, blockParameter);
        }

        public Task<bool> ExistsQueryAsync(ExistsFunction existsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ExistsFunction, bool>(existsFunction, blockParameter);
        }

        
        public Task<bool> ExistsQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var existsFunction = new ExistsFunction();
                existsFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<ExistsFunction, bool>(existsFunction, blockParameter);
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

        public Task<string> GetApprovedQueryAsync(GetApprovedFunction getApprovedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
        }

        
        public Task<string> GetApprovedQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getApprovedFunction = new GetApprovedFunction();
                getApprovedFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetApprovedFunction, string>(getApprovedFunction, blockParameter);
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

        public Task<uint> GetTimeHeldQueryAsync(GetTimeHeldFunction getTimeHeldFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTimeHeldFunction, uint>(getTimeHeldFunction, blockParameter);
        }

        
        public Task<uint> GetTimeHeldQueryAsync(string account, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getTimeHeldFunction = new GetTimeHeldFunction();
                getTimeHeldFunction.Account = account;
                getTimeHeldFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetTimeHeldFunction, uint>(getTimeHeldFunction, blockParameter);
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

        
        public Task<bool> IsApprovedForAllQueryAsync(string owner, string @operator, BlockParameter blockParameter = null)
        {
            var isApprovedForAllFunction = new IsApprovedForAllFunction();
                isApprovedForAllFunction.Owner = owner;
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

        public Task<uint> LastTransferQueryAsync(LastTransferFunction lastTransferFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<LastTransferFunction, uint>(lastTransferFunction, blockParameter);
        }

        
        public Task<uint> LastTransferQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var lastTransferFunction = new LastTransferFunction();
                lastTransferFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<LastTransferFunction, uint>(lastTransferFunction, blockParameter);
        }

        public Task<BigInteger> MaxSupplyQueryAsync(MaxSupplyFunction maxSupplyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxSupplyFunction, BigInteger>(maxSupplyFunction, blockParameter);
        }

        
        public Task<BigInteger> MaxSupplyQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxSupplyFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> MintRequestAsync(MintFunction mintFunction)
        {
             return ContractHandler.SendRequestAsync(mintFunction);
        }

        public Task<TransactionReceipt> MintRequestAndWaitForReceiptAsync(MintFunction mintFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintFunction, cancellationToken);
        }

        public Task<string> MintRequestAsync(string to, BigInteger id)
        {
            var mintFunction = new MintFunction();
                mintFunction.To = to;
                mintFunction.Id = id;
            
             return ContractHandler.SendRequestAsync(mintFunction);
        }

        public Task<TransactionReceipt> MintRequestAndWaitForReceiptAsync(string to, BigInteger id, CancellationTokenSource cancellationToken = null)
        {
            var mintFunction = new MintFunction();
                mintFunction.To = to;
                mintFunction.Id = id;
            
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

        public Task<string> MintForTestsRequestAsync(string to, BigInteger tokenId)
        {
            var mintForTestsFunction = new MintForTestsFunction();
                mintForTestsFunction.To = to;
                mintForTestsFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(mintForTestsFunction);
        }

        public Task<TransactionReceipt> MintForTestsRequestAndWaitForReceiptAsync(string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var mintForTestsFunction = new MintForTestsFunction();
                mintForTestsFunction.To = to;
                mintForTestsFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintForTestsFunction, cancellationToken);
        }

        public Task<string> MintWithoutTraitsRequestAsync(MintWithoutTraitsFunction mintWithoutTraitsFunction)
        {
             return ContractHandler.SendRequestAsync(mintWithoutTraitsFunction);
        }

        public Task<TransactionReceipt> MintWithoutTraitsRequestAndWaitForReceiptAsync(MintWithoutTraitsFunction mintWithoutTraitsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintWithoutTraitsFunction, cancellationToken);
        }

        public Task<string> MintWithoutTraitsRequestAsync(string to, BigInteger tokenId)
        {
            var mintWithoutTraitsFunction = new MintWithoutTraitsFunction();
                mintWithoutTraitsFunction.To = to;
                mintWithoutTraitsFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(mintWithoutTraitsFunction);
        }

        public Task<TransactionReceipt> MintWithoutTraitsRequestAndWaitForReceiptAsync(string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var mintWithoutTraitsFunction = new MintWithoutTraitsFunction();
                mintWithoutTraitsFunction.To = to;
                mintWithoutTraitsFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintWithoutTraitsFunction, cancellationToken);
        }

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        
        public Task<string> NameQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> OwnerOfQueryAsync(OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        
        public Task<string> OwnerOfQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var ownerOfFunction = new OwnerOfFunction();
                ownerOfFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
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

        public Task<string> SafeTransferFromRequestAsync(SafeTransferFromFunction safeTransferFromFunction)
        {
             return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFromFunction safeTransferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(safeTransferFromFunction);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFromFunction = new SafeTransferFromFunction();
                safeTransferFromFunction.From = from;
                safeTransferFromFunction.To = to;
                safeTransferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFromFunction, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(SafeTransferFrom1Function safeTransferFrom1Function)
        {
             return ContractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(SafeTransferFrom1Function safeTransferFrom1Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
        }

        public Task<string> SafeTransferFromRequestAsync(string from, string to, BigInteger tokenId, byte[] data)
        {
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
             return ContractHandler.SendRequestAsync(safeTransferFrom1Function);
        }

        public Task<TransactionReceipt> SafeTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var safeTransferFrom1Function = new SafeTransferFrom1Function();
                safeTransferFrom1Function.From = from;
                safeTransferFrom1Function.To = to;
                safeTransferFrom1Function.TokenId = tokenId;
                safeTransferFrom1Function.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(safeTransferFrom1Function, cancellationToken);
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

        public Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
        }

        
        public Task<string> SymbolQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> TokenByIndexQueryAsync(TokenByIndexFunction tokenByIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> TokenByIndexQueryAsync(BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenByIndexFunction = new TokenByIndexFunction();
                tokenByIndexFunction.Index = index;
            
            return ContractHandler.QueryAsync<TokenByIndexFunction, BigInteger>(tokenByIndexFunction, blockParameter);
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

        public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(TokenOfOwnerByIndexFunction tokenOfOwnerByIndexFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        
        public Task<BigInteger> TokenOfOwnerByIndexQueryAsync(string owner, BigInteger index, BlockParameter blockParameter = null)
        {
            var tokenOfOwnerByIndexFunction = new TokenOfOwnerByIndexFunction();
                tokenOfOwnerByIndexFunction.Owner = owner;
                tokenOfOwnerByIndexFunction.Index = index;
            
            return ContractHandler.QueryAsync<TokenOfOwnerByIndexFunction, BigInteger>(tokenOfOwnerByIndexFunction, blockParameter);
        }

        public Task<string> TokenURIQueryAsync(TokenURIFunction tokenURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        
        public Task<string> TokenURIQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var tokenURIFunction = new TokenURIFunction();
                tokenURIFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        public Task<string> TokenURIHandlerQueryAsync(TokenURIHandlerFunction tokenURIHandlerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenURIHandlerFunction, string>(tokenURIHandlerFunction, blockParameter);
        }

        
        public Task<string> TokenURIHandlerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenURIHandlerFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
        }

        
        public Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
        {
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public Task<string> TransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
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

        public Task<string> WithdrawRequestAsync(WithdrawFunction withdrawFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public Task<string> WithdrawRequestAsync(BigInteger tokenId)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public Task<string> WithdrawBatchRequestAsync(WithdrawBatchFunction withdrawBatchFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawBatchFunction);
        }

        public Task<TransactionReceipt> WithdrawBatchRequestAndWaitForReceiptAsync(WithdrawBatchFunction withdrawBatchFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawBatchFunction, cancellationToken);
        }

        public Task<string> WithdrawBatchRequestAsync(List<BigInteger> tokenIds)
        {
            var withdrawBatchFunction = new WithdrawBatchFunction();
                withdrawBatchFunction.TokenIds = tokenIds;
            
             return ContractHandler.SendRequestAsync(withdrawBatchFunction);
        }

        public Task<TransactionReceipt> WithdrawBatchRequestAndWaitForReceiptAsync(List<BigInteger> tokenIds, CancellationTokenSource cancellationToken = null)
        {
            var withdrawBatchFunction = new WithdrawBatchFunction();
                withdrawBatchFunction.TokenIds = tokenIds;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawBatchFunction, cancellationToken);
        }

        public Task<string> WithdrawWithMetadataRequestAsync(WithdrawWithMetadataFunction withdrawWithMetadataFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawWithMetadataFunction);
        }

        public Task<TransactionReceipt> WithdrawWithMetadataRequestAndWaitForReceiptAsync(WithdrawWithMetadataFunction withdrawWithMetadataFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawWithMetadataFunction, cancellationToken);
        }

        public Task<string> WithdrawWithMetadataRequestAsync(BigInteger tokenId)
        {
            var withdrawWithMetadataFunction = new WithdrawWithMetadataFunction();
                withdrawWithMetadataFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(withdrawWithMetadataFunction);
        }

        public Task<TransactionReceipt> WithdrawWithMetadataRequestAndWaitForReceiptAsync(BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var withdrawWithMetadataFunction = new WithdrawWithMetadataFunction();
                withdrawWithMetadataFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawWithMetadataFunction, cancellationToken);
        }
    }
}

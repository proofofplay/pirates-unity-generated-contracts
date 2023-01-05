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
using SimpleStorage.GameNFT.ContractDefinition;

namespace SimpleStorage.GameNFT
{
    public partial class GameNFTService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, GameNFTDeployment gameNFTDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<GameNFTDeployment>().SendRequestAndWaitForReceiptAsync(gameNFTDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, GameNFTDeployment gameNFTDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<GameNFTDeployment>().SendRequestAsync(gameNFTDeployment);
        }

        public static async Task<GameNFTService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, GameNFTDeployment gameNFTDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, gameNFTDeployment, cancellationTokenSource);
            return new GameNFTService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public GameNFTService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> BATCH_LIMITQueryAsync(BATCH_LIMITFunction bATCH_LIMITFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BATCH_LIMITFunction, BigInteger>(bATCH_LIMITFunction, blockParameter);
        }

        
        public Task<BigInteger> BATCH_LIMITQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BATCH_LIMITFunction, BigInteger>(null, blockParameter);
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

        public Task<string> UriQueryAsync(UriFunction uriFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<UriFunction, string>(uriFunction, blockParameter);
        }

        
        public Task<string> UriQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<UriFunction, string>(null, blockParameter);
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

        public Task<string> DecrementTraitRequestAsync(DecrementTraitFunction decrementTraitFunction)
        {
             return ContractHandler.SendRequestAsync(decrementTraitFunction);
        }

        public Task<TransactionReceipt> DecrementTraitRequestAndWaitForReceiptAsync(DecrementTraitFunction decrementTraitFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(decrementTraitFunction, cancellationToken);
        }

        public Task<string> DecrementTraitRequestAsync(BigInteger tokenId, uint traitId, BigInteger amount)
        {
            var decrementTraitFunction = new DecrementTraitFunction();
                decrementTraitFunction.TokenId = tokenId;
                decrementTraitFunction.TraitId = traitId;
                decrementTraitFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(decrementTraitFunction);
        }

        public Task<TransactionReceipt> DecrementTraitRequestAndWaitForReceiptAsync(BigInteger tokenId, uint traitId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var decrementTraitFunction = new DecrementTraitFunction();
                decrementTraitFunction.TokenId = tokenId;
                decrementTraitFunction.TraitId = traitId;
                decrementTraitFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(decrementTraitFunction, cancellationToken);
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

        public Task<GetExtraTraitsOutputDTO> GetExtraTraitsQueryAsync(GetExtraTraitsFunction getExtraTraitsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetExtraTraitsFunction, GetExtraTraitsOutputDTO>(getExtraTraitsFunction, blockParameter);
        }

        public Task<GetExtraTraitsOutputDTO> GetExtraTraitsQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getExtraTraitsFunction = new GetExtraTraitsFunction();
                getExtraTraitsFunction.TokenId = tokenId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetExtraTraitsFunction, GetExtraTraitsOutputDTO>(getExtraTraitsFunction, blockParameter);
        }

        public Task<bool> GetRescueUnlockEnabledQueryAsync(GetRescueUnlockEnabledFunction getRescueUnlockEnabledFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetRescueUnlockEnabledFunction, bool>(getRescueUnlockEnabledFunction, blockParameter);
        }

        
        public Task<bool> GetRescueUnlockEnabledQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetRescueUnlockEnabledFunction, bool>(null, blockParameter);
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

        public Task<BigInteger> GetTraitInt256QueryAsync(GetTraitInt256Function getTraitInt256Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTraitInt256Function, BigInteger>(getTraitInt256Function, blockParameter);
        }

        
        public Task<BigInteger> GetTraitInt256QueryAsync(BigInteger tokenId, uint traitId, BlockParameter blockParameter = null)
        {
            var getTraitInt256Function = new GetTraitInt256Function();
                getTraitInt256Function.TokenId = tokenId;
                getTraitInt256Function.TraitId = traitId;
            
            return ContractHandler.QueryAsync<GetTraitInt256Function, BigInteger>(getTraitInt256Function, blockParameter);
        }

        public Task<BigInteger> GetTraitUint256QueryAsync(GetTraitUint256Function getTraitUint256Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTraitUint256Function, BigInteger>(getTraitUint256Function, blockParameter);
        }

        
        public Task<BigInteger> GetTraitUint256QueryAsync(BigInteger tokenId, uint traitId, BlockParameter blockParameter = null)
        {
            var getTraitUint256Function = new GetTraitUint256Function();
                getTraitUint256Function.TokenId = tokenId;
                getTraitUint256Function.TraitId = traitId;
            
            return ContractHandler.QueryAsync<GetTraitUint256Function, BigInteger>(getTraitUint256Function, blockParameter);
        }

        public Task<byte> GetTraitUint8QueryAsync(GetTraitUint8Function getTraitUint8Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTraitUint8Function, byte>(getTraitUint8Function, blockParameter);
        }

        
        public Task<byte> GetTraitUint8QueryAsync(BigInteger tokenId, uint traitId, BlockParameter blockParameter = null)
        {
            var getTraitUint8Function = new GetTraitUint8Function();
                getTraitUint8Function.TokenId = tokenId;
                getTraitUint8Function.TraitId = traitId;
            
            return ContractHandler.QueryAsync<GetTraitUint8Function, byte>(getTraitUint8Function, blockParameter);
        }

        public Task<bool> HasTraitQueryAsync(HasTraitFunction hasTraitFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<HasTraitFunction, bool>(hasTraitFunction, blockParameter);
        }

        
        public Task<bool> HasTraitQueryAsync(BigInteger tokenId, uint traitId, BlockParameter blockParameter = null)
        {
            var hasTraitFunction = new HasTraitFunction();
                hasTraitFunction.TokenId = tokenId;
                hasTraitFunction.TraitId = traitId;
            
            return ContractHandler.QueryAsync<HasTraitFunction, bool>(hasTraitFunction, blockParameter);
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

        public Task<string> IncrementTraitRequestAsync(IncrementTraitFunction incrementTraitFunction)
        {
             return ContractHandler.SendRequestAsync(incrementTraitFunction);
        }

        public Task<TransactionReceipt> IncrementTraitRequestAndWaitForReceiptAsync(IncrementTraitFunction incrementTraitFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(incrementTraitFunction, cancellationToken);
        }

        public Task<string> IncrementTraitRequestAsync(BigInteger tokenId, uint traitId, BigInteger amount)
        {
            var incrementTraitFunction = new IncrementTraitFunction();
                incrementTraitFunction.TokenId = tokenId;
                incrementTraitFunction.TraitId = traitId;
                incrementTraitFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(incrementTraitFunction);
        }

        public Task<TransactionReceipt> IncrementTraitRequestAndWaitForReceiptAsync(BigInteger tokenId, uint traitId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var incrementTraitFunction = new IncrementTraitFunction();
                incrementTraitFunction.TokenId = tokenId;
                incrementTraitFunction.TraitId = traitId;
                incrementTraitFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(incrementTraitFunction, cancellationToken);
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

        public Task<bool> IsLockedQueryAsync(IsLockedFunction isLockedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsLockedFunction, bool>(isLockedFunction, blockParameter);
        }

        
        public Task<bool> IsLockedQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var isLockedFunction = new IsLockedFunction();
                isLockedFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<IsLockedFunction, bool>(isLockedFunction, blockParameter);
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

        public Task<string> LockTokenRequestAsync(LockTokenFunction lockTokenFunction)
        {
             return ContractHandler.SendRequestAsync(lockTokenFunction);
        }

        public Task<TransactionReceipt> LockTokenRequestAndWaitForReceiptAsync(LockTokenFunction lockTokenFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(lockTokenFunction, cancellationToken);
        }

        public Task<string> LockTokenRequestAsync(BigInteger tokenId)
        {
            var lockTokenFunction = new LockTokenFunction();
                lockTokenFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(lockTokenFunction);
        }

        public Task<TransactionReceipt> LockTokenRequestAndWaitForReceiptAsync(BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var lockTokenFunction = new LockTokenFunction();
                lockTokenFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(lockTokenFunction, cancellationToken);
        }

        public Task<BigInteger> MaxSupplyQueryAsync(MaxSupplyFunction maxSupplyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxSupplyFunction, BigInteger>(maxSupplyFunction, blockParameter);
        }

        
        public Task<BigInteger> MaxSupplyQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MaxSupplyFunction, BigInteger>(null, blockParameter);
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

        public Task<string> RescueUnlockRequestAsync(RescueUnlockFunction rescueUnlockFunction)
        {
             return ContractHandler.SendRequestAsync(rescueUnlockFunction);
        }

        public Task<TransactionReceipt> RescueUnlockRequestAndWaitForReceiptAsync(RescueUnlockFunction rescueUnlockFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rescueUnlockFunction, cancellationToken);
        }

        public Task<string> RescueUnlockRequestAsync(BigInteger tokenId)
        {
            var rescueUnlockFunction = new RescueUnlockFunction();
                rescueUnlockFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(rescueUnlockFunction);
        }

        public Task<TransactionReceipt> RescueUnlockRequestAndWaitForReceiptAsync(BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var rescueUnlockFunction = new RescueUnlockFunction();
                rescueUnlockFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rescueUnlockFunction, cancellationToken);
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

        public Task<string> SetRescueUnlockEnabledRequestAsync(SetRescueUnlockEnabledFunction setRescueUnlockEnabledFunction)
        {
             return ContractHandler.SendRequestAsync(setRescueUnlockEnabledFunction);
        }

        public Task<TransactionReceipt> SetRescueUnlockEnabledRequestAndWaitForReceiptAsync(SetRescueUnlockEnabledFunction setRescueUnlockEnabledFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setRescueUnlockEnabledFunction, cancellationToken);
        }

        public Task<string> SetRescueUnlockEnabledRequestAsync(bool enabled)
        {
            var setRescueUnlockEnabledFunction = new SetRescueUnlockEnabledFunction();
                setRescueUnlockEnabledFunction.Enabled = enabled;
            
             return ContractHandler.SendRequestAsync(setRescueUnlockEnabledFunction);
        }

        public Task<TransactionReceipt> SetRescueUnlockEnabledRequestAndWaitForReceiptAsync(bool enabled, CancellationTokenSource cancellationToken = null)
        {
            var setRescueUnlockEnabledFunction = new SetRescueUnlockEnabledFunction();
                setRescueUnlockEnabledFunction.Enabled = enabled;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setRescueUnlockEnabledFunction, cancellationToken);
        }

        public Task<string> SetTraitInt256RequestAsync(SetTraitInt256Function setTraitInt256Function)
        {
             return ContractHandler.SendRequestAsync(setTraitInt256Function);
        }

        public Task<TransactionReceipt> SetTraitInt256RequestAndWaitForReceiptAsync(SetTraitInt256Function setTraitInt256Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitInt256Function, cancellationToken);
        }

        public Task<string> SetTraitInt256RequestAsync(BigInteger tokenId, uint traitId, BigInteger value)
        {
            var setTraitInt256Function = new SetTraitInt256Function();
                setTraitInt256Function.TokenId = tokenId;
                setTraitInt256Function.TraitId = traitId;
                setTraitInt256Function.Value = value;
            
             return ContractHandler.SendRequestAsync(setTraitInt256Function);
        }

        public Task<TransactionReceipt> SetTraitInt256RequestAndWaitForReceiptAsync(BigInteger tokenId, uint traitId, BigInteger value, CancellationTokenSource cancellationToken = null)
        {
            var setTraitInt256Function = new SetTraitInt256Function();
                setTraitInt256Function.TokenId = tokenId;
                setTraitInt256Function.TraitId = traitId;
                setTraitInt256Function.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitInt256Function, cancellationToken);
        }

        public Task<string> SetTraitsProviderRequestAsync(SetTraitsProviderFunction setTraitsProviderFunction)
        {
             return ContractHandler.SendRequestAsync(setTraitsProviderFunction);
        }

        public Task<TransactionReceipt> SetTraitsProviderRequestAndWaitForReceiptAsync(SetTraitsProviderFunction setTraitsProviderFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitsProviderFunction, cancellationToken);
        }

        public Task<string> SetTraitsProviderRequestAsync(string traitsProviderAddress)
        {
            var setTraitsProviderFunction = new SetTraitsProviderFunction();
                setTraitsProviderFunction.TraitsProviderAddress = traitsProviderAddress;
            
             return ContractHandler.SendRequestAsync(setTraitsProviderFunction);
        }

        public Task<TransactionReceipt> SetTraitsProviderRequestAndWaitForReceiptAsync(string traitsProviderAddress, CancellationTokenSource cancellationToken = null)
        {
            var setTraitsProviderFunction = new SetTraitsProviderFunction();
                setTraitsProviderFunction.TraitsProviderAddress = traitsProviderAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitsProviderFunction, cancellationToken);
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

        public Task<string> UnlockTokenRequestAsync(UnlockTokenFunction unlockTokenFunction)
        {
             return ContractHandler.SendRequestAsync(unlockTokenFunction);
        }

        public Task<TransactionReceipt> UnlockTokenRequestAndWaitForReceiptAsync(UnlockTokenFunction unlockTokenFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(unlockTokenFunction, cancellationToken);
        }

        public Task<string> UnlockTokenRequestAsync(BigInteger tokenId)
        {
            var unlockTokenFunction = new UnlockTokenFunction();
                unlockTokenFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(unlockTokenFunction);
        }

        public Task<TransactionReceipt> UnlockTokenRequestAndWaitForReceiptAsync(BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var unlockTokenFunction = new UnlockTokenFunction();
                unlockTokenFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(unlockTokenFunction, cancellationToken);
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

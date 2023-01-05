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
using SimpleStorage.TraitsConsumer.ContractDefinition;

namespace SimpleStorage.TraitsConsumer
{
    public partial class TraitsConsumerService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, TraitsConsumerDeployment traitsConsumerDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<TraitsConsumerDeployment>().SendRequestAndWaitForReceiptAsync(traitsConsumerDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, TraitsConsumerDeployment traitsConsumerDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<TraitsConsumerDeployment>().SendRequestAsync(traitsConsumerDeployment);
        }

        public static async Task<TraitsConsumerService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, TraitsConsumerDeployment traitsConsumerDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, traitsConsumerDeployment, cancellationTokenSource);
            return new TraitsConsumerService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public TraitsConsumerService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
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

        public Task<GetExtraTraitsOutputDTO> GetExtraTraitsQueryAsync(GetExtraTraitsFunction getExtraTraitsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetExtraTraitsFunction, GetExtraTraitsOutputDTO>(getExtraTraitsFunction, blockParameter);
        }

        public Task<GetExtraTraitsOutputDTO> GetExtraTraitsQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var getExtraTraitsFunction = new GetExtraTraitsFunction();
                getExtraTraitsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetExtraTraitsFunction, GetExtraTraitsOutputDTO>(getExtraTraitsFunction, blockParameter);
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

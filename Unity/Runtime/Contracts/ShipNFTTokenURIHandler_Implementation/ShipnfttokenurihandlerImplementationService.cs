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
using PirateNationContracts.ShipNFTTokenURIHandler_Implementation.ContractDefinition;

namespace PirateNationContracts.ShipNFTTokenURIHandler_Implementation
{
    public partial class ShipnfttokenurihandlerImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, ShipnfttokenurihandlerImplementationDeployment shipnfttokenurihandlerImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<ShipnfttokenurihandlerImplementationDeployment>().SendRequestAndWaitForReceiptAsync(shipnfttokenurihandlerImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, ShipnfttokenurihandlerImplementationDeployment shipnfttokenurihandlerImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<ShipnfttokenurihandlerImplementationDeployment>().SendRequestAsync(shipnfttokenurihandlerImplementationDeployment);
        }

        public static async Task<ShipnfttokenurihandlerImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, ShipnfttokenurihandlerImplementationDeployment shipnfttokenurihandlerImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, shipnfttokenurihandlerImplementationDeployment, cancellationTokenSource);
            return new ShipnfttokenurihandlerImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public ShipnfttokenurihandlerImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> AddAssetRequestAsync(AddAssetFunction addAssetFunction)
        {
             return ContractHandler.SendRequestAsync(addAssetFunction);
        }

        public Task<TransactionReceipt> AddAssetRequestAndWaitForReceiptAsync(AddAssetFunction addAssetFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addAssetFunction, cancellationToken);
        }

        public Task<string> AddAssetRequestAsync(string tokenContract, Asset asset)
        {
            var addAssetFunction = new AddAssetFunction();
                addAssetFunction.TokenContract = tokenContract;
                addAssetFunction.Asset = asset;
            
             return ContractHandler.SendRequestAsync(addAssetFunction);
        }

        public Task<TransactionReceipt> AddAssetRequestAndWaitForReceiptAsync(string tokenContract, Asset asset, CancellationTokenSource cancellationToken = null)
        {
            var addAssetFunction = new AddAssetFunction();
                addAssetFunction.TokenContract = tokenContract;
                addAssetFunction.Asset = asset;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addAssetFunction, cancellationToken);
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

        public Task<GetAssetOutputDTO> GetAssetQueryAsync(GetAssetFunction getAssetFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetAssetFunction, GetAssetOutputDTO>(getAssetFunction, blockParameter);
        }

        public Task<GetAssetOutputDTO> GetAssetQueryAsync(string tokenContract, BigInteger traitId, BlockParameter blockParameter = null)
        {
            var getAssetFunction = new GetAssetFunction();
                getAssetFunction.TokenContract = tokenContract;
                getAssetFunction.TraitId = traitId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetAssetFunction, GetAssetOutputDTO>(getAssetFunction, blockParameter);
        }

        public Task<List<BigInteger>> GetAssetTraitIdsQueryAsync(GetAssetTraitIdsFunction getAssetTraitIdsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetAssetTraitIdsFunction, List<BigInteger>>(getAssetTraitIdsFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> GetAssetTraitIdsQueryAsync(string tokenContract, BlockParameter blockParameter = null)
        {
            var getAssetTraitIdsFunction = new GetAssetTraitIdsFunction();
                getAssetTraitIdsFunction.TokenContract = tokenContract;
            
            return ContractHandler.QueryAsync<GetAssetTraitIdsFunction, List<BigInteger>>(getAssetTraitIdsFunction, blockParameter);
        }

        public Task<GetExtraTraitsOutputDTO> GetExtraTraitsQueryAsync(GetExtraTraitsFunction getExtraTraitsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetExtraTraitsFunction, GetExtraTraitsOutputDTO>(getExtraTraitsFunction, blockParameter);
        }

        public Task<GetExtraTraitsOutputDTO> GetExtraTraitsQueryAsync(string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getExtraTraitsFunction = new GetExtraTraitsFunction();
                getExtraTraitsFunction.TokenContract = tokenContract;
                getExtraTraitsFunction.TokenId = tokenId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetExtraTraitsFunction, GetExtraTraitsOutputDTO>(getExtraTraitsFunction, blockParameter);
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

        public Task<string> RemoveAssetRequestAsync(RemoveAssetFunction removeAssetFunction)
        {
             return ContractHandler.SendRequestAsync(removeAssetFunction);
        }

        public Task<TransactionReceipt> RemoveAssetRequestAndWaitForReceiptAsync(RemoveAssetFunction removeAssetFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAssetFunction, cancellationToken);
        }

        public Task<string> RemoveAssetRequestAsync(string tokenContract, BigInteger traitId)
        {
            var removeAssetFunction = new RemoveAssetFunction();
                removeAssetFunction.TokenContract = tokenContract;
                removeAssetFunction.TraitId = traitId;
            
             return ContractHandler.SendRequestAsync(removeAssetFunction);
        }

        public Task<TransactionReceipt> RemoveAssetRequestAndWaitForReceiptAsync(string tokenContract, BigInteger traitId, CancellationTokenSource cancellationToken = null)
        {
            var removeAssetFunction = new RemoveAssetFunction();
                removeAssetFunction.TokenContract = tokenContract;
                removeAssetFunction.TraitId = traitId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeAssetFunction, cancellationToken);
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

        public Task<string> TokenURIQueryAsync(TokenURIFunction tokenURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
        }

        
        public Task<string> TokenURIQueryAsync(string returnValue1, string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var tokenURIFunction = new TokenURIFunction();
                tokenURIFunction.ReturnValue1 = returnValue1;
                tokenURIFunction.TokenContract = tokenContract;
                tokenURIFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<TokenURIFunction, string>(tokenURIFunction, blockParameter);
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

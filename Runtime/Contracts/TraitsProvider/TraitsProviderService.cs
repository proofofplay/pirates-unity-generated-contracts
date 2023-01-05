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
using PirateNationContracts.TraitsProvider.ContractDefinition;

namespace PirateNationContracts.TraitsProvider
{
    public partial class TraitsProviderService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, TraitsProviderDeployment traitsProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<TraitsProviderDeployment>().SendRequestAndWaitForReceiptAsync(traitsProviderDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, TraitsProviderDeployment traitsProviderDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<TraitsProviderDeployment>().SendRequestAsync(traitsProviderDeployment);
        }

        public static async Task<TraitsProviderService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, TraitsProviderDeployment traitsProviderDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, traitsProviderDeployment, cancellationTokenSource);
            return new TraitsProviderService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public TraitsProviderService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> AdminRequestAsync(AdminFunction adminFunction)
        {
             return ContractHandler.SendRequestAsync(adminFunction);
        }

        public Task<string> AdminRequestAsync()
        {
             return ContractHandler.SendRequestAsync<AdminFunction>();
        }

        public Task<TransactionReceipt> AdminRequestAndWaitForReceiptAsync(AdminFunction adminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(adminFunction, cancellationToken);
        }

        public Task<TransactionReceipt> AdminRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<AdminFunction>(null, cancellationToken);
        }

        public Task<string> ChangeAdminRequestAsync(ChangeAdminFunction changeAdminFunction)
        {
             return ContractHandler.SendRequestAsync(changeAdminFunction);
        }

        public Task<TransactionReceipt> ChangeAdminRequestAndWaitForReceiptAsync(ChangeAdminFunction changeAdminFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(changeAdminFunction, cancellationToken);
        }

        public Task<string> ChangeAdminRequestAsync(string newAdmin)
        {
            var changeAdminFunction = new ChangeAdminFunction();
                changeAdminFunction.NewAdmin = newAdmin;
            
             return ContractHandler.SendRequestAsync(changeAdminFunction);
        }

        public Task<TransactionReceipt> ChangeAdminRequestAndWaitForReceiptAsync(string newAdmin, CancellationTokenSource cancellationToken = null)
        {
            var changeAdminFunction = new ChangeAdminFunction();
                changeAdminFunction.NewAdmin = newAdmin;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(changeAdminFunction, cancellationToken);
        }

        public Task<string> ImplementationRequestAsync(ImplementationFunction implementationFunction)
        {
             return ContractHandler.SendRequestAsync(implementationFunction);
        }

        public Task<string> ImplementationRequestAsync()
        {
             return ContractHandler.SendRequestAsync<ImplementationFunction>();
        }

        public Task<TransactionReceipt> ImplementationRequestAndWaitForReceiptAsync(ImplementationFunction implementationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(implementationFunction, cancellationToken);
        }

        public Task<TransactionReceipt> ImplementationRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<ImplementationFunction>(null, cancellationToken);
        }

        public Task<string> UpgradeToRequestAsync(UpgradeToFunction upgradeToFunction)
        {
             return ContractHandler.SendRequestAsync(upgradeToFunction);
        }

        public Task<TransactionReceipt> UpgradeToRequestAndWaitForReceiptAsync(UpgradeToFunction upgradeToFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeToFunction, cancellationToken);
        }

        public Task<string> UpgradeToRequestAsync(string newImplementation)
        {
            var upgradeToFunction = new UpgradeToFunction();
                upgradeToFunction.NewImplementation = newImplementation;
            
             return ContractHandler.SendRequestAsync(upgradeToFunction);
        }

        public Task<TransactionReceipt> UpgradeToRequestAndWaitForReceiptAsync(string newImplementation, CancellationTokenSource cancellationToken = null)
        {
            var upgradeToFunction = new UpgradeToFunction();
                upgradeToFunction.NewImplementation = newImplementation;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeToFunction, cancellationToken);
        }

        public Task<string> UpgradeToAndCallRequestAsync(UpgradeToAndCallFunction upgradeToAndCallFunction)
        {
             return ContractHandler.SendRequestAsync(upgradeToAndCallFunction);
        }

        public Task<TransactionReceipt> UpgradeToAndCallRequestAndWaitForReceiptAsync(UpgradeToAndCallFunction upgradeToAndCallFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeToAndCallFunction, cancellationToken);
        }

        public Task<string> UpgradeToAndCallRequestAsync(string newImplementation, byte[] data)
        {
            var upgradeToAndCallFunction = new UpgradeToAndCallFunction();
                upgradeToAndCallFunction.NewImplementation = newImplementation;
                upgradeToAndCallFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(upgradeToAndCallFunction);
        }

        public Task<TransactionReceipt> UpgradeToAndCallRequestAndWaitForReceiptAsync(string newImplementation, byte[] data, CancellationTokenSource cancellationToken = null)
        {
            var upgradeToAndCallFunction = new UpgradeToAndCallFunction();
                upgradeToAndCallFunction.NewImplementation = newImplementation;
                upgradeToAndCallFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeToAndCallFunction, cancellationToken);
        }

        public Task<string> BatchSetTraitBoolRequestAsync(BatchSetTraitBoolFunction batchSetTraitBoolFunction)
        {
             return ContractHandler.SendRequestAsync(batchSetTraitBoolFunction);
        }

        public Task<TransactionReceipt> BatchSetTraitBoolRequestAndWaitForReceiptAsync(BatchSetTraitBoolFunction batchSetTraitBoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetTraitBoolFunction, cancellationToken);
        }

        public Task<string> BatchSetTraitBoolRequestAsync(string tokenContract, List<BigInteger> tokenIds, List<BigInteger> traitIds, List<bool> values)
        {
            var batchSetTraitBoolFunction = new BatchSetTraitBoolFunction();
                batchSetTraitBoolFunction.TokenContract = tokenContract;
                batchSetTraitBoolFunction.TokenIds = tokenIds;
                batchSetTraitBoolFunction.TraitIds = traitIds;
                batchSetTraitBoolFunction.Values = values;
            
             return ContractHandler.SendRequestAsync(batchSetTraitBoolFunction);
        }

        public Task<TransactionReceipt> BatchSetTraitBoolRequestAndWaitForReceiptAsync(string tokenContract, List<BigInteger> tokenIds, List<BigInteger> traitIds, List<bool> values, CancellationTokenSource cancellationToken = null)
        {
            var batchSetTraitBoolFunction = new BatchSetTraitBoolFunction();
                batchSetTraitBoolFunction.TokenContract = tokenContract;
                batchSetTraitBoolFunction.TokenIds = tokenIds;
                batchSetTraitBoolFunction.TraitIds = traitIds;
                batchSetTraitBoolFunction.Values = values;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetTraitBoolFunction, cancellationToken);
        }

        public Task<string> BatchSetTraitInt256RequestAsync(BatchSetTraitInt256Function batchSetTraitInt256Function)
        {
             return ContractHandler.SendRequestAsync(batchSetTraitInt256Function);
        }

        public Task<TransactionReceipt> BatchSetTraitInt256RequestAndWaitForReceiptAsync(BatchSetTraitInt256Function batchSetTraitInt256Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetTraitInt256Function, cancellationToken);
        }

        public Task<string> BatchSetTraitInt256RequestAsync(string tokenContract, List<BigInteger> tokenIds, List<BigInteger> traitIds, List<BigInteger> values)
        {
            var batchSetTraitInt256Function = new BatchSetTraitInt256Function();
                batchSetTraitInt256Function.TokenContract = tokenContract;
                batchSetTraitInt256Function.TokenIds = tokenIds;
                batchSetTraitInt256Function.TraitIds = traitIds;
                batchSetTraitInt256Function.Values = values;
            
             return ContractHandler.SendRequestAsync(batchSetTraitInt256Function);
        }

        public Task<TransactionReceipt> BatchSetTraitInt256RequestAndWaitForReceiptAsync(string tokenContract, List<BigInteger> tokenIds, List<BigInteger> traitIds, List<BigInteger> values, CancellationTokenSource cancellationToken = null)
        {
            var batchSetTraitInt256Function = new BatchSetTraitInt256Function();
                batchSetTraitInt256Function.TokenContract = tokenContract;
                batchSetTraitInt256Function.TokenIds = tokenIds;
                batchSetTraitInt256Function.TraitIds = traitIds;
                batchSetTraitInt256Function.Values = values;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetTraitInt256Function, cancellationToken);
        }

        public Task<string> BatchSetTraitStringRequestAsync(BatchSetTraitStringFunction batchSetTraitStringFunction)
        {
             return ContractHandler.SendRequestAsync(batchSetTraitStringFunction);
        }

        public Task<TransactionReceipt> BatchSetTraitStringRequestAndWaitForReceiptAsync(BatchSetTraitStringFunction batchSetTraitStringFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetTraitStringFunction, cancellationToken);
        }

        public Task<string> BatchSetTraitStringRequestAsync(string tokenContract, List<BigInteger> tokenIds, List<BigInteger> traitIds, List<string> values)
        {
            var batchSetTraitStringFunction = new BatchSetTraitStringFunction();
                batchSetTraitStringFunction.TokenContract = tokenContract;
                batchSetTraitStringFunction.TokenIds = tokenIds;
                batchSetTraitStringFunction.TraitIds = traitIds;
                batchSetTraitStringFunction.Values = values;
            
             return ContractHandler.SendRequestAsync(batchSetTraitStringFunction);
        }

        public Task<TransactionReceipt> BatchSetTraitStringRequestAndWaitForReceiptAsync(string tokenContract, List<BigInteger> tokenIds, List<BigInteger> traitIds, List<string> values, CancellationTokenSource cancellationToken = null)
        {
            var batchSetTraitStringFunction = new BatchSetTraitStringFunction();
                batchSetTraitStringFunction.TokenContract = tokenContract;
                batchSetTraitStringFunction.TokenIds = tokenIds;
                batchSetTraitStringFunction.TraitIds = traitIds;
                batchSetTraitStringFunction.Values = values;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetTraitStringFunction, cancellationToken);
        }

        public Task<string> BatchSetTraitUint256RequestAsync(BatchSetTraitUint256Function batchSetTraitUint256Function)
        {
             return ContractHandler.SendRequestAsync(batchSetTraitUint256Function);
        }

        public Task<TransactionReceipt> BatchSetTraitUint256RequestAndWaitForReceiptAsync(BatchSetTraitUint256Function batchSetTraitUint256Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetTraitUint256Function, cancellationToken);
        }

        public Task<string> BatchSetTraitUint256RequestAsync(string tokenContract, List<BigInteger> tokenIds, List<BigInteger> traitIds, List<BigInteger> values)
        {
            var batchSetTraitUint256Function = new BatchSetTraitUint256Function();
                batchSetTraitUint256Function.TokenContract = tokenContract;
                batchSetTraitUint256Function.TokenIds = tokenIds;
                batchSetTraitUint256Function.TraitIds = traitIds;
                batchSetTraitUint256Function.Values = values;
            
             return ContractHandler.SendRequestAsync(batchSetTraitUint256Function);
        }

        public Task<TransactionReceipt> BatchSetTraitUint256RequestAndWaitForReceiptAsync(string tokenContract, List<BigInteger> tokenIds, List<BigInteger> traitIds, List<BigInteger> values, CancellationTokenSource cancellationToken = null)
        {
            var batchSetTraitUint256Function = new BatchSetTraitUint256Function();
                batchSetTraitUint256Function.TokenContract = tokenContract;
                batchSetTraitUint256Function.TokenIds = tokenIds;
                batchSetTraitUint256Function.TraitIds = traitIds;
                batchSetTraitUint256Function.Values = values;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetTraitUint256Function, cancellationToken);
        }

        public Task<string> DecrementTraitRequestAsync(DecrementTraitFunction decrementTraitFunction)
        {
             return ContractHandler.SendRequestAsync(decrementTraitFunction);
        }

        public Task<TransactionReceipt> DecrementTraitRequestAndWaitForReceiptAsync(DecrementTraitFunction decrementTraitFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(decrementTraitFunction, cancellationToken);
        }

        public Task<string> DecrementTraitRequestAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BigInteger amount)
        {
            var decrementTraitFunction = new DecrementTraitFunction();
                decrementTraitFunction.TokenContract = tokenContract;
                decrementTraitFunction.TokenId = tokenId;
                decrementTraitFunction.TraitId = traitId;
                decrementTraitFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(decrementTraitFunction);
        }

        public Task<TransactionReceipt> DecrementTraitRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var decrementTraitFunction = new DecrementTraitFunction();
                decrementTraitFunction.TokenContract = tokenContract;
                decrementTraitFunction.TokenId = tokenId;
                decrementTraitFunction.TraitId = traitId;
                decrementTraitFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(decrementTraitFunction, cancellationToken);
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

        public Task<string> GenerateTokenURIQueryAsync(GenerateTokenURIFunction generateTokenURIFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GenerateTokenURIFunction, string>(generateTokenURIFunction, blockParameter);
        }

        
        public Task<string> GenerateTokenURIQueryAsync(string tokenContract, BigInteger tokenId, List<TokenURITrait> extraTraits, BlockParameter blockParameter = null)
        {
            var generateTokenURIFunction = new GenerateTokenURIFunction();
                generateTokenURIFunction.TokenContract = tokenContract;
                generateTokenURIFunction.TokenId = tokenId;
                generateTokenURIFunction.ExtraTraits = extraTraits;
            
            return ContractHandler.QueryAsync<GenerateTokenURIFunction, string>(generateTokenURIFunction, blockParameter);
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

        public Task<bool> GetTraitBoolQueryAsync(GetTraitBoolFunction getTraitBoolFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTraitBoolFunction, bool>(getTraitBoolFunction, blockParameter);
        }

        
        public Task<bool> GetTraitBoolQueryAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BlockParameter blockParameter = null)
        {
            var getTraitBoolFunction = new GetTraitBoolFunction();
                getTraitBoolFunction.TokenContract = tokenContract;
                getTraitBoolFunction.TokenId = tokenId;
                getTraitBoolFunction.TraitId = traitId;
            
            return ContractHandler.QueryAsync<GetTraitBoolFunction, bool>(getTraitBoolFunction, blockParameter);
        }

        public Task<byte[]> GetTraitBytesQueryAsync(GetTraitBytesFunction getTraitBytesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTraitBytesFunction, byte[]>(getTraitBytesFunction, blockParameter);
        }

        
        public Task<byte[]> GetTraitBytesQueryAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BlockParameter blockParameter = null)
        {
            var getTraitBytesFunction = new GetTraitBytesFunction();
                getTraitBytesFunction.TokenContract = tokenContract;
                getTraitBytesFunction.TokenId = tokenId;
                getTraitBytesFunction.TraitId = traitId;
            
            return ContractHandler.QueryAsync<GetTraitBytesFunction, byte[]>(getTraitBytesFunction, blockParameter);
        }

        public Task<List<BigInteger>> GetTraitIdsQueryAsync(GetTraitIdsFunction getTraitIdsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTraitIdsFunction, List<BigInteger>>(getTraitIdsFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> GetTraitIdsQueryAsync(string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getTraitIdsFunction = new GetTraitIdsFunction();
                getTraitIdsFunction.TokenContract = tokenContract;
                getTraitIdsFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetTraitIdsFunction, List<BigInteger>>(getTraitIdsFunction, blockParameter);
        }

        public Task<BigInteger> GetTraitInt256QueryAsync(GetTraitInt256Function getTraitInt256Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTraitInt256Function, BigInteger>(getTraitInt256Function, blockParameter);
        }

        
        public Task<BigInteger> GetTraitInt256QueryAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BlockParameter blockParameter = null)
        {
            var getTraitInt256Function = new GetTraitInt256Function();
                getTraitInt256Function.TokenContract = tokenContract;
                getTraitInt256Function.TokenId = tokenId;
                getTraitInt256Function.TraitId = traitId;
            
            return ContractHandler.QueryAsync<GetTraitInt256Function, BigInteger>(getTraitInt256Function, blockParameter);
        }

        public Task<GetTraitMetadataOutputDTO> GetTraitMetadataQueryAsync(GetTraitMetadataFunction getTraitMetadataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetTraitMetadataFunction, GetTraitMetadataOutputDTO>(getTraitMetadataFunction, blockParameter);
        }

        public Task<GetTraitMetadataOutputDTO> GetTraitMetadataQueryAsync(BigInteger traitId, BlockParameter blockParameter = null)
        {
            var getTraitMetadataFunction = new GetTraitMetadataFunction();
                getTraitMetadataFunction.TraitId = traitId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetTraitMetadataFunction, GetTraitMetadataOutputDTO>(getTraitMetadataFunction, blockParameter);
        }

        public Task<string> GetTraitStringQueryAsync(GetTraitStringFunction getTraitStringFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTraitStringFunction, string>(getTraitStringFunction, blockParameter);
        }

        
        public Task<string> GetTraitStringQueryAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BlockParameter blockParameter = null)
        {
            var getTraitStringFunction = new GetTraitStringFunction();
                getTraitStringFunction.TokenContract = tokenContract;
                getTraitStringFunction.TokenId = tokenId;
                getTraitStringFunction.TraitId = traitId;
            
            return ContractHandler.QueryAsync<GetTraitStringFunction, string>(getTraitStringFunction, blockParameter);
        }

        public Task<BigInteger> GetTraitUint256QueryAsync(GetTraitUint256Function getTraitUint256Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetTraitUint256Function, BigInteger>(getTraitUint256Function, blockParameter);
        }

        
        public Task<BigInteger> GetTraitUint256QueryAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BlockParameter blockParameter = null)
        {
            var getTraitUint256Function = new GetTraitUint256Function();
                getTraitUint256Function.TokenContract = tokenContract;
                getTraitUint256Function.TokenId = tokenId;
                getTraitUint256Function.TraitId = traitId;
            
            return ContractHandler.QueryAsync<GetTraitUint256Function, BigInteger>(getTraitUint256Function, blockParameter);
        }

        public Task<bool> HasTraitQueryAsync(HasTraitFunction hasTraitFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<HasTraitFunction, bool>(hasTraitFunction, blockParameter);
        }

        
        public Task<bool> HasTraitQueryAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BlockParameter blockParameter = null)
        {
            var hasTraitFunction = new HasTraitFunction();
                hasTraitFunction.TokenContract = tokenContract;
                hasTraitFunction.TokenId = tokenId;
                hasTraitFunction.TraitId = traitId;
            
            return ContractHandler.QueryAsync<HasTraitFunction, bool>(hasTraitFunction, blockParameter);
        }

        public Task<string> IncrementTraitRequestAsync(IncrementTraitFunction incrementTraitFunction)
        {
             return ContractHandler.SendRequestAsync(incrementTraitFunction);
        }

        public Task<TransactionReceipt> IncrementTraitRequestAndWaitForReceiptAsync(IncrementTraitFunction incrementTraitFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(incrementTraitFunction, cancellationToken);
        }

        public Task<string> IncrementTraitRequestAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BigInteger amount)
        {
            var incrementTraitFunction = new IncrementTraitFunction();
                incrementTraitFunction.TokenContract = tokenContract;
                incrementTraitFunction.TokenId = tokenId;
                incrementTraitFunction.TraitId = traitId;
                incrementTraitFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(incrementTraitFunction);
        }

        public Task<TransactionReceipt> IncrementTraitRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var incrementTraitFunction = new IncrementTraitFunction();
                incrementTraitFunction.TokenContract = tokenContract;
                incrementTraitFunction.TokenId = tokenId;
                incrementTraitFunction.TraitId = traitId;
                incrementTraitFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(incrementTraitFunction, cancellationToken);
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

        public Task<string> SetTraitBoolRequestAsync(SetTraitBoolFunction setTraitBoolFunction)
        {
             return ContractHandler.SendRequestAsync(setTraitBoolFunction);
        }

        public Task<TransactionReceipt> SetTraitBoolRequestAndWaitForReceiptAsync(SetTraitBoolFunction setTraitBoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitBoolFunction, cancellationToken);
        }

        public Task<string> SetTraitBoolRequestAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, bool value)
        {
            var setTraitBoolFunction = new SetTraitBoolFunction();
                setTraitBoolFunction.TokenContract = tokenContract;
                setTraitBoolFunction.TokenId = tokenId;
                setTraitBoolFunction.TraitId = traitId;
                setTraitBoolFunction.Value = value;
            
             return ContractHandler.SendRequestAsync(setTraitBoolFunction);
        }

        public Task<TransactionReceipt> SetTraitBoolRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, bool value, CancellationTokenSource cancellationToken = null)
        {
            var setTraitBoolFunction = new SetTraitBoolFunction();
                setTraitBoolFunction.TokenContract = tokenContract;
                setTraitBoolFunction.TokenId = tokenId;
                setTraitBoolFunction.TraitId = traitId;
                setTraitBoolFunction.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitBoolFunction, cancellationToken);
        }

        public Task<string> SetTraitInt256RequestAsync(SetTraitInt256Function setTraitInt256Function)
        {
             return ContractHandler.SendRequestAsync(setTraitInt256Function);
        }

        public Task<TransactionReceipt> SetTraitInt256RequestAndWaitForReceiptAsync(SetTraitInt256Function setTraitInt256Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitInt256Function, cancellationToken);
        }

        public Task<string> SetTraitInt256RequestAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BigInteger value)
        {
            var setTraitInt256Function = new SetTraitInt256Function();
                setTraitInt256Function.TokenContract = tokenContract;
                setTraitInt256Function.TokenId = tokenId;
                setTraitInt256Function.TraitId = traitId;
                setTraitInt256Function.Value = value;
            
             return ContractHandler.SendRequestAsync(setTraitInt256Function);
        }

        public Task<TransactionReceipt> SetTraitInt256RequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BigInteger value, CancellationTokenSource cancellationToken = null)
        {
            var setTraitInt256Function = new SetTraitInt256Function();
                setTraitInt256Function.TokenContract = tokenContract;
                setTraitInt256Function.TokenId = tokenId;
                setTraitInt256Function.TraitId = traitId;
                setTraitInt256Function.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitInt256Function, cancellationToken);
        }

        public Task<string> SetTraitMetadataRequestAsync(SetTraitMetadataFunction setTraitMetadataFunction)
        {
             return ContractHandler.SendRequestAsync(setTraitMetadataFunction);
        }

        public Task<TransactionReceipt> SetTraitMetadataRequestAndWaitForReceiptAsync(SetTraitMetadataFunction setTraitMetadataFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitMetadataFunction, cancellationToken);
        }

        public Task<string> SetTraitMetadataRequestAsync(BigInteger traitId, TraitMetadata traitMetadata)
        {
            var setTraitMetadataFunction = new SetTraitMetadataFunction();
                setTraitMetadataFunction.TraitId = traitId;
                setTraitMetadataFunction.TraitMetadata = traitMetadata;
            
             return ContractHandler.SendRequestAsync(setTraitMetadataFunction);
        }

        public Task<TransactionReceipt> SetTraitMetadataRequestAndWaitForReceiptAsync(BigInteger traitId, TraitMetadata traitMetadata, CancellationTokenSource cancellationToken = null)
        {
            var setTraitMetadataFunction = new SetTraitMetadataFunction();
                setTraitMetadataFunction.TraitId = traitId;
                setTraitMetadataFunction.TraitMetadata = traitMetadata;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitMetadataFunction, cancellationToken);
        }

        public Task<string> SetTraitStringRequestAsync(SetTraitStringFunction setTraitStringFunction)
        {
             return ContractHandler.SendRequestAsync(setTraitStringFunction);
        }

        public Task<TransactionReceipt> SetTraitStringRequestAndWaitForReceiptAsync(SetTraitStringFunction setTraitStringFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitStringFunction, cancellationToken);
        }

        public Task<string> SetTraitStringRequestAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, string value)
        {
            var setTraitStringFunction = new SetTraitStringFunction();
                setTraitStringFunction.TokenContract = tokenContract;
                setTraitStringFunction.TokenId = tokenId;
                setTraitStringFunction.TraitId = traitId;
                setTraitStringFunction.Value = value;
            
             return ContractHandler.SendRequestAsync(setTraitStringFunction);
        }

        public Task<TransactionReceipt> SetTraitStringRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, string value, CancellationTokenSource cancellationToken = null)
        {
            var setTraitStringFunction = new SetTraitStringFunction();
                setTraitStringFunction.TokenContract = tokenContract;
                setTraitStringFunction.TokenId = tokenId;
                setTraitStringFunction.TraitId = traitId;
                setTraitStringFunction.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitStringFunction, cancellationToken);
        }

        public Task<string> SetTraitUint256RequestAsync(SetTraitUint256Function setTraitUint256Function)
        {
             return ContractHandler.SendRequestAsync(setTraitUint256Function);
        }

        public Task<TransactionReceipt> SetTraitUint256RequestAndWaitForReceiptAsync(SetTraitUint256Function setTraitUint256Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitUint256Function, cancellationToken);
        }

        public Task<string> SetTraitUint256RequestAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BigInteger value)
        {
            var setTraitUint256Function = new SetTraitUint256Function();
                setTraitUint256Function.TokenContract = tokenContract;
                setTraitUint256Function.TokenId = tokenId;
                setTraitUint256Function.TraitId = traitId;
                setTraitUint256Function.Value = value;
            
             return ContractHandler.SendRequestAsync(setTraitUint256Function);
        }

        public Task<TransactionReceipt> SetTraitUint256RequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, BigInteger traitId, BigInteger value, CancellationTokenSource cancellationToken = null)
        {
            var setTraitUint256Function = new SetTraitUint256Function();
                setTraitUint256Function.TokenContract = tokenContract;
                setTraitUint256Function.TokenId = tokenId;
                setTraitUint256Function.TraitId = traitId;
                setTraitUint256Function.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTraitUint256Function, cancellationToken);
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

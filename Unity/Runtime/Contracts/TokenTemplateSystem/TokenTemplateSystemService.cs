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
using PirateNationContracts.TokenTemplateSystem.ContractDefinition;

namespace PirateNationContracts.TokenTemplateSystem
{
    public partial class TokenTemplateSystemService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, TokenTemplateSystemDeployment tokenTemplateSystemDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<TokenTemplateSystemDeployment>().SendRequestAndWaitForReceiptAsync(tokenTemplateSystemDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, TokenTemplateSystemDeployment tokenTemplateSystemDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<TokenTemplateSystemDeployment>().SendRequestAsync(tokenTemplateSystemDeployment);
        }

        public static async Task<TokenTemplateSystemService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, TokenTemplateSystemDeployment tokenTemplateSystemDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, tokenTemplateSystemDeployment, cancellationTokenSource);
            return new TokenTemplateSystemService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public TokenTemplateSystemService(Nethereum.Web3.Web3 web3, string contractAddress)
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

        public Task<string> CreateEntityRequestAsync(CreateEntityFunction createEntityFunction)
        {
             return ContractHandler.SendRequestAsync(createEntityFunction);
        }

        public Task<TransactionReceipt> CreateEntityRequestAndWaitForReceiptAsync(CreateEntityFunction createEntityFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createEntityFunction, cancellationToken);
        }

        public Task<string> CreateEntityRequestAsync(BigInteger entityId)
        {
            var createEntityFunction = new CreateEntityFunction();
                createEntityFunction.EntityId = entityId;
            
             return ContractHandler.SendRequestAsync(createEntityFunction);
        }

        public Task<TransactionReceipt> CreateEntityRequestAndWaitForReceiptAsync(BigInteger entityId, CancellationTokenSource cancellationToken = null)
        {
            var createEntityFunction = new CreateEntityFunction();
                createEntityFunction.EntityId = entityId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createEntityFunction, cancellationToken);
        }

        public Task<bool> ExistsQueryAsync(ExistsFunction existsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ExistsFunction, bool>(existsFunction, blockParameter);
        }

        
        public Task<bool> ExistsQueryAsync(BigInteger templateId, BlockParameter blockParameter = null)
        {
            var existsFunction = new ExistsFunction();
                existsFunction.TemplateId = templateId;
            
            return ContractHandler.QueryAsync<ExistsFunction, bool>(existsFunction, blockParameter);
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

        
        public Task<string> GenerateTokenURIQueryAsync(string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var generateTokenURIFunction = new GenerateTokenURIFunction();
                generateTokenURIFunction.TokenContract = tokenContract;
                generateTokenURIFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GenerateTokenURIFunction, string>(generateTokenURIFunction, blockParameter);
        }

        public Task<string> GenerateTokenURIQueryAsync(GenerateTokenURI1Function generateTokenURI1Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GenerateTokenURI1Function, string>(generateTokenURI1Function, blockParameter);
        }

        
        public Task<string> GenerateTokenURIQueryAsync(string tokenContract, BigInteger tokenId, List<TokenURITrait> extraTraits, BlockParameter blockParameter = null)
        {
            var generateTokenURI1Function = new GenerateTokenURI1Function();
                generateTokenURI1Function.TokenContract = tokenContract;
                generateTokenURI1Function.TokenId = tokenId;
                generateTokenURI1Function.ExtraTraits = extraTraits;
            
            return ContractHandler.QueryAsync<GenerateTokenURI1Function, string>(generateTokenURI1Function, blockParameter);
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

        public Task<GetTemplateOutputDTO> GetTemplateQueryAsync(GetTemplateFunction getTemplateFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetTemplateFunction, GetTemplateOutputDTO>(getTemplateFunction, blockParameter);
        }

        public Task<GetTemplateOutputDTO> GetTemplateQueryAsync(string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getTemplateFunction = new GetTemplateFunction();
                getTemplateFunction.TokenContract = tokenContract;
                getTemplateFunction.TokenId = tokenId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetTemplateFunction, GetTemplateOutputDTO>(getTemplateFunction, blockParameter);
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

        public Task<bool> InitializedEntitiesQueryAsync(InitializedEntitiesFunction initializedEntitiesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<InitializedEntitiesFunction, bool>(initializedEntitiesFunction, blockParameter);
        }

        
        public Task<bool> InitializedEntitiesQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var initializedEntitiesFunction = new InitializedEntitiesFunction();
                initializedEntitiesFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<InitializedEntitiesFunction, bool>(initializedEntitiesFunction, blockParameter);
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

        public Task<string> SetTemplateRequestAsync(SetTemplateFunction setTemplateFunction)
        {
             return ContractHandler.SendRequestAsync(setTemplateFunction);
        }

        public Task<TransactionReceipt> SetTemplateRequestAndWaitForReceiptAsync(SetTemplateFunction setTemplateFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTemplateFunction, cancellationToken);
        }

        public Task<string> SetTemplateRequestAsync(string tokenContract, BigInteger tokenId, BigInteger templateId)
        {
            var setTemplateFunction = new SetTemplateFunction();
                setTemplateFunction.TokenContract = tokenContract;
                setTemplateFunction.TokenId = tokenId;
                setTemplateFunction.TemplateId = templateId;
            
             return ContractHandler.SendRequestAsync(setTemplateFunction);
        }

        public Task<TransactionReceipt> SetTemplateRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, BigInteger templateId, CancellationTokenSource cancellationToken = null)
        {
            var setTemplateFunction = new SetTemplateFunction();
                setTemplateFunction.TokenContract = tokenContract;
                setTemplateFunction.TokenId = tokenId;
                setTemplateFunction.TemplateId = templateId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTemplateFunction, cancellationToken);
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

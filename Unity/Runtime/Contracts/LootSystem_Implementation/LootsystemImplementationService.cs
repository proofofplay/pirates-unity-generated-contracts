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
using PirateNationContracts.LootSystem_Implementation.ContractDefinition;

namespace PirateNationContracts.LootSystem_Implementation
{
    public partial class LootsystemImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, LootsystemImplementationDeployment lootsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<LootsystemImplementationDeployment>().SendRequestAndWaitForReceiptAsync(lootsystemImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, LootsystemImplementationDeployment lootsystemImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<LootsystemImplementationDeployment>().SendRequestAsync(lootsystemImplementationDeployment);
        }

        public static async Task<LootsystemImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, LootsystemImplementationDeployment lootsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, lootsystemImplementationDeployment, cancellationTokenSource);
            return new LootsystemImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public LootsystemImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
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

        public Task<GetLootTableOutputDTO> GetLootTableQueryAsync(GetLootTableFunction getLootTableFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetLootTableFunction, GetLootTableOutputDTO>(getLootTableFunction, blockParameter);
        }

        public Task<GetLootTableOutputDTO> GetLootTableQueryAsync(BigInteger lootTableId, BlockParameter blockParameter = null)
        {
            var getLootTableFunction = new GetLootTableFunction();
                getLootTableFunction.LootTableId = lootTableId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetLootTableFunction, GetLootTableOutputDTO>(getLootTableFunction, blockParameter);
        }

        public Task<string> GrantLootRequestAsync(GrantLootFunction grantLootFunction)
        {
             return ContractHandler.SendRequestAsync(grantLootFunction);
        }

        public Task<TransactionReceipt> GrantLootRequestAndWaitForReceiptAsync(GrantLootFunction grantLootFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantLootFunction, cancellationToken);
        }

        public Task<string> GrantLootRequestAsync(string to, List<Loot> loots)
        {
            var grantLootFunction = new GrantLootFunction();
                grantLootFunction.To = to;
                grantLootFunction.Loots = loots;
            
             return ContractHandler.SendRequestAsync(grantLootFunction);
        }

        public Task<TransactionReceipt> GrantLootRequestAndWaitForReceiptAsync(string to, List<Loot> loots, CancellationTokenSource cancellationToken = null)
        {
            var grantLootFunction = new GrantLootFunction();
                grantLootFunction.To = to;
                grantLootFunction.Loots = loots;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantLootFunction, cancellationToken);
        }

        public Task<string> GrantLootWithRandomWordRequestAsync(GrantLootWithRandomWordFunction grantLootWithRandomWordFunction)
        {
             return ContractHandler.SendRequestAsync(grantLootWithRandomWordFunction);
        }

        public Task<TransactionReceipt> GrantLootWithRandomWordRequestAndWaitForReceiptAsync(GrantLootWithRandomWordFunction grantLootWithRandomWordFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantLootWithRandomWordFunction, cancellationToken);
        }

        public Task<string> GrantLootWithRandomWordRequestAsync(string to, List<Loot> loots, BigInteger randomWord)
        {
            var grantLootWithRandomWordFunction = new GrantLootWithRandomWordFunction();
                grantLootWithRandomWordFunction.To = to;
                grantLootWithRandomWordFunction.Loots = loots;
                grantLootWithRandomWordFunction.RandomWord = randomWord;
            
             return ContractHandler.SendRequestAsync(grantLootWithRandomWordFunction);
        }

        public Task<TransactionReceipt> GrantLootWithRandomWordRequestAndWaitForReceiptAsync(string to, List<Loot> loots, BigInteger randomWord, CancellationTokenSource cancellationToken = null)
        {
            var grantLootWithRandomWordFunction = new GrantLootWithRandomWordFunction();
                grantLootWithRandomWordFunction.To = to;
                grantLootWithRandomWordFunction.Loots = loots;
                grantLootWithRandomWordFunction.RandomWord = randomWord;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantLootWithRandomWordFunction, cancellationToken);
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

        public Task<string> SetLootTableRequestAsync(SetLootTableFunction setLootTableFunction)
        {
             return ContractHandler.SendRequestAsync(setLootTableFunction);
        }

        public Task<TransactionReceipt> SetLootTableRequestAndWaitForReceiptAsync(SetLootTableFunction setLootTableFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setLootTableFunction, cancellationToken);
        }

        public Task<string> SetLootTableRequestAsync(BigInteger lootTableId, List<List<Loot>> loots, List<uint> weights, List<uint> maxSupply)
        {
            var setLootTableFunction = new SetLootTableFunction();
                setLootTableFunction.LootTableId = lootTableId;
                setLootTableFunction.Loots = loots;
                setLootTableFunction.Weights = weights;
                setLootTableFunction.MaxSupply = maxSupply;
            
             return ContractHandler.SendRequestAsync(setLootTableFunction);
        }

        public Task<TransactionReceipt> SetLootTableRequestAndWaitForReceiptAsync(BigInteger lootTableId, List<List<Loot>> loots, List<uint> weights, List<uint> maxSupply, CancellationTokenSource cancellationToken = null)
        {
            var setLootTableFunction = new SetLootTableFunction();
                setLootTableFunction.LootTableId = lootTableId;
                setLootTableFunction.Loots = loots;
                setLootTableFunction.Weights = weights;
                setLootTableFunction.MaxSupply = maxSupply;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setLootTableFunction, cancellationToken);
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

        public Task<bool> ValidateLootsQueryAsync(ValidateLootsFunction validateLootsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ValidateLootsFunction, bool>(validateLootsFunction, blockParameter);
        }

        
        public Task<bool> ValidateLootsQueryAsync(List<Loot> loots, BlockParameter blockParameter = null)
        {
            var validateLootsFunction = new ValidateLootsFunction();
                validateLootsFunction.Loots = loots;
            
            return ContractHandler.QueryAsync<ValidateLootsFunction, bool>(validateLootsFunction, blockParameter);
        }
    }
}

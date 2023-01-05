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
using PirateNationContracts.LockingSystem.ContractDefinition;

namespace PirateNationContracts.LockingSystem
{
    public partial class LockingSystemService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, LockingSystemDeployment lockingSystemDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<LockingSystemDeployment>().SendRequestAndWaitForReceiptAsync(lockingSystemDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, LockingSystemDeployment lockingSystemDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<LockingSystemDeployment>().SendRequestAsync(lockingSystemDeployment);
        }

        public static async Task<LockingSystemService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, LockingSystemDeployment lockingSystemDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, lockingSystemDeployment, cancellationTokenSource);
            return new LockingSystemService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public LockingSystemService(Nethereum.Web3.Web3 web3, string contractAddress)
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

        public Task<string> AddItemReservationRequestAsync(AddItemReservationFunction addItemReservationFunction)
        {
             return ContractHandler.SendRequestAsync(addItemReservationFunction);
        }

        public Task<TransactionReceipt> AddItemReservationRequestAndWaitForReceiptAsync(AddItemReservationFunction addItemReservationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addItemReservationFunction, cancellationToken);
        }

        public Task<string> AddItemReservationRequestAsync(string account, string tokenContract, BigInteger tokenId, BigInteger amount, bool exclusive, uint data)
        {
            var addItemReservationFunction = new AddItemReservationFunction();
                addItemReservationFunction.Account = account;
                addItemReservationFunction.TokenContract = tokenContract;
                addItemReservationFunction.TokenId = tokenId;
                addItemReservationFunction.Amount = amount;
                addItemReservationFunction.Exclusive = exclusive;
                addItemReservationFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(addItemReservationFunction);
        }

        public Task<TransactionReceipt> AddItemReservationRequestAndWaitForReceiptAsync(string account, string tokenContract, BigInteger tokenId, BigInteger amount, bool exclusive, uint data, CancellationTokenSource cancellationToken = null)
        {
            var addItemReservationFunction = new AddItemReservationFunction();
                addItemReservationFunction.Account = account;
                addItemReservationFunction.TokenContract = tokenContract;
                addItemReservationFunction.TokenId = tokenId;
                addItemReservationFunction.Amount = amount;
                addItemReservationFunction.Exclusive = exclusive;
                addItemReservationFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addItemReservationFunction, cancellationToken);
        }

        public Task<string> AddNFTReservationRequestAsync(AddNFTReservationFunction addNFTReservationFunction)
        {
             return ContractHandler.SendRequestAsync(addNFTReservationFunction);
        }

        public Task<TransactionReceipt> AddNFTReservationRequestAndWaitForReceiptAsync(AddNFTReservationFunction addNFTReservationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addNFTReservationFunction, cancellationToken);
        }

        public Task<string> AddNFTReservationRequestAsync(string tokenContract, BigInteger tokenId, bool exclusive, uint data)
        {
            var addNFTReservationFunction = new AddNFTReservationFunction();
                addNFTReservationFunction.TokenContract = tokenContract;
                addNFTReservationFunction.TokenId = tokenId;
                addNFTReservationFunction.Exclusive = exclusive;
                addNFTReservationFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(addNFTReservationFunction);
        }

        public Task<TransactionReceipt> AddNFTReservationRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, bool exclusive, uint data, CancellationTokenSource cancellationToken = null)
        {
            var addNFTReservationFunction = new AddNFTReservationFunction();
                addNFTReservationFunction.TokenContract = tokenContract;
                addNFTReservationFunction.TokenId = tokenId;
                addNFTReservationFunction.Exclusive = exclusive;
                addNFTReservationFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(addNFTReservationFunction, cancellationToken);
        }

        public Task<bool> CanTransferItemsQueryAsync(CanTransferItemsFunction canTransferItemsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CanTransferItemsFunction, bool>(canTransferItemsFunction, blockParameter);
        }

        
        public Task<bool> CanTransferItemsQueryAsync(string account, string tokenContract, List<BigInteger> ids, List<BigInteger> amounts, BlockParameter blockParameter = null)
        {
            var canTransferItemsFunction = new CanTransferItemsFunction();
                canTransferItemsFunction.Account = account;
                canTransferItemsFunction.TokenContract = tokenContract;
                canTransferItemsFunction.Ids = ids;
                canTransferItemsFunction.Amounts = amounts;
            
            return ContractHandler.QueryAsync<CanTransferItemsFunction, bool>(canTransferItemsFunction, blockParameter);
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

        public Task<GetItemReservationOutputDTO> GetItemReservationQueryAsync(GetItemReservationFunction getItemReservationFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetItemReservationFunction, GetItemReservationOutputDTO>(getItemReservationFunction, blockParameter);
        }

        public Task<GetItemReservationOutputDTO> GetItemReservationQueryAsync(string account, string tokenContract, BigInteger tokenId, uint reservationId, BlockParameter blockParameter = null)
        {
            var getItemReservationFunction = new GetItemReservationFunction();
                getItemReservationFunction.Account = account;
                getItemReservationFunction.TokenContract = tokenContract;
                getItemReservationFunction.TokenId = tokenId;
                getItemReservationFunction.ReservationId = reservationId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetItemReservationFunction, GetItemReservationOutputDTO>(getItemReservationFunction, blockParameter);
        }

        public Task<List<uint>> GetItemReservationIdsQueryAsync(GetItemReservationIdsFunction getItemReservationIdsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetItemReservationIdsFunction, List<uint>>(getItemReservationIdsFunction, blockParameter);
        }

        
        public Task<List<uint>> GetItemReservationIdsQueryAsync(string account, string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getItemReservationIdsFunction = new GetItemReservationIdsFunction();
                getItemReservationIdsFunction.Account = account;
                getItemReservationIdsFunction.TokenContract = tokenContract;
                getItemReservationIdsFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetItemReservationIdsFunction, List<uint>>(getItemReservationIdsFunction, blockParameter);
        }

        public Task<GetNFTReservationOutputDTO> GetNFTReservationQueryAsync(GetNFTReservationFunction getNFTReservationFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetNFTReservationFunction, GetNFTReservationOutputDTO>(getNFTReservationFunction, blockParameter);
        }

        public Task<GetNFTReservationOutputDTO> GetNFTReservationQueryAsync(string tokenContract, BigInteger tokenId, uint reservationId, BlockParameter blockParameter = null)
        {
            var getNFTReservationFunction = new GetNFTReservationFunction();
                getNFTReservationFunction.TokenContract = tokenContract;
                getNFTReservationFunction.TokenId = tokenId;
                getNFTReservationFunction.ReservationId = reservationId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetNFTReservationFunction, GetNFTReservationOutputDTO>(getNFTReservationFunction, blockParameter);
        }

        public Task<List<uint>> GetNFTReservationIdsQueryAsync(GetNFTReservationIdsFunction getNFTReservationIdsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetNFTReservationIdsFunction, List<uint>>(getNFTReservationIdsFunction, blockParameter);
        }

        
        public Task<List<uint>> GetNFTReservationIdsQueryAsync(string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getNFTReservationIdsFunction = new GetNFTReservationIdsFunction();
                getNFTReservationIdsFunction.TokenContract = tokenContract;
                getNFTReservationIdsFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetNFTReservationIdsFunction, List<uint>>(getNFTReservationIdsFunction, blockParameter);
        }

        public Task<bool> GetRescueUnlockEnabledQueryAsync(GetRescueUnlockEnabledFunction getRescueUnlockEnabledFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetRescueUnlockEnabledFunction, bool>(getRescueUnlockEnabledFunction, blockParameter);
        }

        
        public Task<bool> GetRescueUnlockEnabledQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetRescueUnlockEnabledFunction, bool>(null, blockParameter);
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

        public Task<bool> IsNFTLockedQueryAsync(IsNFTLockedFunction isNFTLockedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsNFTLockedFunction, bool>(isNFTLockedFunction, blockParameter);
        }

        
        public Task<bool> IsNFTLockedQueryAsync(string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var isNFTLockedFunction = new IsNFTLockedFunction();
                isNFTLockedFunction.TokenContract = tokenContract;
                isNFTLockedFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<IsNFTLockedFunction, bool>(isNFTLockedFunction, blockParameter);
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

        public Task<BigInteger> ItemAmountLockedQueryAsync(ItemAmountLockedFunction itemAmountLockedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ItemAmountLockedFunction, BigInteger>(itemAmountLockedFunction, blockParameter);
        }

        
        public Task<BigInteger> ItemAmountLockedQueryAsync(string account, string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var itemAmountLockedFunction = new ItemAmountLockedFunction();
                itemAmountLockedFunction.Account = account;
                itemAmountLockedFunction.TokenContract = tokenContract;
                itemAmountLockedFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<ItemAmountLockedFunction, BigInteger>(itemAmountLockedFunction, blockParameter);
        }

        public Task<BigInteger> ItemAmountUnlockedQueryAsync(ItemAmountUnlockedFunction itemAmountUnlockedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ItemAmountUnlockedFunction, BigInteger>(itemAmountUnlockedFunction, blockParameter);
        }

        
        public Task<BigInteger> ItemAmountUnlockedQueryAsync(string account, string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var itemAmountUnlockedFunction = new ItemAmountUnlockedFunction();
                itemAmountUnlockedFunction.Account = account;
                itemAmountUnlockedFunction.TokenContract = tokenContract;
                itemAmountUnlockedFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<ItemAmountUnlockedFunction, BigInteger>(itemAmountUnlockedFunction, blockParameter);
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

        public Task<string> RemoveItemReservationRequestAsync(RemoveItemReservationFunction removeItemReservationFunction)
        {
             return ContractHandler.SendRequestAsync(removeItemReservationFunction);
        }

        public Task<TransactionReceipt> RemoveItemReservationRequestAndWaitForReceiptAsync(RemoveItemReservationFunction removeItemReservationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeItemReservationFunction, cancellationToken);
        }

        public Task<string> RemoveItemReservationRequestAsync(string account, string tokenContract, BigInteger tokenId, uint reservationId)
        {
            var removeItemReservationFunction = new RemoveItemReservationFunction();
                removeItemReservationFunction.Account = account;
                removeItemReservationFunction.TokenContract = tokenContract;
                removeItemReservationFunction.TokenId = tokenId;
                removeItemReservationFunction.ReservationId = reservationId;
            
             return ContractHandler.SendRequestAsync(removeItemReservationFunction);
        }

        public Task<TransactionReceipt> RemoveItemReservationRequestAndWaitForReceiptAsync(string account, string tokenContract, BigInteger tokenId, uint reservationId, CancellationTokenSource cancellationToken = null)
        {
            var removeItemReservationFunction = new RemoveItemReservationFunction();
                removeItemReservationFunction.Account = account;
                removeItemReservationFunction.TokenContract = tokenContract;
                removeItemReservationFunction.TokenId = tokenId;
                removeItemReservationFunction.ReservationId = reservationId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeItemReservationFunction, cancellationToken);
        }

        public Task<string> RemoveNFTReservationRequestAsync(RemoveNFTReservationFunction removeNFTReservationFunction)
        {
             return ContractHandler.SendRequestAsync(removeNFTReservationFunction);
        }

        public Task<TransactionReceipt> RemoveNFTReservationRequestAndWaitForReceiptAsync(RemoveNFTReservationFunction removeNFTReservationFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeNFTReservationFunction, cancellationToken);
        }

        public Task<string> RemoveNFTReservationRequestAsync(string tokenContract, BigInteger tokenId, uint reservationId)
        {
            var removeNFTReservationFunction = new RemoveNFTReservationFunction();
                removeNFTReservationFunction.TokenContract = tokenContract;
                removeNFTReservationFunction.TokenId = tokenId;
                removeNFTReservationFunction.ReservationId = reservationId;
            
             return ContractHandler.SendRequestAsync(removeNFTReservationFunction);
        }

        public Task<TransactionReceipt> RemoveNFTReservationRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, uint reservationId, CancellationTokenSource cancellationToken = null)
        {
            var removeNFTReservationFunction = new RemoveNFTReservationFunction();
                removeNFTReservationFunction.TokenContract = tokenContract;
                removeNFTReservationFunction.TokenId = tokenId;
                removeNFTReservationFunction.ReservationId = reservationId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(removeNFTReservationFunction, cancellationToken);
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

        public Task<bool> RescueUnlockEnabledQueryAsync(RescueUnlockEnabledFunction rescueUnlockEnabledFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RescueUnlockEnabledFunction, bool>(rescueUnlockEnabledFunction, blockParameter);
        }

        
        public Task<bool> RescueUnlockEnabledQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RescueUnlockEnabledFunction, bool>(null, blockParameter);
        }

        public Task<string> RescueUnlockItemsRequestAsync(RescueUnlockItemsFunction rescueUnlockItemsFunction)
        {
             return ContractHandler.SendRequestAsync(rescueUnlockItemsFunction);
        }

        public Task<TransactionReceipt> RescueUnlockItemsRequestAndWaitForReceiptAsync(RescueUnlockItemsFunction rescueUnlockItemsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rescueUnlockItemsFunction, cancellationToken);
        }

        public Task<string> RescueUnlockItemsRequestAsync(string account, string tokenContract, BigInteger tokenId)
        {
            var rescueUnlockItemsFunction = new RescueUnlockItemsFunction();
                rescueUnlockItemsFunction.Account = account;
                rescueUnlockItemsFunction.TokenContract = tokenContract;
                rescueUnlockItemsFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(rescueUnlockItemsFunction);
        }

        public Task<TransactionReceipt> RescueUnlockItemsRequestAndWaitForReceiptAsync(string account, string tokenContract, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var rescueUnlockItemsFunction = new RescueUnlockItemsFunction();
                rescueUnlockItemsFunction.Account = account;
                rescueUnlockItemsFunction.TokenContract = tokenContract;
                rescueUnlockItemsFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rescueUnlockItemsFunction, cancellationToken);
        }

        public Task<string> RescueUnlockNFTRequestAsync(RescueUnlockNFTFunction rescueUnlockNFTFunction)
        {
             return ContractHandler.SendRequestAsync(rescueUnlockNFTFunction);
        }

        public Task<TransactionReceipt> RescueUnlockNFTRequestAndWaitForReceiptAsync(RescueUnlockNFTFunction rescueUnlockNFTFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rescueUnlockNFTFunction, cancellationToken);
        }

        public Task<string> RescueUnlockNFTRequestAsync(string tokenContract, BigInteger tokenId)
        {
            var rescueUnlockNFTFunction = new RescueUnlockNFTFunction();
                rescueUnlockNFTFunction.TokenContract = tokenContract;
                rescueUnlockNFTFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(rescueUnlockNFTFunction);
        }

        public Task<TransactionReceipt> RescueUnlockNFTRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var rescueUnlockNFTFunction = new RescueUnlockNFTFunction();
                rescueUnlockNFTFunction.TokenContract = tokenContract;
                rescueUnlockNFTFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rescueUnlockNFTFunction, cancellationToken);
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

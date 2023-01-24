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
using PirateNationContracts.ShipSystem.ContractDefinition;

namespace PirateNationContracts.ShipSystem
{
    public partial class ShipSystemService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, ShipSystemDeployment shipSystemDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<ShipSystemDeployment>().SendRequestAndWaitForReceiptAsync(shipSystemDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, ShipSystemDeployment shipSystemDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<ShipSystemDeployment>().SendRequestAsync(shipSystemDeployment);
        }

        public static async Task<ShipSystemService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, ShipSystemDeployment shipSystemDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, shipSystemDeployment, cancellationTokenSource);
            return new ShipSystemService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public ShipSystemService(Nethereum.Web3.Web3 web3, string contractAddress)
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

        public Task<BigInteger> CurrentShipIdQueryAsync(CurrentShipIdFunction currentShipIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CurrentShipIdFunction, BigInteger>(currentShipIdFunction, blockParameter);
        }

        
        public Task<BigInteger> CurrentShipIdQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CurrentShipIdFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> EquipRequestAsync(EquipFunction equipFunction)
        {
             return ContractHandler.SendRequestAsync(equipFunction);
        }

        public Task<TransactionReceipt> EquipRequestAndWaitForReceiptAsync(EquipFunction equipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(equipFunction, cancellationToken);
        }

        public Task<string> EquipRequestAsync(SlotInputParams @params)
        {
            var equipFunction = new EquipFunction();
                equipFunction.Params = @params;
            
             return ContractHandler.SendRequestAsync(equipFunction);
        }

        public Task<TransactionReceipt> EquipRequestAndWaitForReceiptAsync(SlotInputParams @params, CancellationTokenSource cancellationToken = null)
        {
            var equipFunction = new EquipFunction();
                equipFunction.Params = @params;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(equipFunction, cancellationToken);
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

        public Task<GetSlotsOutputDTO> GetSlotsQueryAsync(GetSlotsFunction getSlotsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetSlotsFunction, GetSlotsOutputDTO>(getSlotsFunction, blockParameter);
        }

        public Task<GetSlotsOutputDTO> GetSlotsQueryAsync(string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getSlotsFunction = new GetSlotsFunction();
                getSlotsFunction.TokenContract = tokenContract;
                getSlotsFunction.TokenId = tokenId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetSlotsFunction, GetSlotsOutputDTO>(getSlotsFunction, blockParameter);
        }

        public Task<GetTokenTotalsDataOutputDTO> GetTokenTotalsDataQueryAsync(GetTokenTotalsDataFunction getTokenTotalsDataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetTokenTotalsDataFunction, GetTokenTotalsDataOutputDTO>(getTokenTotalsDataFunction, blockParameter);
        }

        public Task<GetTokenTotalsDataOutputDTO> GetTokenTotalsDataQueryAsync(string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getTokenTotalsDataFunction = new GetTokenTotalsDataFunction();
                getTokenTotalsDataFunction.TokenContract = tokenContract;
                getTokenTotalsDataFunction.TokenId = tokenId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetTokenTotalsDataFunction, GetTokenTotalsDataOutputDTO>(getTokenTotalsDataFunction, blockParameter);
        }

        public Task<string> GrantLootRequestAsync(GrantLootFunction grantLootFunction)
        {
             return ContractHandler.SendRequestAsync(grantLootFunction);
        }

        public Task<TransactionReceipt> GrantLootRequestAndWaitForReceiptAsync(GrantLootFunction grantLootFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantLootFunction, cancellationToken);
        }

        public Task<string> GrantLootRequestAsync(string account, BigInteger lootId, BigInteger amount)
        {
            var grantLootFunction = new GrantLootFunction();
                grantLootFunction.Account = account;
                grantLootFunction.LootId = lootId;
                grantLootFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(grantLootFunction);
        }

        public Task<TransactionReceipt> GrantLootRequestAndWaitForReceiptAsync(string account, BigInteger lootId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var grantLootFunction = new GrantLootFunction();
                grantLootFunction.Account = account;
                grantLootFunction.LootId = lootId;
                grantLootFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantLootFunction, cancellationToken);
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

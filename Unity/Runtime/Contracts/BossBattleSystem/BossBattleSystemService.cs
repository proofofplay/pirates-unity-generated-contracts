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
using PirateNationContracts.BossBattleSystem.ContractDefinition;

namespace PirateNationContracts.BossBattleSystem
{
    public partial class BossBattleSystemService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, BossBattleSystemDeployment bossBattleSystemDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<BossBattleSystemDeployment>().SendRequestAndWaitForReceiptAsync(bossBattleSystemDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, BossBattleSystemDeployment bossBattleSystemDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<BossBattleSystemDeployment>().SendRequestAsync(bossBattleSystemDeployment);
        }

        public static async Task<BossBattleSystemService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, BossBattleSystemDeployment bossBattleSystemDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, bossBattleSystemDeployment, cancellationTokenSource);
            return new BossBattleSystemService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public BossBattleSystemService(Nethereum.Web3.Web3 web3, string contractAddress)
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

        public Task<string> EndBattleRequestAsync(EndBattleFunction endBattleFunction)
        {
             return ContractHandler.SendRequestAsync(endBattleFunction);
        }

        public Task<TransactionReceipt> EndBattleRequestAndWaitForReceiptAsync(EndBattleFunction endBattleFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(endBattleFunction, cancellationToken);
        }

        public Task<string> EndBattleRequestAsync(BigInteger battleEntity, List<BigInteger> moves, BigInteger totalDamageTaken, BigInteger totalDamageDealt)
        {
            var endBattleFunction = new EndBattleFunction();
                endBattleFunction.BattleEntity = battleEntity;
                endBattleFunction.Moves = moves;
                endBattleFunction.TotalDamageTaken = totalDamageTaken;
                endBattleFunction.TotalDamageDealt = totalDamageDealt;
            
             return ContractHandler.SendRequestAsync(endBattleFunction);
        }

        public Task<TransactionReceipt> EndBattleRequestAndWaitForReceiptAsync(BigInteger battleEntity, List<BigInteger> moves, BigInteger totalDamageTaken, BigInteger totalDamageDealt, CancellationTokenSource cancellationToken = null)
        {
            var endBattleFunction = new EndBattleFunction();
                endBattleFunction.BattleEntity = battleEntity;
                endBattleFunction.Moves = moves;
                endBattleFunction.TotalDamageTaken = totalDamageTaken;
                endBattleFunction.TotalDamageDealt = totalDamageDealt;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(endBattleFunction, cancellationToken);
        }

        public Task<string> EndBattleMockRequestAsync(EndBattleMockFunction endBattleMockFunction)
        {
             return ContractHandler.SendRequestAsync(endBattleMockFunction);
        }

        public Task<TransactionReceipt> EndBattleMockRequestAndWaitForReceiptAsync(EndBattleMockFunction endBattleMockFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(endBattleMockFunction, cancellationToken);
        }

        public Task<string> EndBattleMockRequestAsync(BigInteger battleEntity, List<BigInteger> moves, BigInteger totalDamageTaken, BigInteger totalDamageDealt)
        {
            var endBattleMockFunction = new EndBattleMockFunction();
                endBattleMockFunction.BattleEntity = battleEntity;
                endBattleMockFunction.Moves = moves;
                endBattleMockFunction.TotalDamageTaken = totalDamageTaken;
                endBattleMockFunction.TotalDamageDealt = totalDamageDealt;
            
             return ContractHandler.SendRequestAsync(endBattleMockFunction);
        }

        public Task<TransactionReceipt> EndBattleMockRequestAndWaitForReceiptAsync(BigInteger battleEntity, List<BigInteger> moves, BigInteger totalDamageTaken, BigInteger totalDamageDealt, CancellationTokenSource cancellationToken = null)
        {
            var endBattleMockFunction = new EndBattleMockFunction();
                endBattleMockFunction.BattleEntity = battleEntity;
                endBattleMockFunction.Moves = moves;
                endBattleMockFunction.TotalDamageTaken = totalDamageTaken;
                endBattleMockFunction.TotalDamageDealt = totalDamageDealt;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(endBattleMockFunction, cancellationToken);
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

        public Task<GetActiveBattleOutputDTO> GetActiveBattleQueryAsync(GetActiveBattleFunction getActiveBattleFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetActiveBattleFunction, GetActiveBattleOutputDTO>(getActiveBattleFunction, blockParameter);
        }

        public Task<GetActiveBattleOutputDTO> GetActiveBattleQueryAsync(BigInteger battleEntity, BlockParameter blockParameter = null)
        {
            var getActiveBattleFunction = new GetActiveBattleFunction();
                getActiveBattleFunction.BattleEntity = battleEntity;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetActiveBattleFunction, GetActiveBattleOutputDTO>(getActiveBattleFunction, blockParameter);
        }

        public Task<GetActiveBattleByWalletOutputDTO> GetActiveBattleByWalletQueryAsync(GetActiveBattleByWalletFunction getActiveBattleByWalletFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetActiveBattleByWalletFunction, GetActiveBattleByWalletOutputDTO>(getActiveBattleByWalletFunction, blockParameter);
        }

        public Task<GetActiveBattleByWalletOutputDTO> GetActiveBattleByWalletQueryAsync(string wallet, BlockParameter blockParameter = null)
        {
            var getActiveBattleByWalletFunction = new GetActiveBattleByWalletFunction();
                getActiveBattleByWalletFunction.Wallet = wallet;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetActiveBattleByWalletFunction, GetActiveBattleByWalletOutputDTO>(getActiveBattleByWalletFunction, blockParameter);
        }

        public Task<GetBattleOutputDTO> GetBattleQueryAsync(GetBattleFunction getBattleFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetBattleFunction, GetBattleOutputDTO>(getBattleFunction, blockParameter);
        }

        public Task<GetBattleOutputDTO> GetBattleQueryAsync(BigInteger battleEntity, BlockParameter blockParameter = null)
        {
            var getBattleFunction = new GetBattleFunction();
                getBattleFunction.BattleEntity = battleEntity;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetBattleFunction, GetBattleOutputDTO>(getBattleFunction, blockParameter);
        }

        public Task<BigInteger> GetCurrentBattleIdQueryAsync(GetCurrentBattleIdFunction getCurrentBattleIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCurrentBattleIdFunction, BigInteger>(getCurrentBattleIdFunction, blockParameter);
        }

        
        public Task<BigInteger> GetCurrentBattleIdQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCurrentBattleIdFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> GetEntityQueryAsync(GetEntityFunction getEntityFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetEntityFunction, BigInteger>(getEntityFunction, blockParameter);
        }

        
        public Task<BigInteger> GetEntityQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getEntityFunction = new GetEntityFunction();
                getEntityFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<GetEntityFunction, BigInteger>(getEntityFunction, blockParameter);
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

        public Task<uint> GetShipCooldownQueryAsync(GetShipCooldownFunction getShipCooldownFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetShipCooldownFunction, uint>(getShipCooldownFunction, blockParameter);
        }

        
        public Task<uint> GetShipCooldownQueryAsync(BigInteger shipEntity, BlockParameter blockParameter = null)
        {
            var getShipCooldownFunction = new GetShipCooldownFunction();
                getShipCooldownFunction.ShipEntity = shipEntity;
            
            return ContractHandler.QueryAsync<GetShipCooldownFunction, uint>(getShipCooldownFunction, blockParameter);
        }

        public Task<GetTokenOutputDTO> GetTokenQueryAsync(GetTokenFunction getTokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetTokenFunction, GetTokenOutputDTO>(getTokenFunction, blockParameter);
        }

        public Task<GetTokenOutputDTO> GetTokenQueryAsync(BigInteger entity, BlockParameter blockParameter = null)
        {
            var getTokenFunction = new GetTokenFunction();
                getTokenFunction.Entity = entity;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetTokenFunction, GetTokenOutputDTO>(getTokenFunction, blockParameter);
        }

        public Task<uint> GetWalletCooldownQueryAsync(GetWalletCooldownFunction getWalletCooldownFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetWalletCooldownFunction, uint>(getWalletCooldownFunction, blockParameter);
        }

        
        public Task<uint> GetWalletCooldownQueryAsync(string wallet, BlockParameter blockParameter = null)
        {
            var getWalletCooldownFunction = new GetWalletCooldownFunction();
                getWalletCooldownFunction.Wallet = wallet;
            
            return ContractHandler.QueryAsync<GetWalletCooldownFunction, uint>(getWalletCooldownFunction, blockParameter);
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

        public Task<string> RewindBattleTimelimitRequestAsync(RewindBattleTimelimitFunction rewindBattleTimelimitFunction)
        {
             return ContractHandler.SendRequestAsync(rewindBattleTimelimitFunction);
        }

        public Task<TransactionReceipt> RewindBattleTimelimitRequestAndWaitForReceiptAsync(RewindBattleTimelimitFunction rewindBattleTimelimitFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rewindBattleTimelimitFunction, cancellationToken);
        }

        public Task<string> RewindBattleTimelimitRequestAsync(BigInteger battleEntity, uint rewindTime)
        {
            var rewindBattleTimelimitFunction = new RewindBattleTimelimitFunction();
                rewindBattleTimelimitFunction.BattleEntity = battleEntity;
                rewindBattleTimelimitFunction.RewindTime = rewindTime;
            
             return ContractHandler.SendRequestAsync(rewindBattleTimelimitFunction);
        }

        public Task<TransactionReceipt> RewindBattleTimelimitRequestAndWaitForReceiptAsync(BigInteger battleEntity, uint rewindTime, CancellationTokenSource cancellationToken = null)
        {
            var rewindBattleTimelimitFunction = new RewindBattleTimelimitFunction();
                rewindBattleTimelimitFunction.BattleEntity = battleEntity;
                rewindBattleTimelimitFunction.RewindTime = rewindTime;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rewindBattleTimelimitFunction, cancellationToken);
        }

        public Task<string> RewindShipCooldownRequestAsync(RewindShipCooldownFunction rewindShipCooldownFunction)
        {
             return ContractHandler.SendRequestAsync(rewindShipCooldownFunction);
        }

        public Task<TransactionReceipt> RewindShipCooldownRequestAndWaitForReceiptAsync(RewindShipCooldownFunction rewindShipCooldownFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rewindShipCooldownFunction, cancellationToken);
        }

        public Task<string> RewindShipCooldownRequestAsync(BigInteger shipEntity, uint rewindTime)
        {
            var rewindShipCooldownFunction = new RewindShipCooldownFunction();
                rewindShipCooldownFunction.ShipEntity = shipEntity;
                rewindShipCooldownFunction.RewindTime = rewindTime;
            
             return ContractHandler.SendRequestAsync(rewindShipCooldownFunction);
        }

        public Task<TransactionReceipt> RewindShipCooldownRequestAndWaitForReceiptAsync(BigInteger shipEntity, uint rewindTime, CancellationTokenSource cancellationToken = null)
        {
            var rewindShipCooldownFunction = new RewindShipCooldownFunction();
                rewindShipCooldownFunction.ShipEntity = shipEntity;
                rewindShipCooldownFunction.RewindTime = rewindTime;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rewindShipCooldownFunction, cancellationToken);
        }

        public Task<string> RewindWalletCooldownRequestAsync(RewindWalletCooldownFunction rewindWalletCooldownFunction)
        {
             return ContractHandler.SendRequestAsync(rewindWalletCooldownFunction);
        }

        public Task<TransactionReceipt> RewindWalletCooldownRequestAndWaitForReceiptAsync(RewindWalletCooldownFunction rewindWalletCooldownFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rewindWalletCooldownFunction, cancellationToken);
        }

        public Task<string> RewindWalletCooldownRequestAsync(uint rewindTime)
        {
            var rewindWalletCooldownFunction = new RewindWalletCooldownFunction();
                rewindWalletCooldownFunction.RewindTime = rewindTime;
            
             return ContractHandler.SendRequestAsync(rewindWalletCooldownFunction);
        }

        public Task<TransactionReceipt> RewindWalletCooldownRequestAndWaitForReceiptAsync(uint rewindTime, CancellationTokenSource cancellationToken = null)
        {
            var rewindWalletCooldownFunction = new RewindWalletCooldownFunction();
                rewindWalletCooldownFunction.RewindTime = rewindTime;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(rewindWalletCooldownFunction, cancellationToken);
        }

        public Task<string> SetFullValidationFlagRequestAsync(SetFullValidationFlagFunction setFullValidationFlagFunction)
        {
             return ContractHandler.SendRequestAsync(setFullValidationFlagFunction);
        }

        public Task<TransactionReceipt> SetFullValidationFlagRequestAndWaitForReceiptAsync(SetFullValidationFlagFunction setFullValidationFlagFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFullValidationFlagFunction, cancellationToken);
        }

        public Task<string> SetFullValidationFlagRequestAsync(bool flag)
        {
            var setFullValidationFlagFunction = new SetFullValidationFlagFunction();
                setFullValidationFlagFunction.Flag = flag;
            
             return ContractHandler.SendRequestAsync(setFullValidationFlagFunction);
        }

        public Task<TransactionReceipt> SetFullValidationFlagRequestAndWaitForReceiptAsync(bool flag, CancellationTokenSource cancellationToken = null)
        {
            var setFullValidationFlagFunction = new SetFullValidationFlagFunction();
                setFullValidationFlagFunction.Flag = flag;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setFullValidationFlagFunction, cancellationToken);
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

        public Task<string> StartBattleRequestAsync(StartBattleFunction startBattleFunction)
        {
             return ContractHandler.SendRequestAsync(startBattleFunction);
        }

        public Task<TransactionReceipt> StartBattleRequestAndWaitForReceiptAsync(StartBattleFunction startBattleFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(startBattleFunction, cancellationToken);
        }

        public Task<string> StartBattleRequestAsync(StartBattleParams @params)
        {
            var startBattleFunction = new StartBattleFunction();
                startBattleFunction.Params = @params;
            
             return ContractHandler.SendRequestAsync(startBattleFunction);
        }

        public Task<TransactionReceipt> StartBattleRequestAndWaitForReceiptAsync(StartBattleParams @params, CancellationTokenSource cancellationToken = null)
        {
            var startBattleFunction = new StartBattleFunction();
                startBattleFunction.Params = @params;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(startBattleFunction, cancellationToken);
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

        public Task<bool> UseFullValidationFlagQueryAsync(UseFullValidationFlagFunction useFullValidationFlagFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<UseFullValidationFlagFunction, bool>(useFullValidationFlagFunction, blockParameter);
        }

        
        public Task<bool> UseFullValidationFlagQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<UseFullValidationFlagFunction, bool>(null, blockParameter);
        }
    }
}

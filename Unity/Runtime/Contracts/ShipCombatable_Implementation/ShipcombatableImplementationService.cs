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
using PirateNationContracts.ShipCombatable_Implementation.ContractDefinition;

namespace PirateNationContracts.ShipCombatable_Implementation
{
    public partial class ShipcombatableImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, ShipcombatableImplementationDeployment shipcombatableImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<ShipcombatableImplementationDeployment>().SendRequestAndWaitForReceiptAsync(shipcombatableImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, ShipcombatableImplementationDeployment shipcombatableImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<ShipcombatableImplementationDeployment>().SendRequestAsync(shipcombatableImplementationDeployment);
        }

        public static async Task<ShipcombatableImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, ShipcombatableImplementationDeployment shipcombatableImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, shipcombatableImplementationDeployment, cancellationTokenSource);
            return new ShipcombatableImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public ShipcombatableImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<bool> CanAttackQueryAsync(CanAttackFunction canAttackFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CanAttackFunction, bool>(canAttackFunction, blockParameter);
        }

        
        public Task<bool> CanAttackQueryAsync(string caller, BigInteger entityId, List<BigInteger> overloads, BlockParameter blockParameter = null)
        {
            var canAttackFunction = new CanAttackFunction();
                canAttackFunction.Caller = caller;
                canAttackFunction.EntityId = entityId;
                canAttackFunction.Overloads = overloads;
            
            return ContractHandler.QueryAsync<CanAttackFunction, bool>(canAttackFunction, blockParameter);
        }

        public Task<bool> CanBeAttackedQueryAsync(CanBeAttackedFunction canBeAttackedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CanBeAttackedFunction, bool>(canBeAttackedFunction, blockParameter);
        }

        
        public Task<bool> CanBeAttackedQueryAsync(BigInteger returnValue1, List<BigInteger> returnValue2, BlockParameter blockParameter = null)
        {
            var canBeAttackedFunction = new CanBeAttackedFunction();
                canBeAttackedFunction.ReturnValue1 = returnValue1;
                canBeAttackedFunction.ReturnValue2 = returnValue2;
            
            return ContractHandler.QueryAsync<CanBeAttackedFunction, bool>(canBeAttackedFunction, blockParameter);
        }

        public Task<string> DecreaseHealthRequestAsync(DecreaseHealthFunction decreaseHealthFunction)
        {
             return ContractHandler.SendRequestAsync(decreaseHealthFunction);
        }

        public Task<TransactionReceipt> DecreaseHealthRequestAndWaitForReceiptAsync(DecreaseHealthFunction decreaseHealthFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(decreaseHealthFunction, cancellationToken);
        }

        public Task<string> DecreaseHealthRequestAsync(BigInteger entityId, BigInteger amount)
        {
            var decreaseHealthFunction = new DecreaseHealthFunction();
                decreaseHealthFunction.EntityId = entityId;
                decreaseHealthFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(decreaseHealthFunction);
        }

        public Task<TransactionReceipt> DecreaseHealthRequestAndWaitForReceiptAsync(BigInteger entityId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var decreaseHealthFunction = new DecreaseHealthFunction();
                decreaseHealthFunction.EntityId = entityId;
                decreaseHealthFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(decreaseHealthFunction, cancellationToken);
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

        public Task<GetCombatStatsOutputDTO> GetCombatStatsQueryAsync(GetCombatStatsFunction getCombatStatsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetCombatStatsFunction, GetCombatStatsOutputDTO>(getCombatStatsFunction, blockParameter);
        }

        public Task<GetCombatStatsOutputDTO> GetCombatStatsQueryAsync(BigInteger entityId, BigInteger returnValue2, BigInteger moveId, List<BigInteger> overloads, BlockParameter blockParameter = null)
        {
            var getCombatStatsFunction = new GetCombatStatsFunction();
                getCombatStatsFunction.EntityId = entityId;
                getCombatStatsFunction.ReturnValue2 = returnValue2;
                getCombatStatsFunction.MoveId = moveId;
                getCombatStatsFunction.Overloads = overloads;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetCombatStatsFunction, GetCombatStatsOutputDTO>(getCombatStatsFunction, blockParameter);
        }

        public Task<BigInteger> GetCurrentHealthQueryAsync(GetCurrentHealthFunction getCurrentHealthFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetCurrentHealthFunction, BigInteger>(getCurrentHealthFunction, blockParameter);
        }

        
        public Task<BigInteger> GetCurrentHealthQueryAsync(BigInteger entityId, string traitsProvider, BlockParameter blockParameter = null)
        {
            var getCurrentHealthFunction = new GetCurrentHealthFunction();
                getCurrentHealthFunction.EntityId = entityId;
                getCurrentHealthFunction.TraitsProvider = traitsProvider;
            
            return ContractHandler.QueryAsync<GetCurrentHealthFunction, BigInteger>(getCurrentHealthFunction, blockParameter);
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

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
using PirateNationContracts.HoldingSystem_Implementation.ContractDefinition;

namespace PirateNationContracts.HoldingSystem_Implementation
{
    public partial class HoldingsystemImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, HoldingsystemImplementationDeployment holdingsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<HoldingsystemImplementationDeployment>().SendRequestAndWaitForReceiptAsync(holdingsystemImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, HoldingsystemImplementationDeployment holdingsystemImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<HoldingsystemImplementationDeployment>().SendRequestAsync(holdingsystemImplementationDeployment);
        }

        public static async Task<HoldingsystemImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, HoldingsystemImplementationDeployment holdingsystemImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, holdingsystemImplementationDeployment, cancellationTokenSource);
            return new HoldingsystemImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public HoldingsystemImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> BatchClaimMilestoneRequestAsync(BatchClaimMilestoneFunction batchClaimMilestoneFunction)
        {
             return ContractHandler.SendRequestAsync(batchClaimMilestoneFunction);
        }

        public Task<TransactionReceipt> BatchClaimMilestoneRequestAndWaitForReceiptAsync(BatchClaimMilestoneFunction batchClaimMilestoneFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchClaimMilestoneFunction, cancellationToken);
        }

        public Task<string> BatchClaimMilestoneRequestAsync(string tokenContract, List<BigInteger> tokenIds, List<ushort> milestoneIndicies)
        {
            var batchClaimMilestoneFunction = new BatchClaimMilestoneFunction();
                batchClaimMilestoneFunction.TokenContract = tokenContract;
                batchClaimMilestoneFunction.TokenIds = tokenIds;
                batchClaimMilestoneFunction.MilestoneIndicies = milestoneIndicies;
            
             return ContractHandler.SendRequestAsync(batchClaimMilestoneFunction);
        }

        public Task<TransactionReceipt> BatchClaimMilestoneRequestAndWaitForReceiptAsync(string tokenContract, List<BigInteger> tokenIds, List<ushort> milestoneIndicies, CancellationTokenSource cancellationToken = null)
        {
            var batchClaimMilestoneFunction = new BatchClaimMilestoneFunction();
                batchClaimMilestoneFunction.TokenContract = tokenContract;
                batchClaimMilestoneFunction.TokenIds = tokenIds;
                batchClaimMilestoneFunction.MilestoneIndicies = milestoneIndicies;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchClaimMilestoneFunction, cancellationToken);
        }

        public Task<string> ClaimMilestoneRequestAsync(ClaimMilestoneFunction claimMilestoneFunction)
        {
             return ContractHandler.SendRequestAsync(claimMilestoneFunction);
        }

        public Task<TransactionReceipt> ClaimMilestoneRequestAndWaitForReceiptAsync(ClaimMilestoneFunction claimMilestoneFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(claimMilestoneFunction, cancellationToken);
        }

        public Task<string> ClaimMilestoneRequestAsync(string tokenContract, BigInteger tokenId, ushort milestoneIndex)
        {
            var claimMilestoneFunction = new ClaimMilestoneFunction();
                claimMilestoneFunction.TokenContract = tokenContract;
                claimMilestoneFunction.TokenId = tokenId;
                claimMilestoneFunction.MilestoneIndex = milestoneIndex;
            
             return ContractHandler.SendRequestAsync(claimMilestoneFunction);
        }

        public Task<TransactionReceipt> ClaimMilestoneRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, ushort milestoneIndex, CancellationTokenSource cancellationToken = null)
        {
            var claimMilestoneFunction = new ClaimMilestoneFunction();
                claimMilestoneFunction.TokenContract = tokenContract;
                claimMilestoneFunction.TokenId = tokenId;
                claimMilestoneFunction.MilestoneIndex = milestoneIndex;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(claimMilestoneFunction, cancellationToken);
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

        public Task<GetTokenContractMilestonesOutputDTO> GetTokenContractMilestonesQueryAsync(GetTokenContractMilestonesFunction getTokenContractMilestonesFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetTokenContractMilestonesFunction, GetTokenContractMilestonesOutputDTO>(getTokenContractMilestonesFunction, blockParameter);
        }

        public Task<GetTokenContractMilestonesOutputDTO> GetTokenContractMilestonesQueryAsync(string tokenContract, BlockParameter blockParameter = null)
        {
            var getTokenContractMilestonesFunction = new GetTokenContractMilestonesFunction();
                getTokenContractMilestonesFunction.TokenContract = tokenContract;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetTokenContractMilestonesFunction, GetTokenContractMilestonesOutputDTO>(getTokenContractMilestonesFunction, blockParameter);
        }

        public Task<GetTokenStatusOutputDTO> GetTokenStatusQueryAsync(GetTokenStatusFunction getTokenStatusFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetTokenStatusFunction, GetTokenStatusOutputDTO>(getTokenStatusFunction, blockParameter);
        }

        public Task<GetTokenStatusOutputDTO> GetTokenStatusQueryAsync(string account, string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var getTokenStatusFunction = new GetTokenStatusFunction();
                getTokenStatusFunction.Account = account;
                getTokenStatusFunction.TokenContract = tokenContract;
                getTokenStatusFunction.TokenId = tokenId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetTokenStatusFunction, GetTokenStatusOutputDTO>(getTokenStatusFunction, blockParameter);
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

        public Task<BigInteger> MilestonesClaimedQueryAsync(MilestonesClaimedFunction milestonesClaimedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MilestonesClaimedFunction, BigInteger>(milestonesClaimedFunction, blockParameter);
        }

        
        public Task<BigInteger> MilestonesClaimedQueryAsync(string tokenContract, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var milestonesClaimedFunction = new MilestonesClaimedFunction();
                milestonesClaimedFunction.TokenContract = tokenContract;
                milestonesClaimedFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<MilestonesClaimedFunction, BigInteger>(milestonesClaimedFunction, blockParameter);
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

        public Task<string> SetMilestonesRequestAsync(SetMilestonesFunction setMilestonesFunction)
        {
             return ContractHandler.SendRequestAsync(setMilestonesFunction);
        }

        public Task<TransactionReceipt> SetMilestonesRequestAndWaitForReceiptAsync(SetMilestonesFunction setMilestonesFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMilestonesFunction, cancellationToken);
        }

        public Task<string> SetMilestonesRequestAsync(string tokenContract, List<Milestone> milestones)
        {
            var setMilestonesFunction = new SetMilestonesFunction();
                setMilestonesFunction.TokenContract = tokenContract;
                setMilestonesFunction.Milestones = milestones;
            
             return ContractHandler.SendRequestAsync(setMilestonesFunction);
        }

        public Task<TransactionReceipt> SetMilestonesRequestAndWaitForReceiptAsync(string tokenContract, List<Milestone> milestones, CancellationTokenSource cancellationToken = null)
        {
            var setMilestonesFunction = new SetMilestonesFunction();
                setMilestonesFunction.TokenContract = tokenContract;
                setMilestonesFunction.Milestones = milestones;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMilestonesFunction, cancellationToken);
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

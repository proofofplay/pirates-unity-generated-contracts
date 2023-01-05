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
using PirateNationContracts.PirateGameV1_Implementation.ContractDefinition;

namespace PirateNationContracts.PirateGameV1_Implementation
{
    public partial class Pirategamev1ImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, Pirategamev1ImplementationDeployment pirategamev1ImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<Pirategamev1ImplementationDeployment>().SendRequestAndWaitForReceiptAsync(pirategamev1ImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, Pirategamev1ImplementationDeployment pirategamev1ImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<Pirategamev1ImplementationDeployment>().SendRequestAsync(pirategamev1ImplementationDeployment);
        }

        public static async Task<Pirategamev1ImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, Pirategamev1ImplementationDeployment pirategamev1ImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, pirategamev1ImplementationDeployment, cancellationTokenSource);
            return new Pirategamev1ImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public Pirategamev1ImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
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

        public Task<GetCaptainNFTOutputDTO> GetCaptainNFTQueryAsync(GetCaptainNFTFunction getCaptainNFTFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetCaptainNFTFunction, GetCaptainNFTOutputDTO>(getCaptainNFTFunction, blockParameter);
        }

        public Task<GetCaptainNFTOutputDTO> GetCaptainNFTQueryAsync(string account, BlockParameter blockParameter = null)
        {
            var getCaptainNFTFunction = new GetCaptainNFTFunction();
                getCaptainNFTFunction.Account = account;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetCaptainNFTFunction, GetCaptainNFTOutputDTO>(getCaptainNFTFunction, blockParameter);
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

        public Task<BigInteger> GetLastSetCaptainTimeQueryAsync(GetLastSetCaptainTimeFunction getLastSetCaptainTimeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetLastSetCaptainTimeFunction, BigInteger>(getLastSetCaptainTimeFunction, blockParameter);
        }

        
        public Task<BigInteger> GetLastSetCaptainTimeQueryAsync(string account, BlockParameter blockParameter = null)
        {
            var getLastSetCaptainTimeFunction = new GetLastSetCaptainTimeFunction();
                getLastSetCaptainTimeFunction.Account = account;
            
            return ContractHandler.QueryAsync<GetLastSetCaptainTimeFunction, BigInteger>(getLastSetCaptainTimeFunction, blockParameter);
        }

        public Task<string> GrantXPRequestAsync(GrantXPFunction grantXPFunction)
        {
             return ContractHandler.SendRequestAsync(grantXPFunction);
        }

        public Task<TransactionReceipt> GrantXPRequestAndWaitForReceiptAsync(GrantXPFunction grantXPFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantXPFunction, cancellationToken);
        }

        public Task<string> GrantXPRequestAsync(string tokenContract, BigInteger tokenId, BigInteger amount)
        {
            var grantXPFunction = new GrantXPFunction();
                grantXPFunction.TokenContract = tokenContract;
                grantXPFunction.TokenId = tokenId;
                grantXPFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(grantXPFunction);
        }

        public Task<TransactionReceipt> GrantXPRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var grantXPFunction = new GrantXPFunction();
                grantXPFunction.TokenContract = tokenContract;
                grantXPFunction.TokenId = tokenId;
                grantXPFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantXPFunction, cancellationToken);
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

        public Task<string> SetCaptainNFTRequestAsync(SetCaptainNFTFunction setCaptainNFTFunction)
        {
             return ContractHandler.SendRequestAsync(setCaptainNFTFunction);
        }

        public Task<TransactionReceipt> SetCaptainNFTRequestAndWaitForReceiptAsync(SetCaptainNFTFunction setCaptainNFTFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setCaptainNFTFunction, cancellationToken);
        }

        public Task<string> SetCaptainNFTRequestAsync(string tokenContract, BigInteger tokenId)
        {
            var setCaptainNFTFunction = new SetCaptainNFTFunction();
                setCaptainNFTFunction.TokenContract = tokenContract;
                setCaptainNFTFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(setCaptainNFTFunction);
        }

        public Task<TransactionReceipt> SetCaptainNFTRequestAndWaitForReceiptAsync(string tokenContract, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var setCaptainNFTFunction = new SetCaptainNFTFunction();
                setCaptainNFTFunction.TokenContract = tokenContract;
                setCaptainNFTFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setCaptainNFTFunction, cancellationToken);
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

        public Task<string> SetPausedRequestAsync(bool paused)
        {
            var setPausedFunction = new SetPausedFunction();
                setPausedFunction.Paused = paused;
            
             return ContractHandler.SendRequestAsync(setPausedFunction);
        }

        public Task<TransactionReceipt> SetPausedRequestAndWaitForReceiptAsync(bool paused, CancellationTokenSource cancellationToken = null)
        {
            var setPausedFunction = new SetPausedFunction();
                setPausedFunction.Paused = paused;
            
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

        public Task<string> UpgradePirateLevelRequestAsync(UpgradePirateLevelFunction upgradePirateLevelFunction)
        {
             return ContractHandler.SendRequestAsync(upgradePirateLevelFunction);
        }

        public Task<TransactionReceipt> UpgradePirateLevelRequestAndWaitForReceiptAsync(UpgradePirateLevelFunction upgradePirateLevelFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradePirateLevelFunction, cancellationToken);
        }

        public Task<string> UpgradePirateLevelRequestAsync(string nftContract, BigInteger nftTokenId, uint desiredLevel)
        {
            var upgradePirateLevelFunction = new UpgradePirateLevelFunction();
                upgradePirateLevelFunction.NftContract = nftContract;
                upgradePirateLevelFunction.NftTokenId = nftTokenId;
                upgradePirateLevelFunction.DesiredLevel = desiredLevel;
            
             return ContractHandler.SendRequestAsync(upgradePirateLevelFunction);
        }

        public Task<TransactionReceipt> UpgradePirateLevelRequestAndWaitForReceiptAsync(string nftContract, BigInteger nftTokenId, uint desiredLevel, CancellationTokenSource cancellationToken = null)
        {
            var upgradePirateLevelFunction = new UpgradePirateLevelFunction();
                upgradePirateLevelFunction.NftContract = nftContract;
                upgradePirateLevelFunction.NftTokenId = nftTokenId;
                upgradePirateLevelFunction.DesiredLevel = desiredLevel;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradePirateLevelFunction, cancellationToken);
        }
    }
}

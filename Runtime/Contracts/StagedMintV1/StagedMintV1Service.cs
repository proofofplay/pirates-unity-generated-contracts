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
using SimpleStorage.StagedMintV1.ContractDefinition;

namespace SimpleStorage.StagedMintV1
{
    public partial class StagedMintV1Service
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, StagedMintV1Deployment stagedMintV1Deployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<StagedMintV1Deployment>().SendRequestAndWaitForReceiptAsync(stagedMintV1Deployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, StagedMintV1Deployment stagedMintV1Deployment)
        {
            return web3.Eth.GetContractDeploymentHandler<StagedMintV1Deployment>().SendRequestAsync(stagedMintV1Deployment);
        }

        public static async Task<StagedMintV1Service> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, StagedMintV1Deployment stagedMintV1Deployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, stagedMintV1Deployment, cancellationTokenSource);
            return new StagedMintV1Service(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public StagedMintV1Service(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<BigInteger> AVAILABLE_SUPPLYQueryAsync(AVAILABLE_SUPPLYFunction aVAILABLE_SUPPLYFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AVAILABLE_SUPPLYFunction, BigInteger>(aVAILABLE_SUPPLYFunction, blockParameter);
        }

        
        public Task<BigInteger> AVAILABLE_SUPPLYQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AVAILABLE_SUPPLYFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> MAX_PER_ADDRESSQueryAsync(MAX_PER_ADDRESSFunction mAX_PER_ADDRESSFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_PER_ADDRESSFunction, BigInteger>(mAX_PER_ADDRESSFunction, blockParameter);
        }

        
        public Task<BigInteger> MAX_PER_ADDRESSQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MAX_PER_ADDRESSFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> MINT_COSTQueryAsync(MINT_COSTFunction mINT_COSTFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MINT_COSTFunction, BigInteger>(mINT_COSTFunction, blockParameter);
        }

        
        public Task<BigInteger> MINT_COSTQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MINT_COSTFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> NFT_CONTRACTQueryAsync(NFT_CONTRACTFunction nFT_CONTRACTFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NFT_CONTRACTFunction, string>(nFT_CONTRACTFunction, blockParameter);
        }

        
        public Task<string> NFT_CONTRACTQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NFT_CONTRACTFunction, string>(null, blockParameter);
        }

        public Task<BigInteger> PREMINT_COSTQueryAsync(PREMINT_COSTFunction pREMINT_COSTFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PREMINT_COSTFunction, BigInteger>(pREMINT_COSTFunction, blockParameter);
        }

        
        public Task<BigInteger> PREMINT_COSTQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PREMINT_COSTFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> CurrentTokenIdQueryAsync(CurrentTokenIdFunction currentTokenIdFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CurrentTokenIdFunction, BigInteger>(currentTokenIdFunction, blockParameter);
        }

        
        public Task<BigInteger> CurrentTokenIdQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<CurrentTokenIdFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> EnterPremintRequestAsync(EnterPremintFunction enterPremintFunction)
        {
             return ContractHandler.SendRequestAsync(enterPremintFunction);
        }

        public Task<TransactionReceipt> EnterPremintRequestAndWaitForReceiptAsync(EnterPremintFunction enterPremintFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(enterPremintFunction, cancellationToken);
        }

        public Task<string> EnterPremintRequestAsync(BigInteger amount)
        {
            var enterPremintFunction = new EnterPremintFunction();
                enterPremintFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(enterPremintFunction);
        }

        public Task<TransactionReceipt> EnterPremintRequestAndWaitForReceiptAsync(BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var enterPremintFunction = new EnterPremintFunction();
                enterPremintFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(enterPremintFunction, cancellationToken);
        }

        public Task<string> MintRequestAsync(MintFunction mintFunction)
        {
             return ContractHandler.SendRequestAsync(mintFunction);
        }

        public Task<TransactionReceipt> MintRequestAndWaitForReceiptAsync(MintFunction mintFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintFunction, cancellationToken);
        }

        public Task<string> MintRequestAsync(BigInteger amount)
        {
            var mintFunction = new MintFunction();
                mintFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(mintFunction);
        }

        public Task<TransactionReceipt> MintRequestAndWaitForReceiptAsync(BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var mintFunction = new MintFunction();
                mintFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(mintFunction, cancellationToken);
        }

        public Task<byte> MintStageQueryAsync(MintStageFunction mintStageFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MintStageFunction, byte>(mintStageFunction, blockParameter);
        }

        
        public Task<byte> MintStageQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<MintStageFunction, byte>(null, blockParameter);
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

        public Task<BigInteger> PremintCountsQueryAsync(PremintCountsFunction premintCountsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PremintCountsFunction, BigInteger>(premintCountsFunction, blockParameter);
        }

        
        public Task<BigInteger> PremintCountsQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var premintCountsFunction = new PremintCountsFunction();
                premintCountsFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PremintCountsFunction, BigInteger>(premintCountsFunction, blockParameter);
        }

        public Task<BigInteger> PremintListQueryAsync(PremintListFunction premintListFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PremintListFunction, BigInteger>(premintListFunction, blockParameter);
        }

        
        public Task<BigInteger> PremintListQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var premintListFunction = new PremintListFunction();
                premintListFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<PremintListFunction, BigInteger>(premintListFunction, blockParameter);
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

        public Task<string> SetMintStageRequestAsync(SetMintStageFunction setMintStageFunction)
        {
             return ContractHandler.SendRequestAsync(setMintStageFunction);
        }

        public Task<TransactionReceipt> SetMintStageRequestAndWaitForReceiptAsync(SetMintStageFunction setMintStageFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMintStageFunction, cancellationToken);
        }

        public Task<string> SetMintStageRequestAsync(byte stage)
        {
            var setMintStageFunction = new SetMintStageFunction();
                setMintStageFunction.Stage = stage;
            
             return ContractHandler.SendRequestAsync(setMintStageFunction);
        }

        public Task<TransactionReceipt> SetMintStageRequestAndWaitForReceiptAsync(byte stage, CancellationTokenSource cancellationToken = null)
        {
            var setMintStageFunction = new SetMintStageFunction();
                setMintStageFunction.Stage = stage;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMintStageFunction, cancellationToken);
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

        public Task<string> UpdatePremintListRequestAsync(UpdatePremintListFunction updatePremintListFunction)
        {
             return ContractHandler.SendRequestAsync(updatePremintListFunction);
        }

        public Task<TransactionReceipt> UpdatePremintListRequestAndWaitForReceiptAsync(UpdatePremintListFunction updatePremintListFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updatePremintListFunction, cancellationToken);
        }

        public Task<string> UpdatePremintListRequestAsync(List<string> addresses, BigInteger amount)
        {
            var updatePremintListFunction = new UpdatePremintListFunction();
                updatePremintListFunction.Addresses = addresses;
                updatePremintListFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(updatePremintListFunction);
        }

        public Task<TransactionReceipt> UpdatePremintListRequestAndWaitForReceiptAsync(List<string> addresses, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var updatePremintListFunction = new UpdatePremintListFunction();
                updatePremintListFunction.Addresses = addresses;
                updatePremintListFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(updatePremintListFunction, cancellationToken);
        }

        public Task<string> WithdrawProceedsRequestAsync(WithdrawProceedsFunction withdrawProceedsFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawProceedsFunction);
        }

        public Task<string> WithdrawProceedsRequestAsync()
        {
             return ContractHandler.SendRequestAsync<WithdrawProceedsFunction>();
        }

        public Task<TransactionReceipt> WithdrawProceedsRequestAndWaitForReceiptAsync(WithdrawProceedsFunction withdrawProceedsFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawProceedsFunction, cancellationToken);
        }

        public Task<TransactionReceipt> WithdrawProceedsRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<WithdrawProceedsFunction>(null, cancellationToken);
        }
    }
}

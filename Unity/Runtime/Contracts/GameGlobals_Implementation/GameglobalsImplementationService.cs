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
using PirateNationContracts.GameGlobals_Implementation.ContractDefinition;

namespace PirateNationContracts.GameGlobals_Implementation
{
    public partial class GameglobalsImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, GameglobalsImplementationDeployment gameglobalsImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<GameglobalsImplementationDeployment>().SendRequestAndWaitForReceiptAsync(gameglobalsImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, GameglobalsImplementationDeployment gameglobalsImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<GameglobalsImplementationDeployment>().SendRequestAsync(gameglobalsImplementationDeployment);
        }

        public static async Task<GameglobalsImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, GameglobalsImplementationDeployment gameglobalsImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, gameglobalsImplementationDeployment, cancellationTokenSource);
            return new GameglobalsImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public GameglobalsImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<string> BatchSetInt256RequestAsync(BatchSetInt256Function batchSetInt256Function)
        {
             return ContractHandler.SendRequestAsync(batchSetInt256Function);
        }

        public Task<TransactionReceipt> BatchSetInt256RequestAndWaitForReceiptAsync(BatchSetInt256Function batchSetInt256Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetInt256Function, cancellationToken);
        }

        public Task<string> BatchSetInt256RequestAsync(List<BigInteger> globalIds, List<BigInteger> values)
        {
            var batchSetInt256Function = new BatchSetInt256Function();
                batchSetInt256Function.GlobalIds = globalIds;
                batchSetInt256Function.Values = values;
            
             return ContractHandler.SendRequestAsync(batchSetInt256Function);
        }

        public Task<TransactionReceipt> BatchSetInt256RequestAndWaitForReceiptAsync(List<BigInteger> globalIds, List<BigInteger> values, CancellationTokenSource cancellationToken = null)
        {
            var batchSetInt256Function = new BatchSetInt256Function();
                batchSetInt256Function.GlobalIds = globalIds;
                batchSetInt256Function.Values = values;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetInt256Function, cancellationToken);
        }

        public Task<string> BatchSetStringRequestAsync(BatchSetStringFunction batchSetStringFunction)
        {
             return ContractHandler.SendRequestAsync(batchSetStringFunction);
        }

        public Task<TransactionReceipt> BatchSetStringRequestAndWaitForReceiptAsync(BatchSetStringFunction batchSetStringFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetStringFunction, cancellationToken);
        }

        public Task<string> BatchSetStringRequestAsync(List<BigInteger> globalIds, List<string> values)
        {
            var batchSetStringFunction = new BatchSetStringFunction();
                batchSetStringFunction.GlobalIds = globalIds;
                batchSetStringFunction.Values = values;
            
             return ContractHandler.SendRequestAsync(batchSetStringFunction);
        }

        public Task<TransactionReceipt> BatchSetStringRequestAndWaitForReceiptAsync(List<BigInteger> globalIds, List<string> values, CancellationTokenSource cancellationToken = null)
        {
            var batchSetStringFunction = new BatchSetStringFunction();
                batchSetStringFunction.GlobalIds = globalIds;
                batchSetStringFunction.Values = values;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetStringFunction, cancellationToken);
        }

        public Task<string> BatchSetUint256RequestAsync(BatchSetUint256Function batchSetUint256Function)
        {
             return ContractHandler.SendRequestAsync(batchSetUint256Function);
        }

        public Task<TransactionReceipt> BatchSetUint256RequestAndWaitForReceiptAsync(BatchSetUint256Function batchSetUint256Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetUint256Function, cancellationToken);
        }

        public Task<string> BatchSetUint256RequestAsync(List<BigInteger> globalIds, List<BigInteger> values)
        {
            var batchSetUint256Function = new BatchSetUint256Function();
                batchSetUint256Function.GlobalIds = globalIds;
                batchSetUint256Function.Values = values;
            
             return ContractHandler.SendRequestAsync(batchSetUint256Function);
        }

        public Task<TransactionReceipt> BatchSetUint256RequestAndWaitForReceiptAsync(List<BigInteger> globalIds, List<BigInteger> values, CancellationTokenSource cancellationToken = null)
        {
            var batchSetUint256Function = new BatchSetUint256Function();
                batchSetUint256Function.GlobalIds = globalIds;
                batchSetUint256Function.Values = values;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(batchSetUint256Function, cancellationToken);
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

        public Task<bool> GetBoolQueryAsync(GetBoolFunction getBoolFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetBoolFunction, bool>(getBoolFunction, blockParameter);
        }

        
        public Task<bool> GetBoolQueryAsync(BigInteger globalId, BlockParameter blockParameter = null)
        {
            var getBoolFunction = new GetBoolFunction();
                getBoolFunction.GlobalId = globalId;
            
            return ContractHandler.QueryAsync<GetBoolFunction, bool>(getBoolFunction, blockParameter);
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

        public Task<BigInteger> GetInt256QueryAsync(GetInt256Function getInt256Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetInt256Function, BigInteger>(getInt256Function, blockParameter);
        }

        
        public Task<BigInteger> GetInt256QueryAsync(BigInteger globalId, BlockParameter blockParameter = null)
        {
            var getInt256Function = new GetInt256Function();
                getInt256Function.GlobalId = globalId;
            
            return ContractHandler.QueryAsync<GetInt256Function, BigInteger>(getInt256Function, blockParameter);
        }

        public Task<List<BigInteger>> GetInt256ArrayQueryAsync(GetInt256ArrayFunction getInt256ArrayFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetInt256ArrayFunction, List<BigInteger>>(getInt256ArrayFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> GetInt256ArrayQueryAsync(BigInteger globalId, BlockParameter blockParameter = null)
        {
            var getInt256ArrayFunction = new GetInt256ArrayFunction();
                getInt256ArrayFunction.GlobalId = globalId;
            
            return ContractHandler.QueryAsync<GetInt256ArrayFunction, List<BigInteger>>(getInt256ArrayFunction, blockParameter);
        }

        public Task<GetMetadataOutputDTO> GetMetadataQueryAsync(GetMetadataFunction getMetadataFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetMetadataFunction, GetMetadataOutputDTO>(getMetadataFunction, blockParameter);
        }

        public Task<GetMetadataOutputDTO> GetMetadataQueryAsync(BigInteger globalId, BlockParameter blockParameter = null)
        {
            var getMetadataFunction = new GetMetadataFunction();
                getMetadataFunction.GlobalId = globalId;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetMetadataFunction, GetMetadataOutputDTO>(getMetadataFunction, blockParameter);
        }

        public Task<string> GetStringQueryAsync(GetStringFunction getStringFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetStringFunction, string>(getStringFunction, blockParameter);
        }

        
        public Task<string> GetStringQueryAsync(BigInteger globalId, BlockParameter blockParameter = null)
        {
            var getStringFunction = new GetStringFunction();
                getStringFunction.GlobalId = globalId;
            
            return ContractHandler.QueryAsync<GetStringFunction, string>(getStringFunction, blockParameter);
        }

        public Task<List<string>> GetStringArrayQueryAsync(GetStringArrayFunction getStringArrayFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetStringArrayFunction, List<string>>(getStringArrayFunction, blockParameter);
        }

        
        public Task<List<string>> GetStringArrayQueryAsync(BigInteger globalId, BlockParameter blockParameter = null)
        {
            var getStringArrayFunction = new GetStringArrayFunction();
                getStringArrayFunction.GlobalId = globalId;
            
            return ContractHandler.QueryAsync<GetStringArrayFunction, List<string>>(getStringArrayFunction, blockParameter);
        }

        public Task<BigInteger> GetUint256QueryAsync(GetUint256Function getUint256Function, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetUint256Function, BigInteger>(getUint256Function, blockParameter);
        }

        
        public Task<BigInteger> GetUint256QueryAsync(BigInteger globalId, BlockParameter blockParameter = null)
        {
            var getUint256Function = new GetUint256Function();
                getUint256Function.GlobalId = globalId;
            
            return ContractHandler.QueryAsync<GetUint256Function, BigInteger>(getUint256Function, blockParameter);
        }

        public Task<List<BigInteger>> GetUint256ArrayQueryAsync(GetUint256ArrayFunction getUint256ArrayFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetUint256ArrayFunction, List<BigInteger>>(getUint256ArrayFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> GetUint256ArrayQueryAsync(BigInteger globalId, BlockParameter blockParameter = null)
        {
            var getUint256ArrayFunction = new GetUint256ArrayFunction();
                getUint256ArrayFunction.GlobalId = globalId;
            
            return ContractHandler.QueryAsync<GetUint256ArrayFunction, List<BigInteger>>(getUint256ArrayFunction, blockParameter);
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

        public Task<string> SetBoolRequestAsync(SetBoolFunction setBoolFunction)
        {
             return ContractHandler.SendRequestAsync(setBoolFunction);
        }

        public Task<TransactionReceipt> SetBoolRequestAndWaitForReceiptAsync(SetBoolFunction setBoolFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBoolFunction, cancellationToken);
        }

        public Task<string> SetBoolRequestAsync(BigInteger globalId, bool value)
        {
            var setBoolFunction = new SetBoolFunction();
                setBoolFunction.GlobalId = globalId;
                setBoolFunction.Value = value;
            
             return ContractHandler.SendRequestAsync(setBoolFunction);
        }

        public Task<TransactionReceipt> SetBoolRequestAndWaitForReceiptAsync(BigInteger globalId, bool value, CancellationTokenSource cancellationToken = null)
        {
            var setBoolFunction = new SetBoolFunction();
                setBoolFunction.GlobalId = globalId;
                setBoolFunction.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setBoolFunction, cancellationToken);
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

        public Task<string> SetInt256RequestAsync(SetInt256Function setInt256Function)
        {
             return ContractHandler.SendRequestAsync(setInt256Function);
        }

        public Task<TransactionReceipt> SetInt256RequestAndWaitForReceiptAsync(SetInt256Function setInt256Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setInt256Function, cancellationToken);
        }

        public Task<string> SetInt256RequestAsync(BigInteger globalId, BigInteger value)
        {
            var setInt256Function = new SetInt256Function();
                setInt256Function.GlobalId = globalId;
                setInt256Function.Value = value;
            
             return ContractHandler.SendRequestAsync(setInt256Function);
        }

        public Task<TransactionReceipt> SetInt256RequestAndWaitForReceiptAsync(BigInteger globalId, BigInteger value, CancellationTokenSource cancellationToken = null)
        {
            var setInt256Function = new SetInt256Function();
                setInt256Function.GlobalId = globalId;
                setInt256Function.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setInt256Function, cancellationToken);
        }

        public Task<string> SetInt256ArrayRequestAsync(SetInt256ArrayFunction setInt256ArrayFunction)
        {
             return ContractHandler.SendRequestAsync(setInt256ArrayFunction);
        }

        public Task<TransactionReceipt> SetInt256ArrayRequestAndWaitForReceiptAsync(SetInt256ArrayFunction setInt256ArrayFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setInt256ArrayFunction, cancellationToken);
        }

        public Task<string> SetInt256ArrayRequestAsync(BigInteger globalId, List<BigInteger> values)
        {
            var setInt256ArrayFunction = new SetInt256ArrayFunction();
                setInt256ArrayFunction.GlobalId = globalId;
                setInt256ArrayFunction.Values = values;
            
             return ContractHandler.SendRequestAsync(setInt256ArrayFunction);
        }

        public Task<TransactionReceipt> SetInt256ArrayRequestAndWaitForReceiptAsync(BigInteger globalId, List<BigInteger> values, CancellationTokenSource cancellationToken = null)
        {
            var setInt256ArrayFunction = new SetInt256ArrayFunction();
                setInt256ArrayFunction.GlobalId = globalId;
                setInt256ArrayFunction.Values = values;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setInt256ArrayFunction, cancellationToken);
        }

        public Task<string> SetMetadataRequestAsync(SetMetadataFunction setMetadataFunction)
        {
             return ContractHandler.SendRequestAsync(setMetadataFunction);
        }

        public Task<TransactionReceipt> SetMetadataRequestAndWaitForReceiptAsync(SetMetadataFunction setMetadataFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMetadataFunction, cancellationToken);
        }

        public Task<string> SetMetadataRequestAsync(BigInteger globalId, GlobalMetadata globalMetadata)
        {
            var setMetadataFunction = new SetMetadataFunction();
                setMetadataFunction.GlobalId = globalId;
                setMetadataFunction.GlobalMetadata = globalMetadata;
            
             return ContractHandler.SendRequestAsync(setMetadataFunction);
        }

        public Task<TransactionReceipt> SetMetadataRequestAndWaitForReceiptAsync(BigInteger globalId, GlobalMetadata globalMetadata, CancellationTokenSource cancellationToken = null)
        {
            var setMetadataFunction = new SetMetadataFunction();
                setMetadataFunction.GlobalId = globalId;
                setMetadataFunction.GlobalMetadata = globalMetadata;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setMetadataFunction, cancellationToken);
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

        public Task<string> SetStringRequestAsync(SetStringFunction setStringFunction)
        {
             return ContractHandler.SendRequestAsync(setStringFunction);
        }

        public Task<TransactionReceipt> SetStringRequestAndWaitForReceiptAsync(SetStringFunction setStringFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStringFunction, cancellationToken);
        }

        public Task<string> SetStringRequestAsync(BigInteger globalId, string value)
        {
            var setStringFunction = new SetStringFunction();
                setStringFunction.GlobalId = globalId;
                setStringFunction.Value = value;
            
             return ContractHandler.SendRequestAsync(setStringFunction);
        }

        public Task<TransactionReceipt> SetStringRequestAndWaitForReceiptAsync(BigInteger globalId, string value, CancellationTokenSource cancellationToken = null)
        {
            var setStringFunction = new SetStringFunction();
                setStringFunction.GlobalId = globalId;
                setStringFunction.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStringFunction, cancellationToken);
        }

        public Task<string> SetStringArrayRequestAsync(SetStringArrayFunction setStringArrayFunction)
        {
             return ContractHandler.SendRequestAsync(setStringArrayFunction);
        }

        public Task<TransactionReceipt> SetStringArrayRequestAndWaitForReceiptAsync(SetStringArrayFunction setStringArrayFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStringArrayFunction, cancellationToken);
        }

        public Task<string> SetStringArrayRequestAsync(BigInteger globalId, List<string> values)
        {
            var setStringArrayFunction = new SetStringArrayFunction();
                setStringArrayFunction.GlobalId = globalId;
                setStringArrayFunction.Values = values;
            
             return ContractHandler.SendRequestAsync(setStringArrayFunction);
        }

        public Task<TransactionReceipt> SetStringArrayRequestAndWaitForReceiptAsync(BigInteger globalId, List<string> values, CancellationTokenSource cancellationToken = null)
        {
            var setStringArrayFunction = new SetStringArrayFunction();
                setStringArrayFunction.GlobalId = globalId;
                setStringArrayFunction.Values = values;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStringArrayFunction, cancellationToken);
        }

        public Task<string> SetUint256RequestAsync(SetUint256Function setUint256Function)
        {
             return ContractHandler.SendRequestAsync(setUint256Function);
        }

        public Task<TransactionReceipt> SetUint256RequestAndWaitForReceiptAsync(SetUint256Function setUint256Function, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setUint256Function, cancellationToken);
        }

        public Task<string> SetUint256RequestAsync(BigInteger globalId, BigInteger value)
        {
            var setUint256Function = new SetUint256Function();
                setUint256Function.GlobalId = globalId;
                setUint256Function.Value = value;
            
             return ContractHandler.SendRequestAsync(setUint256Function);
        }

        public Task<TransactionReceipt> SetUint256RequestAndWaitForReceiptAsync(BigInteger globalId, BigInteger value, CancellationTokenSource cancellationToken = null)
        {
            var setUint256Function = new SetUint256Function();
                setUint256Function.GlobalId = globalId;
                setUint256Function.Value = value;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setUint256Function, cancellationToken);
        }

        public Task<string> SetUint256ArrayRequestAsync(SetUint256ArrayFunction setUint256ArrayFunction)
        {
             return ContractHandler.SendRequestAsync(setUint256ArrayFunction);
        }

        public Task<TransactionReceipt> SetUint256ArrayRequestAndWaitForReceiptAsync(SetUint256ArrayFunction setUint256ArrayFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setUint256ArrayFunction, cancellationToken);
        }

        public Task<string> SetUint256ArrayRequestAsync(BigInteger globalId, List<BigInteger> values)
        {
            var setUint256ArrayFunction = new SetUint256ArrayFunction();
                setUint256ArrayFunction.GlobalId = globalId;
                setUint256ArrayFunction.Values = values;
            
             return ContractHandler.SendRequestAsync(setUint256ArrayFunction);
        }

        public Task<TransactionReceipt> SetUint256ArrayRequestAndWaitForReceiptAsync(BigInteger globalId, List<BigInteger> values, CancellationTokenSource cancellationToken = null)
        {
            var setUint256ArrayFunction = new SetUint256ArrayFunction();
                setUint256ArrayFunction.GlobalId = globalId;
                setUint256ArrayFunction.Values = values;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setUint256ArrayFunction, cancellationToken);
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

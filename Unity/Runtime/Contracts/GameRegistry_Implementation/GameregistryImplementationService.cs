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
using PirateNationContracts.GameRegistry_Implementation.ContractDefinition;

namespace PirateNationContracts.GameRegistry_Implementation
{
    public partial class GameregistryImplementationService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, GameregistryImplementationDeployment gameregistryImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<GameregistryImplementationDeployment>().SendRequestAndWaitForReceiptAsync(gameregistryImplementationDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, GameregistryImplementationDeployment gameregistryImplementationDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<GameregistryImplementationDeployment>().SendRequestAsync(gameregistryImplementationDeployment);
        }

        public static async Task<GameregistryImplementationService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, GameregistryImplementationDeployment gameregistryImplementationDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, gameregistryImplementationDeployment, cancellationTokenSource);
            return new GameregistryImplementationService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public GameregistryImplementationService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<byte[]> DefaultAdminRoleQueryAsync(DefaultAdminRoleFunction defaultAdminRoleFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DefaultAdminRoleFunction, byte[]>(defaultAdminRoleFunction, blockParameter);
        }

        
        public Task<byte[]> DefaultAdminRoleQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DefaultAdminRoleFunction, byte[]>(null, blockParameter);
        }

        public Task<BigInteger> OperatorMessageBlockLimitQueryAsync(OperatorMessageBlockLimitFunction operatorMessageBlockLimitFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OperatorMessageBlockLimitFunction, BigInteger>(operatorMessageBlockLimitFunction, blockParameter);
        }

        
        public Task<BigInteger> OperatorMessageBlockLimitQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OperatorMessageBlockLimitFunction, BigInteger>(null, blockParameter);
        }

        public Task<BigInteger> RegisterOperatorCooldownLimitQueryAsync(RegisterOperatorCooldownLimitFunction registerOperatorCooldownLimitFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RegisterOperatorCooldownLimitFunction, BigInteger>(registerOperatorCooldownLimitFunction, blockParameter);
        }

        
        public Task<BigInteger> RegisterOperatorCooldownLimitQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RegisterOperatorCooldownLimitFunction, BigInteger>(null, blockParameter);
        }

        public Task<string> DeregisterOperatorRequestAsync(DeregisterOperatorFunction deregisterOperatorFunction)
        {
             return ContractHandler.SendRequestAsync(deregisterOperatorFunction);
        }

        public Task<TransactionReceipt> DeregisterOperatorRequestAndWaitForReceiptAsync(DeregisterOperatorFunction deregisterOperatorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(deregisterOperatorFunction, cancellationToken);
        }

        public Task<string> DeregisterOperatorRequestAsync(string operatorToDeregister)
        {
            var deregisterOperatorFunction = new DeregisterOperatorFunction();
                deregisterOperatorFunction.OperatorToDeregister = operatorToDeregister;
            
             return ContractHandler.SendRequestAsync(deregisterOperatorFunction);
        }

        public Task<TransactionReceipt> DeregisterOperatorRequestAndWaitForReceiptAsync(string operatorToDeregister, CancellationTokenSource cancellationToken = null)
        {
            var deregisterOperatorFunction = new DeregisterOperatorFunction();
                deregisterOperatorFunction.OperatorToDeregister = operatorToDeregister;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(deregisterOperatorFunction, cancellationToken);
        }

        public Task<byte[]> GetOperatorAccountRegistrationMessageToSignQueryAsync(GetOperatorAccountRegistrationMessageToSignFunction getOperatorAccountRegistrationMessageToSignFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetOperatorAccountRegistrationMessageToSignFunction, byte[]>(getOperatorAccountRegistrationMessageToSignFunction, blockParameter);
        }

        
        public Task<byte[]> GetOperatorAccountRegistrationMessageToSignQueryAsync(string player, string @operator, BigInteger expiration, BigInteger blockNumber, BlockParameter blockParameter = null)
        {
            var getOperatorAccountRegistrationMessageToSignFunction = new GetOperatorAccountRegistrationMessageToSignFunction();
                getOperatorAccountRegistrationMessageToSignFunction.Player = player;
                getOperatorAccountRegistrationMessageToSignFunction.Operator = @operator;
                getOperatorAccountRegistrationMessageToSignFunction.Expiration = expiration;
                getOperatorAccountRegistrationMessageToSignFunction.BlockNumber = blockNumber;
            
            return ContractHandler.QueryAsync<GetOperatorAccountRegistrationMessageToSignFunction, byte[]>(getOperatorAccountRegistrationMessageToSignFunction, blockParameter);
        }

        public Task<string> GetPlayerAccountQueryAsync(GetPlayerAccountFunction getPlayerAccountFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetPlayerAccountFunction, string>(getPlayerAccountFunction, blockParameter);
        }

        
        public Task<string> GetPlayerAccountQueryAsync(string operatorAddress, BlockParameter blockParameter = null)
        {
            var getPlayerAccountFunction = new GetPlayerAccountFunction();
                getPlayerAccountFunction.OperatorAddress = operatorAddress;
            
            return ContractHandler.QueryAsync<GetPlayerAccountFunction, string>(getPlayerAccountFunction, blockParameter);
        }

        public Task<List<string>> GetRegisteredOperatorsQueryAsync(GetRegisteredOperatorsFunction getRegisteredOperatorsFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetRegisteredOperatorsFunction, List<string>>(getRegisteredOperatorsFunction, blockParameter);
        }

        
        public Task<List<string>> GetRegisteredOperatorsQueryAsync(string player, BlockParameter blockParameter = null)
        {
            var getRegisteredOperatorsFunction = new GetRegisteredOperatorsFunction();
                getRegisteredOperatorsFunction.Player = player;
            
            return ContractHandler.QueryAsync<GetRegisteredOperatorsFunction, List<string>>(getRegisteredOperatorsFunction, blockParameter);
        }

        public Task<byte[]> GetRoleAdminQueryAsync(GetRoleAdminFunction getRoleAdminFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetRoleAdminFunction, byte[]>(getRoleAdminFunction, blockParameter);
        }

        
        public Task<byte[]> GetRoleAdminQueryAsync(byte[] role, BlockParameter blockParameter = null)
        {
            var getRoleAdminFunction = new GetRoleAdminFunction();
                getRoleAdminFunction.Role = role;
            
            return ContractHandler.QueryAsync<GetRoleAdminFunction, byte[]>(getRoleAdminFunction, blockParameter);
        }

        public Task<string> GetSystemQueryAsync(GetSystemFunction getSystemFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetSystemFunction, string>(getSystemFunction, blockParameter);
        }

        
        public Task<string> GetSystemQueryAsync(BigInteger systemId, BlockParameter blockParameter = null)
        {
            var getSystemFunction = new GetSystemFunction();
                getSystemFunction.SystemId = systemId;
            
            return ContractHandler.QueryAsync<GetSystemFunction, string>(getSystemFunction, blockParameter);
        }

        public Task<string> GrantRoleRequestAsync(GrantRoleFunction grantRoleFunction)
        {
             return ContractHandler.SendRequestAsync(grantRoleFunction);
        }

        public Task<TransactionReceipt> GrantRoleRequestAndWaitForReceiptAsync(GrantRoleFunction grantRoleFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantRoleFunction, cancellationToken);
        }

        public Task<string> GrantRoleRequestAsync(byte[] role, string account)
        {
            var grantRoleFunction = new GrantRoleFunction();
                grantRoleFunction.Role = role;
                grantRoleFunction.Account = account;
            
             return ContractHandler.SendRequestAsync(grantRoleFunction);
        }

        public Task<TransactionReceipt> GrantRoleRequestAndWaitForReceiptAsync(byte[] role, string account, CancellationTokenSource cancellationToken = null)
        {
            var grantRoleFunction = new GrantRoleFunction();
                grantRoleFunction.Role = role;
                grantRoleFunction.Account = account;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(grantRoleFunction, cancellationToken);
        }

        public Task<bool> HasAccessRoleQueryAsync(HasAccessRoleFunction hasAccessRoleFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<HasAccessRoleFunction, bool>(hasAccessRoleFunction, blockParameter);
        }

        
        public Task<bool> HasAccessRoleQueryAsync(byte[] role, string account, BlockParameter blockParameter = null)
        {
            var hasAccessRoleFunction = new HasAccessRoleFunction();
                hasAccessRoleFunction.Role = role;
                hasAccessRoleFunction.Account = account;
            
            return ContractHandler.QueryAsync<HasAccessRoleFunction, bool>(hasAccessRoleFunction, blockParameter);
        }

        public Task<bool> HasRoleQueryAsync(HasRoleFunction hasRoleFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<HasRoleFunction, bool>(hasRoleFunction, blockParameter);
        }

        
        public Task<bool> HasRoleQueryAsync(byte[] role, string account, BlockParameter blockParameter = null)
        {
            var hasRoleFunction = new HasRoleFunction();
                hasRoleFunction.Role = role;
                hasRoleFunction.Account = account;
            
            return ContractHandler.QueryAsync<HasRoleFunction, bool>(hasRoleFunction, blockParameter);
        }

        public Task<string> InitializeRequestAsync(InitializeFunction initializeFunction)
        {
             return ContractHandler.SendRequestAsync(initializeFunction);
        }

        public Task<string> InitializeRequestAsync()
        {
             return ContractHandler.SendRequestAsync<InitializeFunction>();
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(InitializeFunction initializeFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(initializeFunction, cancellationToken);
        }

        public Task<TransactionReceipt> InitializeRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<InitializeFunction>(null, cancellationToken);
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

        public Task<BigInteger> LastRegisterOperatorTimeQueryAsync(LastRegisterOperatorTimeFunction lastRegisterOperatorTimeFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<LastRegisterOperatorTimeFunction, BigInteger>(lastRegisterOperatorTimeFunction, blockParameter);
        }

        
        public Task<BigInteger> LastRegisterOperatorTimeQueryAsync(string returnValue1, BlockParameter blockParameter = null)
        {
            var lastRegisterOperatorTimeFunction = new LastRegisterOperatorTimeFunction();
                lastRegisterOperatorTimeFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<LastRegisterOperatorTimeFunction, BigInteger>(lastRegisterOperatorTimeFunction, blockParameter);
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

        public Task<string> RegisterOperatorRequestAsync(RegisterOperatorFunction registerOperatorFunction)
        {
             return ContractHandler.SendRequestAsync(registerOperatorFunction);
        }

        public Task<TransactionReceipt> RegisterOperatorRequestAndWaitForReceiptAsync(RegisterOperatorFunction registerOperatorFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerOperatorFunction, cancellationToken);
        }

        public Task<string> RegisterOperatorRequestAsync(byte[] signature, string player, string @operator, BigInteger expiration, BigInteger blockNumber)
        {
            var registerOperatorFunction = new RegisterOperatorFunction();
                registerOperatorFunction.Signature = signature;
                registerOperatorFunction.Player = player;
                registerOperatorFunction.Operator = @operator;
                registerOperatorFunction.Expiration = expiration;
                registerOperatorFunction.BlockNumber = blockNumber;
            
             return ContractHandler.SendRequestAsync(registerOperatorFunction);
        }

        public Task<TransactionReceipt> RegisterOperatorRequestAndWaitForReceiptAsync(byte[] signature, string player, string @operator, BigInteger expiration, BigInteger blockNumber, CancellationTokenSource cancellationToken = null)
        {
            var registerOperatorFunction = new RegisterOperatorFunction();
                registerOperatorFunction.Signature = signature;
                registerOperatorFunction.Player = player;
                registerOperatorFunction.Operator = @operator;
                registerOperatorFunction.Expiration = expiration;
                registerOperatorFunction.BlockNumber = blockNumber;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerOperatorFunction, cancellationToken);
        }

        public Task<string> RegisterSystemRequestAsync(RegisterSystemFunction registerSystemFunction)
        {
             return ContractHandler.SendRequestAsync(registerSystemFunction);
        }

        public Task<TransactionReceipt> RegisterSystemRequestAndWaitForReceiptAsync(RegisterSystemFunction registerSystemFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerSystemFunction, cancellationToken);
        }

        public Task<string> RegisterSystemRequestAsync(BigInteger systemId, string systemAddress)
        {
            var registerSystemFunction = new RegisterSystemFunction();
                registerSystemFunction.SystemId = systemId;
                registerSystemFunction.SystemAddress = systemAddress;
            
             return ContractHandler.SendRequestAsync(registerSystemFunction);
        }

        public Task<TransactionReceipt> RegisterSystemRequestAndWaitForReceiptAsync(BigInteger systemId, string systemAddress, CancellationTokenSource cancellationToken = null)
        {
            var registerSystemFunction = new RegisterSystemFunction();
                registerSystemFunction.SystemId = systemId;
                registerSystemFunction.SystemAddress = systemAddress;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(registerSystemFunction, cancellationToken);
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

        public Task<string> RenounceRoleRequestAsync(RenounceRoleFunction renounceRoleFunction)
        {
             return ContractHandler.SendRequestAsync(renounceRoleFunction);
        }

        public Task<TransactionReceipt> RenounceRoleRequestAndWaitForReceiptAsync(RenounceRoleFunction renounceRoleFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceRoleFunction, cancellationToken);
        }

        public Task<string> RenounceRoleRequestAsync(byte[] role, string account)
        {
            var renounceRoleFunction = new RenounceRoleFunction();
                renounceRoleFunction.Role = role;
                renounceRoleFunction.Account = account;
            
             return ContractHandler.SendRequestAsync(renounceRoleFunction);
        }

        public Task<TransactionReceipt> RenounceRoleRequestAndWaitForReceiptAsync(byte[] role, string account, CancellationTokenSource cancellationToken = null)
        {
            var renounceRoleFunction = new RenounceRoleFunction();
                renounceRoleFunction.Role = role;
                renounceRoleFunction.Account = account;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceRoleFunction, cancellationToken);
        }

        public Task<string> RevokeRoleRequestAsync(RevokeRoleFunction revokeRoleFunction)
        {
             return ContractHandler.SendRequestAsync(revokeRoleFunction);
        }

        public Task<TransactionReceipt> RevokeRoleRequestAndWaitForReceiptAsync(RevokeRoleFunction revokeRoleFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(revokeRoleFunction, cancellationToken);
        }

        public Task<string> RevokeRoleRequestAsync(byte[] role, string account)
        {
            var revokeRoleFunction = new RevokeRoleFunction();
                revokeRoleFunction.Role = role;
                revokeRoleFunction.Account = account;
            
             return ContractHandler.SendRequestAsync(revokeRoleFunction);
        }

        public Task<TransactionReceipt> RevokeRoleRequestAndWaitForReceiptAsync(byte[] role, string account, CancellationTokenSource cancellationToken = null)
        {
            var revokeRoleFunction = new RevokeRoleFunction();
                revokeRoleFunction.Role = role;
                revokeRoleFunction.Account = account;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(revokeRoleFunction, cancellationToken);
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

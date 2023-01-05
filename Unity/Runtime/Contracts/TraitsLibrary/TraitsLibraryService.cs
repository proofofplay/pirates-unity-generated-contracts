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
using SimpleStorage.TraitsLibrary.ContractDefinition;

namespace SimpleStorage.TraitsLibrary
{
    public partial class TraitsLibraryService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, TraitsLibraryDeployment traitsLibraryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<TraitsLibraryDeployment>().SendRequestAndWaitForReceiptAsync(traitsLibraryDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, TraitsLibraryDeployment traitsLibraryDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<TraitsLibraryDeployment>().SendRequestAsync(traitsLibraryDeployment);
        }

        public static async Task<TraitsLibraryService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, TraitsLibraryDeployment traitsLibraryDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, traitsLibraryDeployment, cancellationTokenSource);
            return new TraitsLibraryService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public TraitsLibraryService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<uint> COMMAND_RANK_TRAIT_IDQueryAsync(COMMAND_RANK_TRAIT_IDFunction cOMMAND_RANK_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<COMMAND_RANK_TRAIT_IDFunction, uint>(cOMMAND_RANK_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> COMMAND_RANK_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<COMMAND_RANK_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> DESCRIPTION_TRAIT_IDQueryAsync(DESCRIPTION_TRAIT_IDFunction dESCRIPTION_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DESCRIPTION_TRAIT_IDFunction, uint>(dESCRIPTION_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> DESCRIPTION_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DESCRIPTION_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> DICE_ROLL_1_TRAIT_IDQueryAsync(DICE_ROLL_1_TRAIT_IDFunction dICE_ROLL_1_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DICE_ROLL_1_TRAIT_IDFunction, uint>(dICE_ROLL_1_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> DICE_ROLL_1_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DICE_ROLL_1_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> DICE_ROLL_2_TRAIT_IDQueryAsync(DICE_ROLL_2_TRAIT_IDFunction dICE_ROLL_2_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DICE_ROLL_2_TRAIT_IDFunction, uint>(dICE_ROLL_2_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> DICE_ROLL_2_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<DICE_ROLL_2_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> ELEMENTAL_AFFINITY_TRAIT_IDQueryAsync(ELEMENTAL_AFFINITY_TRAIT_IDFunction eLEMENTAL_AFFINITY_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ELEMENTAL_AFFINITY_TRAIT_IDFunction, uint>(eLEMENTAL_AFFINITY_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> ELEMENTAL_AFFINITY_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<ELEMENTAL_AFFINITY_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> GENERATION_TRAIT_IDQueryAsync(GENERATION_TRAIT_IDFunction gENERATION_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GENERATION_TRAIT_IDFunction, uint>(gENERATION_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> GENERATION_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GENERATION_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> IMAGE_HASH_TRAIT_IDQueryAsync(IMAGE_HASH_TRAIT_IDFunction iMAGE_HASH_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IMAGE_HASH_TRAIT_IDFunction, uint>(iMAGE_HASH_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> IMAGE_HASH_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IMAGE_HASH_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> IS_NAVY_TRAIT_IDQueryAsync(IS_NAVY_TRAIT_IDFunction iS_NAVY_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IS_NAVY_TRAIT_IDFunction, uint>(iS_NAVY_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> IS_NAVY_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IS_NAVY_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> NAME_TRAIT_IDQueryAsync(NAME_TRAIT_IDFunction nAME_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NAME_TRAIT_IDFunction, uint>(nAME_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> NAME_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NAME_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_BACKGROUND_TRAIT_IDQueryAsync(PROFILE_BACKGROUND_TRAIT_IDFunction pROFILE_BACKGROUND_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_BACKGROUND_TRAIT_IDFunction, uint>(pROFILE_BACKGROUND_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_BACKGROUND_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_BACKGROUND_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_CHARACTER_TYPEQueryAsync(PROFILE_CHARACTER_TYPEFunction pROFILE_CHARACTER_TYPEFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_CHARACTER_TYPEFunction, uint>(pROFILE_CHARACTER_TYPEFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_CHARACTER_TYPEQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_CHARACTER_TYPEFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_COAT_TRAIT_IDQueryAsync(PROFILE_COAT_TRAIT_IDFunction pROFILE_COAT_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_COAT_TRAIT_IDFunction, uint>(pROFILE_COAT_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_COAT_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_COAT_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_EARRING_TRAIT_IDQueryAsync(PROFILE_EARRING_TRAIT_IDFunction pROFILE_EARRING_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_EARRING_TRAIT_IDFunction, uint>(pROFILE_EARRING_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_EARRING_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_EARRING_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_EYES_TRAIT_IDQueryAsync(PROFILE_EYES_TRAIT_IDFunction pROFILE_EYES_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_EYES_TRAIT_IDFunction, uint>(pROFILE_EYES_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_EYES_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_EYES_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_EYE_COVERING_TRAIT_IDQueryAsync(PROFILE_EYE_COVERING_TRAIT_IDFunction pROFILE_EYE_COVERING_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_EYE_COVERING_TRAIT_IDFunction, uint>(pROFILE_EYE_COVERING_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_EYE_COVERING_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_EYE_COVERING_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_FACIAL_HAIR_TRAIT_IDQueryAsync(PROFILE_FACIAL_HAIR_TRAIT_IDFunction pROFILE_FACIAL_HAIR_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_FACIAL_HAIR_TRAIT_IDFunction, uint>(pROFILE_FACIAL_HAIR_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_FACIAL_HAIR_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_FACIAL_HAIR_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_HAIR_TRAIT_IDQueryAsync(PROFILE_HAIR_TRAIT_IDFunction pROFILE_HAIR_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_HAIR_TRAIT_IDFunction, uint>(pROFILE_HAIR_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_HAIR_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_HAIR_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_HEADWEAR_TRAIT_IDQueryAsync(PROFILE_HEADWEAR_TRAIT_IDFunction pROFILE_HEADWEAR_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_HEADWEAR_TRAIT_IDFunction, uint>(pROFILE_HEADWEAR_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_HEADWEAR_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_HEADWEAR_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_IS_LEGENDARY_TRAIT_IDQueryAsync(PROFILE_IS_LEGENDARY_TRAIT_IDFunction pROFILE_IS_LEGENDARY_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_IS_LEGENDARY_TRAIT_IDFunction, uint>(pROFILE_IS_LEGENDARY_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_IS_LEGENDARY_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_IS_LEGENDARY_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_MAGE_GEM_TRAIT_IDQueryAsync(PROFILE_MAGE_GEM_TRAIT_IDFunction pROFILE_MAGE_GEM_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_MAGE_GEM_TRAIT_IDFunction, uint>(pROFILE_MAGE_GEM_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_MAGE_GEM_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_MAGE_GEM_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> PROFILE_SKIN_TRAIT_IDQueryAsync(PROFILE_SKIN_TRAIT_IDFunction pROFILE_SKIN_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_SKIN_TRAIT_IDFunction, uint>(pROFILE_SKIN_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> PROFILE_SKIN_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<PROFILE_SKIN_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> RARITY_TRAIT_IDQueryAsync(RARITY_TRAIT_IDFunction rARITY_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RARITY_TRAIT_IDFunction, uint>(rARITY_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> RARITY_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<RARITY_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> SHIP_GOLD_CAPACITY_TRAIT_IDQueryAsync(SHIP_GOLD_CAPACITY_TRAIT_IDFunction sHIP_GOLD_CAPACITY_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SHIP_GOLD_CAPACITY_TRAIT_IDFunction, uint>(sHIP_GOLD_CAPACITY_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> SHIP_GOLD_CAPACITY_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SHIP_GOLD_CAPACITY_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> SHIP_GOLD_PER_DAY_TRAIT_IDQueryAsync(SHIP_GOLD_PER_DAY_TRAIT_IDFunction sHIP_GOLD_PER_DAY_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SHIP_GOLD_PER_DAY_TRAIT_IDFunction, uint>(sHIP_GOLD_PER_DAY_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> SHIP_GOLD_PER_DAY_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SHIP_GOLD_PER_DAY_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> SHIP_RANK_TRAIT_IDQueryAsync(SHIP_RANK_TRAIT_IDFunction sHIP_RANK_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SHIP_RANK_TRAIT_IDFunction, uint>(sHIP_RANK_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> SHIP_RANK_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SHIP_RANK_TRAIT_IDFunction, uint>(null, blockParameter);
        }

        public Task<uint> STAR_SIGNQueryAsync(STAR_SIGNFunction sTAR_SIGNFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<STAR_SIGNFunction, uint>(sTAR_SIGNFunction, blockParameter);
        }

        
        public Task<uint> STAR_SIGNQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<STAR_SIGNFunction, uint>(null, blockParameter);
        }

        public Task<uint> XP_TRAIT_IDQueryAsync(XP_TRAIT_IDFunction xP_TRAIT_IDFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<XP_TRAIT_IDFunction, uint>(xP_TRAIT_IDFunction, blockParameter);
        }

        
        public Task<uint> XP_TRAIT_IDQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<XP_TRAIT_IDFunction, uint>(null, blockParameter);
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Hydration.NetApi.Generated.Storage
{
    
    
    /// <summary>
    /// >> XYKLiquidityMiningStorage
    /// </summary>
    public sealed class XYKLiquidityMiningStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> XYKLiquidityMiningStorage Constructor
        /// </summary>
        public XYKLiquidityMiningStorage(SubstrateClientExt client)
        {
            this._client = client;
        }
    }
    
    /// <summary>
    /// >> XYKLiquidityMiningCalls
    /// </summary>
    public sealed class XYKLiquidityMiningCalls
    {
        
        /// <summary>
        /// >> create_global_farm
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method CreateGlobalFarm(Substrate.NetApi.Model.Types.Primitive.U128 total_rewards, Substrate.NetApi.Model.Types.Primitive.U32 planned_yielding_periods, Substrate.NetApi.Model.Types.Primitive.U32 blocks_per_period, Substrate.NetApi.Model.Types.Primitive.U32 incentivized_asset, Substrate.NetApi.Model.Types.Primitive.U32 reward_currency, Hydration.NetApi.Generated.Model.sp_core.crypto.AccountId32 owner, Hydration.NetApi.Generated.Model.sp_arithmetic.per_things.Perquintill yield_per_period, Substrate.NetApi.Model.Types.Primitive.U128 min_deposit, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 price_adjustment)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(total_rewards.Encode());
            byteArray.AddRange(planned_yielding_periods.Encode());
            byteArray.AddRange(blocks_per_period.Encode());
            byteArray.AddRange(incentivized_asset.Encode());
            byteArray.AddRange(reward_currency.Encode());
            byteArray.AddRange(owner.Encode());
            byteArray.AddRange(yield_per_period.Encode());
            byteArray.AddRange(min_deposit.Encode());
            byteArray.AddRange(price_adjustment.Encode());
            return new Method(95, "XYKLiquidityMining", 0, "create_global_farm", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> update_global_farm
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method UpdateGlobalFarm(Substrate.NetApi.Model.Types.Primitive.U32 global_farm_id, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 price_adjustment)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(global_farm_id.Encode());
            byteArray.AddRange(price_adjustment.Encode());
            return new Method(95, "XYKLiquidityMining", 1, "update_global_farm", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> terminate_global_farm
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TerminateGlobalFarm(Substrate.NetApi.Model.Types.Primitive.U32 global_farm_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(global_farm_id.Encode());
            return new Method(95, "XYKLiquidityMining", 2, "terminate_global_farm", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> create_yield_farm
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method CreateYieldFarm(Substrate.NetApi.Model.Types.Primitive.U32 global_farm_id, Hydration.NetApi.Generated.Model.pallet_xyk.types.AssetPair asset_pair, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 multiplier, Substrate.NetApi.Model.Types.Base.BaseOpt<Hydration.NetApi.Generated.Model.pallet_liquidity_mining.types.LoyaltyCurve> loyalty_curve)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(global_farm_id.Encode());
            byteArray.AddRange(asset_pair.Encode());
            byteArray.AddRange(multiplier.Encode());
            byteArray.AddRange(loyalty_curve.Encode());
            return new Method(95, "XYKLiquidityMining", 3, "create_yield_farm", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> update_yield_farm
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method UpdateYieldFarm(Substrate.NetApi.Model.Types.Primitive.U32 global_farm_id, Hydration.NetApi.Generated.Model.pallet_xyk.types.AssetPair asset_pair, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 multiplier)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(global_farm_id.Encode());
            byteArray.AddRange(asset_pair.Encode());
            byteArray.AddRange(multiplier.Encode());
            return new Method(95, "XYKLiquidityMining", 4, "update_yield_farm", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> stop_yield_farm
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method StopYieldFarm(Substrate.NetApi.Model.Types.Primitive.U32 global_farm_id, Hydration.NetApi.Generated.Model.pallet_xyk.types.AssetPair asset_pair)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(global_farm_id.Encode());
            byteArray.AddRange(asset_pair.Encode());
            return new Method(95, "XYKLiquidityMining", 5, "stop_yield_farm", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> resume_yield_farm
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ResumeYieldFarm(Substrate.NetApi.Model.Types.Primitive.U32 global_farm_id, Substrate.NetApi.Model.Types.Primitive.U32 yield_farm_id, Hydration.NetApi.Generated.Model.pallet_xyk.types.AssetPair asset_pair, Hydration.NetApi.Generated.Model.sp_arithmetic.fixed_point.FixedU128 multiplier)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(global_farm_id.Encode());
            byteArray.AddRange(yield_farm_id.Encode());
            byteArray.AddRange(asset_pair.Encode());
            byteArray.AddRange(multiplier.Encode());
            return new Method(95, "XYKLiquidityMining", 6, "resume_yield_farm", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> terminate_yield_farm
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method TerminateYieldFarm(Substrate.NetApi.Model.Types.Primitive.U32 global_farm_id, Substrate.NetApi.Model.Types.Primitive.U32 yield_farm_id, Hydration.NetApi.Generated.Model.pallet_xyk.types.AssetPair asset_pair)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(global_farm_id.Encode());
            byteArray.AddRange(yield_farm_id.Encode());
            byteArray.AddRange(asset_pair.Encode());
            return new Method(95, "XYKLiquidityMining", 7, "terminate_yield_farm", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> deposit_shares
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method DepositShares(Substrate.NetApi.Model.Types.Primitive.U32 global_farm_id, Substrate.NetApi.Model.Types.Primitive.U32 yield_farm_id, Hydration.NetApi.Generated.Model.pallet_xyk.types.AssetPair asset_pair, Substrate.NetApi.Model.Types.Primitive.U128 shares_amount)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(global_farm_id.Encode());
            byteArray.AddRange(yield_farm_id.Encode());
            byteArray.AddRange(asset_pair.Encode());
            byteArray.AddRange(shares_amount.Encode());
            return new Method(95, "XYKLiquidityMining", 8, "deposit_shares", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> redeposit_shares
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RedepositShares(Substrate.NetApi.Model.Types.Primitive.U32 global_farm_id, Substrate.NetApi.Model.Types.Primitive.U32 yield_farm_id, Hydration.NetApi.Generated.Model.pallet_xyk.types.AssetPair asset_pair, Substrate.NetApi.Model.Types.Primitive.U128 deposit_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(global_farm_id.Encode());
            byteArray.AddRange(yield_farm_id.Encode());
            byteArray.AddRange(asset_pair.Encode());
            byteArray.AddRange(deposit_id.Encode());
            return new Method(95, "XYKLiquidityMining", 9, "redeposit_shares", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> claim_rewards
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method ClaimRewards(Substrate.NetApi.Model.Types.Primitive.U128 deposit_id, Substrate.NetApi.Model.Types.Primitive.U32 yield_farm_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(deposit_id.Encode());
            byteArray.AddRange(yield_farm_id.Encode());
            return new Method(95, "XYKLiquidityMining", 10, "claim_rewards", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> withdraw_shares
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method WithdrawShares(Substrate.NetApi.Model.Types.Primitive.U128 deposit_id, Substrate.NetApi.Model.Types.Primitive.U32 yield_farm_id, Hydration.NetApi.Generated.Model.pallet_xyk.types.AssetPair asset_pair)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(deposit_id.Encode());
            byteArray.AddRange(yield_farm_id.Encode());
            byteArray.AddRange(asset_pair.Encode());
            return new Method(95, "XYKLiquidityMining", 11, "withdraw_shares", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> XYKLiquidityMiningConstants
    /// </summary>
    public sealed class XYKLiquidityMiningConstants
    {
        
        /// <summary>
        /// >> NFTCollectionId
        ///  NFT collection id for liquidity mining's deposit nfts.
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 NFTCollectionId()
        {
            var result = new Substrate.NetApi.Model.Types.Primitive.U128();
            result.Create("0x0D150000000000000000000000000000");
            return result;
        }
    }
    
    /// <summary>
    /// >> XYKLiquidityMiningErrors
    /// </summary>
    public enum XYKLiquidityMiningErrors
    {
        
        /// <summary>
        /// >> CantFindDepositOwner
        /// Nft pallet didn't return an owner.
        /// </summary>
        CantFindDepositOwner,
        
        /// <summary>
        /// >> InsufficientXykSharesBalance
        /// Account balance of XYK pool shares is not sufficient.
        /// </summary>
        InsufficientXykSharesBalance,
        
        /// <summary>
        /// >> XykPoolDoesntExist
        /// XYK pool does not exist
        /// </summary>
        XykPoolDoesntExist,
        
        /// <summary>
        /// >> NotDepositOwner
        /// Account is not deposit owner.
        /// </summary>
        NotDepositOwner,
        
        /// <summary>
        /// >> CantGetXykAssets
        /// XYK did not return assets for given pool id
        /// </summary>
        CantGetXykAssets,
        
        /// <summary>
        /// >> DepositDataNotFound
        /// Deposit data not found
        /// </summary>
        DepositDataNotFound,
        
        /// <summary>
        /// >> ZeroClaimedRewards
        /// Calculated reward to claim is 0.
        /// </summary>
        ZeroClaimedRewards,
        
        /// <summary>
        /// >> AssetNotInAssetPair
        /// Asset is not in the `AssetPair`.
        /// </summary>
        AssetNotInAssetPair,
        
        /// <summary>
        /// >> InvalidAssetPair
        /// Provided `AssetPair` is not used by the deposit.
        /// </summary>
        InvalidAssetPair,
        
        /// <summary>
        /// >> AssetNotRegistered
        /// Asset is not registered in asset registry.
        /// </summary>
        AssetNotRegistered,
        
        /// <summary>
        /// >> FailToGetPotId
        /// Failed to calculate `pot`'s account.
        /// </summary>
        FailToGetPotId,
    }
}
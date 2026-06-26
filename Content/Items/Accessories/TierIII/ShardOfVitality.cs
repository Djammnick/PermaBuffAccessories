using DjamUtility.Content.Buffs;
using DjamUtility.Content.Items.Accessories.TierII;
using DjamUtility.Content.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierIII;

public class ShardOfVitality : ModItem
{
    public override void SetStaticDefaults()
    {
        //IL_002f: Unknown result type (might be due to invalid IL or missing references)
        //IL_0039: Expected O, but got Unknown
        // ((ModItem)this).DisplayName.SetDefault("Shard of Vitality");
        // ((ModItem)this).Tooltip.SetDefault("Your inner power is immense.\n'The third one of the legendary shards'");
        Main.RegisterItemAnimation(((ModItem)this).Item.type, (DrawAnimation)new DrawAnimationVertical(5, 15, false));
        ItemID.Sets.AnimatesAsSoul[Item.type] = true;
        ItemID.Sets.ItemIconPulse[Item.type] = true;
        ItemID.Sets.ItemNoGravity[Item.type] = true;
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        ((Entity)((ModItem)this).Item).width = 20;
        ((Entity)((ModItem)this).Item).height = 26;
        ((ModItem)this).Item.useAnimation = 15;
        ((ModItem)this).Item.useTime = 15;
        ((ModItem)this).Item.maxStack = 1;
        ((ModItem)this).Item.consumable = false;
        ((ModItem)this).Item.accessory = true;
        ((ModItem)this).Item.rare = ItemRarityID.Lime;
        ((ModItem)this).Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void PostUpdate()
    {
        //IL_0006: Unknown result type (might be due to invalid IL or missing references)
        //IL_000b: Unknown result type (might be due to invalid IL or missing references)
        //IL_0010: Unknown result type (might be due to invalid IL or missing references)
        //IL_0013: Unknown result type (might be due to invalid IL or missing references)
        //IL_001d: Unknown result type (might be due to invalid IL or missing references)
        //IL_0027: Unknown result type (might be due to invalid IL or missing references)
        Vector2 center = ((Entity)((ModItem)this).Item).Center;
        Color whiteSmoke = Color.WhiteSmoke;
        Lighting.AddLight(center, whiteSmoke.ToVector3() * 0.55f * Main.essScale);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(ModContent.BuffType<BlessingOfVitality>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient<AquaticCharm>(1).AddIngredient<IronboundBracelet>(1)
            .AddIngredient<LocationWarper>(1)
            .AddIngredient<PortableLifeSupport>(1)
            .AddIngredient(ItemID.ChlorophyteBar, 5)
            .AddTile<LivingBreweryTile>()
            .Register();
    }
}

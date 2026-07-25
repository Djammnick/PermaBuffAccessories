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

public class ShardOfUtility : ModItem
{
    public override void SetStaticDefaults()
    {
        Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 18, false));
        ItemID.Sets.AnimatesAsSoul[Item.type] = true;
        ItemID.Sets.ItemIconPulse[Item.type] = false;
        ItemID.Sets.ItemNoGravity[Item.type] = true;
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 26;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.maxStack = 1;
        Item.consumable = false;
        Item.accessory = true;
        Item.rare = ItemRarityID.Lime;
        Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void PostUpdate()
    {
        Vector2 center = Item.Center;
        Color whiteSmoke = Color.WhiteSmoke;
        Lighting.AddLight(center, ((Color)whiteSmoke).ToVector3() * 0.55f * Main.essScale);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(ModContent.BuffType<BlessingOfUtility>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient<DjamsGlasses>(1).AddIngredient<FourLeafClover>(1)
            .AddIngredient<HandheldDrill>(1)
            .AddIngredient<FishermansScanner>(1)
            .AddIngredient(ItemID.LifeFruit, 5)
            .AddTile<LivingBreweryTile>()
            .Register();
    }
}

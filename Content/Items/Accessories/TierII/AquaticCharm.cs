using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using DjamUtility.Content.Items.Accessories.TierI;
using Terraria.ModLoader;
using Terraria.ID;

namespace DjamUtility.Content.Items.Accessories.TierII;

public class AquaticCharm : ModItem
{
    public override void SetStaticDefaults()
    {
        
        // ((ModItem)this).DisplayName.SetDefault("Aquatic Charm");
        // ((ModItem)this).Tooltip.SetDefault("Grants greater mobility in water.\n'Like flying, but in water.'");
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
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(ModContent.BuffType<AquaticAbility>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient<AnkletOfFlippers>(1).AddIngredient<AnkletOfGills>(1)
            .AddIngredient<AnkletOfWaterWalking>(1)
            .AddIngredient(ItemID.Coral, 15)
            .AddIngredient(ItemID.WaterWalkingBoots, 1)
            .AddTile(TileID.AlchemyTable)
            .Register();
    }
}

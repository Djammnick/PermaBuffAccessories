using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Placeables;

public class DemoniteBrewery : ModItem
{
    public override void SetStaticDefaults()
    {
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.useStyle = ItemUseStyleID.Swing;
        Item.useTurn = true;
        Item.useAnimation = 15;
        Item.useTime = 10;
        Item.autoReuse = true;
        Item.consumable = true;
        Item.createTile = ModContent.TileType<DemoniteBreweryTile>();
        Item.width = 24;
        Item.height = 24;
        Item.rare = ItemRarityID.Green;
    }

    public override void AddRecipes()
    {
        CreateRecipe(1)
            .AddIngredient(ItemID.Bottle, 1)
            .AddIngredient(ItemID.IronAnvil, 1)
            .AddIngredient(ItemID.DemoniteBar, 15)
            .AddTile(TileID.Anvils)
            .Register();
        CreateRecipe(1)
            .AddIngredient(ItemID.Bottle, 1)
            .AddIngredient(ItemID.LeadAnvil, 1)
            .AddIngredient(ItemID.DemoniteBar, 15)
            .AddTile(TileID.Anvils)
            .Register();
    }
}

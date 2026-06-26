using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Placeables;

public class CrimtaneBrewery : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Crimtane Brewery");
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[((ModItem)this).Type] = 1;
    }

    public override void SetDefaults()
    {
        ((ModItem)this).Item.useStyle = 1;
        ((ModItem)this).Item.useTurn = true;
        ((ModItem)this).Item.useAnimation = 15;
        ((ModItem)this).Item.useTime = 10;
        ((ModItem)this).Item.autoReuse = true;
        ((ModItem)this).Item.consumable = true;
        ((ModItem)this).Item.createTile = ModContent.TileType<CrimtaneBreweryTile>();
        ((Entity)((ModItem)this).Item).width = 24;
        ((Entity)((ModItem)this).Item).height = 24;
        ((ModItem)this).Item.rare = 2;
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(31, 1).AddIngredient(35, 1)
            .AddIngredient(1257, 15)
            .AddTile(16)
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(31, 1).AddIngredient(716, 1)
            .AddIngredient(1257, 15)
            .AddTile(16)
            .Register();
    }
}

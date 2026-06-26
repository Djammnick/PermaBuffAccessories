using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Placeables;

public class LivingBrewery : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Living Brewery");
        // ((ModItem)this).Tooltip.SetDefault("Used to craft tier III potion accessories.");
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
        ((ModItem)this).Item.createTile = ModContent.TileType<LivingBreweryTile>();
        ((Entity)((ModItem)this).Item).width = 24;
        ((Entity)((ModItem)this).Item).height = 24;
        ((ModItem)this).Item.rare = 7;
    }
}

using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierI;

[AutoloadEquip(/*Could not decode attribute arguments.*/)]
public class CrownOfThorns : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Crown of Thorns");
        // ((ModItem)this).Tooltip.SetDefault("Applies the Thorns buff that lasts until taken off.\n'DMG UP (not really).'");
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[((ModItem)this).Type] = 1;
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
        ((ModItem)this).Item.rare = 2;
        ((ModItem)this).Item.value = Item.buyPrice(0, 0, 0, 0);
        ((ModItem)this).Item.vanity = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(14, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(301, 15).AddIngredient(264, 1)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(301, 15).AddIngredient(264, 1)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(301, 15).AddIngredient(715, 1)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(301, 15).AddIngredient(715, 1)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

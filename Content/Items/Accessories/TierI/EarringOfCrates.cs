using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierI;

public class EarringOfCrates : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Earring of Crates");
        // ((ModItem)this).Tooltip.SetDefault("Applies the Crate buff that lasts until taken off.\n'It seems like someone is fishing for the long haul...'");
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
        ((ModItem)this).Item.rare = 1;
        ((ModItem)this).Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(123, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(2356, 15).AddIngredient(2334, 3)
            .AddIngredient(2335, 3)
            .AddIngredient(2336, 3)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(2356, 15).AddIngredient(2334, 3)
            .AddIngredient(2335, 3)
            .AddIngredient(2336, 3)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(2356, 15).AddIngredient(3979, 3)
            .AddIngredient(3980, 3)
            .AddIngredient(3981, 3)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(2356, 15).AddIngredient(3979, 3)
            .AddIngredient(3980, 3)
            .AddIngredient(3981, 3)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

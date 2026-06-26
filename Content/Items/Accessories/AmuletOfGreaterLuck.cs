using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories;

public class AmuletOfGreaterLuck : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Amulet of Greater Luck");
        // ((ModItem)this).Tooltip.SetDefault("Bestows Greater Luck to the user.\n'All those pearls, for one small trinket...'");
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
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(257, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(4479, 15).AddIngredient(4412, 5)
            .AddIngredient(4413, 5)
            .AddIngredient(4414, 5)
            .AddIngredient(85, 1)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(4479, 15).AddIngredient(4412, 5)
            .AddIngredient(4413, 5)
            .AddIngredient(4414, 5)
            .AddIngredient(85, 1)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

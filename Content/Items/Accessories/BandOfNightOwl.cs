using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories;

public class BandOfNightOwl : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Band of Night Owl");
        // ((ModItem)this).Tooltip.SetDefault("Applies the Night Owl buff that lasts until taken off.\n'I've seen enough. I'm satisfied.'");
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
        player.AddBuff(12, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(299, 15).AddIngredient(4395, 1)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(299, 15).AddIngredient(4395, 1)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

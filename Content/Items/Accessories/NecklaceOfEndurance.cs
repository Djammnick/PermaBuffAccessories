using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories;

public class NecklaceOfEndurance : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Necklace of Endurance");
        // ((ModItem)this).Tooltip.SetDefault("Applies the Endurance buff that lasts until taken off.\n'Nanomachines, son.'");
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
        player.AddBuff(114, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(2346, 15).AddRecipeGroup(RecipeGroups.SilverBars, 5)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(2346, 15).AddRecipeGroup(RecipeGroups.SilverBars, 5)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

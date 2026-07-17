using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.DjamSpecifics;

public class RulesCard : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).Tooltip.SetDefault("Welcome to Pieselopadaka Utility!\nTo begin your journey, simply collect 15 of your favourite potion and some specific materials related to it.\nUsage of Recipe Browser is recommended, as some recipes may get complicated as you go.");
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
        ((ModItem)this).Item.rare = ItemRarityID.Green;
        ((ModItem)this).Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.Silk, 1).AddTile(TileID.DemonAltar)
            .Register();
    }
}

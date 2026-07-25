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
        Item.rare = ItemRarityID.Green;
        Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient(ItemID.Silk, 1).AddTile(TileID.DemonAltar)
            .Register();
    }
}

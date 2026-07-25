using DjamUtility.Content.Tiles;
using DjamUtility.Content.Items.Materials;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierI;

[AutoloadEquip(EquipType.Face)]
public class GogglesOfBuilding : ModItem
{
    public override void SetStaticDefaults()
    {
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 26;
        Item.useAnimation = 20;
        Item.useTime = 15;
        Item.maxStack = 1;
        Item.consumable = false;
        Item.accessory = true;
        Item.rare = ItemRarityID.Green;
        Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(BuffID.Builder, 10, true, false);
    }

    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient(ItemID.BuilderPotion, 15).AddRecipeGroup(RecipeGroups.IronBars, 5)
            .AddIngredient(ModContent.ItemType<WindWalkerCore>(), 5)
			.AddTile<DemoniteBreweryTile>()
            .Register();
        CreateRecipe(1).AddIngredient(ItemID.BuilderPotion, 15).AddRecipeGroup(RecipeGroupID.Wood, 100)
            .AddIngredient(ModContent.ItemType<WindWalkerCore>(), 5)
			.AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

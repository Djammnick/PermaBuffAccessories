using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierI;

public class EarringOfCrates : ModItem
{
    public override void SetStaticDefaults()
    {
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
        Item.rare = ItemRarityID.Blue;
        Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(BuffID.Crate, 10, true, false);
    }

    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient(ItemID.CratePotion, 15).AddIngredient(ItemID.WoodenCrate, 3)
            .AddIngredient(ItemID.IronCrate, 3)
            .AddIngredient(ItemID.GoldenCrate, 3)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        CreateRecipe(1).AddIngredient(ItemID.CratePotion, 15).AddIngredient(ItemID.WoodenCrate, 3)
            .AddIngredient(ItemID.IronCrate, 3)
            .AddIngredient(ItemID.GoldenCrate, 3)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
        CreateRecipe(1).AddIngredient(ItemID.CratePotion, 15).AddIngredient(ItemID.WoodenCrateHard, 3)
            .AddIngredient(ItemID.IronCrateHard, 3)
            .AddIngredient(ItemID.GoldenCrateHard, 3)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        CreateRecipe(1).AddIngredient(ItemID.CratePotion, 15).AddIngredient(ItemID.WoodenCrateHard, 3)
            .AddIngredient(ItemID.IronCrateHard, 3)
            .AddIngredient(ItemID.GoldenCrateHard, 3)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

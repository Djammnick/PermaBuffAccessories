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
        ((ModItem)this).Item.rare = ItemRarityID.Blue;
        ((ModItem)this).Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(BuffID.Crate, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.CratePotion, 15).AddIngredient(ItemID.WoodenCrate, 3)
            .AddIngredient(ItemID.IronCrate, 3)
            .AddIngredient(ItemID.GoldenCrate, 3)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.CratePotion, 15).AddIngredient(ItemID.WoodenCrate, 3)
            .AddIngredient(ItemID.IronCrate, 3)
            .AddIngredient(ItemID.GoldenCrate, 3)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.CratePotion, 15).AddIngredient(ItemID.WoodenCrateHard, 3)
            .AddIngredient(ItemID.IronCrateHard, 3)
            .AddIngredient(ItemID.GoldenCrateHard, 3)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.CratePotion, 15).AddIngredient(ItemID.WoodenCrateHard, 3)
            .AddIngredient(ItemID.IronCrateHard, 3)
            .AddIngredient(ItemID.GoldenCrateHard, 3)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

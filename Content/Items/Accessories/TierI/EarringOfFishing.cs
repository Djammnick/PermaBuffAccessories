using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierI;

public class EarringOfFishing : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Earring of Fishing");
        // ((ModItem)this).Tooltip.SetDefault("Applies the Fishing buff that lasts until taken off.\n'The earring of the Supreme Helper Minion.'");
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
        player.AddBuff(BuffID.Fishing, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.FishingPotion, 15).AddIngredient(ItemID.Bass, 3)
            .AddIngredient(ItemID.AtlanticCod, 3)
            .AddIngredient(ItemID.NeonTetra, 3)
            .AddIngredient(ItemID.Shrimp, 3)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.FishingPotion, 15).AddIngredient(ItemID.Bass, 3)
            .AddIngredient(ItemID.AtlanticCod, 3)
            .AddIngredient(ItemID.NeonTetra, 3)
            .AddIngredient(ItemID.Shrimp, 3)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

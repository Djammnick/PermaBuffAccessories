using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierI;

public class PendantOfCalming : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Pendant of Calming");
        // ((ModItem)this).Tooltip.SetDefault("Applies the Calm buff that lasts until taken off.\n'Free chill pills for everyone.'");
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
        player.AddBuff(BuffID.Calm, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.CalmingPotion, 15).AddIngredient(ItemID.Daybloom, 1)
            .AddIngredient(ItemID.Blinkroot, 1)
            .AddIngredient(ItemID.Waterleaf, 1)
            .AddIngredient(ItemID.Moonglow, 1)
            .AddIngredient(ItemID.Deathweed, 1)
            .AddIngredient(ItemID.Fireblossom, 1)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.CalmingPotion, 15).AddIngredient(ItemID.Daybloom, 1)
            .AddIngredient(ItemID.Blinkroot, 1)
            .AddIngredient(ItemID.Waterleaf, 1)
            .AddIngredient(ItemID.Moonglow, 1)
            .AddIngredient(ItemID.Deathweed, 1)
            .AddIngredient(ItemID.Fireblossom, 1)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

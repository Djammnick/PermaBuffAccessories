using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierI;

[AutoloadEquip(EquipType.Neck)]
public class PendantOfCalming : ModItem
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
        player.AddBuff(BuffID.Calm, 10, true, false);
    }

    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient(ItemID.CalmingPotion, 15).AddIngredient(ItemID.Daybloom, 1)
            .AddIngredient(ItemID.Blinkroot, 1)
            .AddIngredient(ItemID.Waterleaf, 1)
            .AddIngredient(ItemID.Moonglow, 1)
            .AddIngredient(ItemID.Deathweed, 1)
            .AddIngredient(ItemID.Fireblossom, 1)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        CreateRecipe(1).AddIngredient(ItemID.CalmingPotion, 15).AddIngredient(ItemID.Daybloom, 1)
            .AddIngredient(ItemID.Blinkroot, 1)
            .AddIngredient(ItemID.Waterleaf, 1)
            .AddIngredient(ItemID.Moonglow, 1)
            .AddIngredient(ItemID.Deathweed, 1)
            .AddIngredient(ItemID.Fireblossom, 1)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

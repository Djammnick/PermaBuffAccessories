using DjamUtility.Content.Tiles;
using DjamUtility.Content.Items.Materials;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierI;

[AutoloadEquip(EquipType.Neck)]
public class AmuletOfGreaterLuck : ModItem
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
        Item.rare = ItemRarityID.Green;
        Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(BuffID.Lucky, 10, true, false);
    }

    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient(ItemID.LuckPotionGreater, 15).AddIngredient(ItemID.WhitePearl, 5)
            .AddIngredient(ItemID.BlackPearl, 5)
            .AddIngredient(ItemID.PinkPearl, 5)
            .AddIngredient(ItemID.Chain, 1)
			.AddIngredient(ModContent.ItemType<WindWalkerCore>(), 5)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        CreateRecipe(1).AddIngredient(ItemID.LuckPotionGreater, 15).AddIngredient(ItemID.WhitePearl, 5)
            .AddIngredient(ItemID.BlackPearl, 5)
            .AddIngredient(ItemID.PinkPearl, 5)
            .AddIngredient(ItemID.Chain, 1)
			.AddIngredient(ModContent.ItemType<WindWalkerCore>(), 5)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

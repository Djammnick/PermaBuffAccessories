using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using DjamUtility.Content.Items.Accessories.TierI;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.ID;

namespace DjamUtility.Content.Items.Accessories.TierII;

[AutoloadEquip(EquipType.HandsOn, EquipType.HandsOff)]
public class RangersGlove : ModItem
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
        Item.rare = ItemRarityID.LightRed;
        Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(ModContent.BuffType<RangersProficiency>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient<ArcheryGlove>(1).AddIngredient<AmmoReservationPouch>(1)
            .AddIngredient(ItemID.ShadowScale, 10)
            .AddIngredient(ItemID.Leather, 10)
            .AddTile(TileID.AlchemyTable)
            .Register();
        CreateRecipe(1).AddIngredient<ArcheryGlove>(1).AddIngredient<AmmoReservationPouch>(1)
            .AddIngredient(ItemID.TissueSample, 10)
            .AddIngredient(ItemID.Leather, 10)
            .AddTile(TileID.AlchemyTable)
            .Register();
    }
}

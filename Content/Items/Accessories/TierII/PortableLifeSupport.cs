using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using DjamUtility.Content.Items.Accessories.TierI;
using Terraria.ModLoader;
using Terraria.ID;

namespace DjamUtility.Content.Items.Accessories.TierII;

public class PortableLifeSupport : ModItem
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
        player.AddBuff(ModContent.BuffType<LifeSupport>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        CreateRecipe(1).AddIngredient<NecklaceOfLifeforce>(1).AddIngredient<NecklaceOfRegeneration>(1)
            .AddIngredient<NecklaceOfHeartreach>(1)
            .AddIngredient(ItemID.LifeCrystal, 5)
            .AddIngredient(ItemID.Bone, 15)
            .AddIngredient(ItemID.ShadowScale, 15)
            .AddTile(TileID.AlchemyTable)
            .Register();
        CreateRecipe(1).AddIngredient<NecklaceOfLifeforce>(1).AddIngredient<NecklaceOfRegeneration>(1)
            .AddIngredient<NecklaceOfHeartreach>(1)
            .AddIngredient(ItemID.LifeCrystal, 5)
            .AddIngredient(ItemID.Bone, 15)
            .AddIngredient(ItemID.TissueSample, 15)
            .AddTile(TileID.AlchemyTable)
            .Register();
    }
}

using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using DjamUtility.Content.Items.Accessories.TierI;
using Terraria.ModLoader;
using Terraria.ID;

namespace DjamUtility.Content.Items.Accessories.TierII;

public class MuskyPerfumes : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Musky Perfumes");
        // ((ModItem)this).Tooltip.SetDefault("Makes you fall in love and smell badly.\n'Not related to any Elon.'");
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
        ((ModItem)this).Item.rare = ItemRarityID.LightRed;
        ((ModItem)this).Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(ModContent.BuffType<LovelyStench>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient<HopekScent>(1).AddIngredient<RingOfLove>(1)
            .AddIngredient(ItemID.JungleSpores, 15)
            .AddTile(TileID.AlchemyTable)
            .Register();
    }
}

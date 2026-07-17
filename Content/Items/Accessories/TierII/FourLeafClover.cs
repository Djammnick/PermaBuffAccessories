using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using DjamUtility.Content.Items.Accessories.TierI;
using Terraria.ModLoader;
using Terraria.ID;

namespace DjamUtility.Content.Items.Accessories.TierII;

public class FourLeafClover : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Four-leaf Clover");
        // ((ModItem)this).Tooltip.SetDefault("Ultimate lucky amulet. Grants luck that's hardly even imaginable.\n'Unique specimen, only for the truly lucky ones.'");
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
        player.AddBuff(ModContent.BuffType<SuperLucky>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient<AmuletOfGreaterLuck>(1).AddIngredient(ItemID.LuckPotionLesser, 15)
            .AddIngredient(ItemID.LuckPotion, 15)
            .AddIngredient(ItemID.GrassSeeds, 20)
            .AddTile(TileID.AlchemyTable)
            .Register();
    }
}

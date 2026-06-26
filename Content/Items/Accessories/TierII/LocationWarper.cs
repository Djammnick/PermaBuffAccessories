using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierII;

public class LocationWarper : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Location Warper");
        // ((ModItem)this).Tooltip.SetDefault("Increases movement speed, slows the fall and allows to invert gravity.\n'Seems anomalous.'");
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
        ((ModItem)this).Item.rare = 4;
        ((ModItem)this).Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(ModContent.BuffType<LocationInstability>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient<AnkletOfFeatherfall>(1).AddIngredient<BandOfGravityControl>(1)
            .AddIngredient<BandOfSwiftness>(1)
            .AddIngredient(181, 15)
            .AddTile(355)
            .Register();
    }
}

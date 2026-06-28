using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using DjamUtility.Content.Items.Accessories.TierI;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierII;

public class FishermansScanner : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Fisherman's Scanner");
        // ((ModItem)this).Tooltip.SetDefault("Increases your fishing power, chance to fish up crates and allows to see what's on your hook.\n'Desired by every fisherman.'");
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
        player.AddBuff(ModContent.BuffType<PotentBait>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient<EarringOfSonarVision>(1).AddIngredient<EarringOfFishing>(1)
            .AddIngredient<EarringOfCrates>(1)
            .AddIngredient(3118, 1)
            .AddIngredient(3084, 1)
            .AddTile(355)
            .Register();
    }
}

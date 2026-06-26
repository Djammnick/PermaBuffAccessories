using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierII;

public class SummonersCatalyst : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Summoner's Catalyst");
        // ((ModItem)this).Tooltip.SetDefault("Increases your minion slots by 2.\n'There is no such thing as too much companions.'");
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
        player.AddBuff(ModContent.BuffType<SummonersFocus>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient<NecklaceOfSummoning>(1).AddIngredient(2999, 1)
            .AddTile(355)
            .Register();
    }
}

using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using DjamUtility.Content.Items.Accessories.TierI;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierII;

public class IronboundBracelet : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Ironbound Bracelet");
        // ((ModItem)this).Tooltip.SetDefault("Protects you effectively. Even stronger against cold damage sources.\n'How is it more effective than a shield?'");
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
        player.AddBuff(ModContent.BuffType<HeavilyProtected>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient<NecklaceOfEndurance>(1).AddIngredient<NecklaceOfIronskin>(1)
            .AddIngredient<NecklaceOfWarmth>(1)
            .AddIngredient(147, 25)
            .AddTile(355)
            .Register();
    }
}

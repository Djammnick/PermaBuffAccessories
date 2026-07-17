using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using DjamUtility.Content.Items.Accessories.TierI;
using Terraria.ModLoader;
using Terraria.ID;

namespace DjamUtility.Content.Items.Accessories.TierII;

public class HellishCharm : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Hellish Charm");
        // ((ModItem)this).Tooltip.SetDefault("Grants you immunity to lava and creates a damaging fire aura.\n'Passed down with a hellish legacy.'");
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
        player.AddBuff(ModContent.BuffType<FieryInheritance>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient<BandOfInferno>(1).AddIngredient<NecklaceOfObsidianSkin>(1)
            .AddIngredient(ItemID.Hellstone, 20)
            .AddIngredient(ItemID.Meteorite, 10)
            .AddTile(TileID.AlchemyTable)
            .Register();
    }
}

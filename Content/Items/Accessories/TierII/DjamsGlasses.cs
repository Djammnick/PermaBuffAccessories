using DjamUtility.Content.Buffs;
using Terraria;
using Terraria.GameContent.Creative;
using DjamUtility.Content.Items.Accessories.TierI;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.ID;

namespace DjamUtility.Content.Items.Accessories.TierII;

[AutoloadEquip(EquipType.Face)]
public class DjamsGlasses : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Djam's Glasses");
        // ((ModItem)this).Tooltip.SetDefault("Allows you to see ores, creatures and dangers.\n'Thick as a bottle's den.'");
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
		((ModItem)this).Item.vanity = true;
        ((ModItem)this).Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(ModContent.BuffType<PerfectVision>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient<BandOfDangersense>(1).AddIngredient<HuntersCloak>(1)
            .AddIngredient<MonocleOfSpelunking>(1)
            .AddIngredient(ItemID.Bone, 15)
            .AddIngredient(ItemID.Glass, 60)
            .AddTile(TileID.AlchemyTable)
            .Register();
    }
}

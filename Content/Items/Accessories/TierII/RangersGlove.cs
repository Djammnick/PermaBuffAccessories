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
        // ((ModItem)this).DisplayName.SetDefault("Ranger's Glove");
        // ((ModItem)this).Tooltip.SetDefault("Increases your archery power and decreases ammo consumption.\n'Forged in the depths of Hopek's basement.'");
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
        player.AddBuff(ModContent.BuffType<RangersProficiency>(), 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient<ArcheryGlove>(1).AddIngredient<GauntletOfAmmoReservation>(1)
            .AddIngredient(86, 10)
            .AddIngredient(259, 10)
            .AddTile(355)
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient<ArcheryGlove>(1).AddIngredient<GauntletOfAmmoReservation>(1)
            .AddIngredient(1329, 10)
            .AddIngredient(259, 10)
            .AddTile(355)
            .Register();
    }
}

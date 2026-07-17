using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierI;

[AutoloadEquip(EquipType.HandsOn)]
public class BandOfSwiftness : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Band of Swiftness");
        // ((ModItem)this).Tooltip.SetDefault("Applies the Swiftness buff that lasts until taken off.\n'Gotta go fast!'");
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
        ((ModItem)this).Item.rare = ItemRarityID.Blue;
        ((ModItem)this).Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(BuffID.Swiftness, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.SwiftnessPotion, 15).AddIngredient(ItemID.HermesBoots, 1)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.SwiftnessPotion, 15).AddIngredient(ItemID.HermesBoots, 1)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.ID;

namespace DjamUtility.Content.Items.Accessories.TierI;

[AutoloadEquip(EquipType.Back, EquipType.Front)]
public class HuntersCloak : ModItem
{
    public override void SetStaticDefaults()
    {
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
        ((ModItem)this).Item.rare = ItemRarityID.Green;
        ((ModItem)this).Item.value = Item.buyPrice(0, 0, 0, 0);
        ((ModItem)this).Item.vanity = true;
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(BuffID.Hunter, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.HunterPotion, 5).AddIngredient(ItemID.Silk, 15)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.HunterPotion, 5).AddIngredient(ItemID.Silk, 15)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

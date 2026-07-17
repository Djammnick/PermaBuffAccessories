using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierI;

public class AmuletOfGreaterLuck : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Amulet of Greater Luck");
        // ((ModItem)this).Tooltip.SetDefault("Bestows Greater Luck to the user.\n'All those pearls, for one small trinket...'");
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
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(BuffID.Lucky, 10, true, false);
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.LuckPotionGreater, 15).AddIngredient(ItemID.WhitePearl, 5)
            .AddIngredient(ItemID.BlackPearl, 5)
            .AddIngredient(ItemID.PinkPearl, 5)
            .AddIngredient(ItemID.Chain, 1)
            .AddTile<DemoniteBreweryTile>()
            .Register();
        ((ModItem)this).CreateRecipe(1).AddIngredient(ItemID.LuckPotionGreater, 15).AddIngredient(ItemID.WhitePearl, 5)
            .AddIngredient(ItemID.BlackPearl, 5)
            .AddIngredient(ItemID.PinkPearl, 5)
            .AddIngredient(ItemID.Chain, 1)
            .AddTile<CrimtaneBreweryTile>()
            .Register();
    }
}

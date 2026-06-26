using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Placeables;

public class PrakMusicBox : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Music Box (Prak)");
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[((ModItem)this).Type] = 1;
        MusicLoader.AddMusicBox(((ModType)this).Mod, MusicLoader.GetMusicSlot(((ModType)this).Mod, "Assets/Music/Prak-Meme-Geometry-Korona"), ModContent.ItemType<PrakMusicBox>(), ModContent.TileType<PrakMusicBoxTile>(), 0);
    }

    public override void SetDefaults()
    {
        ((ModItem)this).Item.useStyle = 1;
        ((ModItem)this).Item.useTurn = true;
        ((ModItem)this).Item.useAnimation = 15;
        ((ModItem)this).Item.useTime = 10;
        ((ModItem)this).Item.autoReuse = true;
        ((ModItem)this).Item.consumable = true;
        ((ModItem)this).Item.createTile = ModContent.TileType<PrakMusicBoxTile>();
        ((Entity)((ModItem)this).Item).width = 24;
        ((Entity)((ModItem)this).Item).height = 24;
        ((ModItem)this).Item.rare = 4;
        ((ModItem)this).Item.value = 100000;
    }

    public override void AddRecipes()
    {
        ((ModItem)this).CreateRecipe(1).AddIngredient(2, 999).Register();
    }
}

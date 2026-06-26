using DjamUtility.Content.Items.Placeables;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DjamUtility.Content.Tiles;

public class LivingBreweryTile : ModTile
{
    public override void SetStaticDefaults()
    {
        //IL_0030: Unknown result type (might be due to invalid IL or missing references)
        //IL_007e: Unknown result type (might be due to invalid IL or missing references)
        Main.tileFrameImportant[((ModBlockType)this).Type] = true;
        Main.tileObsidianKill[((ModBlockType)this).Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
        TileObjectData.newTile.Origin = new Point16(0, 1);
        TileObjectData.newTile.LavaDeath = false;
        TileObjectData.newTile.DrawYOffset = 2;
        TileObjectData.addTile((int)((ModBlockType)this).Type);
        LocalizedText val = ((ModBlockType)this).CreateMapEntryName();
        // val.SetDefault("Living Brewery");
        ((ModTile)this).AddMapEntry(new Color(200, 200, 200), val);
    }

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        //IL_0003: Unknown result type (might be due to invalid IL or missing references)
        //IL_0023: Expected O, but got Unknown
        Item.NewItem((IEntitySource)new EntitySource_TileBreak(i, j, (string)null), i * 16, j * 16, 16, 48, ModContent.ItemType<LivingBrewery>(), 1, false, 0, false, false);
    }

    public override void MouseOver(int i, int j)
    {
        Player localPlayer = Main.LocalPlayer;
        localPlayer.noThrow = 2;
        localPlayer.cursorItemIconEnabled = true;
        localPlayer.cursorItemIconID = ModContent.ItemType<LivingBrewery>();
    }
}

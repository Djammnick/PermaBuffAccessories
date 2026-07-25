using DjamUtility.Content.Items.Placeables;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace DjamUtility.Content.Tiles;

public class CrimtaneBreweryTile : ModTile
{
    public override void SetStaticDefaults()
    {
        //IL_0030: Unknown result type (might be due to invalid IL or missing references)
        //IL_007e: Unknown result type (might be due to invalid IL or missing references)
        Main.tileFrameImportant[Type] = true;
        Main.tileObsidianKill[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
        TileObjectData.newTile.Origin = new Point16(0, 1);
        TileObjectData.newTile.LavaDeath = false;
        TileObjectData.newTile.DrawYOffset = 2;
        TileObjectData.addTile(Type);
        LocalizedText val = CreateMapEntryName();
        // val.SetDefault("Brewery");
        AddMapEntry(new Color(200, 200, 200), val);
		AnimationFrameHeight = 54;
    }
	public override void AnimateTile(ref int frame, ref int frameCounter)
	{
		frameCounter++;
		if (frameCounter >= 4)
		{
			
			frameCounter = 0;
			frame = ++frame %8;
		}
	}

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        //IL_0003: Unknown result type (might be due to invalid IL or missing references)
        //IL_0023: Expected O, but got Unknown
        Item.NewItem(new EntitySource_TileBreak(i, j, null), i * 16, j * 16, 16, 54, ModContent.ItemType<CrimtaneBrewery>(), 1, false, 0, false, false);
    }

    public override void MouseOver(int i, int j)
    {
        Player localPlayer = Main.LocalPlayer;
        localPlayer.noThrow = 2;
        localPlayer.cursorItemIconEnabled = true;
        localPlayer.cursorItemIconID = ModContent.ItemType<CrimtaneBrewery>();
    }
}

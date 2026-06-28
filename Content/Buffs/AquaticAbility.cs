using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class AquaticAbility : ModBuff
{
    public override void SetStaticDefaults()
    {
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.waterWalk = true;
        player.gills = true;
        player.accFlipper = true;
        player.buffImmune[BuffID.Gills] = true;
        player.buffImmune[BuffID.WaterWalking] = true;
        player.buffImmune[BuffID.Flipper] = true;
    }
}

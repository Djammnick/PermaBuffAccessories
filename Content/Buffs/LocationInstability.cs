using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class LocationInstability : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Location Instability");
        // ((ModBuff)this).Description.SetDefault("You seem to have anomalous motoric properties.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.runAcceleration += 0.25f;
        player.gravControl = true;
        player.slowFall = true;
        player.buffImmune[3] = true;
        player.buffImmune[18] = true;
        player.buffImmune[8] = true;
    }
}

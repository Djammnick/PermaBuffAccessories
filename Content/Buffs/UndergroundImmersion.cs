using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class UndergroundImmersion : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Undergrond Immersion");
        // ((ModBuff)this).Description.SetDefault("Control the terrain and see the way.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        //IL_001a: Unknown result type (might be due to invalid IL or missing references)
        player.pickSpeed += 0.25f;
        player.nightVision = true;
        Lighting.AddLight(((Entity)player).position, 0);
        player.tileSpeed += 0.25f;
        player.wallSpeed += 0.25f;
        player.buffImmune[11] = true;
        player.buffImmune[12] = true;
        player.buffImmune[104] = true;
        player.buffImmune[107] = true;
    }
}

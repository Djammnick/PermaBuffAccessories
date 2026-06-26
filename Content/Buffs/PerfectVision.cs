using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class PerfectVision : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Perfect Vision");
        // ((ModBuff)this).Description.SetDefault("I can see everything!");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.dangerSense = true;
        player.findTreasure = true;
        player.detectCreature = true;
        player.buffImmune[17] = true;
        player.buffImmune[9] = true;
        player.buffImmune[111] = true;
    }
}

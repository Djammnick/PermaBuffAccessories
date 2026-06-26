using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class HeavilyProtected : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Heavily Protected");
        // ((ModBuff)this).Description.SetDefault("Tougher than steel.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.statDefense += 8;
        player.resistCold = true;
        player.endurance = 10f;
        player.buffImmune[5] = true;
        player.buffImmune[114] = true;
        player.buffImmune[124] = true;
    }
}

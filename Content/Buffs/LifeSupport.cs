using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class LifeSupport : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Life Support");
        // ((ModBuff)this).Description.SetDefault("Your vitals are under control.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.lifeMagnet = true;
        player.lifeRegen += 2;
        player.statLifeMax2 += player.statLifeMax2 / 5;
        player.buffImmune[2] = true;
        player.buffImmune[105] = true;
        player.buffImmune[113] = true;
    }
}

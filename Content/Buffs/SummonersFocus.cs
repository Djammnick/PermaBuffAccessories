using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class SummonersFocus : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Summoner's Focus");
        // ((ModBuff)this).Description.SetDefault("The more, the merrier.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.maxMinions += 2;
        player.buffImmune[110] = true;
        player.buffImmune[150] = true;
    }
}

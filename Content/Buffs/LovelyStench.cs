using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class LovelyStench : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Lovely Stench");
        // ((ModBuff)this).Description.SetDefault("You are still in love, but now you smell horribly.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.stinky = true;
        player.loveStruck = true;
        player.buffImmune[119] = true;
        player.buffImmune[120] = true;
    }
}

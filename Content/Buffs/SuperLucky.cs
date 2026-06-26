using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class SuperLucky : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Super Lucky!");
        // ((ModBuff)this).Description.SetDefault("More luck you could ever imagine.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.luck += 0.5f;
        player.buffImmune[257] = true;
    }
}

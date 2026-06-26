using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class FieryInheritance : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Fiery Inheritance");
        // ((ModBuff)this).Description.SetDefault("Be one with the flames.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.inferno = true;
        player.lavaImmune = true;
        player.buffImmune[67] = true;
        player.buffImmune[24] = true;
        player.buffImmune[1] = true;
        player.buffImmune[116] = true;
    }
}

using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class AquaticAbility : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Aquatic Ability");
        // ((ModBuff)this).Description.SetDefault("Mastery of the waters.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.waterWalk = true;
        player.gills = true;
        player.accFlipper = true;
        player.buffImmune[4] = true;
        player.buffImmune[15] = true;
        player.buffImmune[109] = true;
    }
}

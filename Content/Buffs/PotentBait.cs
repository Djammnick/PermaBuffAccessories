using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class PotentBait : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Potent Bait");
        // ((ModBuff)this).Description.SetDefault("All the fish want to bite your hook now.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.sonarPotion = true;
        player.cratePotion = true;
        player.fishingSkill += 15;
        player.buffImmune[122] = true;
        player.buffImmune[123] = true;
        player.buffImmune[121] = true;
    }
}

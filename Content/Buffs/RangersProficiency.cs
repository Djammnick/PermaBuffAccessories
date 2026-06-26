using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class RangersProficiency : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Ranger's Proficiency");
        // ((ModBuff)this).Description.SetDefault("Your Ranger skills are elite.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.archery = true;
        player.ammoPotion = true;
        player.buffImmune[16] = true;
        player.buffImmune[112] = true;
    }
}

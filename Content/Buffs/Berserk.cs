using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class Berserk : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Berserk!");
        // ((ModBuff)this).Description.SetDefault("Give in to your fury.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        //IL_000c: Unknown result type (might be due to invalid IL or missing references)
        //IL_0016: Unknown result type (might be due to invalid IL or missing references)
        //IL_001b: Unknown result type (might be due to invalid IL or missing references)
        //IL_004b: Unknown result type (might be due to invalid IL or missing references)
        //IL_0055: Unknown result type (might be due to invalid IL or missing references)
        //IL_005a: Unknown result type (might be due to invalid IL or missing references)
        ref StatModifier damage = ref player.GetDamage(DamageClass.Generic);
        damage += 0.1f;
        player.GetCritChance(DamageClass.Generic) += 10f;
        player.thorns = 1f;
        ref StatModifier knockback = ref player.GetKnockback(DamageClass.Generic);
        knockback += 0.5f;
        player.buffImmune[117] = true;
        player.buffImmune[115] = true;
        player.buffImmune[108] = true;
        player.buffImmune[14] = true;
    }
}

using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class BlessingOfDestruction : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Blessing of Destruction");
        // ((ModBuff)this).Description.SetDefault("Your might is greater than all.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        //IL_000c: Unknown result type (might be due to invalid IL or missing references)
        //IL_0016: Unknown result type (might be due to invalid IL or missing references)
        //IL_001b: Unknown result type (might be due to invalid IL or missing references)
        //IL_0045: Unknown result type (might be due to invalid IL or missing references)
        //IL_004f: Unknown result type (might be due to invalid IL or missing references)
        //IL_0054: Unknown result type (might be due to invalid IL or missing references)
        //IL_0084: Unknown result type (might be due to invalid IL or missing references)
        //IL_008e: Unknown result type (might be due to invalid IL or missing references)
        //IL_0093: Unknown result type (might be due to invalid IL or missing references)
        ref StatModifier damage = ref player.GetDamage(DamageClass.Magic);
        damage += 0.2f;
        player.manaRegenBuff = true;
        player.buffImmune[6] = true;
        player.buffImmune[7] = true;
        ref StatModifier damage2 = ref player.GetDamage(DamageClass.Generic);
        damage2 += 0.1f;
        player.GetCritChance(DamageClass.Generic) += 10f;
        player.thorns = 1f;
        ref StatModifier knockback = ref player.GetKnockback(DamageClass.Generic);
        knockback += 0.5f;
        player.buffImmune[117] = true;
        player.buffImmune[115] = true;
        player.buffImmune[108] = true;
        player.buffImmune[14] = true;
        player.inferno = true;
        player.lavaImmune = true;
        player.buffImmune[67] = true;
        player.buffImmune[24] = true;
        player.buffImmune[1] = true;
        player.buffImmune[116] = true;
        player.maxMinions += 2;
        player.buffImmune[110] = true;
        player.buffImmune[150] = true;
        player.buffImmune[ModContent.BuffType<WonderfulArcana>()] = true;
        player.buffImmune[ModContent.BuffType<Berserk>()] = true;
        player.buffImmune[ModContent.BuffType<FieryInheritance>()] = true;
        player.buffImmune[ModContent.BuffType<SummonersFocus>()] = true;
    }
}

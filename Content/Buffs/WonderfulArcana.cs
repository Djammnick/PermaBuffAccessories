using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class WonderfulArcana : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Wonderful Arcana");
        // ((ModBuff)this).Description.SetDefault("The potency of your magic is greatly increased.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        //IL_0013: Unknown result type (might be due to invalid IL or missing references)
        //IL_001d: Unknown result type (might be due to invalid IL or missing references)
        //IL_0022: Unknown result type (might be due to invalid IL or missing references)
        player.waterWalk = true;
        ref StatModifier damage = ref player.GetDamage(DamageClass.Magic);
        damage += 0.2f;
        player.manaRegenBuff = true;
        player.buffImmune[6] = true;
        player.buffImmune[7] = true;
    }
}

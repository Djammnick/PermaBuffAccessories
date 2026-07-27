using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class Permabuff : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Blessing of Pieselopadaka");
        // ((ModBuff)this).Description.SetDefault("The power of Pieselopadaka is at your hands.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        player.waterWalk = true;
        player.gills = true;
        player.accFlipper = true;
        player.buffImmune[4] = true;
        player.buffImmune[15] = true;
        player.buffImmune[109] = true;
        player.statDefense += 8;
        player.resistCold = true;
        player.endurance = 10f;
        player.buffImmune[5] = true;
        player.buffImmune[114] = true;
        player.buffImmune[124] = true;
        player.runAcceleration += 0.25f;
        player.gravControl = true;
        player.slowFall = true;
        player.buffImmune[3] = true;
        player.buffImmune[18] = true;
        player.buffImmune[8] = true;
        player.lifeMagnet = true;
        player.lifeRegen += 2;
        player.statLifeMax2 += player.statLifeMax2 / 5;
        player.buffImmune[2] = true;
        player.buffImmune[105] = true;
        player.buffImmune[113] = true;
        player.buffImmune[ModContent.BuffType<AquaticAbility>()] = true;
        player.buffImmune[ModContent.BuffType<HeavilyProtected>()] = true;
        player.buffImmune[ModContent.BuffType<LocationInstability>()] = true;
        player.buffImmune[ModContent.BuffType<LifeSupport>()] = true;
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
        player.dangerSense = true;
        player.findTreasure = true;
        player.detectCreature = true;
        player.buffImmune[17] = true;
        player.buffImmune[9] = true;
        player.buffImmune[111] = true;
        player.luck += 0.5f;
        player.buffImmune[257] = true;
        player.pickSpeed += 0.25f;
        player.nightVision = true;
        Lighting.AddLight(player.position, 0);
        player.tileSpeed += 0.25f;
        player.wallSpeed += 0.25f;
        player.buffImmune[11] = true;
        player.buffImmune[12] = true;
        player.buffImmune[104] = true;
        player.buffImmune[107] = true;
        player.sonarPotion = true;
        player.cratePotion = true;
        player.fishingSkill += 15;
        player.buffImmune[122] = true;
        player.buffImmune[123] = true;
        player.buffImmune[121] = true;
        player.buffImmune[ModContent.BuffType<PerfectVision>()] = true;
        player.buffImmune[ModContent.BuffType<SuperLucky>()] = true;
        player.buffImmune[ModContent.BuffType<UndergroundImmersion>()] = true;
        player.buffImmune[ModContent.BuffType<PotentBait>()] = true;
        player.buffImmune[ModContent.BuffType<BlessingOfVitality>()] = true;
        player.buffImmune[ModContent.BuffType<BlessingOfUtility>()] = true;
        player.buffImmune[ModContent.BuffType<BlessingOfDestruction>()] = true;
    }
}

using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class BlessingOfVitality : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Blessing of Vitality");
        // ((ModBuff)this).Description.SetDefault("Your inner power is immense.");
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
    }
}

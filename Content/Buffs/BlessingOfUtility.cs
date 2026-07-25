using Terraria;
using Terraria.ModLoader;

namespace DjamUtility.Content.Buffs;

public class BlessingOfUtility : ModBuff
{
    public override void SetStaticDefaults()
    {
        // ((ModBuff)this).DisplayName.SetDefault("Blessing of Utility");
        // ((ModBuff)this).Description.SetDefault("Your possibilities are countless.");
    }

    public override void Update(Player player, ref int buffIndex)
    {
        //IL_006c: Unknown result type (might be due to invalid IL or missing references)
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
    }
}

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Microsoft.Xna.Framework;
using DjamUtility.Content.NPCs.Enemies;
using DjamUtility.Content.Items.Materials;
using Terraria.GameContent.ItemDropRules;

namespace DjamUtility.Content.NPCs.Enemies
{
    public class WindWalker : ModNPC
    {
        public bool IsDeflecting = false;
		public int DeflectTimer = 0;
		
		public override void SetStaticDefaults()
        {
            Main.npcFrameCount[Type] = 10;
        }

        public override void SetDefaults()
        {
            NPC.width = 21;
            NPC.height = 26;
            NPC.damage = 20;
            NPC.defense = 8;
            NPC.lifeMax = 140;
            NPC.HitSound = SoundID.NPCHit30;
            NPC.DeathSound = SoundID.NPCDeath33;
            NPC.knockBackResist = 0.6f;
            NPC.aiStyle = 14;
            AnimationType = NPCID.Harpy;
			NPC.noGravity = true;
			NPC.friendly = false;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface,
                new FlavorTextBestiaryInfoElement("example")
            });
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.Materials.WindWalkerCore>(), 2));
        }
		public override void AI ()
		{
		base.AI();
		DeflectTimer++;
		if (DeflectTimer >= 360)
		{
			IsDeflecting = !IsDeflecting;
			DeflectTimer = 0;
		}
		}
		public override void ModifyHitByProjectile(Projectile projectile, ref NPC.HitModifiers modifiers)
		{ 
		if (IsDeflecting)
		    {
				modifiers.FinalDamage *= 0;
			    projectile.hostile = true;
			    projectile.friendly = false;
			   projectile.velocity = -projectile.velocity;
		    }
		}
		
		public override void ModifyHitByItem(Player player, Item item, ref NPC.HitModifiers modifiers)
		{
			if (IsDeflecting)
			{
				modifiers.FinalDamage *= 0;
			}
		}
	}
}
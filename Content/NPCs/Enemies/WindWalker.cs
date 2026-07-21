using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Microsoft.Xna.Framework;
using DjamUtility.Content.NPCs.Enemies;
using DjamUtility.Content.Items.Materials;
using Terraria.GameContent.ItemDropRules;
//using Terraria.Chat;

namespace DjamUtility.Content.NPCs.Enemies
{
    public class WindWalker : ModNPC
    {
        private bool IsDeflecting = false;
		private int DeflectTimer = 0;
		
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
            NPC.aiStyle = NPCAIStyleID.Bat;
            AnimationType = NPCID.Harpy;
			NPC.noGravity = true;
			NPC.friendly = false;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
			Player player = spawnInfo.Player;
			if(player.ZoneNormalSpace && NPC.downedBoss1)
			{
				return 1f;
			}
			return 0;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[]
            {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface,
                new FlavorTextBestiaryInfoElement("A powerful spirit of an ancient sorcerer. Rules over the high skies.")
            });
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.Materials.WindWalkerCore>(), 2, 1, 2));
        }
		public override void AI()
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
			}
		}

        public override void OnHitByProjectile(Projectile projectile, NPC.HitInfo hit, int damageDone)
        {
			if(!IsDeflecting)
			{
				return;
			}

            int att = projectile.owner;
			// Main.NewText($"Owner: {att}");
			if(att < 0 || att > Main.maxPlayers)
			{
				return;
			}

			Player targetPlayer = Main.player[att];

			Vector2 direction = targetPlayer.Center - NPC.Center;

			direction.SafeNormalize(-projectile.velocity);
			float speed = projectile.velocity.Length();

			int deflectedProjectileId = Projectile.NewProjectile(
				NPC.GetSource_FromAI(), // spawn source
				NPC.Center, // position
				direction * speed, // velocity
				projectile.type,
				projectile.damage / 2,
				projectile.knockBack,
				att
			);
			Projectile deflectedProjectile = Main.projectile[deflectedProjectileId];
			deflectedProjectile.friendly = false;
			deflectedProjectile.hostile = true;
			deflectedProjectile.netUpdate = true;

			projectile.Kill();
        }
		
		public override void ModifyHitByItem(Player player, Item item, ref NPC.HitModifiers modifiers)
		{
			if (IsDeflecting)
			{
				modifiers.FinalDamage *= 0;
			}
		}

		const float rotationSpeed = 0.1f;
		public override void PostAI()
		{
			if (!IsDeflecting)
				return;
			
			float angle = Main.GameUpdateCount * rotationSpeed;
			Lighting.AddLight(
            	NPC.Center,
            	0.2f,
           		0.5f,
            	0.8f
        	);

			int dustCount = 4;
			for (int i = 0; i < dustCount; i++)
			{
				float currentAngle = angle + i * 2 * MathHelper.Pi / dustCount;
				Vector2 offset = currentAngle.ToRotationVector2() * 25f;

				Dust dust = Dust.NewDustPerfect(
					NPC.Center + offset,
					DustID.Cloud
				);

				dust.noGravity = true;
				dust.scale = 0.8f;
			}
		}
	}
}
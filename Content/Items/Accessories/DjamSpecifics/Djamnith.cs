using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.DjamSpecifics
{
	public class Djamnith : ModItem
	{
        public override string Texture => $"Terraria/Images/Item_{ItemID.Zenith}";
		public override void SetDefaults() {
			Item.width = 40;
			Item.height = 40;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.autoReuse = true;
			Item.useTurn = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 5;
			Item.knockBack = 4;

			Item.rare = ItemRarityID.Red;
			Item.UseSound = SoundID.Item1;
		}

		public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone) {
			target.AddBuff(BuffID.Confused, 300);
		}

		public override bool MeleePrefix() => true;
	}
}
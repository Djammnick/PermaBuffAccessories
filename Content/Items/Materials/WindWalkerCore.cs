using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using Terraria.ID;

namespace DjamUtility.Content.Items.Materials
{
    public class WindWalkerCore : ModItem
    {
        public override void SetStaticDefaults()
        {
            ItemID.Sets.ItemNoGravity[Type] = true;
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 50;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.maxStack = 9999;
            Item.consumable = false;
            Item.rare = 2;
            Item.value = Item.buyPrice(0, 0, 0, 0);
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(Item.Center, 0.0f, 0.5f, 0.5f);
        }
    }
}
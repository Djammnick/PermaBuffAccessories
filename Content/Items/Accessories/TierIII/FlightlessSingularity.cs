using DjamUtility.Content.Buffs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.TierIII;

public class FlightlessSingularity : ModItem
{
    public override void SetStaticDefaults()
    {
        Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(5, 18, false));
        ItemID.Sets.AnimatesAsSoul[Item.type] = true;
        ItemID.Sets.ItemIconPulse[Item.type] = false;
        ItemID.Sets.ItemNoGravity[Item.type] = true;
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.width = 20;
        Item.height = 26;
        Item.useAnimation = 15;
        Item.useTime = 15;
        Item.maxStack = 1;
        Item.consumable = false;
        Item.accessory = true;
        Item.rare = ItemRarityID.Lime;
        Item.value = Item.buyPrice(0, 0, 0, 0);
    }

    public override void RightClick(Player player)
    {
        IEntitySource source_OpenItem = player.GetSource_OpenItem(Type, null);
        player.QuickSpawnItem(source_OpenItem, ModContent.ItemType<FlightlessSingularity>(), 1);
    }

    public override void PostUpdate()
    {
        Vector2 center = Item.Center;
        Color whiteSmoke = Color.WhiteSmoke;
        Lighting.AddLight(center, ((Color)whiteSmoke).ToVector3() * 0.55f * Main.essScale);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(ModContent.BuffType<FlightlessPermabuff>(), 10, true, false);
    }
}

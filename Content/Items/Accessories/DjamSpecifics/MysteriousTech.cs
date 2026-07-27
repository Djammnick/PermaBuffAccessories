using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.DjamSpecifics;

[AutoloadEquip(EquipType.Balloon)]
public class MysteriousTech : ModItem
{
    public override void SetStaticDefaults()
    {
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
    }

    public override void SetDefaults()
    {
        Item.width = 22;
        Item.height = 28;
        Item.accessory = true;
        Item.rare = ItemRarityID.Expert;
        Item.value = Item.sellPrice(0, 0, 0, 0);
        Item.vanity = true;
        Item.maxStack = 1;
    }

    public override bool CanRightClick()
    {
        return true;
    }

    public override void RightClick(Player player)
    {
        IEntitySource source_OpenItem = player.GetSource_OpenItem(Type, null);
        player.QuickSpawnItem(source_OpenItem, ModContent.ItemType<MysteriousTech>(), 1);
    }

    public override void UpdateAccessory(Player player, bool hideVisual)
    {
        player.AddBuff(BuffID.Puppy, 10, true, false);
        player.AddBuff(BuffID.Lucky, 650000, true, false);
    }

    public override void UpdateVanity(Player player)
    {
        player.AddBuff(BuffID.Puppy, 10, true, false);
    }
}

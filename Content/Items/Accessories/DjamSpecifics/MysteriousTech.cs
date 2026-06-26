using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Content.Items.Accessories.DjamSpecifics;

[AutoloadEquip(/*Could not decode attribute arguments.*/)]
public class MysteriousTech : ModItem
{
    public override void SetStaticDefaults()
    {
        // ((ModItem)this).DisplayName.SetDefault("Djammnick's Control Pad: Inactive");
        // ((ModItem)this).Tooltip.SetDefault("'What does it even do...?'");
        CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[((ModItem)this).Type] = 1;
    }

    public override void SetDefaults()
    {
        ((Entity)((ModItem)this).Item).width = 22;
        ((Entity)((ModItem)this).Item).height = 28;
        ((ModItem)this).Item.accessory = true;
        ((ModItem)this).Item.rare = ItemRarityID.Expert;
        ((ModItem)this).Item.value = Item.sellPrice(0, 0, 0, 0);
        ((ModItem)this).Item.vanity = true;
        ((ModItem)this).Item.maxStack = 1;
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

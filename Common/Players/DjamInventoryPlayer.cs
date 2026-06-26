using System.Collections.Generic;
using DjamUtility.Content.Items.Accessories.DjamSpecifics;
using DjamUtility.Content.Items.Placeables;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Common.Players;

public class DjamInventoryPlayer : ModPlayer
{
    public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)/* tModPorter Suggestion: Return an Item array to add to the players starting items. Use ModifyStartingInventory for modifying them if needed */
    {
        if (!mediumCoreDeath)
        {
            if (!Player.name.Contains("Prak"))
            {
                if (!Player.name.Contains("Djam"))
                {
                    return (IEnumerable<Item>)(object)new Item[1]
                    {
                        new Item(ModContent.ItemType<RulesCard>(), 1, 0)
                    };
                }
                return (IEnumerable<Item>)(object)new Item[1]
                {
                    new Item(ModContent.ItemType<MysteriousTech>(), 1, 0)
                };
            }
            return (IEnumerable<Item>)(object)new Item[1]
            {
                new Item(ModContent.ItemType<PrakMusicBox>(), 1, 0)
            };
        }
        return (IEnumerable<Item>)(object)new Item[1]
        {
            new Item(188, 1, 0)
        };
    }

    public override void ModifyStartingInventory(IReadOnlyDictionary<string, List<Item>> itemsByMod, bool mediumCoreDeath)
    {
        itemsByMod["Terraria"].RemoveAll((Item item) => item.type == ItemID.IronAxe);
    }
}

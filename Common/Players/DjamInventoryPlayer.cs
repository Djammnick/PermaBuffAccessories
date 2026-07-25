using System;
using System.Collections.Generic;
using DjamUtility.Content.Items.Accessories.DjamSpecifics;
using DjamUtility.Content.Items.Placeables;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Common.Players;

public class DjamInventoryPlayer : ModPlayer
{
    public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
    {
        List<Item> additionalInventory = [];
        if(!mediumCoreDeath)
        {
            additionalInventory.Add(new Item(ModContent.ItemType<RulesCard>(), 1, 0));
            if(Player.name.Contains("Djam"))
            {
                additionalInventory.Add(new Item(ModContent.ItemType<MysteriousTech>(), 1, 0));
            }
            /*if(Player.name.Contains("Prak"))
            {
                additionalInventory.Add(new Item(ModContent.ItemType<PrakMusicBox>(), 1, 0));
            }*/
        }
        return additionalInventory;
    }

    public override void ModifyStartingInventory(IReadOnlyDictionary<string, List<Item>> itemsByMod, bool mediumCoreDeath)
    {
        if(Player.name.Contains("Djam"))
        {
            foreach(Item item in itemsByMod["Terraria"])
            {
                if(item.type == ItemID.CopperShortsword)
                {
                    item.SetDefaults(ModContent.ItemType<Djamnith>());
                }
            }
        }
    }
}

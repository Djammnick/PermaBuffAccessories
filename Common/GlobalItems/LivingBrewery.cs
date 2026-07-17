using DjamUtility.Content.Items.Placeables;
using DjamUtility.Content.Tiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace DjamUtility.Common.GlobalItems;

public class LivingBreweryNPCLoot : GlobalNPC
{
    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
    {
        if (npc.type == NPCID.Plantera)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<LivingBrewery>()));
        }
    }
}
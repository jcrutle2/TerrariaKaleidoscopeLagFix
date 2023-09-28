using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace kaleidoscopeFix.Global
{
	public class GlobalNPCsTest : GlobalNPC
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.tutorialMod.hjson file.

        public override void SetDefaults(NPC npc)
        {
            npc.buffImmune[316] = true;
        }
        public override void OnSpawn(NPC npc, IEntitySource source)
        {
            npc.buffImmune[316] = true;
        }
    }
}
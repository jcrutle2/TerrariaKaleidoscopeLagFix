using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace kaleidoscopeFix.Global
{
	public class GlobalItemsTest : GlobalItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.tutorialMod.hjson file.

		public override void SetDefaults(Item Item)
		{
			if (Item.type == ItemID.RainbowWhip) Item.damage = (int)(1.1 * Item.damage);
		}
	}
}
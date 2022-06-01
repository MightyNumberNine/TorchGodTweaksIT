using Terraria.ID;
using Terraria.ModLoader;

namespace TorchGodTweaks
{
	public class TorchGodsFavorRecipe : GlobalItem
	{
		public override void AddRecipes()
		{
			if (!Config.Instance.TorchGodsFavorRecipe)
			{
				return;
			}

			var goodTorches = new int[]
			{
				ItemID.IceTorch,
				ItemID.DesertTorch,
				ItemID.JungleTorch,
			};
			int torchAmount = 100;
			int otherAmount = 25;

			var recipe = Mod.CreateRecipe(ItemID.TorchGodsFavor);

			recipe.AddRecipeGroup(TorchGodTweaks.GoldRecipeGroup, 4);
			recipe.AddIngredient(ItemID.Torch, torchAmount);
			foreach (var biomeTorch in goodTorches)
			{
				recipe.AddIngredient(biomeTorch, otherAmount);
			}
			recipe.AddRecipeGroup(TorchGodTweaks.PreHMEvilTorchRecipeGroup, otherAmount);

			recipe.AddTile(TileID.DemonAltar);
			recipe.Register();
		}
	}
}

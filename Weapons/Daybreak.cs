using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThrowingDaybreak.Items
{
	class DaybreakClone : ModItem
	{
        public override void SetStaticDefaults()
        
        {
             DisplayName.SetDefault("Daybreak - Throwning");
             Tooltip.SetDefault("'Rend your foes asunder with a spear of light!'");
        }

		public override string Texture { get { return "Terraria/Item_" + ItemID.DayBreak; } }

		public override void SetDefaults()
		{
            item.CloneDefaults(ItemID.DayBreak);
            item.melee = false;
            item.thrown = true;
		}

        public override void AddRecipes() //Adding recipes
        {
            ModRecipe recipe = new ModRecipe(mod);  //Creating a new recipe to be added to 
            recipe.AddIngredient(ItemID.FragmentSolar, 18);   
            recipe.AddTile(TileID.LunarCraftingStation );
            recipe.SetResult(this); //Set the result of the recipe to this item (this refers to the class itself)
            recipe.AddRecipe(); //Add this recipe
        }
	}
}
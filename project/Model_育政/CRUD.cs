using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Model_育政
{
    public class RecipeClass
    {
        public int RecipeID { get; private set; }
        public int PostTime { get; private set; }
        public int RecipeCategoryID { get; private set; }
        public string RecipeName { get; private set; }
        public byte[] ReceipePicture { get; private set; }
        public string RecipeDescription { get; private set; }
        public int ForHowMany { get; private set; }
        public int TimeNeed { get; private set; }
        public string ShareLink { get; private set; }
        public int Views { get; private set; }
        public string Video { get; private set; }
        public bool DisVisible { get; private set; }
        public bool DeleteorNot { get; private set; }
        public int MemberID { get; private set; }
    }

    public class IngredientRecordClass
    {
        public int IngredientID { get; private set; }
        public string Ingredient { get; private set; }
        public int IngredientCategoryID { get; private set; }
        public int RecipeID { get; private set; }
        public double ForUse { get; private set; }
        public string Unit { get; private set; }
    }

    public class StepClass
    {
        public int StepsID { get; private set; }
        public int RecipeID { get; private set; }
        public int StepsNumber { get; private set; }
        public string Steps { get; private set; }
        public byte[] Picture { get; private set; }
    }
}

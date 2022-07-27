using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProductReview
{
    public class ProductReviewManagement
    {
        public static void RetriveTo3ReviewBasedOnTheHighestRating(List<ProductReview> list)
        {
            Console.WriteLine("\nSorted Order");
            //here we are using query syntax
            //here we are retriving the product review based on the higest rating for that we are sortin gthe list in desending oredr
            List<ProductReview> sortedList = (from product in list orderby product.Rating descending select product).ToList();
            Program.IterateOverProductReview(sortedList);
            //after sortig we are taking only top 3 so thas why we are usigng take method for the sroted order
            Console.WriteLine("\nRetriveint To 3Review Based On The Highest Rating");
            List<ProductReview> top4res = sortedList.Take(3).ToList();
            Program.IterateOverProductReview(top4res);


        }
    }
}
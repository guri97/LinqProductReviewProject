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
            //here we are using method syntax
            //here we are retriving the product review based on the higest rating for that we are sortin gthe list in desending oredr
            List<ProductReview> sortedList = (from product in list orderby product.Rating descending select product).ToList();
            Program.IterateOverProductReview(sortedList);
            //after sortig we are taking only top 3 so thas why we are usigng take method for the sroted order
            Console.WriteLine("\nRetriveint To 3Review Based On The Highest Rating");
            List<ProductReview> top3res = sortedList.Take(3).ToList();
            Program.IterateOverProductReview(top3res);


        }
        //UC3
        public static void RetriveBasedOnProductIdAndRatig(List<ProductReview> list)
        {
            Console.WriteLine("\nretriving the productid and rating");
            //this is using the query synatx
            //var res = list.Where(p => p.Rating > 3 && (p.ProductId == 1 || p.ProductId == 4 || p.ProductId == 9));
            //this for the method syntax     //----------from here to here execute fisrt---------------------------------------------//
            var res1 = (from p in list where p.Rating > 3 && (p.ProductId.Equals(1) || p.ProductId.Equals(4) || p.ProductId.Equals(9)) select p).ToList();//this condition execute
                                                                                                                                                          //a/c to the how many data we given inside the list
            Program.IterateOverProductReview(res1);
        }
        public static void CountEachProductID(List<ProductReview> list)
        {//uc4
            //here groupby duplicate values are removed and we are slecting the productid as key
            //and aftre that we are counting how many times ecah porductid is repeating
            Console.WriteLine("\nretriving the count of the product id");                  //here we are using get property to get the values a/c to condition
            var CountOfProductId = (list.GroupBy(p => p.ProductId).Select(product => new { productId = product.Key, ncount = product.Count() })).ToList();
            foreach (var product in CountOfProductId)
            {
                Console.WriteLine("ProductId:{0} Count: {1}", product.productId, product.ncount);
            }
        }
        //uc5
        public static void RetriveProductIDAndRevies(List<ProductReview> list)
        {//just retriving the review and productid
            Console.WriteLine("\nRetriving the productId and review");
            //here we are creating object of anonymous type inside that we are appsing the parameters 
            var res = (list.Select(product => new { productID = product.ProductId, review = product.Review })).ToList();
            foreach (var product in res)
            {
                Console.WriteLine("ProductId:{0} Review: {1}", product.productID, product.review);
            }
        }
        //uc6
        public static void SkipTop5DataRetriveRemaining(List<ProductReview> list)
        {
            Console.WriteLine("\nSkip the Top 5 Records display remaing records");
            List<ProductReview> AfterskipRecords = list.Skip(5).ToList();//it bypasses the specified elements nad returns remaining
            Program.IterateOverProductReview(AfterskipRecords);
        }
    }
}
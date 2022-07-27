﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProductReview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ProductReview> list = new List<ProductReview>();//list maintain the same order
            Console.WriteLine("1.AddProductReviewIntoList\n2.RetriveTo3ReviewBasedOnTheHighestRating\n" +
                "3.RetriveBasedOnProductIdAndRatig\n4..CountEachProductID\n5.RetriveProductIDAndRevies" +
                "\n6.SkipTop5DataRetriveRemaining\n7.AddindDatausingDataTable");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddProductReviewIntoList(list);
                    Console.ReadLine();
                    break;
                case 2:
                    ProductReviewManagement.RetriveTo3ReviewBasedOnTheHighestRating(list);
                    Console.ReadLine();
                    break;
                case 3:
                    ProductReviewManagement.RetriveBasedOnProductIdAndRatig(list);
                    Console.ReadLine();
                    break;
                case 4:
                    ProductReviewManagement.CountEachProductID(list);
                    Console.ReadLine();
                    break;
                case 5:
                    ProductReviewManagement.RetriveProductIDAndRevies(list);
                    Console.ReadLine();
                    break;
                case 6:
                    ProductReviewManagement.SkipTop5DataRetriveRemaining(list);
                    Console.ReadLine();
                    break;
                case 7:
                    LinqToDataTable linq = new LinqToDataTable();
                    linq.AddDataTable();
                    Console.ReadLine();
                    break;
            }
        }
        public static void IterateOverProductReview(List<ProductReview> list)
        {//here we are iterating through the list to display the productreview inside the list
            foreach (ProductReview product in list)
            {
                Console.WriteLine(product);//here it will go to the overeride method inside the ProductReview class
            }
        }


        public static void AddProductReviewIntoList(List<ProductReview> list)
        {                                 //this we called as objevt intialize
            list.Add(new ProductReview() { ProductId = 1, UserId = 101, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 2, UserId = 102, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 3, UserId = 103, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 4, UserId = 104, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 5, UserId = 105, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 6, UserId = 106, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 6, UserId = 107, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 7, UserId = 108, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 8, UserId = 109, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 9, UserId = 110, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 10, UserId = 111, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 11, UserId = 112, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 12, UserId = 113, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 13, UserId = 114, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 14, UserId = 115, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 15, UserId = 116, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 16, UserId = 117, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 17, UserId = 118, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 18, UserId = 119, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 19, UserId = 120, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 20, UserId = 121, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 21, UserId = 122, Review = "Good", IsLike = true, Rating = 8 });
            list.Add(new ProductReview() { ProductId = 22, UserId = 123, Review = "Average", IsLike = true, Rating = 4 });
            list.Add(new ProductReview() { ProductId = 23, UserId = 124, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 24, UserId = 125, Review = "poor", IsLike = false, Rating = 0 });
            list.Add(new ProductReview() { ProductId = 25, UserId = 1, Review = "Good", IsLike = true, Rating = 8 });
            IterateOverProductReview(list);
        }
    }
}
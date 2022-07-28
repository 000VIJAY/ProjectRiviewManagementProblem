using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRiviewManagement
{
    public class Management
    {
        public readonly DataTable dataTable = new DataTable();
        public void Toprecords(List<ProductReview> productReview)
        {
            var recordedData = (from productReviews in productReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            foreach (var item in recordedData)
            {
                Console.WriteLine("ProductId: " + item.ProductId + "  UserId: " + item.UserId
                                + "  Rating: " + item.Rating + "  Review: " + item.Review + "  IsLike: " + item.IsLike);
            }
        }
        public void SelectedRecords(List<ProductReview> productReview)
        {
            var recordData = from productReviews in productReview
                             where (productReviews.ProductId == 1 && productReviews.Rating > 3)
                             || (productReviews.ProductId == 4 && productReviews.Rating > 3)
                             || (productReviews.ProductId == 9 && productReviews.Rating > 3)
                             select productReviews;
            foreach (var item in recordData)
            {
                Console.WriteLine("ProductId: " + item.ProductId + "  UserId: " + item.UserId
                                + "  Rating: " + item.Rating + "  Review: " + item.Review + "  IsLike: " + item.IsLike);
            }
        }
        public void CountBtyProductId(List<ProductReview> productReview)
        {
            var recordedData = productReview.GroupBy(x => x.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() });
            foreach (var item in recordedData)
            {
                Console.WriteLine(item.ProductId + "------" + item.Count);
            }
        }
        public void RetrieveOnlyProductIdAndReview(List<ProductReview> productReview)
        {
            var records = from productReviews in productReview where (productReviews.ProductId > 0) select productReviews;
            foreach (var record in records)
            {
                Console.WriteLine("Product Id: " + record.ProductId + "  Reeview: " + record.Review);
            }
        }
        public void SkipTopRecords(List<ProductReview> productReview)
        {
            var recordedData = (from productReviews in productReview
                                select productReviews).Skip(5);
            foreach (var item in recordedData)
            {
                Console.WriteLine("ProductId: " + item.ProductId + "  UserId: " + item.UserId
                                + "  Rating: " + item.Rating + "  Review: " + item.Review + "  IsLike: " + item.IsLike);
            }
        }
        public void FindAvgRating(List<ProductReview> productReviews)
        {
            var result = productReviews.GroupBy(info => info.ProductId).Select(group => new { products = group.Key, Count = group.Average(a => a.Rating) });
            foreach (var data in result)
            {
                Console.WriteLine("Product Id:{0} => Average Rating :{1}", data.products, data.Count);
            }
        }
        public void RetrieveReview(List<ProductReview> productReview)
        {
            var records = (from productReviews in productReview where productReviews.Review == "Nice" select productReviews);
            foreach (var record in records)
            {
                Console.WriteLine("Product Id: " + record.ProductId + "  Reeview: " + record.Review);
            }
           
        }
        public void RetrieveDataofSameUserId(List<ProductReview> productReview)
        {
            var records = (from productReviews in productReview where productReviews.UserId == 10 orderby productReviews.Rating ascending select productReviews);
            foreach (var item in records)
            {
                Console.WriteLine("ProductId: " + item.ProductId + "  UserId: " + item.UserId
                                + "  Rating: " + item.Rating + "  Review: " + item.Review + "  IsLike: " + item.IsLike);
            }
        }
    }
}

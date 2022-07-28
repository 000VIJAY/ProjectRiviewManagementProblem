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
    }
}

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
    }
}

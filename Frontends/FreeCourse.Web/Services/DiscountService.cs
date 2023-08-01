using FreeCourse.Web.Models.Discounts;
using FreeCourse.Web.Services.Interfaces;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services
{
    public class DiscountService : IDiscountService
{
    public Task<DiscountViewModel> GetDiscount(string discountCode)
    {
        throw new System.NotImplementedException();
    }
}
}

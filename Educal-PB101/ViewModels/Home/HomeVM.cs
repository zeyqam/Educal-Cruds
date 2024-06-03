using Educal_PB101.Models;

namespace Educal_PB101.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Course> Courses { get; set; }
    }
}

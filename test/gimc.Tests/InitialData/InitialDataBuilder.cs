using gimc.EntityFrameworkCore;
using gimc.Models;


namespace gimc.Tests.InitialData
{
    class InitialDataBuilder
    {
        public void Build(gimcDbContext context)
        {
            //Add some Products
            context.Products.AddRange(
                new Product { Title = "Isaac Asimov" },
                new Product { Title = "Thomas More" }
            );
            context.SaveChanges();
        }
    }
}

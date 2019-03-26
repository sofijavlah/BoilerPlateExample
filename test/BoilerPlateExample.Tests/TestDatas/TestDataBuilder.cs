using System.ComponentModel;
using System.Threading.Tasks;
using BoilerPlateExample.EntityFrameworkCore;
using BoilerPlateExample.Models;

namespace BoilerPlateExample.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly BoilerPlateExampleDbContext _context;

        public TestDataBuilder(BoilerPlateExampleDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...

            _context.Offices.AddRange(
                new Office{Description = "Marketing"},
                new Office{Description = "HR"});



        }
    }
}
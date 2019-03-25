using BoilerPlateExample.EntityFrameworkCore;

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
        }
    }
}
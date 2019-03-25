using System;
using System.Threading.Tasks;
using Abp.TestBase;
using BoilerPlateExample.EntityFrameworkCore;
using BoilerPlateExample.Tests.TestDatas;

namespace BoilerPlateExample.Tests
{
    public class BoilerPlateExampleTestBase : AbpIntegratedTestBase<BoilerPlateExampleTestModule>
    {
        public BoilerPlateExampleTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<BoilerPlateExampleDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<BoilerPlateExampleDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<BoilerPlateExampleDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BoilerPlateExampleDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<BoilerPlateExampleDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<BoilerPlateExampleDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<BoilerPlateExampleDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<BoilerPlateExampleDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}

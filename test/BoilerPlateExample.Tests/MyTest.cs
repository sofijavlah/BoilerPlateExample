using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;

namespace BoilerPlateExample.Tests
{
    public class MyTest : BoilerPlateExampleTestBase
    {
        private readonly IFirstService _firstService;

        public MyTest()
        {
            _firstService = Resolve<IFirstService>();
        }


        public async System.Threading.Tasks.Task ShouldGetAllOffices()
        {
            //Act
            var result = await _firstService.GetAll();

            //Assert
            result.Count.ShouldBe(4);
        }

        public async System.Threading.Tasks.Task ShouldGetFilteredOffices()
        {
            //Act
            var result = await _firstService.GetAll();

            //Assert
            result.ShouldAllBe(x => x.Description != null);
        }
    }
}

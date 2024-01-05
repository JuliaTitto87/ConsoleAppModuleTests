using ConsoleAppModuleTests;

namespace LessonCube_Test
{
    public class UnitTest1:IDisposable
    {
        private Brick brick;
        public UnitTest1() 
        {
            brick = new Brick();
        }


        [Fact]
        public void Test1()
        {
            
            var output = new StringWriter();
            Console.SetOut(output);

            brick.Brick_surface_area();

            var outputString = output.ToString();

            if (outputString[0] == '-')
            {
                Assert.Fail("Bricks area has negative meaning");
            }
        }
        public void Dispose()
        {

        }
        [Theory]
        [InlineData(new object[] { 1.8, 1800 })]

        public void If_density_is_18_mass_equals (double density, double mass)
        {
            // act
            var result = brick.Brick_mass(density);

            // assert
            Assert.Equal(mass, result);
        }

    }
}
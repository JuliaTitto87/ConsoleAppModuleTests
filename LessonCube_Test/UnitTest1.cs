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

        [Theory]
        [InlineData(new object[] { 0, -2, 3 })]
        public void NegativeTest_IfEnteredValuesAreNotGreaterThanZeroReturnException(double a, double b, double c) 
        {
            Assert.Throws<ArgumentException>(() => brick.Brick_surface_area(a, b, c));
        }
public void Dispose()
        {

        }



        [Theory]
        [InlineData(new object[] {1, 5, 10, 130})]
        public void PozitiveTest_EnterParametersAndGetArea(double a, double b, double c, double area)
        {
            var result = brick.Brick_surface_area(a, b, c);

            Assert.Equal(area, result);

        }
        

    }
}
using FindMaximumNumber;
namespace FindMaxNumTest
{
    public class FindMaxNumberTest
    {
        FindMaximumNum maxNum = new FindMaximumNum();
        [Test]
        public void GivenMaxFirstNum_WhenAnalysed_ShouldReturnFirstMax()
        {
            //AAA(Act,Arrange,Assert)
            int result = maxNum.FindMaxInteger(15, 5, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxSecondNum_WhenAnalysed_ShouldReturnSecondMax()
        {
            int result = maxNum.FindMaxInteger(5, 15, 10);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxThirdNum_WhenAnalysed_ShouldReturnThirdMax()
        {
            int result = maxNum.FindMaxInteger(10, 5, 15);
            Assert.AreEqual(15, result);
        }
        [Test]
        public void GivenMaxFirstNumFloat_WhenAnalysed_ShouldReturnFirstMax()
        {
            //AAA(Act,Arrange,Assert)
            float result = maxNum.FindMaxFloat(5.7F, 5.5F, 5.4F);
            Assert.AreEqual(5.7F, result);
        }
        [Test]
        public void GivenMaxSecondNumFloat_WhenAnalysed_ShouldReturnSecondMax()
        {
            float result = maxNum.FindMaxFloat(5.5F, 5.7F, 5.4F);
            Assert.AreEqual(5.7F, result);
        }
        [Test]
        public void GivenMaxThirdNumFloat_WhenAnalysed_ShouldReturnThirdMax()
        {
            float result = maxNum.FindMaxFloat(5.5F, 5.4F, 5.7F);
            Assert.AreEqual(5.7F, result);
        }
    }
}

using NUnit.Framework;
using _1_Two_Sum;

namespace _1_Two_Sum_Test
{
    public class Tests
    {
        private Solution SubmitHost = null;

        [SetUp]
        public void Setup()
        {
            // ���͸��D�{�� instance
            this.SubmitHost = new Solution();
        }

        [Test]
        public void Test_leetCode_Example()
        {
            // ���ղĤ@�� test case
            int[] Given = new int[] { 2, 7, 11, 15 };
            int target = 9;
            int[] exactly = new int[] { 0, 1 };

            Assert.AreEqual(
                this.SubmitHost.TwoSum(Given, target),
                exactly);
        }

        [Test]
        public void Test_My_Example()
        {
            // ���զۭq�ר� test case
            int[] Given = new int[] { 2, 7, 11, 15 };
            int target = 17;
            int[] exactly = new int[] { 0, 3 };

            Assert.AreEqual(
                this.SubmitHost.TwoSum(Given, target),
                exactly);
        }
    }
}
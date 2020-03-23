using NUnit.Framework;
using _2_Add_Two_Numbers;

namespace _2_Add_Two_Numbers_Test
{
    public class Tests
    {

        private Solution SubmitHost = null;

        [SetUp]
        public void Setup()
        {
            // 產生解題程式 instance
            this.SubmitHost = new Solution();
        }

        [Test]
        public void Test_leetCode_Example()
        {
            ListNode l1 = new ListNode(243);
            ListNode l2 = new ListNode(564);
            int actual = this.SubmitHost.AddTwoNumbers(l1, l2).val;
            int expected = new ListNode(708).val;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void Test_My_Example()
        {
            ListNode l1 = new ListNode(243);
            ListNode l2 = new ListNode(400);
            int actual = this.SubmitHost.AddTwoNumbers(l1, l2).val;
            int expected = new ListNode(346).val;
            Assert.AreEqual(actual, expected);
        }

    }
}
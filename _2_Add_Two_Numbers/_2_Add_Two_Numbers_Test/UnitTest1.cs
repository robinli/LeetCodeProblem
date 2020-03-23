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

        /// <summary>
        /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        /// Output: 7 -> 0 -> 8
        /// Explanation: 342 + 465 = 807.
        /// </summary>
        [Test]
        public void Test_leetCode_Example()
        {

            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            ListNode actual = this.SubmitHost.AddTwoNumbers(l1, l2);

            ListNode expected = new ListNode(7);
            expected.next = new ListNode(0);
            expected.next.next = new ListNode(8);

            Assert.IsTrue(ListNodeCompare(actual, expected));
        }

        /// <summary>
        /// Input: (2 -> 4 -> 3) + (1 -> 4 -> 3)
        /// Output: 3 -> 8 -> 6
        /// Explanation: 342 + 341 = 683.
        /// </summary>
        [Test]
        public void Test_My_Example()
        {

            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(2);
            l2.next.next = new ListNode(3);

            ListNode actual = this.SubmitHost.AddTwoNumbers(l1, l2);

            ListNode expected = new ListNode(3);
            expected.next = new ListNode(8);
            expected.next.next = new ListNode(6);

            Assert.IsTrue(ListNodeCompare(actual, expected));
        }

        private bool ListNodeCompare(ListNode l1, ListNode l2)
        {
            ListNode n1 = l1;
            ListNode n2 = l2;
            while (n1 != null && n2 != null)
            {
                if(n1.val != n2.val)
                {
                    //Assert.Fail($"{n1.val} is different from {n2.val}");
                    return false;
                }
                n1 = n1.next;
                n2 = n2.next;
            }
            //Assert.Pass();
            return true;
        }

    }
}
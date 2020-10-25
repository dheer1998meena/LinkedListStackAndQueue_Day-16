using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListStackAndQueue;

namespace LinkedListStackAndQueueMsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodForLinkedListQueue()
        {
            {
                //Arrange
                LinkedListQueue queue = new LinkedListQueue()
                //Act
                queue.EnqueueElement(56);
                int expected = 56;
                int actual =  queue.DequeueElement();
                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}

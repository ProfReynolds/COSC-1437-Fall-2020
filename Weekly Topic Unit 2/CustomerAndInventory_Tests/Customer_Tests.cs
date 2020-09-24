using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerAndInventory_Tests
{
    [TestClass]
    public class Customer_Tests
    {
        [TestMethod]
        public void Verify_The_ID_Is_Zero_When_Instantiated()
        {
            // assign
            var customer=new CustomerAndInventory.Customer();

            // action

            // assert
            Assert.AreEqual(0, customer.ID);
        }

        [TestMethod]
        public void Verify_The_ID_Can_Be_Assigned()
        {
            // assign
            var assignedID = 1234;
            var customer = new CustomerAndInventory.Customer();

            // action
            customer.ID = assignedID;

            // assert
            Assert.AreEqual(assignedID, customer.ID);
        }
    }
}
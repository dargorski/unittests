using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class OrderServiceTests
    {
        [Test]
        public void PlaceOrder_WhenCalled_ShouldStoreOrder()
        {
            var order = new Order();
            var storage = new Mock<IStorage>();
            var service = new OrderService(storage.Object);

            service.PlaceOrder(order);

            storage.Verify(s => s.Store(order));         
        }
    }
}

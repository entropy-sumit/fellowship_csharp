using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGenartorTest
{
    [TestClass]
    public class UnitTest1
    {

        InvoiceGeneartor invoiceGeneartor = null;

        [TestMethod]
        public void GivenDistanceAndTimeShouldTotalFare()
        {
            invoiceGeneartor = new InvoiceGeneartor(RideType.Normal);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGeneartor.CalcaulateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);

        }


        [TestMethod]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            invoiceGeneartor = new InvoiceGeneartor(RideType.Normal);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = invoiceGeneartor.CalcaulateFare(rides);
            InvoiceSummary excpectedSummary = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(excpectedSummary, summary);
        }
    }
}
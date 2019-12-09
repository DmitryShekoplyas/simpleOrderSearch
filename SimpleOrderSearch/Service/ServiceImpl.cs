using System;
using System.Collections.Generic;
using System.Linq;
using SampleOrderSearch.Model;

namespace SampleOrderSearch.Service
{
    /// <summary>
    /// Class which represents Service with basic operations.
    /// </summary>
    class ServiceImpl
    {
        private List<OrderInfo> orders = new List<OrderInfo>();

        /// <summary>
        /// Returns orders by criteria.
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="msa">MSA</param>
        /// <param name="status">Order status</param>
        /// <param name="date">Completion date</param>
        /// <returns></returns>
        public IEnumerable<OrderInfo> GetOrdersByFields(int orderId, short msa, short status, DateTime date)
        {
            // Use LINQ to get orders by criteria : (Order Number || (MSA && Status)) && CompletionDate
            var ordersQuery =
                from order in orders
                where (order.OrderId == orderId || (order.MSA == msa && order.Status == status))
                    && order.CompletionDate.Equals(date)
                select order;

            return ordersQuery;
        }

        /// <summary>
        /// Creates order and add the order to collection.
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="shipperId">Shipper id</param>
        /// <param name="driverId">Driver id</param>
        /// <param name="date">Completion date</param>
        /// <param name="status">Order status</param>
        /// <param name="code">Code</param>
        /// <param name="msa">MSA</param>
        /// <param name="duration">Duration</param>
        /// <param name="type">Offer type</param>
        /// <returns></returns>
        public OrderInfo CreateOrder(int orderId, int shipperId, int driverId, DateTime date, short status
            , string code, short msa, double duration, short type)
        {
            if (orderId < 0)
                throw new ArgumentException("Order Id must be a positive number");
            if (shipperId < 0)
                throw new ArgumentException("Shipper Id must be a positive number");
            if (driverId < 0)
                throw new ArgumentException("Driver Id must be a positive number");
            if (date == null)
                throw new ArgumentException("Date can not be a null");
            if (status < 0)
                throw new ArgumentException("Status must be a positive number");
            if (code == null || code.Length == 0)
                throw new ArgumentException("Code must be a valid string");
            if (msa < 0)
                throw new ArgumentException("MSA must be a positive number");
            if (duration < 0)
                throw new ArgumentException("Duration must be a positive number");
            if (type < 0)
                throw new ArgumentException("Offer Type must be a positive number");

            OrderInfo order;
            try
            {
                order = new OrderInfo(orderId, shipperId, driverId, date, status
                    , code, msa, duration, type);

                orders.Add(order);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return order;
        }
    }
}
using System;


namespace SampleOrderSearch.Model
{
    /// <summary>
    /// Class which represents Order information.
    /// </summary>
    public class OrderInfo
    {
        /// <summary>
        /// Order id
        /// </summary>
        public int OrderId { get; }
        /// <summary>
        /// Shipper id
        /// </summary>
        public int ShipperId { get; }
        /// <summary>
        /// Driver id
        /// </summary>
        public int DriverId { get; }
        /// <summary>
        /// Completion date
        /// </summary>
        public DateTime CompletionDate { get; }
        /// <summary>
        /// Status
        /// </summary>
        public short Status { get; }
        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; }
        /// <summary>
        /// MSA
        /// </summary>
        public short MSA { get; }
        /// <summary>
        /// Duration
        /// </summary>
        public double Duration { get; }
        /// <summary>
        /// OfferType
        /// </summary>
        public short OfferType { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="orderId">Order id</param>
        /// <param name="shipperId">Shipper id</param>
        /// <param name="driverId">Driver id</param>
        /// <param name="date">Completion date</param>
        /// <param name="status">Order status</param>
        /// <param name="code">Code</param>
        /// <param name="msa">MSA</param>
        /// <param name="duration">Duration</param>
        /// <param name="type">Type</param>
        public OrderInfo(int orderId, int shipperId, int driverId, DateTime date, short status
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

            OrderId = orderId;
            ShipperId = shipperId;
            DriverId = driverId;
            CompletionDate = date;
            Status = status;
            Code = code;
            MSA = msa;
            Duration = duration;
            OfferType = type;
        }
    }
}
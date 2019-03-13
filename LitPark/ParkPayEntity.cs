using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 支付记录
    /// </summary>
    public class ParkPayEntity
    {
        /// <summary>
        /// 支付id
        /// </summary>
        public int Id { set; get; }

        /// <summary>
        /// 临时车牌
        /// </summary>
        public string Licence { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 优惠券id
        /// </summary>
        public int TicketId { get; set; }

        /// <summary>
        /// 消费多少钱，以元为单位
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 支付结果
        /// </summary>
        public ParkPayType PayType { get; set; }

        /// <summary>
        /// 支付备注
        /// </summary>
        public string Note { get; set; }
    }
}
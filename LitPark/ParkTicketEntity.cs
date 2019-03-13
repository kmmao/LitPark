using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 优惠券基本信息，灵感来自http://www.bj.xinhuanet.com/bjyw/2019-01/24/c_1124037114.htm
    /// </summary>
    public class ParkTicketEntity
    {
        /// <summary>
        /// 优惠券Id
        /// </summary>
        public int Id { get; set; }
      
        /// <summary>
        /// 优惠券编号
        /// </summary>
        public string Guid { get; set; }
        
        /// <summary>
        /// 免费时长分钟
        /// </summary>
        public int FreeMinutes { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpDate { get; set; }

        /// <summary>
        /// 优惠券来源
        /// </summary>
        public int TicketSourceId { get; set; }
      
        /// <summary>
        /// 是否用过了
        /// </summary>
        public bool Used { get; set; }

        /// <summary>
        /// 是否被废弃
        /// </summary>
        public bool Discard { get; set; }

        /// <summary>
        /// 日志相关
        /// </summary>
        public string Note { get; set; }
    }
}
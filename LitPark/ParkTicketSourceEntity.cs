using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 优惠券来源
    /// </summary>
    public class ParkTicketSourceEntity
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 优惠券名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 管理员id，0为系统生成
        /// </summary>
        public int AdminId { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime ExpDate { get; set; }

        /// <summary>
        /// 是否被废弃
        /// </summary>
        public bool Discard { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string Note { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 会员基本信息
    /// </summary>
    public class ParkMemberEntity
    {
        /// <summary>
        /// 会员Id，包含流动车和固定车
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 楼栋
        /// </summary>
        public int Building { get; set; }

        /// <summary>
        /// 单元
        /// </summary>
        public int Unit { get; set; }

        /// <summary>
        /// 门牌号
        /// </summary>
        public int Room { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 会员开始时间
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// 会员结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 会员备注信息
        /// </summary>
        public string Note { get; set; }
    }
}

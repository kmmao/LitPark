using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 汽车进出日志
    /// </summary>
    public class ParkCarLogEntity
    {
        /// <summary>
        /// 编号id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 车牌
        /// </summary>
        public string License { get; set; }

        /// <summary>
        /// 车场名称
        /// </summary>
        public int LotId { get; set; }

        /// <summary>
        /// 进出时间
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// 当时车所属车主
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// 是否抬杆
        /// </summary>
        public bool Sucess { get; set; }
    }
}

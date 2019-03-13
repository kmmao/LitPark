using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 车位基本信息
    /// </summary>
    public class ParkSpaceEntity
    {
        /// <summary>
        /// 车位id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 车位名称，如东区120号
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 车位类型
        /// </summary>
        public ParkCarType CarType { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
    }
}

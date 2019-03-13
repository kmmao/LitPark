using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 车位类型
    /// </summary>
    public enum ParkCarType
    {
        /// <summary>
        /// 私人车位
        /// </summary>
        Private = 0,
        /// <summary>
        /// 固定车位
        /// </summary>
        Fixed = 1,
        /// <summary>
        /// 流动车位
        /// </summary>
        Move = 2,
        /// <summary>
        /// 临时车位
        /// </summary>
        Temp = 3
    }
}

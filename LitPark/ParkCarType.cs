using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 车或车位类型
    /// </summary>
    public enum ParkCarType
    {
        /// <summary>
        /// 固定车
        /// </summary>
        Fixed = 0,
        /// <summary>
        /// 流动车
        /// </summary>
        Move = 1,
        /// <summary>
        /// 临时车
        /// </summary>
        Temp = 2
    }
}

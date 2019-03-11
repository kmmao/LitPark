using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 支付结果
    /// </summary>
    public enum ParkPayType
    {
        /// <summary>
        /// 没有支付,临时车出场时即生成
        /// </summary>
        No_Pay = 0,
        /// <summary>
        /// 支付完成
        /// </summary>
        Has_Pay = 1,
        /// <summary>
        /// 不知道，可能人工抬杆放行了
        /// </summary>
        Unknow = 2
    }
}
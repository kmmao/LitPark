using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 可登录系统的用户级别
    /// </summary>
    public enum ParkGroupType
    {
        /// <summary>
        /// 管理员，可添加可修改
        /// </summary>
        Manager = 1,
        /// <summary>
        /// 门岗，查看所有信息
        /// </summary>
        DoorMan = 2,
        /// <summary>
        /// 用户，只能查看自己
        /// </summary>
        Member = 3
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 管理员操作类型
    /// </summary>
    public enum ParkAdminActionType
    {
        /// <summary>
        /// 登录系统
        /// </summary>
        Login = 0,
        /// <summary>
        /// 添加用户
        /// </summary>
        AddMember = 1,
        /// <summary>
        /// 删除用户
        /// </summary>
        DeleteMember = 2,
        /// <summary>
        /// 编辑用户
        /// </summary>
        EditMember = 3,
        /// <summary>
        /// 添加车场
        /// </summary>
        AddPartLot = 4,
        /// <summary>
        /// 删除车场
        /// </summary>
        DeleteParkLot = 5,
    }
}
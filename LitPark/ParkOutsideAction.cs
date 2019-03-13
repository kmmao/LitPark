using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 委托事件，外部实现，内部调用
    /// </summary>
    public class ParkOutsideAction
    {
        /// <summary>
        /// 获取管理员列表
        /// </summary>
        public static Func<List<ParkAdminEntity>> GetAdminEntityList;

        /// <summary>
        /// 获取停车位列表
        /// </summary>
        public static Func<List<ParkSpaceEntity>> GetSpaceEntityList;

        /// <summary>
        /// 获取停车位列表
        /// </summary>
        public static Func<List<ParkLotEntity>> GetLotEntityList;

        /// <summary>
        /// 获取用户列表
        /// </summary>
        public static Func<List<ParkMemberEntity>> GetMemberEntityList;

        /// <summary>
        /// 获得优惠券列表
        /// </summary>
        public static Func<List<ParkTicketEntity>> GetTicketEntityList;

        /// <summary>
        /// 获取优惠券来源列表
        /// </summary>
        public static Func<List<ParkTicketSourceEntity>> GetTicketSourceEntityList;
    }
}

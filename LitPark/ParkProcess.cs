using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 整个系统运行核心处理
    /// </summary>
    public class ParkProcess
    {
        private static bool loadOK = false;
        /// <summary>
        /// 是否完全加载完成
        /// </summary>
        public static bool LoadOK
        {
            get { return loadOK; }
        }

        /// <summary>
        /// 管理员列表
        /// </summary>
        public static List<ParkAdminEntity> AdminEntityList;

        /// <summary>
        /// 停车位列表
        /// </summary>
        public static List<ParkSpaceEntity> SpaceEntityList;

        /// <summary>
        /// 停车位列表
        /// </summary>
        public static List<ParkLotEntity> LotEntityList;

        /// <summary>
        /// 用户列表
        /// </summary>
        public static List<ParkMemberEntity> MemberEntityList;

        /// <summary>
        /// 优惠券列表
        /// </summary>
        public static List<ParkTicketEntity> TicketEntityList;

        /// <summary>
        /// 优惠券来源列表
        /// </summary>
        public static List<ParkTicketSourceEntity> TicketSourceEntityList;

        /// <summary>
        /// 启动事件列表，最后要用loadOK来判断是否完成
        /// </summary>
        public static void StartAsynLoad()
        {
            new System.Threading.Thread(() =>
            {
                AdminEntityList = ParkOutsideAction.GetAdminEntityList();
                SpaceEntityList = ParkOutsideAction.GetSpaceEntityList();
                LotEntityList = ParkOutsideAction.GetLotEntityList();
                MemberEntityList = ParkOutsideAction.GetMemberEntityList();
                TicketEntityList = ParkOutsideAction.GetTicketEntityList();
                TicketSourceEntityList = ParkOutsideAction.GetTicketSourceEntityList();
                loadOK = true;
            }).Start();
        }

        /// <summary>
        /// 开始整个系统的运行, 中间生成的东西通过事件传送出去
        /// </summary>
        public static void StartApp()
        {

        }
    }
}

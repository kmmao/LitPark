using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 管理员操作日志，包含登录，添加等
    /// </summary>
    public class ParkAdminLogEntity
    {
        /// <summary>
        /// 日志Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 管理员Id，自增
        /// </summary>
        public int AdminId { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime LogTime { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        public ParkAdminActionType AdminActionType { get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        public string Note { get; set; }
    }
}
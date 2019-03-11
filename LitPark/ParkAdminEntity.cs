using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 管理员基本信息
    /// </summary>
    public class ParkAdminEntity
    {
        /// <summary>
        /// 管理员信息
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// 管理员用户组
        /// </summary>
        public ParkGroupType GroupType { get; set; }

        /// <summary>
        /// 可管理的车场，0为所有
        /// </summary>
        public int ParkId { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime LastLogin { get; set; }
    }
}
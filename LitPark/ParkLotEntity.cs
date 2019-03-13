using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitPark
{
    /// <summary>
    /// 车场基本信息
    /// </summary>
    public class ParkLotEntity
    {
        /// <summary>
        /// 车场id，根车场为0
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 上级车场id
        /// </summary>
        public int Pid { get; set; }

        /// <summary>
        /// 车场名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 禁止临时车进入
        /// </summary>
        public int BanTemp { get; set; }

        /// <summary>
        /// 进入的IP
        /// </summary>
        public string EnterIP { get; set; }

        /// <summary>
        /// 进入端口
        /// </summary>
        public int EnterPort { get; set; }

        /// <summary>
        /// 离开的IP
        /// </summary>
        public string LeaveIP { get; set; }
        
        /// <summary>
        /// 离开的端口
        /// </summary>
        public int LeavePort { get; set; }
    }
}
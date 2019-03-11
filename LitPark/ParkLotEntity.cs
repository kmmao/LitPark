using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkLib
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
        /// 禁止临时车
        /// </summary>
        public int BanTemp { get; set; }

        /// <summary>
        /// 是否进入
        /// </summary>
        public bool IsEnter { get; set; }

        /// <summary>
        /// 对应的IP
        /// </summary>
        public string CameraIP { get; set; }

        /// <summary>
        /// 对应端口
        /// </summary>
        public int CameraPort { get; set; }
    }
}

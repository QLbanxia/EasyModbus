using System;
using System.Collections.Generic;
using System.Text;

namespace EasyModbus.Config
{
    /// <summary>
    /// 配置静态类
    /// </summary>
    public static class EConfig
    {
        /// <summary>
        /// modbus 协议 实例化
        /// </summary>
        public static ConfigModbus configModbus = new ConfigModbus();
        /// <summary>
        /// 串口实例化
        /// </summary>
        public static ConfigSerialPort configSerialPort = new ConfigSerialPort();
        /// <summary>
        /// TCP实例化
        /// </summary>
        public static ConfigTCP configTCP = new ConfigTCP();
    }
}

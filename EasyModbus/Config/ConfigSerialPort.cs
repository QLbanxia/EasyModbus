using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace EasyModbus.Config
{
    /// <summary>
    /// 串口配置
    /// </summary>
    public class ConfigSerialPort
    {
        /// <summary>
        /// 串口名称
        /// </summary>
        public string portName = "COM1";
        /// <summary>
        /// 波特率
        /// </summary>
        public int baudRate = 9600;
        /// <summary>
        /// 奇偶校验位
        /// </summary>
        public Parity parity = Parity.None;
        /// <summary>
        /// 数据位
        /// </summary>
        public int dataBits = 8;
        /// <summary>
        /// 停止位
        /// </summary>
        public StopBits stopBits = StopBits.One;
    }
}

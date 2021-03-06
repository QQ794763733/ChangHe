﻿namespace ChangHeWebSite.Areas.Admin.Models
{
    /// <summary>
    /// 系统信息
    /// </summary>
    public class SystemInfo
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 系统名称
        /// </summary>
        public string SystemName { get; set; }
        /// <summary>
        /// 系统Logo
        /// </summary>
        public string SystemLogo { get; set; }
        /// <summary>
        /// 系统版权
        /// </summary>
        public string SystemCopyright { get; set; }
        /// <summary>
        /// 系统描述
        /// </summary>
        public string SystemDescription { get; set; }
    }
}
﻿using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using TinyEdu.Util;

namespace TinyEdu.Entity.SystemManage
{
    [Table("sys_log_api")]
    public class LogApiEntity : BaseCreateEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int? LogStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Remark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ExecuteUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ExecuteParam { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ExecuteResult { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int? ExecuteTime { get; set; }

        [NotMapped]
        public string UserName { get; set; }
        [NotMapped]
        public string DepartmentName { get; set; }
    }
}
﻿using Tiny.OPS.Domain.XGJProduct;
using System.Collections.Generic;

namespace Tiny.OPS.Contract
{

    /// <summary>
    /// 来源系统产品体系--课程信息表
    /// </summary>
    public class VMEXTCoursePageInfoResponse : SearchBase
    {
        /// <summary>
        /// 产品信息列表信息
        /// </summary>
        public IList<VM_EXT_Course> ReusltList { set; get; } = new List<VM_EXT_Course>();
    }
}

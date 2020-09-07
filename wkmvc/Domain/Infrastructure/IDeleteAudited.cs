﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDeleteAudited
    {
        /// <summary>
        /// 逻辑删除标记
        /// </summary>
        bool ? DeleteMark { get; set; }
        /// <summary>
        /// 删除实体的用户
        /// </summary>
        int? DeleteUserId { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        DateTime? DeleteDate { get; set; }
    }
}

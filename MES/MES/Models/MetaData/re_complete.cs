﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MES.Models
{
    [MetadataType(typeof(re_completeMetaData))]
    public partial class re_complete
    {
        private class re_completeMetaData
        {
            [Key]
            public int rowid { get; set; }

            [Display(Name = "訂單編號")]
            [Required(ErrorMessage = "編號不可空白!")]
            public string order_no { get; set; }

            [Display(Name = "回報單編號")]
            [Required(ErrorMessage = "名稱不可空白!")]
            public string re_complete_no { get; set; }

            [Display(Name = "回報單日期")]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
            public DateTime re_complete_date { get; set; }

        }
    }
}
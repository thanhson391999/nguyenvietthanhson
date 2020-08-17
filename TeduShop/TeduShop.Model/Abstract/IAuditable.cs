﻿using System;

namespace TeduShop.Model.Abstract
{
    public interface IDisposable
    {
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
        bool Status { get; set; }
    }
}
using System;

namespace TadeShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        String CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        String UpdateBy { set; get; }

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        bool Status { set; get; }
    }
}
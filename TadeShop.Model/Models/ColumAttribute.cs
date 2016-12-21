using System;

namespace TadeShop.Model.Models
{
    internal class Column : Attribute
    {
        public string TypeName;

        public int Order { get; set; }
    }
}
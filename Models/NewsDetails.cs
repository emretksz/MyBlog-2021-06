//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBlog2021N.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewsDetails
    {
        public int NewsId { get; set; }
        public string ImageURL { get; set; }
        public string MainDescription { get; set; }
    
        public virtual News News { get; set; }
    }
}

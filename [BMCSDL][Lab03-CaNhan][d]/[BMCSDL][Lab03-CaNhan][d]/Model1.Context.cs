﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _BMCSDL__Lab03_CaNhan__d_
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLSVEntities : DbContext
    {
        public QLSVEntities()
            : base("name=QLSVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Nullable<int>> SP_SEL_USER(string tENDN, string mATKHAU)
        {
            var tENDNParameter = tENDN != null ?
                new ObjectParameter("TENDN", tENDN) :
                new ObjectParameter("TENDN", typeof(string));
    
            var mATKHAUParameter = mATKHAU != null ?
                new ObjectParameter("MATKHAU", mATKHAU) :
                new ObjectParameter("MATKHAU", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SP_SEL_USER", tENDNParameter, mATKHAUParameter);
        }
    }
}

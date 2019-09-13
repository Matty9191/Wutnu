﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wutnu.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class WutNuContext : DbContext
    {
        public WutNuContext()
            //: base("name=WutNuContext")
        	: base(Util.BuildEntityConnectionStringFromAppSettings("WutNuContext","WutNuEntities"))
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<UrlHistory> UrlHistories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAssignment> UserAssignments { get; set; }
        public virtual DbSet<WutLink> WutLinks { get; set; }
        public virtual DbSet<vwHistoryReport> vwHistoryReports { get; set; }
    
        public virtual int usp_AddHistory(string shortUrl, Nullable<System.DateTime> callDate, Nullable<int> userId, string hostIp, string latitude, string longitude, string city, string region, string country, string continent, string isp)
        {
            var shortUrlParameter = shortUrl != null ?
                new ObjectParameter("ShortUrl", shortUrl) :
                new ObjectParameter("ShortUrl", typeof(string));
    
            var callDateParameter = callDate.HasValue ?
                new ObjectParameter("CallDate", callDate) :
                new ObjectParameter("CallDate", typeof(System.DateTime));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var hostIpParameter = hostIp != null ?
                new ObjectParameter("HostIp", hostIp) :
                new ObjectParameter("HostIp", typeof(string));
    
            var latitudeParameter = latitude != null ?
                new ObjectParameter("Latitude", latitude) :
                new ObjectParameter("Latitude", typeof(string));
    
            var longitudeParameter = longitude != null ?
                new ObjectParameter("Longitude", longitude) :
                new ObjectParameter("Longitude", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var regionParameter = region != null ?
                new ObjectParameter("Region", region) :
                new ObjectParameter("Region", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var continentParameter = continent != null ?
                new ObjectParameter("Continent", continent) :
                new ObjectParameter("Continent", typeof(string));
    
            var ispParameter = isp != null ?
                new ObjectParameter("Isp", isp) :
                new ObjectParameter("Isp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddHistory", shortUrlParameter, callDateParameter, userIdParameter, hostIpParameter, latitudeParameter, longitudeParameter, cityParameter, regionParameter, countryParameter, continentParameter, ispParameter);
        }
    }
}

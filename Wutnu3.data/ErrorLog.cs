//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ErrorLog
    {
        public int ErrorId { get; set; }
        public System.DateTime ErrorDate { get; set; }
        public string ErrorMessage { get; set; }
        public string CallStack { get; set; }
        public string UserAgent { get; set; }
        public string IPAddress { get; set; }
        public string UserComment { get; set; }
        public string Email { get; set; }
        public string ValidationErrors { get; set; }
        public string ErrorSource { get; set; }
        public string StackTrace { get; set; }
        public string InnerExceptionSource { get; set; }
        public string QSData { get; set; }
        public string PostData { get; set; }
        public string Referrer { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public string InnerExceptionMessage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DNCHK_K1159610.Models
{
    public class ResidentDailyReportContext : DbContext
    {

        public DbSet<ResidentDailyReport> ResidentDailyReports { get; set; }
    }
}
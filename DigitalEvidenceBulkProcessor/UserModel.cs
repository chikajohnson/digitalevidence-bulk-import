using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEvidenceBulkProcessor
{
    public class UserModel
    {
        public string UserID { get; set; }
        public string BranchCode { get; set; }
        public string UserNames { get; set; }
        public string Password { get; set; } = "teller";
    }
}


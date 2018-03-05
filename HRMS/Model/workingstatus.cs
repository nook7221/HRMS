using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Model
{
    public class workingstatus
    {
        public string status_code { get; set; }
        public string status_name { get; set; }
        public string x_status { get; set; }
        public string x_note { get; set; }
        public string x_log { get; set; }
        public string id { get; set; }
        public DateTime rowversion { get; set; }

    }
}

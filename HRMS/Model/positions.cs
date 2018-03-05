using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Model
{
    public class positions
    {
        public string position_code { get; set; }
        public string position_desc { get; set; }
        public string x_status { get; set; }
        public string x_note { get; set; }
        public string x_log { get; set; }
        public string id { get; set; }
        public DateTime rowversion { get; set; }

    }
}

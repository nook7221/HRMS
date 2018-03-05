using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Model
{
    public class empworklog
    {
        public string emp_code { get; set; }
        public int row_number { get; set; }
        public string status_code { get; set; }
        public string start_year { get; set; }
        public string end_year { get; set; }
        public string position_name { get; set; }
        public string posiition_level { get; set; }
        public string work_division { get; set; }
        public string work_organization { get; set; }
        public string working_country { get; set; }
        public int year_of_response { get; set; }
        public int month_of_response { get; set; }
        public string career_score { get; set; }
        public string selection_score { get; set; }
        public string doc_image1 { get; set; }
        public string doc_image2 { get; set; }
        public string doc_image3 { get; set; }
        public string doc_image4 { get; set; }
        public string doc_image5 { get; set; }
        public string x_status { get; set; }
        public string x_note { get; set; }
        public string x_log { get; set; }
        public string id { get; set; }
        public DateTime rowversion { get; set; }

    }
}

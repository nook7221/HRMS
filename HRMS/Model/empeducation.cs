using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Model
{
    public class empeducation
    {
        public string emp_code { get; set; }
        public int row_number { get; set; }
        public int study_year { get; set; }
        public int graduate_year { get; set; }
        public string institute_name { get; set; }
        public string degree_name { get; set; }
        public string facultly_name { get; set; }
        public string major_name { get; set; }
        public string minor_name { get; set; }
        public string honor { get; set; }
        public string gpa { get; set; }
        public string graduate_country { get; set; }
        public string career_score { get; set; }
        public string selection_score { get; set; }
        public string doc_image1 { get; set; }
        public string doc_image2 { get; set; }
        public string doc_image3 { get; set; }
        public string doc_image4 { get; set; }
        public string doc_image5 { get; set; }
        public string master_file_location { get; set; }
        public string x_status { get; set; }
        public string x_note { get; set; }
        public string x_log { get; set; }
        public string id { get; set; }
        public DateTime rowversion { get; set; }

    }
}

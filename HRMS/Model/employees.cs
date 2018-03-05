using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Model
{
    public class employees
    {
        public string emp_code { get; set; }
        public string ref_code { get; set; }
        public string pre_name { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string position_code { get; set; }
        public string pos_level_code { get; set; }
        public DateTime birthdate { get; set; }
        public string nationality { get; set; }
        public string cid_card { get; set; }
        public DateTime cid_card_issue_date { get; set; }
        public DateTime cid_card_expire_date { get; set; }
        public string tax_id { get; set; }
        public string email { get; set; }
        public string mobile_phone { get; set; }
        public string messager_id { get; set; }
        public string org_code { get; set; }
        public string dept1_code { get; set; }
        public string dept2_code { get; set; }
        public string dept3_code { get; set; }
        public string dept4_code { get; set; }
        public DateTime emp_card_issue_date { get; set; }
        public DateTime emp_card_expire_date { get; set; }
        public string cid_pic_code { get; set; }
        public string pic_code { get; set; }

        public string blood_group { get; set; }
        public string marital_status { get; set; }
        public string tag_id { get; set; }
        public string mac_address { get; set; }
        public string x_status { get; set; }
        public string x_note { get; set; }
        public string x_log { get; set; }
        public string id { get; set; }
        public DateTime? rowversion { get; set; }

    }
}

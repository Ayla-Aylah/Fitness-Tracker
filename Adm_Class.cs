using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack_Assignment_Program
{
    class Adm_Class
    {
        private string _AdmID,_AdmUsName,_AdmLglName,_AdmPw,_AdmEmail;

        public string AdmID
        {
            set
            {
                _AdmID = value;
            }
            get
            {
                return _AdmID;

            }
 
        }
        public string AdmUsName
        {
            set
            {
                _AdmUsName = value;
            }
            get
            {
                return _AdmUsName;

            }

        }
        public string AdmLglName
        {
            set
            {
                _AdmLglName = value;
            }
            get
            {
                return _AdmLglName;

            }
        }
        public string AdmPw
        {
            set
            {
                _AdmPw = value;
            }
            get
            {
                return _AdmPw;

            }
        }
        public string AdmEmail
        {
            set
            {
                _AdmEmail = value;
            }
            get
            {
                return _AdmEmail;

            }
        }
       
    }
}

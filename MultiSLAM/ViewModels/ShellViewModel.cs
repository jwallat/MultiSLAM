using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;

namespace MultiSLAM.ViewModels
{
    class ShellViewModel : Screen
    {

        private string _firstName = "Jonas";

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value; 
                NotifyOfPropertyChange(() => FirstName);
            }
        }
 

    }
}

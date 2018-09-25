using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSMGMT
{
    public class Actions
    {
        private CheckBox _actionCheckbox;
        private int _actionValue;

        public Actions(CheckBox actionCheckBox,int actionValue)
        {
            _actionCheckbox = actionCheckBox;
            _actionValue = actionValue;

        }

        public CheckBox ActionCheckBox
        {
            get { return _actionCheckbox; }
            set { _actionCheckbox = value; }
        }

        public int ActionValue
        {
            get { return _actionValue; }
            set { _actionValue = value; }
        }
    }
}

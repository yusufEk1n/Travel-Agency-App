using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımMimarisiProjeV2.TextBox_Control
{
    public class TextBoxControl
    {
        public TextBoxControl_Factory Controller { get; set; }

        public TextBoxControl()
        {
            this.Controller = new TextBoxControl_Factory();
        }

        public bool Control()
        {
            bool control = true;

            foreach (var item in this.Controller.Controller())
            {
                if (item.Key.Text == "")
                {
                    item.Value.Text = "*";
                    control = false;
                }
                else
                {
                    item.Value.Text = "";
                }
            }
            return control;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımMimarisiProjeV2.TextBox_Control
{
    public class TextBoxControl_Factory
    {
        private Dictionary<TextBox, Label> textBoxLabel;

        public TextBoxControl_Factory()
        {
            textBoxLabel = new Dictionary<TextBox, Label>();
        }

        public void textBoxAndLabelAdd(TextBox textBox, Label label)
        {
            textBoxLabel.Add(textBox, label);
        }

        public Dictionary<TextBox, Label> Controller()
        {
            return textBoxLabel;
        }
    }
}

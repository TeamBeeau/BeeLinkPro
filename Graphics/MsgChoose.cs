using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace Graphics
{
    public partial class MsgChoose: UserControl
    {
        public MsgChoose()
        {
           
            InitializeComponent();
            this.BackColor = Resource.ColorBG(clBackground.UserCotrol);
        }

        private void MsgChoose_Load(object sender, EventArgs e)
        {
           
        }
    }
}

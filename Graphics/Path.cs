﻿using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics
{
    public partial class Path : UserControl
    {
        public Path()
        {
            InitializeComponent();
            this.BackColor = Resource.ColorBG(clBackground.UserCotrol);
        }
    }
}

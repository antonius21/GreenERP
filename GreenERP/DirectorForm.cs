﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenERP
{
    public partial class DirectorForm : MainForm
    {
        public DirectorForm(User user) : base(user)
        {
            InitializeComponent();
        }
    }
}

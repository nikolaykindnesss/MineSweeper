﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

		private void SettingOpenClikc(object sender, EventArgs e)
		{
            SettingForm form = new SettingForm();
            form.ShowDialog();
		}
	}
}

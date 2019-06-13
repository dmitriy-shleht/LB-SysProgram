using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace MainDomain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 1; i <= 3; i++)
            {
                var app = AppDomain.CreateDomain($"Lib{i}");
                var obj = (MarshalByLib)app.CreateInstanceAndUnwrap(Assembly.GetExecutingAssembly().FullName, "MainDomain.MarshalByLib");
                var s = obj.GetDomainInfo($"Lib{i}.dll", $"Lib{i}.Class1");

                listBox1.Items.Add(s);
            }
        }
    }
}

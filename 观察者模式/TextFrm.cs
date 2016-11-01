using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 观察者模式
{
    public partial class TextFrm : Form,Observer
    {
        public TextFrm(Subject subj)
        {
            InitializeComponent();
            init(subj);
        }

        public void init(Subject subj)
        {
            subj.registerInterest(this);
        }

        public void sendNotify(string message)
        {
            IsColors.Items.Add(message);
        }
    }
}

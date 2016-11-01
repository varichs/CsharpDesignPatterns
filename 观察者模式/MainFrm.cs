using System;
using System.Collections;
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
    public partial class MainFrm : Form,Subject
    {
        private ArrayList observers;
        public MainFrm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            EventHandler evh = new EventHandler(RdoBtn_Click);
            RdoBtnRed.Click += evh;
            RdoBtnGreen.Click += evh;
            RdoBtnBlue.Click += evh;

            observers = new ArrayList();
            ColorFrm colorFrm = new ColorFrm(this);
            colorFrm.Show();
            TextFrm textFrm = new TextFrm(this);
            textFrm.Show();
        }

        public void registerInterest(Observer obs)
        {
            observers.Add(obs);
        }

        //private void RdoBtnRed_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (RdoBtnRed.Checked)
        //    {
        //        MessageBox.Show("哈鲁");
        //    }
            
        //}

        //private void RdoBtnGreen_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (RdoBtnGreen.Checked)
        //    {

        //    }
        //}

        //private void RdoBtnBlue_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (RdoBtnBlue.Checked)
        //    {

        //    }
        //}

        private void RdoBtn_Click(object sender, EventArgs e)
        {
            RadioButton but = (RadioButton)sender;
            for(int i = 0; i < observers.Count; i++)
            {
                Observer obs = (Observer)observers[i];
                obs.sendNotify(but.Text);
            }
        }
    }
}

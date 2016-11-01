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
    public partial class ColorFrm : Form,Observer
    {
        private Brush bBrush;
        private Font fnt;
        private Hashtable colors;
        private string colName;
        public ColorFrm(Subject subj)
        {
            InitializeComponent();
            init(subj);
        }

        private void init(Subject subj)
        {
            subj.registerInterest(this);
            fnt = new Font("arial", 18, FontStyle.Bold);
            bBrush = new SolidBrush(Color.Black);
            pic.Paint += new PaintEventHandler(paintHandler);

            //=================
            //make Hashtable for converting color strings
            //=================
            colors = new Hashtable();
            colors.Add("red", Color.Red);
            colors.Add("green", Color.Green);
            colors.Add("blue", Color.Blue);
            colName = "";
        }

        private void paintHandler(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString(colName, fnt, bBrush, 20, 40);
        }

        public void sendNotify(string message)
        {
            colName = message;
            message = message.ToLower();

            Color col = (Color)colors[message];
            pic.BackColor = col;
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        if (components != null)
        //        {
        //            components.Dispose();
        //        }
        //    }
        //    base.Dispose(disposing);
        //}

    }
}

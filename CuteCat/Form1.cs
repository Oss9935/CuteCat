using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CuteCat
{
     public partial class Form1 : Form
     {
          private Cat Mycat = new Cat("BBKIM", 3);

          public Form1()
          {
               InitializeComponent();

          }

          private void Play_Click(object sender, EventArgs e)
          {
               Mycat.Play();
               CatScreen1.Text = Mycat.Express();
          }

          private void Feed_Click(object sender, EventArgs e)
          {
               Mycat.Eat();
               CatScreen1.Text = Mycat.Express();
          }

          private void timer1_Tick(object sender, EventArgs e)
          {
               Mycat.GetBored();
               CatScreen1.Text = Mycat.Express();
          }
     }



}

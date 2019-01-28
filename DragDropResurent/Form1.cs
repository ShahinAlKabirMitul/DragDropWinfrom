using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDropResurent
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(); 
        public Form1()
        {
            InitializeComponent();

          // buttonUserControl1.

            this.panel2.DragOver += new DragEventHandler(panel2_DragOver);
            this.panel2.DragDrop += new DragEventHandler(panel2_DragDrop);


            panel2.AllowDrop = true;
            panel1.AllowDrop = true;

            foreach (Control ctrl in this.panel1.Controls)
            {
                ctrl.MouseDown += new MouseEventHandler(button1_MouseDown);
            }
            foreach (Control ctrl1 in this.panel2.Controls)
            {
                ctrl1.MouseDown += new MouseEventHandler(button1_MouseDown);
            }   
        }
      

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

            Control ctrl1 = sender as Control;
            ctrl1.DoDragDrop(ctrl1, DragDropEffects.Copy);
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {

            Control ctrl1 = sender as Control;
            ctrl1.Top = e.Y;
            ctrl1.Left = e.X;

        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
           
            Control copyControl = e.Data.GetData(e.Data.GetFormats()[0]) as Control;

            buttonUserControl aUserControl = new buttonUserControl();
            aUserControl.pic.Image = copyControl.BackgroundImage;
            aUserControl.lbl.Text = "Table" + rnd.Next();
           
            aUserControl.Location = this.panel2.PointToClient(new Point(e.X, e.Y));
            // Declare rnd globally for creating random id for dynamic button(eg : Random rnd = new Random();)
            Button btn = new Button();
            btn.Name = "Button" + rnd.Next();
            
            if (copyControl != null)
            {
                btn.Text = copyControl.Text;
                btn.BackgroundImage = copyControl.BackgroundImage;
                btn.BackgroundImageLayout = copyControl.BackgroundImageLayout;
                btn.Location = this.panel2.PointToClient(new Point(e.X, e.Y));
                // btn.MouseMove += btn_MouseMove;
                //btn.MouseDown += new MouseEventHandler(btn_MouseDown);
                //   panel2.DragDrop +=panel2_DragDrop; ;
                //  btn.MouseDown += btn_MouseDown;
                ControlExtension.Draggable(aUserControl, true);
               
                this.panel2.Controls.Add(aUserControl);
            }

        }

        void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Control ctrl1 = sender as Control;
            ctrl1.Top = e.Y;
            ctrl1.Left = e.X;
        }

        private void Panel2OnDragOver(object sender, DragEventArgs e)
        {
            //Control ctrl1 = sender as Control;
            //ctrl1.Location = this.PointToClient(new Point(e.X, e.Y));
            //this.Controls.Add(ctrl1);
        }

        void panel2_Move(object sender, EventArgs e)
        {
           
        }

        private void Panel2OnDragDrop(object sender, DragEventArgs e)
        {
           
        }

        void panel2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

      

        private void panel2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ControlExtension.Draggable(button1, true);
        }
    }
}

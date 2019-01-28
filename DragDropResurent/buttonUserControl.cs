using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDropResurent
{
    public partial class buttonUserControl : UserControl
    {
        public bool isPreviewMode = false;
        private SelectionStatus _objectSelectState;
        Nullable<Point> clickPosition;
        double origOffsetLeft;
        double origOffsetTop;

        public Image _ImageDefault_Free;
        public Image _ImageBooked;
        public Image _ImageOcupy;

        public buttonUserControl()
        {
            InitializeComponent();
            _objectSelectState = SelectionStatus.UnSelected;
           // this.Mous += new MouseButtonEventHandler(Control_MouseLeftButtonDown);
           // this.MouseLeftButtonDown += new MouseButtonEventHandler(Control_MouseLeftButtonDown);
            //this.MouseLeftButtonUp += new MouseButtonEventHandler(Control_MouseLeftButtonUp);
            this.MouseMove += new MouseEventHandler(Control_MouseMove);
        }
        public void SetStatusUnSelected()
        {
            _objectSelectState = SelectionStatus.UnSelected;
          
            btnRoateBack.Visible = false;
            btnRoateFront.Visible = false;


        }
        public void ToggoleStatus()
        {
            if (_objectSelectState == SelectionStatus.Selected)
            {
                SetStatusUnSelected();
            }
            else if (_objectSelectState == SelectionStatus.UnSelected)
            {
                SetStatusSelected();
            }
        }

        private void SetStatusSelected()
        {
            _objectSelectState = SelectionStatus.Selected;
            btnRoateBack.Visible = true;
            btnRoateFront.Visible = true;
        }
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPreviewMode)
                return;

            var draggableControl = sender as UserControl;

           

            if (clickPosition != null && e.Button == MouseButtons.Left)
            {

                var element = (UserControl)sender;
                var newPoint = new Point(e.Location.X, e.Location.Y);

                //Canvas.SetLeft(element, origOffsetLeft + ( newPoint.X - clickPosition.Value.X) ); // offset
                //Canvas.SetTop(element, origOffsetTop + (newPoint.Y - clickPosition.Value.Y)); // offsete

                //RotateTransform current = this.RenderTransform as RotateTransform;

                //if (current != null && current.Angle != 0)
                //{
                //    double angle = current.Angle;
                //    current.Angle = 0;
                //    this.RenderTransform = current;

                //    Canvas.SetLeft(element, p2.X - clickPosition.Value.X); // offset
                //    Canvas.SetTop(element, p2.Y - clickPosition.Value.X); // offsete

                //    current.Angle = angle;
                //    this.RenderTransform = current;
                //}
                //else
                //{
              //  Panel. (element, newPoint.X - clickPosition.Value.X); // offset
              //  Canvas.SetTop(element, newPoint.Y - clickPosition.Value.Y); // offsete
                //}

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          //  pic. = pic.Size.Width * 0.75;
          //  pic.Image = resizeImage(pictureBox1.Image, new Size((int)(pictureBox1.Image.Width * factor), (int)(pictureBox1.Image.Height * factor)));
           // pic.Height = pic.Height * 0.75;
        }

        private void buttonUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            //Cursor = Cursors.Hand;

            //// Call MyBase.OnMouseMove to activate the delegate.
            //base.OnMouseMove(e);
        }
    }
}

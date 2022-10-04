
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxAll.Text = TrackBarAll.Value.ToString();
            textBoxY.Text = TrackBarY.Value.ToString();
            textBoxU.Text = TrackBarU.Value.ToString(); 
            textBoxV.Text = TrackBarV.Value.ToString();
        }

        #region TrackBarControl
        private void TrackBarAll_ValueChanged(object sender, EventArgs e)
        {
            textBoxAll.Text = TrackBarAll.Value.ToString();
            YUV2RGB(TrackBarAll.Value, TrackBarAll.Value, TrackBarAll.Value);
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            textBoxAll.Text = TrackBarAll.Value.ToString();
            textBoxY.Text = TrackBarY.Value.ToString();
            textBoxU.Text = TrackBarU.Value.ToString();
            textBoxV.Text = TrackBarV.Value.ToString();
            YUV2RGB(TrackBarY.Value, TrackBarU.Value, TrackBarV.Value);
        }

        private void textBoxAll_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAll.Text == "")
            {
                TrackBarAll.Value = 0;
            }
            else
            {
                TrackBarAll.Value = Convert.ToInt32(textBoxAll.Text);
            }

            if (textBoxY.Text == "")
            {
                TrackBarY.Value = 0;
            }
            else
            {
                TrackBarY.Value = Convert.ToInt32(textBoxY.Text);
            }

            if (textBoxU.Text == "")
            {
                TrackBarU.Value = 0;
            }
            else
            {
                TrackBarU.Value = Convert.ToInt32(textBoxU.Text);
            }

            if (textBoxV.Text == "")
            {
                TrackBarV.Value = 0;
            }
            else
            {
                TrackBarV.Value = Convert.ToInt32(textBoxV.Text);
            }
        }
        #endregion
        private void YUV2RGB(double Y,double U,double V)
        {
            int r, g, b;
            r = Convert.ToInt32(Y + 1.13983 * (V - 128));
            g = Convert.ToInt32(Y - 0.39465 * (U - 128) - 0.58060 * (V - 128));
            b = Convert.ToInt32(Y + 2.03211 * (U - 128));
            if (r > 255)
            {
                r = 255;
            }
            else if (r < 0)
            {
                r = 0;
            }
            if (g > 255)
            {
                g = 255;
            }
            else if (g < 0)
            {
                g = 0;
            }
            if (b > 255)
            {
                b = 255;
            }
            else if (b < 0)
            {
                b = 0;
            }
            ColorHolder.BackColor = Color.FromArgb(r, g, b);
        }


    }
}
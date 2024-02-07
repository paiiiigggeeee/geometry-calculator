using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryCalculator
{
    public partial class GeometryCalculator : Form
    {
        public GeometryCalculator()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (button1.Text == "Calculate")
            {
                if (RBaandp.Checked == true && RBrectangle.Checked == true)
                {
                    float v1 = Convert.ToSingle(TXTv1.Text);
                    float v2 = Convert.ToSingle(TXTv2.Text);
                    TXTarea.Text = Convert.ToString(v1 * v2);
                    TXTperimeter.Text = Convert.ToString(v1 + v1 + v2 + v2);

                }
                else if (RBarea.Checked == true && RBrectangle.Checked == true)
                {
                    float v1 = Convert.ToSingle(TXTv1.Text);
                    TXTarea.Text = Convert.ToString(v1 * v1);

                }
                else if (RBperimeter.Checked == true && RBrectangle.Checked == true)
                {
                    float v1 = Convert.ToSingle(TXTv1.Text);
                    float v2 = Convert.ToSingle(TXTv2.Text);
                    TXTperimeter.Text = Convert.ToString(v1 + v1 + v2 + v2);

                }


                pictureBox1.Image = Image.FromFile(@"C:/C#/GeometryCalculator/rectangle1.jpg");
                txtLength.Visible = true;
                txtWidth.Visible = true;
                TXTarea.Visible = true;
                TXTperimeter.Visible = true;
                textSide.Visible = false;
                lblBase.Visible = false;
                lblHeight.Visible = false;
                lblSide.Visible = false;
                lblWidth.Visible = true;
                lblLength.Visible = true;
                txtBase.Visible = false;
                txtHeight.Visible = false;

            }
            button1.Text = "Answer";
            //Add display of appropriate shape and formula 
            //Add display of appropriate text box and label 
            //else //button says answer 
           /* if (RBaandp.Checked == true && RBrectangle.Checked == true)
              
            {
                float v1 = Convert.ToSingle(txtLength.Text);
                float v2 = Convert.ToSingle(txtWidth.Text);
                TXTarea.Text = Convert.ToString(v1 * v2);
                TXTperimeter.Text = Convert.ToString(v1 + v1 + v2 + v2);
               
            }
            else if (RBarea.Checked == true && RBrectangle.Checked == true)
            {
                float v1 = Convert.ToSingle(txtLength.Text);
                TXTarea.Text = Convert.ToString(v1 * v1);

            }
            else if (RBperimeter.Checked == true && RBrectangle.Checked == true)
            {
                float v1 = Convert.ToSingle(txtLength.Text);
                float v2 = Convert.ToSingle(txtWidth.Text);
                TXTperimeter.Text = Convert.ToString(v1 + v1 + v2 + v2);

            }
            else if (RBaandp.Checked == true && RBSquare.Checked == true)
            {
                float v1 = Convert.ToSingle(txtLength.Text);
                TXTarea.Text = Convert.ToString(v1 * v1);
                TXTperimeter.Text = Convert.ToString(v1 * 4);

            }
            else if (RBarea.Checked == true && RBSquare.Checked == true)
            {
                float v1 = Convert.ToSingle(txtLength.Text);
                TXTarea.Text = Convert.ToString(v1 * v1);

            }
            else if (RBperimeter.Checked == true && RBSquare.Checked == true)
            {
                float v1 = Convert.ToSingle(txtLength.Text);
                TXTperimeter.Text = Convert.ToString(v1 * 4);

            }
            else if (RBaandp.Checked == true && RBparallelogram.Checked == true)
            {
                float v1 = Convert.ToSingle(txtLength.Text);
                float v2 = Convert.ToSingle(txtWidth.Text);
                float v3 = Convert.ToSingle(txtHeight.Text);
                TXTarea.Text = Convert.ToString(v2 * v3);
                TXTperimeter.Text = Convert.ToString(v1 * 2 + v2 * 2);
            }
            else if (RBarea.Checked == true && RBparallelogram.Checked == true)
            {
                float v2 = Convert.ToSingle(txtWidth.Text);
                float v3 = Convert.ToSingle(txtHeight.Text);
                TXTarea.Text = Convert.ToString(v2 * v3);

            }
            else if (RBperimeter.Checked == true && RBparallelogram.Checked == true)
            {
                float v2 = Convert.ToSingle(txtWidth.Text);
                float v1 = Convert.ToSingle(txtLength.Text);
                TXTperimeter.Text = Convert.ToString(v1 * 2 + v2 * 2);
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RBrectangle_CheckedChanged(object sender, EventArgs e)
        {
           

            if (RBrectangle.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"C:/C#/GeometryCalculator/rectangle1.jpg");
                txtLength.Visible = true;
                txtWidth.Visible = true;
                TXTarea.Visible = true;
                TXTperimeter.Visible = true;
                textSide.Visible = false;
                lblBase.Visible = false;
                lblHeight.Visible = false;
                lblSide.Visible = false;
                lblWidth.Visible = true;
                lblLength.Visible = true;
                txtBase.Visible = false;
                txtHeight.Visible = false;

            } */
           

            
            
           
            
            
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void GeometryCalculator_Load(object sender, EventArgs e)
        {

        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSide_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBase_Click(object sender, EventArgs e)
        {

        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TXTarea_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void TXTperimeter_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
    

       
        
    


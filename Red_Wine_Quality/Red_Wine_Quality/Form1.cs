using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Red_Wine_Quality
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alcohol_ratio;
            double sugar_ratio;
            double ph_ratio;
            double quality_ratio = 0;
            string result = "aaa";

            if(!string.IsNullOrEmpty(alcohol_txt.Text))
            {
                alcohol_ratio = double.Parse(alcohol_txt.Text);
            }
            else
            {
                alcohol_ratio = 10.429;
            }
            
            if(!string.IsNullOrEmpty(sugar_txt.Text))
            {
                sugar_ratio = double.Parse(sugar_txt.Text);
            }
            else
            {
                sugar_ratio = 2.508;
            }
            
            if(!string.IsNullOrEmpty(ph_txt.Text))
            {
                ph_ratio = double.Parse(ph_txt.Text);
            }
            else
            {
                ph_ratio = 3.316;
            }

            if (alcohol_ratio > 10.450)
            {
                if(alcohol_ratio > 11.550)
                {
                    if(ph_ratio > 3.365)
                    {
                        if(alcohol_ratio > 13.550)
                        {
                            quality_ratio = 7.0;
                        }
                        else if(alcohol_ratio <= 13.550)
                        {
                            quality_ratio = 6.0;
                        }
                    }
                    else if(ph_ratio <= 3.365)
                    {
                        if(sugar_ratio > 6.350)
                        {
                            quality_ratio = 7.2;
                        }
                        else if(sugar_ratio <= 6.350)
                        {
                            quality_ratio = 6.5;
                        }
                    }
                }
                else if(alcohol_ratio <= 11.550)
                {
                    if(ph_ratio > 3.455)
                    {
                        if(sugar_ratio > 3)
                        {
                            quality_ratio = 4.0;
                        }
                        else if(sugar_ratio <= 3)
                        {
                            quality_ratio = 5.4;
                        }
                    }
                    else if(ph_ratio <= 3.455)
                    {
                        if(sugar_ratio > 3.800)
                        {
                            quality_ratio = 5.5;
                        }
                        else if(sugar_ratio <= 3.800)
                        {
                            quality_ratio = 6.0;
                        }
                    }
                }
            }
            else if(alcohol_ratio <= 10.450)
            {
                if(alcohol_ratio > 9.975)
                {
                    if(sugar_ratio > 5.750)
                    {
                        if(sugar_ratio > 7.400)
                        {
                            quality_ratio = 6.0;
                        }
                        else if(sugar_ratio <= 7.400)
                        {
                            quality_ratio = 7.0;
                        }
                    }
                    else if(sugar_ratio <= 5.750)
                    {
                        if(ph_ratio > 3.425)
                        {
                            quality_ratio = 5.2;
                        }
                        else if(ph_ratio <= 3.425)
                        {
                            quality_ratio = 5.6;
                        }
                    }
                }
                else if(alcohol_ratio <= 9.975)
                {
                    if(ph_ratio <= 3.075)
                    {
                        if(sugar_ratio > 3.300)
                        {
                            quality_ratio = 4.3;
                        }
                        else if(sugar_ratio <= 3.300)
                        {
                            quality_ratio = 5.7;
                        }
                    }
                    else if(ph_ratio > 3.075)
                    {
                        quality_ratio = 5.2;
                    }
                }
            }

            if(quality_ratio >= 7)
            {
                result = "Perfect";
            }
            else if(quality_ratio >= 6 && quality_ratio < 7)
            {
                result = "Good";
            }
            else if(quality_ratio >= 5 && quality_ratio < 6)
            {
                result = "Normal";
            }
            else if(quality_ratio >= 4 && quality_ratio < 5)
            {
                result = "Bad";
            }
            else if(quality_ratio < 4)
            {
                result = "Worst";
            }
            else
            {
                MessageBox.Show("Quality Ratio could not be Determined !");
            }

            quality_ratio_lbl.Text = quality_ratio.ToString();
            result_lbl.Text = result;
            quality_ratio_lbl.Visible = true;
            result_lbl.Visible = true;
        }
    }
}

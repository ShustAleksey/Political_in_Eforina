using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Political_in_Eforina
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Byte tag, k = 10; int PodSoc, PodKon, PodMon, PodLib;Double VSoc,VKon,VMon,Vlib;
        void UpdateVlianie(int rezVliv)
        {
            if (tag == 1)
            {
                VSoc -= rezVliv;
            }
            else
            {
                if (tag == 2)
                {
                    Vlib -= rezVliv;
                }
                else
                {
                    if (tag == 3)
                    {
                        VMon -= rezVliv;
                    }
                    else
                    {
                        if (tag == 4)
                        {
                            VKon -= rezVliv;
                        }
                    }
                }
            }

        }
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (pbYourPodPart.Value >= 50)
            {
                if (pbYourPolit.Value >= 5)
                {
                    if (lPolitStroi.Text!="Конфедерация")
                    {
                        lPolitStroi.Text = "Конфедерация";
                        UpdateVlianie(5);
                        ChekPolitStroi(false);
                    }
                    else
                    {
                        MessageBox.Show("У вас стоит этот закон");
                        return;
                    }

                }
                MessageBox.Show("Ваша поддержка население мало что бы приянть этот закон");
                return;
            }

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (pbYourPodPart.Value >= 50 )
            {
                if (pbYourPolit.Value > 5)
                {
                    if (lPolitStroi.Text != "Федерация")
                    {
                        lPolitStroi.Text = "Федерация";
                        UpdateVlianie(5);
                        ChekPolitStroi(false);
                    }

                }

            }

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            if (tag != 1 )
            {
                if (pbYourPodPart.Value >= 50)
                {
                    if (pbYourPolit.Value > 15)
                        {
                            if (lPolitStroi.Text != "Унитарное")
                            {
                                lPolitStroi.Text = "Унитарное";
                                UpdateVlianie(15);
                                ChekPolitStroi(false);
                            }
                        }
                }


            }

        }
        void ChekVlianieParty()
        {
            VSoc = PodSoc / k;
            Vlib=PodLib/k;
            VMon=PodMon/k;
            VKon=Math.Round((PodKon/k)*0.3);

        }
        void ChekYourParty()
        {
            ChekVlianieParty();
            if (tag == 1)
            {
                pbYourPodPart.Value = PodSoc;
                pbYourPolit.Value =(int)VSoc;
                pbYourProgres.Value = pbSocProg.Value;
            }
            else
            {
                if (tag == 2)
                {
                    pbYourPodPart.Value = PodLib;
                    pbYourPolit.Value =(int)Vlib;
                    pbYourProgres.Value = pbLibProg.Value;
                }
                else
                {
                    if (tag == 3)
                    {
                        pbYourPodPart.Value = PodMon;
                        pbYourPolit.Value =(int)VMon;
                        pbYourProgres.Value = pbMonProg.Value;
                    }
                    else
                    {
                        if (tag == 4)
                        {
                            pbYourPodPart.Value = PodKon;
                            pbYourPolit.Value =(int)VKon;
                            pbYourProgres.Value = pbFasProg.Value;
                        }
                    }
                }
            }
            lPoderz.Text = pbYourPodPart.Value.ToString() + "%";
            lProgress.Text = pbYourProgres.Value.ToString() + "%";
            lVlianie.Text = pbYourPolit.Value.ToString() + "%";
        }
        
        private void президенскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lPolitRezim.Text = президенскийToolStripMenuItem.Text;
        }

        private void смешаннаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lPolitRezim.Text = смешаннаяToolStripMenuItem.Text;
        }

        private void парламенскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lPolitRezim.Text = парламенскийToolStripMenuItem.Text;
        }

        /// <summary>
        /// Метод который проверяет политический строй в стране и накладывает эфекты 
        /// </summary>
        void ChekPolitStroi(bool start)
        {
            
            if (lPolitStroi.Text == "Конфедерация")
            {
                k = 10;
            }
            else
            {
                if (lPolitStroi.Text == "Федерация")
                {
                    k = 5;
                    
                }
                else
                {
                    if (lPolitStroi.Text=="Унитарное")
                    {
                        k = 1;                        
                    }
                }
            }
            if (start)
            {
                ChekVlianieParty();
            }

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddY(VSoc);
            chart1.Series[0].Points.AddY(Vlib);
            chart1.Series[0].Points.AddY(VMon);
            chart1.Series[0].Points.AddY(VKon);
            chart1.Series[0].Points[0].LegendText = "Социалисты";
            chart1.Series[0].Points[0].LabelForeColor = Color.Red;
            chart1.Series[0].Points[0].MarkerColor = Color.Red;
            chart1.Series[0].Points[1].LegendText = "Либералы";
            chart1.Series[0].Points[1].LabelForeColor = Color.ForestGreen;
            chart1.Series[0].Points[2].LegendText = "Монархисты";
            chart1.Series[0].Points[2].LabelForeColor = Color.WhiteSmoke;
            chart1.Series[0].Points[3].LegendText = "Консерваторы";
            chart1.Series[0].Points[3].LabelForeColor = Color.Blue;
        }

        void StartGame()
        {
            Random r = new Random();
            PodSoc = r.Next(100); PodLib = r.Next(100 - PodSoc); PodKon = r.Next(100 - PodLib); PodMon=r.Next(100-PodKon);
            chart2.Series[0].Points.AddY(PodSoc);
            chart2.Series[0].Points[0].LegendText= "Социалисты";
            chart2.Series[0].Points[0].LabelForeColor=Color.Red;
            chart2.Series[0].Points.AddY(PodLib);
            chart2.Series[0].Points[1].LegendText = "Либералы";
            chart2.Series[0].Points[1].LabelForeColor = Color.ForestGreen;
            chart2.Series[0].Points.AddY(PodMon);
            chart2.Series[0].Points[2].LegendText = "Монархисты";
            chart2.Series[0].Points[2].LabelForeColor = Color.WhiteSmoke;
            chart2.Series[0].Points.AddY(PodKon);
            chart2.Series[0].Points[3].LegendText = "Консерваторы";
            chart2.Series[0].Points[3].LabelForeColor = Color.Blue;
            ChekPolitStroi(true);
            ChekYourParty();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

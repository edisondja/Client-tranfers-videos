using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Host_transfers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            List<Media> medias = new List<Media>();


            if (title1.Text != "")
            {

                medias.Add(new Media()
                {
                    title = title1.Text,
                    description = description1.Text,
                    categories = catogries1.Text,
                    host = Host1.Text

                });

            }
            if (title2.Text != "")
            {
                medias.Add(new Media()
                {
                    title = title2.Text,
                    description = description2.Text,
                    categories = categories2.Text,
                    host = host2.Text
             
                });
            }

            if (title3.Text != "")
            {
                medias.Add(new Media()
                {
                    title = title3.Text,
                    description = description3.Text,
                    categories = categories3.Text,
                    host = host3.Text

                });
              
            }

            Transfersfiles w = new Transfersfiles();
            w.TranferFile();

            MessageBox.Show("Transfer filing now");
        }
    }
}

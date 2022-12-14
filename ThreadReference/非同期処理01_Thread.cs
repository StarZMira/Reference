using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadReference
{
    public partial class 非同期処理01_Thread : Form
    {
        public 非同期処理01_Thread()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = new System.Threading.Thread(GetData);
            t.Start();
        }


        private void GetData()
        {
            var result = new List<DTO>();

            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                result.Add(new DTO(i.ToString(), "Name" + 1));
            }

            this.Invoke((Action)delegate ()
            {
                dataGridView1.DataSource = result;
            });

        }



    }
}

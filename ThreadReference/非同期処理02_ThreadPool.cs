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
    public partial class 非同期処理02_ThreadPool : Form
    {
        public 非同期処理02_ThreadPool()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(GetData);
        }


        private void GetData(object o)
        {
            //var dto = o as DTO;
            //if (dto == null)
            //{
            //    return;
            //}

            var result = new List<DTO>();

            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                result.Add(new DTO(i.ToString(), "Name" + 1));
            }

            this.Invoke((Action)delegate ()
            {
                dataGridView1.DataSource = result;
                MessageBox.Show("完了");
            });

        }



    }
}

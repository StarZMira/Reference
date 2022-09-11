using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadReference
{
    public partial class 非同期処理03_Task : Form
    {
        public 非同期処理03_Task()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = TaskScheduler.FromCurrentSynchronizationContext();
            Task.Run(() => GetData()).ContinueWith(x =>
            {
                dataGridView1.DataSource = x.Result;
                MessageBox.Show("完了");
            }, context);
        }


        private List<DTO> GetData()
        {
            var result = new List<DTO>();

            for (int i = 0; i < 5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                result.Add(new DTO(i.ToString(), "Name" + 1));
            }

            return result;
        }



    }
}

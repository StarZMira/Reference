using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadReference
{
    public partial class 非同期処理04_async_await : Form
    {
        public 非同期処理04_async_await()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await Task.Run(()=>GetData());
            MessageBox.Show("完了");
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

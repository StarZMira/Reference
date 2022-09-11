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
    public partial class 同期処理 : Form
    {
        public 同期処理()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData();
        }


        private List<DTO> GetData()
        {
            var result = new List<DTO>();

            for (int i = 0; i < 5; i++)
            {
                result.Add(new DTO(i.ToString(), "Name" + 1));
            }

            return result;
        }
    }
}

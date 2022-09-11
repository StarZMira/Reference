using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadReference
{
    public partial class 非同期処理05_キャンセル : Form
    {
        System.Threading.CancellationTokenSource _token;
        private database _database = new database();

        public 非同期処理05_キャンセル()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            try
            {
                _token = new System.Threading.CancellationTokenSource();
                dataGridView1.DataSource = await Task.Run(() => _database.GetData(_token.Token), _token.Token);
                MessageBox.Show("完了!");
            }
            catch (OperationCanceledException o)
            {
                MessageBox.Show("キャンセルされました");
            }
            finally
            {
                _token.Dispose();
                _token = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _token?.Cancel();
        }
    }
}

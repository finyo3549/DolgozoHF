using System.Configuration;
using System.Text;
using DolgozoKonzol;
using Newtonsoft.Json;

namespace Dolgozo
{
    public partial class Form1 : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = ReadSetting("endpointUrl");

        public static string ReadSetting(string keyName)
        {
            string result = null;
            try
            {
                var value = ConfigurationManager.AppSettings;
                result = value[keyName];
            }
            catch (ConfigurationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        public Form1()
        {
            InitializeComponent();
            listBox_workers.SelectedIndexChanged += listBox_workers_SelectedIndexChanged;
        }

        private void listBox_workers_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Worker worker = (Worker)listBox_workers.SelectedItem;
            textBox_Name.Text = worker.Name;
            numericUpDown_Salary.Value = worker.Salary;
            textbox_Position.Text = worker.Position;
            numericUpDown_ID.Value = worker.Id;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listboxFrissites();
        }

        private async void listboxFrissites()
        {
            listBox_workers.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(endPoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonString = await response.Content.ReadAsStringAsync();
                    var member = Worker.FromJson(jsonString);
                    foreach (Worker item in member)
                    {
                        listBox_workers.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button_Update_Click(object sender, EventArgs e)
        {
            if (listBox_workers.SelectedIndex != -1)
            {
                Worker selectedWorker = (Worker)listBox_workers.SelectedItem;
                selectedWorker.Name = textBox_Name.Text;
                selectedWorker.Salary = (int)numericUpDown_Salary.Value;
                selectedWorker.Position = textbox_Position.Text;

                var json = JsonConvert.SerializeObject(selectedWorker);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"{endPoint}/{selectedWorker.Id}", data);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres módosítás!");
                    listboxFrissites();
                }
                else
                {
                    MessageBox.Show("Sikertelen módosítás!");
                }
                textBox_Name.Clear();
                numericUpDown_Salary.Value = 0;
                textbox_Position.Clear();

            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem!");
            }
        }

        private async void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_workers.SelectedIndex != -1)
            {
                Worker selectedWorker = (Worker)listBox_workers.SelectedItem;
                selectedWorker.Name = textBox_Name.Text;
                selectedWorker.Salary = (int)numericUpDown_Salary.Value;
                selectedWorker.Position = textbox_Position.Text;
                selectedWorker.Id = (int)numericUpDown_ID.Value;

                var json = JsonConvert.SerializeObject(selectedWorker);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.DeleteAsync($"{endPoint}/{selectedWorker.Id}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres törlés!");
                    listboxFrissites();
                }
                else
                {
                    MessageBox.Show("Sikertelen törlés!");
                }
                textBox_Name.Clear();
                numericUpDown_Salary.Value = 0;
                textbox_Position.Clear();

            }
            else
            {
                MessageBox.Show("Nincs kiválasztott elem!");
            }
        }

        private void button_New_Click(object sender, EventArgs e)
        {
            NewForm newForm = new NewForm();
            newForm.ShowDialog();
        }
    }
}


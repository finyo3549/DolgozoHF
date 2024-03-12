using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DolgozoKonzol;
using Newtonsoft.Json;

namespace Dolgozo
{
    public partial class NewForm : Form
    {
        HttpClient client = new HttpClient();
        string endPoint = Form1.ReadSetting("endpointUrl");
        public NewForm()
        {
            InitializeComponent();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {

        }

        private void NewForm_Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewForm_button_Save_Click(object sender, EventArgs e)
        {
            if (NewForm_numericUpDown_Salary.Value == 0 || Newform_textbox_Name.Text == "" || NewForm_textbox_Position.Text == "")
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
            }
            else
            {
                Worker worker = new Worker();   
                worker.Name = Newform_textbox_Name.Text;
                worker.Salary = (int)NewForm_numericUpDown_Salary.Value;
                worker.Position = NewForm_textbox_Position.Text;
                
                string json = JsonConvert.SerializeObject(worker);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = client.PostAsync(endPoint, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sikeres mentés!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sikertelen mentés!");
                }
            }       
        }
    }
}

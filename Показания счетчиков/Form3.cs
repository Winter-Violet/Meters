using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Показания_счетчиков
{
    public partial class formAddMeter : Form
    {
        public formAddMeter()
        {
            InitializeComponent();
        }
        DataBase dataBase3 = new DataBase();

        private void addMeterClose_Click(object sender, EventArgs e)
        {
            string variableComment = "";
            if (combChooseMeter3.SelectedIndex > -1)
            {
                //Выбор услуги
                string service = Convert.ToString (combChooseMeter3.SelectedItem);
                
                //Название
                if (comment.Text != "")
                {
                    variableComment = comment.Text;
                    dataBase3.AddMeter(service, variableComment);
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
                
                
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void combChooseMeter3_DropDown(object sender, EventArgs e)
        {
            combChooseMeter3.Items.Clear();
            string[] service = new string[dataBase3.Service().Length];

            service = dataBase3.Service();
            for (int i = 0; i < service.Length; i++)
            {
                combChooseMeter3.Items.Add(service[i]);
            }
        }
    }
}

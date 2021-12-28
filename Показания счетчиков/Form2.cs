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
    public partial class formAddValue : Form
    {
        public formAddValue()
        {
            InitializeComponent();
            //DateTime today = DateTime.Today;
            dateTimePicker1.Value = DateTime.Now;


        }
        DataBase dataBase2 = new DataBase();
        private void addValueClose_Click(object sender, EventArgs e)
        {
            if(combChooseMeter2.SelectedIndex > -1 && Value.Text != "")
            {
                

                //показания
                try
                {
                    //проверка на положительное число
                    if (Convert.ToInt32(Value.Text) > 0)
                    {
                        //определение счетчика
                        string meter = combChooseMeter2.SelectedItem.ToString();

                        //выбранная дата
                        string date = dateTimePicker1.Value.ToString();
                        Console.WriteLine(date);
                        int value = Convert.ToInt32(Value.Text);
                        dataBase2.AddMetersData(meter,date,value);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Введите положительное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Value.Clear();
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите целое число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Value.Clear();
                }

                
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void combChooseMeter2_DropDown(object sender, EventArgs e)
        {

            combChooseMeter2.Items.Clear();
            string[] name = new string[dataBase2.MetersNames().Length];
            name = dataBase2.MetersNames();
            for (int i = 0; i < name.Length; i++)
            {
                combChooseMeter2.Items.Add(name[i]);
            }




        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {





































































        }
    }
}

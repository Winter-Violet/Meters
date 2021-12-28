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
    public partial class Parent : Form
    {
        public Parent()
        {
            InitializeComponent();
        }


        public string measurement;
        DataBase dataBase = new DataBase();
        
        //добавить показание
        private void addValue_Click(object sender, EventArgs e)
        {
            formAddValue form2 = new formAddValue();
            form2.Show();
        }
        
        //добавить счетчик
        private void addMeter_Click(object sender, EventArgs e)
        {
            formAddMeter form3 = new formAddMeter();
            form3.Show();
            
        }
        
        //добавить цену услуги
        private void addPrice_Click(object sender, EventArgs e)
        {
            

            if (combChooseMeter4.SelectedIndex > -1 && servicePrice.Text != "")
            {
                //Выбор услуги
                
                string service = Convert.ToString(combChooseMeter4.Text);
                

                //Стоимость
                try
                {
                    //проверка на положительное число
                    if (Convert.ToDouble(servicePrice.Text) > 0)
                    {
                        double price = Convert.ToDouble(servicePrice.Text);
                        
                        switch (service)
                        {
                            case "Холодное водоснабжение":
                                measurement = "м³";
                                dataBase.AddPrice(service, price, measurement);
                                break;

                            case "Горячее водоснабжение":
                                measurement = "м³";
                                dataBase.AddPrice(service, price, measurement);
                                break;

                            case "Электроснабжение":
                                measurement = " кВт*ч";
                                dataBase.AddPrice(service, price, measurement);
                                break;

                            case "Газоснабжение":
                                measurement = "м³";
                                dataBase.AddPrice(service, price, measurement);

                                break;

                        }

                        showTable();
                        combChooseMeter4.SelectedIndex = -1;
                        servicePrice.Clear();                     
                    }
                    else
                    {
                        MessageBox.Show("Введите положительное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        servicePrice.Clear();
                    }
                    
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    servicePrice.Clear();
                }

            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        private void combChooseMeter_DropDown(object sender, EventArgs e)
        {

            combChooseMeter.Items.Clear();
            string[] name = new string[dataBase.MetersNames().Length];

            name = dataBase.MetersNames();
            for (int i = 0; i < name.Length; i++)
            {
                
                combChooseMeter.Items.Add(name[i]);
            }
            //RefreshDataGridView1();

            //List<string[]> data = new List<string[]>();
            //data = dataBase.Values(Convert.ToString(combChooseMeter.SelectedItem));
            //foreach (string[] s in data)
            //{
            //    dataGridView1.Rows.Add(s);
            //}

        }
        //переход на другую вкладку
        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            showTable();
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (combChooseMeter4.Items.Contains(dataGridView2.Rows[i].Cells[0].Value) == true)
                {
                    string text = Convert.ToString(dataGridView2.Rows[i].Cells[0].Value);
                    combChooseMeter4.Items.Remove(text);
                }

            }
            combChooseMeter5.Items.Clear();
            combChooseMeter6.Items.Clear();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                combChooseMeter5.Items.Add(dataGridView2.Rows[i].Cells[0].Value);
                combChooseMeter6.Items.Add(dataGridView2.Rows[i].Cells[0].Value);
            }

        }
        //обновление datagridview2
        public void showTable()
        {
            dataGridView2.Rows.Clear();
            List<string[]> data = new List<string[]>();
            data = dataBase.Prices();

            foreach (string[] s in data)
            {
                dataGridView2.Rows.Add(s);
            }
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (combChooseMeter4.Items.Contains(Convert.ToString(dataGridView2.Rows[i].Cells[0].Value)) == true)
                {
                    string text = Convert.ToString(dataGridView2.Rows[i].Cells[1].Value);
                    combChooseMeter4.Items.Remove(text);
                }

            }
            combChooseMeter5.Items.Clear();
            combChooseMeter6.Items.Clear();
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                combChooseMeter5.Items.Add(dataGridView2.Rows[i].Cells[0].Value);
                combChooseMeter6.Items.Add(dataGridView2.Rows[i].Cells[0].Value);
            }
        }
        //изменить стоимость услуги
        private void changePrice_Click(object sender, EventArgs e)
        {
            //string[] price = new string[dataGridView2.Rows.Count];
            //for (int i = 0;i < price.Length; i++)
            //{
            //    price[i] = Convert.ToString(dataGridView2.Rows[i].Cells[2].Value);
            //}
            //List<string[]> newPrice = new List<string[]>();

            // newPrice = dataBase.ChangeValue(price);
            //foreach (string[] s in newPrice)
            //{
            //    dataGridView2.Rows.Add(s);
            //}
            if (combChooseMeter5.SelectedIndex > -1 && newServicePrice.Text != "")
            {
                //Выбор услуги
                string service = Convert.ToString(combChooseMeter5.SelectedItem);
                try
                {
                    //проверка на положительное число
                    if (Convert.ToDouble(newServicePrice.Text) > 0)
                    {
                        string newPrice = newServicePrice.Text;
                        dataBase.ChangePriceValue(service, newPrice);
                        dataGridView2.Rows[combChooseMeter5.SelectedIndex].Cells[1].Value = newPrice;
                        


                        //combChooseMeter5.SelectedItem = "";
                        combChooseMeter5.SelectedIndex = -1;
                        newServicePrice.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Введите положительное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        newServicePrice.Clear();
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Введите число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newServicePrice.Clear();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //удалить стоимость услуги
        private void deletePrice_Click(object sender, EventArgs e)
        {

            string name;
            
            if (combChooseMeter6.SelectedIndex > -1)
            {
                string deletePrice = combChooseMeter6.Text;
                
                dataGridView2.Rows.RemoveAt(combChooseMeter6.SelectedIndex);
                
                dataBase.DeletePriceValue(deletePrice);
                combChooseMeter6.SelectedIndex = -1;
                showTable();

                
            }
        }
        //при изменении значения comboBox, обновляется dataGridView
        private void combChooseMeter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView1(Convert.ToString(combChooseMeter.SelectedItem));
        }
        private void RefreshDataGridView1(string meter)
        {
            dataGridView1.Rows.Clear();
            List<string[]> data = new List<string[]>();
            data = dataBase.Values(Convert.ToString(combChooseMeter.SelectedItem));
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
            
            double price;
            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                price = dataBase.Prices2(meter);
                
                
                if (i == 0 ){
                    dataGridView1.Rows[0].Cells[2].Value = Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value);
                    dataGridView1.Rows[0].Cells[3].Value = price * Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value);
                    
                }
                else
                {
                    dataGridView1.Rows[i].Cells[2].Value = Convert.ToInt32( dataGridView1.Rows[i].Cells[1].Value) - Convert.ToInt32(dataGridView1.Rows[i-1].Cells[1].Value);
                    dataGridView1.Rows[i].Cells[3].Value = price * Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);


                }
          
            }
                
            
            
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace task8
{

    


    public partial class Form1 : Form
    {
        string way="data.xml";
        string serch="";
        int serch_number = 1;
        int delet = 0;
        Kom insert = new Kom { 
            Number_of_house=-1, 
            Number_of_flat = -1, 
            Last_name = "", 
            Type = 'r', 
            Data = new DateTime(1000, 1, 1), 
            Sum = -1, 
            Prochent = -1, 
            Pr = -1 };


        bool Check()
        {
            bool ans = true;
            if(insert.Number_of_house<=0)
            {
                ans= false;
            }
            if (insert.Number_of_flat <= 0)
            {
                ans = false;
            }
            if (insert.Last_name =="")
            {
                ans = false;
            }
            if (!(insert.Type =='e' || insert.Type=='g'|| insert.Type == 'r' || insert.Type == 'w'))
            {
                ans = false;
            }
            if (insert.Data == new DateTime(1000, 1, 1))
            {
                ans = false;

            }
            if (!(insert.Sum > 0 && insert.Sum*100%1==0))
            {
                ans = false;
            }
            if (insert.Prochent < 0)
            {
                ans = false;
            }
            if (insert.Pr < 0)
            {
                ans = false;
            }
            return ans;
        }

        void Write_into_file(IEnumerable<Kom> data)
        {
            var x_data = new XDocument(new XDeclaration("1.0","utf-8","yes"),new XElement("Koms",data.Select(d=>new XElement("Kom",
                new XAttribute("Number_of_house",d.Number_of_house), new XAttribute("Number_of_flat", d.Number_of_flat), new XAttribute("Last_name", d.Last_name),
                new XAttribute("Type", d.Type), new XAttribute("Data", d.Data), new XAttribute("Sum", d.Sum),
                new XAttribute("Prochent", d.Prochent), new XAttribute("Pr", d.Pr)))));
            x_data.Save(way);
        }

        IEnumerable<Kom> Read_from_xml()
        {
            var data = (from i in XDocument.Load(way).Descendants("Kom") select new Kom { Number_of_house = (int)i.Attribute("Number_of_house"), Number_of_flat = (int)i.Attribute("Number_of_flat")
                        , Last_name = (string)i.Attribute("Last_name"), Type = (char)((string)i.Attribute("Type"))[0], Data = (DateTime)i.Attribute("Data"), 
                                Sum = (double)i.Attribute("Sum"), Prochent = (double)i.Attribute("Prochent"), Pr = (int)i.Attribute("Pr")
            });
            return data;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void number_of_house_Click(object sender, EventArgs e)
        {

        }

        private void number_of_flat_Click(object sender, EventArgs e)
        {

        }

        private void last_name_Click(object sender, EventArgs e)
        {

        }

        private void type_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var list = Read_from_xml();
                if (serch != "")
                {
                    switch (serch_number)
                    {
                        case 1:
                            list = from i in Read_from_xml() where i.Number_of_house == Convert.ToInt32(serch) select i;
                            break;
                        case 2:
                            list = from i in Read_from_xml() where i.Number_of_flat == Convert.ToInt32(serch) select i;
                            break;
                        case 3:
                            list = from i in Read_from_xml() where i.Last_name == serch select i;
                            break;
                        case 4:
                            list = from i in Read_from_xml() where i.Type == Convert.ToChar(serch) select i;
                            break;
                        case 5:
                            list = from i in Read_from_xml() where i.Data == Convert.ToDateTime(serch) select i;
                            break;
                    }
                }
                show_serch.Text = "";
                int y = 1;
                foreach (var i in list)
                {
                    show_serch.Text += y+") "+i.Number_of_house + " " + i.Number_of_flat + " " + i.Last_name + " " +
                        i.Type + " " + i.Data + " " + i.Sum + " " + i.Prochent + " " + i.Pr + '\r' + '\n';
                    y++;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void number_of_house_CheckedChanged(object sender, EventArgs e)
        {
            serch_number = 1;
        }

        private void number_of_flat_CheckedChanged(object sender, EventArgs e)
        {
            serch_number = 2;
        }

        private void last_name_CheckedChanged(object sender, EventArgs e)
        {
            serch_number = 3;
        }

        private void type_CheckedChanged(object sender, EventArgs e)
        {
            serch_number = 4;
        }

        private void date_CheckedChanged(object sender, EventArgs e)
        {
            serch_number = 5;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            serch = serch_type.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            IEnumerable<Kom> list = Read_from_xml();
            List<Kom> ans = new List<Kom>();
            int y = 1;
            //MessageBox.Show(Convert.ToString(delet));
            foreach (var i in list)
            {
                    ans.Add(i);
            }
            if (Check())
            {
                ans.Add(insert);
                Write_into_file(ans);


                show_serch.Text = "";
                y = 1;
                foreach (var i in ans)
                {
                    show_serch.Text += y + ") " + i.Number_of_house + " " + i.Number_of_flat + " " + i.Last_name + " " +
                        i.Type + " " + i.Data + " " + i.Sum + " " + i.Prochent + " " + i.Pr + '\r' + '\n';
                    y++;
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                insert.Number_of_house = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                insert.Number_of_flat = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                insert.Last_name = textBox3.Text;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                insert.Type = Convert.ToChar(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                insert.Data = Convert.ToDateTime(textBox5.Text);
            }
            catch
            {
                //MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                insert.Sum = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                insert.Prochent = Convert.ToDouble(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                insert.Pr = Convert.ToInt32(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void delete_text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                delet = Convert.ToInt32(delete_text.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            IEnumerable<Kom> list = Read_from_xml();
            List<Kom> ans = new List<Kom>();
            int y = 1;
            //MessageBox.Show(Convert.ToString(delet));
            foreach (var i in list)
            {
                
                if (y != delet)
                    ans.Add(i);
                y++;
            }
            Write_into_file(ans);


            show_serch.Text = "";
            y = 1;
            foreach (var i in list)
            {
                show_serch.Text += y + ") " + i.Number_of_house + " " + i.Number_of_flat + " " + i.Last_name + " " +
                    i.Type + " " + i.Data + " " + i.Sum + " " + i.Prochent + " " + i.Pr + '\r' + '\n';
                y++;
            }


        }
    }


    class Kom
    {
        public int Number_of_house { get; set; }
        public int Number_of_flat { get; set; }
        public string Last_name { get; set; }
        public char Type { get; set; }

        public DateTime Data { get; set; }

        public double Sum { get; set; }

        public double Prochent { get; set; }

        public int Pr { get; set; }



        public static IEnumerable<Kom> Create_start_values()
        {
            return new List<Kom> { new Kom { Number_of_house=100, Number_of_flat=100, Last_name="A",Type='e',Data = new DateTime(2020, 7, 20),Sum=1200,Prochent=0.1,Pr=0},
            new Kom { Number_of_house=101, Number_of_flat=101, Last_name="A",Type='e',Data = new DateTime(2020, 7, 20),Sum=1200,Prochent=0.1,Pr=0},
            new Kom { Number_of_house=102, Number_of_flat=102, Last_name="B",Type='g',Data = new DateTime(2020, 6, 19),Sum=1100,Prochent=0.12,Pr=3},
            new Kom { Number_of_house=103, Number_of_flat=103, Last_name="C",Type='w',Data = new DateTime(2019, 7, 20),Sum=1000,Prochent=0.13,Pr=5},
            new Kom { Number_of_house=104, Number_of_flat=104, Last_name="D",Type='r',Data = new DateTime(2020, 7, 6),Sum=1500,Prochent=0.14,Pr=13},
            new Kom { Number_of_house=105, Number_of_flat=105, Last_name="E",Type='e',Data = new DateTime(2020, 2, 20),Sum=1800,Prochent=0.15,Pr=10}};
        }


    }

}

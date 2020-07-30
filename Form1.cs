using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace Task
{
    public partial class Application : Form
    {
        List<Book> product_List = new List<Book>();
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        

        public Application()
        {
            InitializeComponent();
          
        }

       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
      
        private void Open_Click(object sender, EventArgs e)
        {
            //открытие файла пишем
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                /*  XmlSerializer serializer = new XmlSerializer(typeof(List<Book>), new XmlRootAttribute("bookstore"));
                  var xmlString = File.ReadAllText(openFile.FileName);
                  StringReader stringReader = new StringReader(xmlString);
                  product_List = (List<Book>)serializer.Deserialize(stringReader);
                  dataGridView1.DataSource = product_List;*/
                BookCollection Books;
               string path = openFile.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(BookCollection));

                StreamReader reader = new StreamReader(path);
                Books = (BookCollection)serializer.Deserialize(reader);
                dataGridView1.DataSource = Books;
                reader.Close();
               
            }
            else
            {
                MessageBox.Show("File is not found");
            }
        }
        //SAVE_FILE
        private void Save_Click(object sender, EventArgs e)
        {
          
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace OOPLab3
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> genresProperties = new Dictionary<string, string>();
        string CHECK;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Initialization objcts = new Initialization();
            genresProperties = objcts.initProperties(genresProperties);
        }


        private void Serialize_Click(object sender, EventArgs e)
        {
            List<string> genreList = new List<string>();
            
            for (int i=0; i<=objectsList.Items.Count-1; i++)
            {
                genreList.Add(objectsList.Items[i].ToString());
            }
            
            Initialization objcts = new Initialization();
            var genres = objcts.initObjects(genreList, genresProperties);

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };

            var json = JsonConvert.SerializeObject(genres, settings);
            FileInfo f = new FileInfo("D:\\genres.json");
            using (StreamWriter sw = f.CreateText())
            {
                sw.WriteLine(json);
            }

        }


        private void addObject_Click(object sender, EventArgs e)
        {
            objectsList.Items.Add(objectsBox.SelectedItem);
        }


        private void deleteObject_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(objectsList);
            selectedItems = objectsList.SelectedItems;
            for (int i = selectedItems.Count - 1; i >= 0; i--)
                objectsList.Items.Remove(selectedItems[i]);
        }


        private void Deserialize_Click(object sender, EventArgs e)
        {
            List<string> genreList = new List<string>();

            for (int i = 0; i <= objectsList.Items.Count - 1; i++)
            {
                genreList.Add(objectsList.Items[i].ToString());
            }

            Initialization objcts = new Initialization();
            var genres = objcts.initObjects(genreList, genresProperties);

            JsonSerializerSettings settings = new JsonSerializerSettings 
            { 
                TypeNameHandling = TypeNameHandling.All
            };

            string f = System.IO.File.ReadAllText("D:\\genres.json");
            genres = JsonConvert.DeserializeObject<List<Genre>>(f, settings);

            foreach (var key in genres)
            {
                listBox1.Items.Add(key.bookExample);
            } 
        }


        private void button1_Click(object sender, EventArgs e)
        {
            genresProperties[objectsList.SelectedItem.ToString()] = textBox1.Text;
        }

        

    }
}

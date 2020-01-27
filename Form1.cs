using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml;
using System.Xml.Serialization;


namespace POlab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SERIALIZE JSON
        private void button1_Click(object sender, EventArgs e)
        {
            Person FormToSave = new Person(

                                            this.FnameTB.Text,
                                            this.LnameTB.Text,
                                            this.BirthDate.Value.ToShortDateString(),
                                            this.AddressTB.Text
                                            );



            string PersonJson = JsonConvert.SerializeObject(FormToSave);

            SaveFileDialog saveDialog = new SaveFileDialog()
            {
                Title = "Zapisz dane osoby do pliku",
                Filter = "txt (*.txt)|*.txt",
                DefaultExt = "txt",
                AddExtension = true,
                OverwritePrompt = false
            };



            if (saveDialog.ShowDialog() == DialogResult.OK)

            {
                using (StreamWriter sw = new StreamWriter(saveDialog.FileName, true))
                {
                    sw.WriteLine(PersonJson);
                };
            }


            MessageBox.Show("Zapisano dane do pliku tekstowego.");

        }
        // DESERIALIZE JSON
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wybierz plik txt.");

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var stream = openFileDialog1.OpenFile();
                StreamReader reader = new StreamReader(stream);
                string JsonIsOpen;

                List<Person> person = new List<Person>();

                while (!reader.EndOfStream)
                {
                    JsonIsOpen = reader.ReadLine();
                    Person newperson = JsonConvert.DeserializeObject<Person>(JsonIsOpen);
                    person.Add(newperson);
                }
                reader.Close();

                listBox1.DataSource = person;
            }

            MessageBox.Show("Wczytano plik tekstowy.");

        }
        // SAVE TO XML
        private void buttonXMLsave_Click(object sender, EventArgs e)
        {
            List<Person> listOfPeople = listBox1.Items.Cast<Person>().ToList();
            PeopleGroup people = new PeopleGroup(listOfPeople);

            SaveFileDialog saveDialog = new SaveFileDialog()
            {
                Title = "Save to file",
                Filter = "xml files (*.xml)|*.xml",
                DefaultExt = "xml",
                AddExtension = true,
                OverwritePrompt = false
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer SerializerObj = new XmlSerializer(typeof(PeopleGroup));
                TextWriter WriteFileStream = new StreamWriter(saveDialog.FileName);
                SerializerObj.Serialize(WriteFileStream, people);
                WriteFileStream.Close();
            }
        }

        // DESERIALIZE XML AND OPEN IN LISTBOX1
        private void buttonXMLopendes_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "xml files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(PeopleGroup));
                    PeopleGroup deserializedPeople;

                    using (Stream reader = openFileDialog.OpenFile())
                    {
                        deserializedPeople = (PeopleGroup)serializer.Deserialize(reader);
                    }
                    listBox1.DataSource = deserializedPeople.People;
                }
            }
        }
        // SAVE TO MEMORY
        private void buttonMemorySave_Click(object sender, EventArgs e)
        {
            {
                Person FormToSave = new Person(
                       this.FnameTB.Text,
                       this.LnameTB.Text,
                       this.BirthDate.Value.ToShortDateString(),
                       this.AddressTB.Text);

                listBox1.Items.Add(FormToSave);
            }
        }
    }
}

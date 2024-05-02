
using System.Xml;
namespace XMLForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void btnShowCD_Click(object sender, EventArgs e)
        {
            String URLString = "https://www.w3schools.com/xml/cd_catalog.xml";
            XmlTextReader Reader = new XmlTextReader(URLString);

            while (Reader.Read())
            {
                switch (Reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        txtCD.Text += ("<" + Reader.Name);

                        while (Reader.MoveToNextAttribute()) // Read the attributes.
                            txtCD.Text += (" " + Reader.Name + "='" + Reader.Value + "'");
                        txtCD.Text += (">") + Environment.NewLine; ;
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        txtCD.Text += (Reader.Value) + Environment.NewLine; ;
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        txtCD.Text += ("</" + Reader.Name);
                        txtCD.Text += (">") + Environment.NewLine; ;
                        break;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            

           
        }
    }

    
}
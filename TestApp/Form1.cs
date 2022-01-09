using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SharpUpdater;

namespace TestApp
{
    public partial class Form1 : Form,ISharpUpdatable
    {
        private SharpUpdaterSystem updater;
        public Form1()
        {
            InitializeComponent();

            this.label1.Text = this.ApplicationAssembly.GetName().Version.ToString();
            updater = new SharpUpdaterSystem(this);
        }

        public string ApplicationName { get { return "TestApp"; } }

        public string ApplicationID { get { return "TestApp"; } }

        public Assembly ApplicationAssembly { get { return Assembly.GetExecutingAssembly(); } }

        public Icon ApplicationIcon { get { return this.Icon; } }

        public Uri UpdateXmlLocation { get { return new Uri("http://f0564038.xsph.ru/TestSystem/update.xml"); } }

        public Form Context { get { return this; } }

        private void button1_Click(object sender, EventArgs e)
        {
            updater.DoUpdate();
        }
    }
}

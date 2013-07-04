using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace QA
{
    public partial class Form1 : Form
    {

        String fileName;
        XmlDocument xmlDoc = new XmlDocument();
        List<QA.QAElement> qaList = new List<QA.QAElement>();
        QAElement currentqa;
        Random r;

        public Form1()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            //setup Open File Dialog
            OpenFileDialog openfileDiag = new OpenFileDialog();
            openfileDiag.Filter = "XML Files| *.xml";



            using (openfileDiag)
            {
                try
                {
                    if (openfileDiag.ShowDialog() == DialogResult.OK)
                    {
                        fileName = openfileDiag.FileName;

                        XmlReaderSettings readersettings = new XmlReaderSettings();
                        readersettings.IgnoreComments = true;
                        readersettings.IgnoreWhitespace = true;

                        XmlReader reader = XmlReader.Create(fileName, readersettings);

                        this.xmlDoc.Load(fileName);

                        parseDoc(xmlDoc);

                        startBtn.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void parseDoc(XmlDocument doc)
        {

            XmlNode root = doc.ChildNodes[1];

            for(int i = 0; i<root.ChildNodes.Count; i++)
            {
                XmlNode x = root.ChildNodes[i];
                QAElement qa = new QAElement(x);
                qaList.Add(qa);
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            r = new Random();
            currentqa = qaList[r.Next(qaList.Count)];
            questionTb.Text = currentqa.getQ();

            answerBtn.Enabled = true;
            nextBtn.Enabled = true;
        }

        private void answerBtn_Click(object sender, EventArgs e)
        {
            if (currentqa != null)
            {
                answerTb.Text = currentqa.getA();
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            currentqa = qaList[r.Next(qaList.Count)];
            questionTb.Text = "";
            answerTb.Text = "";

            questionTb.Text = currentqa.getQ();
        }
    }
}

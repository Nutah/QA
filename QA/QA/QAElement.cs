using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace QA
{
    class QAElement
    {
        XmlNode qa;
        XmlNode q;
        XmlNode a;
        

        public QAElement(XmlNode node)
        {
            this.qa = node;
            if (node.HasChildNodes)
            {
                this.q = node.ChildNodes[0];
                this.a = node.ChildNodes[1];
            }
        }

        public String getQ()
        {
            String ret = "empty";
            if (this.q != null)
            {
                ret = q.InnerText;
            }
            return ret;
        }

        public String getA()
        {
            String ret = "empty";
            if (this.a != null)
            {
                ret = a.InnerText;
            }
            return ret;
        }

    }
}

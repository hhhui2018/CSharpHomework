using System;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformTest
{
    class Program
    {
        public static void Transform(string sXmlPath, string sXslPath)
        {
            try
            {
                //load the Xml doc
                XPathDocument myXPathDoc = new XPathDocument(@"D:\C#_lesson\homework8");

                XslTransform myXslTrans = new XslTransform();

                //load the Xsl 
                myXslTrans.Load(@"D:\C#_lesson\homework8");

                //create the output stream
                XmlTextWriter myWriter = new XmlTextWriter
                    ("Order.html", null);

                //do the actual transform of Xml
                myXslTrans.Transform(myXPathDoc, null, myWriter);

                myWriter.Close();

            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: {0}", e.ToString());
            }

        }

        public static void PrintUsage()
        {
            Console.WriteLine
            ("Usage: XmlTransformUtil.exe <xml path> <xsl path>");
        }
    }
}

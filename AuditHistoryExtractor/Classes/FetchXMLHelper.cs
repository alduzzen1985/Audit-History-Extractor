using System.IO;
using System.Text;
using System.Xml;

namespace AuditHistoryExtractor.Classes
{
    public static class FetchXMLHelper
    {
        public static string CreateXml(string xml, string cookie, int page, int count)
        {
            StringReader stringReader = new StringReader(xml);
            XmlTextReader reader = new XmlTextReader(stringReader);

            // Load document
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);

            return CreateXml(doc, cookie, page, count);
        }


        public static string CreateXml(XmlDocument doc, string cookie, int page, int count)
        {
            XmlAttributeCollection attrs = doc.DocumentElement.Attributes;

            if (cookie != null)
            {
                XmlAttribute pagingAttr = doc.CreateAttribute("paging-cookie");
                pagingAttr.Value = cookie;
                attrs.Append(pagingAttr);
            }

            XmlAttribute pageAttr = doc.CreateAttribute("page");
            pageAttr.Value = System.Convert.ToString(page);
            attrs.Append(pageAttr);

            XmlAttribute countAttr = doc.CreateAttribute("count");
            countAttr.Value = System.Convert.ToString(count);
            attrs.Append(countAttr);

            StringBuilder sb = new StringBuilder(1024);
            StringWriter stringWriter = new StringWriter(sb);

            XmlTextWriter writer = new XmlTextWriter(stringWriter);
            doc.WriteTo(writer);
            writer.Close();

            return sb.ToString();
        }


        public static string AddAttributeFilter(string fetchXML, string attributeToAdd)
        {
            // Load document
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(fetchXML);

            XmlAttributeCollection attrs = doc.DocumentElement.Attributes;

            foreach (XmlElement node in doc.DocumentElement.ChildNodes)
            {
                if (node.Name.Equals("entity"))
                {
                    XmlElement e = node.OwnerDocument.CreateElement("attribute");
                    XmlAttribute countAttr = doc.CreateAttribute("name");
                    countAttr.Value = attributeToAdd;
                    attrs.Append(countAttr);
                    e.Attributes.Append(countAttr);
                    node.AppendChild(e);
                }
            }


            return doc.InnerXml;
        }

        public static string AddCookie(string fetchXML, string cookie, int page)
        {
            if (page > 1)
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(fetchXML);

                XmlElement fetch = doc.DocumentElement;
                XmlAttribute cookieAttr = doc.CreateAttribute("cookie");
                cookieAttr.Value = cookie;

                XmlAttribute pageAttr = doc.CreateAttribute("page");
                pageAttr.Value = $"{page}";

                fetch.Attributes.Append(cookieAttr);
                fetch.Attributes.Append(pageAttr);

                return doc.OuterXml;
            }
            else
            {
                return fetchXML;
            }
        }
    }
}

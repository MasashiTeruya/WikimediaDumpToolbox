using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace WikimediaDumpToolbox
{
    using Models;
    /// <summary>
    /// Sequential article reader
    /// </summary>
    public class PageReader : IDisposable
    {
        #region Constructors

        /// <summary>
        /// Initialize with file path
        /// </summary>
        /// <param name="path">Path to pages-articles.xml</param>
        public PageReader(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                throw new ArgumentNullException(nameof(path));
            }
            Reader = XmlReader.Create(path);
        }

        /// <summary>
        /// Initialize with XmlReader
        /// </summary>
        /// <param name="reader">XmlReader</param>
        public PageReader(XmlReader reader)
        {
            if (reader == null)
            {
                throw new ArgumentNullException(nameof(reader));
            }
            Reader = reader;
        }

        #endregion

        private XmlReader Reader;

        public void Dispose()
        {
            Reader.Dispose();
        }

        public IEnumerable<PageType> Read()
        {
            var reader = Reader;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element
                    && reader.Name == "page")
                {
                    var serializer = new XmlSerializer(typeof(PageType));
                    var page = serializer.Deserialize(reader) as PageType;
                    if (page != null)
                    {
                        yield return page;
                    }
                }
            }
        }

    }
}

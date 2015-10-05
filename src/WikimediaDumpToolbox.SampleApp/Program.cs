using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikimediaDumpToolbox.SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Wikipedia\jawiki-latest-pages-articles.xml";
            using (var reader = new PageReader(path))
            {
                foreach (var item in reader.Read())
                {
                    Console.WriteLine(item.title);
                }
            }
        }
    }
}

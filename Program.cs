using System;
using System.Text;
using dBASE.NET;

namespace DbfConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding encoding = System.Text.Encoding.GetEncoding("big5");


            Dbf dbf = new Dbf(encoding);
            dbf.Read(@"C:\Users\coder\Desktop\data\shp_bah.dbf");

            foreach (DbfRecord record in dbf.Records)
            {
                for (int i = 0; i < dbf.Fields.Count; i++)
                {
                    Console.WriteLine(record[i]);

                }
            }
            Console.WriteLine(dbf.Records.Count);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

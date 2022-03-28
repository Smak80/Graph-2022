using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_2022
{
    public class Loader
    {
        private string _filename;
        public Loader(string filename)
        {
            _filename = filename;
        }

        public double[,]? Load()
        {
            StreamReader? sr = null;
            try
            {
                sr = new StreamReader(_filename);
                double[,]? result = null;
                int row = 0;
                while (!sr.EndOfStream)
                {
                    var data = sr.ReadLine();
                    if (data is not null)
                    {
                        var vals = data.Split(new []{';',' ','\n','\r'});
                        result = new double[vals.Length, vals.Length];
                        var col = 0;
                        foreach (var val in vals)
                        {
                            result[row, col++] = double.Parse(val);
                        }

                        row++;
                    }
                }

                return result;
            }
            finally
            {
                sr?.Close();
            }
        }
    }
}

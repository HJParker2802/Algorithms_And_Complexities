using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TxtCreater
    {
        public void main(string NewFileName, string MergeFile1, string MergeFile2)
        {
            using (var output = File.Create(NewFileName))
            {
                foreach (var file in new[] { MergeFile1, MergeFile2 })
                {
                    using (var input = File.OpenRead(file))
                    {
                        input.CopyTo(output);
                    }
                }
            }
        }
    }
}

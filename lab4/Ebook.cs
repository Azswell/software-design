using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Ebook : Book
    {
        public int FileSizeMb { get; set; }

        public override string GetInfo()
        {
            return $"{Title} (Ebook, {FileSizeMb}Mb)";
        }
    }
}

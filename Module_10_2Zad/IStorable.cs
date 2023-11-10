using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10_2Zad
{
    public interface IStorable
    {
        void SaveToFile(string fileName);
        void LoadFromFile(string fileName);
    }
}

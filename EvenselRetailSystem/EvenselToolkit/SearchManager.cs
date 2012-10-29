using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Evensel.EvenselToolkit
{
    public interface ISearchManager
    {
        ArrayList Find(string key, string value);
        ArrayList GetKeys();
    }
}

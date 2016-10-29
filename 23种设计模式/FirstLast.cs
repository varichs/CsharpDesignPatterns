using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23种设计模式
{
    /// <summary>
    /// 名字-姓氏模式
    /// </summary>
    public class FirstLast:Namer
    {
        public FirstLast(string name)
        {
            int i = name.Trim().IndexOf(" ");
            if (i > 0)
            {
                frName = name.Substring(0, i).Trim();
                lName = name.Substring(i + 1).Trim();
            }
            else
            {
                frName = name;
                lName = "";
            }
        }
    }
}

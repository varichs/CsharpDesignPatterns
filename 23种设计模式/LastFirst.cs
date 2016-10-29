using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23种设计模式
{
    /// <summary>
    /// 姓氏-名字模式
    /// </summary>
    public class LastFirst : Namer
    {
        public LastFirst(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
            {
                lName = name.Substring(0, i);
                frName = name.Substring(i + 1).Trim();
            }
            else
            {
                lName = name;
                frName = "";
            }
        }
    }
}

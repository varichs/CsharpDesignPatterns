using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23种设计模式
{
    /// <summary>
    /// 名字基类，其实可以设置为抽象类，多态实现各种情况
    /// </summary>
    public class Namer
    {
        protected string frName, lName;

        public string getFrName()
        {
            return frName;
        }
        public string getLName()
        {
            return lName;
        }
    }
}

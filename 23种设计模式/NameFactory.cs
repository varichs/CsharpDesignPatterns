using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _23种设计模式.Namer;

namespace _23种设计模式
{
    public class NameFactory
    {
        /// <summary>
        /// 简单的工厂方法，根据输入的字符串，返回相应的实例
        /// </summary>
        public NameFactory() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Namer getName(string name)
        {
            int i = name.IndexOf(",");
            if (i > 0)
            {
                return new LastFirst(name);
            }
            else
            {
                return new FirstLast(name);
            }
        }
    }
}

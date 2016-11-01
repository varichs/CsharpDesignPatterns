using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 工厂方法模式
{
    public abstract class Event
    {
        protected int numLanes;
        protected ArrayList swimmers;

        public Event(string filename,int lanes)
        {
            numLanes = lanes;
            swimmers = new ArrayList();
            //从文件中读取游泳运动员的信息
            csFile f = new csFile(filename);
            f.OpenForRead();
            string s = f.readLine();
            while (s != null)
            {
                
            }
        }
    }
}

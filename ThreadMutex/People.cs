using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadMutex
{
    public class People
    {
        public Thread PeopleThread;

        public People()
        {
            PeopleThread = new Thread(new ParameterizedThreadStart(UseTrailer));
        }
        public void UseTrailer(object count)
        {
            //使用次数
            int useCount = (int)count;
            for (int i = 0; i < useCount; i++)
            {
                //申请使用拖车(申请互斥锁)
                TrailerShare.TrailerMutex.WaitOne();
                Console.WriteLine(String.Format("{0}第{1}次使用拖车...", PeopleThread.Name, i + 1));
                Console.WriteLine(String.Format("{0}开始使用拖车...", PeopleThread.Name));
                Random rd = new Random();
                //使用拖车时间
                int useTime = rd.Next(5);
                Thread.Sleep(useTime*1000);
                Console.WriteLine(String.Format("{0}使用拖车完毕，使用时长:{1}s...", PeopleThread.Name, useTime));
                //归还拖车（释放互斥锁）
                TrailerShare.TrailerMutex.ReleaseMutex();
            }
        }
    }
}

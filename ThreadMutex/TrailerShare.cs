using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadMutex
{
    class TrailerShare
    {
        /// <summary>
        /// 拖车
        /// </summary>
        public static Mutex TrailerMutex;

        static TrailerShare()
        {
            TrailerMutex = new Mutex();
        }
    }
}

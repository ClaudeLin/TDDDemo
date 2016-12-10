using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDDemo
{
    public class OneHundredDoors
    {
        private bool doorStatus = false;

        public void Visit(int visitCount=1)
        {
            for (var i = 1; i <= visitCount; i++)
            {
                if (100%i == 0)
                {
                    doorStatus = !doorStatus;
                }
            }
        }

        public bool GetLastDoorStatus()
        {
            return doorStatus;
        }
    }
}

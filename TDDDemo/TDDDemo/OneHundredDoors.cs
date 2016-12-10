using System.Collections.Generic;

namespace TDDDemo
{
    public class OneHundredDoors
    {
        private Dictionary<int, bool> _doorsStatusDictionary;

        public OneHundredDoors(int totalDoors=100)
        {
            InitDoor(totalDoors);
        }

        private void InitDoor(int totalDoors)
        {
            _doorsStatusDictionary = new Dictionary<int, bool>();
            for (var i = 1; i <= totalDoors; i++)
            {
                _doorsStatusDictionary.Add(i, false);
            }
        }

        public void Visit(int visitCount = 1)
        {
            var doorsCount = _doorsStatusDictionary.Count;
            for (var i = 1; i <= visitCount; i++)
            {
                for (var j = 1; j <= doorsCount; j++)
                {
                    if (j % i == 0)
                    {
                        _doorsStatusDictionary[j] = !_doorsStatusDictionary[j];
                    }
                }
            }
        }

        public bool GetDoorStatus(int doorNo = 100)
        {
            return _doorsStatusDictionary[doorNo];
        }

    }
}

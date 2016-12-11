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

        public void Visit(int visitTimes = 1)
        {
            var doorsCount = _doorsStatusDictionary.Count;
            for (var visitCount = 1; visitCount <= visitTimes; visitCount++)
            {
                VisitDoors(visitCount, doorsCount);
            }
        }

        private void VisitDoors(int visitCount, int doorsCount)
        {
            for (var dictionaryPoint = visitCount; dictionaryPoint <= doorsCount; dictionaryPoint++)
            {
                SetDoorStatus(dictionaryPoint, visitCount);
            }
        }

        private void SetDoorStatus(int dictionaryPoint, int visitCount)
        {
            if (dictionaryPoint%visitCount == 0)
            {
                _doorsStatusDictionary[dictionaryPoint] = !_doorsStatusDictionary[dictionaryPoint];
            }
        }

        public bool GetDoorStatus(int doorNo = 100)
        {
            return _doorsStatusDictionary[doorNo];
        }

    }
}

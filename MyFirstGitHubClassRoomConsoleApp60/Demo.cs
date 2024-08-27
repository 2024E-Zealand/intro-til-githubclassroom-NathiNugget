using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        private string _activity;
        private int _time;
        private char _letter; 

        public Demo(string activity, int time, char letter)
        {
            _activity = activity;
            _time = time;
            _letter = letter;

        }
public string Activity { get => _activity; set => _activity = value; }
        public int Time { get => _time; set => _time = value; }
        public char Letter { get => _letter; set => _letter = value; }
    }
}

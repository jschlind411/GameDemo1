using System;
using System.Collections.Generic;
using System.Text;

namespace AMSWindowApp
{
    class HeadQuarters
    {
        private int[] soldiers;
        private int[] tanks;
        private int[] copters;

        public int maxBuildings = 5;

        public HeadQuarters(int[] _sol, int[] _tanks, int[] _copt)
        {
            soldiers = _sol;
            tanks = _tanks;
            copters = _copt;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;


namespace AMSWindowApp
{

    public class Player
    {

        private int[] soldiers;
        private int[] tanks;
        private int[] copters;

        private HeadQuarters PlayerHQ;

        private string _username;
        private int _level;
        private int _numKills;
        private int _totalTroops;

        private Image avatar;

        public String GetName { get { return _username; }  }
        public int GetLVL { get { return _level; } }
        public Image GetAvatar { get { return avatar; } }

        public Player()         //for new players only
        {
            GenNewPlayer();
        }

        private void GenNewPlayer()
        {
            GenFirstName();     //create random name for first time player
            _level = 1;
            _numKills = 0;
            _totalTroops = 0;

            soldiers = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            tanks = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            copters = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            PlayerHQ = new HeadQuarters(soldiers, tanks, copters);

            avatar = Image.FromFile("Images/gpyqyxcyxykashoo6jyj.jpg");
        }

        public void Update()
        {

        }

        public void changeName(string name)
        {
            _username = name;
        }

        private void GenFirstName()
        {
            Random rand = new Random();         
            _username = "sarge"+ rand.Next(1000, 9999);
        }

        public int GetTotalTroops()
        {
            return _totalTroops;
        }
    }
}

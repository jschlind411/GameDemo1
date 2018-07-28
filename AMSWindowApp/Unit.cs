using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AMSWindowApp
{
    class Unit
    {
        private string _unitName;
        private int _unitLevel;
        private UnitType _unitType;
        private Weapons _currWeapon;
        private Rank _rank;

        public enum Weapons
        {
            Rifle = 0,
            MachineGun = 1
        };

        public enum UnitType
        {
            Soldier = 0,
            Tank = 1,
            Helicopter = 2
        };

        public enum Rank
        {
            Pvt,
            Spc,
            Sgt,
            Sgm,
            Lt,
            Cpt,
            Col
        };

        public Unit(string uName, int uLevel, UnitType type, Weapons weapon, Rank rnk)
        {
            _unitName = uName;
            _unitLevel = uLevel;
            _unitType = type;
            _currWeapon = weapon;
            _rank = rnk;
        }


        public void Attack()
        {

        }
        public void Move()
        {

        }

        public Unit GetTroopInfo()
        {
            return this;
        }
    }
}

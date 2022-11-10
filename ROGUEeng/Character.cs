using System;

namespace ROGUEeng
{
    public class Character
    {
        private int _hp;
        private int _armor;
        private int _damage;

        public Character(int hp, int armor, int damage)
        {
            Hp = hp;
            Armor = armor;
            Damage = damage;
        }

        public int Hp
        {
            get => _hp; set
            {
                if (value >= 0)
                    _hp = value;
                else
                {
                    throw new ArgumentException("Геймдезигнер не Кодзима!нет хп");
                }
            }
        }
        public int Armor { get => _armor; set { if (value >= 0) _armor = value; else throw new ArgumentException("Геймдезигнер не Кодзима!нет брони"); } }
        public int Damage
        {
            get => _damage; set
            {
                if (value >= 0)
                    _damage = value;
                else
                {
                    throw new ArgumentException("Геймдезигнер не Кодзима, нет домага!");
                }
            }
            
        }
            

    }
}

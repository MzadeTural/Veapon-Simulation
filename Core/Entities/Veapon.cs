using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
   public class Veapon
    {

        public Veapon(int allBullet, int magazineSize)
        {
            AllBullet = allBullet;
            MagazineSize = magazineSize;
            CurrentBulletMagazine = magazineSize;
            CurrentBulletAmount = allBullet;

        }
        public string SingleFire(int NumberOfShoot)

        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (CurrentBulletMagazine >= NumberOfShoot)
            {
                for (int i = 1; i <= NumberOfShoot; i++)
                {
                    CurrentBulletMagazine -= 1;
                    Console.WriteLine($"Fire({i})");
                }

                return $"Your fire {NumberOfShoot} times bullets left in the magazine {CurrentBulletMagazine}";

            }
            else if (NumberOfShoot > MagazineSize)
                return "\n magazine capacity exceeded";
            else
                return "Not enough ammo please reload";


        }
        public string AutomaticFire()
        {


            if (CurrentBulletMagazine > 0)
            {
                int NumberOfShoot = CurrentBulletMagazine;
                for (int i = 1; i <= NumberOfShoot; i++)
                {
                    CurrentBulletMagazine -= 1;
                    Console.WriteLine($"Fire({i})=>");
                }
                return $"Your fire{NumberOfShoot} times magazine is emptye please reload";

            }
            else
                return "Not enough amm please reload!!";
        }

        public string Reload()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (CurrentBulletMagazine == MagazineSize)
                return "Cant reolad your magazine if full";
            else if ((MagazineSize - CurrentBulletMagazine) <= CurrentBulletAmount)
            {
                CurrentBulletAmount -= (MagazineSize - CurrentBulletMagazine);
                CurrentBulletMagazine += (MagazineSize - CurrentBulletMagazine);

                return $"Your current Magazine is {CurrentBulletMagazine} and  depo:{CurrentBulletAmount}";
            }

            else
                return "Not enough ammo please buy bullet";
        }
        public string Reload(int numberofBullet)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (CurrentBulletMagazine + numberofBullet <= MagazineSize)
            {
                if (CurrentBulletMagazine == MagazineSize)
                    return "Cant reolad your magazine if full";
                else if (numberofBullet <= CurrentBulletAmount)
                {
                    CurrentBulletAmount -= numberofBullet;
                    CurrentBulletMagazine += numberofBullet;

                    return $"Your current Magazine is {CurrentBulletMagazine} and  depo:{CurrentBulletAmount}";
                }

                else
                    return "Not enough ammo";
            }
            else
                return $"magazine capacity exceeded please try again ({MagazineSize - CurrentBulletMagazine}<=n)";
        }
        private int _magazineSize;
        public int MagazineSize
        {
            private set
            {
                if (value > 0 && value <= 50)
                {
                    _magazineSize = value;
                }
            }
            get
            {
                return _magazineSize;
            }
        }

        private int _allBullet;
        public int AllBullet
        {
            private set
            {
                if (value > 0)
                {
                    _allBullet = value;
                }
            }
            get
            {
                return _allBullet;
            }
        }
        private int _currentBulletMagazine;
        public int CurrentBulletMagazine
        {
            get
            {
                return _currentBulletMagazine;
            }
            private set
            {
                if (value >= 0)
                {
                    _currentBulletMagazine = value;
                }
            }
        }
        private int _currentBulletAmount;
        public int CurrentBulletAmount
        {
            get
            {
                return _currentBulletAmount;
            }
            private set
            {
                if (value >= 0)
                {
                    //_currentBullet number = value;
                    if (_allBullet - _currentBulletAmount > value)
                    {
                        _currentBulletAmount = _allBullet;
                    }
                    else
                    {
                        _currentBulletAmount = value;
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"Your current Tank is {CurrentBulletAmount}";
        }
    }
}

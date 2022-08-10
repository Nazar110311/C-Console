using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GulTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun = new Gun();
            Zombie zombie = new Zombie();
            gun.InformationGun(gun._name, gun._fire);
            Console.WriteLine($"Убейте зомби у немо {zombie.healht}");
            Console.WriteLine("Напишите 1 чтобы стрельнуть в зомби");
            for (bool isKill = false; zombie.healht >= 1;)
            {
                var key = Console.ReadLine();
                if (key == "1")
                {
                    zombie.healht -= gun._fire;
                    Console.WriteLine($"Вы стрельнули в зомби у него осталось {zombie.healht}");
                }
                if (isKill == true)
                {
                    continue;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Вы убили зомби");
        }
    }

    public class Zombie
    {
        public int healht = 100;
    }
    public class Gun : IGun, IGunShot
    {
        public string _name { get; set; } = "AKM";
        public int _fire { get; set; } = 20;

        public void InformationGun(string name, int fire)
        {
            Console.WriteLine($"У вас {name} которая наносит {fire}");
        }
        public void GunShot()
        {

        }
    }

    public interface IGun
    {
        void InformationGun(string name, int fire);
    }
    public interface IGunShot
    {
        void GunShot();
    }
}

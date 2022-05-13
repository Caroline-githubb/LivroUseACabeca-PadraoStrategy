using Jogo01.Interface;

namespace Jogo01.Comportamentos
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            System.Console.WriteLine("cut with the knife");
        }
    }
}
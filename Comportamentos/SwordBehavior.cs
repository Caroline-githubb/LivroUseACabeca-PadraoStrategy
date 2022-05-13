using Jogo01.Interface;

namespace Jogo01.Comportamentos
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            System.Console.WriteLine("cut with the sword");
        }
    }
}
using Jogo01.Interface;

namespace Jogo01.Comportamentos
{
    public class AxeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            System.Console.WriteLine("cut with an ax");
        }
    }
}
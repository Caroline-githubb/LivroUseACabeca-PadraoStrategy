using Jogo01.Interface;

namespace Jogo01.Comportamentos
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            System.Console.WriteLine("shot with the bow and arrow");
        }
    }
}
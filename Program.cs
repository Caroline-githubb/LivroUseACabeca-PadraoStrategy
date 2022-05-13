using Jogo01.Classes;
using Jogo01.Comportamentos;

namespace Jogo01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Character character = new Knigth();
            character.Fight();
            character.PerformFight();
            character.SetWeapon(new KnifeBehavior());
            character.PerformFight();


           
        
        }
    }
}
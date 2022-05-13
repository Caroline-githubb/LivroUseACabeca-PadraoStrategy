using Jogo01.Comportamentos;

namespace Jogo01.Classes
{
    public class Knigth : Character
    {        
        public Knigth()
        {
            weapon = new AxeBehavior();
        }
        
        public override void Fight()
        {
            System.Console.WriteLine("I'm a Knight");
        }

        
    }
}
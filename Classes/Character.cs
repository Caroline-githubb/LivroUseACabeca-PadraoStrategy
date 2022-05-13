using Jogo01.Interface;

namespace Jogo01.Classes
{
    public abstract class Character
    {
        protected IWeaponBehavior weapon;

        public Character()
        {

        }
        public abstract void Fight();
        public void PerformFight()
        {
            weapon.UseWeapon();            
        }      

        public void SetWeapon(IWeaponBehavior w)
        {
            this.weapon = w;
        }
    }
}
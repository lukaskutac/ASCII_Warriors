namespace ascii_warriors
{
    internal class Program
    {
        abstract class warrior
        {
            public int health;
            public int damage;

            public abstract void attack();
        }

        abstract class melee : warrior
        {
            public abstract void walk();
        }

        abstract class ranged : warrior
        {
            
        }

        abstract class knight : melee
        {
            
        }

        abstract class golem : melee
        {
            
        }

        abstract class mage : ranged
        {
            
        }

        abstract class ninja : ranged
        {
            
        }



        static void Main(string[] args)
        {
            
        }
    }
}
namespace OOPClass
{
    public abstract class GuestVist  // C# Abstarct Class
    {
        public string strTest;
        public GuestVist()
        {
            strTest = "asdf";
        }
        public string Guestwelcomemessage()
        {
            return "welcome guest!";
        }

        public abstract string purposeofVisit();

    }

    // derived class to inherit the abstract class  
    public class Houseclass : GuestVist
    {
        public bool ischain;
        public Houseclass(bool sentischain)
        {
            ischain = sentischain;
        }
        public Houseclass() : this(true)  // C# constructor chaining
        {
        }
        public override string purposeofVisit()
        {
            return "Abstract just came for a Meetup and spend some time ";
        }
        ~Houseclass()
        {
            ischain = false;
        }
    }

    // Static class
    public static class StaticClsPerson
    {
        public static int age = 23, y;
        public static int calculate()
        {
            y = age * 2;
            return y;
        }
        static void Test()
        {
            StaticClsPerson.calculate();
        }
        // Static class can not contain destructor
        //~StaticClsPerson()
        //{
        //    age = 0;
        //}
    }

    public class TestStaticClass
    {
        int agemul = StaticClsPerson.calculate();
    }

}

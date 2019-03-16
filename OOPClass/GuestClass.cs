namespace OOPClass
{
    public abstract class GuestVist
    {
        public string Guestwelcomemessage()
        {
            return "welcome guest!";
        }

        public abstract string purposeofVisit();

    }

    // derived class to inherit the abstract class  
    public class Houseclass : GuestVist
    {
        //static void Main(string[] args)
        //{
        //    Houseclass objHouse = new Houseclass();
        //    objHouse.Guestwelcomemessage();
        //}

        public override string purposeofVisit()
        {
            return "Abstract just came for a Meetup and spend some time ";
        }
    }
}

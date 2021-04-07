using System;

namespace StrategyDesignPattern
{
    public abstract class clsStatergy
    {
        public abstract
            String Display(String Name, String Surname);
    }
    public class clsNameSurname : clsStatergy
    {
        public override String Display(String Name, String Surname)
        {
            return Name + Surname;
        }
    }
    public class clssurnameName : clsStatergy
    {
        public override String Display(String Name, String Surname)
        {
            return Surname + Name;
        }
    }
    public class clsDisplayName
    {
        public String Name = "";
        public String Surname = "";
        private clsStatergy objStatergy;
        public void setStatergy(clsStatergy obj)
        {
            objStatergy = obj;
        }
        public String Show()
        {
            return objStatergy.Display(Name, Surname);
        }
    }
}

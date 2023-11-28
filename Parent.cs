using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilites
{
    public class Parent
    {
        public string _name;
        string _lastName;
        string _surname;
        string _adress;
        string _Who;

        public Parent()
        {
            _name = "Леонид";
            _lastName = "Паньков";
            _surname = "Павлович";
            _adress = "Ул.Транспортная. Д. 13";
            _Who = "Отец";

        }
        public Parent(string name, string lastName, string surname, string adress, string who)
        {
            _name = name;
            _lastName = lastName;
            _surname = surname;
            _adress = adress;
            _Who = who;

        }
        override public string ToString()
        {

            return $"{_name} {_lastName} {_surname} ";
        }
    }
}

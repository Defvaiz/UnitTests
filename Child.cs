using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilites
{
    public class Child
    {
        string _name;
        string _lastName;
        string _surname;
        string _adress;
        DateTime _birthdate;
        DateTime _yearOfAdmission;
        Parent[] _parents;
        string _group;

        public void PrintToConsole()
        {
            string parents = "";
            for (int i = 0; i < _parents.Length; i++)
            {
                parents += _parents[i].ToString() + ", ";
            }
            Console.WriteLine($"Ребенок {_name} {_lastName} {_surname} {_adress} {_birthdate} {_yearOfAdmission}, Родители: {parents} {_group}");
        }

        public Child(string name, string lastName, string surname, string adress, DateTime birthdate, DateTime yearOfAdmission, string group)
        {
            this._name = name;
            this._lastName = lastName;
            this._surname = surname;
            this._adress = adress;
            this._birthdate = birthdate;
            this._yearOfAdmission = yearOfAdmission;
            this._group = group;
            _parents = new Parent[0];
            _parents = new Parent[0];
        }
        public Child()
        {
            _name = "Максим";
            _lastName = "Паньков";
            _surname = "Леонидович";
            _adress = "ул.Транспортная 13, д. 60";
            _birthdate = new DateTime(2003, 5, 20);
            _yearOfAdmission = new DateTime(2007, 5, 10);
            _group = "Группа Б";
            _parents = new Parent[1];
            _parents[0] = new Parent();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Имя не может быть пустым!");
                _name = value;

            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Фамилия не может быть пустой!");
                _lastName = value;
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Отчество не может быть пустым!");
                _surname = value;
            }

        }
        public string Adress
        {
            get { return _adress; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Адресс не может быть пустым!");
                _adress = value;
            }
        }
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
        public DateTime YearOfAdmission
        {
            get { return _yearOfAdmission; }
            set { _yearOfAdmission = value; }
        }
        public Parent[] Parents
        {
            get { return _parents; }
            set
            {
                if (_parents == null)
                    throw new ArgumentException("Родители не может быть пустым!");
                _parents = value;
            }
        }
        public string Group
        {
            get { return _group; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Группа не может быть пустым!");
                _group = value;
            }
        }
        public string FullName
        {
            get { return $"{_name} {_lastName} {_surname}"; }
        }

        public void AddParents(params Parent[] newParent)
        {
            Parent[] newParentArray = new Parent[_parents.Length + newParent.Length];
            Array.Copy(_parents, newParentArray, _parents.Length);
            for (int i = 0; i < newParentArray.Length; i++)
            {
                newParentArray[_parents.Length + i] = newParent[i];
            }
            _parents = newParentArray;
        }
        public int CalculateAge()
        {
            DateTime currantDate = DateTime.Now;
            int age = currantDate.Year - _birthdate.Year;
            if (currantDate.Month < _birthdate.Month || (currantDate.Month == _birthdate.Month && currantDate.Day < _birthdate.Day))
            {
                age--;
            }
            return age;
        }
        public void ChangeGroup(string newGroup)
        {
            _group = newGroup;
        }
        public string[] GetParentsNames()
        {
            string[] parentsNames = new string[_parents.Length];
            for (int i = 0; i < _parents.Length; i++)
            {
                parentsNames[i] = _parents[i]._name;
            }
            return parentsNames;
        }
        override public string ToString()
        {

            return $"Ребенок: {_name} {_lastName} {_surname} {_adress} {_birthdate} {_parents} {_group}";
        }
    }
}

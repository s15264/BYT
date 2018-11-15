
using System;
using System.Collections;

namespace ObjectPooling
{
    class Person
    {
        public static int Counter = 0;
        public Person()
        {
            ++Counter;
        }
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
    }


    class Pool
    {
        private static int poolSize = 3;
        private static readonly Queue  objPool = new Queue(poolSize);

        public Person GetPerson()
        {
            Person oPerson;
            if (Person.Counter >= poolSize && objPool.Count > 0)
            {
                oPerson = Retrive();
                Console.WriteLine("retrived");
            }
            else
            {
                oPerson = GetNewPerson();
                Console.WriteLine("created");
            }

            return oPerson;
        }
        private Person GetNewPerson()
        {
            Person person = new Person();
            objPool.Enqueue(person);

            return person;
        }
        protected Person Retrive()
        {
            Person person;
            if (objPool.Count > 0)
            {
                person = (Person)objPool.Dequeue();
                Person.Counter--;
            }
            else
            {
                person = new Person();
            }

            return person;
        }
    }

}

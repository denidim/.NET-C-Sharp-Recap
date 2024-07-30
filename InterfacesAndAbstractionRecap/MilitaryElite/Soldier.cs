﻿namespace MilitaryElite
{
    internal abstract class Soldier
    {
        private int id;
        private string firstName;
        private string lastName;

        protected Soldier(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get => id; private set => id = value; }

        public string FirstName { get => firstName; private set => firstName = value; }

        public string LastName { get => lastName; private set => lastName = value; }
    }
}

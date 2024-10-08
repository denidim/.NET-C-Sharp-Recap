﻿namespace PlayersAndMonsters
{
    internal class Hero
    {
        private string username;
        private int level;

        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }

        public string Username { get => username; set => username = value; }

        public int Level { get => level; set => level = value; }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerWpfProject.Model
{
    internal class Player
    {
        public Player(string name, string pClass, string gender)
        {
            Name = name;
            PClass = pClass;
            Gender = gender;
            Health = 1;
            Damage = 1;
            Defense = 1;
            Xp = 1;
            Level = 1;
            SkillPoints = 10;
        }

        public string Name { get; set; }
        public string PClass { get; set; }
        public string Gender { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Id { get; set; }
        public int Xp { get; set; }
        public int Level { get; set; }
        public int SkillPoints { get; set; }

        public override string ToString()
        {
            return $"Player name: {Name}"
                    + $", class: {PClass}"
                    + $", gender: {Gender}"
                    + $", health: {Health}"
                    + $", damage: {Damage}"
                    + $", defense:{Defense}"
                    + $", xp:{Xp}"
                    + $", level:{Level}"
                    + $", skillpoints:{SkillPoints}";
        }
    }
}

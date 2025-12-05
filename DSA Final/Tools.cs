using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Final
{
    public class Penalty
    {
        public List<decimal> Penalties = new List<decimal>();
        public int MainStairPenaltyF1 {get; set;}
        public int MainStairUsersF1 { get; set; }

        public int MainStairPenaltyF2 { get; set; }
        public int MainStairUsersF2 { get; set; }

        public int MainStairPenaltyF3 { get; set; }
        public int MainStairUsersF3 { get; set; }

        public int RightSideStairPenaltyF1 { get; set;}
        public int RightSideStairUsersF1 { get; set; }

        public int LeftSideStairPenaltyF1 { get; set; }
        public int LeftSideStairUsersF1{ get; set; }

        public int RightSideStairPenaltyF2 { get; set; }
        public int RightSideStairUsersF2 { get; set; }

        public int LeftSideStairPenaltyF2 { get; set; }
        public int LeftSideStairUsersF2 { get; set; }

        public int RightSideStairPenaltyF3 { get; set; }
        public int RightSideStairUsersF3 { get; set; }

        public int LeftSideStairPenaltyF3 { get; set; }
        public int LeftSideStairUsersF3 { get; set; }

        public int Exit1Penalty {get; set;}
        public int Exit1Users {get; set;}

        public int Exit2Penalty { get; set; }
        public int Exit2Users { get; set; }

        public int Exit3Penalty { get; set; }
        public int Exit3Users { get; set; }

        public int Exit4Penalty { get; set; }
        public int Exit4Users { get; set; }

        public int Exit5Penalty { get; set; }
        public int Exit5Users { get; set; }

        public Penalty()
        {

        }

        public decimal SumOfPenalties()
        {
            decimal sum = 0;    

            foreach (var penalty in Penalties)
            {
                sum += penalty;
            }
            return sum;
        }
        public void AddPenalty(decimal penalty)
        {
            if(penalty > 0)
            {
                Penalties.Add(penalty);
            }
            
        }

        public void ComputePenalty(string room)
        {
            int user = 30;
            int capacity;

            if(room == "E")
            {
                capacity = 200;
                MainStairUsersF1 += user;

                if (MainStairUsersF1 <= capacity)
                {
                    AddPenalty(MainStairPenaltyF1 = 0);
                }
                else
                {
                    AddPenalty(MainStairPenaltyF1 = (MainStairUsersF1 - capacity) / capacity);
                }
            }
            else if(room == "DD")
            {
                capacity = 200;
                MainStairUsersF1 += user;

                if (MainStairUsersF1 <= capacity)
                {
                    AddPenalty(MainStairPenaltyF1 = 0);
                }
                else
                {
                    AddPenalty(MainStairPenaltyF1 = (MainStairUsersF1 - capacity) / capacity);
                }
            }
            else if(room == "CC")
            {
                capacity = 200;
                MainStairUsersF3 += user;

                if (MainStairUsersF3 <= capacity)
                {
                    AddPenalty(MainStairPenaltyF3 = 0);
                }
                else
                {
                    AddPenalty(MainStairPenaltyF3 = (MainStairUsersF3 - capacity) / capacity);
                }
            }
            else if (room == "GGG")
            {
                capacity = 100;
                LeftSideStairUsersF3 += user;

                if (LeftSideStairUsersF3 <= capacity)
                {
                    AddPenalty(LeftSideStairPenaltyF3 = 0);
                }
                else
                {
                    AddPenalty(LeftSideStairPenaltyF3 = (LeftSideStairUsersF3 - capacity) / capacity);
                }
            }
            else if (room == "AAA")
            {
                capacity = 100;
                RightSideStairUsersF3 += user;

                if (RightSideStairUsersF3 <= capacity)
                {
                    AddPenalty(RightSideStairPenaltyF3 = 0);
                }
                else
                {
                    AddPenalty(RightSideStairPenaltyF3 = (RightSideStairUsersF3 - capacity) / capacity);
                }
            }
            else if (room == "GG")
            {
                capacity = 100;
                LeftSideStairUsersF2 += user;

                if (LeftSideStairUsersF2 <= capacity)
                {
                    AddPenalty(LeftSideStairPenaltyF2 = 0);
                }
                else
                {
                    AddPenalty(LeftSideStairPenaltyF2 = (LeftSideStairUsersF2 - capacity) / capacity);
                }
            }
            else if (room == "AA")
            {
                capacity = 100;
                RightSideStairUsersF2 += user;

                if (RightSideStairUsersF2 <= capacity)
                {
                    AddPenalty(RightSideStairPenaltyF2 = 0);
                }
                else
                {
                    AddPenalty(RightSideStairPenaltyF2 = (RightSideStairUsersF2 - capacity) / capacity);
                }

            }
            else if (room == "I")
            {
                capacity = 100;
                LeftSideStairUsersF1 += user;

                if (LeftSideStairUsersF1 <= capacity)
                {
                    AddPenalty(LeftSideStairPenaltyF1 = 0);
                }
                else
                {
                    AddPenalty(LeftSideStairPenaltyF1 = (LeftSideStairUsersF1 - capacity) / capacity);
                }
            }
            else if (room == "A")
            {
                capacity = 100;
                RightSideStairUsersF1 += user;

                if (RightSideStairUsersF1 <= capacity)
                {
                    AddPenalty(RightSideStairPenaltyF1 = 0);
                }
                else
                {
                    AddPenalty(RightSideStairPenaltyF1 = (RightSideStairUsersF1 - capacity) / capacity);
                }
            }
            else if (room == "Exit1")
            {
                capacity = 300;
                Exit1Users += user;

                if (Exit1Users <= capacity)
                {
                    AddPenalty(Exit1Penalty = 0);
                }
                else
                {
                    AddPenalty(Exit1Penalty = (Exit1Users - capacity) / capacity);
                }
            }
            else if (room == "Exit2")
            {
                capacity = 300;
                Exit2Users += user;

                if (Exit2Users <= capacity)
                {
                    AddPenalty(Exit2Penalty = 0);
                }
                else
                {
                    AddPenalty(Exit2Penalty = (Exit2Users - capacity) / capacity);
                }
            }
            else if (room == "Exit3")
            {
                capacity = 300;
                Exit3Users += user;

                if (Exit3Users <= capacity)
                {
                    AddPenalty(Exit3Penalty = 0);
                }
                else
                {
                    AddPenalty(Exit3Penalty = (Exit3Users - capacity) / capacity);
                }
            }
            else if (room == "Exit4")
            {
                capacity = 300;
                Exit4Users += user;

                if (Exit4Users <= capacity)
                {
                    AddPenalty(Exit4Penalty = 0);
                }
                else
                {
                    AddPenalty(Exit4Penalty = (Exit4Users - capacity) / capacity);
                }

            }
            else if (room == "Exit5")
            {
                capacity = 300;
                Exit5Users += user;

                if (Exit5Users <= capacity)
                {
                    AddPenalty(Exit5Penalty = 0);
                }
                else
                {
                    AddPenalty(Exit5Penalty = (Exit5Users - capacity) / capacity);
                }
            }
            

        }

    }
}

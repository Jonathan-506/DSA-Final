using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Final
{
    public class Penalty
    {
        
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

        public decimal SumOfPenalties(string room)
        {
            decimal sum = 0;    


                if (room == "151")
                {
                    
                }
                else if (room == "142")
                {

                }
                else if (room == "143")
                {

                }
                else if (room == "124")
                {

                }
                else if (room == "122")
                {

                }
                else if (room == "123")
                {

                }
                else if (room == "223")
                {


                }
                else if (room == "225")
                {

                }
                else if (room == "254")
                {

                }
                else if (room == "243")
                {

                }
                else if (room == "251")
                {

                    
                }
                else if (room == "323")
                {

                }
                else if (room == "324")
                {


                }
                else if (room == "354")
                {

                }
                else if (room == "353")
                {

                } 
                else if (room == "343")
                {

                }
                else if (room == "342")
                {
  
                }
                else if (room == "351")
                {

                }
                else if (room == "341")
                {

                }


            return sum;
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
                    MainStairPenaltyF1 = 0;
                }
                else
                {
                    MainStairPenaltyF1 = (MainStairUsersF1 - capacity) / capacity;
                }
            }
            else if(room == "DD")
            {
                capacity = 200;
                MainStairUsersF1 += user;

                if (MainStairUsersF1 <= capacity)
                {
                   MainStairPenaltyF1 = 0;
                }
                else
                {
                    MainStairPenaltyF1 = (MainStairUsersF1 - capacity) / capacity;
                }
            }
            else if(room == "CC")
            {
                capacity = 200;
                MainStairUsersF3 += user;

                if (MainStairUsersF3 <= capacity)
                {
                   MainStairPenaltyF3 = 0;
                }
                else
                {
                   MainStairPenaltyF3 = (MainStairUsersF3 - capacity) / capacity;
                }
            }
            else if (room == "GGG")
            {
                capacity = 100;
                LeftSideStairUsersF3 += user;

                if (LeftSideStairUsersF3 <= capacity)
                {
                    LeftSideStairPenaltyF3 = 0;
                }
                else
                {
                    LeftSideStairPenaltyF3 = (LeftSideStairUsersF3 - capacity) / capacity;
                }
            }
            else if (room == "AAA")
            {
                capacity = 100;
                RightSideStairUsersF3 += user;

                if (RightSideStairUsersF3 <= capacity)
                {
                    RightSideStairPenaltyF3 = 0;
                }
                else
                {
                    RightSideStairPenaltyF3 = (RightSideStairUsersF3 - capacity) / capacity;
                }
            }
            else if (room == "GG")
            {
                capacity = 100;
                LeftSideStairUsersF2 += user;

                if (LeftSideStairUsersF2 <= capacity)
                {
                    LeftSideStairPenaltyF2 = 0;
                }
                else
                {
                    LeftSideStairPenaltyF2 = (LeftSideStairUsersF2 - capacity) / capacity;
                }
            }
            else if (room == "AA")
            {
                capacity = 100;
                RightSideStairUsersF2 += user;

                if (RightSideStairUsersF2 <= capacity)
                {
                    RightSideStairPenaltyF2 = 0;
                }
                else
                {
                   RightSideStairPenaltyF2 = (RightSideStairUsersF2 - capacity) / capacity;
                }

            }
            else if (room == "I")
            {
                capacity = 100;
                LeftSideStairUsersF1 += user;

                if (LeftSideStairUsersF1 <= capacity)
                {
                    LeftSideStairPenaltyF1 = 0;
                }
                else
                {
                    LeftSideStairPenaltyF1 = (LeftSideStairUsersF1 - capacity) / capacity;
                }
            }
            else if (room == "A")
            {
                capacity = 100;
                RightSideStairUsersF1 += user;

                if (RightSideStairUsersF1 <= capacity)
                {
                    RightSideStairPenaltyF1 = 0;
                }
                else
                {
                    RightSideStairPenaltyF1 = (RightSideStairUsersF1 - capacity) / capacity;
                }
            }
            else if (room == "Exit1")
            {
                capacity = 300;
                Exit1Users += user;

                if (Exit1Users <= capacity)
                {
                    Exit1Penalty = 0;
                }
                else
                {
                    Exit1Penalty = (Exit1Users - capacity) / capacity;
                }
            }
            else if (room == "Exit2")
            {
                capacity = 300;
                Exit2Users += user;

                if (Exit2Users <= capacity)
                {
                    Exit2Penalty = 0;
                }
                else
                {
                    Exit2Penalty = (Exit2Users - capacity) / capacity;
                }
            }
            else if (room == "Exit3")
            {
                capacity = 300;
                Exit3Users += user;

                if (Exit3Users <= capacity)
                {
                    Exit3Penalty = 0;
                }
                else
                {
                    Exit3Penalty = (Exit3Users - capacity) / capacity;
                }
            }
            else if (room == "Exit4")
            {
                capacity = 300;
                Exit4Users += user;

                if (Exit4Users <= capacity)
                {
                    Exit4Penalty = 0;
                }
                else
                {
                    Exit4Penalty = (Exit4Users - capacity) / capacity;
                }

            }
            else if (room == "Exit5")
            {
                capacity = 300;
                Exit5Users += user;

                if (Exit5Users <= capacity)
                {
                    Exit5Penalty = 0;
                }
                else
                {
                   Exit5Penalty = (Exit5Users - capacity) / capacity;
                }
            }
            

        }

    }
}

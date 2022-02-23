using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace saving_objectz
{
    class Program
    {
        static void Main(string[] args)
        {
            var rijals = new List<Guy>();

            rijals.Add(new Guy() {  Name = "Bob", 
                                    Clothes = new Outfit() { Top = "Kemeja", 
                                                            Bottom = "compang camping" }, 
                                    Hair = new HairStyle() { Color = HairColor.Blonde, Length = 3.3f } });



            rijals.Add(new Guy()
            {
                                Name = "Joe",
                                Clothes = new Outfit()
                                                        {
                                                            Top = "Polo",
                                                            Bottom = "Slack"
                                                        },
                                Hair = new HairStyle() { Color = HairColor.Auburn, Length = 2.7f }
            });

            foreach (var item in rijals)
            {
                Console.WriteLine(item);
            }



        }//END method
  } // END class
}//END ALL


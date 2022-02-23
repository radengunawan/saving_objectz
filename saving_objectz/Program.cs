using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Text.Json;

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

            //foreach (var item in rijals)
            //{
            //    Console.WriteLine(item);
            //}


            var jsonString = JsonSerializer.Serialize(rijals);

         

            using (var sw = new StreamWriter("hasil_coba_save.json"))
            {
                //jsonString;
                // JsonSerializer.Serialize(rijals); <----not work
                sw.WriteLine(jsonString);
            }

            var copyOfGuys = JsonSerializer.Deserialize<List<Guy>>(jsonString);


            //Console.WriteLine(jsonString);


            //foreach (var guy in copyOfGuys) {

            //    //Console.WriteLine("I deserialized this guy: {0}", guy);
            //    Console.WriteLine($"I deserialized this guy: {guy}");
            //}


        }//END Main method
    } // END class
}//END ALL


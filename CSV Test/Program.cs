using System;

namespace CSV_Test
{
    class Program
    {
        static void Main(string[] args)
        { // test data don't 
            string fname = "Rick";
            string lname = "Tucker";
            string email = "test";
            string address = "test street";
            string hphone = "304-123-1000";
            string counties = "Kanawha";
            string route = "52";
            string rdname = "taco";
            string landmark = "taco bell";
            string gps = "the map";
            string description = "Read the map morty";
            string city = "Fresh";

            //******!!!!!If you are importing this into your project only copy from here down!!!!**********
            createlog(DateTime.Now.ToString(), fname, lname, email, address, hphone, counties, route, rdname, landmark, gps, description, city);
            static void createlog(string date, string fname, string lname, string email, string address, string hphone, string counties, string route, string rdname, string landmark, string gps, string description, string city)
            {
                try
                {
                    DateTime dateOnly = DateTime.Today;

                    // This should be your file destination and what you want the file to be named. 
                    string filepath = @"\\dotb6ftp02v\d$\SWATLogs\" + dateOnly.ToString("MM.dd.yyyy") + "testSwatLog.csv";
                    // string filepath = @"\\dotb6ftp02v\d$\SWATLogs\SwatLog.csv";
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                    {   // Line below writes the data to the csv file
                        file.WriteLine(date + "," + fname + "," + lname + "," + email + "," + address + "," + hphone + "," + counties + "," + route + "," + rdname + "," + landmark + "," + gps + "," + description + "," + city);
                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Crashed", ex);
                }
            }
        }
    }
}

/////////////////////////////////////////////////////////////////////////////////////////یاسین منعم\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
string address = @"C:\Users\Yassin\Desktop\univercity\project\exercise7\orders.csv";
string line;
List<string> citys = new List<string>();

using (StreamReader srreader = new StreamReader(address))
{
    while (!srreader.EndOfStream)
    {
        line = srreader.ReadLine();
        citys.Add(Regex.Replace(line, @"(\d|\.|,|:|-| )+", ""));
    }
}

var nonduplicatecitys = citys.Distinct();

foreach (string city in nonduplicatecitys)
{
    using (StreamWriter strwriter = new StreamWriter(@"D:\" + city + ".csv"))
    {
        strwriter.WriteLine("city_name");
    }
}


    string address1 = @"C:\Users\Yassin\Desktop\univercity\project\exercise7\orders.csv";
    string address2 = @"D\2015.csv";
    string address3 = @"D\2016.csv";
    string address4 = @"D\2017.csv";
    string address5 = @"D\2018.csv";
    string address6 = @"D\2019.csv";
    string address7 = @"D\2020.csv";
    string address8 = @"D\2021.csv";
    string address9 = @"D\2022.csv";
    string address10 = @"D\2023.csv";

    year1();
    year2();
    year3();
    year4();
    year5();
    year6();
    year7();
    year8();
    year9();

    void year1()
    {

        StreamReader srreader = new StreamReader(address1);

        StreamWriter srwriter = new StreamWriter(address2);
        string line1;
        while (!srreader.EndOfStream)
        {
            line = srreader.ReadLine();
            if (line.Contains("2015"))
            {
                srwriter.WriteLine(line);
            }
        }

        srwriter.Close();

        srreader.Close();
    }

    void year2()
    {
        StreamReader srreader = new StreamReader(address1);

        StreamWriter srwriter = new StreamWriter(address3);
        string line1;
        while (!srreader.EndOfStream)
        {
            line = srreader.ReadLine();
            if (line.Contains("2016"))
            {
                srwriter.WriteLine(line);
            }
        }

        srwriter.Close();

        srreader.Close();

    }

    void year3()
    {
        StreamReader srreader = new StreamReader(address1);

        StreamWriter srwriter = new StreamWriter(address4);
        string line1;
        while (!srreader.EndOfStream)
        {
            line = srreader.ReadLine();
            if (line.Contains("2017"))
            {
                srwriter.WriteLine(line);
            }
        }

        srwriter.Close();

        srreader.Close();
    }

    void year4()
    {
        StreamReader srreader = new StreamReader(address1);

        StreamWriter srwriter = new StreamWriter(address5);
        string line1;
        while (!srreader.EndOfStream)
        {
            line = srreader.ReadLine();
            if (line.Contains("2018"))
            {
                srwriter.WriteLine(line);
            }
        }

        srwriter.Close();

        srreader.Close();
    }

    void year5()
    {
        StreamReader srreader = new StreamReader(address1);

        StreamWriter srwriter = new StreamWriter(address6);
        string line1;
        while (!srreader.EndOfStream)
        {
            line = srreader.ReadLine();
            if (line.Contains("2019"))
            {
                srwriter.WriteLine(line);
            }
        }

        srwriter.Close();

        srreader.Close();
    }

    void year6()
    {

        StreamReader srreader = new StreamReader(address1);

        StreamWriter srwriter = new StreamWriter(address7);
        string line1;
        while (!srreader.EndOfStream)
        {
            line = srreader.ReadLine();
            if (line.Contains("2020"))
            {
                srwriter.WriteLine(line);
            }
        }

        srwriter.Close();

        srreader.Close();

    }

    void year7()
    {
        StreamReader srreader = new StreamReader(address1);

        StreamWriter srwriter = new StreamWriter(address8);
        string line1;
        while (!srreader.EndOfStream)
        {
            line = srreader.ReadLine();
            if (line.Contains("2021"))
            {
                srwriter.WriteLine(line);
            }
        }

        srwriter.Close();

        srreader.Close();
    }

    void year8()
    {
        StreamReader srreader = new StreamReader(address1);

        StreamWriter srwriter = new StreamWriter(address9);
        string line1;
        while (!srreader.EndOfStream)
        {
            line = srreader.ReadLine();
            if (line.Contains("2022"))
            {
                srwriter.WriteLine(line);
            }
        }

        srwriter.Close();

        srreader.Close();
    }

    void year9()
    {
        StreamReader srreader = new StreamReader(address1);

        StreamWriter srwriter = new StreamWriter(address10);
        string line1;
        while (!srreader.EndOfStream)
        {
            line = srreader.ReadLine();
            if (line.Contains("2023"))
            {
                srwriter.WriteLine(line);
            }
        }

        srwriter.Close();

        srreader.Close();
    }


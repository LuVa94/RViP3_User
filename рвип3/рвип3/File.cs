using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace рвип3
{
    public class File : CollectionBase
    {
        ConcurrentBag<string> cb_file = new ConcurrentBag<string>();
        ConcurrentBag<string> cb_state = new ConcurrentBag<string>();
        //string stfile = "free";
        string stfile = "";
        const int slep = 4;

        public void Get_info(string file, string state)
        {
            Console.WriteLine("Файловая система принимает: Имя файла " + file.ToString() + " для  " + state.ToString());
            cb_file.Add(file.ToString());
            cb_state.Add(state.ToString());
        }

        string c = "";
        public string Change_state_file(string file, string stfile)
        {
            if ((stfile.StartsWith("note")))
            {
                    c = "busy";
                }
            return stfile;
        }
        string stat = "";
        public string state_file(string file, string stfile)
        {
            //foreach (string sp in cb_file)
            //{
            //    foreach (string c in cb_state)
            //    {
            if ((stfile.StartsWith("read")))
                    {
                        stat = file.ToString()+" для чтения";
                    }
                    else
                    {
                        stat = file.ToString() + " для записи";
                    }
            //    }
            //}
            return stat;
        }

        public void Display_info()
        {
            foreach (string sp in cb_file)
            {
                foreach (string c in cb_state)
                {
                    if ((c == "read") && (stfile == "free"))
                    {
                        Console.WriteLine("чтение");
                    }
                    else
                    {
                        Console.WriteLine("ожидание");
                    }
                }
            }
        }

        public void Send(string state)
        {
            int sl = 0;
            Random r = new Random();
            sl = r.Next(10, 100);
            Thread.Sleep(sl * slep);
            //sv.Get_info(state);
        }
    }
}

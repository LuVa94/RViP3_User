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
    public class User : CollectionBase
    {
        ConcurrentBag<string> cb_file = new ConcurrentBag<string>();
        ConcurrentBag<string> cb_state = new ConcurrentBag<string>();

        public int name;
         const int slep = 4;
         int sl = 0;
         int vibor = 0;
         int v = 0;
         string file = "file";
         public User(int _name)
        {
            name = _name;
        }
         string state = "free";
         //string act = "";

         public string Choice_file()
         {
             Random r = new Random();
             v = r.Next(1, 10);
             Thread.Sleep(10 * slep);
             return file+v.ToString();
         }
         public string Change_state()
         {
             Random r = new Random();
             vibor = r.Next(1, 20);
             Thread.Sleep(10 * slep);
             if (vibor%2==1)
             {
                 //state = "note";//запись
                state = "read";//чтение
             }
             else
             {
                 state = "note";//запись
             }
             
             return state.ToString();
         }

         public void Get_info(string state)
         {
             Console.WriteLine("Пользователь принимает:  "  + state.ToString());
             //cb_file.Add(file.ToString());
             cb_state.Add(state.ToString());
         }

         public void Send(string file, string state)
         {
             Random r = new Random();
             sl = r.Next(10, 100);
             Thread.Sleep(sl * slep);
             //sv.Get_info(file, state);
         }
    }
}

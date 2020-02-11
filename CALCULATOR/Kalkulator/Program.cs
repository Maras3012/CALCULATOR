using System;                                                       //omogucuje nam koristenje metoda iz System namespace bez da moramo svaki put pisati rijec System
using System.Collections.Generic;                                   //omogucuju stvaranje jakih tipiziranih zbirki koje pruzaju bolju vrstu sigurnosti i performansi od ne generickih kolekcija
using System.Linq;                                                  //omogucava klase i sucelja za potporu LINQ upita
using System.Windows.Forms;                                         //sadrzava klase za windows forms applications 

namespace Kalkulator                                                //namespace se koristi za organiziranje klasa a Calculator je ime programa
{
    static class Program                                            //staticka klasa moze samo sadrzavati staticke metode i varijable
    {
        [STAThread]                                                 //omogucava komunikaciju izmedu djelova programa
        static void Main()                                          //staticka klasa moze samo sadrzavati staticke metode i varijable
        {
            Application.EnableVisualStyles();                       //omogucava vizualni dio programa
            Application.SetCompatibleTextRenderingDefault(false);   //default vrijednosti za nove kontrole stavlja na false
            Application.Run(new Form1());                          //pokrece Form1
        }
    }
}

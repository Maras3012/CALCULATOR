using System;                               //omogucuje nam koristenje metoda iz System namespace bez da moramo svaki put pisati rijec System           
using System.Collections.Generic;           //omogucuju stvaranje jakih tipiziranih zbirki koje pruzaju bolju vrstu sigurnosti i performansi od ne generickih kolekcija
using System.ComponentModel;                //omogucava klase koje se koriste za implementiranje run-time i design-time za komponente i kontrole
using System.Data;                          //olaksava koristenje podataka iz vise izvora
using System.Drawing;                       //omogucuje pristup GDI basic grafici
using System.Linq;                          //omogucava klase i sucelja za potporu LINQ upita
using System.Text;                          //abstraktne klase za pretvorbu blokova karaktera u blokove bitova
using System.Windows.Forms;                 //sadrzava klase za windows forms applications
using System.IO;                            //za funkciju File.WriteAllText pomocu koje pisemo u file

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        Double Rezultat = 0;                //ovdje spremamo rezultat
        String Operacija = "";              //ovdje spremamo operaciju koja je unesena na GUI-u
        bool JeliOperacija = false;         //ovaj bool sprema false ako niti jedna operacija nije izvrsena i obrnuto
        public Form1()
        {
            InitializeComponent();          //stvori je sam Windows Form Designer i tako konfiguira komponente
        }

        private void tipka_click(object sender, EventArgs e)
        {
            if ((Ekran_Rezultat.Text == "0") || (JeliOperacija))         //ako je nula na pocetku ili je pritisnuta neka operacija onda prvo ocistimo textBox_Result
                Ekran_Rezultat.Clear();                                  //funkcija clear() cisti  textBox_Result

            JeliOperacija = false;
            Button tipka = (Button)sender;
            if (tipka.Text == ".")      //dodaje tocku te tako omogucuje decimalni zapis
            {
                if (!Ekran_Rezultat.Text.Contains("."))       //ogranicava da ne mozemo vise od jedne tocke
                    Ekran_Rezultat.Text = Ekran_Rezultat.Text + tipka.Text;

            }
            else Ekran_Rezultat.Text = Ekran_Rezultat.Text + tipka.Text;


        }

        private void operacija_click(object sender, EventArgs e)
        {
            Button tipka = (Button)sender;

            if (Rezultat != 0)      //pomocu ovoga if-else-a odradi prijasnju operaciju ako smo stisnuli sljedecu
            {
                tipka19.PerformClick();     //tipka jednako je tipka19
                Operacija = tipka.Text;     //spremimo operaciju u Operacija
                JeliOperacija = true;       //postavimo da je odradena neka operacija
            }
            else
            {

                Operacija = tipka.Text;                             //spremimo operaciju u Operacija
                Rezultat = Double.Parse(Ekran_Rezultat.Text);       //Double.Parse pretvara Ekran_Rezultat u double
                JeliOperacija = true;                               //postavimo da je odradena neka operacija
            }
        }

        private void operacija11_click(object sender, EventArgs e)      //tipka DEL brise sadrzaj Ekran_Rezultat.Text
        {
            Ekran_Rezultat.Text = "0";
        }

        private void operacija13_click(object sender, EventArgs e)      ////tipka AC brise sadrzaj Ekran_Rezultat.Text i postavlja rezultat na nulu
        {
            Ekran_Rezultat.Text = "0";
            Rezultat = 0;
        }

        private void operacija10_click(object sender, EventArgs e)      //sender sadrzava referencu na objekt koji je napravio neku radnju
        {
            switch (Operacija)
            {
                case "+":       //zbraja
                    Ekran_Rezultat.Text = (Rezultat + Double.Parse(Ekran_Rezultat.Text)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "-":       //oduzima
                    Ekran_Rezultat.Text = (Rezultat - Double.Parse(Ekran_Rezultat.Text)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "*":       //mnozi
                    Ekran_Rezultat.Text = (Rezultat * Double.Parse(Ekran_Rezultat.Text)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "/":       //dijeli
                    Ekran_Rezultat.Text = (Rezultat / Double.Parse(Ekran_Rezultat.Text)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "√":       //prvo unesemo broj koji zelimo korijenovati pa onda korijen
                    Ekran_Rezultat.Text = (Math.Sqrt(Rezultat)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "π":      //mnozi sa 3.14159
                    Ekran_Rezultat.Text = (Rezultat * 3.14159).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "SIN":     //u radijanima ispisuje
                    Ekran_Rezultat.Text = (Math.Sin(Rezultat)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "COS":     //u radijanima ispisuje           
                    Ekran_Rezultat.Text = (Math.Cos(Rezultat)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "TAN":      //u radijanima ispisuje
                    Ekran_Rezultat.Text = (Math.Sin(Rezultat) / Math.Cos(Rezultat)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "CTG":      //u radijanima ispisuje
                    Ekran_Rezultat.Text = (Math.Cos(Rezultat) / Math.Sin(Rezultat)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "BIN":      //u binarni pretvara
                    Ekran_Rezultat.Text = (Convert.ToString((Int64)Rezultat, 2)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                case "HEX":      //u heksadecimalni pretvara
                    Ekran_Rezultat.Text = (Convert.ToString((Int64)Rezultat, 16)).ToString();
                    File.WriteAllText(@"C:\Users\Korisnik\Desktop\Kalkulator\Rezultati.txt", Ekran_Rezultat.Text);
                    break;
                default:
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)     //ovo program sam stvori
        {

        }
    }
}
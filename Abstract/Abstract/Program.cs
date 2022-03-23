using System;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Code Academyde tehsil aliram";
            string example = "sil aliram";
            int i = 0;
            foreach (char b in sentence)
            {
                if (i != sentence.Length)
                {
                    if (b == sentence[i])
                    { i++; }
                    else if (b != sentence[i])
                        i = 0;
                }
                else break;
            }
            if (i == sentence.Length)
            { Console.WriteLine("True"); }
            else
            { Console.WriteLine("False"); }

            //---------------------------------------------------------------
            EmailSender emailSender = new EmailSender();
            //emailSender.SendMessage();
            SmsSender smsSender = new SmsSender();
            //smsSender.SendMessage();
            
            Console.WriteLine("1. E-Mail message:");
            Console.WriteLine("2.SmS message:");
            Console.WriteLine("0.Exit:");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Mesaj e-Mailinize gonderilib.");
                    break;
                case 2:
                    Console.WriteLine("Mesaj SmS vasitesi ile gonderilib.");
                    break;
                case 0:
                    break;

            }


        }
    }
}

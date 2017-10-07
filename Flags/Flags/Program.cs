using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            /*
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            // Add some elements to the dictionary. There are no 
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            */
            //enum Country_Names {afghanistan, albania, algeria, andorra, angola, antigua_and_barbuda, argentina, armenia, australia, austria, azerbaijan};
            
            Dictionary<string, Image> Flaglist = new Dictionary<string, Image>();
            
            {
                Image F_Afghanistan = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Afghanistan.png");
                Image F_Albania = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Albania.png");
                Image F_Algeria = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Algeria.png");
                Image F_Andorra = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Andorra.png");
                Image F_Angola = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Angola.png");
                Image F_Antigua_Barbuda = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Antigua_Barbuda.png");
                Image F_Argentina = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Argentina.png");
                Image F_Armenia = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Armenia.png");
                Image F_Australia = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Australia.png");
                Image F_Austria = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Austria.png");
                Image F_Azerbaijan = Image.FromFile(@"H:\IT V-T\Csharp\Flags\Flags\Images\Azerbaijan.png");

                Flaglist.Add("afghanistan", F_Afghanistan);
                Flaglist.Add("albania", F_Afghanistan);
                Flaglist.Add("algeria", F_Afghanistan);
                Flaglist.Add("andorra", F_Afghanistan);
                Flaglist.Add("angola", F_Afghanistan);
                Flaglist.Add("antigua and barbuda", F_Afghanistan);
                Flaglist.Add("argentina", F_Afghanistan);
                Flaglist.Add("armenia", F_Afghanistan);
                Flaglist.Add("australia", F_Afghanistan);
                Flaglist.Add("austria", F_Afghanistan);
                Flaglist.Add("azerbaijan", F_Afghanistan);
                //Flaglist.Add("australia", F_Afghanistan);
                
            }
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

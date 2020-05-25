using AppEContact.WinForm.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEContact.WinForm
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MemoryStream ms = new MemoryStream();
            Bitmap bmp = Properties.Resources._default;
            bmp.Save(ms, bmp.RawFormat);
            byte[] img = ms.ToArray();

            DBContact.AddContact(new Contact("APETSI Ange E", DateTime.Parse("01/01/2001"), "leaderangeemmanuel@gmail.com", "47 26 80 43", "M", img));
            DBContact.AddContact(new Contact("KOUAME Wilfried", DateTime.Parse("23/10/2002"), "alltech.ci@gmail.com", "09 96 28 06", "M", img));
            DBContact.AddContact(new Contact("OUATTARA Ibrahima", DateTime.Parse("16/09/1999"), "ouattaraib@gmail.com", "47 11 02 33", "M", img));
            DBContact.AddContact(new Contact("ZADJI Rebecca", DateTime.Parse("31/01/2003"), "rebeccazadji@gmail.com", "51 16 83 23", "F", img));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
}

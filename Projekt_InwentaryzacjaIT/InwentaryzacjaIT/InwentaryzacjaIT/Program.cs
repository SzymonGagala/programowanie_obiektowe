using System;
using System.Windows.Forms;
using InwentaryzacjaIT.Forms;

namespace InwentaryzacjaIT
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new Form1());
        }
    }
}
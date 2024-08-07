using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CESAMKinematics;
using System.Diagnostics;
namespace CESAM_HMI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            /* Kinematics cKinematicModel = new Kinematics(200.5, 256, 256, 36.2);
             Matrix matrix = cKinematicModel.ForwardKinematics(0, 0, 00, 0, 0, 0);
             Console.WriteLine(matrix.ToString());*/

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SplashScreen sc = new SplashScreen();
            if(sc.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Exit();
            }

            
             
            
        }

    }
}

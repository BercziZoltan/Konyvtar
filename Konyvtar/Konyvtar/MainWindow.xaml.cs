using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Konyvtar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Adatok
        {
            public int ID { get; set; }
            public string szerzo { get; set; }
            public string cim { get; set; }
            public string ev { get; set; }
            public string kiado { get; set; }
            public bool ig { get; set; }
            public Adatok(string sor)
            {
                string[] resz = sor.Split(';');
                ID = Convert.ToInt32(resz[0]);
                szerzo = resz[1];
                cim = resz[2];
                ev = resz[3];
                kiado = resz[4];
                ig = Convert.ToBoolean(resz[5]);

            }
        }
        class Adatok2
        {
            public int olvasID { get; set; }
            public string nev { get; set; }
            public DateTime szul { get; set; }
            public int szam { get; set; }
            public string telepules { get; set; }
            public string utca { get; set; }
            public Adatok2(string sor)
            {
                string[] resz = sor.Split(';');
                olvasID = Convert.ToInt32(resz[0]);
                nev = resz[1];
                szul = Convert.ToDateTime(resz[2]);
                szam = Convert.ToInt32(resz[3]);
                telepules = resz[4];
                utca = resz[5];
            }
            foreach (var item in File.ReadAllLines("tagok.txt"))
            {
                l2.Add(new Adatok2(item));
                Tag.ItemsSource = l2;
                Tag.AutoGenerateColumns = false;
            }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

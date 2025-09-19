using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using System.Windows.Threading;

namespace MonProjet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            BtnDashboard.Click += (s, e) => MainFrame.Navigate(new DashboardPage());
            BtnPointageArrivee.Click += (s, e) => MainFrame.Navigate(new PointageArriveeDepart());
            BtnPointageSurveillance.Click += (s, e) => MainFrame.Navigate(new PointageArriveeDepart());
            BtnEmploiTemps.Click += (s, e) => MainFrame.Navigate(new Edt());
            BtnClasse.Click += (s, e) => MainFrame.Navigate(new GestionMatieres());
            BtnHistoriqueAbsences.Click += (s, e) => MainFrame.Navigate(new HistoriqueAbs());
            BtnRapportPonctualite.Click += (s, e) => MainFrame.Navigate(new RapportPonctualite());
            BtnStatistiques.Click += (s, e) => MainFrame.Navigate(new Stat());
            BtnProfilsEnseignants.Click += (s, e) => MainFrame.Navigate(new PointagePage());
            BtnParametres.Click += (s, e) => MainFrame.Navigate(new Parametres());

            MainFrame.Navigate(new DashboardPage());
        }

    }
}

﻿using System;
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
using Model.Business;
using Model.DATA;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DBAL thedbal;
        private daoEquipe daoE;
        private daoJoueur daoJ;
        private daoPays daoPA;
        private daoPoste daoPO;
        private List<Equipe> theequipe;
        private List<Joueur> thejoueur;
        private List<Pays> thepays;
        private List<Poste> theposte;


        public MainWindow(daoEquipe thedaoequipe,daoJoueur thedaojoueur,daoPays thedaopays,daoPoste thedaoposte)
        {
            InitializeComponent();
           Globale.DataContext = new ClubfootApp.viewModel.viewModelJoueur(thedaoequipe,thedaojoueur,thedaopays,thedaoposte);

        }
        // public MainWindow()
        //{
        //    InitializeComponent();
        //}

       
    }
}

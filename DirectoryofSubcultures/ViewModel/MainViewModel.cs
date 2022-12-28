using DirectoryofSubcultures.View;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace DirectoryofSubcultures.ViewModel
{
    internal class MainViewModel : ViewModelClass
    {
        private Page Subculture = new subculture();
        private Page Emo = new emo();
        private Page Goth = new goths();
        private Page Hippies = new hippies();
        private Page Metallist = new metallist();
        private Page Mods = new mods();
        private Page NewAge = new new_age();
        private Page Punk = new punks();
        private Page Rastafarians = new rastafarians();
        private Page Rock = new rock();
        private Page TraditionalSkinheads = new traditional_skinheads();
        private Page Bikers = new bikers();
        private Page Alternative = new alternative();
        private Page Spravka = new spravka();

        private Page _CurPage = new subculture();

        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenSubculturePage
            {
                get
                {
                return new RelayCommand(() => CurPage = Subculture);
                }

            }
        public ICommand OpenAlternativePage
        {
            get
            {
                return new RelayCommand(() => CurPage = Alternative);
            }

        }
        public ICommand OpenBikersPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Bikers);
            }

        }
        public ICommand OpenEmoPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Emo);
            }

        }
        public ICommand OpenGothPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Goth);
            }

        }
        public ICommand OpenHippiesPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Hippies);
            }

        }
        public ICommand OpenMetallistPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Metallist);
            }

        }
        public ICommand OpenModsPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Mods);
            }

        }
        public ICommand OpenNewAgePage
        {
            get
            {
                return new RelayCommand(() => CurPage = NewAge);
            }

        }
        public ICommand OpenPunksPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Punk);
            }

        }
        public ICommand OpenRastafariansPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Rastafarians);
            }

        }
        public ICommand OpenRockPage
        {
            get
            {
                return new RelayCommand(() => CurPage = Rock);
            }

        }
        public ICommand OpenTraditionalSkinheadsPage
        {
            get
            {
                return new RelayCommand(() => CurPage = TraditionalSkinheads);
            }

        }
        public ICommand OpenSpravkaPage
        {
            get 
            {
                return new RelayCommand(() => CurPage = Spravka);
            }
        }
        

    }

}

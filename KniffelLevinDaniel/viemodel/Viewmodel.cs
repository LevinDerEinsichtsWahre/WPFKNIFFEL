using KniffelLevinDaniel.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KniffelLevinDaniel.viemodel
{
    class Viewmodel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand NeuWürfeln { get; private set; }

        public List<Dice> Dices { get; private set; }

        public string Dice1Text
        {
            get
            {
                return "1";
            }

            private set { }
        }

        private string dice2Text;

        public string Dice2Text
        {
            get 
            { 
                return dice2Text; 
            }
            set 
            { 
                dice2Text = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Dice2Text)));
            }
        }

        public string Dice3Text
        {
            get
            {
                return "1";
            }

            private set { }
        }

        public string Dice4Text
        {
            get
            {
                return "1";
            }

            private set { }
        }

        public string Dice5Text
        {
            get
            {
                return "1";
            }

            private set { }
        }



    }
}

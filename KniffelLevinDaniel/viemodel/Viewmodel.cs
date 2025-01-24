using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                return "1"
            }

            private set;
        }

        public string Dice2Text
        {
            get
            {
                return "1"
            }

            private set;
        }

        public string Dice3Text
        {
            get
            {
                return "1"
            }

            private set;
        }

        public string Dice4Text
        {
            get
            {
                return "1"
                }

            private set;
        }

        public string Dice5Text
        {
            get
            {
                return "1"
                }

            private set;
        }

        public MainViewModel()
        {
            this.NeuWürfeln = new NeuWürfeln(this);
        }

    }
}

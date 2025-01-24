using KniffelLevinDaniel.commands;
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
        public Viewmodel()
        {
            NeuWürfeln= new NeuWürfeln(this);
            Dices = new List<Dice>();
            for (int i = 0; i < 5; i++) {Dices.Add(new Dice());}
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand NeuWürfeln { get; private set; }

        public List<Dice> Dices { get; private set; }

        
        public string Dice1Text
        {
            get
            {
                return Dices[0].Value.ToString() ;
            }

            private set {}
        }

        

        public string Dice2Text
        {
            get 
            { 
                return Dices[1].Value.ToString(); 
            }
           private set 
            { 
                //dice2Text = value;
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Dice2Text)));
            }
        }

        public string Dice3Text
        {
            get
            {
                return Dices[2].Value.ToString();
            }

            private set { }
        }

        public string Dice4Text
        {
            get
            {
                return Dices[3].Value.ToString();
            }

            private set { }
        }

        public string Dice5Text
        {
            get
            {
                return Dices[4].Value.ToString();
            }

            private set { }
        }



    }
}

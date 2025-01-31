using KniffelLevinDaniel.commands;
using KniffelLevinDaniel.model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace KniffelLevinDaniel.viemodel
{
    class Viewmodel : INotifyPropertyChanged
    {
        public Viewmodel()
        {
            NeuWürfeln = new NeuWürfeln(this);
            Dices = new ObservableCollection<Dice>();
            for (int i = 0; i < 5; i++)
            {
                Dices.Add(new Dice());
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ICommand NeuWürfeln { get; private set; }

        public ObservableCollection<Dice> Dices { get; private set; }

        public string Dice1Text => Dices[0].Value.ToString();
        public string Dice2Text => Dices[1].Value.ToString();
        public string Dice3Text => Dices[2].Value.ToString();
        public string Dice4Text => Dices[3].Value.ToString();
        public string Dice5Text => Dices[4].Value.ToString();

        public void UpdateDiceValues()
        {
            OnPropertyChanged(nameof(Dice1Text));
            OnPropertyChanged(nameof(Dice2Text));
            OnPropertyChanged(nameof(Dice3Text));
            OnPropertyChanged(nameof(Dice4Text));
            OnPropertyChanged(nameof(Dice5Text));
        }

    }
}

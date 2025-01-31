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
        public ICommand NeuWürfeln { get; private set; }
        public ICommand LockDice { get; private set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public ObservableCollection<Dice> Dices { get; private set; }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Viewmodel()
        {
            LockDice = new LockDice(this);
            NeuWürfeln = new NeuWürfeln(this);
            Dices = new ObservableCollection<Dice>();
            for (int i = 0; i < 5; i++)
            {
                Dices.Add(new Dice());
            }
        }

        //Dice Methods for the UI 
        public string Dice1Text => FormatDiceText(0);
        public string Dice2Text => FormatDiceText(1);
        public string Dice3Text => FormatDiceText(2);
        public string Dice4Text => FormatDiceText(3);
        public string Dice5Text => FormatDiceText(4);

        private string FormatDiceText(int index)
        {
            return Dices[index].IsLocked ? $"[{Dices[index].Value}]" : Dices[index].Value.ToString();
        }

        public void UpdateDiceValues()
        {
            OnPropertyChanged(nameof(Dice1Text));
            OnPropertyChanged(nameof(Dice2Text));
            OnPropertyChanged(nameof(Dice3Text));
            OnPropertyChanged(nameof(Dice4Text));
            OnPropertyChanged(nameof(Dice5Text));
        }

        
        public void ToggleDiceLock(int index)
        {
            Dices[index].ToggleLock();
            UpdateDiceValues();
        }
    }
}

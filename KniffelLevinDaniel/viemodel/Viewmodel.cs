using KniffelLevinDaniel.commands;
using KniffelLevinDaniel.model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace KniffelLevinDaniel.viemodel
{
    public class Viewmodel : INotifyPropertyChanged
    {
        public ICommand NeuWürfeln { get; private set; }
        public ICommand LockDice { get; private set; }

        public Game game;

        public Player PlayerOne;

        public Player PlayerTwo;

        public event PropertyChangedEventHandler? PropertyChanged;
        public ObservableCollection<Dice> Dices { get; private set; }

        public String onePlayerOne;

        public String twoPlayerOne;

        public String threePlayerOne;

        public String fourPlayerOne;

        public String fivePlayerOne;

        public String sixPlayerOne;

        public String bonusPlayerOne;

        public String allUpPlayerOne;

        public String threeOfAKindPlayerOne;

        public String fourOfAKindPlayerOne;

        public String fullHousePlayerOne;

        public String smallStreetPlayerOne;

        public String bigStreetPlayerOne;

        public String kniffelPlayerOne;

        public String chancePlayerOne;

        public String allDownPlayerOne;

        public String allPlayerOne;

        public String onePlayerTwo;

        public String twoPlayerTwo;

        public String threePlayerTwo;

        public String fourPlayerTwo;

        public String fivePlayerTwo;

        public String sixPlayerTwo;

        public String bonusPlayerTwo;

        public String allUpPlayerTwo;

        public String threeOfAKindPlayerTwo;

        public String fourOfAKindPlayerTwo;

        public String fullHousePlayerTwo;

        public String smallStreetPlayerTwo;

        public String bigStreetPlayerTwo;

        public String kniffelPlayerTwo;

        public String chancePlayerTwo;

        public String allDownPlayerTwo;

        public String allPlayerTwo;
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
            PlayerOne = new Player(Dices);
            PlayerTwo = new Player(Dices);
            List<Player> players = new List<Player> { PlayerOne, PlayerTwo };
            game = new Game(players, this);
        }

        //Dice Methods for the UI 
        public string Dice1Text => FormatDiceText(0);
        public string Dice2Text => FormatDiceText(1);
        public string Dice3Text => FormatDiceText(2);
        public string Dice4Text => FormatDiceText(3);
        public string Dice5Text => FormatDiceText(4);

        private string FormatDiceText(int index)
        {
            return Dices[index].IsLocked ? $"{Dices[index].Value}" : Dices[index].Value.ToString();
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
        }
    }
}

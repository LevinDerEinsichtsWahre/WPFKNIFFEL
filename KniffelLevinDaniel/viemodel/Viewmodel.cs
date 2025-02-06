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

        public string onePlayerOne { get;  set; }
        public string twoPlayerOne { get;  set; }
        public string threePlayerOne { get;  set; }
        public string fourPlayerOne { get;  set; }
        public string fivePlayerOne { get;  set; }
        public string sixPlayerOne { get;  set; }
        public string bonusPlayerOne { get;  set; }
        public string allUpPlayerOne { get;  set; }
        public string threeOfAKindPlayerOne { get;  set; }
        public string fourOfAKindPlayerOne { get;  set; }
        public string fullHousePlayerOne { get;  set; }
        public string smallStreetPlayerOne { get;  set; }
        public string bigStreetPlayerOne { get;  set; }
        public string kniffelPlayerOne { get;  set; }
        public string chancePlayerOne { get;  set; }
        public string allDownPlayerOne { get;  set; }
        public string allPlayerOne { get;  set; }
        public string onePlayerTwo { get;  set; }
        public string twoPlayerTwo { get;  set; }
        public string threePlayerTwo { get;  set; }
        public string fourPlayerTwo { get;  set; }
        public string fivePlayerTwo { get;  set; }
        public string sixPlayerTwo { get;  set; }
        public string bonusPlayerTwo { get;  set; }
        public string allUpPlayerTwo { get;  set; }
        public string threeOfAKindPlayerTwo { get;  set; }
        public string fourOfAKindPlayerTwo { get;  set; }
        public string fullHousePlayerTwo { get;  set; }
        public string smallStreetPlayerTwo { get;  set; }
        public string bigStreetPlayerTwo { get;  set; }
        public string kniffelPlayerTwo { get;  set; }
        public string chancePlayerTwo { get;  set; }
        public string allDownPlayerTwo { get;  set; }
        public string allPlayerTwo { get; set; }
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
            PlayerOne = new Player(Dices, this, "One");
            PlayerTwo = new Player(Dices, this, "Two");
            List<Player> players = new List<Player> { PlayerOne, PlayerTwo };
            game = new Game(players, this);
            onePlayerOne = "0";
            twoPlayerOne = "0";
            threePlayerOne = "0";
            fourPlayerOne = "0";
            fivePlayerOne = "0";
            sixPlayerOne = "0";
            bonusPlayerOne = "0";
            allUpPlayerOne = "0";
            threeOfAKindPlayerOne = "0";
            fourOfAKindPlayerOne = "0";
            fullHousePlayerOne = "0";
            smallStreetPlayerOne = "0";
            bigStreetPlayerOne = "0";
            kniffelPlayerOne = "0";
            chancePlayerOne = "0";
            allDownPlayerOne = "0";
            allPlayerOne = "0";
            onePlayerTwo = "0";
            twoPlayerTwo = "0";
            threePlayerTwo = "0";
            fourPlayerTwo = "0";
            fivePlayerTwo = "0";
            sixPlayerTwo = "0";
            bonusPlayerTwo = "0";
            allUpPlayerTwo = "0";
            threeOfAKindPlayerTwo = "0";
            fourOfAKindPlayerTwo = "0";
            fullHousePlayerTwo = "0";
            smallStreetPlayerTwo = "0";
            bigStreetPlayerTwo = "0";
            kniffelPlayerTwo = "0";
            chancePlayerTwo = "0";
            allDownPlayerTwo = "0";
            allPlayerTwo = "0";
        }

        //Dice Methods for the UI 
        public string Dice1Text => FormatDiceText(0);
        public string Dice2Text => FormatDiceText(1);
        public string Dice3Text => FormatDiceText(2);
        public string Dice4Text => FormatDiceText(3);
        public string Dice5Text => FormatDiceText(4);

        private string FormatDiceText(int index)
        {
            return Dices[index].Value.ToString();
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

        public void updateTextUi()
        {
            OnPropertyChanged(nameof(onePlayerOne));

            OnPropertyChanged(nameof(twoPlayerOne));

            OnPropertyChanged(nameof(threePlayerOne));

            OnPropertyChanged(nameof(fourPlayerOne));

            OnPropertyChanged(nameof(fivePlayerOne));

            OnPropertyChanged(nameof(sixPlayerOne));

            OnPropertyChanged(nameof(bonusPlayerOne));

            OnPropertyChanged(nameof(allUpPlayerOne));

            OnPropertyChanged(nameof(threeOfAKindPlayerOne));

            OnPropertyChanged(nameof(fourOfAKindPlayerOne));

            OnPropertyChanged(nameof(fullHousePlayerOne));

            OnPropertyChanged(nameof(smallStreetPlayerOne));

            OnPropertyChanged(nameof(bigStreetPlayerOne));

            OnPropertyChanged(nameof(kniffelPlayerOne));

            OnPropertyChanged(nameof(chancePlayerOne));

            OnPropertyChanged(nameof(allDownPlayerOne));

            OnPropertyChanged(nameof(allPlayerOne));

            OnPropertyChanged(nameof(onePlayerTwo));

            OnPropertyChanged(nameof(twoPlayerTwo));

            OnPropertyChanged(nameof(threePlayerTwo));

            OnPropertyChanged(nameof(fourPlayerTwo));

            OnPropertyChanged(nameof(fivePlayerTwo));

            OnPropertyChanged(nameof(sixPlayerTwo));

            OnPropertyChanged(nameof(bonusPlayerTwo));

            OnPropertyChanged(nameof(allUpPlayerTwo));

            OnPropertyChanged(nameof(threeOfAKindPlayerTwo));

            OnPropertyChanged(nameof(fourOfAKindPlayerTwo));

            OnPropertyChanged(nameof(fullHousePlayerTwo));

            OnPropertyChanged(nameof(smallStreetPlayerTwo));

            OnPropertyChanged(nameof(bigStreetPlayerTwo));

            OnPropertyChanged(nameof(kniffelPlayerTwo));

            OnPropertyChanged(nameof(chancePlayerTwo));

            OnPropertyChanged(nameof(allDownPlayerTwo));

            OnPropertyChanged(nameof(allPlayerTwo));
        }

    }
}

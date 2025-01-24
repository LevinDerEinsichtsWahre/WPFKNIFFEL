using KniffelLevinDaniel.viemodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KniffelLevinDaniel.commands
{
    internal class NeuWürfeln: Command
    {
        

        public NeuWürfeln(Viewmodel viewModel) : base(viewModel)
        {
            
        }

        public override void Execute(object parameter)
        {
            foreach (var dice in viewModel.Dices)
            {
                 dice.Roll().ToString();
            }
        }
    }
}

using KniffelLevinDaniel.viemodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KniffelLevinDaniel.commands
{
    internal class LockDice : Command
    {
        private readonly Viewmodel _viewModel;
        public LockDice(Viewmodel viewModel) : base(viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            int index = Convert.ToInt32(parameter);
            _viewModel.ToggleDiceLock(index);

        }
    }
}

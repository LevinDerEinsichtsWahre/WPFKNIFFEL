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

        public bool CanExecute(object? parameter)
        {
            return parameter is int;
        }

        public override void Execute(object parameter)
        {
            if (parameter is int index)
            {
                _viewModel.ToggleDiceLock(index);
            }
        }
    }
}

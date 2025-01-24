public class NeuWürfeln: Commands()
{

    private MainViewModel mainViewModel;

    public NeuWürfeln(MainViewModel viewModel) : base(viewModel)
    {
        mainViewModel = viewModel;
    }

    public override void Execute(object parameter)
    {
        foreach (var dice in mainViewModel.Dices)
        {
            dice.Reroll()
            }
    }

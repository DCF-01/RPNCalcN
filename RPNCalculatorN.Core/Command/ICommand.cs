namespace RPNCalculatorN.Core.Command;

public interface ICommand
{
    int State { get; }
    void Execute();
}
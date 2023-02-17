using RPNCalculatorN.Core.Command;

namespace RPNCalculatorN.Core.Memento;

public class CommandStackMemento
{
    private Stack<ICommand> _state;
    public CommandStackMemento(Stack<ICommand> state)
    {
        var newList = new Stack<ICommand>();
        
        foreach (var cmd in _state)
        {
            newList.Push(cmd);
        }

        _state = newList;
    }

    public Stack<ICommand> GetState()
    {
        return _state;
    }
}
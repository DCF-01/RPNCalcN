using RPNCalculatorN.Core.Command;

namespace RPNCalculatorN.Core.Memento;

public class CommandStack
{
    private Stack<ICommand> _state;

    public CommandStackMemento Save()
    {
        return new CommandStackMemento(_state);
    }

    public void Restore(CommandStackMemento memento)
    {
        this._state = memento.GetState();
    }
}
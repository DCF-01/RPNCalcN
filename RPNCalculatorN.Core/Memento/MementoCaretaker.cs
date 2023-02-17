namespace RPNCalculatorN.Core.Memento;

public class MementoCaretaker
{
    private static ICollection<CommandStackMemento> _collectionMementoes;
    private static int _currentPosition = 0;
    private MementoCaretaker()
    {
        _collectionMementoes = new List<CommandStackMemento>();
    }

    public static CommandStackMemento Undo()
    {
        if (_currentPosition < 0)
        {
            return _collectionMementoes.ElementAt(0);
        }

        _currentPosition -= 1;
        return _collectionMementoes.ElementAt(_currentPosition);
    }
    
    public static CommandStackMemento Redo()
    {
        if (_currentPosition > _collectionMementoes.Count - 1)
        {
            return _collectionMementoes.ElementAt(_collectionMementoes.Count - 1);
        }

        _currentPosition += 1;
        return _collectionMementoes.ElementAt(_currentPosition);
    }
}
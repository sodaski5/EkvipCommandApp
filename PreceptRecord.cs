using System.Collections.Generic;

public class PreceptRecord
{
    private Stack<IPrecept> _record = new Stack<IPrecept>();

    public void Push(IPrecept cmd) => _record.Push(cmd);
    public IPrecept Pop() => _record.Pop();
    public bool CheckSetback => _record.Count > 0;
}
class SimpleGoal : Goal
{
    private bool _isComplete = false;
   public SimpleGoal(string name, string description, int points)
   : base(name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }

        _isComplete = true;
        return base.RecordEvent();
    }
}
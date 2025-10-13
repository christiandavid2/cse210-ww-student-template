using System;


public class SimpleGoal : Goal
    {
        private bool _isComplete = false;

        public SimpleGoal(string name, string description, int points)
            : base(name, description, points)
        {
            // _isComplete defaults to false (new goals are not complete)
        }

        public override int RecordEvent()
        {
            if (_isComplete)
            {
                Console.WriteLine("This goal is already complete. No points awarded.");
                return 0;
            }
            _isComplete = true;
            return PointsPerEvent;
        }

        public override bool IsComplete() => _isComplete;

        public override string GetDetailsString()
        {
            string status = IsComplete() ? "[X]" : "[ ]";
            return $"{status} {Name} ({Description}) - Worth {PointsPerEvent} points";
        }

        public override string ToSaveString()
        {
            // Format: Simple|name|desc|points|isComplete
            return $"Simple|{Escape(Name)}|{Escape(Description)}|{PointsPerEvent}|{_isComplete}";
        }

        // helper for escaping save fields
        private static string Escape(string s) => s.Replace("|", "¦"); // replace pipe to avoid collision
    }

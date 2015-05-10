namespace NRules.RuleModel
{
    /// <summary>
    /// Action that aggregation performed on the aggregate, based on added/modified/removed facts.
    /// </summary>
    public enum AggregationAction
    {
        /// <summary>
        /// No changes at the aggregate level.
        /// </summary>
        None = 0,

        /// <summary>
        /// New aggregate created.
        /// </summary>
        Added = 1,

        /// <summary>
        /// Existing aggregate modified.
        /// </summary>
        Modified = 2,

        /// <summary>
        /// Existing aggregate removed.
        /// </summary>
        Removed = 3,
    }

    /// <summary>
    /// Result of the aggregation.
    /// </summary>
    public struct AggregationResult
    {
        private readonly AggregationAction _action;
        private readonly object _result;
        public static AggregationResult[] Empty = new AggregationResult[0];

        private AggregationResult(AggregationAction action, object result)
        {
            _action = action;
            _result = result;
        }

        /// <summary>
        /// Constructs an aggregation result that indicates no changes at the aggregate level.
        /// </summary>
        /// <param name="result">Aggregate.</param>
        /// <returns>Aggregation result.</returns>
        public static AggregationResult None(object result)
        {
            return new AggregationResult(AggregationAction.None, result);
        }

        /// <summary>
        /// Constructs an aggregation result that indicates a new aggregate.
        /// </summary>
        /// <param name="result">Aggregate.</param>
        /// <returns>Aggregation result.</returns>
        public static AggregationResult Added(object result)
        {
            return new AggregationResult(AggregationAction.Added, result);
        }

        /// <summary>
        /// Constructs an aggregation result that indicates a modification at the aggregate level.
        /// </summary>
        /// <param name="result">Aggregate.</param>
        /// <returns>Aggregation result.</returns>
        public static AggregationResult Modified(object result)
        {
            return new AggregationResult(AggregationAction.Modified, result);
        }

        /// <summary>
        /// Constructs an aggregation result that indicates an aggregate was removed.
        /// </summary>
        /// <param name="result">Aggregate.</param>
        /// <returns>Aggregation result.</returns>
        public static AggregationResult Removed(object result)
        {
            return new AggregationResult(AggregationAction.Removed, result);
        }

        /// <summary>
        /// Action that aggregation performed on the aggregate.
        /// </summary>
        public AggregationAction Action { get { return _action; } }

        /// <summary>
        /// Aggregation result.
        /// </summary>
        public object Result { get { return _result; } }
    }
}
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NRules.Fluent.Dsl;
using NRules.RuleModel.Builders;

namespace NRules.Fluent.Expressions
{
    internal class CollectPatternExpression<TElement> : LeftHandSideExpression, ICollectPatternExpression<TElement>
    {
        private readonly PatternBuilder _patternBuilder;

        public CollectPatternExpression(RuleBuilder builder, GroupBuilder groupBuilder, PatternBuilder patternBuilder) 
            : base(builder, groupBuilder)
        {
            _patternBuilder = patternBuilder;
        }

        public ILeftHandSideExpression Where(params Expression<Func<IEnumerable<TElement>, bool>>[] conditions)
        {
            _patternBuilder.DslConditions(_patternBuilder.Declarations, conditions);
            return this;
        }
    }
}
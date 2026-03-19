
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTConditionalOperatorNodeOutputConditionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AndOperator,
        /// <summary>
        /// 
        /// </summary>
        BooleanLiteral,
        /// <summary>
        /// 
        /// </summary>
        ConditionalOperator,
        /// <summary>
        /// 
        /// </summary>
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        EqOperator,
        /// <summary>
        /// 
        /// </summary>
        GtOperator,
        /// <summary>
        /// 
        /// </summary>
        GteOperator,
        /// <summary>
        /// 
        /// </summary>
        Llm,
        /// <summary>
        /// 
        /// </summary>
        LtOperator,
        /// <summary>
        /// 
        /// </summary>
        LteOperator,
        /// <summary>
        /// 
        /// </summary>
        NeqOperator,
        /// <summary>
        /// 
        /// </summary>
        NumberLiteral,
        /// <summary>
        /// 
        /// </summary>
        OrOperator,
        /// <summary>
        /// 
        /// </summary>
        StringLiteral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ASTConditionalOperatorNodeOutputConditionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTConditionalOperatorNodeOutputConditionDiscriminatorType value)
        {
            return value switch
            {
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.AndOperator => "and_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.EqOperator => "eq_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.GtOperator => "gt_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.GteOperator => "gte_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.Llm => "llm",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.LtOperator => "lt_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.LteOperator => "lte_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.NeqOperator => "neq_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.NumberLiteral => "number_literal",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.OrOperator => "or_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTConditionalOperatorNodeOutputConditionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.AndOperator,
                "boolean_literal" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.ConditionalOperator,
                "dynamic_variable" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.EqOperator,
                "gt_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.GtOperator,
                "gte_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.GteOperator,
                "llm" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.Llm,
                "lt_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.LtOperator,
                "lte_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.LteOperator,
                "neq_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.NeqOperator,
                "number_literal" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.NumberLiteral,
                "or_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.OrOperator,
                "string_literal" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}
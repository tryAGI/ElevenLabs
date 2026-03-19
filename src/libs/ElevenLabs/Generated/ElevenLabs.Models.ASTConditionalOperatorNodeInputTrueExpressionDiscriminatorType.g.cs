
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType
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
    public static class ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType value)
        {
            return value switch
            {
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.AndOperator => "and_operator",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.EqOperator => "eq_operator",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.GtOperator => "gt_operator",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.GteOperator => "gte_operator",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.Llm => "llm",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.LtOperator => "lt_operator",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.LteOperator => "lte_operator",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.NeqOperator => "neq_operator",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.NumberLiteral => "number_literal",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.OrOperator => "or_operator",
                ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.AndOperator,
                "boolean_literal" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.ConditionalOperator,
                "dynamic_variable" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.EqOperator,
                "gt_operator" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.GtOperator,
                "gte_operator" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.GteOperator,
                "llm" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.Llm,
                "lt_operator" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.LtOperator,
                "lte_operator" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.LteOperator,
                "neq_operator" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.NeqOperator,
                "number_literal" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.NumberLiteral,
                "or_operator" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.OrOperator,
                "string_literal" => ASTConditionalOperatorNodeInputTrueExpressionDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}
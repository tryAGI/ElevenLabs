
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType
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
    public static class ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType value)
        {
            return value switch
            {
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.AndOperator => "and_operator",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.EqOperator => "eq_operator",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.GtOperator => "gt_operator",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.GteOperator => "gte_operator",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.Llm => "llm",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.LtOperator => "lt_operator",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.LteOperator => "lte_operator",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.NeqOperator => "neq_operator",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.NumberLiteral => "number_literal",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.OrOperator => "or_operator",
                ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.StringLiteral => "string_literal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "and_operator" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.AndOperator,
                "boolean_literal" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.ConditionalOperator,
                "dynamic_variable" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.EqOperator,
                "gt_operator" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.GtOperator,
                "gte_operator" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.GteOperator,
                "llm" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.Llm,
                "lt_operator" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.LtOperator,
                "lte_operator" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.LteOperator,
                "neq_operator" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.NeqOperator,
                "number_literal" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.NumberLiteral,
                "or_operator" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.OrOperator,
                "string_literal" => ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType.StringLiteral,
                _ => null,
            };
        }
    }
}
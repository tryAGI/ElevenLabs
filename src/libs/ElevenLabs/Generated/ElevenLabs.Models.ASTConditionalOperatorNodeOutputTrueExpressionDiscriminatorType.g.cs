
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AddOperator,
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
        DivOperator,
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
        MulOperator,
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
        /// <summary>
        /// 
        /// </summary>
        SubOperator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType value)
        {
            return value switch
            {
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.AddOperator => "add_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.AndOperator => "and_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.DivOperator => "div_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.EqOperator => "eq_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.GtOperator => "gt_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.GteOperator => "gte_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.Llm => "llm",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.LtOperator => "lt_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.LteOperator => "lte_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.MulOperator => "mul_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.NeqOperator => "neq_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.NumberLiteral => "number_literal",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.OrOperator => "or_operator",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.StringLiteral => "string_literal",
                ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.AddOperator,
                "and_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.AndOperator,
                "boolean_literal" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.EqOperator,
                "gt_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.GtOperator,
                "gte_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.GteOperator,
                "llm" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.Llm,
                "lt_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.LtOperator,
                "lte_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.LteOperator,
                "mul_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.MulOperator,
                "neq_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.NeqOperator,
                "number_literal" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.NumberLiteral,
                "or_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.OrOperator,
                "string_literal" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.StringLiteral,
                "sub_operator" => ASTConditionalOperatorNodeOutputTrueExpressionDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
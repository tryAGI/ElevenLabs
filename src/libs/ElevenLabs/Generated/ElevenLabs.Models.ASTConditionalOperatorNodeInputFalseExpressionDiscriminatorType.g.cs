
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType
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
    public static class ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType value)
        {
            return value switch
            {
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.AddOperator => "add_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.AndOperator => "and_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.DivOperator => "div_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.EqOperator => "eq_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.GtOperator => "gt_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.GteOperator => "gte_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.Llm => "llm",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.LtOperator => "lt_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.LteOperator => "lte_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.MulOperator => "mul_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.NeqOperator => "neq_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.NumberLiteral => "number_literal",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.OrOperator => "or_operator",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.StringLiteral => "string_literal",
                ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.AddOperator,
                "and_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.AndOperator,
                "boolean_literal" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.EqOperator,
                "gt_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.GtOperator,
                "gte_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.GteOperator,
                "llm" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.Llm,
                "lt_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.LtOperator,
                "lte_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.LteOperator,
                "mul_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.MulOperator,
                "neq_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.NeqOperator,
                "number_literal" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.NumberLiteral,
                "or_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.OrOperator,
                "string_literal" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.StringLiteral,
                "sub_operator" => ASTConditionalOperatorNodeInputFalseExpressionDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
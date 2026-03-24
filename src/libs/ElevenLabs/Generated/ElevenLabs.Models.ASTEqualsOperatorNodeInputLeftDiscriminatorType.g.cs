
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTEqualsOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTEqualsOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTEqualsOperatorNodeInputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTEqualsOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTEqualsOperatorNodeInputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
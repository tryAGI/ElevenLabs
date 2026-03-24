
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTMultiplicationOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTMultiplicationOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTMultiplicationOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTMultiplicationOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTMultiplicationOperatorNodeInputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTMultiplicationOperatorNodeInputRightDiscriminatorType
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
    public static class ASTMultiplicationOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTMultiplicationOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.AddOperator => "add_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.DivOperator => "div_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTMultiplicationOperatorNodeInputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTMultiplicationOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTMultiplicationOperatorNodeInputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
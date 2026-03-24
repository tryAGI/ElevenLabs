
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTMultiplicationOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTMultiplicationOperatorNodeOutputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
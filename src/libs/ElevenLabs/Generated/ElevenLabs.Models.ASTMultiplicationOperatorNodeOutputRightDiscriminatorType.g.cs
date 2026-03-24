
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTMultiplicationOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTMultiplicationOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTMultiplicationOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.AddOperator => "add_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.DivOperator => "div_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTMultiplicationOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTMultiplicationOperatorNodeOutputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
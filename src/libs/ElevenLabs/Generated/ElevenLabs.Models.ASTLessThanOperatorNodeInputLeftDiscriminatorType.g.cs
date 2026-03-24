
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTLessThanOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTLessThanOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTLessThanOperatorNodeInputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTLessThanOperatorNodeInputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTNotEqualsOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTNotEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTNotEqualsOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTNotEqualsOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTNotEqualsOperatorNodeInputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
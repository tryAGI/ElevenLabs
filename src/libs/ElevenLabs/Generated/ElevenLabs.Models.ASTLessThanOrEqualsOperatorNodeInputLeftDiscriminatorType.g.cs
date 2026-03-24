
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
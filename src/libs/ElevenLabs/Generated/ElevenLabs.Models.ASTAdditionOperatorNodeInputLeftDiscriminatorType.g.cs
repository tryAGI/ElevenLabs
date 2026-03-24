
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTAdditionOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTAdditionOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTAdditionOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTAdditionOperatorNodeInputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTAdditionOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTAdditionOperatorNodeInputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
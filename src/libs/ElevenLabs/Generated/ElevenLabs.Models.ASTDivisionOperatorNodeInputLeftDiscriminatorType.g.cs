
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTDivisionOperatorNodeInputLeftDiscriminatorType
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
    public static class ASTDivisionOperatorNodeInputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTDivisionOperatorNodeInputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.Llm => "llm",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTDivisionOperatorNodeInputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTDivisionOperatorNodeInputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.GteOperator,
                "llm" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTDivisionOperatorNodeInputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
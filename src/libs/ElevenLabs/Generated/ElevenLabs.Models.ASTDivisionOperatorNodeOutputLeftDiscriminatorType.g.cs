
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTDivisionOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTDivisionOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTDivisionOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTDivisionOperatorNodeOutputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTDivisionOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTDivisionOperatorNodeOutputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
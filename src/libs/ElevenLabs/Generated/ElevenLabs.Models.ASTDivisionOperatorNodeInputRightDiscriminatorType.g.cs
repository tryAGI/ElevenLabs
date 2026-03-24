
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTDivisionOperatorNodeInputRightDiscriminatorType
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
    public static class ASTDivisionOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTDivisionOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTDivisionOperatorNodeInputRightDiscriminatorType.AddOperator => "add_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.DivOperator => "div_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTDivisionOperatorNodeInputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTDivisionOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTDivisionOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTDivisionOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTDivisionOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTDivisionOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTDivisionOperatorNodeInputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTDivisionOperatorNodeInputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
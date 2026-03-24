
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTDivisionOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTDivisionOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTDivisionOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.AddOperator => "add_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.DivOperator => "div_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTDivisionOperatorNodeOutputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTDivisionOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTDivisionOperatorNodeOutputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
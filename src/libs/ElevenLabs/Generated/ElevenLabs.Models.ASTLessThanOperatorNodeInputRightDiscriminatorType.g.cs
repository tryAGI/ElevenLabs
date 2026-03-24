
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTLessThanOperatorNodeInputRightDiscriminatorType
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
    public static class ASTLessThanOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOperatorNodeInputRightDiscriminatorType.AddOperator => "add_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.DivOperator => "div_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTLessThanOperatorNodeInputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTLessThanOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOperatorNodeInputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTLessThanOperatorNodeInputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
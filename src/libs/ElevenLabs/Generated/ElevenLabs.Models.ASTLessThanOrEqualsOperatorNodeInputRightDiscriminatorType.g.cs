
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType
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
    public static class ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.AddOperator => "add_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.DivOperator => "div_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTLessThanOrEqualsOperatorNodeInputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
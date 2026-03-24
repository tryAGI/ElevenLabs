
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTNotEqualsOperatorNodeInputRightDiscriminatorType
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
    public static class ASTNotEqualsOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTNotEqualsOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.AddOperator => "add_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.DivOperator => "div_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTNotEqualsOperatorNodeInputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTNotEqualsOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTNotEqualsOperatorNodeInputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
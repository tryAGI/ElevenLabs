
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTEqualsOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTEqualsOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTEqualsOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.AddOperator => "add_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.DivOperator => "div_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTEqualsOperatorNodeOutputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTEqualsOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTEqualsOperatorNodeOutputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
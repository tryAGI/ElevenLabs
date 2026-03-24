
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AddOperator => "add_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DivOperator => "div_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
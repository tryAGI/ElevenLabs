
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType
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
    public static class ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AddOperator => "add_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator => "and_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DivOperator => "div_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.Llm => "llm",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator => "or_operator",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.GteOperator,
                "llm" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.Llm,
                "lt_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTGreaterThanOrEqualsOperatorNodeOutputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
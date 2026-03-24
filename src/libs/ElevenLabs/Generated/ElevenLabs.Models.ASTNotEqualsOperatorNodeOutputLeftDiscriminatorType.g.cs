
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTNotEqualsOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTNotEqualsOperatorNodeOutputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
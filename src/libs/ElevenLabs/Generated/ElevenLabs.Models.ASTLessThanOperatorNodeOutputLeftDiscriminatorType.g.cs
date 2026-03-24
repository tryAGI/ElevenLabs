
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTLessThanOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTLessThanOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTLessThanOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTLessThanOperatorNodeOutputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTLessThanOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTLessThanOperatorNodeOutputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
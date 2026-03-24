
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTAdditionOperatorNodeOutputLeftDiscriminatorType
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
    public static class ASTAdditionOperatorNodeOutputLeftDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTAdditionOperatorNodeOutputLeftDiscriminatorType value)
        {
            return value switch
            {
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.AddOperator => "add_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.AndOperator => "and_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.DivOperator => "div_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.EqOperator => "eq_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.GtOperator => "gt_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.GteOperator => "gte_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.Llm => "llm",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.LtOperator => "lt_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.LteOperator => "lte_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.MulOperator => "mul_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.NeqOperator => "neq_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.NumberLiteral => "number_literal",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.OrOperator => "or_operator",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.StringLiteral => "string_literal",
                ASTAdditionOperatorNodeOutputLeftDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTAdditionOperatorNodeOutputLeftDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.AddOperator,
                "and_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.AndOperator,
                "boolean_literal" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.EqOperator,
                "gt_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.GtOperator,
                "gte_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.GteOperator,
                "llm" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.Llm,
                "lt_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.LtOperator,
                "lte_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.LteOperator,
                "mul_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.MulOperator,
                "neq_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.NeqOperator,
                "number_literal" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.NumberLiteral,
                "or_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.OrOperator,
                "string_literal" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.StringLiteral,
                "sub_operator" => ASTAdditionOperatorNodeOutputLeftDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
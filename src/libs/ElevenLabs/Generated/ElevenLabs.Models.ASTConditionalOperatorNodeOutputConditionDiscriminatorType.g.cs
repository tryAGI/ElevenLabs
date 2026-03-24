
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTConditionalOperatorNodeOutputConditionDiscriminatorType
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
    public static class ASTConditionalOperatorNodeOutputConditionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTConditionalOperatorNodeOutputConditionDiscriminatorType value)
        {
            return value switch
            {
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.AddOperator => "add_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.AndOperator => "and_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.DivOperator => "div_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.EqOperator => "eq_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.GtOperator => "gt_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.GteOperator => "gte_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.Llm => "llm",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.LtOperator => "lt_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.LteOperator => "lte_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.MulOperator => "mul_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.NeqOperator => "neq_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.NumberLiteral => "number_literal",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.OrOperator => "or_operator",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.StringLiteral => "string_literal",
                ASTConditionalOperatorNodeOutputConditionDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTConditionalOperatorNodeOutputConditionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.AddOperator,
                "and_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.AndOperator,
                "boolean_literal" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.EqOperator,
                "gt_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.GtOperator,
                "gte_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.GteOperator,
                "llm" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.Llm,
                "lt_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.LtOperator,
                "lte_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.LteOperator,
                "mul_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.MulOperator,
                "neq_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.NeqOperator,
                "number_literal" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.NumberLiteral,
                "or_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.OrOperator,
                "string_literal" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.StringLiteral,
                "sub_operator" => ASTConditionalOperatorNodeOutputConditionDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
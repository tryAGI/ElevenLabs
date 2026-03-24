
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTConditionalOperatorNodeInputConditionDiscriminatorType
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
    public static class ASTConditionalOperatorNodeInputConditionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTConditionalOperatorNodeInputConditionDiscriminatorType value)
        {
            return value switch
            {
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.AddOperator => "add_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.AndOperator => "and_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.DivOperator => "div_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.EqOperator => "eq_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.GtOperator => "gt_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.GteOperator => "gte_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.Llm => "llm",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.LtOperator => "lt_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.LteOperator => "lte_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.MulOperator => "mul_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.NeqOperator => "neq_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.NumberLiteral => "number_literal",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.OrOperator => "or_operator",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.StringLiteral => "string_literal",
                ASTConditionalOperatorNodeInputConditionDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTConditionalOperatorNodeInputConditionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.AddOperator,
                "and_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.AndOperator,
                "boolean_literal" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.EqOperator,
                "gt_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.GtOperator,
                "gte_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.GteOperator,
                "llm" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.Llm,
                "lt_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.LtOperator,
                "lte_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.LteOperator,
                "mul_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.MulOperator,
                "neq_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.NeqOperator,
                "number_literal" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.NumberLiteral,
                "or_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.OrOperator,
                "string_literal" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.StringLiteral,
                "sub_operator" => ASTConditionalOperatorNodeInputConditionDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}
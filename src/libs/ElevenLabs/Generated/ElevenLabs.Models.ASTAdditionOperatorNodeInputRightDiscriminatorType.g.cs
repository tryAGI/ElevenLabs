
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ASTAdditionOperatorNodeInputRightDiscriminatorType
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
    public static class ASTAdditionOperatorNodeInputRightDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASTAdditionOperatorNodeInputRightDiscriminatorType value)
        {
            return value switch
            {
                ASTAdditionOperatorNodeInputRightDiscriminatorType.AddOperator => "add_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.AndOperator => "and_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.BooleanLiteral => "boolean_literal",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.ConditionalOperator => "conditional_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.DivOperator => "div_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.DynamicVariable => "dynamic_variable",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.EqOperator => "eq_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.GtOperator => "gt_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.GteOperator => "gte_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.Llm => "llm",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.LtOperator => "lt_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.LteOperator => "lte_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.MulOperator => "mul_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.NeqOperator => "neq_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.NumberLiteral => "number_literal",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.OrOperator => "or_operator",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.StringLiteral => "string_literal",
                ASTAdditionOperatorNodeInputRightDiscriminatorType.SubOperator => "sub_operator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASTAdditionOperatorNodeInputRightDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "add_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.AddOperator,
                "and_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.AndOperator,
                "boolean_literal" => ASTAdditionOperatorNodeInputRightDiscriminatorType.BooleanLiteral,
                "conditional_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.ConditionalOperator,
                "div_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.DivOperator,
                "dynamic_variable" => ASTAdditionOperatorNodeInputRightDiscriminatorType.DynamicVariable,
                "eq_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.EqOperator,
                "gt_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.GtOperator,
                "gte_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.GteOperator,
                "llm" => ASTAdditionOperatorNodeInputRightDiscriminatorType.Llm,
                "lt_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.LtOperator,
                "lte_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.LteOperator,
                "mul_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.MulOperator,
                "neq_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.NeqOperator,
                "number_literal" => ASTAdditionOperatorNodeInputRightDiscriminatorType.NumberLiteral,
                "or_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.OrOperator,
                "string_literal" => ASTAdditionOperatorNodeInputRightDiscriminatorType.StringLiteral,
                "sub_operator" => ASTAdditionOperatorNodeInputRightDiscriminatorType.SubOperator,
                _ => null,
            };
        }
    }
}